using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_INVOICE_DEMO
{
    public partial class Form3 : Form
    {
        SalesInvoice SalesInvoiceModel = new SalesInvoice();
        InvoiceItem InvoiceItemModel = new InvoiceItem();
        DataTable table = new DataTable("table");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saleInvoiceDataSet1.InvoiceItems' table. You can move, or remove it, as needed.
            //this.invoiceItemsTableAdapter.Fill(this.saleInvoiceDataSet1.InvoiceItems);


        }



    }
}

