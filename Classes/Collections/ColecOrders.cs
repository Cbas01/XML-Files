using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheiros_XML
{
    class ColecOrders : Collection<Orders>
    {
        public void Adicionar(Orders o)
        {
            base.Add(o);
        }
    }
}
