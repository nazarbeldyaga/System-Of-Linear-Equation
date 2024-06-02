using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Of_Linear_Equation;

namespace System_Of_Linear_Equation
{
    public static class Method3
    {
        public static (double[,], double[,], double[,], double[,], double[,], double[,], int) Cholesky(double[,] A, double[,] B)
        {
            int operations = 0;
            (double[,] L, double[,] D) = LDDecomposition(A, ref operations);
            double[,] LUp = SimpleUpperTriangularMatrix(L);//Транспонування нижньої матриці
            double[,] Y = SimpleSolveForY(L, B, ref operations);
            double[,] Z = SimpleSolveForX(D, Y, ref operations);
            double[,] X = SimpleSolveForX(LUp, Z, ref operations);
            return (X, L, D, LUp, Y, Z, operations);
        }
        public static (double[,], double[,]) LDDecomposition(double[,] A, ref int operations)
        {
            int n = A.GetLength(0);
            double[,] L = new double[n, n];
            double[,] D = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    double sum = 0;
                    operations++;
                    if (j == i)
                    {
                        for (int k = 0; k < j; k++)
                        {
                            operations += 3;
                            sum += L[j, k] * L[j, k] * D[k, k];
                        }
                        operations++;
                        D[j, j] = A[j, j] - sum; //при від'ємних значеннях, елементи діагональної матриці можуть бути від'ємними або нульовими 
                        L[j, j] = 1;
                    }
                    else
                    {
                        for (int k = 0; k < j; k++)
                        {
                            operations += 3;
                            sum += (L[i, k] * D[k, k] * L[j, k]);
                        }
                        operations += 2;
                        L[i, j] = (A[i, j] - sum) / D[j, j];//через можливе ділення на нуль або від'ємне число, нижня трикутна мтариця може бути неправильною
                    }
                }
            }

            return (L, D);
        }
        public static double[,] SimpleUpperTriangularMatrix(double[,] L)
        {
            int n = L.GetLength(0);
            double[,] LUp = new double[n, n]; // Верхня трикутна матриця L
            double temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    LUp[i, j] = L[i, j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j > i)
                    {
                        temp = LUp[i, j];
                        LUp[i, j] = L[j, i];
                        LUp[j, i] = temp;
                    }
                }
            }
            return LUp;
        }
        public static double[,] SimpleSolveForY(double[,] L, double[,] B, ref int operations)
        {
            int n = L.GetLength(0); // Розмірність матриці L
            double[,] Y = new double[n, 1]; // Матриця Y

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
            int n = LUp.GetLength(0); // Розмірність матриці LUp
            double[,] X = new double[n, 1]; // Матриця X

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
