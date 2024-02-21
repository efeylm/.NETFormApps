using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Return_Metod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam(int s1,int s2)
        {
            int sum = s1 + s2;

            return sum;
        }
        int kup(int num)
        {
            int kup = num * num * num;
            return kup;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt16(textBox1.Text);
            
            label1.Text=kup(number).ToString();
//          label1.Text = toplam(2, 3).ToString();
        }


    }
}
