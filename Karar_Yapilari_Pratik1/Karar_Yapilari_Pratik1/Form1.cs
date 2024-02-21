using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapilari_Pratik1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapadet;
            double toplam=0;
            kitapadet = Convert.ToInt16(textBox1.Text);
            if (kitapadet>=0 && kitapadet <=20)
            {
                toplam = (kitapadet * 8) * 0.8;
            }
            else if (kitapadet>=21 && kitapadet<=40)
            {
                toplam = (kitapadet * 8) * 0.6;

            }
            else if(kitapadet>=41)
            {
                toplam = (kitapadet * 8) * 0.5;
            }
            textBox2.Text = toplam.ToString();

        }
    }
}

//0-20 %20
//21-40 %40
//41+ %50
//Kitap 8 tl