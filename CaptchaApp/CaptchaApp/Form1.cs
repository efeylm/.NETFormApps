using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptchaApp
{
    public partial class Form1 : Form
    {       
        public Form1()
        {

            InitializeComponent();
        }
        string word;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] sembol2 = { "+", "-", "*", "/", "#" };

            Random rnd = new Random();
            int s1, s2, s3, s4, s5;
            s1 = rnd.Next(0, sembol1.Length);
            s2 = rnd.Next(0, sembol2.Length);
            s3 = rnd.Next(0, 10);
            s4 = rnd.Next(0, sembol1.Length);
            s5 = rnd.Next(0, 10);

            word = sembol1[s1] + sembol2[s2] + s3 + sembol1[s1] + s5;
            //label1.Text = sembol1[s1] + sembol2[s2] + s3 + sembol1[s1]+s5;
            label1.Text = word;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text==word)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
