﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_Management_System
{
    public partial class @return : Form
    {
        public @return()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            dealer dealerForm = new dealer();
            dealerForm.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            store storeForm = new store();
            storeForm.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            customer customerForm = new customer();
            customerForm.Show();
            this.Hide();
        }
    }
}
