using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OTU_lab2
{
    public partial class Graf1 : Form
    {
        string type = "0";
        public Graf1(double d1, double d2, double d3, double d4, double d5, double d6, string br, string gr, string type_z)//добавить: передача типа звена = name
        {
            InitializeComponent();
            //антиплагиат
            lbl_stud1.Text="Бригада №"+br+"   Группа: "+gr;

            lbl_diff.Text = d1 + "·x''+"+d2+ "·x'+"+d3+ "·x = "+d4 + "·y''+"+d5+ "·y'+"+d6+ "·y";

            //тип звена
            type = type_z;

            //вывод дифф. формулы
            this.dd1.Text = Convert.ToString(d1); 
            this.dd2.Text = Convert.ToString(d2);
            this.dd3.Text = Convert.ToString(d3);
            this.dd4.Text = Convert.ToString(d4);
            this.dd5.Text = Convert.ToString(d5);
            this.dd6.Text = Convert.ToString(d6);

            //график
            //int xmax = 10;
            int xmin = 0;
            double step = 0.01;
            int count = 1001;
            
            double[] x = new double[count];
            double[] y = new double[count];

            graf_h.ChartAreas[0].AxisX.Minimum = xmin;
            graf_h.ChartAreas[0].AxisX.MajorGrid.Interval=1;
            //graf_h.ChartAreas[0].AxisY.MajorGrid.Interval = 0.1;

            switch (type)
            {
                case "iiz":
                    //идеал. интегрирующее звено
                    graf_h.ChartAreas[0].AxisY.MajorGrid.Interval = 1;
                    for (int i = 0; i < count; i++)
                    {
                        x[i] = xmin + step * i;
                        y[i] = d3 * x[i];
                    }
                    graf_h.Series[0].Points.DataBindXY(x, y);
                    break;
                case "iz":
                    //инерционное звено
                    graf_h.ChartAreas[0].AxisY.MajorGrid.Interval = 0.1;
                    for (int i = 0; i < count; i++)
                    {
                        x[i] = xmin + step * i;
                        y[i] = d3 * (1 - (Math.Exp(-x[i] / d5)));
                    }
                    graf_h.Series[0].Points.DataBindXY(x, y);
                    break;
                case "pz":
                    MessageBox.Show("Звено не задано по условию программы. Построение недоступно.");
                    break;
                case "rdz":
                    //реальное дифф. звено
                    graf_h.ChartAreas[0].AxisY.MajorGrid.Interval = 0.05;
                    for (int i = 0; i < count; i++)
                    {
                        x[i] = xmin + step * i;
                        y[i] = (d2 / d5) * (Math.Exp(-x[i] / d5));
                    }
                    graf_h.Series[0].Points.DataBindXY(x, y);
                    break;
                case "kz":
                    //колебательное звено
                    graf_h.ChartAreas[0].AxisX.Maximum = 25;
                    count = 104;
                    graf_h.ChartAreas[0].AxisY.MajorGrid.Interval = 0.25;
                    step = 0.25;
                    double T = Math.Sqrt(d4);
                    double kk = d3;
                    double d = d5 / (2*T);
                    double w0 = 1 / T;
                    double w1 = (w0 * Math.Sqrt((1-Math.Pow(d,2))));
                    for (int i = 0; i < count; i++)
                    {
                        x[i] = xmin + step * i;
                        //x[i] = xmin + 0.25 * i;
                        y[i] = (kk * (1 - Math.Exp(-d * x[i] / T) * (Math.Cos(w1 * x[i]) + (d / T) * Math.Sin(w1 * x[i]))));
                        graf_h.Series[0].Points.AddXY(x[i],y[i]);
                    }
                    //graf_h.Series[0].Points.DataBindXY(x, y);
                    break;
                case "uz":
                    //упругое звено
                    graf_h.ChartAreas[0].AxisY.MajorGrid.Interval = 0.1;
                    double k = d3;
                    double T0 = d2 / k;
                    double T1 = d5;
                    double tau = T0 / T1;
                    for (int i = 0; i < count; i++)
                    {
                        x[i] = xmin + step * i;
                        y[i] = (k * (1 + (tau - 1)*(Math.Exp(-x[i] / T1))));
                    }
                    graf_h.Series[0].Points.DataBindXY(x, y);
                    break;
                default:
                    MessageBox.Show("Ошибка, тип звена не найден.");
                    break;
                
                
            }
        }

        private void Graf1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle bounds = this.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left-10, bounds.Top-10), new Point(-20,-20), bounds.Size);
                }
                SaveFileDialog dial = new SaveFileDialog();
                dial.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp";
                if (dial.ShowDialog() == DialogResult.OK)
                {
                    bitmap.Save(dial.FileName);
                }
            }
            //Array.Clear(x,0,901);
            graf_h.Series[0].Points.Clear();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Array.Clear(x[],0,1001);
            graf_h.Series[0].Points.Clear();
            this.Hide();
        }
    }
}
