using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace OTU_lab2
{
    public partial class Graf2 : Form
    {
        string type = "none";

        public Graf2(double w1, double w2, double w3, double w4, double w5, double w6, string br, string gr, string type_z)
        {
            InitializeComponent();
            //антиплагиат
            lbl_stud2.Text = "Бригада №" + br + "   Группа: " + gr;

            //тип звена
            type = type_z;

            //вывод дифф. формулы
            this.ww1.Text = Convert.ToString(w1);
            this.ww2.Text = Convert.ToString(w2);
            this.ww3.Text = Convert.ToString(w3);
            this.ww4.Text = Convert.ToString(w4);
            this.ww5.Text = Convert.ToString(w5);
            this.ww6.Text = Convert.ToString(w6);

            //график, начало осей
            graf_achh.ChartAreas[0].AxisX.Minimum = 0;
            graf_fchh.ChartAreas[0].AxisX.Minimum = 0;
        }

        private void chart4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 1;
            if (tb_a.Visible)
            {
                if (tb_a.Text != "")
                {
                    a = Convert.ToDouble(tb_a.Text);
                    tb_a.Visible = false;
                    lbl_a.Text = "Амплитуда = ";
                    lbl_a.Text += tb_a.Text;
                    label1.Visible = false;
                    label2.Visible = false;
                } else
                {
                    //a = Convert.ToDouble(tb_a.Text);
                    tb_a.Visible = false;
                    lbl_a.Text = "Амплитуда = ";
                    lbl_a.Text += a;
                    label1.Visible = false;
                    label2.Visible = false;
                }
                
                int count = (int)Math.Ceiling((12 - 0) / 0.01) + 1;
                double[] xs = new double[count];
                double[] ys = new double[count];

                for (int i = 0; i < count; i++) //точки для графика
                {
                    xs[i] = 0 + 0.01 * i;
                    ys[i] = a*Math.Sin(xs[i]);
                }
                graf_sin.ChartAreas[0].AxisX.Minimum = 0;
                graf_sin.ChartAreas[0].AxisX.Maximum = 12; 
                graf_sin.Series[0].Points.DataBindXY(xs, ys);
            }

            double xy, y1, y2, x_re, y_im = 0;
            switch (type)
            {
                case "iiz":
                    //идеал. интегрирующее звено
                    xy = Convert.ToDouble(tb_w.Text);
                    if (a == 0)
                    {
                        MessageBox.Show("Некорректная амплитуда! \nИзмените данные и повторите попытку.");
                        //this.Hide();
                        break;
                    }
                    if (xy == 0)
                    {
                        MessageBox.Show("Частота не может быть равна нулю!\nВведите другое число.");
                        break;
                    }
                    else {
                        y1 = Convert.ToDouble(ww3.Text) / xy ;
                        graf_achh.Series[0].Points.AddXY(xy, y1);
                        y2 = -Math.PI / 2;
                        graf_fchh.Series[0].Points.AddXY(xy, y2);
                        Complex com = y1 * Complex.Exp(Complex.ImaginaryOne * y2); //A(w)*e^(j*f(w))
                        x_re = Math.Round(com.Real, 4);
                        y_im = Math.Round(com.Imaginary, 4);
                        graf_afh.Series[0].Points.AddXY(x_re,y_im);
                    }
                    break;
                case "iz":
                    //инерционное звено
                    xy = Convert.ToDouble(tb_w.Text);
                    if (a == 0)
                    {
                        MessageBox.Show("Некорректная амплитуда! \nИзмените данные и повторите попытку.");
                        break;
                    }
                    if (xy == 0)
                    {
                        MessageBox.Show("Частота не может быть равна нулю!\nВведите другое число.");
                        break;
                    }
                    else
                    {
                        y1 = Convert.ToDouble(ww3.Text) / ((Math.Sqrt(1+Math.Pow(Convert.ToDouble(ww5.Text)*xy,2))));
                        graf_achh.Series[0].Points.AddXY(xy, y1);
                        y2 = -Math.Atan(xy*Convert.ToDouble(ww5.Text));
                        graf_fchh.Series[0].Points.AddXY(xy, y2);
                        Complex com = y1 * Complex.Exp(Complex.ImaginaryOne * y2); //A(w)*e^(j*f(w))
                        x_re = Math.Round(com.Real, 4);
                        y_im = Math.Round(com.Imaginary, 4);
                        graf_afh.Series[0].Points.AddXY(x_re, y_im);
                    }
                    break;
                case "pz":
                    //
                    break;
                case "rdz":
                    xy = Convert.ToDouble(tb_w.Text);
                    if (a == 0)
                    {
                        MessageBox.Show("Некорректная амплитуда! \nИзмените данные и повторите попытку.");
                        break;
                    }
                    if (xy == 0)
                    {
                        MessageBox.Show("Частота не может быть равна нулю!\nВведите другое число.");
                        break;
                    }
                    else
                    {
                        y1 = (Convert.ToDouble(ww2.Text) * xy) / ((Math.Sqrt(1 + Math.Pow(Convert.ToDouble(ww5.Text) * xy, 2))));
                        graf_achh.Series[0].Points.AddXY(xy, y1);
                        y2 = Math.PI/2-Math.Atan(xy * Convert.ToDouble(ww5.Text));
                        graf_fchh.Series[0].Points.AddXY(xy, y2);
                        Complex com = y1 * Complex.Exp(Complex.ImaginaryOne * y2); //A(w)*e^(j*f(w))
                        x_re = Math.Round(com.Real, 4);
                        y_im = Math.Round(com.Imaginary, 4);
                        graf_afh.Series[0].Points.AddXY(x_re, y_im);
                    }
                    break;
                case "kz":
                    xy = Convert.ToDouble(tb_w.Text);
                    if (a == 0)
                    {
                        MessageBox.Show("Некорректная амплитуда! \nИзмените данные и повторите попытку.");
                        break;
                    }
                    if (xy == 0)
                    {
                        MessageBox.Show("Частота не может быть равна нулю!\nВведите другое число.");
                        break;
                    }
                    else
                    {
                        double wat =Math.Pow(Convert.ToDouble(ww5.Text),2);
                        y1 = Convert.ToDouble(ww3.Text) / (Math.Sqrt((Math.Pow((1-Convert.ToDouble(ww4.Text)*Math.Pow(xy,2)),2))+wat*Math.Pow(xy,2)));
                        graf_achh.Series[0].Points.AddXY(xy, y1);
                        if ((Convert.ToDouble(ww4.Text) * Math.Pow(xy, 2)) > 1)
                        {
                            y2= 0 - (Math.Atan(Convert.ToDouble(ww5.Text) / (1 - Convert.ToDouble(ww4.Text) * Math.Pow(xy, 2)))+Math.PI);
                        }
                        else
                        {
                            y2 = 0 - (Math.Atan(Convert.ToDouble(ww5.Text)/(1-Convert.ToDouble(ww4.Text)*Math.Pow(xy,2))));
                        }
                        //y2 = Math.PI / 2 - Math.Atan(xy * Convert.ToDouble(ww5.Text));
                        graf_fchh.Series[0].Points.AddXY(xy, y2);
                        Complex com = y1 * Complex.Exp(Complex.ImaginaryOne * y2); //A(w)*e^(j*f(w))
                        x_re = Math.Round(com.Real, 4);
                        y_im = Math.Round(com.Imaginary, 4);
                        graf_afh.Series[0].Points.AddXY(x_re, y_im);
                    }
                    break;
                case "uz":
                    double k = Convert.ToDouble(ww3.Text);
                    double T0 = Convert.ToDouble(ww2.Text) / k;
                    double T = Convert.ToDouble(ww5.Text);
                    double tau = T0 / T;
                    xy = Convert.ToDouble(tb_w.Text);
                    if (a == 0)
                    {
                        MessageBox.Show("Некорректная амплитуда! \nИзмените данные и повторите попытку.");
                        break;
                    }
                    if (xy == 0)
                    {
                        MessageBox.Show("Частота не может быть равна нулю!\nВведите другое число.");
                        break;
                    }
                    else
                    {
                        //y1 = (Convert.ToDouble(ww3.Text) * xy) / ((Math.Sqrt(1 + Math.Pow(Convert.ToDouble(ww5.Text) * xy, 2))));
                        y1 = (k * ((Math.Sqrt(Math.Pow(xy * T0, 2) + 1)) / (Math.Sqrt(1 + Math.Pow(xy * T, 2)))));
                        graf_achh.Series[0].Points.AddXY(xy, y1);
                        //y2 = Math.PI / 2 - Math.Atan(xy * Convert.ToDouble(ww5.Text));
                        y2 = Math.Atan(xy * T0) - Math.Atan(xy * T);
                        graf_fchh.Series[0].Points.AddXY(xy, y2);
                        Complex com = y1 * Complex.Exp(Complex.ImaginaryOne * y2); //A(w)*e^(j*f(w))
                        x_re = Math.Round(com.Real, 4);
                        y_im = Math.Round(com.Imaginary, 4);
                        graf_afh.Series[0].Points.AddXY(x_re, y_im);
                    }
                    break;
                default:
                    MessageBox.Show("Ошибка, тип звена не найден.");
                    break;
            }
        }

        private void ww4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            graf_achh.Series[0].Points.Clear();
            graf_fchh.Series[0].Points.Clear();
            graf_afh.Series[0].Points.Clear();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rectangle bounds = this.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left - 10, bounds.Top - 10), new Point(-20, -20), bounds.Size);
                }
                SaveFileDialog dial = new SaveFileDialog();
                dial.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp";
                if (dial.ShowDialog() == DialogResult.OK)
                {
                    bitmap.Save(dial.FileName);
                }
            }
            graf_achh.Series[0].Points.Clear();
            graf_fchh.Series[0].Points.Clear();
            graf_afh.Series[0].Points.Clear();
            this.Hide();
        }

        private void graf_fchh_Click(object sender, EventArgs e)
        {

        }

        private void Graf2_Load(object sender, EventArgs e)
        {

        }

        private void graf_achh_Click(object sender, EventArgs e)
        {

        }

        private void graf_afh_Click(object sender, EventArgs e)
        {

        }

        private void tb_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void lbl_stud2_Click(object sender, EventArgs e)
        {

        }
    }
}
