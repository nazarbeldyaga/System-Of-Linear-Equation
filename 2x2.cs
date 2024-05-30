using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Of_Linear_Equation
{
    public static class _2x2
    {
        public static (double, double)? Solve(double[,] Amatrix, double[,] Bmatrix)
        {
            var result = SolveLinearEquations(Amatrix, Bmatrix);
            return (result.Item1, result.Item2);
        }
        public static Tuple<double, double> SolveLinearEquations(double[,] A, double[,] B)
        {
            double detA = A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0];

            double x = (B[0, 0] * A[1, 1] - B[0, 1] * A[0, 1]) / detA;
            double y = (A[0, 0] * B[0, 1] - A[1, 0] * B[0, 0]) / detA;

            return Tuple.Create(x, y);
        }
    }
}
