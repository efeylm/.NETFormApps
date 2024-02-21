using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int saat=0,dakika=58,saniye=58;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label1.Text = saniye.ToString();
            if (saniye==60)
            {
                dakika++;
                label2.Text = dakika.ToString();    
                saniye=0;
                if (dakika==60)
                {
                    dakika=0;
                    label2.Text = dakika.ToString();
                    saat++;
                    label3.Text = saat.ToString();
                }
            }
        }
    }
}
