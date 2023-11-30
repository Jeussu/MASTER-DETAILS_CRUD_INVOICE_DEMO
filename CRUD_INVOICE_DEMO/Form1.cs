using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CRUD_INVOICE_DEMO
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        SalesInvoice SalesInvoiceModel = new SalesInvoice();
        InvoiceItem InvoiceItemModel = new InvoiceItem();
        DataTable table = new DataTable("table");

        public Form1()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            using (SaleInvoiceEntities saleInvoice = new SaleInvoiceEntities())
            {
                var data = saleInvoice.SalesInvoices.ToList();
                // Bind the data to the grid control
                gridControl1.DataSource = data;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("InvoiceNumber", Type.GetType("System.String"));
            table.Columns.Add("CustomerID", Type.GetType("System.Int32"));
            table.Columns.Add("InVoiceDate", Type.GetType("System.String"));
            table.Columns.Add("CustomerName", Type.GetType("System.String"));
            table.Columns.Add("Address", Type.GetType("System.String"));
            table.Columns.Add("InvoiceID", Type.GetType("System.Int32"));
            table.Columns.Add("ProductID", Type.GetType("System.Int32"));
            table.Columns.Add("Quantity", Type.GetType("System.Int32"));
            table.Columns.Add("UnitPrice", Type.GetType("System.Int32"));
            table.Columns.Add("ProductName", Type.GetType("System.String"));
            table.Columns.Add("IntoMoney", Type.GetType("System.Int32"));
            table.Columns.Add("TotalMoney", Type.GetType("System.Int32"));

            gridControl1.DataSource = table;
            //LoadData();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            table.Rows.Add(spin_invoiceNumber.Text, spin_customerID.Value, date_date.Value, txt_name.Text,
            text_address.Text, spin_ID.Value, spin_productID.Value, spin_quantity.Value, spin_unitprice.Value,
            txt_productname.Text, spin_intomoney.Value, spin_totalmoney.Value);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SalesInvoiceModel = new SalesInvoice();
            SaleInvoiceEntities saleInvoice = new SaleInvoiceEntities();
            SalesInvoiceModel.InvoiceNumber = Convert.ToInt32(spin_invoiceNumber.Text);
            SalesInvoiceModel.CustomerID = Convert.ToInt32(spin_customerID.Text);
            SalesInvoiceModel.InVoiceDate = Convert.ToDateTime(date_date.Value);
            SalesInvoiceModel.CustomerName = txt_name.Text;
            SalesInvoiceModel.Address = text_address.Text;
            foreach (DataRow row in table.Rows)
            {

                InvoiceItemModel = new InvoiceItem();





                InvoiceItemModel.InvoiceNumber = SalesInvoiceModel.InvoiceNumber;
                InvoiceItemModel.ProductID = Convert.ToInt32(row["ProductID"]);
                InvoiceItemModel.Quantity = Convert.ToInt32(row["Quantity"]);
                InvoiceItemModel.UnitPrice = Convert.ToDecimal(row["UnitPrice"]);
                InvoiceItemModel.ProductName = row["ProductName"].ToString();
                InvoiceItemModel.IntoMoney = Convert.ToDecimal(row["IntoMoney"]);
                InvoiceItemModel.ToTalMoney = Convert.ToDecimal(row["TotalMoney"]);


                saleInvoice.InvoiceItems.Add(InvoiceItemModel);
            }
            // gan 3 lan chay 3 lần thì sẽ trùng key
            saleInvoice.SalesInvoices.Add(SalesInvoiceModel);

            saleInvoice.SaveChanges();
        }





        private void spin_invoiceNumber_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void spin_customerID_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            //LoadData();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
