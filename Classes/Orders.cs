using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheiros_XML
{
    class Orders
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }

        public Orders(string[] o)
        {
            OrderID = Convert.ToInt32(o[0]);
            OrderDate = Convert.ToDateTime(o[1]);
        }
    }
}
