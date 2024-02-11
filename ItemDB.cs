using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_Management_System
{
    public class ItemDB
    {
        public DataTable Store_SelectAll()
        {
            MySqlConnection con = new Dbconnection().ConnectDB();
            string query = "select*from store";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rdr);
            return table;
        }

        public store findbyitemID(string itemID)
        {
            MySqlConnection con = new Dbconnection().ConnectDB();
            string query = "select Name_I,Price_I,Quantity_I,Dealer_I from stock where Item_ID='" + itemID + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            store store = new store();
            while (rdr.Read())
            {
                store.Name=rdr.GetString("Name_I");              
            }
            return store;
        }
        public DataTable Customer_SelectAll()
        {
            MySqlConnection con = new Dbconnection().ConnectDB();
            string query = "select*from bill";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rdr);
            return table;
        }
        public DataTable Dealer_SelectAll()
        {
            MySqlConnection con = new Dbconnection().ConnectDB();
            string query = "select*from dealer";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rdr);
            return table;
        }
        public void Customer_Insert(string name, int id, int qty, double dis_I, double dis,double Tot_Each)
        {
            MySqlConnection con = new Dbconnection().ConnectDB();
            string sql = "insert into bill(Name_I,Item_ID,Quantity_B,Discount_I,Discount,Total)values('"+name+"',"+id+","+qty+","+dis_I+","+dis+","+Tot_Each+")";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }
        public void Customer_Delete(int id)
        {
            MySqlConnection con = new Dbconnection().ConnectDB();
            string sql = "delete from bill where Item_ID=" + id;
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
