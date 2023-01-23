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
    public partial class FormVectors : Form
    {

        public FormVectors()
        {
            InitializeComponent();
        }        
        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    int len1 = 0;
                    int len2 = 0;
                    try
                    {
                        len1 = Convert.ToInt32(textBox1.Text);
                        len2 = Convert.ToInt32(textBox3.Text);
                        if (len1 <= 0 && len2 <= 0)
                            MessageBox.Show("Введите правильно размерность вектора");
                        else
                        {
                            string[] array1 = textBox2.Text.Split();
                            string[] array2 = textBox4.Text.Split();
                            ArrayVector arr1 = new ArrayVector(array1.Length);
                            try
                            {
                                for (int i = 0; i < array1.Length; i++)
                                {
                                    arr1[i] = Convert.ToInt32(array1[i]);
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Ошибка ввода.");
                            }
                            ArrayVector arr2 = new ArrayVector(array2.Length);
                            try
                            {
                                for (int i = 0; i < array2.Length; i++)
                                {
                                    arr2[i] = Convert.ToInt32(array2[i]);
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Ошибка ввода.");
                            }
                            textBox5.Text = arr1.ToString();
                            textBox6.Text = arr2.ToString();
                            double modul1 = Vectors.GetNorm(arr1);
                            textBox10.Text = "" + modul1;
                            double modul2 = Vectors.GetNorm(arr2);
                            textBox9.Text = "" + modul2;
                            try
                            {
                                if (len1 == len2)
                                {
                                    ArrayVector sum = Vectors.Sum(arr1, arr2);
                                    for (int i = 0; i < array1.Length; i++)
                                    {
                                        textBox7.Text += sum[i] + " ";
                                    }
                                }
                                else
                                    MessageBox.Show("Длины векторов разные.");
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Произошла ошибка!");
                            }
                            try
                            {
                                if (len1 == len2)
                                {
                                    double sc = Vectors.Scalar(arr1, arr2);
                                    textBox8.Text = "" + sc;
                                }                                
                                else
                                    MessageBox.Show("Длины векторов разные.");
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Произошла ошибка!");
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Введите правильно размерность вектора");
                    }
                    break;
                case 1:
                    int len3 = 0;
                    int len4 = 0;
                    try
                    {
                        len3 = Convert.ToInt32(textBox1.Text);
                        len4 = Convert.ToInt32(textBox3.Text);
                        if (len3 <= 0 && len4 <= 0)
                            MessageBox.Show("Введите правильно размерность вектора");
                        else
                        {
                            string[] array1 = textBox2.Text.Split(' ');
                            string[] array2 = textBox4.Text.Split(' ');
                            LinkedListVector arr1 = new LinkedListVector(len3);
                            try
                            {
                                for (int i = 0; i < len3; i++)
                                {
                                    arr1[i] = Convert.ToInt32(array1[i]);
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Ошибка ввода.");
                            }
                            LinkedListVector arr2 = new LinkedListVector(len4);
                            try
                            {
                                for (int i = 0; i < len4; i++)
                                {
                                    arr2[i] = Convert.ToInt32(array2[i]);
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Ошибка ввода.");
                            }
                            textBox5.Text = arr1.ToString();
                            textBox6.Text = arr2.ToString();
                            double modul1 = Vectors.GetNorm(arr1);
                            textBox10.Text = "" + modul1;
                            double modul2 = Vectors.GetNorm(arr2);
                            textBox9.Text = "" + modul2;
                            try
                            {
                                if (len3 == len4)
                                {
                                    ArrayVector sum = Vectors.Sum(arr1, arr2);
                                    for (int i = 0; i < array1.Length; i++)
                                    {
                                        textBox7.Text += sum[i] + " ";
                                    }
                                }                                
                                else
                                    MessageBox.Show("Длины векторов разные.");
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Произошла ошибка!");
                            }
                            try
                            {
                                if (len3 == len4)
                                {
                                    double sc = Vectors.Scalar(arr1, arr2);
                                    textBox8.Text = "" + sc;
                                }                                
                                else
                                    MessageBox.Show("Длины векторов разные.");
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Произошла ошибка!");
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Введите правильно размерность вектора");
                    }
                    break;
                case 2:
                    int len5 = 0;
                    int len6 = 0;
                    try
                    {
                        len5 = Convert.ToInt32(textBox1.Text);
                        len6 = Convert.ToInt32(textBox3.Text);
                        if (len5 <= 0 && len6 <= 0)
                            MessageBox.Show("Введите правильно размерность вектора");
                        else
                        {
                            string[] array1 = textBox2.Text.Split(' ');
                            string[] array2 = textBox4.Text.Split(' ');
                            LinkedListVector arr1 = new LinkedListVector(len5);
                            try
                            {
                                for (int i = 0; i < len5; i++)
                                {
                                    arr1[i] = Convert.ToInt32(array1[i]);
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Ошибка ввода.");
                            }
                            ArrayVector arr2 = new ArrayVector(len6);
                            try
                            {
                                for (int i = 0; i < len6; i++)
                                {
                                    arr2[i] = Convert.ToInt32(array2[i]);
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Ошибка ввода.");
                            }
                            textBox5.Text = arr1.ToString();
                            textBox6.Text = arr2.ToString();
                            double modul1 = Vectors.GetNorm(arr1);
                            textBox10.Text = "" + modul1;
                            double modul2 = Vectors.GetNorm(arr2);
                            textBox9.Text = "" + modul2;
                            try
                            {
                                if (len5 == len6)
                                {
                                    ArrayVector sum = Vectors.Sum(arr1, arr2);
                                    for (int i = 0; i < array1.Length; i++)
                                    {
                                        textBox7.Text += sum[i] + " ";
                                    }
                                }
                                else
                                    MessageBox.Show("Длины векторов разные.");
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Произошла ошибка!");
                            }
                            try
                            {
                                if (len5 == len6)
                                {
                                    double sc = Vectors.Scalar(arr1, arr2);
                                    textBox8.Text = "" + sc;
                                }                               
                                else
                                    MessageBox.Show("Длины векторов разные.");
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Произошла ошибка!");
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Введите правильно размерность вектора");
                    }
                    break;
                case 3:
                    int len7 = 0;
                    int len8 = 0;
                    try
                    {
                        len7 = Convert.ToInt32(textBox1.Text);
                        len8 = Convert.ToInt32(textBox3.Text);
                        if (len7 <= 0 && len8 <= 0)
                            MessageBox.Show("Введите правильно размерность вектора");
                        else
                        {
                            string[] array1 = textBox2.Text.Split(' ');
                            string[] array2 = textBox4.Text.Split(' ');
                            ArrayVector arr1 = new ArrayVector(len7);
                            try
                            {
                                for (int i = 0; i < len7; i++)
                                {
                                    arr1[i] = Convert.ToInt32(array1[i]);
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Ошибка ввода.");
                            }
                            LinkedListVector arr2 = new LinkedListVector(len8);
                            try
                            {
                                for (int i = 0; i < len8; i++)
                                {
                                    arr2[i] = Convert.ToInt32(array2[i]);
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Ошибка ввода.");
                            }
                            textBox5.Text = arr1.ToString();
                            textBox6.Text = arr2.ToString();
                            double modul1 = Vectors.GetNorm(arr1);
                            textBox10.Text = "" + modul1;
                            double modul2 = Vectors.GetNorm(arr2);
                            textBox9.Text = "" + modul2;
                            try
                            {
                                if (len7 == len8)
                                {
                                    ArrayVector sum = Vectors.Sum(arr1, arr2);
                                    for (int i = 0; i < array1.Length; i++)
                                    {
                                        textBox7.Text += sum[i] + " ";
                                    }
                                }
                                else
                                    MessageBox.Show("Длины векторов разные.");
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Произошла ошибка!");
                            }
                            try
                            {
                                if (len7 == len8)
                                {
                                    double sc = Vectors.Scalar(arr1, arr2);
                                    textBox8.Text = "" + sc;
                                }
                                else
                                    MessageBox.Show("Длины векторов разные.");
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Произошла ошибка!");
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Введите правильно размерность вектора");
                    }
                    break;
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox10_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox9_TextChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }               
    }
}
