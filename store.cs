using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
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

    public partial class store : Form
    {
     
        public store()
        {
            InitializeComponent();
            dataGridView1.DataSource = new ItemDB().Store_SelectAll();
          
        }

        private void store_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string search_itemID = guna2TextBox2.Text;
            store store= new ItemDB().findbyitemID(search_itemID);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            customer customerForm = new customer();
            customerForm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            dealer dealerForm= new dealer();
            dealerForm.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            @return rtn=new @return();
            rtn.Show();
            this.Hide();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
