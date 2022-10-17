using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Ficheiros_XML
{
    public partial class Form1 : Form
    {
        ColecProducts colecProds = Program.colecProd;
        ColecOrders colecOrders = Program.colecOrder;
        ColecOD colecOD = Program.colecOD;
        public Form1()
        {
            InitializeComponent();
        }

        #region limpar dados
        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lbProducts.Items.Count != 0)
            {
                if (MessageBox.Show("Tem a certeza que quer apagar os dados?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lbProducts.Items.Clear();
                    colecProds.Clear();
                }
            }
            else
                MessageBox.Show("Não existem dados carregados.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ordersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lbOrders.Items.Count != 0 && lbOrderDetails.Items.Count != 0)
            {
                if (MessageBox.Show("Tem a certeza que quer apagar os dados?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    colecOD.Clear();
                    colecOrders.Clear();
                    lbOrderDetails.Items.Clear();
                    lbOrders.Items.Clear();
                }
            }
            else
                MessageBox.Show("Não existem dados carregados.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
#endregion

        #region open orders csv

        private void cSVToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (lbOrders.Items.Count != 0)
            {
                MessageBox.Show("Já existe um ficheiro carregado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                openfdOrders.ShowDialog();
                if (openfdOrders.FileName == "")
                    return;
                else
                {
                    StreamReader OrderStream = new StreamReader(openfdOrders.FileName);
                    OrderStream.ReadLine();
                    while (OrderStream.EndOfStream == false)
                    {
                        string line = OrderStream.ReadLine();
                        lbOrders.Items.Add(line);
                        string[] splitline = line.Split(';');
                        Orders order = new Orders(splitline);
                        colecOrders.Adicionar(order);
                    }
                    FileInfo dir = new FileInfo(openfdOrders.FileName);
                    FileInfo[] files = dir.Directory.GetFiles();
                    foreach (FileInfo f in files)
                    {
                        if (f.Name == "OrderDetails.csv")
                        {
                            string od = f.FullName;
                            StreamReader ODStream = new StreamReader(od);
                            ODStream.ReadLine();
                            while (ODStream.EndOfStream == false)
                            {
                                string line = ODStream.ReadLine();
                                lbOrderDetails.Items.Add(line);
                                string[] splitline = line.Split(';');
                                OrderDetails ordeta = new OrderDetails(splitline);
                                colecOD.Adicionar(ordeta);
                            }
                            return;
                        }
                    }
                    MessageBox.Show("Está em falta o ficheiro OrderDetails", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    colecOrders.Clear();
                    lbOrders.Items.Clear();

                }
            }
        }
        #endregion

        #region open products csv
        private void cSVToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (lbProducts.Items.Count != 0)
            {
                MessageBox.Show("Já existe um ficheiro carregado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                openfdProducts.ShowDialog();
                if (openfdProducts.FileName == "")
                    return;
                else
                {
                    StreamReader ProdStream = new StreamReader(openfdProducts.FileName);
                    ProdStream.ReadLine();
                    while (ProdStream.EndOfStream == false)
                    {
                        string line = ProdStream.ReadLine();
                        lbProducts.Items.Add(line);
                        string[] splitline = line.Split(';');
                        Products prod = new Products(splitline);
                        colecProds.Adicionar(prod);
                    }
                }
            }
        }
#endregion

        #region save products xml
        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbProducts.Items.Count == 0)
            {
                MessageBox.Show("Não existem dados carregados.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                savefdProducts.ShowDialog();
                if (savefdProducts.FileName == "")
                {
                    return;
                }
                else
                {
                    if (savefdProducts.FileName.EndsWith("Products.xml") == false)
                    {
                        MessageBox.Show("O nome tem de ser Products.xml", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        XmlWriterSettings xmlwset = new XmlWriterSettings();
                        xmlwset.Indent = true;
                        xmlwset.IndentChars = "  ";
                        XmlWriter xmlw = XmlWriter.Create(savefdProducts.FileName, xmlwset);
                        xmlw.WriteStartDocument();
                        xmlw.WriteStartElement("Products");
                        for (int i = 0; i < colecProds.Count; i++)
                        {
                            xmlw.WriteStartElement("Product");
                            xmlw.WriteElementString("ProductID", colecProds[i].ProductID.ToString());
                            xmlw.WriteElementString("ProductName", colecProds[i].ProductName);
                            xmlw.WriteElementString("UnitPrice", colecProds[i].UnitPrice.ToString());
                            xmlw.WriteElementString("UnitsInStock", colecProds[i].UnitsInStock.ToString());
                            xmlw.WriteElementString("Discontinued", colecProds[i].Discontinued.ToString());
                            xmlw.WriteEndElement();
                        }
                        xmlw.WriteEndElement();
                        xmlw.Close();

                    }
                }
            }
        }
#endregion

        #region save orders xml
        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lbOrders.Items.Count == 0)
            {
                MessageBox.Show("Não existem dados carregados.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                savefdOrders.ShowDialog();
                if (savefdOrders.FileName == "")
                {
                    return;
                }
                else
                {
                    if (savefdOrders.FileName.EndsWith("Orders.xml") == false)
                    {
                        MessageBox.Show("O nome tem de ser Orders.xml", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        XmlWriterSettings xmlwset = new XmlWriterSettings();
                        xmlwset.Indent = true;
                        xmlwset.IndentChars = "  ";
                        XmlWriter xmlw = XmlWriter.Create(savefdOrders.FileName, xmlwset);
                        xmlw.WriteStartDocument();
                        xmlw.WriteStartElement("Orders");
                        for (int i = 0; i < colecOrders.Count; i++)
                        {
                            xmlw.WriteStartElement("Order");
                            xmlw.WriteElementString("OrderID", colecOrders[i].OrderID.ToString());
                            xmlw.WriteElementString("OrderDate", colecOrders[i].OrderDate.ToString());
                            xmlw.WriteEndElement();
                        }
                        xmlw.WriteEndElement();
                        xmlw.Close();

                        FileInfo dir = new FileInfo(savefdOrders.FileName);
                        XmlWriterSettings xmlwset2 = new XmlWriterSettings();
                        xmlwset2.Indent = true;
                        xmlwset2.IndentChars = "  ";
                        XmlWriter xmlw2 = XmlWriter.Create(dir.Directory + @"\OrderDetails.xml", xmlwset2);
                        xmlw2.WriteStartDocument();
                        xmlw2.WriteStartElement("Orders");
                        for (int i = 0; i < colecOD.Count; i++)
                        {
                            xmlw2.WriteStartElement("Order");
                            xmlw2.WriteElementString("OrderID", colecOD[i].OrderID.ToString());
                            xmlw2.WriteElementString("ProductID", colecOD[i].ProductID.ToString());
                            xmlw2.WriteElementString("Quantity", colecOD[i].Quantity.ToString());
                            xmlw2.WriteElementString("Discount", colecOD[i].Discount.ToString());
                            xmlw2.WriteEndElement();
                        }
                        xmlw2.WriteEndElement();
                        xmlw2.Close();
                    }
                }
            }
        }
#endregion

        #region open products xml
        private void xMLToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (lbProducts.Items.Count != 0)
            {
                MessageBox.Show("Já existe um ficheiro carregado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                openfdProdXML.ShowDialog();
                if (openfdProdXML.FileName == "")
                    return;
                else
                {
                    XmlReaderSettings xmlset = new XmlReaderSettings();
                    xmlset.IgnoreComments = true;
                    xmlset.IgnoreWhitespace = true;
                    XmlReader xmlr = XmlReader.Create(openfdProdXML.FileName, xmlset);

                }
            }
        }
        #endregion
    }
}
