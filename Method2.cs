using System;

public static class Method2
{
    public static double[,] QR(double[,] A, double[,] B)
    {
        int n = A.GetLength(0);
        double[,] Q = new double[n, n];
        double[,] R = (double[,])A.Clone();

        for (int k = 0; k < n - 1; k++)
        {
            double[] x = new double[n - k];
            for (int i = k; i < n; i++)
            {
                x[i - k] = R[i, k];
            }

            double alpha = -Math.Sign(x[0]) * Math.Sqrt(DotProduct(x, x));
            double[] u = new double[n - k];
            u[0] = x[0] - alpha;
            for (int i = 1; i < n - k; i++)
            {
                u[i] = x[i];
            }

            double normU = Math.Sqrt(DotProduct(u, u));
            for (int i = 0; i < n - k; i++)
            {
                u[i] /= normU;
            }

            double[,] H = IdentityMatrix(n);
            for (int i = k; i < n; i++)
            {
                for (int j = k; j < n; j++)
                {
                    H[i, j] -= 2 * u[i - k] * u[j - k];
                }
            }

            R = MatrixMultiply(H, R);
            Q = k == 0 ? H : MatrixMultiply(Q, H);
        }

        Q = MatrixTranspose(Q);

        double[,] Y = MatrixMultiply(Q, MatrixTranspose(B));
        double[,] X = SimpleSolveForX(R, Y);
        return X;
    }

    private static double DotProduct(double[] a, double[] b)
    {
        double result = 0;
        for (int i = 0; i < a.Length; i++)
        {
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

    private static double[,] MatrixMultiply(double[,] A, double[,] B)
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

    public static double[,] SimpleSolveForX(double[,] R, double[,] Y)
    {
        int n = R.GetLength(0);
        double[,] X = new double[n, 1];

        for (int i = n - 1; i >= 0; i--)
        {
            double sum = 0;
            for (int k = i + 1; k < n; k++)
            {
                sum += R[i, k] * X[k, 0];
            }
            X[i, 0] = (Y[i, 0] - sum) / R[i, i];
        }

        return X;
    }
}