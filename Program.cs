using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficheiros_XML
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static ColecProducts colecProd = new ColecProducts();
        public static ColecOrders colecOrder = new ColecOrders();
        public static ColecOD colecOD = new ColecOD();
    }
}
