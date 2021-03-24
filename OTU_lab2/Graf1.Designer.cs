namespace OTU_lab2
{
    partial class Graf1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graf1));
            this.graf_h = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dd3 = new System.Windows.Forms.Label();
            this.dd5 = new System.Windows.Forms.Label();
            this.dd1 = new System.Windows.Forms.Label();
            this.dd2 = new System.Windows.Forms.Label();
            this.dd4 = new System.Windows.Forms.Label();
            this.dd6 = new System.Windows.Forms.Label();
            this.lbl_stud1 = new System.Windows.Forms.Label();
            this.lbl_diff = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.graf_h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // graf_h
            // 
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorTickMark.Interval = 0D;
            chartArea1.AxisX.Title = "t";
            chartArea1.AxisY.Title = "h(t)";
            chartArea1.BorderColor = System.Drawing.Color.Bisque;
            chartArea1.Name = "ChartArea1";
            this.graf_h.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graf_h.Legends.Add(legend1);
            this.graf_h.Location = new System.Drawing.Point(0, 78);
            this.graf_h.Name = "graf_h";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.RoyalBlue;
            series1.LabelForeColor = System.Drawing.Color.Gray;
            series1.Legend = "Legend1";
            series1.LegendText = "h(t)";
            series1.Name = "Series1";
            this.graf_h.Series.Add(series1);
            this.graf_h.Size = new System.Drawing.Size(804, 362);
            this.graf_h.TabIndex = 1;
            this.graf_h.Text = "Передаточные характеристики";
            this.graf_h.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(137, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить график";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(545, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dd3
            // 
            this.dd3.AutoSize = true;
            this.dd3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dd3.Location = new System.Drawing.Point(216, 25);
            this.dd3.Name = "dd3";
            this.dd3.Size = new System.Drawing.Size(39, 20);
            this.dd3.TabIndex = 5;
            this.dd3.Text = "dd3";
            this.dd3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dd5
            // 
            this.dd5.AutoSize = true;
            this.dd5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dd5.Location = new System.Drawing.Point(398, 25);
            this.dd5.Name = "dd5";
            this.dd5.Size = new System.Drawing.Size(39, 20);
            this.dd5.TabIndex = 6;
            this.dd5.Text = "dd5";
            this.dd5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dd1
            // 
            this.dd1.AutoSize = true;
            this.dd1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dd1.Location = new System.Drawing.Point(32, 24);
            this.dd1.Name = "dd1";
            this.dd1.Size = new System.Drawing.Size(39, 20);
            this.dd1.TabIndex = 7;
            this.dd1.Text = "dd1";
            this.dd1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dd2
            // 
            this.dd2.AutoSize = true;
            this.dd2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dd2.Location = new System.Drawing.Point(127, 25);
            this.dd2.Name = "dd2";
            this.dd2.Size = new System.Drawing.Size(39, 20);
            this.dd2.TabIndex = 8;
            this.dd2.Text = "dd2";
            this.dd2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dd4
            // 
            this.dd4.AutoSize = true;
            this.dd4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dd4.Location = new System.Drawing.Point(297, 25);
            this.dd4.Name = "dd4";
            this.dd4.Size = new System.Drawing.Size(39, 20);
            this.dd4.TabIndex = 9;
            this.dd4.Text = "dd4";
            this.dd4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dd6
            // 
            this.dd6.AutoSize = true;
            this.dd6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dd6.Location = new System.Drawing.Point(485, 25);
            this.dd6.Name = "dd6";
            this.dd6.Size = new System.Drawing.Size(39, 20);
            this.dd6.TabIndex = 10;
            this.dd6.Text = "dd6";
            this.dd6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_stud1
            // 
            this.lbl_stud1.AutoSize = true;
            this.lbl_stud1.Font = new System.Drawing.Font("Cambria", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_stud1.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_stud1.Location = new System.Drawing.Point(263, 75);
            this.lbl_stud1.Name = "lbl_stud1";
            this.lbl_stud1.Size = new System.Drawing.Size(218, 20);
            this.lbl_stud1.TabIndex = 11;
            this.lbl_stud1.Text = "Бригада №__ Группа _-__-__";
            // 
            // lbl_diff
            // 
            this.lbl_diff.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_diff.Location = new System.Drawing.Point(240, 29);
            this.lbl_diff.Name = "lbl_diff";
            this.lbl_diff.Size = new System.Drawing.Size(533, 29);
            this.lbl_diff.TabIndex = 12;
            this.lbl_diff.Text = "Дифф. формула";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dd3);
            this.panel1.Controls.Add(this.dd5);
            this.panel1.Controls.Add(this.dd6);
            this.panel1.Controls.Add(this.dd1);
            this.panel1.Controls.Add(this.dd4);
            this.panel1.Controls.Add(this.dd2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(143, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 66);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // Graf1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 492);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_diff);
            this.Controls.Add(this.lbl_stud1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.graf_h);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Graf1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Переходные характеристики";
            this.Load += new System.EventHandler(this.Graf1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graf_h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graf_h;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label dd3;
        private System.Windows.Forms.Label dd5;
        private System.Windows.Forms.Label dd1;
        private System.Windows.Forms.Label dd2;
        private System.Windows.Forms.Label dd4;
        private System.Windows.Forms.Label dd6;
        private System.Windows.Forms.Label lbl_stud1;
        private System.Windows.Forms.Label lbl_diff;
        private System.Windows.Forms.Panel panel1;
    }
}