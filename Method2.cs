using System;

public static class Method2
{
    public static (double[,], double[,], double[,], double[,], double[,], int) QR(double[,] A, double[,] B)
    {
        int operations = 0;
        int n = A.GetLength(0);
        double[,] Q = new double[n, n];
        double[,] R = (double[,])A.Clone();
        double[,] H = new double[n, n];

        for (int k = 0; k < n - 1; k++)
        {
            double[] x = new double[n - k];
            for (int i = k; i < n; i++)
            {
                x[i - k] = R[i, k];
            }
            operations += 2;
            double alpha = -Math.Sign(x[0]) * Math.Sqrt(DotProduct(x, x, ref operations));
            double[] u = new double[n - k];
            operations++;
            u[0] = x[0] - alpha;
            for (int i = 1; i < n - k; i++)
            {
                u[i] = x[i];
            }

            double normU = Math.Sqrt(DotProduct(u, u, ref operations));
            for (int i = 0; i < n - k; i++)
            {
                operations++;
                u[i] /= normU;
            }

            H = IdentityMatrix(n);
            for (int i = k; i < n; i++)
            {
                for (int j = k; j < n; j++)
                {
                    operations += 3;
                    H[i, j] -= 2 * u[i - k] * u[j - k];
                }
            }

            R = MatrixMultiply(H, R, ref operations);
            Q = k == 0 ? H : MatrixMultiply(Q, H, ref operations);
        }

        Q = MatrixTranspose(Q);

        double[,] Y = MatrixMultiply(Q, MatrixTranspose(B), ref operations);
        double[,] X = SimpleSolveForX(R, Y, ref operations);
        return (X, Q, R, H, Y, operations);
    }

    private static double DotProduct(double[] a, double[] b, ref int operations)
    {
        double result = 0;
        for (int i = 0; i < a.Length; i++)
        {
            operations += 2;
            result += a[i] * b[i];
        }
        return result;
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
        int n = A.GetLength(0);
        int colsB = B.GetLength(1);
        double[,] result = new double[n, colsB];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    operations += 2;
                    result[i, j] += A[i, k] * B[k, j];
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
                operations += 2;
                sum += R[i, k] * X[k, 0];
            }
            operations += 2;
            X[i, 0] = (Y[i, 0] - sum) / R[i, i];
        }

        return X;
    }
}