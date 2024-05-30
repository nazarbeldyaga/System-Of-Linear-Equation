﻿using System;
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
        public static (double[,], double[,], double[,], double[,], double[,], double[,]) Cholesky(double[,] A, double[,] B)
        {
            (double[,] L, double[,] D) = LDLDecomposition(A);
            double[,] LUp = SimpleUpperTriangularMatrix(L);
            double[,] Y = SimpleSolveForY(L, B);
            double[,] Z = SimpleSolveForX(D, Y);
            double[,] X = SimpleSolveForX(LUp, Z);
            return (X, L, D, LUp, Y, Z);
        }
        public static (double[,], double[,]) LDLDecomposition(double[,] A)
        {
            int n = A.GetLength(0);
            double[,] L = new double[n, n];
            double[,] D = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    double sum = 0;

                    if (j == i)
                    {
                        for (int k = 0; k < j; k++)
                            sum += L[j, k] * L[j, k] * D[k, k];

                        D[j, j] = A[j, j] - sum;
                        L[j, j] = 1;
                    }
                    else
                    {
                        for (int k = 0; k < j; k++)
                            sum += (L[i, k] * D[k, k] * L[j, k]);

                        L[i, j] = (A[i, j] - sum) / D[j, j];
                    }
                }
            }

            return (L, D);
        }
        public static double[,] SimpleUpperTriangularMatrix(double[,] L)
        {
            int n = L.GetLength(0); // Розмірність матриці A
            double[,] LUp = new double[n, n]; // Нижня трикутна матриця L
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
        public static double[,] SimpleSolveForY(double[,] L, double[,] B)
        {
            int n = L.GetLength(0); // Розмірність матриці L
            double[,] Y = new double[n, 1]; // Матриця Y

            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int k = 0; k < i; k++)
                {
                    sum += L[i, k] * Y[k, 0];
                }
                Y[i, 0] = (B[0, i] - sum) / L[i, i];
            }
            return Y;
        }
        public static double[,] SimpleSolveForX(double[,] LUp, double[,] Y)
        {
            int n = LUp.GetLength(0); // Розмірність матриці LUp
            double[,] X = new double[n, 1]; // Матриця X

            for (int i = n - 1; i >= 0; i--)
            {
                double sum = 0;
                for (int k = i + 1; k < n; k++)
                {
                    sum += LUp[i, k] * X[k, 0];
                }
                X[i, 0] = (Y[i, 0] - sum) / LUp[i, i];
            }

            return X;
        }


    }
}