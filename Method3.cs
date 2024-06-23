using System;

namespace System_Of_Linear_Equation
{
    public static class Method3
    {
        public static (double[,], double[,], double[,], double[,], int) Cholesky(double[,] A, double[,] B)
        {
            int operations = 0;
            double[,] L = CholeskyDecomposition(A, ref operations);
            double[,] LUp = SimpleUpperTriangularMatrix(L); // Transpose of lower triangular matrix
            double[,] Y = SimpleSolveForY(L, B, ref operations);
            double[,] X = SimpleSolveForX(LUp, Y, ref operations);
            return (X, L, LUp, Y, operations);
        }

        public static double[,] CholeskyDecomposition(double[,] A, ref int operations)
        {
            int n = A.GetLength(0);
            double[,] L = new double[n, n];

            for (int j = 0; j < n; j++)
            {
                double sum = 0;
                for (int k = 0; k < j; k++)
                {
                    operations+=2;
                    sum += L[j, k] * L[j, k];
                }
                operations++;
                L[j, j] = Math.Sqrt(A[j, j] - sum);

                for (int i = j + 1; i < n; i++)
                {
                    sum = 0;
                    for (int k = 0; k < j; k++)
                    {
                        operations++;
                        sum += L[i, k] * L[j, k];
                    }
                    operations++;
                    L[i, j] = (A[i, j] - sum) / L[j, j];
                }
            }

            return L;
        }

        public static double[,] SimpleUpperTriangularMatrix(double[,] L)
        {
            int n = L.GetLength(0);
            double[,] LUp = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    LUp[i, j] = L[j, i];
                }
            }

            return LUp;
        }

        public static double[,] SimpleSolveForY(double[,] L, double[,] B, ref int operations)
        {
            int n = L.GetLength(0); // Dimension of matrix L
            double[,] Y = new double[n, 1]; // Matrix Y

            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int k = 0; k < i; k++)
                {
                    operations += 2;
                    sum += L[i, k] * Y[k, 0];
                }
                operations += 2;
                Y[i, 0] = (B[0, i] - sum) / L[i, i];
            }
            return Y;
        }

        public static double[,] SimpleSolveForX(double[,] LUp, double[,] Y, ref int operations)
        {
            int n = LUp.GetLength(0); // Dimension of matrix LUp
            double[,] X = new double[n, 1]; // Matrix X

            for (int i = n - 1; i >= 0; i--)
            {
                double sum = 0;
                for (int k = i + 1; k < n; k++)
                {
                    operations += 2;
                    sum += LUp[i, k] * X[k, 0];
                }
                operations += 2;
                X[i, 0] = (Y[i, 0] - sum) / LUp[i, i];
            }

            return X;
        }
    }
}
