﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_nesterov_kak_delfi_1_laba_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c;
            c = a + b;
            textBox3.Text = Convert.ToString(c);
            label4.Text = "Сложение";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c;
            c = a - b;
            textBox3.Text = Convert.ToString(c);
            label4.Text = "Вычитание";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c;
            c = a / b;
            textBox3.Text = Convert.ToString(c);
            label4.Text = "Деление";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c;
            c = a * b;
            textBox3.Text = Convert.ToString(c);
            label4.Text = "Умножение";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
