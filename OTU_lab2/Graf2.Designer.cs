namespace OTU_lab2
{
    partial class Graf2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graf2));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graf_achh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graf_fchh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graf_sin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_w = new System.Windows.Forms.Label();
            this.tb_w = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ww1 = new System.Windows.Forms.Label();
            this.ww2 = new System.Windows.Forms.Label();
            this.ww3 = new System.Windows.Forms.Label();
            this.ww4 = new System.Windows.Forms.Label();
            this.ww5 = new System.Windows.Forms.Label();
            this.ww6 = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_stud2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.graf_afh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.graf_achh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf_fchh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf_sin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf_afh)).BeginInit();
            this.SuspendLayout();
            // 
            // graf_achh
            // 
            chartArea1.AxisX.Title = "t";
            chartArea1.AxisY.Title = "A(w)";
            chartArea1.Name = "ChartArea1";
            this.graf_achh.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.graf_achh.Legends.Add(legend1);
            this.graf_achh.Location = new System.Drawing.Point(494, 121);
            this.graf_achh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.graf_achh.Name = "graf_achh";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.Legend = "Legend1";
            series1.LegendText = "АЧХ";
            series1.Name = "Series1";
            this.graf_achh.Series.Add(series1);
            this.graf_achh.Size = new System.Drawing.Size(476, 308);
            this.graf_achh.TabIndex = 0;
            this.graf_achh.Text = "chart1";
            this.graf_achh.Click += new System.EventHandler(this.graf_achh_Click);
            // 
            // graf_fchh
            // 
            chartArea2.AxisX.Title = "t";
            chartArea2.AxisY.Title = "φ(t)";
            chartArea2.Name = "ChartArea1";
            this.graf_fchh.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.graf_fchh.Legends.Add(legend2);
            this.graf_fchh.Location = new System.Drawing.Point(494, 437);
            this.graf_fchh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.graf_fchh.Name = "graf_fchh";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.BlueViolet;
            series2.Legend = "Legend1";
            series2.LegendText = "ФЧХ";
            series2.Name = "Series1";
            this.graf_fchh.Series.Add(series2);
            this.graf_fchh.Size = new System.Drawing.Size(476, 308);
            this.graf_fchh.TabIndex = 1;
            this.graf_fchh.Text = "chart2";
            this.graf_fchh.Click += new System.EventHandler(this.graf_fchh_Click);
            // 
            // graf_sin
            // 
            chartArea3.AxisX.Title = "t";
            chartArea3.Name = "ChartArea1";
            this.graf_sin.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.graf_sin.Legends.Add(legend3);
            this.graf_sin.Location = new System.Drawing.Point(12, 121);
            this.graf_sin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.graf_sin.Name = "graf_sin";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.LegendText = "Сигнал\\nвход-выход";
            series3.Name = "Series1";
            this.graf_sin.Series.Add(series3);
            this.graf_sin.Size = new System.Drawing.Size(476, 308);
            this.graf_sin.TabIndex = 3;
            this.graf_sin.Text = "chart4";
            this.graf_sin.Click += new System.EventHandler(this.chart4_Click);
            // 
            // lbl_w
            // 
            this.lbl_w.AutoSize = true;
            this.lbl_w.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_w.Location = new System.Drawing.Point(12, 832);
            this.lbl_w.Name = "lbl_w";
            this.lbl_w.Size = new System.Drawing.Size(306, 20);
            this.lbl_w.TabIndex = 8;
            this.lbl_w.Text = "Добавить новую точку с частотой W =";
            // 
            // tb_w
            // 
            this.tb_w.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_w.Location = new System.Drawing.Point(321, 829);
            this.tb_w.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_w.Name = "tb_w";
            this.tb_w.Size = new System.Drawing.Size(56, 27);
            this.tb_w.TabIndex = 9;
            this.tb_w.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tb_w.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(129, 868);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(283, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ww1
            // 
            this.ww1.AutoSize = true;
            this.ww1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ww1.Location = new System.Drawing.Point(374, 57);
            this.ww1.Name = "ww1";
            this.ww1.Size = new System.Drawing.Size(43, 20);
            this.ww1.TabIndex = 12;
            this.ww1.Text = "0,00";
            this.ww1.Click += new System.EventHandler(this.label6_Click);
            // 
            // ww2
            // 
            this.ww2.AutoSize = true;
            this.ww2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ww2.Location = new System.Drawing.Point(485, 57);
            this.ww2.Name = "ww2";
            this.ww2.Size = new System.Drawing.Size(43, 20);
            this.ww2.TabIndex = 13;
            this.ww2.Text = "0,00";
            // 
            // ww3
            // 
            this.ww3.AutoSize = true;
            this.ww3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ww3.Location = new System.Drawing.Point(584, 57);
            this.ww3.Name = "ww3";
            this.ww3.Size = new System.Drawing.Size(43, 20);
            this.ww3.TabIndex = 14;
            this.ww3.Text = "0,00";
            // 
            // ww4
            // 
            this.ww4.AutoSize = true;
            this.ww4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ww4.Location = new System.Drawing.Point(374, 86);
            this.ww4.Name = "ww4";
            this.ww4.Size = new System.Drawing.Size(43, 20);
            this.ww4.TabIndex = 15;
            this.ww4.Text = "0,00";
            this.ww4.Click += new System.EventHandler(this.ww4_Click);
            // 
            // ww5
            // 
            this.ww5.AutoSize = true;
            this.ww5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ww5.Location = new System.Drawing.Point(485, 86);
            this.ww5.Name = "ww5";
            this.ww5.Size = new System.Drawing.Size(43, 20);
            this.ww5.TabIndex = 16;
            this.ww5.Text = "0,00";
            // 
            // ww6
            // 
            this.ww6.AutoSize = true;
            this.ww6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ww6.Location = new System.Drawing.Point(584, 86);
            this.ww6.Name = "ww6";
            this.ww6.Size = new System.Drawing.Size(43, 20);
            this.ww6.TabIndex = 17;
            this.ww6.Text = "0,00";
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_a.Location = new System.Drawing.Point(12, 796);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(119, 20);
            this.lbl_a.TabIndex = 18;
            this.lbl_a.Text = "Амплитуда* = ";
            // 
            // tb_a
            // 
            this.tb_a.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_a.Location = new System.Drawing.Point(129, 793);
            this.tb_a.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(56, 27);
            this.tb_a.TabIndex = 19;
            this.tb_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_a_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(212, 790);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "*вводится только один раз, далее не изменяется. \r\nПо умолч. = 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(873, 868);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 34);
            this.button2.TabIndex = 21;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(652, 868);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 34);
            this.button3.TabIndex = 22;
            this.button3.Text = "Сохранить графики";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_stud2
            // 
            this.lbl_stud2.AutoSize = true;
            this.lbl_stud2.Font = new System.Drawing.Font("Cambria", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_stud2.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_stud2.Location = new System.Drawing.Point(341, 9);
            this.lbl_stud2.Name = "lbl_stud2";
            this.lbl_stud2.Size = new System.Drawing.Size(218, 20);
            this.lbl_stud2.TabIndex = 24;
            this.lbl_stud2.Text = "Бригада №__ Группа _-__-__";
            this.lbl_stud2.Click += new System.EventHandler(this.lbl_stud2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 749);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Введите параметры, чтобы начать!";
            // 
            // graf_afh
            // 
            chartArea4.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea4.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisX.Title = "+ (Re)";
            chartArea4.AxisY.Title = "+j (Im)";
            chartArea4.Name = "ChartArea1";
            this.graf_afh.ChartAreas.Add(chartArea4);
            legend4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            this.graf_afh.Legends.Add(legend4);
            this.graf_afh.Location = new System.Drawing.Point(12, 437);
            this.graf_afh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.graf_afh.Name = "graf_afh";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Color = System.Drawing.Color.MediumVioletRed;
            series4.CustomProperties = "IsXAxisQuantitative=True, EmptyPointValue=Zero";
            series4.Legend = "Legend1";
            series4.LegendText = "АФХ";
            series4.Name = "Series1";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.YValuesPerPoint = 30;
            this.graf_afh.Series.Add(series4);
            this.graf_afh.Size = new System.Drawing.Size(476, 308);
            this.graf_afh.TabIndex = 26;
            this.graf_afh.Text = "chart2";
            // 
            // Graf2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 915);
            this.ControlBox = false;
            this.Controls.Add(this.graf_afh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_stud2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_a);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.ww6);
            this.Controls.Add(this.ww5);
            this.Controls.Add(this.ww4);
            this.Controls.Add(this.ww3);
            this.Controls.Add(this.ww2);
            this.Controls.Add(this.ww1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_w);
            this.Controls.Add(this.lbl_w);
            this.Controls.Add(this.graf_sin);
            this.Controls.Add(this.graf_fchh);
            this.Controls.Add(this.graf_achh);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Graf2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Частотные характеристики";
            this.Load += new System.EventHandler(this.Graf2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graf_achh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf_fchh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf_sin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf_afh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graf_achh;
        private System.Windows.Forms.DataVisualization.Charting.Chart graf_fchh;
        private System.Windows.Forms.DataVisualization.Charting.Chart graf_sin;
        private System.Windows.Forms.Label lbl_w;
        private System.Windows.Forms.TextBox tb_w;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ww1;
        private System.Windows.Forms.Label ww2;
        private System.Windows.Forms.Label ww3;
        private System.Windows.Forms.Label ww4;
        private System.Windows.Forms.Label ww5;
        private System.Windows.Forms.Label ww6;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_stud2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graf_afh;
    }
}