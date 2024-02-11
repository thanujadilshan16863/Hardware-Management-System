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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
            dataGridView1.DataSource = new ItemDB().Customer_SelectAll();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginForm = new login();
            loginForm.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            store storeForm = new store();
            storeForm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            dealer dealerForm = new dealer();
            dealerForm.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string name=txtname.Text;
            int id=Convert.ToInt32(txtid.Text);
            int qty=Convert.ToInt32(txtqty.Text);
            double dis_I = Convert.ToDouble(txtdis_I.Text);
            double dis=Convert.ToDouble(txtdis.Text);
            double Tot_Each = Convert.ToDouble(Tot_Each);
        
            new ItemDB().Customer_Insert(name,id,qty,dis_I,dis,Tot_Each);

            txtname.Clear();txtid.Clear();txtqty.Clear();txtdis_I.Clear();txtdis.Clear();

            
        }

        private void customer_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            new ItemDB().Customer_Delete(id);
            
            txtid.Clear();
        }
    }
}
