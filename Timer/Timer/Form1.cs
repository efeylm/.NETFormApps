using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start(); 
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();

            if (sayac==30)
            {
                this.BackColor = Color.Yellow;
            }
            if (sayac==40)
            {
                this.BackColor = Color.Green;
            }
            if (sayac==70)
            {
                this.BackColor = Color.Red;
                sayac = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayac = 0;
            label1.Text = sayac.ToString();
            timer1.Stop();
        }
    }
}
//0-30 kırmızı 30_40 sarı 40 70 yeşil