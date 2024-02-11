using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_Management_System
{
    public class calculation
    {
        public double Customer_Total(int id, int qty, double dis_I, double dis)
        {
            double price = 0;double Tot_Each = 0;double Tot_Final;
                MySqlConnection con = new Dbconnection().ConnectDB();
                string query = "select Price_I from stock where Item_ID="+id;
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                store store = new store();
                if (rdr.Read())
                {
                     price = rdr.GetDouble("Price_I");
                }
                rdr.Close();
            
             Tot_Each= (price * qty)-(price*qty*dis_I);
             Tot_Final = (Tot_Each + Tot_Each)-((Tot_Each + Tot_Each)*dis);
            return Tot_Final;

            
        
        }
    }
}
