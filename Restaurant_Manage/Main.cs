﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Manage
{
    public partial class Main: Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order or = new Order();
            or.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Food fd = new Food();
            fd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            p.Show();
        }
    }
}
