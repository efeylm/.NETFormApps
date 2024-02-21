using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int midterm, homework, final, gano;            
            midterm = int.Parse(maskedTextBox1.Text);
            homework = int.Parse(maskedTextBox2.Text);
            final = int.Parse(maskedTextBox3.Text);
            gano=((midterm*4)+homework*2+final*4)/10;

            label5.Text = gano.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
