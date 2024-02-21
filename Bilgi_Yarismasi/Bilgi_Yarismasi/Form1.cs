using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;

            LblDogru.Text = BtnB.Text;
            if (label4.Text == LblDogru.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            BtnSonraki.Enabled = true;

        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;

            LblDogru.Text = BtnC.Text;
            if (label4.Text == LblDogru.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            BtnSonraki.Enabled = true;

        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;

            LblDogru.Text = BtnD.Text;
            if (label4.Text == LblDogru.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            BtnSonraki.Enabled = true;

        }

        private void BtnA_Click(object sender, EventArgs e)
        {
                BtnA.Enabled=false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;

            LblDogru.Text=BtnA.Text;
            if (label4.Text==LblDogru.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            BtnSonraki.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            soruno++;
            LblSoruno.Text = soruno.ToString();
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            if (soruno==1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında kuruldu ?";
                BtnA.Text = "1920";
                BtnB.Text = "1922";
                BtnC.Text = "1923";
                BtnD.Text = "1925";
                label4.Text = "1923";//doğru cevap
            }
            if (soruno==2)
            {
                richTextBox1.Text = "Hangi il Ege bölgesinde değildir ?";
                BtnA.Text = "İzmir";
                BtnB.Text = "Balıkesir";
                BtnC.Text = "Aydın";
                BtnD.Text = "Manisa";
                label4.Text = "Balıkesir";//doğru cevap
            }
            if (soruno==3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir ?";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Süreya";
                BtnC.Text = "Attila İlhan";
                BtnD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";//doğru cevap
                BtnSonraki.Text = "Sonuçlar";

            }
            if (soruno==4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogru +"\nYanlış: " + yanlis);
            }

        }
    }
}
