using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР08
{
    public partial class FormLinkedListVector : Form
    {
        public FormLinkedListVector()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int len = 0;
            try
            {
                len = Convert.ToInt32(textBox1.Text);
                if (len <= 0)
                    MessageBox.Show("Введите правильно размерность вектора");
                else
                {
                    LinkedListVector arr = new LinkedListVector(len);
                    string[] array = textBox2.Text.Split(' ');
                    try
                    {
                        for (int i = 0; i < len; i++)
                        {
                            arr[i] = Convert.ToInt32(array[i]);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка ввода.");
                    }
                    textBox3.Text = arr.ToString();
                    double modul = arr.GetNorm();
                    textBox4.Text = "" + modul;
                    try
                    {
                        int index = Convert.ToInt32(textBox5.Text);
                        double k = arr[index - 1];
                        if (k == 0)
                            MessageBox.Show("Элемента с таким номером не существует");
                        else
                            textBox6.Text = "" + k;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка ввода.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите правильно размерность вектора");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox5.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }       
    }
}
