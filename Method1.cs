using System;

public static class Method1
{
    public static (double[,], double[,], double[,], int[], double[,], int) LUP(double[,] A, double[,] B)
    {
        int operations = 0;
        (double[,] L, double[,] U, int[] P) = LUPDecomposition(A, ref operations);
        double[,] Y = SolveForY(L, B, P, ref operations);
        double[,] X = SolveForX(U, Y, ref operations);
        return (X, L, U, P, Y, operations);
    }

    public static (double[,], double[,], int[]) LUPDecomposition(double[,] A, ref int operations)
    {
        int n = A.GetLength(0);
        double[,] L = new double[n, n];
        double[,] U = new double[n, n];
        int[] P = new int[n];

        for (int i = 0; i < n; i++)
        {
            P[i] = i;
        }

        double[,] C = (double[,])A.Clone();

        for (int i = 0; i < n; i++)
        {
            double pivotValue = 0;
            int pivot = -1;
            for (int row = i; row < n; row++)
            {
                if (Math.Abs(C[row, i]) > pivotValue)
                {
                    pivotValue = Math.Abs(C[row, i]);
                    pivot = row;
                }
            }

            if (pivotValue != 0)
            {
                SwapRows(ref P, i, pivot);
                SwapRows(ref C, i, pivot);

                for (int j = i + 1; j < n; j++)
                {
                    C[j, i] /= C[i, i];
                    operations++;
                    for (int k = i + 1; k < n; k++)
                    {
                        C[j, k] -= C[j, i] * C[i, k];
                        operations += 2;
                    }
                }
            }
        }

        // Разделение C на L и U
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i > j)
                    L[i, j] = C[i, j];
                else
                {
                    U[i, j] = C[i, j];
                    if (i == j)
                        L[i, j] = 1;
                }
            }
        }

        return (L, U, P);
    }

    private static void SwapRows(ref int[] P, int i, int j)
    {
        int temp = P[i];
        P[i] = P[j];
        P[j] = temp;
    }

    private static void SwapRows(ref double[,] matrix, int row1, int row2)
    {
        int n = matrix.GetLength(1);
        for (int j = 0; j < n; j++)
        {
            double temp = matrix[row1, j];
            matrix[row1, j] = matrix[row2, j];
            matrix[row2, j] = temp;
        }
    }

    public static double[,] SolveForY(double[,] L, double[,] B, int[] P, ref int operations)
    {
        int n = L.GetLength(0);
        double[,] Y = new double[n, 1];

        for (int i = 0; i < n; i++)
        {
            double sum = 0;
            for (int k = 0; k < i; k++)
            {
                operations += 2;
                sum += L[i, k] * Y[k, 0];
            }
            operations += 2;
            Y[i, 0] = B[0, P[i]] - sum;
        }

        return Y;
    }

    public static double[,] SolveForX(double[,] U, double[,] Y, ref int operations)
    {
        int n = U.GetLength(0);
        double[,] X = new double[n, 1];

        for (int i = n - 1; i >= 0; i--)
        {
            double sum = 0;
            for (int k = i + 1; k < n; k++)
            {
                operations += 2;
                sum += U[i, k] * X[k, 0];
            }
            operations++;
            X[i, 0] = (Y[i, 0] - sum) / U[i, i];
        }

        return X;
    }
}
