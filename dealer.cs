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
    public partial class dealer : Form
    {
        public dealer()
        {
            InitializeComponent();
            dataGridView1.DataSource = new ItemDB().Dealer_SelectAll();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            store storeForm = new store();
            storeForm.Show();
            storeForm.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            customer customerForm = new customer();
            customerForm.Show();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            @return retunForm=new @return();
            retunForm.Show();
            this.Close();
        }

        private void dealer_Load(object sender, EventArgs e)
        {

        }
    }
}
