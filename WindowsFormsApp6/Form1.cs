﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hell Saman this me Ahmed");
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            lbl.Text = "This is a test, saman, so if it works that mean we are working right.";
        }
    }
}
