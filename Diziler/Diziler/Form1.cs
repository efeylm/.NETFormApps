﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //string[] kisiler = {"Efe","Ece","Ali","Ahmet","Mehmet","Fatih","Hikmet"};
        //int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string[] sehirler = {"Ankara","İzmir","İstanbul","Bursa","Adana","Yozgat"};
            for (int i = 0; i < sehirler.Length; i++)
            {
                listBox1.Items.Add(sehirler[i]);
            }




            //if (i<kisiler.Length)
            //{            
            //    label1.Text=kisiler[i];
            //    i++;
            //}
            
        }
    }
}
