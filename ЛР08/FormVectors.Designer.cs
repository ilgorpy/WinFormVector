﻿
namespace ЛР08
{
    partial class FormVectors
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ЛР08.Properties.Resources.ЛР085;
            this.pictureBox1.Location = new System.Drawing.Point(0, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1080);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1400, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vectors";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Bisque;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(50, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите размерность первого вектора/списка:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ArrayVector и ArrayVector",
            "LinkedListVector и LinkedListVector",
            "LinkedListVector и ArrayVector",
            "ArrayVector и LinkedListVector"});
            this.comboBox1.Location = new System.Drawing.Point(50, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Выберите типы массивов:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Bisque;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(50, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите размерность второго вектора/списка:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(497, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Bisque;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(50, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(441, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите элементы первого вектора/списка:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(497, 225);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 22);
            this.textBox2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Bisque;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(50, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(441, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Введите элементы второго вектора/списка:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(497, 262);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 22);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(497, 299);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(226, 22);
            this.textBox4.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Bisque;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(761, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(441, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Первый введенный вектор/список:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Bisque;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(761, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(441, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Второй введенный вектор/список:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1208, 149);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(226, 22);
            this.textBox5.TabIndex = 14;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1208, 188);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(226, 22);
            this.textBox6.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Bisque;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(761, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(441, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Сумма векторов/списков:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1208, 225);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(226, 22);
            this.textBox7.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Bisque;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(761, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(441, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Скалярное произведение векторов/списков:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1208, 262);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(226, 22);
            this.textBox8.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Bisque;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(761, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(441, 22);
            this.label10.TabIndex = 20;
            this.label10.Text = "Модуль первого вектора/списка:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Bisque;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(761, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(441, 22);
            this.label11.TabIndex = 21;
            this.label11.Text = "Модуль второго вектора/списка:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(1208, 336);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(226, 22);
            this.textBox9.TabIndex = 22;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(1208, 299);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(226, 22);
            this.textBox10.TabIndex = 23;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(931, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 30);
            this.button1.TabIndex = 24;
            this.button1.Text = "Рассчитать:";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Bisque;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(761, 373);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 30);
            this.button3.TabIndex = 25;
            this.button3.Text = "Очистить поля";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Bisque;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(50, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 44);
            this.label12.TabIndex = 26;
            this.label12.Text = "Введите:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Bisque;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(761, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 44);
            this.label13.TabIndex = 27;
            this.label13.Text = "Результат:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Bisque;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(931, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 30);
            this.button2.TabIndex = 28;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // FormVectors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 556);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormVectors";
            this.Text = "FormVectors";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
    }
}