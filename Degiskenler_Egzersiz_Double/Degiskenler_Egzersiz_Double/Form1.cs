using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_Egzersiz_Double
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            double sinav1, sinav2, proje;
            double ort;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            sinav1=int.Parse(textBox3.Text);//Convert.ToInt16(txtbox.text);
            sinav2=int.Parse(textBox4.Text);
            proje=int.Parse(textBox5.Text);
            ort = (sinav1 * 30 + sinav2 * 30 + proje * 40) / 100;
            listBox1.Items.Add(ad + " " +soyad + " " + ort);
        }
    }
}
