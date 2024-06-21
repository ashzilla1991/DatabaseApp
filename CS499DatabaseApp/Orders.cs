using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS499DatabaseApp
{
    //class for order details
    internal class Orders
    { 
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public String SKU { get; set; }
        public String Description { get; set; }
    }
}
