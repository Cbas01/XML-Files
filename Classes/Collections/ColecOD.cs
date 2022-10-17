using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheiros_XML
{
    class ColecOD : Collection<OrderDetails>
    {
        public void Adicionar(OrderDetails o)
        {
            base.Add(o);
        }
    }
}
