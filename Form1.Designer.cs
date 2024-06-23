using System.IO;
using System;
using System.Windows.Forms;

namespace System_Of_Linear_Equation
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.допомогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інструкціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(69, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(696, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кількість невідомих величин в системі:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(562, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "Заповніть систему лінійних рівнянь:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox14.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox14.Location = new System.Drawing.Point(4, 14);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(72, 39);
            this.textBox14.TabIndex = 6;
            this.textBox14.Text = "0";
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox24.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox24.Location = new System.Drawing.Point(4, 105);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(72, 39);
            this.textBox24.TabIndex = 12;
            this.textBox24.Text = "0";
            this.textBox24.TextChanged += new System.EventHandler(this.textBox24_TextChanged);
            // 
            // textBox41
            // 
            this.textBox41.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox41.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox41.Location = new System.Drawing.Point(12, 29);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(72, 39);
            this.textBox41.TabIndex = 17;
            this.textBox41.Text = "0";
            this.textBox41.TextChanged += new System.EventHandler(this.textBox41_TextChanged);
            // 
            // textBox42
            // 
            this.textBox42.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox42.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox42.Location = new System.Drawing.Point(160, 29);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(72, 39);
            this.textBox42.TabIndex = 18;
            this.textBox42.Text = "0";
            this.textBox42.TextChanged += new System.EventHandler(this.textBox42_TextChanged);
            // 
            // textBox43
            // 
            this.textBox43.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox43.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox43.Location = new System.Drawing.Point(316, 29);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(72, 39);
            this.textBox43.TabIndex = 19;
            this.textBox43.Text = "0";
            this.textBox43.TextChanged += new System.EventHandler(this.textBox43_TextChanged);
            // 
            // textBox44
            // 
            this.textBox44.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox44.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox44.Location = new System.Drawing.Point(478, 29);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(72, 39);
            this.textBox44.TabIndex = 20;
            this.textBox44.Text = "0";
            this.textBox44.TextChanged += new System.EventHandler(this.textBox44_TextChanged);
            // 
            // textBox54
            // 
            this.textBox54.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox54.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox54.Location = new System.Drawing.Point(477, 18);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(72, 39);
            this.textBox54.TabIndex = 24;
            this.textBox54.Text = "0";
            this.textBox54.TextChanged += new System.EventHandler(this.textBox54_TextChanged);
            // 
            // textBox53
            // 
            this.textBox53.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox53.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox53.Location = new System.Drawing.Point(315, 18);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(72, 39);
            this.textBox53.TabIndex = 23;
            this.textBox53.Text = "0";
            this.textBox53.TextChanged += new System.EventHandler(this.textBox53_TextChanged);
            // 
            // textBox52
            // 
            this.textBox52.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox52.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox52.Location = new System.Drawing.Point(159, 18);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(72, 39);
            this.textBox52.TabIndex = 22;
            this.textBox52.Text = "0";
            this.textBox52.TextChanged += new System.EventHandler(this.textBox52_TextChanged);
            // 
            // textBox51
            // 
            this.textBox51.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox51.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox51.Location = new System.Drawing.Point(10, 18);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(72, 39);
            this.textBox51.TabIndex = 21;
            this.textBox51.Text = "0";
            this.textBox51.TextChanged += new System.EventHandler(this.textBox51_TextChanged);
            // 
            // textBox64
            // 
            this.textBox64.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox64.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox64.Location = new System.Drawing.Point(476, 15);
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(72, 39);
            this.textBox64.TabIndex = 28;
            this.textBox64.Text = "0";
            this.textBox64.TextChanged += new System.EventHandler(this.textBox64_TextChanged);
            // 
            // textBox63
            // 
            this.textBox63.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox63.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox63.Location = new System.Drawing.Point(314, 15);
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(72, 39);
            this.textBox63.TabIndex = 27;
            this.textBox63.Text = "0";
            this.textBox63.TextChanged += new System.EventHandler(this.textBox63_TextChanged);
            // 
            // textBox62
            // 
            this.textBox62.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox62.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox62.Location = new System.Drawing.Point(158, 15);
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(72, 39);
            this.textBox62.TabIndex = 26;
            this.textBox62.Text = "0";
            this.textBox62.TextChanged += new System.EventHandler(this.textBox62_TextChanged);
            // 
            // textBox61
            // 
            this.textBox61.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox61.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox61.Location = new System.Drawing.Point(9, 15);
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(72, 39);
            this.textBox61.TabIndex = 25;
            this.textBox61.Text = "0";
            this.textBox61.TextChanged += new System.EventHandler(this.textBox61_TextChanged);
            // 
            // textBox65
            // 
            this.textBox65.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox65.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox65.Location = new System.Drawing.Point(639, 20);
            this.textBox65.Name = "textBox65";
            this.textBox65.Size = new System.Drawing.Size(72, 39);
            this.textBox65.TabIndex = 34;
            this.textBox65.Text = "0";
            this.textBox65.TextChanged += new System.EventHandler(this.textBox65_TextChanged);
            // 
            // textBox55
            // 
            this.textBox55.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox55.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox55.Location = new System.Drawing.Point(640, 23);
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(72, 39);
            this.textBox55.TabIndex = 33;
            this.textBox55.Text = "0";
            this.textBox55.TextChanged += new System.EventHandler(this.textBox55_TextChanged);
            // 
            // textBox45
            // 
            this.textBox45.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox45.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox45.Location = new System.Drawing.Point(3, 285);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(72, 39);
            this.textBox45.TabIndex = 32;
            this.textBox45.Text = "0";
            this.textBox45.TextChanged += new System.EventHandler(this.textBox45_TextChanged);
            // 
            // textBox25
            // 
            this.textBox25.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox25.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox25.Location = new System.Drawing.Point(8, 108);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(72, 39);
            this.textBox25.TabIndex = 30;
            this.textBox25.Text = "0";
            this.textBox25.TextChanged += new System.EventHandler(this.textBox25_TextChanged);
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox15.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox15.Location = new System.Drawing.Point(8, 17);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(72, 39);
            this.textBox15.TabIndex = 29;
            this.textBox15.Text = "0";
            this.textBox15.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // textBox66
            // 
            this.textBox66.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox66.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox66.Location = new System.Drawing.Point(792, 25);
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(72, 39);
            this.textBox66.TabIndex = 40;
            this.textBox66.Text = "0";
            this.textBox66.TextChanged += new System.EventHandler(this.textBox66_TextChanged);
            // 
            // textBox56
            // 
            this.textBox56.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox56.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox56.Location = new System.Drawing.Point(6, 385);
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(72, 39);
            this.textBox56.TabIndex = 39;
            this.textBox56.Text = "0";
            this.textBox56.TextChanged += new System.EventHandler(this.textBox56_TextChanged);
            // 
            // textBox46
            // 
            this.textBox46.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox46.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox46.Location = new System.Drawing.Point(4, 294);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(72, 39);
            this.textBox46.TabIndex = 38;
            this.textBox46.Text = "0";
            this.textBox46.TextChanged += new System.EventHandler(this.textBox46_TextChanged);
            // 
            // textBox26
            // 
            this.textBox26.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox26.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox26.Location = new System.Drawing.Point(4, 114);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(72, 39);
            this.textBox26.TabIndex = 36;
            this.textBox26.Text = "0";
            this.textBox26.TextChanged += new System.EventHandler(this.textBox26_TextChanged);
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox16.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox16.Location = new System.Drawing.Point(4, 23);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(72, 39);
            this.textBox16.TabIndex = 35;
            this.textBox16.Text = "0";
            this.textBox16.TextChanged += new System.EventHandler(this.textBox16_TextChanged);
            // 
            // textBox67
            // 
            this.textBox67.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox67.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox67.Location = new System.Drawing.Point(8, 475);
            this.textBox67.Name = "textBox67";
            this.textBox67.Size = new System.Drawing.Size(72, 39);
            this.textBox67.TabIndex = 46;
            this.textBox67.Text = "0";
            this.textBox67.TextChanged += new System.EventHandler(this.textBox67_TextChanged);
            // 
            // textBox57
            // 
            this.textBox57.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox57.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox57.Location = new System.Drawing.Point(8, 380);
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(72, 39);
            this.textBox57.TabIndex = 45;
            this.textBox57.Text = "0";
            this.textBox57.TextChanged += new System.EventHandler(this.textBox57_TextChanged);
            // 
            // textBox47
            // 
            this.textBox47.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox47.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox47.Location = new System.Drawing.Point(8, 289);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(72, 39);
            this.textBox47.TabIndex = 44;
            this.textBox47.Text = "0";
            this.textBox47.TextChanged += new System.EventHandler(this.textBox47_TextChanged);
            // 
            // textBox27
            // 
            this.textBox27.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox27.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox27.Location = new System.Drawing.Point(8, 109);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(72, 39);
            this.textBox27.TabIndex = 42;
            this.textBox27.Text = "0";
            this.textBox27.TextChanged += new System.EventHandler(this.textBox27_TextChanged);
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox17.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox17.Location = new System.Drawing.Point(8, 18);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(72, 39);
            this.textBox17.TabIndex = 41;
            this.textBox17.Text = "0";
            this.textBox17.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 974);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1317, 46);
            this.label1.TabIndex = 47;
            this.label1.Text = "Вводити можна лише числа або дроби (-2,4, 5,7, ...). Більш детально читайте в";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(932, 968);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 45);
            this.button2.TabIndex = 48;
            this.button2.Text = "правилах вводу чисел.";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(74, 849);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 63);
            this.button3.TabIndex = 49;
            this.button3.Text = "LUP Метод";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(80, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 42);
            this.label13.TabIndex = 87;
            this.label13.Text = "x3+";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(87, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 42);
            this.label14.TabIndex = 93;
            this.label14.Text = "x4+";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(87, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 31);
            this.label15.TabIndex = 99;
            this.label15.Text = "x5+";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(84, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 42);
            this.label16.TabIndex = 105;
            this.label16.Text = "x6=";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(652, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 44);
            this.comboBox1.TabIndex = 111;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(84, 123);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(69, 42);
            this.label26.TabIndex = 117;
            this.label26.Text = "x6=";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(87, 117);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 31);
            this.label25.TabIndex = 116;
            this.label25.Text = "x5+";
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(90, 114);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 42);
            this.label24.TabIndex = 115;
            this.label24.Text = "x4+";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(80, 105);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 42);
            this.label23.TabIndex = 114;
            this.label23.Text = "x3+";
            // 
            // label46
            // 
            this.label46.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label46.Location = new System.Drawing.Point(84, 303);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(69, 42);
            this.label46.TabIndex = 129;
            this.label46.Text = "x6=";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label45.Location = new System.Drawing.Point(87, 297);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(58, 31);
            this.label45.TabIndex = 128;
            this.label45.Text = "x5+";
            // 
            // label44
            // 
            this.label44.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label44.Location = new System.Drawing.Point(561, 38);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(74, 42);
            this.label44.TabIndex = 127;
            this.label44.Text = "x4+";
            // 
            // label43
            // 
            this.label43.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label43.Location = new System.Drawing.Point(394, 32);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(74, 42);
            this.label43.TabIndex = 126;
            this.label43.Text = "x3+";
            // 
            // label42
            // 
            this.label42.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label42.Location = new System.Drawing.Point(240, 32);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(74, 42);
            this.label42.TabIndex = 125;
            this.label42.Text = "x2+";
            // 
            // label41
            // 
            this.label41.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label41.Location = new System.Drawing.Point(88, 32);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(74, 42);
            this.label41.TabIndex = 124;
            this.label41.Text = "x1+";
            // 
            // label56
            // 
            this.label56.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label56.Location = new System.Drawing.Point(84, 394);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(69, 42);
            this.label56.TabIndex = 135;
            this.label56.Text = "x6=";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label55.Location = new System.Drawing.Point(720, 32);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(58, 31);
            this.label55.TabIndex = 134;
            this.label55.Text = "x5+";
            // 
            // label54
            // 
            this.label54.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label54.Location = new System.Drawing.Point(560, 28);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(74, 42);
            this.label54.TabIndex = 133;
            this.label54.Text = "x4+";
            // 
            // label53
            // 
            this.label53.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label53.Location = new System.Drawing.Point(393, 23);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(74, 42);
            this.label53.TabIndex = 132;
            this.label53.Text = "x3+";
            // 
            // label52
            // 
            this.label52.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label52.Location = new System.Drawing.Point(238, 23);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(74, 42);
            this.label52.TabIndex = 131;
            this.label52.Text = "x2+";
            // 
            // label51
            // 
            this.label51.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label51.Location = new System.Drawing.Point(87, 23);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(74, 42);
            this.label51.TabIndex = 130;
            this.label51.Text = "x1+";
            // 
            // label66
            // 
            this.label66.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label66.Location = new System.Drawing.Point(872, 29);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(70, 42);
            this.label66.TabIndex = 141;
            this.label66.Text = "x6=";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label65.Location = new System.Drawing.Point(718, 29);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(58, 31);
            this.label65.TabIndex = 140;
            this.label65.Text = "x5+";
            // 
            // label64
            // 
            this.label64.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label64.Location = new System.Drawing.Point(558, 25);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(74, 42);
            this.label64.TabIndex = 139;
            this.label64.Text = "x4+";
            // 
            // label63
            // 
            this.label63.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label63.Location = new System.Drawing.Point(392, 20);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(74, 42);
            this.label63.TabIndex = 138;
            this.label63.Text = "x3+";
            // 
            // label62
            // 
            this.label62.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label62.Location = new System.Drawing.Point(237, 20);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(74, 42);
            this.label62.TabIndex = 137;
            this.label62.Text = "x2+";
            // 
            // label61
            // 
            this.label61.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label61.Location = new System.Drawing.Point(86, 20);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(74, 42);
            this.label61.TabIndex = 136;
            this.label61.Text = "x1+";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(1917, 1011);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(264, 71);
            this.button4.TabIndex = 142;
            this.button4.Text = "Вийти";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(375, 849);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(357, 63);
            this.button1.TabIndex = 145;
            this.button1.Text = "Метод Обертання (QR)";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(770, 849);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(318, 63);
            this.button5.TabIndex = 146;
            this.button5.Text = "Гауса-Холецького";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(74, 263);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 578);
            this.panel1.TabIndex = 147;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.textBox67);
            this.panel11.Controls.Add(this.textBox57);
            this.panel11.Controls.Add(this.textBox47);
            this.panel11.Controls.Add(this.textBox37);
            this.panel11.Controls.Add(this.textBox27);
            this.panel11.Controls.Add(this.textBox17);
            this.panel11.Location = new System.Drawing.Point(963, 5);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(96, 551);
            this.panel11.TabIndex = 150;
            // 
            // textBox37
            // 
            this.textBox37.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox37.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox37.Location = new System.Drawing.Point(8, 198);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(72, 39);
            this.textBox37.TabIndex = 43;
            this.textBox37.Text = "0";
            this.textBox37.TextChanged += new System.EventHandler(this.textBox37_TextChanged);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label66);
            this.panel10.Controls.Add(this.label65);
            this.panel10.Controls.Add(this.label64);
            this.panel10.Controls.Add(this.label63);
            this.panel10.Controls.Add(this.label62);
            this.panel10.Controls.Add(this.label61);
            this.panel10.Controls.Add(this.textBox66);
            this.panel10.Controls.Add(this.textBox65);
            this.panel10.Controls.Add(this.textBox64);
            this.panel10.Controls.Add(this.textBox63);
            this.panel10.Controls.Add(this.textBox62);
            this.panel10.Controls.Add(this.textBox61);
            this.panel10.Location = new System.Drawing.Point(4, 455);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(957, 102);
            this.panel10.TabIndex = 149;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label56);
            this.panel9.Controls.Add(this.label46);
            this.panel9.Controls.Add(this.textBox56);
            this.panel9.Controls.Add(this.label36);
            this.panel9.Controls.Add(this.label26);
            this.panel9.Controls.Add(this.label16);
            this.panel9.Controls.Add(this.textBox46);
            this.panel9.Controls.Add(this.textBox36);
            this.panel9.Controls.Add(this.textBox26);
            this.panel9.Controls.Add(this.textBox16);
            this.panel9.Location = new System.Drawing.Point(796, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(166, 452);
            this.panel9.TabIndex = 148;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label36.Location = new System.Drawing.Point(84, 212);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(69, 42);
            this.label36.TabIndex = 123;
            this.label36.Text = "x6=";
            // 
            // textBox36
            // 
            this.textBox36.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox36.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox36.Location = new System.Drawing.Point(4, 203);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(72, 39);
            this.textBox36.TabIndex = 37;
            this.textBox36.Text = "0";
            this.textBox36.TextChanged += new System.EventHandler(this.textBox36_TextChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label55);
            this.panel8.Controls.Add(this.label54);
            this.panel8.Controls.Add(this.label53);
            this.panel8.Controls.Add(this.label52);
            this.panel8.Controls.Add(this.label51);
            this.panel8.Controls.Add(this.textBox55);
            this.panel8.Controls.Add(this.textBox54);
            this.panel8.Controls.Add(this.textBox53);
            this.panel8.Controls.Add(this.textBox52);
            this.panel8.Controls.Add(this.textBox51);
            this.panel8.Location = new System.Drawing.Point(3, 357);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(792, 97);
            this.panel8.TabIndex = 147;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label45);
            this.panel7.Controls.Add(this.label35);
            this.panel7.Controls.Add(this.textBox45);
            this.panel7.Controls.Add(this.label25);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.textBox35);
            this.panel7.Controls.Add(this.textBox25);
            this.panel7.Controls.Add(this.textBox15);
            this.panel7.Location = new System.Drawing.Point(640, 2);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(156, 354);
            this.panel7.TabIndex = 146;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label35.Location = new System.Drawing.Point(87, 206);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(58, 31);
            this.label35.TabIndex = 122;
            this.label35.Text = "x5+";
            // 
            // textBox35
            // 
            this.textBox35.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox35.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox35.Location = new System.Drawing.Point(8, 197);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(72, 39);
            this.textBox35.TabIndex = 31;
            this.textBox35.Text = "0";
            this.textBox35.TextChanged += new System.EventHandler(this.textBox35_TextChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label44);
            this.panel6.Controls.Add(this.label43);
            this.panel6.Controls.Add(this.label42);
            this.panel6.Controls.Add(this.label41);
            this.panel6.Controls.Add(this.textBox44);
            this.panel6.Controls.Add(this.textBox43);
            this.panel6.Controls.Add(this.textBox42);
            this.panel6.Controls.Add(this.textBox41);
            this.panel6.Location = new System.Drawing.Point(2, 252);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(638, 105);
            this.panel6.TabIndex = 145;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label34);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.textBox24);
            this.panel5.Controls.Add(this.textBox34);
            this.panel5.Controls.Add(this.textBox14);
            this.panel5.Location = new System.Drawing.Point(477, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(164, 252);
            this.panel5.TabIndex = 144;
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label34.Location = new System.Drawing.Point(90, 203);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(69, 42);
            this.label34.TabIndex = 121;
            this.label34.Text = "x4+";
            // 
            // textBox34
            // 
            this.textBox34.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox34.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox34.Location = new System.Drawing.Point(3, 195);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(72, 39);
            this.textBox34.TabIndex = 14;
            this.textBox34.Text = "0";
            this.textBox34.TextChanged += new System.EventHandler(this.textBox34_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label33);
            this.panel4.Controls.Add(this.label32);
            this.panel4.Controls.Add(this.label31);
            this.panel4.Controls.Add(this.textBox33);
            this.panel4.Controls.Add(this.textBox32);
            this.panel4.Controls.Add(this.textBox31);
            this.panel4.Location = new System.Drawing.Point(2, 163);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(476, 89);
            this.panel4.TabIndex = 0;
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label33.Location = new System.Drawing.Point(394, 37);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(74, 42);
            this.label33.TabIndex = 120;
            this.label33.Text = "x3+";
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.Location = new System.Drawing.Point(240, 37);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(74, 42);
            this.label32.TabIndex = 119;
            this.label32.Text = "x2+";
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.Location = new System.Drawing.Point(88, 37);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(74, 42);
            this.label31.TabIndex = 118;
            this.label31.Text = "x1+";
            // 
            // textBox33
            // 
            this.textBox33.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox33.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox33.Location = new System.Drawing.Point(316, 32);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(72, 39);
            this.textBox33.TabIndex = 16;
            this.textBox33.Text = "0";
            this.textBox33.TextChanged += new System.EventHandler(this.textBox33_TextChanged);
            // 
            // textBox32
            // 
            this.textBox32.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox32.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox32.Location = new System.Drawing.Point(160, 32);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(72, 39);
            this.textBox32.TabIndex = 15;
            this.textBox32.Text = "0";
            this.textBox32.TextChanged += new System.EventHandler(this.textBox32_TextChanged);
            // 
            // textBox31
            // 
            this.textBox31.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox31.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox31.Location = new System.Drawing.Point(12, 32);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(72, 39);
            this.textBox31.TabIndex = 13;
            this.textBox31.Text = "0";
            this.textBox31.TextChanged += new System.EventHandler(this.textBox31_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.textBox23);
            this.panel3.Controls.Add(this.textBox13);
            this.panel3.Location = new System.Drawing.Point(318, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 163);
            this.panel3.TabIndex = 143;
            // 
            // textBox23
            // 
            this.textBox23.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox23.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox23.Location = new System.Drawing.Point(0, 102);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(72, 39);
            this.textBox23.TabIndex = 11;
            this.textBox23.Text = "0";
            this.textBox23.TextChanged += new System.EventHandler(this.textBox23_TextChanged);
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox13.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox13.Location = new System.Drawing.Point(0, 11);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(72, 39);
            this.textBox13.TabIndex = 8;
            this.textBox13.Text = "0";
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.textBox12);
            this.panel2.Controls.Add(this.textBox22);
            this.panel2.Controls.Add(this.textBox21);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 162);
            this.panel2.TabIndex = 142;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(242, 106);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 42);
            this.label22.TabIndex = 113;
            this.label22.Text = "x2+";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(90, 106);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 42);
            this.label21.TabIndex = 112;
            this.label21.Text = "x1+";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(242, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 42);
            this.label12.TabIndex = 81;
            this.label12.Text = "x2+";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(90, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 42);
            this.label11.TabIndex = 50;
            this.label11.Text = "x1+";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox11.Location = new System.Drawing.Point(14, 12);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(72, 39);
            this.textBox11.TabIndex = 5;
            this.textBox11.Text = "0";
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox12.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox12.Location = new System.Drawing.Point(162, 12);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(72, 39);
            this.textBox12.TabIndex = 7;
            this.textBox12.Text = "0";
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox22.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox22.Location = new System.Drawing.Point(162, 103);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(72, 39);
            this.textBox22.TabIndex = 10;
            this.textBox22.Text = "0";
            this.textBox22.TextChanged += new System.EventHandler(this.textBox22_TextChanged);
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox21.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox21.Location = new System.Drawing.Point(14, 103);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(72, 39);
            this.textBox21.TabIndex = 9;
            this.textBox21.Text = "0";
            this.textBox21.TextChanged += new System.EventHandler(this.textBox21_TextChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(375, 789);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(357, 63);
            this.button6.TabIndex = 148;
            this.button6.Text = "Графічно (2 рівняння)";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(518, 203);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(390, 52);
            this.button7.TabIndex = 149;
            this.button7.Text = "Випадково (-100; 100, цілі) ";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 260);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 525);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 150;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1166, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(616, 46);
            this.label4.TabIndex = 151;
            this.label4.Text = "Розв\'язок:";
            this.label4.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(1173, 263);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1006, 704);
            this.textBox1.TabIndex = 152;
            this.textBox1.Text = "1\r\n2";
            this.textBox1.Visible = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button8.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(1173, 1011);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(264, 71);
            this.button8.TabIndex = 153;
            this.button8.Text = "Зберегти у txt";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.допомогаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2199, 50);
            this.menuStrip1.TabIndex = 154;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // допомогаToolStripMenuItem
            // 
            this.допомогаToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.допомогаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.інструкціяToolStripMenuItem});
            this.допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
            this.допомогаToolStripMenuItem.Size = new System.Drawing.Size(167, 44);
            this.допомогаToolStripMenuItem.Text = "Допомога";
            // 
            // інструкціяToolStripMenuItem
            // 
            this.інструкціяToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.інструкціяToolStripMenuItem.Name = "інструкціяToolStripMenuItem";
            this.інструкціяToolStripMenuItem.Size = new System.Drawing.Size(258, 48);
            this.інструкціяToolStripMenuItem.Text = "Інструкція";
            this.інструкціяToolStripMenuItem.Click += new System.EventHandler(this.інструкціяToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1496, 1011);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(412, 46);
            this.label5.TabIndex = 155;
            this.label5.Text = "К-сть операцій: ";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(2199, 1100);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "System Of Linear Equation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.TextBox textBox42;
        private System.Windows.Forms.TextBox textBox43;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.TextBox textBox54;
        private System.Windows.Forms.TextBox textBox53;
        private System.Windows.Forms.TextBox textBox52;
        private System.Windows.Forms.TextBox textBox51;
        private System.Windows.Forms.TextBox textBox64;
        private System.Windows.Forms.TextBox textBox63;
        private System.Windows.Forms.TextBox textBox62;
        private System.Windows.Forms.TextBox textBox61;
        private System.Windows.Forms.TextBox textBox65;
        private System.Windows.Forms.TextBox textBox55;
        private System.Windows.Forms.TextBox textBox45;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox66;
        private System.Windows.Forms.TextBox textBox56;
        private System.Windows.Forms.TextBox textBox46;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox67;
        private System.Windows.Forms.TextBox textBox57;
        private System.Windows.Forms.TextBox textBox47;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private Label label33;
        private Label label32;
        private Label label31;
        private TextBox textBox33;
        private TextBox textBox32;
        private TextBox textBox34;
        private TextBox textBox31;
        private Label label34;
        private TextBox textBox35;
        private Label label35;
        private TextBox textBox36;
        private Label label36;
        private TextBox textBox37;
        private Label label22;
        private Label label21;
        private Label label12;
        private Label label11;
        private TextBox textBox23;
        private TextBox textBox22;
        private TextBox textBox21;
        private TextBox textBox13;
        private TextBox textBox12;
        private TextBox textBox11;
        private Panel panel3;
        private Panel panel2;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        private Button button6;
        private Button button7;
        private PictureBox pictureBox1;
        private Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private Button button8;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem допомогаToolStripMenuItem;
        private ToolStripMenuItem інструкціяToolStripMenuItem;
        private Label label5;
    }
}

