﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B10523025_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.FormClosed += new FormClosedEventHandler(showform1);
            f1.Show();
            this.Hide();
        }
        void showform1(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.FormClosed += new FormClosedEventHandler(showform1);
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.FormClosed += new FormClosedEventHandler(showform1);
            f1.Show();
            this.Hide();
        }
    }
}
