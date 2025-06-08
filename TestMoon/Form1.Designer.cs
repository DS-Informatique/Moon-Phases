namespace TestMoon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Input_Date = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NewMoon2022 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.LunarPeriode = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Delta = new System.Windows.Forms.NumericUpDown();
            this.Modulo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.L_Week1 = new System.Windows.Forms.Label();
            this.L_Week2 = new System.Windows.Forms.Label();
            this.L_Week4 = new System.Windows.Forms.Label();
            this.L_Week3 = new System.Windows.Forms.Label();
            this.L_Week5 = new System.Windows.Forms.Label();
            this.Week5day4 = new TestMoon.Day();
            this.Week5day3 = new TestMoon.Day();
            this.Week5day2 = new TestMoon.Day();
            this.Week5day1 = new TestMoon.Day();
            this.Week5day6 = new TestMoon.Day();
            this.Week5day5 = new TestMoon.Day();
            this.Week4day7 = new TestMoon.Day();
            this.Week4day6 = new TestMoon.Day();
            this.Week4day5 = new TestMoon.Day();
            this.Week4day4 = new TestMoon.Day();
            this.Week4day3 = new TestMoon.Day();
            this.Week4day2 = new TestMoon.Day();
            this.Week4day1 = new TestMoon.Day();
            this.Week3day7 = new TestMoon.Day();
            this.Week3day6 = new TestMoon.Day();
            this.Week3day5 = new TestMoon.Day();
            this.Week3day4 = new TestMoon.Day();
            this.Week3day3 = new TestMoon.Day();
            this.Week3day2 = new TestMoon.Day();
            this.Week3day1 = new TestMoon.Day();
            this.Week2day7 = new TestMoon.Day();
            this.Week2day6 = new TestMoon.Day();
            this.Week2day5 = new TestMoon.Day();
            this.Week2day4 = new TestMoon.Day();
            this.Week2day3 = new TestMoon.Day();
            this.Week2day2 = new TestMoon.Day();
            this.Week2day1 = new TestMoon.Day();
            this.week1day1 = new TestMoon.Day();
            this.week1day2 = new TestMoon.Day();
            this.week1day3 = new TestMoon.Day();
            this.week1day4 = new TestMoon.Day();
            this.week1day5 = new TestMoon.Day();
            this.week1day6 = new TestMoon.Day();
            this.week1day7 = new TestMoon.Day();
            this.Week5day7 = new TestMoon.Day();
            ((System.ComponentModel.ISupportInitialize)(this.LunarPeriode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Modulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Input_Date
            // 
            this.Input_Date.Location = new System.Drawing.Point(149, 31);
            this.Input_Date.Name = "Input_Date";
            this.Input_Date.Size = new System.Drawing.Size(200, 20);
            this.Input_Date.TabIndex = 1;
            this.Input_Date.Value = new System.DateTime(2022, 2, 1, 14, 52, 0, 0);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lunar Day";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Constante New Moon of January:";
            // 
            // NewMoon2022
            // 
            this.NewMoon2022.Location = new System.Drawing.Point(504, 114);
            this.NewMoon2022.Name = "NewMoon2022";
            this.NewMoon2022.Size = new System.Drawing.Size(200, 20);
            this.NewMoon2022.TabIndex = 6;
            this.NewMoon2022.Value = new System.DateTime(2022, 1, 2, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Constante Periode Lunaire:";
            // 
            // LunarPeriode
            // 
            this.LunarPeriode.DecimalPlaces = 10;
            this.LunarPeriode.Location = new System.Drawing.Point(504, 146);
            this.LunarPeriode.Name = "LunarPeriode";
            this.LunarPeriode.Size = new System.Drawing.Size(120, 20);
            this.LunarPeriode.TabIndex = 8;
            this.LunarPeriode.Value = new decimal(new int[] {
            -1878729072,
            687,
            0,
            720896});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date Diff";
            // 
            // Delta
            // 
            this.Delta.Location = new System.Drawing.Point(149, 80);
            this.Delta.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.Delta.Name = "Delta";
            this.Delta.Size = new System.Drawing.Size(120, 20);
            this.Delta.TabIndex = 11;
            // 
            // Modulo
            // 
            this.Modulo.DecimalPlaces = 10;
            this.Modulo.Location = new System.Drawing.Point(149, 122);
            this.Modulo.Name = "Modulo";
            this.Modulo.Size = new System.Drawing.Size(120, 20);
            this.Modulo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Modulo";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(149, 169);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(120, 20);
            this.Result.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Int";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(59, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 39);
            this.button3.TabIndex = 16;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Semaine";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Lundi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Mardi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(391, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Jeudi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Mercredi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(604, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Samedi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(481, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Vendredi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(700, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Dimanche";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 430);
            this.panel1.TabIndex = 25;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.Controls.Add(this.Week5day4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Week5day3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Week5day2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Week5day1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Week5day6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Week5day5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Week4day7, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.Week4day6, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.Week4day5, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.Week4day4, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.Week4day3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Week4day2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Week4day1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Week3day7, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.Week3day6, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.Week3day5, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.Week3day4, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.Week3day3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Week3day2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Week3day1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.L_Week4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Week2day7, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.Week2day6, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.Week2day5, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.Week2day4, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.Week2day3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Week2day2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Week2day1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.L_Week2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.week1day1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.week1day2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.week1day3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.week1day4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.week1day5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.week1day6, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.week1day7, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.L_Week1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.L_Week3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Week5day7, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.L_Week5, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 430);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // L_Week1
            // 
            this.L_Week1.AutoSize = true;
            this.L_Week1.Location = new System.Drawing.Point(3, 0);
            this.L_Week1.Name = "L_Week1";
            this.L_Week1.Size = new System.Drawing.Size(45, 13);
            this.L_Week1.TabIndex = 18;
            this.L_Week1.Text = "Week 1";
            // 
            // L_Week2
            // 
            this.L_Week2.AutoSize = true;
            this.L_Week2.Location = new System.Drawing.Point(3, 85);
            this.L_Week2.Name = "L_Week2";
            this.L_Week2.Size = new System.Drawing.Size(45, 13);
            this.L_Week2.TabIndex = 19;
            this.L_Week2.Text = "Week 2";
            // 
            // L_Week4
            // 
            this.L_Week4.AutoSize = true;
            this.L_Week4.Location = new System.Drawing.Point(3, 253);
            this.L_Week4.Name = "L_Week4";
            this.L_Week4.Size = new System.Drawing.Size(45, 13);
            this.L_Week4.TabIndex = 29;
            this.L_Week4.Text = "Week 4";
            // 
            // L_Week3
            // 
            this.L_Week3.AutoSize = true;
            this.L_Week3.Location = new System.Drawing.Point(3, 170);
            this.L_Week3.Name = "L_Week3";
            this.L_Week3.Size = new System.Drawing.Size(45, 13);
            this.L_Week3.TabIndex = 30;
            this.L_Week3.Text = "Week 3";
            // 
            // L_Week5
            // 
            this.L_Week5.AutoSize = true;
            this.L_Week5.Location = new System.Drawing.Point(3, 340);
            this.L_Week5.Name = "L_Week5";
            this.L_Week5.Size = new System.Drawing.Size(45, 13);
            this.L_Week5.TabIndex = 45;
            this.L_Week5.Text = "Week 5";
            // 
            // Week5day4
            // 
            this.Week5day4.Date = new System.DateTime(((long)(0)));
            this.Week5day4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week5day4.Imge = "";
            this.Week5day4.Location = new System.Drawing.Point(356, 343);
            this.Week5day4.Lunar = 29.53058770576D;
            this.Week5day4.LunarDay = 0D;
            this.Week5day4.Name = "Week5day4";
            this.Week5day4.Size = new System.Drawing.Size(100, 84);
            this.Week5day4.TabIndex = 53;
            // 
            // Week5day3
            // 
            this.Week5day3.Date = new System.DateTime(((long)(0)));
            this.Week5day3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week5day3.Imge = "";
            this.Week5day3.Location = new System.Drawing.Point(268, 343);
            this.Week5day3.Lunar = 29.53058770576D;
            this.Week5day3.LunarDay = 0D;
            this.Week5day3.Name = "Week5day3";
            this.Week5day3.Size = new System.Drawing.Size(82, 84);
            this.Week5day3.TabIndex = 52;
            // 
            // Week5day2
            // 
            this.Week5day2.Date = new System.DateTime(((long)(0)));
            this.Week5day2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week5day2.Imge = "";
            this.Week5day2.Location = new System.Drawing.Point(179, 343);
            this.Week5day2.Lunar = 29.53058770576D;
            this.Week5day2.LunarDay = 0D;
            this.Week5day2.Name = "Week5day2";
            this.Week5day2.Size = new System.Drawing.Size(83, 84);
            this.Week5day2.TabIndex = 51;
            // 
            // Week5day1
            // 
            this.Week5day1.Date = new System.DateTime(((long)(0)));
            this.Week5day1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week5day1.Imge = "";
            this.Week5day1.Location = new System.Drawing.Point(86, 343);
            this.Week5day1.Lunar = 29.53058770576D;
            this.Week5day1.LunarDay = 0D;
            this.Week5day1.Name = "Week5day1";
            this.Week5day1.Size = new System.Drawing.Size(87, 84);
            this.Week5day1.TabIndex = 50;
            // 
            // Week5day6
            // 
            this.Week5day6.Date = new System.DateTime(((long)(0)));
            this.Week5day6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week5day6.Imge = "";
            this.Week5day6.Location = new System.Drawing.Point(567, 343);
            this.Week5day6.Lunar = 29.53058770576D;
            this.Week5day6.LunarDay = 0D;
            this.Week5day6.Name = "Week5day6";
            this.Week5day6.Size = new System.Drawing.Size(94, 84);
            this.Week5day6.TabIndex = 49;
            // 
            // Week5day5
            // 
            this.Week5day5.Date = new System.DateTime(((long)(0)));
            this.Week5day5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week5day5.Imge = "";
            this.Week5day5.Location = new System.Drawing.Point(462, 343);
            this.Week5day5.Lunar = 29.53058770576D;
            this.Week5day5.LunarDay = 0D;
            this.Week5day5.Name = "Week5day5";
            this.Week5day5.Size = new System.Drawing.Size(99, 84);
            this.Week5day5.TabIndex = 48;
            // 
            // Week4day7
            // 
            this.Week4day7.Date = new System.DateTime(((long)(0)));
            this.Week4day7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week4day7.Imge = "";
            this.Week4day7.Location = new System.Drawing.Point(667, 256);
            this.Week4day7.Lunar = 29.53058770576D;
            this.Week4day7.LunarDay = 0D;
            this.Week4day7.Name = "Week4day7";
            this.Week4day7.Size = new System.Drawing.Size(106, 81);
            this.Week4day7.TabIndex = 44;
            // 
            // Week4day6
            // 
            this.Week4day6.Date = new System.DateTime(((long)(0)));
            this.Week4day6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week4day6.Imge = "";
            this.Week4day6.Location = new System.Drawing.Point(567, 256);
            this.Week4day6.Lunar = 29.53058770576D;
            this.Week4day6.LunarDay = 0D;
            this.Week4day6.Name = "Week4day6";
            this.Week4day6.Size = new System.Drawing.Size(94, 81);
            this.Week4day6.TabIndex = 43;
            // 
            // Week4day5
            // 
            this.Week4day5.Date = new System.DateTime(((long)(0)));
            this.Week4day5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week4day5.Imge = "";
            this.Week4day5.Location = new System.Drawing.Point(462, 256);
            this.Week4day5.Lunar = 29.53058770576D;
            this.Week4day5.LunarDay = 0D;
            this.Week4day5.Name = "Week4day5";
            this.Week4day5.Size = new System.Drawing.Size(99, 81);
            this.Week4day5.TabIndex = 42;
            // 
            // Week4day4
            // 
            this.Week4day4.Date = new System.DateTime(((long)(0)));
            this.Week4day4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week4day4.Imge = "";
            this.Week4day4.Location = new System.Drawing.Point(356, 256);
            this.Week4day4.Lunar = 29.53058770576D;
            this.Week4day4.LunarDay = 0D;
            this.Week4day4.Name = "Week4day4";
            this.Week4day4.Size = new System.Drawing.Size(100, 81);
            this.Week4day4.TabIndex = 41;
            // 
            // Week4day3
            // 
            this.Week4day3.Date = new System.DateTime(((long)(0)));
            this.Week4day3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week4day3.Imge = "";
            this.Week4day3.Location = new System.Drawing.Point(268, 256);
            this.Week4day3.Lunar = 29.53058770576D;
            this.Week4day3.LunarDay = 0D;
            this.Week4day3.Name = "Week4day3";
            this.Week4day3.Size = new System.Drawing.Size(82, 81);
            this.Week4day3.TabIndex = 40;
            // 
            // Week4day2
            // 
            this.Week4day2.Date = new System.DateTime(((long)(0)));
            this.Week4day2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week4day2.Imge = "";
            this.Week4day2.Location = new System.Drawing.Point(179, 256);
            this.Week4day2.Lunar = 29.53058770576D;
            this.Week4day2.LunarDay = 0D;
            this.Week4day2.Name = "Week4day2";
            this.Week4day2.Size = new System.Drawing.Size(83, 81);
            this.Week4day2.TabIndex = 39;
            // 
            // Week4day1
            // 
            this.Week4day1.Date = new System.DateTime(((long)(0)));
            this.Week4day1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week4day1.Imge = "";
            this.Week4day1.Location = new System.Drawing.Point(86, 256);
            this.Week4day1.Lunar = 29.53058770576D;
            this.Week4day1.LunarDay = 0D;
            this.Week4day1.Name = "Week4day1";
            this.Week4day1.Size = new System.Drawing.Size(87, 81);
            this.Week4day1.TabIndex = 38;
            // 
            // Week3day7
            // 
            this.Week3day7.Date = new System.DateTime(((long)(0)));
            this.Week3day7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week3day7.Imge = "";
            this.Week3day7.Location = new System.Drawing.Point(667, 173);
            this.Week3day7.Lunar = 29.53058770576D;
            this.Week3day7.LunarDay = 0D;
            this.Week3day7.Name = "Week3day7";
            this.Week3day7.Size = new System.Drawing.Size(106, 77);
            this.Week3day7.TabIndex = 37;
            // 
            // Week3day6
            // 
            this.Week3day6.Date = new System.DateTime(((long)(0)));
            this.Week3day6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week3day6.Imge = "";
            this.Week3day6.Location = new System.Drawing.Point(567, 173);
            this.Week3day6.Lunar = 29.53058770576D;
            this.Week3day6.LunarDay = 0D;
            this.Week3day6.Name = "Week3day6";
            this.Week3day6.Size = new System.Drawing.Size(94, 77);
            this.Week3day6.TabIndex = 36;
            // 
            // Week3day5
            // 
            this.Week3day5.Date = new System.DateTime(((long)(0)));
            this.Week3day5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week3day5.Imge = "";
            this.Week3day5.Location = new System.Drawing.Point(462, 173);
            this.Week3day5.Lunar = 29.53058770576D;
            this.Week3day5.LunarDay = 0D;
            this.Week3day5.Name = "Week3day5";
            this.Week3day5.Size = new System.Drawing.Size(99, 77);
            this.Week3day5.TabIndex = 35;
            // 
            // Week3day4
            // 
            this.Week3day4.Date = new System.DateTime(((long)(0)));
            this.Week3day4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week3day4.Imge = "";
            this.Week3day4.Location = new System.Drawing.Point(356, 173);
            this.Week3day4.Lunar = 29.53058770576D;
            this.Week3day4.LunarDay = 0D;
            this.Week3day4.Name = "Week3day4";
            this.Week3day4.Size = new System.Drawing.Size(100, 77);
            this.Week3day4.TabIndex = 34;
            // 
            // Week3day3
            // 
            this.Week3day3.Date = new System.DateTime(((long)(0)));
            this.Week3day3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week3day3.Imge = "";
            this.Week3day3.Location = new System.Drawing.Point(268, 173);
            this.Week3day3.Lunar = 29.53058770576D;
            this.Week3day3.LunarDay = 0D;
            this.Week3day3.Name = "Week3day3";
            this.Week3day3.Size = new System.Drawing.Size(82, 77);
            this.Week3day3.TabIndex = 33;
            // 
            // Week3day2
            // 
            this.Week3day2.Date = new System.DateTime(((long)(0)));
            this.Week3day2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week3day2.Imge = "";
            this.Week3day2.Location = new System.Drawing.Point(179, 173);
            this.Week3day2.Lunar = 29.53058770576D;
            this.Week3day2.LunarDay = 0D;
            this.Week3day2.Name = "Week3day2";
            this.Week3day2.Size = new System.Drawing.Size(83, 77);
            this.Week3day2.TabIndex = 32;
            // 
            // Week3day1
            // 
            this.Week3day1.Date = new System.DateTime(((long)(0)));
            this.Week3day1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week3day1.Imge = "";
            this.Week3day1.Location = new System.Drawing.Point(86, 173);
            this.Week3day1.Lunar = 29.53058770576D;
            this.Week3day1.LunarDay = 0D;
            this.Week3day1.Name = "Week3day1";
            this.Week3day1.Size = new System.Drawing.Size(87, 77);
            this.Week3day1.TabIndex = 31;
            // 
            // Week2day7
            // 
            this.Week2day7.Date = new System.DateTime(((long)(0)));
            this.Week2day7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week2day7.Imge = "";
            this.Week2day7.Location = new System.Drawing.Point(667, 88);
            this.Week2day7.Lunar = 29.53058770576D;
            this.Week2day7.LunarDay = 0D;
            this.Week2day7.Name = "Week2day7";
            this.Week2day7.Size = new System.Drawing.Size(106, 79);
            this.Week2day7.TabIndex = 26;
            // 
            // Week2day6
            // 
            this.Week2day6.Date = new System.DateTime(((long)(0)));
            this.Week2day6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week2day6.Imge = "";
            this.Week2day6.Location = new System.Drawing.Point(567, 88);
            this.Week2day6.Lunar = 29.53058770576D;
            this.Week2day6.LunarDay = 0D;
            this.Week2day6.Name = "Week2day6";
            this.Week2day6.Size = new System.Drawing.Size(94, 79);
            this.Week2day6.TabIndex = 25;
            // 
            // Week2day5
            // 
            this.Week2day5.Date = new System.DateTime(((long)(0)));
            this.Week2day5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week2day5.Imge = "";
            this.Week2day5.Location = new System.Drawing.Point(462, 88);
            this.Week2day5.Lunar = 29.53058770576D;
            this.Week2day5.LunarDay = 0D;
            this.Week2day5.Name = "Week2day5";
            this.Week2day5.Size = new System.Drawing.Size(99, 79);
            this.Week2day5.TabIndex = 24;
            // 
            // Week2day4
            // 
            this.Week2day4.Date = new System.DateTime(((long)(0)));
            this.Week2day4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week2day4.Imge = "";
            this.Week2day4.Location = new System.Drawing.Point(356, 88);
            this.Week2day4.Lunar = 29.53058770576D;
            this.Week2day4.LunarDay = 0D;
            this.Week2day4.Name = "Week2day4";
            this.Week2day4.Size = new System.Drawing.Size(100, 79);
            this.Week2day4.TabIndex = 23;
            // 
            // Week2day3
            // 
            this.Week2day3.Date = new System.DateTime(((long)(0)));
            this.Week2day3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week2day3.Imge = "";
            this.Week2day3.Location = new System.Drawing.Point(268, 88);
            this.Week2day3.Lunar = 29.53058770576D;
            this.Week2day3.LunarDay = 0D;
            this.Week2day3.Name = "Week2day3";
            this.Week2day3.Size = new System.Drawing.Size(82, 79);
            this.Week2day3.TabIndex = 22;
            // 
            // Week2day2
            // 
            this.Week2day2.Date = new System.DateTime(((long)(0)));
            this.Week2day2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week2day2.Imge = "";
            this.Week2day2.Location = new System.Drawing.Point(179, 88);
            this.Week2day2.Lunar = 29.53058770576D;
            this.Week2day2.LunarDay = 0D;
            this.Week2day2.Name = "Week2day2";
            this.Week2day2.Size = new System.Drawing.Size(83, 79);
            this.Week2day2.TabIndex = 21;
            // 
            // Week2day1
            // 
            this.Week2day1.Date = new System.DateTime(((long)(0)));
            this.Week2day1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week2day1.Imge = "";
            this.Week2day1.Location = new System.Drawing.Point(86, 88);
            this.Week2day1.Lunar = 29.53058770576D;
            this.Week2day1.LunarDay = 0D;
            this.Week2day1.Name = "Week2day1";
            this.Week2day1.Size = new System.Drawing.Size(87, 79);
            this.Week2day1.TabIndex = 20;
            // 
            // week1day1
            // 
            this.week1day1.Date = new System.DateTime(((long)(0)));
            this.week1day1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.week1day1.Imge = "";
            this.week1day1.Location = new System.Drawing.Point(86, 3);
            this.week1day1.Lunar = 29.53058770576D;
            this.week1day1.LunarDay = 0D;
            this.week1day1.Name = "week1day1";
            this.week1day1.Size = new System.Drawing.Size(87, 79);
            this.week1day1.TabIndex = 0;
            // 
            // week1day2
            // 
            this.week1day2.Date = new System.DateTime(((long)(0)));
            this.week1day2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.week1day2.Imge = "";
            this.week1day2.Location = new System.Drawing.Point(179, 3);
            this.week1day2.Lunar = 29.53058770576D;
            this.week1day2.LunarDay = 0D;
            this.week1day2.Name = "week1day2";
            this.week1day2.Size = new System.Drawing.Size(83, 79);
            this.week1day2.TabIndex = 1;
            // 
            // week1day3
            // 
            this.week1day3.Date = new System.DateTime(((long)(0)));
            this.week1day3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.week1day3.Imge = "";
            this.week1day3.Location = new System.Drawing.Point(268, 3);
            this.week1day3.Lunar = 29.53058770576D;
            this.week1day3.LunarDay = 0D;
            this.week1day3.Name = "week1day3";
            this.week1day3.Size = new System.Drawing.Size(82, 79);
            this.week1day3.TabIndex = 2;
            // 
            // week1day4
            // 
            this.week1day4.Date = new System.DateTime(((long)(0)));
            this.week1day4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.week1day4.Imge = "";
            this.week1day4.Location = new System.Drawing.Point(356, 3);
            this.week1day4.Lunar = 29.53058770576D;
            this.week1day4.LunarDay = 0D;
            this.week1day4.Name = "week1day4";
            this.week1day4.Size = new System.Drawing.Size(100, 79);
            this.week1day4.TabIndex = 3;
            // 
            // week1day5
            // 
            this.week1day5.Date = new System.DateTime(((long)(0)));
            this.week1day5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.week1day5.Imge = "";
            this.week1day5.Location = new System.Drawing.Point(462, 3);
            this.week1day5.Lunar = 29.53058770576D;
            this.week1day5.LunarDay = 0D;
            this.week1day5.Name = "week1day5";
            this.week1day5.Size = new System.Drawing.Size(99, 79);
            this.week1day5.TabIndex = 4;
            // 
            // week1day6
            // 
            this.week1day6.Date = new System.DateTime(((long)(0)));
            this.week1day6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.week1day6.Imge = "";
            this.week1day6.Location = new System.Drawing.Point(567, 3);
            this.week1day6.Lunar = 29.53058770576D;
            this.week1day6.LunarDay = 0D;
            this.week1day6.Name = "week1day6";
            this.week1day6.Size = new System.Drawing.Size(94, 79);
            this.week1day6.TabIndex = 5;
            // 
            // week1day7
            // 
            this.week1day7.Date = new System.DateTime(((long)(0)));
            this.week1day7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.week1day7.Imge = "";
            this.week1day7.Location = new System.Drawing.Point(667, 3);
            this.week1day7.Lunar = 29.53058770576D;
            this.week1day7.LunarDay = 0D;
            this.week1day7.Name = "week1day7";
            this.week1day7.Size = new System.Drawing.Size(106, 79);
            this.week1day7.TabIndex = 6;
            // 
            // Week5day7
            // 
            this.Week5day7.Date = new System.DateTime(((long)(0)));
            this.Week5day7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week5day7.Imge = "";
            this.Week5day7.Location = new System.Drawing.Point(667, 343);
            this.Week5day7.Lunar = 29.53058770576D;
            this.Week5day7.LunarDay = 0D;
            this.Week5day7.Name = "Week5day7";
            this.Week5day7.Size = new System.Drawing.Size(106, 84);
            this.Week5day7.TabIndex = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Modulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Delta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LunarPeriode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewMoon2022);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Input_Date);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LunarPeriode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Modulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker Input_Date;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker NewMoon2022;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown LunarPeriode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Delta;
        private System.Windows.Forms.NumericUpDown Modulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Day Week5day4;
        private Day Week5day3;
        private Day Week5day2;
        private Day Week5day1;
        private Day Week5day6;
        private Day Week5day5;
        private Day Week4day7;
        private Day Week4day6;
        private Day Week4day5;
        private Day Week4day4;
        private Day Week4day3;
        private Day Week4day2;
        private Day Week4day1;
        private Day Week3day7;
        private Day Week3day6;
        private Day Week3day5;
        private Day Week3day4;
        private Day Week3day3;
        private Day Week3day2;
        private Day Week3day1;
        private System.Windows.Forms.Label L_Week4;
        private Day Week2day7;
        private Day Week2day6;
        private Day Week2day5;
        private Day Week2day4;
        private Day Week2day3;
        private Day Week2day2;
        private Day Week2day1;
        private System.Windows.Forms.Label L_Week2;
        private Day week1day1;
        private Day week1day2;
        private Day week1day3;
        private Day week1day4;
        private Day week1day5;
        private Day week1day6;
        private Day week1day7;
        private System.Windows.Forms.Label L_Week1;
        private System.Windows.Forms.Label L_Week3;
        private Day Week5day7;
        private System.Windows.Forms.Label L_Week5;
    }
}

