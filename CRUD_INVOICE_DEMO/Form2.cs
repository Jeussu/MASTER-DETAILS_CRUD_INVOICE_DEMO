using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_INVOICE_DEMO
{
    public partial class Form2 : Form
    {
        SalesInvoice SalesInvoiceModel = new SalesInvoice();
        InvoiceItem InvoiceItemModel = new InvoiceItem();
        DataTable table = new DataTable("table");
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saleInvoiceDataSet1.InvoiceItems' table. You can move, or remove it, as needed.
            this.invoiceItemsTableAdapter.Fill(this.saleInvoiceDataSet1.InvoiceItems);
            // TODO: This line of code loads data into the 'saleInvoiceDataSet1.SalesInvoices' table. You can move, or remove it, as needed.
            this.salesInvoicesTableAdapter.Fill(this.saleInvoiceDataSet1.SalesInvoices);
            // TODO: This line of code loads data into the 'saleInvoiceDataSet1.InvoiceItems' table. You can move, or remove it, as needed.
            this.invoiceItemsTableAdapter.Fill(this.saleInvoiceDataSet1.InvoiceItems);
            // TODO: This line of code loads data into the 'saleInvoiceDataSet1.SalesInvoices' table. You can move, or remove it, as needed.
            this.salesInvoicesTableAdapter.Fill(this.saleInvoiceDataSet1.SalesInvoices);
            // TODO: This line of code loads data into the 'saleInvoiceDataSet1.InvoiceItems' table. You can move, or remove it, as needed.
            this.invoiceItemsTableAdapter.Fill(this.saleInvoiceDataSet1.InvoiceItems);
            // TODO: This line of code loads data into the 'saleInvoiceDataSet1.SalesInvoices' table. You can move, or remove it, as needed.
            this.salesInvoicesTableAdapter.Fill(this.saleInvoiceDataSet1.SalesInvoices);


            
            // TODO: This line of code loads data into the 'saleInvoiceDataSet1.InvoiceItems' table. You can move, or remove it, as needed.
            this.invoiceItemsTableAdapter.Fill(this.saleInvoiceDataSet1.InvoiceItems);
            
        }
        private void SearchSalesInvoices(string searchQuery)
        {
            // Example: Filtering SalesInvoices based on CustomerName
            var filteredSalesInvoices = from invoice in saleInvoiceDataSet1.SalesInvoices
                                        where invoice.CustomerName.Contains(searchQuery)
                                        select invoice;

            // Bind the result to gridControl1
            gridControl1.DataSource = filteredSalesInvoices.ToList();
        }

        private void PopulateInvoiceItems(int invoiceNumber)
        {
            var invoiceItems = from item in saleInvoiceDataSet1.InvoiceItems
                               where item.InvoiceNumber == invoiceNumber
                               select item;

            gridControl2.DataSource = invoiceItems.ToList();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void cmbcolumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                SearchSalesInvoices(txtSearch.Text);
            }
            else
            {
                gridControl1.DataSource = null;
                gridControl2.DataSource = null;
            }
        }

        private void txtSearch_KeyDown2(object sender, KeyEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            //form1.ShowDialog();
        }

        private void txtSearch1_TextChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtSearch.Text))
            //{
            //    SearchInvoiceItems(txtSearch.Text);
            //}
            //else
            //{
            //    Optionally, reset the grid or handle empty search query
            //}
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            
            var gridView = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (gridView != null && gridView.FocusedRowHandle >= 0)
            {
                object row = gridView.GetRow(gridView.FocusedRowHandle);
                if (row is DataRowView dataRowView)
                {
                    // Assuming the column name is "InvoiceNumber" and it's of type int
                    int invoiceNumber = Convert.ToInt32(dataRowView["InvoiceNumber"]);
                    PopulateInvoiceItems(invoiceNumber);
                }
            }
        }

        
        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
        //private int GetCurrentInvoiceNumber()
        //{
        //    // Assuming gridControl1's main view is GridView
        //    var gridView = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

        //    if (gridView != null && gridView.FocusedRowHandle >= 0)
        //    {
        //        object row = gridView.GetRow(gridView.FocusedRowHandle);
        //        if (row is DataRowView dataRowView)
        //        {
        //            // Assuming the column name is "InvoiceNumber" and it's of type int
        //            return Convert.ToInt32(dataRowView["InvoiceNumber"]);
        //        }
        //    }

        //    // Return a default value or handle the case when no row is selected
        //    return -1; // -1 or any other value that indicates no selection
        //}
        //private void DeleteInvoiceItem(int itemID)
        //{
        //    // Find the row with the given ItemID
        //    var rows = saleInvoiceDataSet1.InvoiceItems.Select($"ItemID = {itemID}");
        //    if (rows.Length > 0)
        //    {
        //        // Remove the found row
        //        saleInvoiceDataSet1.InvoiceItems.Rows.Remove(rows[0]);

        //        // Optionally, update the database here if you're using a database

        //        // Refresh gridControl2 to reflect the deletion
        //        int currentInvoiceNumber = GetCurrentInvoiceNumber(); // Implement this method
        //        PopulateInvoiceItems(currentInvoiceNumber);
        //    }
        //}
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
