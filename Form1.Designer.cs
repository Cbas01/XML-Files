namespace Ficheiros_XML
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.limparDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openfdProducts = new System.Windows.Forms.OpenFileDialog();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.lbOrderDetails = new System.Windows.Forms.ListBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.openfdOrders = new System.Windows.Forms.OpenFileDialog();
            this.savefdProducts = new System.Windows.Forms.SaveFileDialog();
            this.savefdOrders = new System.Windows.Forms.SaveFileDialog();
            this.cSVToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.openfdProdXML = new System.Windows.Forms.OpenFileDialog();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.limparDadosToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(590, 24);
            this.menu.TabIndex = 0;
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.ordersToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem2,
            this.xMLToolStripMenuItem2});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productsToolStripMenuItem.Text = "Products...";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem3,
            this.xMLToolStripMenuItem3});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ordersToolStripMenuItem.Text = "Orders...";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem2,
            this.ordersToolStripMenuItem2});
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.saveAsToolStripMenuItem.Text = "Save...";
            // 
            // productsToolStripMenuItem2
            // 
            this.productsToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.cSVToolStripMenuItem});
            this.productsToolStripMenuItem2.Name = "productsToolStripMenuItem2";
            this.productsToolStripMenuItem2.Size = new System.Drawing.Size(130, 22);
            this.productsToolStripMenuItem2.Text = "Products...";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.cSVToolStripMenuItem.Text = "CSV";
            // 
            // ordersToolStripMenuItem2
            // 
            this.ordersToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem1,
            this.cSVToolStripMenuItem1});
            this.ordersToolStripMenuItem2.Name = "ordersToolStripMenuItem2";
            this.ordersToolStripMenuItem2.Size = new System.Drawing.Size(130, 22);
            this.ordersToolStripMenuItem2.Text = "Orders...";
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.xMLToolStripMenuItem1.Text = "XML";
            this.xMLToolStripMenuItem1.Click += new System.EventHandler(this.xMLToolStripMenuItem1_Click);
            // 
            // cSVToolStripMenuItem1
            // 
            this.cSVToolStripMenuItem1.Name = "cSVToolStripMenuItem1";
            this.cSVToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.cSVToolStripMenuItem1.Text = "CSV";
            // 
            // limparDadosToolStripMenuItem
            // 
            this.limparDadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem1,
            this.ordersToolStripMenuItem1});
            this.limparDadosToolStripMenuItem.Name = "limparDadosToolStripMenuItem";
            this.limparDadosToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.limparDadosToolStripMenuItem.Text = "Limpar Dados...";
            // 
            // productsToolStripMenuItem1
            // 
            this.productsToolStripMenuItem1.Name = "productsToolStripMenuItem1";
            this.productsToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.productsToolStripMenuItem1.Text = "Products";
            this.productsToolStripMenuItem1.Click += new System.EventHandler(this.productsToolStripMenuItem1_Click);
            // 
            // ordersToolStripMenuItem1
            // 
            this.ordersToolStripMenuItem1.Name = "ordersToolStripMenuItem1";
            this.ordersToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.ordersToolStripMenuItem1.Text = "Orders";
            this.ordersToolStripMenuItem1.Click += new System.EventHandler(this.ordersToolStripMenuItem1_Click);
            // 
            // openfdProducts
            // 
            this.openfdProducts.Filter = "Products.csv|Products.csv";
            this.openfdProducts.InitialDirectory = "\"C:\\\\\"";
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.HorizontalScrollbar = true;
            this.lbProducts.Location = new System.Drawing.Point(12, 52);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(185, 290);
            this.lbProducts.TabIndex = 1;
            // 
            // lbOrders
            // 
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.HorizontalScrollbar = true;
            this.lbOrders.Location = new System.Drawing.Point(203, 52);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(185, 290);
            this.lbOrders.TabIndex = 2;
            // 
            // lbOrderDetails
            // 
            this.lbOrderDetails.FormattingEnabled = true;
            this.lbOrderDetails.HorizontalScrollbar = true;
            this.lbOrderDetails.Location = new System.Drawing.Point(394, 52);
            this.lbOrderDetails.Name = "lbOrderDetails";
            this.lbOrderDetails.Size = new System.Drawing.Size(185, 290);
            this.lbOrderDetails.TabIndex = 3;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(11, 36);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(49, 13);
            this.lblProducts.TabIndex = 4;
            this.lblProducts.Text = "Products";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(202, 36);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(33, 13);
            this.lblOrder.TabIndex = 5;
            this.lblOrder.Text = "Order";
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Location = new System.Drawing.Point(392, 36);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(68, 13);
            this.lblOrderDetails.TabIndex = 6;
            this.lblOrderDetails.Text = "Order Details";
            // 
            // openfdOrders
            // 
            this.openfdOrders.Filter = "Orders.csv |Orders.csv";
            // 
            // savefdProducts
            // 
            this.savefdProducts.DefaultExt = "xml";
            // 
            // savefdOrders
            // 
            this.savefdOrders.DefaultExt = "xml";
            // 
            // cSVToolStripMenuItem2
            // 
            this.cSVToolStripMenuItem2.Name = "cSVToolStripMenuItem2";
            this.cSVToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.cSVToolStripMenuItem2.Text = "CSV";
            this.cSVToolStripMenuItem2.Click += new System.EventHandler(this.cSVToolStripMenuItem2_Click);
            // 
            // xMLToolStripMenuItem2
            // 
            this.xMLToolStripMenuItem2.Name = "xMLToolStripMenuItem2";
            this.xMLToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.xMLToolStripMenuItem2.Text = "XML";
            this.xMLToolStripMenuItem2.Click += new System.EventHandler(this.xMLToolStripMenuItem2_Click);
            // 
            // cSVToolStripMenuItem3
            // 
            this.cSVToolStripMenuItem3.Name = "cSVToolStripMenuItem3";
            this.cSVToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.cSVToolStripMenuItem3.Text = "CSV";
            this.cSVToolStripMenuItem3.Click += new System.EventHandler(this.cSVToolStripMenuItem3_Click);
            // 
            // xMLToolStripMenuItem3
            // 
            this.xMLToolStripMenuItem3.Name = "xMLToolStripMenuItem3";
            this.xMLToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.xMLToolStripMenuItem3.Text = "XML";
            // 
            // openfdProdXML
            // 
            this.openfdProdXML.Filter = "Products.xml |Products.xml";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 353);
            this.Controls.Add(this.lblOrderDetails);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lbOrderDetails);
            this.Controls.Add(this.lbOrders);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openfdProducts;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.ListBox lbOrderDetails;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.ToolStripMenuItem limparDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openfdOrders;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem2;
        private System.Windows.Forms.SaveFileDialog savefdProducts;
        private System.Windows.Forms.SaveFileDialog savefdOrders;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem3;
        private System.Windows.Forms.OpenFileDialog openfdProdXML;
    }
}

