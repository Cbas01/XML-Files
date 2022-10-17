using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheiros_XML
{
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int Discontinued { get; set; }

        public Products(string[] s)
        {
            ProductID = Convert.ToInt32(s[0]);
            ProductName = s[1];
            UnitPrice = Convert.ToDecimal(s[2]);
            UnitsInStock = Convert.ToInt32(s[3]);
            Discontinued = Convert.ToInt32(s[4]);
        }
    }
}
