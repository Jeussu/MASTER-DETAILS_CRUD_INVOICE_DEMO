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
            
            // TODO: This line of code loads data into the 'saleInvoiceDataSet1.SalesInvoices' table. You can move, or remove it, as needed.
            this.salesInvoicesTableAdapter.Fill(this.saleInvoiceDataSet1.SalesInvoices);
            // TODO: This line of code loads data into the 'saleInvoiceDataSet1.InvoiceItems' table. You can move, or remove it, as needed.
            //this.invoiceItemsTableAdapter.Fill(this.saleInvoiceDataSet1.InvoiceItems);


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Get the currently selected row in the GridView
            int selectedRowHandle = gridView1.FocusedRowHandle;

            // Check if a row is selected
            if (selectedRowHandle >= 0)
            {
                // Prompt the user for confirmation
                if (XtraMessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Delete the selected row from the DataTable
                    table.Rows.RemoveAt(selectedRowHandle);
                }
            }
            else
            {
                // If no row is selected, show a message to the user
                XtraMessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

