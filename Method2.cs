using System;

public static class Method2
{
    public static (double[,], double[,],  double[,], double[,], int) QR(double[,] A, double[,] B)
    {
        int operations = 0;
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        double[,] Q = IdentityMatrix(n); //одинична матриця
        double[,] R = (double[,])A.Clone();

        for (int j = 0; j < m; j++) //обхід по стовпцям
        {
            for (int i = n - 1; i > j; i--) //обхід по рядкам знизу угору починаючи з n-1 до j+1
            {
                double a = R[i - 1, j];
                double b = R[i, j];
                if (b != 0)
                {
                    double r = Math.Sqrt(a * a + b * b);
                    double c = a / r;
                    double s = -b / r;

                    for (int k = 0; k < m; k++)
                    {
                        double tempR = c * R[i - 1, k] - s * R[i, k];
                        R[i, k] = s * R[i - 1, k] + c * R[i, k];
                        R[i - 1, k] = tempR;
                        operations += 6;
                    }

                    for (int k = 0; k < n; k++)
                    {
                        double tempQ = c * Q[k, i - 1] - s * Q[k, i];
                        Q[k, i] = s * Q[k, i - 1] + c * Q[k, i];
                        Q[k, i - 1] = tempQ;
                        operations += 6;
                    }
                }
            }
        }

        Q = MatrixTranspose(Q);

        double[,] Y = MatrixMultiply(Q, MatrixTranspose(B), ref operations);
        double[,] X = SimpleSolveForX(R, Y, ref operations);
        return (X, Q, R, Y, operations);
    }

    private static double[,] IdentityMatrix(int n)
    {
        double[,] identity = new double[n, n];
        for (int i = 0; i < n; i++)
        {
            identity[i, i] = 1.0;
        }
        return identity;
    }

    private static double[,] MatrixMultiply(double[,] A, double[,] B, ref int operations)
    {
        int rowsA = A.GetLength(0);
        int colsA = A.GetLength(1);
        int colsB = B.GetLength(1);
        double[,] result = new double[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < colsA; k++)
                {
                    result[i, j] += A[i, k] * B[k, j];
                    operations += 2;
                }
            }
        }

        return result;
    }

    private static double[,] MatrixTranspose(double[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        double[,] result = new double[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[j, i] = A[i, j];
            }
        }

        return result;
    }

    public static double[,] SimpleSolveForX(double[,] R, double[,] Y, ref int operations)
    {
        int n = R.GetLength(0);
        double[,] X = new double[n, 1];

        for (int i = n - 1; i >= 0; i--)
        {
            double sum = 0;
            for (int k = i + 1; k < n; k++)
            {
                sum += R[i, k] * X[k, 0];
                operations += 2;
            }
            X[i, 0] = (Y[i, 0] - sum) / R[i, i];
            operations += 2;
        }

        return X;
    }
}
