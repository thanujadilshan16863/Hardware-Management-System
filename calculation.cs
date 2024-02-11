using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_Management_System
{
    public class calculation
    {
        public void Total(int qty, double dis_I, double dis)
        {
            double Tot_Each= (Price_I * qty)-(Price_I*qty*dis_I);
            double Tot_Final = Tot_Each++;
        
        }
    }
}
