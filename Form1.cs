using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace System_Of_Linear_Equation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox52.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox52.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox52.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox42.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox42.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox42.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox32.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox32.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox32.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox22.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox22.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox22.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox63.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox63.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox63.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox53.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox53.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox53.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox43.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox43.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox43.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox33.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox33.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox33.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox23.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox23.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox23.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox13.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox13.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox13.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox64.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox64.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox64.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox54.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox54.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox54.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox44.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox44.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox44.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox34.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox34.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox34.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox24.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox24.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox24.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox14.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox14.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox14.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox65_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox65.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox65.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox65.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox55.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox55.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox55.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox45.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox45.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox45.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox35.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox35.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox35.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox25.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox25.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox25.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox15.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox15.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox15.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox66.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox66.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox66.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox46.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox46.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox46.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox36.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox36.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox36.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox26.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox26.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox26.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox16.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox16.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox16.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox62.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox62.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox62.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox67.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox67.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox67.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox57.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox57.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox57.BackColor = System.Drawing.SystemColors.Menu;
            }

        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox47.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox47.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox47.BackColor = System.Drawing.SystemColors.Menu;
            }

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox37.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox37.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox37.BackColor = System.Drawing.SystemColors.Menu;
            }

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox27.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox27.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox27.BackColor = System.Drawing.SystemColors.Menu;
            }
        }
        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox17.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox17.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox17.BackColor = System.Drawing.SystemColors.Menu;
            }

        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox56.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox56.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox56.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox61_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox61.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox61.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox61.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox51.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox51.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox51.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox41.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox41.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox41.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox31.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox31.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox31.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox21.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox21.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox21.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox12.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox12.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox12.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox11.Text, out double result) || result > 100000 || result < -100000 ||
                (result > 0 && result < 0.00001) || (result < 0 && result > -0.00001))
            {
                textBox11.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox11.BackColor = System.Drawing.SystemColors.Menu;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double[,] Amatrix;
            double[,] Bmatrix;
            double[,] X, Q, R, H, Y;
            bool success;
            int operations = 0;
            switch (comboBox1.SelectedItem)
            {
                case "3":
                    (Amatrix, Bmatrix, success) = ArrayToMatrix.RunAlgorithm(textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text,
                        textBox21.Text, textBox22.Text, textBox23.Text, textBox24.Text,
                        textBox31.Text, textBox32.Text, textBox33.Text, textBox34.Text);
                    if (success)
                    {
                        
                        textBox1.Visible = true;
                        button8.Visible = true;
                        textBox1.Text = "Умова:\r\n";
                        textBox1.Text += MatrixToStringEquation(Amatrix, Bmatrix);
                        textBox1.Text += $"\r\n\r\nМетод QR для ({comboBox1.SelectedItem} рівнянь)\r\n\r\n";
                        if(CalculateDeterminant(Amatrix) != 0)
                        {
                            (X, Q, R, H, Y, operations) = Method2.QR(Amatrix, Bmatrix);
                            if (double.IsNaN(X[0, 0]))
                            {
                                textBox1.Text += "Можливих рішень для заданого рівняння\r\nобраним способом не знайдено!";
                            }
                            else
                            {
                                textBox1.Text += $"X1 = {Math.Round(X[0, 0], 3).ToString()}\r\n" +
                                $"X2 = {Math.Round(X[1, 0], 3).ToString()}\r\n" +
                                $"X3 = {Math.Round(X[2, 0], 3).ToString()}\r\n";
                                label4.Visible = true;
                                label5.Visible = true;
                                label5.Text = $"К-сть операцій: {operations}";
                                textBox1.Text += "\r\n-----------------\r\nРішення:\r\n";
                                textBox1.Text += $"\r\nМатриця Q:\r\n" +
                                $"| {Math.Round(Q[0, 0], 2)} {Math.Round(Q[0, 1], 2)} {Math.Round(Q[0, 2], 2)} |\r\n" +
                                $"| {Math.Round(Q[1, 0], 2)} {Math.Round(Q[1, 1], 2)} {Math.Round(Q[1, 2], 2)} |\r\n" +
                                $"| {Math.Round(Q[2, 0], 2)} {Math.Round(Q[2, 1], 2)} {Math.Round(Q[2, 2], 2)} |\r\n" +
                                $"\r\nМатриця R:\r\n" +
                                $"| {Math.Round(R[0, 0], 2)} {Math.Round(R[0, 1], 2)} {Math.Round(R[0, 2], 2)} |\r\n" +
                                $"| {Math.Round(R[1, 0], 2)} {Math.Round(R[1, 1], 2)} {Math.Round(R[1, 2], 2)} |\r\n" +
                                $"| {Math.Round(R[2, 0], 2)} {Math.Round(R[2, 1], 2)} {Math.Round(R[2, 2], 2)} |\r\n" +
                                $"\r\nМатриця H:\r\n" +
                                $"| {Math.Round(H[0, 0], 2)} {Math.Round(H[0, 1], 2)} {Math.Round(H[0, 2], 2)} |\r\n" +
                                $"| {Math.Round(H[1, 0], 2)} {Math.Round(H[1, 1], 2)} {Math.Round(H[1, 2], 2)} |\r\n" +
                                $"| {Math.Round(H[2, 0], 2)} {Math.Round(H[2, 1], 2)} {Math.Round(H[2, 2], 2)} |\r\n" +
                                $"\r\nМатриця Y:\r\n" +
                                $"| {Math.Round(Y[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[2, 0], 2)} |\r\n" +
                                $"\r\nМатриця X:\r\n" +
                                $"| {Math.Round(X[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[2, 0], 2)} |";
                            }
                        }
                        else
                        {
                            textBox1.Text += "Введена матриця є вродженою (її визначник рівний нулю).\r\n" +
                                "Нажаль для цього випадку метод QR не працює\r\n";
                        }
                    }
                    else
                    {
                        textBox1.Visible = false;
                        button8.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                    }
                    break;
                case "4":
                    (Amatrix, Bmatrix, success) = ArrayToMatrix.RunAlgorithm(textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text,
                        textBox21.Text, textBox22.Text, textBox23.Text, textBox24.Text, textBox25.Text,
                        textBox31.Text, textBox32.Text, textBox33.Text, textBox34.Text, textBox35.Text,
                        textBox41.Text, textBox42.Text, textBox43.Text, textBox44.Text, textBox45.Text);
                    if (success)
                    {                        
                        textBox1.Visible = true;
                        button8.Visible = true;
                        textBox1.Text = "Умова:\r\n";
                        textBox1.Text += MatrixToStringEquation(Amatrix, Bmatrix);
                        textBox1.Text += $"\r\n\r\nМетод QR для ({comboBox1.SelectedItem} рівнянь)\r\n\r\n";
                        if(CalculateDeterminant(Amatrix) != 0)
                        {
                            (X, Q, R, H, Y, operations) = Method2.QR(Amatrix, Bmatrix);
                            if (double.IsNaN(X[0, 0]))
                            {
                                textBox1.Text += "Можливих рішень для заданого рівняння\r\nобраним способом не знайдено!";
                            }
                            else
                            {
                                textBox1.Text += $"X1 = {Math.Round(X[0, 0], 3).ToString()}\r\n" +
                                $"X2 = {Math.Round(X[1, 0], 3).ToString()}\r\n" +
                                $"X3 = {Math.Round(X[2, 0], 3).ToString()}\r\n" +
                                $"X4 = {Math.Round(X[3, 0], 3).ToString()}\r\n";
                                label4.Visible = true;
                                label5.Visible = true;
                                label5.Text = $"К-сть операцій: {operations}";
                                textBox1.Text += "\r\n-----------------\r\nРішення:\r\n";
                                textBox1.Text += $"\r\nМатриця Q:\r\n" +
                                $"| {Math.Round(Q[0, 0], 2)} {Math.Round(Q[0, 1], 2)} {Math.Round(Q[0, 2], 2)}  {Math.Round(Q[0, 3], 2)} |\r\n" +
                                $"| {Math.Round(Q[1, 0], 2)} {Math.Round(Q[1, 1], 2)} {Math.Round(Q[1, 2], 2)}  {Math.Round(Q[1, 3], 2)} |\r\n" +
                                $"| {Math.Round(Q[2, 0], 2)} {Math.Round(Q[2, 1], 2)} {Math.Round(Q[2, 2], 2)}  {Math.Round(Q[2, 3], 2)} |\r\n" +
                                $"| {Math.Round(Q[3, 0], 2)} {Math.Round(Q[3, 1], 2)} {Math.Round(Q[3, 2], 2)}  {Math.Round(Q[3, 3], 2)} |\r\n" +
                                $"\r\nМатриця R:\r\n" +
                                $"| {Math.Round(R[0, 0], 2)} {Math.Round(R[0, 1], 2)} {Math.Round(R[0, 2], 2)}  {Math.Round(R[0, 3], 2)} |\r\n" +
                                $"| {Math.Round(R[1, 0], 2)} {Math.Round(R[1, 1], 2)} {Math.Round(R[1, 2], 2)}  {Math.Round(R[1, 3], 2)} |\r\n" +
                                $"| {Math.Round(R[2, 0], 2)} {Math.Round(R[2, 1], 2)} {Math.Round(R[2, 2], 2)}  {Math.Round(R[2, 3], 2)} |\r\n" +
                                $"| {Math.Round(R[3, 0], 2)} {Math.Round(R[3, 1], 2)} {Math.Round(R[3, 2], 2)}  {Math.Round(R[3, 3], 2)} |\r\n" +
                                $"\r\nМатриця H:\r\n" +
                                $"| {Math.Round(H[0, 0], 2)} {Math.Round(H[0, 1], 2)} {Math.Round(H[0, 2], 2)}  {Math.Round(H[0, 3], 2)} |\r\n" +
                                $"| {Math.Round(H[1, 0], 2)} {Math.Round(H[1, 1], 2)} {Math.Round(H[1, 2], 2)}  {Math.Round(H[1, 3], 2)} |\r\n" +
                                $"| {Math.Round(H[2, 0], 2)} {Math.Round(H[2, 1], 2)} {Math.Round(H[2, 2], 2)}  {Math.Round(H[2, 3], 2)} |\r\n" +
                                $"| {Math.Round(H[3, 0], 2)} {Math.Round(H[3, 1], 2)} {Math.Round(H[3, 2], 2)}  {Math.Round(H[3, 3], 2)} |\r\n" +
                                $"\r\nМатриця Y:\r\n" +
                                $"| {Math.Round(Y[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[2, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[3, 0], 2)} |\r\n" +
                                $"\r\nМатриця X:\r\n" +
                                $"| {Math.Round(X[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[2, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[3, 0], 2)} |";
                            }
                        }
                        else
                        {
                            textBox1.Text += "Введена матриця є вродженою (її визначник рівний нулю).\r\n" +
                                "Нажаль для цього випадку метод QR не працює\r\n";
                        }                        
                    }
                    else
                    {
                        textBox1.Visible = false;
                        button8.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                    }
                    break;
                case "5":
                    (Amatrix, Bmatrix, success) = ArrayToMatrix.RunAlgorithm(textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text, textBox16.Text,
                        textBox21.Text, textBox22.Text, textBox23.Text, textBox24.Text, textBox25.Text, textBox26.Text,
                        textBox31.Text, textBox32.Text, textBox33.Text, textBox34.Text, textBox35.Text, textBox36.Text,
                        textBox41.Text, textBox42.Text, textBox43.Text, textBox44.Text, textBox45.Text, textBox46.Text,
                        textBox51.Text, textBox52.Text, textBox53.Text, textBox54.Text, textBox55.Text, textBox56.Text);
                    if (success)
                    {                        
                        textBox1.Visible = true;
                        button8.Visible = true;
                        textBox1.Text = "Умова:\r\n";
                        textBox1.Text += MatrixToStringEquation(Amatrix, Bmatrix);
                        textBox1.Text += $"\r\n\r\nМетод QR для ({comboBox1.SelectedItem} рівнянь)\r\n\r\n";
                        if(CalculateDeterminant(Amatrix) != 0)
                        {
                            (X, Q, R, H, Y, operations) = Method2.QR(Amatrix, Bmatrix);
                            if (double.IsNaN(X[0, 0]))
                            {
                                textBox1.Text += "Можливих рішень для заданого рівняння\r\nобраним способом не знайдено!";
                            }
                            else
                            {
                                textBox1.Text += $"X1 = {Math.Round(X[0, 0], 3).ToString()}\r\n" +
                                $"X2 = {Math.Round(X[1, 0], 3).ToString()}\r\n" +
                                $"X3 = {Math.Round(X[2, 0], 3).ToString()}\r\n" +
                                $"X4 = {Math.Round(X[3, 0], 3).ToString()}\r\n" +
                                $"X5 = {Math.Round(X[4, 0], 3).ToString()}\r\n";
                                label4.Visible = true;
                                label5.Visible = true;
                                label5.Text = $"К-сть операцій: {operations}";
                                textBox1.Text += "\r\n-----------------\r\nРішення:\r\n";
                                textBox1.Text += $"\r\nМатриця Q:\r\n" +
                                $"| {Math.Round(Q[0, 0], 2)} {Math.Round(Q[0, 1], 2)} {Math.Round(Q[0, 2], 2)}  {Math.Round(Q[0, 3], 2)}  {Math.Round(Q[0, 4], 2)} |\r\n" +
                                $"| {Math.Round(Q[1, 0], 2)} {Math.Round(Q[1, 1], 2)} {Math.Round(Q[1, 2], 2)}  {Math.Round(Q[1, 3], 2)}  {Math.Round(Q[1, 4], 2)} |\r\n" +
                                $"| {Math.Round(Q[2, 0], 2)} {Math.Round(Q[2, 1], 2)} {Math.Round(Q[2, 2], 2)}  {Math.Round(Q[2, 3], 2)}  {Math.Round(Q[2, 4], 2)} |\r\n" +
                                $"| {Math.Round(Q[3, 0], 2)} {Math.Round(Q[3, 1], 2)} {Math.Round(Q[3, 2], 2)}  {Math.Round(Q[3, 3], 2)}  {Math.Round(Q[3, 4], 2)} |\r\n" +
                                $"| {Math.Round(Q[4, 0], 2)} {Math.Round(Q[4, 1], 2)} {Math.Round(Q[4, 2], 2)}  {Math.Round(Q[4, 3], 2)}  {Math.Round(Q[4, 4], 2)} |\r\n" +
                                $"\r\nМатриця R:\r\n" +
                                $"| {Math.Round(R[0, 0], 2)} {Math.Round(R[0, 1], 2)} {Math.Round(R[0, 2], 2)}  {Math.Round(R[0, 3], 2)}  {Math.Round(R[0, 4], 2)} |\r\n" +
                                $"| {Math.Round(R[1, 0], 2)} {Math.Round(R[1, 1], 2)} {Math.Round(R[1, 2], 2)}  {Math.Round(R[1, 3], 2)}  {Math.Round(R[1, 4], 2)} |\r\n" +
                                $"| {Math.Round(R[2, 0], 2)} {Math.Round(R[2, 1], 2)} {Math.Round(R[2, 2], 2)}  {Math.Round(R[2, 3], 2)}  {Math.Round(R[2, 4], 2)} |\r\n" +
                                $"| {Math.Round(R[3, 0], 2)} {Math.Round(R[3, 1], 2)} {Math.Round(R[3, 2], 2)}  {Math.Round(R[3, 3], 2)}  {Math.Round(R[3, 4], 2)} |\r\n" +
                                $"| {Math.Round(R[4, 0], 2)} {Math.Round(R[4, 1], 2)} {Math.Round(R[4, 2], 2)}  {Math.Round(R[4, 3], 2)}  {Math.Round(R[4, 4], 2)} |\r\n" +
                                $"\r\nМатриця H:\r\n" +
                                $"| {Math.Round(H[0, 0], 2)} {Math.Round(H[0, 1], 2)} {Math.Round(H[0, 2], 2)}  {Math.Round(H[0, 3], 2)}  {Math.Round(H[0, 4], 2)} |\r\n" +
                                $"| {Math.Round(H[1, 0], 2)} {Math.Round(H[1, 1], 2)} {Math.Round(H[1, 2], 2)}  {Math.Round(H[1, 3], 2)}  {Math.Round(H[1, 4], 2)} |\r\n" +
                                $"| {Math.Round(H[2, 0], 2)} {Math.Round(H[2, 1], 2)} {Math.Round(H[2, 2], 2)}  {Math.Round(H[2, 3], 2)}  {Math.Round(H[2, 4], 2)} |\r\n" +
                                $"| {Math.Round(H[3, 0], 2)} {Math.Round(H[3, 1], 2)} {Math.Round(H[3, 2], 2)}  {Math.Round(H[3, 3], 2)}  {Math.Round(H[3, 4], 2)} |\r\n" +
                                $"| {Math.Round(H[4, 0], 2)} {Math.Round(H[4, 1], 2)} {Math.Round(H[4, 2], 2)}  {Math.Round(H[4, 3], 2)}  {Math.Round(H[4, 4], 2)} |\r\n" +
                                $"\r\nМатриця Y:\r\n" +
                                $"| {Math.Round(Y[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[2, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[3, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[4, 0], 2)} |\r\n" +
                                $"\r\nМатриця X:\r\n" +
                                $"| {Math.Round(X[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[2, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[3, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[4, 0], 2)} |";
                            }
                        }
                        else
                        {
                            textBox1.Text += "Введена матриця є вродженою (її визначник рівний нулю).\r\n" +
                                "Нажаль для цього випадку метод QR не працює\r\n";
                        }
                        
                    }
                    else
                    {
                        textBox1.Visible = false;
                        button8.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                    }
                    break;
                case "6":
                    (Amatrix, Bmatrix, success) = ArrayToMatrix.RunAlgorithm(textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text, textBox16.Text, textBox17.Text,
                        textBox21.Text, textBox22.Text, textBox23.Text, textBox24.Text, textBox25.Text, textBox26.Text, textBox27.Text,
                        textBox31.Text, textBox32.Text, textBox33.Text, textBox34.Text, textBox35.Text, textBox36.Text, textBox37.Text,
                        textBox41.Text, textBox42.Text, textBox43.Text, textBox44.Text, textBox45.Text, textBox46.Text, textBox47.Text,
                        textBox51.Text, textBox52.Text, textBox53.Text, textBox54.Text, textBox55.Text, textBox56.Text, textBox57.Text,
                        textBox61.Text, textBox62.Text, textBox63.Text, textBox64.Text, textBox65.Text, textBox66.Text, textBox67.Text);
                    if (success)
                    {                        
                        textBox1.Visible = true;
                        button8.Visible = true;
                        textBox1.Text = "Умова:\r\n";
                        textBox1.Text += MatrixToStringEquation(Amatrix, Bmatrix);
                        textBox1.Text += $"\r\n\r\nМетод QR для ({comboBox1.SelectedItem} рівнянь)\r\n\r\n";
                        if(CalculateDeterminant(Amatrix) != 0)
                        {
                            (X, Q, R, H, Y, operations) = Method2.QR(Amatrix, Bmatrix);
                            if (double.IsNaN(X[0, 0]))
                            {
                                textBox1.Text += "Можливих рішень для заданого рівняння\r\nобраним способом не знайдено!";
                            }
                            else
                            {
                                textBox1.Text += $"X1 = {Math.Round(X[0, 0], 3).ToString()}\r\n" +
                                $"X2 = {Math.Round(X[1, 0], 3).ToString()}\r\n" +
                                $"X3 = {Math.Round(X[2, 0], 3).ToString()}\r\n" +
                                $"X4 = {Math.Round(X[3, 0], 3).ToString()}\r\n" +
                                $"X5 = {Math.Round(X[4, 0], 3).ToString()}\r\n" +
                                $"X6 = {Math.Round(X[5, 0], 3).ToString()}\r\n";
                                label4.Visible = true;
                                label5.Visible = true;
                                label5.Text = $"К-сть операцій: {operations}";
                                textBox1.Text += "\r\n-----------------\r\nРішення:\r\n";
                                textBox1.Text += $"\r\nМатриця Q:\r\n" +
                                $"| {Math.Round(Q[0, 0], 2)} {Math.Round(Q[0, 1], 2)} {Math.Round(Q[0, 2], 2)}  {Math.Round(Q[0, 3], 2)}  {Math.Round(Q[0, 4], 2)}  {Math.Round(Q[0, 5], 2)} |\r\n" +
                                $"| {Math.Round(Q[1, 0], 2)} {Math.Round(Q[1, 1], 2)} {Math.Round(Q[1, 2], 2)}  {Math.Round(Q[1, 3], 2)}  {Math.Round(Q[1, 4], 2)}  {Math.Round(Q[1, 5], 2)} |\r\n" +
                                $"| {Math.Round(Q[2, 0], 2)} {Math.Round(Q[2, 1], 2)} {Math.Round(Q[2, 2], 2)}  {Math.Round(Q[2, 3], 2)}  {Math.Round(Q[2, 4], 2)}  {Math.Round(Q[2, 5], 2)} |\r\n" +
                                $"| {Math.Round(Q[3, 0], 2)} {Math.Round(Q[3, 1], 2)} {Math.Round(Q[3, 2], 2)}  {Math.Round(Q[3, 3], 2)}  {Math.Round(Q[3, 4], 2)}  {Math.Round(Q[3, 5], 2)} |\r\n" +
                                $"| {Math.Round(Q[4, 0], 2)} {Math.Round(Q[4, 1], 2)} {Math.Round(Q[4, 2], 2)}  {Math.Round(Q[4, 3], 2)}  {Math.Round(Q[4, 4], 2)}  {Math.Round(Q[4, 5], 2)} |\r\n" +
                                $"| {Math.Round(Q[5, 0], 2)} {Math.Round(Q[5, 1], 2)} {Math.Round(Q[5, 2], 2)}  {Math.Round(Q[5, 3], 2)}  {Math.Round(Q[5, 4], 2)}  {Math.Round(Q[5, 5], 2)} |\r\n" +
                                $"\r\nМатриця R:\r\n" +
                                $"| {Math.Round(R[0, 0], 2)} {Math.Round(R[0, 1], 2)} {Math.Round(R[0, 2], 2)}  {Math.Round(R[0, 3], 2)}  {Math.Round(R[0, 4], 2)}  {Math.Round(Q[0, 5], 2)} |\r\n" +
                                $"| {Math.Round(R[1, 0], 2)} {Math.Round(R[1, 1], 2)} {Math.Round(R[1, 2], 2)}  {Math.Round(R[1, 3], 2)}  {Math.Round(R[1, 4], 2)}  {Math.Round(Q[1, 5], 2)} |\r\n" +
                                $"| {Math.Round(R[2, 0], 2)} {Math.Round(R[2, 1], 2)} {Math.Round(R[2, 2], 2)}  {Math.Round(R[2, 3], 2)}  {Math.Round(R[2, 4], 2)}  {Math.Round(Q[2, 5], 2)} |\r\n" +
                                $"| {Math.Round(R[3, 0], 2)} {Math.Round(R[3, 1], 2)} {Math.Round(R[3, 2], 2)}  {Math.Round(R[3, 3], 2)}  {Math.Round(R[3, 4], 2)}  {Math.Round(Q[3, 5], 2)} |\r\n" +
                                $"| {Math.Round(R[4, 0], 2)} {Math.Round(R[4, 1], 2)} {Math.Round(R[4, 2], 2)}  {Math.Round(R[4, 3], 2)}  {Math.Round(R[4, 4], 2)}  {Math.Round(Q[4, 5], 2)} |\r\n" +
                                $"| {Math.Round(R[5, 0], 2)} {Math.Round(R[5, 1], 2)} {Math.Round(R[5, 2], 2)}  {Math.Round(R[5, 3], 2)}  {Math.Round(R[5, 4], 2)}  {Math.Round(Q[5, 5], 2)} |\r\n" +
                                $"\r\nМатриця H:\r\n" +
                                $"| {Math.Round(H[0, 0], 2)} {Math.Round(H[0, 1], 2)} {Math.Round(H[0, 2], 2)}  {Math.Round(H[0, 3], 2)}  {Math.Round(H[0, 4], 2)}  {Math.Round(H[0, 5], 2)} |\r\n" +
                                $"| {Math.Round(H[1, 0], 2)} {Math.Round(H[1, 1], 2)} {Math.Round(H[1, 2], 2)}  {Math.Round(H[1, 3], 2)}  {Math.Round(H[1, 4], 2)}  {Math.Round(H[1, 5], 2)} |\r\n" +
                                $"| {Math.Round(H[2, 0], 2)} {Math.Round(H[2, 1], 2)} {Math.Round(H[2, 2], 2)}  {Math.Round(H[2, 3], 2)}  {Math.Round(H[2, 4], 2)}  {Math.Round(H[2, 5], 2)} |\r\n" +
                                $"| {Math.Round(H[3, 0], 2)} {Math.Round(H[3, 1], 2)} {Math.Round(H[3, 2], 2)}  {Math.Round(H[3, 3], 2)}  {Math.Round(H[3, 4], 2)}  {Math.Round(H[3, 5], 2)} |\r\n" +
                                $"| {Math.Round(H[4, 0], 2)} {Math.Round(H[4, 1], 2)} {Math.Round(H[4, 2], 2)}  {Math.Round(H[4, 3], 2)}  {Math.Round(H[4, 4], 2)}  {Math.Round(H[4, 5], 2)} |\r\n" +
                                $"| {Math.Round(H[5, 0], 2)} {Math.Round(H[5, 1], 2)} {Math.Round(H[5, 2], 2)}  {Math.Round(H[5, 3], 2)}  {Math.Round(H[5, 4], 2)}  {Math.Round(H[5, 5], 2)} |\r\n" +
                                $"\r\nМатриця Y:\r\n" +
                                $"| {Math.Round(Y[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[2, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[3, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[4, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[5, 0], 2)} |\r\n" +
                                $"\r\nМатриця X:\r\n" +
                                $"| {Math.Round(X[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[2, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[3, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[4, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[5, 0], 2)} |";
                            }
                        }
                        else
                        {
                            textBox1.Text += "Введена матриця є вродженою (її визначник рівний нулю).\r\n" +
                                "Нажаль для цього випадку метод QR не працює\r\n";
                        }
                        
                    }
                    else
                    {
                        textBox1.Visible = false;
                        button8.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                    }
                    break;
            }

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "2":
                    this.panel4.Visible = false;
                    this.panel5.Visible = false;
                    this.panel6.Visible = false;
                    this.panel7.Visible = false;
                    this.panel8.Visible = false;
                    this.panel9.Visible = false;
                    this.panel10.Visible = false;
                    this.panel11.Visible = false;
                    this.label12.Text = "x2=";
                    this.label22.Text = "x2=";
                    this.label13.Text = "";
                    this.label23.Text = "";
                    this.button1.Visible = false;
                    this.button3.Visible = false;
                    this.button5.Visible = false;
                    this.button6.Visible = true;
                    this.pictureBox1.Size = new System.Drawing.Size(36, 105);

                    break;
                case "3":
                    this.panel4.Visible = true;
                    this.panel5.Visible = true;
                    this.panel6.Visible = false;
                    this.panel7.Visible = false;
                    this.panel8.Visible = false;
                    this.panel9.Visible = false;
                    this.panel10.Visible = false;
                    this.panel11.Visible = false;
                    this.label12.Text = "x2+";
                    this.label22.Text = "x2+";
                    this.label13.Text = "x3=";
                    this.label23.Text = "x3=";
                    this.label33.Text = "x3=";
                    this.label14.Text = "";
                    this.label24.Text = "";
                    this.label34.Text = "";
                    this.button1.Visible = true;
                    this.button3.Visible = true;
                    this.button5.Visible = true;
                    this.button6.Visible = false;
                    this.pictureBox1.Size = new System.Drawing.Size(36, 166);
                    break;
                case "4":
                    this.panel4.Visible = true;
                    this.panel5.Visible = true;
                    this.panel6.Visible = true;
                    this.panel7.Visible = true;
                    this.panel8.Visible = false;
                    this.panel9.Visible = false;
                    this.panel10.Visible = false;
                    this.panel11.Visible = false;
                    this.label12.Text = "x2+";
                    this.label22.Text = "x2+";
                    this.label13.Text = "x3+";
                    this.label23.Text = "x3+";
                    this.label33.Text = "x3+";
                    this.label14.Text = "x4=";
                    this.label24.Text = "x4=";
                    this.label34.Text = "x4=";
                    this.label44.Text = "x4=";
                    this.label15.Text = "";
                    this.label25.Text = "";
                    this.label35.Text = "";
                    this.label45.Text = "";
                    this.button1.Visible = true;
                    this.button3.Visible = true;
                    this.button5.Visible = true;
                    this.button6.Visible = false;
                    this.pictureBox1.Size = new System.Drawing.Size(36, 222);
                    break;
                case "5":
                    this.panel4.Visible = true;
                    this.panel5.Visible = true;
                    this.panel6.Visible = true;
                    this.panel7.Visible = true;
                    this.panel8.Visible = true;
                    this.panel9.Visible = true;
                    this.panel10.Visible = false;
                    this.panel11.Visible = false;
                    this.label12.Text = "x2+";
                    this.label22.Text = "x2+";
                    this.label13.Text = "x3+";
                    this.label23.Text = "x3+";
                    this.label33.Text = "x3+";
                    this.label14.Text = "x4+";
                    this.label24.Text = "x4+";
                    this.label34.Text = "x4+";
                    this.label44.Text = "x4+";
                    this.label15.Text = "x5=";
                    this.label25.Text = "x5=";
                    this.label35.Text = "x5=";
                    this.label45.Text = "x5=";
                    this.label55.Text = "x5=";
                    this.label16.Text = "";
                    this.label26.Text = "";
                    this.label36.Text = "";
                    this.label46.Text = "";
                    this.label56.Text = "";
                    this.button1.Visible = true;
                    this.button3.Visible = true;
                    this.button5.Visible = true;
                    this.button6.Visible = false;
                    this.pictureBox1.Size = new System.Drawing.Size(36, 281);
                    break;
                case "6":
                    this.panel4.Visible = true;
                    this.panel5.Visible = true;
                    this.panel6.Visible = true;
                    this.panel7.Visible = true;
                    this.panel8.Visible = true;
                    this.panel9.Visible = true;
                    this.panel10.Visible = true;
                    this.panel11.Visible = true;
                    this.label12.Text = "x2+";
                    this.label22.Text = "x2+";
                    this.label13.Text = "x3+";
                    this.label23.Text = "x3+";
                    this.label33.Text = "x3+";
                    this.label14.Text = "x4+";
                    this.label24.Text = "x4+";
                    this.label34.Text = "x4+";
                    this.label44.Text = "x4+";
                    this.label15.Text = "x5+";
                    this.label25.Text = "x5+";
                    this.label35.Text = "x5+";
                    this.label45.Text = "x5+";
                    this.label55.Text = "x5+";
                    this.label16.Text = "x6=";
                    this.label26.Text = "x6=";
                    this.label36.Text = "x6=";
                    this.label46.Text = "x6=";
                    this.label56.Text = "x6=";
                    this.label66.Text = "x6=";
                    this.button1.Visible = true;
                    this.button3.Visible = true;
                    this.button5.Visible = true;
                    this.button6.Visible = false;
                    this.pictureBox1.Size = new System.Drawing.Size(36, 344);
                    break;
                default:
                    break;

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double[,] Amatrix;
            double[,] Bmatrix;
            double[,] X, L, U, Y;
            int[] P;
            bool success;
            int operations;
            switch (comboBox1.SelectedItem)
            {
                case "3":
                    (Amatrix, Bmatrix, success) = ArrayToMatrix.RunAlgorithm(textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text,
                        textBox21.Text, textBox22.Text, textBox23.Text, textBox24.Text,
                        textBox31.Text, textBox32.Text, textBox33.Text, textBox34.Text);
                    if (success)
                    {
                        textBox1.Visible = true;
                        button8.Visible = true;
                        textBox1.Text = "Умова:\r\n";
                        textBox1.Text += MatrixToStringEquation(Amatrix, Bmatrix);
                        textBox1.Text += $"\r\n\r\nМетод LUP для ({comboBox1.SelectedItem} рівнянь)\r\n\r\n";
                        if (CalculateDeterminant(Amatrix) != 0)
                        {
                            (X, L, U, P, Y, operations) = Method1.LUP(Amatrix, Bmatrix);
                            if (!(double.IsNaN(X[0, 0])))
                            {
                                textBox1.Text += $"X1 = {Math.Round(X[0, 0], 3).ToString()}\r\n" +
                                $"X2 = {Math.Round(X[1, 0], 3).ToString()}\r\n" +
                                $"X3 = {Math.Round(X[2, 0], 3).ToString()}\r\n";
                                label4.Visible = true;
                                label5.Visible = true;
                                label5.Text = $"К-сть операцій: {operations}";
                                textBox1.Text += "\r\n-----------------\r\nРішення:\r\n";
                                textBox1.Text += $"L (нижньотрикутна матриця):\r\n" +
                                $"| {Math.Round(L[0, 0], 2)}  0   0  |\r\n" +
                                $"| {Math.Round(L[1, 0], 2)} {Math.Round(L[1, 1], 2)}  0  |\r\n" +
                                $"| {Math.Round(L[2, 0], 2)} {Math.Round(L[2, 1], 2)} {Math.Round(L[2, 2], 2)} |\r\n" +
                                $"\r\nU (верхньотрикутна матриця):\r\n" +
                                $"| {Math.Round(U[0, 0], 2)} {Math.Round(U[0, 1], 2)} {Math.Round(U[0, 2], 2)} |\r\n" +
                                $"|  0  {Math.Round(U[1, 1], 2)} {Math.Round(U[1, 2], 2)} |\r\n" +
                                $"|  0   0  {Math.Round(U[2, 2], 2)} |\r\n" +
                                $"\r\nP (матриця перестановок):\r\n" +
                                $"| {P[0]} |\r\n" +
                                $"| {P[1]} |\r\n" +
                                $"| {P[2]} |\r\n" +
                                $"\r\nМатриця Y:\r\n" +
                                $"| {Math.Round(Y[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[2, 0], 2)} |\r\n" +
                                $"\r\nМатриця X:\r\n" +
                                $"| {Math.Round(X[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[2, 0], 2)} |";
                            }
                            else
                            {
                                textBox1.Text += "Можливих рішень для заданого рівняння\r\nобраним способом не знайдено!";
                            }
                        }
                        else
                        {
                            textBox1.Text += "Введена матриця є вродженою (її визначник рівний нулю).\r\n" +
                                "Нажаль для цього випадку метод LUP не працює\r\n";
                        }
                    }
                    else
                    {
                        textBox1.Visible = false;
                        button8.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                    }
                    break;
                case "4":
                    (Amatrix, Bmatrix, success) = ArrayToMatrix.RunAlgorithm(textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text,
                        textBox21.Text, textBox22.Text, textBox23.Text, textBox24.Text, textBox25.Text,
                        textBox31.Text, textBox32.Text, textBox33.Text, textBox34.Text, textBox35.Text,
                        textBox41.Text, textBox42.Text, textBox43.Text, textBox44.Text, textBox45.Text);
                    if (success)
                    {
                        textBox1.Visible = true;
                        button8.Visible = true;
                        textBox1.Text = "Умова:\r\n";
                        textBox1.Text += MatrixToStringEquation(Amatrix, Bmatrix);
                        textBox1.Text += $"\r\n\r\nМетод LUP для ({comboBox1.SelectedItem} рівнянь)\r\n\r\n";
                        if (CalculateDeterminant(Amatrix) != 0)
                        {
                            (X, L, U, P, Y, operations) = Method1.LUP(Amatrix, Bmatrix);
                            if (!(double.IsNaN(X[0, 0])))
                            {
                                textBox1.Text += $"X1 = {Math.Round(X[0, 0], 3).ToString()}\r\n" +
                                $"X2 = {Math.Round(X[1, 0], 3).ToString()}\r\n" +
                                $"X3 = {Math.Round(X[2, 0], 3).ToString()}\r\n" +
                                $"X4 = {Math.Round(X[3, 0], 3).ToString()}\r\n";
                                label4.Visible = true;
                                label5.Text = $"К-сть операцій: {operations}";
                                textBox1.Text += "\r\n-----------------\r\nРішення:\r\n";
                                textBox1.Text += $"L (нижньотрикутна матриця):\r\n" +
                                $"| {Math.Round(L[0, 0], 2)}  0   0   0  |\r\n" +
                                $"| {Math.Round(L[1, 0], 2)} {Math.Round(L[1, 1], 2)}  0   0  |\r\n" +
                                $"| {Math.Round(L[2, 0], 2)} {Math.Round(L[2, 1], 2)} {Math.Round(L[2, 2], 2)}  0  |\r\n" +
                                $"| {Math.Round(L[3, 0], 2)} {Math.Round(L[3, 1], 2)} {Math.Round(L[3, 2], 2)} {Math.Round(L[3, 3], 2)} |\r\n" +
                                $"\r\nU (верхньотрикутна матриця):\r\n" +
                                $"| {Math.Round(U[0, 0], 2)} {Math.Round(U[0, 1], 2)} {Math.Round(U[0, 2], 2)} {Math.Round(U[0, 3], 2)} |\r\n" +
                                $"|  0  {Math.Round(U[1, 1], 2)} {Math.Round(U[1, 2], 2)} {Math.Round(U[1, 3], 2)} |\r\n" +
                                $"|  0   0  {Math.Round(U[2, 2], 2)} {Math.Round(U[2, 3], 2)} |\r\n" +
                                $"|  0   0   0  {Math.Round(U[3, 3], 2)} |\r\n" +
                                $"\r\nP (матриця перестановок):\r\n" +
                                $"| {P[0]} |\r\n" +
                                $"| {P[1]} |\r\n" +
                                $"| {P[2]} |\r\n" +
                                $"| {P[3]} |\r\n" +
                                $"|  {P[0]}  |\r\n" +
                                $"\r\nМатриця Y:\r\n" +
                                $"| {Math.Round(Y[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[2, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[3, 0], 2)} |\r\n" +
                                $"\r\nМатриця X:\r\n" +
                                $"| {Math.Round(X[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[2, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[3, 0], 2)} |";
                            }
                            else
                            {
                                textBox1.Text += "Можливих рішень для заданого рівняння\r\nобраним способом не знайдено!";
                            }
                        }
                        else
                        {
                            textBox1.Text += "Введена матриця є вродженою (її визначник рівний нулю).\r\n" +
                                "Нажаль для цього випадку метод LUP не працює\r\n";
                        }                        
                    }
                    else
                    {
                        textBox1.Visible = false;
                        button8.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                    }

                    break;
                case "5":
                    (Amatrix, Bmatrix, success) = ArrayToMatrix.RunAlgorithm(textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text, textBox16.Text,
                        textBox21.Text, textBox22.Text, textBox23.Text, textBox24.Text, textBox25.Text, textBox26.Text,
                        textBox31.Text, textBox32.Text, textBox33.Text, textBox34.Text, textBox35.Text, textBox36.Text,
                        textBox41.Text, textBox42.Text, textBox43.Text, textBox44.Text, textBox45.Text, textBox46.Text,
                        textBox51.Text, textBox52.Text, textBox53.Text, textBox54.Text, textBox55.Text, textBox56.Text);
                    if (success)
                    {
                        textBox1.Visible = true;
                        button8.Visible = true;
                        textBox1.Text = "Умова:\r\n";
                        textBox1.Text += MatrixToStringEquation(Amatrix, Bmatrix);
                        textBox1.Text += $"\r\n\r\nМетод LUP для ({comboBox1.SelectedItem} рівнянь)\r\n\r\n";
                        if (CalculateDeterminant(Amatrix) != 0)
                        {
                            (X, L, U, P, Y, operations) = Method1.LUP(Amatrix, Bmatrix);
                            if (!(double.IsNaN(X[0, 0])))
                            {
                                textBox1.Text += $"X1 = {Math.Round(X[0, 0], 3).ToString()}\r\n" +
                                $"X2 = {Math.Round(X[1, 0], 3).ToString()}\r\n" +
                                $"X3 = {Math.Round(X[2, 0], 3).ToString()}\r\n" +
                                $"X4 = {Math.Round(X[3, 0], 3).ToString()}\r\n" +
                                $"X5 = {Math.Round(X[4, 0], 3).ToString()}\r\n";
                                label4.Visible = true;
                                label5.Visible = true;
                                label5.Text = $"К-сть операцій: {operations}";
                                textBox1.Text += "\r\n-----------------\r\nРішення:\r\n";
                                textBox1.Text += $"L (нижньотрикутна матриця):\r\n" +
                                $"| {Math.Round(L[0, 0], 2)}  0   0   0   0  |\r\n" +
                                $"| {Math.Round(L[1, 0], 2)} {Math.Round(L[1, 1], 2)}  0   0   0  |\r\n" +
                                $"| {Math.Round(L[2, 0], 2)} {Math.Round(L[2, 1], 2)} {Math.Round(L[2, 2], 2)}  0   0  |\r\n" +
                                $"| {Math.Round(L[3, 0], 2)} {Math.Round(L[3, 1], 2)} {Math.Round(L[3, 2], 2)} {Math.Round(L[3, 3], 2)}  0  |\r\n" +
                                $"| {Math.Round(L[4, 0], 2)} {Math.Round(L[4, 1], 2)} {Math.Round(L[4, 2], 2)} {Math.Round(L[4, 3], 2)} {Math.Round(L[4, 4], 2)} |\r\n" +
                                $"\r\nU (верхньотрикутна матриця):\r\n" +
                                $"| {Math.Round(U[0, 0], 2)} {Math.Round(U[0, 1], 2)} {Math.Round(U[0, 2], 2)} {Math.Round(U[0, 3], 2)} {Math.Round(U[0, 4], 2)} |\r\n" +
                                $"|  0  {Math.Round(U[1, 1], 2)} {Math.Round(U[1, 2], 2)} {Math.Round(U[1, 3], 2)} {Math.Round(U[1, 4], 2)} |\r\n" +
                                $"|  0   0  {Math.Round(U[2, 2], 2)} {Math.Round(U[2, 3], 2)} {Math.Round(U[2, 4], 2)} |\r\n" +
                                $"|  0   0   0  {Math.Round(U[3, 3], 2)} {Math.Round(U[3, 4], 2)} |\r\n" +
                                $"|  0   0   0   0  {Math.Round(U[4, 4], 2)} |\r\n" +
                                $"\r\nP (матриця перестановок):\r\n" +
                                $"| {P[0]} |\r\n" +
                                $"| {P[1]} |\r\n" +
                                $"| {P[2]} |\r\n" +
                                $"| {P[3]} |\r\n" +
                                $"| {P[4]} |\r\n" +
                                $"\r\nМатриця Y:\r\n" +
                                $"| {Math.Round(Y[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[2, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[3, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[4, 0], 2)} |\r\n" +
                                $"\r\nМатриця X:\r\n" +
                                $"| {Math.Round(X[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[2, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[3, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[4, 0], 2)} |";
                            }
                            else
                            {
                                textBox1.Text += "Можливих рішень для заданого рівняння\r\nобраним способом не знайдено!";
                            }
                        }
                        else
                        {
                            textBox1.Text += "Введена матриця є вродженою (її визначник рівний нулю).\r\n" +
                                "Нажаль для цього випадку метод LUP не працює\r\n";
                        }                        
                    }
                    else
                    {
                        textBox1.Visible = false;
                        button8.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                    }

                    break;
                case "6":
                    (Amatrix, Bmatrix, success) = ArrayToMatrix.RunAlgorithm(textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text, textBox16.Text, textBox17.Text,
                        textBox21.Text, textBox22.Text, textBox23.Text, textBox24.Text, textBox25.Text, textBox26.Text, textBox27.Text,
                        textBox31.Text, textBox32.Text, textBox33.Text, textBox34.Text, textBox35.Text, textBox36.Text, textBox37.Text,
                        textBox41.Text, textBox42.Text, textBox43.Text, textBox44.Text, textBox45.Text, textBox46.Text, textBox47.Text,
                        textBox51.Text, textBox52.Text, textBox53.Text, textBox54.Text, textBox55.Text, textBox56.Text, textBox57.Text,
                        textBox61.Text, textBox62.Text, textBox63.Text, textBox64.Text, textBox65.Text, textBox66.Text, textBox67.Text);
                    if (success)
                    {
                        
                        textBox1.Visible = true;
                        button8.Visible = true;
                        textBox1.Text = "Умова:\r\n";
                        textBox1.Text += MatrixToStringEquation(Amatrix, Bmatrix);
                        textBox1.Text += $"\r\n\r\nМетод LUP для ({comboBox1.SelectedItem} рівнянь)\r\n\r\n";
                        if (CalculateDeterminant(Amatrix) != 0)
                        {
                            (X, L, U, P, Y, operations) = Method1.LUP(Amatrix, Bmatrix);                            
                            if (!(double.IsNaN(X[0, 0])))
                            {
                                textBox1.Text += $"X1 = {Math.Round(X[0, 0], 3).ToString()}\r\n" +
                                $"X2 = {Math.Round(X[1, 0], 3).ToString()}\r\n" +
                                $"X3 = {Math.Round(X[2, 0], 3).ToString()}\r\n" +
                                $"X4 = {Math.Round(X[3, 0], 3).ToString()}\r\n" +
                                $"X5 = {Math.Round(X[4, 0], 3).ToString()}\r\n" +
                                $"X6 = {Math.Round(X[5, 0], 3).ToString()}\r\n";
                                label4.Visible = true;
                                label5.Visible = true;
                                label5.Text = $"К-сть операцій: {operations}";
                                textBox1.Text += "\r\n-----------------\r\nРішення:\r\n";
                                textBox1.Text += $"L (нижньотрикутна матриця):\r\n" +
                                $"| {Math.Round(L[0, 0], 2)}  0   0   0   0   0  |\r\n" +
                                $"| {Math.Round(L[1, 0], 2)} {Math.Round(L[1, 1], 2)}  0   0   0   0  |\r\n" +
                                $"| {Math.Round(L[2, 0], 2)} {Math.Round(L[2, 1], 2)} {Math.Round(L[2, 2], 2)}  0   0   0  |\r\n" +
                                $"| {Math.Round(L[3, 0], 2)} {Math.Round(L[3, 1], 2)} {Math.Round(L[3, 2], 2)} {Math.Round(L[3, 3], 2)}  0   0  |\r\n" +
                                $"| {Math.Round(L[4, 0], 2)} {Math.Round(L[4, 1], 2)} {Math.Round(L[4, 2], 2)} {Math.Round(L[4, 3], 2)} {Math.Round(L[4, 4], 2)}  0  |\r\n" +
                                $"| {Math.Round(L[5, 0], 2)} {Math.Round(L[5, 1], 2)} {Math.Round(L[5, 2], 2)} {Math.Round(L[5, 3], 2)} {Math.Round(L[5, 4], 2)} {Math.Round(L[5, 5], 2)} |\r\n" +
                                $"\r\nU (верхньотрикутна матриця):\r\n" +
                                $"| {Math.Round(U[0, 0], 2)} {Math.Round(U[0, 1], 2)} {Math.Round(U[0, 2], 2)} {Math.Round(U[0, 3], 2)} {Math.Round(U[0, 4], 2)} {Math.Round(U[0, 5], 2)} |\r\n" +
                                $"|  0  {Math.Round(U[1, 1], 2)} {Math.Round(U[1, 2], 2)} {Math.Round(U[1, 3], 2)} {Math.Round(U[1, 4], 2)} {Math.Round(U[1, 5], 2)} |\r\n" +
                                $"|  0   0  {Math.Round(U[2, 2], 2)} {Math.Round(U[2, 3], 2)} {Math.Round(U[2, 4], 2)} {Math.Round(U[2, 5], 2)} |\r\n" +
                                $"|  0   0   0  {Math.Round(U[3, 3], 2)} {Math.Round(U[3, 4], 2)} {Math.Round(U[3, 5], 2)} |\r\n" +
                                $"|  0   0   0   0  {Math.Round(U[4, 4], 2)} {Math.Round(U[4, 5], 2)} |\r\n" +
                                $"|  0   0   0   0   0  {Math.Round(U[5, 5], 2)} |\r\n" +
                                $"\r\nP (матриця перестановок):\r\n" +
                                $"| {P[0]} |\r\n" +
                                $"| {P[1]} |\r\n" +
                                $"| {P[2]} |\r\n" +
                                $"| {P[3]} |\r\n" +
                                $"| {P[4]} |\r\n" +
                                $"| {P[5]} |\r\n" +
                                $"\r\nМатриця Y:\r\n" +
                                $"| {Math.Round(Y[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[2, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[3, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[4, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[5, 0], 2)} |\r\n" +
                                $"\r\nМатриця X:\r\n" +
                                $"| {Math.Round(X[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[2, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[3, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[4, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[5, 0], 2)} |";
                            }
                            else
                            {
                                textBox1.Text += "Можливих рішень для заданого рівняння\r\nобраним способом не знайдено!";
                            }
                        }
                        else
                        {
                            textBox1.Text += "Введена матриця є вродженою (її визначник рівний нулю).\r\n" +
                                "Нажаль для цього випадку метод LUP не працює\r\n";
                        }
                    }
                    else
                    {
                        textBox1.Visible = false;
                        button8.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                    }
                    break;
            }
            
        }

        private string MatrixToStringEquation(double[,] matrix, double[,] results)
        {
            StringBuilder sb = new StringBuilder();
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                sb.Append("|");
                for (int j = 0; j < columns; j++)
                {
                    sb.AppendFormat("{0,3} ", matrix[i, j]);
                }
                sb.Append("|");

                // Додавання змінних (X1, X2, ...)
                if (i == rows / 2) // Центрування для середини матриці
                {
                    sb.AppendFormat("  *   | X{0} |   =   | {1} |", i + 1, results[0, i]);
                }
                else
                {
                    sb.AppendFormat("      | X{0} |       | {1} |", i + 1, results[0, i]);
                }

                if (i < rows - 1)
                {
                    sb.AppendLine();
                }
            }
            return sb.ToString();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            double[,] Amatrix;
            double[,] Bmatrix, L, LUp, Y, X;
            int operations = 0;
            bool success;
            switch (comboBox1.SelectedItem)
            {     
                case "3":
                    (Amatrix, Bmatrix, success) = ArrayToMatrix.RunAlgorithm(textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text,
                        textBox21.Text, textBox22.Text, textBox23.Text, textBox24.Text,
                        textBox31.Text, textBox32.Text, textBox33.Text, textBox34.Text);
                    if (success)
                    {                        
                        textBox1.Visible = true;
                        button8.Visible = true;
                        textBox1.Text = "Умова:\r\n";
                        textBox1.Text += MatrixToStringEquation(Amatrix, Bmatrix);
                        textBox1.Text += $"\r\n\r\nМетод Холеського ({comboBox1.SelectedItem} рівнянь)\r\n\r\n";
                        if (CalculateDeterminant(Amatrix) != 0)
                        {
                            (X, L, LUp, Y, operations) = Method3.Cholesky(Amatrix, Bmatrix);
                            if (!(IsPositiveDefinite(Amatrix) && IsSymmetric(Amatrix)))
                            {
                                textBox1.Text += "Матриця не є симетричною та додатньо\r\nвизначеною одночасно!\r\n" +
                                    "Метод Холеського не працює!";
                                label5.Visible = false;
                            }
                            else if(!(double.IsNaN(X[0, 0])))
                            {
                                textBox1.Text += $"X1 = {Math.Round(X[0, 0], 3).ToString()}\r\n" +
                                $"X2 = {Math.Round(X[1, 0], 3).ToString()}\r\n" +
                                $"X3 = {Math.Round(X[2, 0], 3).ToString()}\r\n";
                                label4.Visible = true;
                                label5.Visible = true;
                                label5.Text = $"К-сть операцій: {operations}";
                                textBox1.Text += "\r\n-----------------\r\nРішення:\r\n";
                                textBox1.Text += $"L (нижньотрикутна матриця):\r\n" +
                                $"| {Math.Round(L[0, 0], 2)}  0   0  |\r\n" +
                                $"| {Math.Round(L[1, 0], 2)} {Math.Round(L[1, 1], 2)}  0  |\r\n" +
                                $"| {Math.Round(L[2, 0], 2)} {Math.Round(L[2, 1], 2)} {Math.Round(L[2, 2], 2)} |\r\n" +
                                $"\r\nU (верхньотрикутна матриця):\r\n" +
                                $"|  {Math.Round(LUp[0, 0], 2)} {Math.Round(LUp[0, 1], 2)} {Math.Round(LUp[0, 2], 2)} |\r\n" +
                                $"|  0   {Math.Round(LUp[1, 1], 2)} {Math.Round(LUp[1, 2], 2)} |\r\n" +
                                $"|  0   0   {Math.Round(LUp[2, 2], 2)} |\r\n" +
                                $"\r\nМатриця Y:\r\n" +
                                $"| {Math.Round(Y[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[2, 0], 2)} |\r\n" +
                                $"\r\nМатриця X:\r\n" +
                                $"| {Math.Round(X[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[2, 0], 2)} |";
                            }
                            else
                            {
                                textBox1.Text += "Можливих рішень для заданого рівняння\r\nобраним способом не знайдено!";
                            }
                        }
                        else
                        {
                            textBox1.Text += "Введена матриця є вродженою (її визначник рівний нулю).\r\n" +
                                "Нажаль для цього випадку метод Холеського не працює\r\n";
                            
                        }
                    }
                    else
                    {
                        textBox1.Visible = false;
                        button8.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                    }
                    break;
                case "4":
                    (Amatrix, Bmatrix, success) = ArrayToMatrix.RunAlgorithm(textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text,
                        textBox21.Text, textBox22.Text, textBox23.Text, textBox24.Text, textBox25.Text,
                        textBox31.Text, textBox32.Text, textBox33.Text, textBox34.Text, textBox35.Text,
                        textBox41.Text, textBox42.Text, textBox43.Text, textBox44.Text, textBox45.Text);
                    if (success)
                    {
                        textBox1.Visible = true;
                        button8.Visible = true;
                        textBox1.Text = "Умова:\r\n";
                        textBox1.Text += MatrixToStringEquation(Amatrix, Bmatrix);
                        textBox1.Text += $"\r\n\r\nМетод Холеського ({comboBox1.SelectedItem} рівнянь)\r\n\r\n";
                        if (CalculateDeterminant(Amatrix) != 0)
                        {
                            (X, L, LUp, Y, operations) = Method3.Cholesky(Amatrix, Bmatrix);
                            if (!(IsPositiveDefinite(Amatrix) && IsSymmetric(Amatrix)))
                            {
                                textBox1.Text += "Матриця не є симетричною та додатньо\r\nвизначеною одночасно!\r\n" +
                                    "Метод Холеського не працює!";
                                label5.Visible = false;
                            }
                            else if (!(double.IsNaN(X[0, 0])))
                            {
                                textBox1.Text += $"X1 = {Math.Round(X[0, 0], 3).ToString()}\r\n" +
                                $"X2 = {Math.Round(X[1, 0], 3).ToString()}\r\n" +
                                $"X3 = {Math.Round(X[2, 0], 3).ToString()}\r\n" +
                                $"X4 = {Math.Round(X[3, 0], 3).ToString()}\r\n";
                                label4.Visible = true;
                                label5.Visible = true;
                                label5.Text = $"К-сть операцій: {operations}";
                                textBox1.Text += "\r\n-----------------\r\nРішення:\r\n";
                                textBox1.Text += $"L (нижньотрикутна матриця):\r\n" +
                                $"| {Math.Round(L[0, 0], 2)}  0   0  0  |\r\n" +
                                $"| {Math.Round(L[1, 0], 2)} {Math.Round(L[1, 1], 2)}  0  0  |\r\n" +
                                $"| {Math.Round(L[2, 0], 2)} {Math.Round(L[2, 1], 2)} {Math.Round(L[2, 2], 2)}  0 |\r\n" +
                                $"| {Math.Round(L[3, 0], 2)} {Math.Round(L[3, 1], 2)} {Math.Round(L[3, 2], 2)}  {Math.Round(L[3, 3], 2)} |\r\n" +
                                $"\r\nU (верхньотрикутна матриця):\r\n" +
                                $"|  {Math.Round(LUp[0, 0], 2)} {Math.Round(LUp[0, 1], 2)} {Math.Round(LUp[0, 2], 2)}  {Math.Round(LUp[0, 3], 2)} |\r\n" +
                                $"|  0   {Math.Round(LUp[1, 1], 2)} {Math.Round(LUp[1, 2], 2)}  {Math.Round(LUp[1, 3], 2)} |\r\n" +
                                $"|  0   0   {Math.Round(LUp[2, 2], 2)}  {Math.Round(LUp[2, 3], 2)} |\r\n" +
                                $"|  0   0   0   {Math.Round(LUp[3, 3], 2)} |\r\n" +
                                $"\r\nМатриця Y:\r\n" +
                                $"| {Math.Round(Y[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[2, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[3, 0], 2)} |\r\n" +
                                $"\r\nМатриця X:\r\n" +
                                $"| {Math.Round(X[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[2, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[3, 0], 2)} |";
                            }
                            else
                            {
                                textBox1.Text += "Можливих рішень для заданого рівняння\r\nобраним способом не знайдено!";
                            }
                        }
                        else
                        {
                            textBox1.Text += "Введена матриця є вродженою (її визначник рівний нулю).\r\n" +
                                "Нажаль для цього випадку метод Холеського не працює\r\n";
                        }
                    }
                    else
                    {
                        textBox1.Visible = false;
                        button8.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                    }
                    break;
                case "5":
                    (Amatrix, Bmatrix, success) = ArrayToMatrix.RunAlgorithm(textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text, textBox16.Text,
                        textBox21.Text, textBox22.Text, textBox23.Text, textBox24.Text, textBox25.Text, textBox26.Text,
                        textBox31.Text, textBox32.Text, textBox33.Text, textBox34.Text, textBox35.Text, textBox36.Text,
                        textBox41.Text, textBox42.Text, textBox43.Text, textBox44.Text, textBox45.Text, textBox46.Text,
                        textBox51.Text, textBox52.Text, textBox53.Text, textBox54.Text, textBox55.Text, textBox56.Text);
                    if (success)
                    {                        
                        textBox1.Visible = true;
                        button8.Visible = true;
                        textBox1.Text = "Умова:\r\n";
                        textBox1.Text += MatrixToStringEquation(Amatrix, Bmatrix);
                        textBox1.Text += $"\r\n\r\nМетод Холеського ({comboBox1.SelectedItem} рівнянь)\r\n\r\n";
                        if (CalculateDeterminant(Amatrix) != 0)
                        {
                            (X, L, LUp, Y, operations) = Method3.Cholesky(Amatrix, Bmatrix);
                            if (!(IsPositiveDefinite(Amatrix) && IsSymmetric(Amatrix)))
                            {
                                textBox1.Text += "Матриця не є симетричною та додатньо\r\nвизначеною одночасно!\r\n" +
                                    "Метод Холеського не працює!";
                                label5.Visible = false;
                            }
                            else if (!(double.IsNaN(X[0, 0])))
                            {
                                textBox1.Text += $"X1 = {Math.Round(X[0, 0], 3).ToString()}\r\n" +
                                $"X2 = {Math.Round(X[1, 0], 3).ToString()}\r\n" +
                                $"X3 = {Math.Round(X[2, 0], 3).ToString()}\r\n" +
                                $"X4 = {Math.Round(X[3, 0], 3).ToString()}\r\n" +
                                $"X5 = {Math.Round(X[4, 0], 3).ToString()}\r\n";
                                label4.Visible = true;
                                label5.Visible = true;
                                label5.Text = $"К-сть операцій: {operations}";
                                textBox1.Text += "\r\n-----------------\r\nРішення:\r\n";
                                textBox1.Text += $"L (нижньотрикутна матриця):\r\n" +
                                $"| {Math.Round(L[0, 0], 2)}  0   0  0  0  |\r\n" +
                                $"| {Math.Round(L[1, 0], 2)} {Math.Round(L[1, 1], 2)}  0  0  0  |\r\n" +
                                $"| {Math.Round(L[2, 0], 2)} {Math.Round(L[2, 1], 2)} {Math.Round(L[2, 2], 2)}  0  0 |\r\n" +
                                $"| {Math.Round(L[3, 0], 2)} {Math.Round(L[3, 1], 2)} {Math.Round(L[3, 2], 2)}  {Math.Round(L[3, 3], 2)}  0 |\r\n" +
                                $"| {Math.Round(L[4, 0], 2)} {Math.Round(L[4, 1], 2)} {Math.Round(L[4, 2], 2)}  {Math.Round(L[4, 3], 2)}  {Math.Round(L[4, 4], 2)} |\r\n" +
                                $"\r\nU (верхньотрикутна матриця):\r\n" +
                                $"|  {Math.Round(LUp[0, 0], 2)} {Math.Round(LUp[0, 1], 2)} {Math.Round(LUp[0, 2], 2)}  {Math.Round(LUp[0, 3], 2)}  {Math.Round(LUp[0, 4], 2)} |\r\n" +
                                $"|  0   {Math.Round(LUp[1, 1], 2)} {Math.Round(LUp[1, 2], 2)}  {Math.Round(LUp[1, 3], 2)}  {Math.Round(LUp[1, 4], 2)} |\r\n" +
                                $"|  0   0   {Math.Round(LUp[2, 2], 2)}  {Math.Round(LUp[2, 3], 2)}  {Math.Round(LUp[2, 4], 2)} |\r\n" +
                                $"|  0   0   0   {Math.Round(LUp[3, 3], 2)}  {Math.Round(LUp[3, 4], 2)} |\r\n" +
                                $"|  0   0   0   0   {Math.Round(LUp[4, 4], 2)} |\r\n" +
                                $"\r\nМатриця Y:\r\n" +
                                $"| {Math.Round(Y[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[2, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[3, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[4, 0], 2)} |\r\n" +
                                $"\r\nМатриця X:\r\n" +
                                $"| {Math.Round(X[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[2, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[3, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[4, 0], 2)} |";
                            }
                            else
                            {
                                textBox1.Text += "Можливих рішень для заданого рівняння\r\nобраним способом не знайдено!";
                            }
                        }
                        else
                        {
                            textBox1.Text += "Введена матриця є вродженою (її визначник рівний нулю).\r\n" +
                                "Нажаль для цього випадку метод Холеського не працює\r\n";
                        }
                    }
                    else
                    {
                        textBox1.Visible = false;
                        button8.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                    }
                    break;
                case "6":
                    (Amatrix, Bmatrix, success) = ArrayToMatrix.RunAlgorithm(textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text, textBox16.Text, textBox17.Text,
                        textBox21.Text, textBox22.Text, textBox23.Text, textBox24.Text, textBox25.Text, textBox26.Text, textBox27.Text,
                        textBox31.Text, textBox32.Text, textBox33.Text, textBox34.Text, textBox35.Text, textBox36.Text, textBox37.Text,
                        textBox41.Text, textBox42.Text, textBox43.Text, textBox44.Text, textBox45.Text, textBox46.Text, textBox47.Text,
                        textBox51.Text, textBox52.Text, textBox53.Text, textBox54.Text, textBox55.Text, textBox56.Text, textBox57.Text,
                        textBox61.Text, textBox62.Text, textBox63.Text, textBox64.Text, textBox65.Text, textBox66.Text, textBox67.Text);
                    if (success)
                    {                        
                        textBox1.Visible = true;
                        button8.Visible = true;
                        textBox1.Text = "Умова:\r\n";
                        textBox1.Text += MatrixToStringEquation(Amatrix, Bmatrix);
                        textBox1.Text += $"\r\n\r\nМетод Холеського ({comboBox1.SelectedItem} рівнянь)\r\n\r\n";
                        if (CalculateDeterminant(Amatrix) != 0)
                        {
                            (X, L, LUp, Y, operations) = Method3.Cholesky(Amatrix, Bmatrix);
                            if (!(IsPositiveDefinite(Amatrix) && IsSymmetric(Amatrix)))
                            {
                                textBox1.Text += "Матриця не є симетричною та додатньо\r\nвизначеною одночасно!\r\n" +
                                    "Метод Холеського не працює!";
                                label5.Visible = false;
                            }
                            else if (!(double.IsNaN(X[0, 0])))
                            {
                                textBox1.Text += $"X1 = {Math.Round(X[0, 0], 3).ToString()}\r\n" +
                                $"X2 = {Math.Round(X[1, 0], 3).ToString()}\r\n" +
                                $"X3 = {Math.Round(X[2, 0], 3).ToString()}\r\n" +
                                $"X4 = {Math.Round(X[3, 0], 3).ToString()}\r\n" +
                                $"X5 = {Math.Round(X[4, 0], 3).ToString()}\r\n" +
                                $"X6 = {Math.Round(X[5, 0], 3).ToString()}\r\n";
                                label4.Visible = true;
                                label5.Visible = true;
                                label5.Text = $"К-сть операцій: {operations}";
                                textBox1.Text += "\r\n-----------------\r\nРішення:\r\n";
                                textBox1.Text += $"L (нижньотрикутна матриця):\r\n" +
                                $"| {Math.Round(L[0, 0], 2)}   0   0   0   0   0   |\r\n" +
                                $"| {Math.Round(L[1, 0], 2)} {Math.Round(L[1, 1], 2)}   0   0   0   0   |\r\n" +
                                $"| {Math.Round(L[2, 0], 2)} {Math.Round(L[2, 1], 2)} {Math.Round(L[2, 2], 2)}   0   0   0   |\r\n" +
                                $"| {Math.Round(L[3, 0], 2)} {Math.Round(L[3, 1], 2)} {Math.Round(L[3, 2], 2)}  {Math.Round(L[3, 3], 2)}   0   0   |\r\n" +
                                $"| {Math.Round(L[4, 0], 2)} {Math.Round(L[4, 1], 2)} {Math.Round(L[4, 2], 2)}  {Math.Round(L[4, 3], 2)}  {Math.Round(L[4, 4], 2)}   0  |\r\n" +
                                $"| {Math.Round(L[5, 0], 2)} {Math.Round(L[5, 1], 2)} {Math.Round(L[5, 2], 2)}  {Math.Round(L[5, 3], 2)}  {Math.Round(L[5, 4], 2)}  {Math.Round(L[5, 5], 2)}  |\r\n" +
                                $"\r\nU (верхньотрикутна матриця):\r\n" +
                                $"|   {Math.Round(LUp[0, 0], 2)}  {Math.Round(LUp[0, 1], 2)}  {Math.Round(LUp[0, 2], 2)}  {Math.Round(LUp[0, 3], 2)}  {Math.Round(LUp[0, 4], 2)}  {Math.Round(LUp[0, 5], 2)} |\r\n" +
                                $"|   0   {Math.Round(LUp[1, 1], 2)}  {Math.Round(LUp[1, 2], 2)}  {Math.Round(LUp[1, 3], 2)}  {Math.Round(LUp[1, 4], 2)}  {Math.Round(LUp[1, 5], 2)} |\r\n" +
                                $"|   0   0   {Math.Round(LUp[2, 2], 2)}  {Math.Round(LUp[2, 3], 2)}  {Math.Round(LUp[2, 4], 2)}  {Math.Round(LUp[2, 5], 2)} |\r\n" +
                                $"|   0   0   0   {Math.Round(LUp[3, 3], 2)}  {Math.Round(LUp[3, 4], 2)}  {Math.Round(LUp[3, 5], 2)} |\r\n" +
                                $"|   0   0   0   0   {Math.Round(LUp[4, 4], 2)}  {Math.Round(LUp[0, 5], 2)} |\r\n" +
                                $"|   0   0   0   0   0   {Math.Round(LUp[5, 5], 2)} |\r\n" +
                                $"\r\nМатриця Y:\r\n" +
                                $"| {Math.Round(Y[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[2, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[3, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[4, 0], 2)} |\r\n" +
                                $"| {Math.Round(Y[5, 0], 2)} |\r\n" +
                                $"\r\nМатриця X:\r\n" +
                                $"| {Math.Round(X[0, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[1, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[2, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[3, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[4, 0], 2)} |\r\n" +
                                $"| {Math.Round(X[5, 0], 2)} |";
                            }
                            else
                            {
                                textBox1.Text += "Можливих рішень для заданого рівняння\r\nобраним способом не знайдено!";
                            }
                        }
                        else
                        {
                            textBox1.Text += "Введена матриця є вродженою (її визначник рівний нулю).\r\n" +
                                "Нажаль для цього випадку метод Холеського не працює\r\n";
                        }
                    }
                    else
                    {
                        textBox1.Visible = false;
                        button8.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                    }
                    break;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool success;
            double[,] Amatrix, Bmatrix;
            (Amatrix, Bmatrix, success) = ArrayToMatrix.RunAlgorithm(textBox11.Text, textBox12.Text, textBox13.Text,
                textBox21.Text, textBox22.Text, textBox23.Text);            
            var solution = _2x2.Solve(Amatrix, Bmatrix);
            if (solution != null)
            {
                double x = Math.Round(solution.Value.Item1, 3);
                double y = Math.Round(solution.Value.Item2, 3);
                if (double.IsNaN(x) || double.IsNaN(y) || Math.Abs(x) == double.PositiveInfinity || Math.Abs(y) == double.PositiveInfinity)
                {
                    Form4 form4 = new Form4();
                    form4.Label1Text = $"{Amatrix[0, 0]} * X1 + {Amatrix[0, 1]} * X2 = {Bmatrix[0, 0]}";
                    form4.Label2Text = $"{Amatrix[1, 0]} * X1 + {Amatrix[1, 1]} * X2 = {Bmatrix[0, 1]}";
                    form4.Label3Text = $"Прямі паралельні або \r\nзалежні.Система не має \r\nрішень або їх надто багато.";
                    form4.DrawLinesAndIntersection(Amatrix, Bmatrix);
                    form4.ShowDialog();
                }
                else
                {
                    Form4 form4 = new Form4();
                    form4.Label1Text = $"{Amatrix[0, 0]} * X1 + {Amatrix[0, 1]} * X2 = {Bmatrix[0, 0]}";
                    form4.Label2Text = $"{Amatrix[1, 0]} * X1 + {Amatrix[1, 1]} * X2 = {Bmatrix[0, 1]}";
                    form4.Label3Text = $"Відповіддю є точка: ({x.ToString()}:{y.ToString()})";
                    form4.DrawLinesAndIntersection(x, y, Amatrix, Bmatrix);
                    form4.ShowDialog();
                }
                    
            }
            else
            {
                MessageBox.Show($"Система не має рішень або їх надто багато!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
            
        }

        public static bool IsSymmetric(double[,] matrix)
        {
            int n = matrix.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        private static bool IsPositiveDefinite(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 1; i <= n; i++)
            {
                double[,] minor = GetMinor(matrix, i);
                double det = CalculateDeterminant(minor);
                if (det <= 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static double CalculateDeterminant(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            double det = 0;
            if (n == 1)
            {
                return matrix[0, 0];
            }
            else if (n == 2)
            {
                return ((matrix[0, 0] * matrix[1, 1]) - (matrix[1, 0] * matrix[0, 1]));
            }
            else
            {
                for (int p = 0; p < n; p++)
                {
                    double[,] minor = GetMinor(matrix, 0, p);
                    det += matrix[0, p] * Math.Pow(-1, p) * CalculateDeterminant(minor);
                }
                return det;
            }
        }

        private static double[,] GetMinor(double[,] matrix, int row, int col)
        {
            int n = matrix.GetLength(0);
            double[,] output = new double[n - 1, n - 1];
            int i = 0, j = 0;
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (r != row && c != col)
                    {
                        output[i, j] = matrix[r, c];
                        j++;
                        if (j == n - 1)
                        {
                            j = 0;
                            i++;
                        }
                    }
                }
            }
            return output;
        }
        private static double[,] GetMinor(double[,] matrix, int size)
        {
            double[,] minor = new double[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    minor[i, j] = matrix[i, j];
                }
            }
            return minor;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SetRandomTextToTextBoxes(panel1);
        }
        private void SetRandomTextToTextBoxes(Control parentControl)
        {
            Random rnd = new Random();
            HashSet<int> usedValues = new HashSet<int>();
            List<TextBox> textBoxes = new List<TextBox>();

            
            CollectTextBoxes(parentControl, textBoxes);

            
            foreach (var textBox in textBoxes)
            {
                int newValue;
                do
                {
                    newValue = rnd.Next(-100, 101);
                } while (usedValues.Contains(newValue) && usedValues.Count < 202);

                usedValues.Add(newValue);
                textBox.Text = newValue.ToString();
            }
        }

        private void CollectTextBoxes(Control parentControl, List<TextBox> textBoxes)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBoxes.Add(textBox);
                }
                else if (control.HasChildren)
                {
                    CollectTextBoxes(control, textBoxes);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                saveFileDialog.Title = "Save a Text File";
                saveFileDialog.DefaultExt = "txt";

                
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        
                        File.WriteAllText(filePath, textBox1.Text);
                        MessageBox.Show("Файл успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show($"Помилка при збереженні файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void інструкціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4About form4 = new Form4About();
            form4.ShowDialog();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
