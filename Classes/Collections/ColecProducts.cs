using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheiros_XML
{
    class ColecProducts : Collection<Products>
    {
        public void Adicionar(Products p)
        {
            base.Add(p);
        }
    }
}
