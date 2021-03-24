using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Numerics;

namespace OTU_lab2
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //label3.Text = "p" & ChrW(&HB2) & "  " & "25" & ChrW(&HB3)
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string zveno = "";

            bool correct_students = false;
            if (tb_br.Visible == true)
            {
                if ((tb_br.Text != "") & (tb_gr.Text != ""))
                {
                    tb_br.Visible = false;
                    tb_gr.Visible = false;
                    lbl_br.Text += tb_br.Text;
                    lbl_gr.Text += tb_gr.Text;
                    correct_students = true;
                }
                else
                    MessageBox.Show("Заполните данные о бригаде и группе!");
            } else { correct_students = true; }

            double df1 = Math.Round(Convert.ToDouble(d1.Text), 2);
            double df2 = Math.Round(Convert.ToDouble(d2.Text), 2);
            double df3 = Math.Round(Convert.ToDouble(d3.Text), 2);
            double df4 = Math.Round(Convert.ToDouble(d4.Text), 2);
            double df5 = Math.Round(Convert.ToDouble(d5.Text), 2);
            double df6 = Math.Round(Convert.ToDouble(d6.Text), 2);

            bool correct_p = false;

            if (iiz.Checked)
            {
                if ((df1 == 0) & (df2 == 0) & (df3 != 0) & (df4 == 0) & (df5 != 0) & (df6 == 0))
                {
                    correct_p = true;
                    zveno = "iiz";
                }
                else
                {
                    MessageBox.Show("Параметры не соответсвуют типу звена.\n Проверьте данные и повторите попытку!");
                }
            }
            if (iz.Checked)
            {
                if ((df1 == 0) & (df2 == 0) & (df3 != 0) & (df4 == 0) & (df5 != 0) & (df6 != 0))
                {
                    correct_p = true;
                    zveno = "iz";
                }
                else
                {
                    MessageBox.Show("Параметры не соответсвуют типу звена.\n Проверьте данные и повторите попытку!");
                }
            }
            if (rdz.Checked)
            {
                if ((df1 == 0) & (df2 != 0) & (df3 == 0) & (df4 == 0) & (df5 != 0) & (df6 != 0))
                {
                    correct_p = true;
                    zveno = "rdz";
                }
                else
                {
                    MessageBox.Show("Параметры не соответсвуют типу звена.\n Проверьте данные и повторите попытку!");
                }
            }
            if (uz.Checked)
            {
                if ((df1 == 0) & (df2 != 0) & (df3 != 0) & (df4 == 0) & (df5 != 0) & (df6 != 0))
                {
                    correct_p = true;
                    zveno = "uz";
                }
                else
                {
                    MessageBox.Show("Параметры не соответсвуют типу звена.\n Проверьте данные и повторите попытку!");
                }
            }
            if (kz.Checked)
            {
                if ((df1 == 0) & (df2 == 0) & (df3 != 0) & (df4 != 0) & (df5 != 0) & (df6 != 0))
                {
                    correct_p = true;
                    zveno = "kz";
                }
                else
                {
                    MessageBox.Show("Параметры не соответсвуют типу звена.\n Проверьте данные и повторите попытку!");
                }
            }
            //прописать соответствие для каждого типа звена (параметры)
            //обработка исключения для звена, а не общего запуска окна!!!!
            //ПЕРЕНЕСТИ
            if (correct_p & correct_students) { //если всё верно, то молча открыть след. окно
                Graf1 graph_h = new Graf1(df1, df2, df3, df4, df5, df6, tb_br.Text, tb_gr.Text, zveno);
                //correct_p = false;
                graph_h.Show();
            } 
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string zveno = "";

            bool correct_students = false;
            if (tb_br.Visible)
            {
                if ((tb_br.Text != "") & (tb_gr.Text != ""))
                {
                    tb_br.Visible = false;
                    tb_gr.Visible = false;
                    lbl_br.Text += tb_br.Text;
                    lbl_gr.Text += tb_gr.Text;
                    correct_students = true;
                }
                else
                    MessageBox.Show("Заполните данные о бригаде и группе!");
            } else { correct_students = true; }

            double wp1 = Math.Round(Convert.ToDouble(w1.Text), 2);
            double wp2 = Math.Round(Convert.ToDouble(w2.Text), 2);
            double wp3 = Math.Round(Convert.ToDouble(w3.Text), 2);
            double wp4 = Math.Round(Convert.ToDouble(w4.Text), 2);
            double wp5 = Math.Round(Convert.ToDouble(w5.Text), 2);
            double wp6 = Math.Round(Convert.ToDouble(w6.Text), 2);

            bool correct_ch = false;

            if (iiz.Checked)
            {
                if ((wp1 == 0) & (wp2 == 0) & (wp3 != 0) & (wp4 == 0) & (wp5 != 0) & (wp6 == 0))
                {
                    correct_ch = true;
                    zveno = "iiz";
                }
                else
                {
                    MessageBox.Show("Параметры не соответсвуют типу звена.\n Проверьте данные и повторите попытку!");
                }
            }
            if (iz.Checked)
            {
                if ((wp1 == 0) & (wp2 == 0) & (wp3 != 0) & (wp4 == 0) & (wp5 != 0) & (wp6 != 0))
                {
                    correct_ch = true;
                    zveno = "iz";
                }
                else
                {
                    MessageBox.Show("Параметры не соответсвуют типу звена.\n Проверьте данные и повторите попытку!");
                }
            }
            if (rdz.Checked)
            {
                if ((wp1 == 0) & (wp2 != 0) & (wp3 == 0) & (wp4 == 0) & (wp5 != 0) & (wp6 != 0))
                {
                    correct_ch = true;
                    zveno = "rdz";
                }
                else
                {
                    MessageBox.Show("Параметры не соответсвуют типу звена.\n Проверьте данные и повторите попытку!");
                }
            }
            if (kz.Checked)
            {
                if ((wp1 == 0) & (wp2 == 0) & (wp3 != 0) & (wp4 != 0) & (wp5 != 0) & (wp6 != 0))
                {
                    correct_ch = true;
                    zveno = "kz";
                }
                else
                {
                    MessageBox.Show("Параметры не соответсвуют типу звена.\n Проверьте данные и повторите попытку!");
                }
            }
            if (uz.Checked)
            {
                if ((wp1 == 0) & (wp2 != 0) & (wp3 != 0) & (wp4 == 0) & (wp5 != 0) & (wp6 != 0))
                {
                    correct_ch = true;
                    zveno = "uz";
                }
                else
                {
                    MessageBox.Show("Параметры не соответсвуют типу звена.\n Проверьте данные и повторите попытку!");
                }
            }
            //correct_ch = true;
            //прописать соответствие для каждого типа звена (параметры)

            //ЗАГЛУШКА
            //zveno = "iz";

            if (correct_ch & correct_students)
            {
                Graf2 graph_a = new Graf2(wp1, wp2, wp3, wp4, wp5, wp6, tb_br.Text, tb_gr.Text, zveno);
                //correct_ch = false;
                graph_a.Show();
            }

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox10_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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

        private void w2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void w3_TextChanged(object sender, EventArgs e)
        {

        }

        private void w3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void w4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void w5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void w6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void d1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void d2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void d3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void d4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void d5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void d6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            Reference_Materials R_M = new Reference_Materials();
            R_M.Show();
        }

        private void rdz_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Lab2_Load(object sender, EventArgs e)
        {

        }
    }
}
