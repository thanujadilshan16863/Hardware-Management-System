using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            string query = "select Name_I,Price_I,Quantity_I,Dealer_I from stock where Item_ID="+itemID;
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
        public void Dealer_Insert(int D_ID,int Item_ID,String Com_Name,String D_Name,int D_qty,Double D_Price)
        {
            MySqlConnection con = new Dbconnection().ConnectDB();
            string sql = "insert into dealer(Dealer_ID,Name_D,Item_ID,Company,Price_D,Quantity_D)values("+D_ID+","+D_Name+","+Item_ID+","+Com_Name+","+D_Price+","+D_qty+")";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }
        public void Dealer_Delete(int D_ID,int Item_ID)
        {
            //things to add..

            MySqlConnection con = new Dbconnection().ConnectDB();
            string sql = "delete from Dealer where Deealer_ID=" + D_ID;
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }
        public void Return_Insert(int RItem_ID,string R_Name,int R_qty)
        {
            //thing date automatic update...

            MySqlConnection con = new Dbconnection().ConnectDB();
            string sql = "insert into return(Item_ID,Dealer_ID,Quantity_R)values(" +RItem_ID+","+R_Name+","+R_qty+")";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }
            
        public void Return_Delete(int Item_ID)
        {
            MySqlConnection con = new Dbconnection().ConnectDB();
            string sql = "delete from return where Item_ID=" + Item_ID;
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
