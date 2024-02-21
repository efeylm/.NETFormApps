﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus(); 
        }
        void renklendir() {
            textBox1.BackColor = Color.Green;
            textBox2.BackColor = Color.SaddleBrown;
            textBox3.BackColor = Color.Black;
            textBox4.BackColor= Color.Tan;
        }

        void printInfo()
        {
            string[] info = { "Efe", "Yalım", "20", "İstanbul" };
            textBox1.Text = info[0];
            textBox2.Text = info[1];
            textBox3.Text = info[2];
            textBox4.Text = info[3];

        }
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printInfo();
        }
    }
}
