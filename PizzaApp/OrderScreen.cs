﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class OrderScreen : Form
    {
        public OrderScreen()
        {
            InitializeComponent();
        }

        private void BTNOrder_Click(object sender, EventArgs e)
        {
            Form Frm = new PizzaOptions();
            Frm.Show();
        }
    }
}
