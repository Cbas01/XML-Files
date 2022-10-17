using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheiros_XML
{
    class OrderDetails
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }

        public OrderDetails(string[] o)
        {
            OrderID = Convert.ToInt32(o[0]);
            ProductID = Convert.ToInt32(o[1]);
            Quantity = Convert.ToInt32(o[2]);
            Discount = Convert.ToDecimal(o[3]);
        }
    }
}
