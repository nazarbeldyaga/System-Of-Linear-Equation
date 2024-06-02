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
        int[] P = new int[n]; //Вектор перестановок

        for (int i = 0; i < n; i++)
        {
            P[i] = i; // Initialize permutation vector

            for (int j = 0; j <= i; j++)
            {
                double sum = 0;

                for (int k = 0; k < j; k++)
                {
                    operations += 2;
                    sum += L[i, k] * U[k, j];
                }
                operations += 2;
                L[i, j] = A[P[i], j] - sum;
                operations++;
                if (i == j)
                    U[i, j] = 1;
                else
                {
                    sum = 0;
                    for (int k = 0; k < i; k++)
                    {
                        operations += 2;
                        sum += L[j, k] * U[k, i];
                    }
                    operations += 3;
                    U[j, i] = (A[P[j], i] - sum) / L[j, j];
                }
            }

            
            //знайти рядок, який має максимальне абсолютне значення в поточному стовпчику, починаючи з рядка i.
            operations++;
            double maxVal = Math.Abs(L[i, i]); // Ініціалізуємо maxVal як абсолютне значення поточного діагонального елемента
            int pivotRow = i; // Ініціалізуємо pivotRow як поточний рядок
            for (int k = i + 1; k < n; k++) // Цикл для перегляду всіх рядків нижче поточного
            {
                operations +=2;
                double absVal = Math.Abs(L[k, i]); // Обчислюємо абсолютне значення елемента в стовпчику і рядку k
                if (absVal > maxVal) // Якщо знайдене значення більше за поточне максимальне
                {
                    maxVal = absVal; // Оновлюємо максимальне значення
                    pivotRow = k; // Оновлюємо індекс pivotRow
                }
            }

            // Міняємо рядки у L та оновлюємо матрицю перестановок
            operations++;
            if (pivotRow != i)
            {
                SwapRows(ref L, i, pivotRow);
                Swap(ref P[i], ref P[pivotRow]);
            }
        }

        return (L, U, P);
    }

    private static void SwapRows(ref double[,] matrix, int row1, int row2)
    {
        int n = matrix.GetLength(0);
        for (int j = 0; j < n; j++)
        {
            double temp = matrix[row1, j];
            matrix[row1, j] = matrix[row2, j];
            matrix[row2, j] = temp;
        }
    }
    //міняємо відповідні елементи у матриці перестановок
    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
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
            Y[i, 0] = (B[0, P[i]] - sum) / L[i, i];
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
            X[i, 0] = Y[i, 0] - sum;
        }
        return X;
    }

}
