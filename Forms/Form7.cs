﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sun21_p
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            f.ShowDialog();
            this.Close ();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 f = new Form12();
            f.ShowDialog();
            this.Close ();
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            Form14 f = new Form14();
            f.ShowDialog();
            this.Close();
           
        }
    }
}
