using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;

namespace System_Of_Linear_Equation
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        public string Label1Text
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string Label2Text
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }
        public string Label3Text
        {
            get { return label3.Text; }
            set { label3.Text = value; }
        }
        public void DrawLinesAndIntersection(double x, double y, double[,] AMatrix, double[,] BMatrix)
        {
            var model = new PlotModel { Background = OxyColors.LightGray };

            double k = (Math.Abs(x) + Math.Abs(y)) * 2;

            // Перша пряма
            var line1 = new LineSeries
            {
                Title = "Перша пряма",
                StrokeThickness = 2,
                Color = OxyColors.Blue
            };
            line1.Points.Add(new OxyPlot.DataPoint(-k, (BMatrix[0, 0] - AMatrix[0, 0] * -k) / AMatrix[0, 1]));
            line1.Points.Add(new OxyPlot.DataPoint(k, (BMatrix[0, 0] - AMatrix[0, 0] * k) / AMatrix[0, 1]));

            // Друга пряма
            var line2 = new LineSeries
            {
                Title = "Друга пряма",
                StrokeThickness = 2,
                Color = OxyColors.Green
            };
            line2.Points.Add(new OxyPlot.DataPoint(-k, (BMatrix[0, 1] - AMatrix[1, 0] * -k) / AMatrix[1, 1]));
            line2.Points.Add(new OxyPlot.DataPoint(k, (BMatrix[0, 1] - AMatrix[1, 0] * k) / AMatrix[1, 1]));

            // Точка перетину
            var intersection = new ScatterSeries
            {
                Title = "Точка перетину",
                MarkerType = MarkerType.Circle,
                MarkerFill = OxyColors.Red,
                MarkerSize = 5
            };
            intersection.Points.Add(new ScatterPoint(x, y));

            model.Series.Add(line1);
            model.Series.Add(line2);
            model.Series.Add(intersection);

            plotView1.Model = model;
        }

        public void DrawLinesAndIntersection(double[,] AMatrix, double[,] BMatrix)
        {
            var model = new PlotModel { Background = OxyColors.LightGray };

            // Перша пряма
            var line1 = new LineSeries
            {
                Title = "Перша пряма",
                StrokeThickness = 2,//ширина прямої
                Color = OxyColors.Blue
            };
            var line2 = new LineSeries
            {
                Title = "Друга пряма",
                StrokeThickness = 2,
                Color = OxyColors.Green
            };
            if (AMatrix[0,1] == 0 && AMatrix[1,1] == 0)
            {
                line1.Points.Add(new OxyPlot.DataPoint(BMatrix[0, 0], -100));
                line1.Points.Add(new OxyPlot.DataPoint(BMatrix[0, 0], 100));

                line2.Points.Add(new OxyPlot.DataPoint(BMatrix[0, 1], -100));
                line2.Points.Add(new OxyPlot.DataPoint(BMatrix[0, 1], 100));
            }
            else if (AMatrix[0, 0] == 0 && AMatrix[1, 0] == 0)
            {
                line1.Points.Add(new OxyPlot.DataPoint(-100, BMatrix[0, 0]));
                line1.Points.Add(new OxyPlot.DataPoint(100, BMatrix[0, 0]));

                line2.Points.Add(new OxyPlot.DataPoint(-100, BMatrix[0, 1]));
                line2.Points.Add(new OxyPlot.DataPoint(100, BMatrix[0, 1]));
            }
            else
            {
                line1.Points.Add(new OxyPlot.DataPoint(-100, (BMatrix[0, 0] - AMatrix[0, 0] * -100) / AMatrix[0, 1]));
                line1.Points.Add(new OxyPlot.DataPoint(100, (BMatrix[0, 0] - AMatrix[0, 0] * 100) / AMatrix[0, 1]));

                line2.Points.Add(new OxyPlot.DataPoint(-100, (BMatrix[0, 1] - AMatrix[1, 0] * -100) / AMatrix[1, 1]));
                line2.Points.Add(new OxyPlot.DataPoint(100, (BMatrix[0, 1] - AMatrix[1, 0] * 100) / AMatrix[1, 1]));
            }             
            

            model.Series.Add(line1);
            model.Series.Add(line2);

            plotView1.Model = model;
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                saveFileDialog.Title = "Save a Text File";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.AddExtension = true;

                // Открытие диалогового окна и проверка выбора файла пользователем
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Получение пути к выбранному файлу
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        // Добавление содержимого TextBox в конец файла
                        File.WriteAllText(filePath, label1.Text + Environment.NewLine);
                        File.AppendAllText(filePath, label2.Text + Environment.NewLine);
                        File.AppendAllText(filePath, label3.Text + Environment.NewLine);
                        MessageBox.Show("Рішення успішно додано у файл!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Обработка ошибок при записи файла
                        MessageBox.Show($"Помилка додавання у файл: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        

        private void plotView1_Click(object sender, EventArgs e)
        {

        }
    }
}
