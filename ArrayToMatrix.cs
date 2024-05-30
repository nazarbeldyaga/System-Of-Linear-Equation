using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace System_Of_Linear_Equation
{
    public static class ArrayToMatrix
    {
        public static (double[,], double[,], bool) RunAlgorithm(string a00, string a01, string b00,
            string a10, string a11, string b10)
        {
            string[] Aarray = { a00, a01, a10, a11 };
            string[] Barray = { b00, b10 };
            double[,] Amatrix = new double[2, 2];
            double[,] Bmatrix = new double[1, 2];
            bool success;
            bool success1;
            bool success2;
            success1 = FillMatrix(Amatrix, Aarray);
            success2 = FillMatrix(Bmatrix, Barray);
            success = success1 && success2;
            return (Amatrix, Bmatrix, success);
        }
        public static (double[,], double[,], bool) RunAlgorithm(string a00, string a01, string a02, string b00,
            string a10, string a11, string a12, string b10,
            string a20, string a21, string a22, string b20)
        {
            string[] Aarray = { a00, a01, a02,
                a10, a11, a12,
                a20, a21, a22 };
            string[] Barray = { b00, b10, b20 };
            double[,] Amatrix = new double[3, 3];
            double[,] Bmatrix = new double[1, 3];
            bool success;
            bool success1;
            bool success2;
            success1 = FillMatrix(Amatrix, Aarray);
            success2 = FillMatrix(Bmatrix, Barray);
            success = success1 && success2;
            return (Amatrix, Bmatrix, success);
        }
        public static (double[,], double[,], bool) RunAlgorithm(string a00, string a01, string a02, string a03, string b00,
            string a10, string a11, string a12, string a13, string b10,
            string a20, string a21, string a22, string a23, string b20,
            string a30, string a31, string a32, string a33, string b30)
        {
            string[] Aarray = { a00, a01, a02, a03,
                a10, a11, a12, a13,
                a20, a21, a22, a23,
                a30, a31, a32, a33 };
            string[] Barray = { b00, b10, b20, b30 };
            double[,] Amatrix = new double[4, 4];
            double[,] Bmatrix = new double[1, 4];
            bool success;
            bool success1;
            bool success2;
            success1 = FillMatrix(Amatrix, Aarray);
            success2 = FillMatrix(Bmatrix, Barray);
            success = success1 && success2;
            return (Amatrix, Bmatrix, success);
        }
        public static (double[,], double[,], bool) RunAlgorithm(string a00, string a01, string a02, string a03, string a04, string b00,
            string a10, string a11, string a12, string a13, string a14, string b10,
            string a20, string a21, string a22, string a23, string a24, string b20,
            string a30, string a31, string a32, string a33, string a34, string b30,
            string a40, string a41, string a42, string a43, string a44, string b40)
        {
            string[] Aarray = { a00, a01, a02, a03, a04,
                a10, a11, a12, a13, a14,
                a20, a21, a22, a23, a24,
                a30, a31, a32, a33, a34,
                a40, a41, a42, a43, a44 };
            string[] Barray = { b00, b10, b20, b30, b40 };
            double[,] Amatrix = new double[5, 5];
            double[,] Bmatrix = new double[1, 5];
            bool success;
            bool success1;
            bool success2;
            success1 = FillMatrix(Amatrix, Aarray);
            success2 = FillMatrix(Bmatrix, Barray);
            success = success1 && success2;
            return (Amatrix, Bmatrix, success);
        }
        public static (double[,], double[,], bool) RunAlgorithm(string a00, string a01, string a02, string a03, string a04, string a05, string b00,
            string a10, string a11, string a12, string a13, string a14, string a15, string b10,
            string a20, string a21, string a22, string a23, string a24, string a25, string b20,
            string a30, string a31, string a32, string a33, string a34, string a35, string b30,
            string a40, string a41, string a42, string a43, string a44, string a45, string b40,
            string a50, string a51, string a52, string a53, string a54, string a55, string b50)
        {
            string[] Aarray = { a00, a01, a02, a03, a04, a05,
                a10, a11, a12, a13, a14, a15,
                a20, a21, a22, a23, a24, a25,
                a30, a31, a32, a33, a34, a35,
                a40, a41, a42, a43, a44, a45,
                a50, a51, a52, a53, a54, a55};
            string[] Barray = { b00, b10, b20, b30, b40, b50 };
            double[,] Amatrix = new double[6, 6];
            double[,] Bmatrix = new double[1, 6];
            bool success;
            bool success1;
            bool success2;
            success1 = FillMatrix(Amatrix, Aarray);
            success2 = FillMatrix(Bmatrix, Barray);
            success = success1 && success2;
            return (Amatrix, Bmatrix, success);
        }
        public static bool FillMatrix(double[,] matrix, string[] array)
        {
            int index = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    try
                    {
                        matrix[i, j] = double.Parse(array[index]);
                        index++;
                    }
                    catch
                    {
                        MessageBox.Show($"Формат введених даних невірний.\r\nДивіться правила вводу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (matrix[i, j] > 100000)
                    {
                        MessageBox.Show($"Значення надто велике.\r\nДивіться правила вводу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (matrix[i, j] < -100000)
                    {
                        MessageBox.Show($"Значення надто мале.\r\nДивіться правила вводу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (matrix[i, j] < 0.00001 && matrix[i, j] > 0)
                    {
                        MessageBox.Show($"Значення надто близьке до нуля.\r\nДивіться правила вводу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (matrix[i, j] > -0.00001 && matrix[i, j] < 0)
                    {
                        MessageBox.Show($"Значення надто близьке до нуля.\r\nДивіться правила вводу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }


                }
            }
            return true;
        }


    }
}
