using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS499DatabaseApp
{
    //class for customer details
    internal class Customers
    {
        public int CustomerID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String StreetAddress { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public int ZipCode { get; set; }
        public String Telephone { get; set; }
    }
}
