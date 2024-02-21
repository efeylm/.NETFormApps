using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = {7,8,16,4,14,15,25,23,17,50,40,44,52};
            int counter = 0;

            foreach (int k in sayilar)
            {
                if (k%4==0 && k>10)
                {
                    listBox1.Items.Add(k);
                    counter++;
                }
                label1.Text = counter.ToString();

            }
        }
    }
}
