using System;
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
            dataGridView1.DataSource = new ItemDB().Return_SelectAll();
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            int RItem_ID = Convert.ToInt32(txtritemid.Text);
            string R_Name = txtrname.Text;
            int R_qty = Convert.ToInt32(txtrqty.Text);

            // Get selected date and time from the DateTimePicker
            DateTime selectedDateTime = guna2DateTimePicker1.Value;

            // Assuming DealerID is a variable you want to use (adjust as needed)
            int DealerID = Convert.ToInt32(txtrname.Text); 

            new ItemDB().Return_Insert(RItem_ID, DealerID, R_qty, selectedDateTime);
        }



        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int RItem_ID = Convert.ToInt32(txtritemid.Text);
            new ItemDB().Return_Delete(RItem_ID);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void return_Load(object sender, EventArgs e)
        {

        }
    }
}
