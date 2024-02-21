using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Gray;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje efeyalım tarafından yapıldı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void mADMAXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webControl1.WebView.Url="https://www.youtube.com/watch?v=hEJnMQG9ev8&ab_channel=WarnerBros.Pictures";

            label1.Text = "MAD MAX";
        }



        private void tFIOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webControl1.WebView.Url = "https://www.youtube.com/watch?v=9ItBvH5J6ss&ab_channel=20thCenturyStudios";
            label1.Text = "TFIOS";

        }

        private void görevimizTehToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webControl1.WebView.Url = "https://www.youtube.com/watch?v=65bU2CLkRQ4&ab_channel=BoxOfficeT%C3%BCrkiye";
            label1.Text = "GOREVİMİZ TEHLİKE";
        }
    }
}
