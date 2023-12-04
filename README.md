# CRUD_INVOICE_DEMO
-	Khi chạy even nên cho vào try-catch
-	Validate cho ID khi bị trùng
-	Dùng validate khi detail empty
-	Sau khi thêm xong  data phải được load ở form search
-	Không cho client được sửa UI khi chưa update vào DB
-	Search invoiceNumber theo Master từ đó hiện ra details chứa trong Master.
-	From search: search dữ liệu từ master-details
-	Update: thêm, xoá master-details theo Invoice để sửa 
-	Tìm theo keyword: databidingsource 

 
-	Thêm nút add
-	Ném dữ liệu nhập vào grid view
-	Tìm hiểu class object
-	List – 
-	Nhập data và hiển thị dữ liệu
1.	Tìm hiểu : làm sao để tạo class object
2.	Làm sao để sinh ra được list<object>
3.	Add được dữ liệu vào list 
4.	Xử lý phần tử trong grid view(CRUD)
đầu tiên anh vào sẽ nhập liệu mã khách hàng, tên khách hàng, ngày xuất...=> thêm mới danh sách sản phẩm mà anh cần tạo hóa đơn=> lưu
-	invoiceID -> InvoiceNumber, bỏ tự tăng invoiceID ở bảng saleinvoice -> nhập tay

 
 
 
 

-	Sales invoice: Hoá đơn bán hàng
+ Insert value for SalesInvoices table and InvoiceItems table
+ Add more NameItem entity to InvoiceItems Table and insert value again
1. **SalesInvoices table (Master):**
   - InvoiceID (Primary Key)
   - InvoiceNumber
   - CustomerID
   - InvoiceDate
   - ...

2. **InvoiceItems table (Detail):**
   - ItemID (Primary Key)
   - InvoiceID (Foreign Key referencing SalesInvoices.InvoiceID)
   - ProductID
   - Quantity
   - UnitPrice
   - ...
private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaleInvoiceEntities saleInvoice = new SaleInvoiceEntities();

            foreach (DataRow row in table.Rows)
            {
                SalesInvoiceModel = new SalesInvoice();
                InvoiceItemModel = new InvoiceItem();

                // Populate SalesInvoiceModel
                SalesInvoiceModel.InvoiceNumber = Convert.ToInt32(row["InvoiceNumber"]);
                SalesInvoiceModel.CustomerID = Convert.ToInt32(row["CustomerID"]);
                SalesInvoiceModel.InVoiceDate = Convert.ToDateTime(row["InVoiceDate"]);
                SalesInvoiceModel.CustomerName = row["CustomerName"].ToString();
                SalesInvoiceModel.Address = row["Address"].ToString();

                // Populate InvoiceItemModel
                InvoiceItemModel.InvoiceNumber = SalesInvoiceModel.InvoiceNumber;
                InvoiceItemModel.ProductID = Convert.ToInt32(row["ProductID"]);
                InvoiceItemModel.Quantity = Convert.ToInt32(row["Quantity"]);
                InvoiceItemModel.UnitPrice = Convert.ToDecimal(row["UnitPrice"]);
                InvoiceItemModel.ProductName = row["ProductName"].ToString();
                InvoiceItemModel.IntoMoney = Convert.ToDecimal(row["IntoMoney"]);
                InvoiceItemModel.ToTalMoney = Convert.ToDecimal(row["TotalMoney"]);

                // Add to context
                saleInvoice.SalesInvoices.Add(SalesInvoiceModel);
                saleInvoice.InvoiceItems.Add(InvoiceItemModel);
            }

            saleInvoice.SaveChanges();
        }
CREATE TABLE SalesInvoices (
	InvoiceID INT PRIMARY KEY,
	InvoiceNumber VARCHAR(20),
	CustomerID INT,
	InVoiceDate DATE
CustomerName NVARCHAR (255) NOT NULL;
Address VARCHAR(255) NOT NULL;

	);

CREATE TABLE InvoiceItems (
    ItemID INT PRIMARY KEY,
    InvoiceID INT,
    ProductID INT,
    Quantity INT,
    UnitPrice DECIMAL(10, 2),
    ProductName VARCHAR(255) NOT NULL;
    IntoMoney DECIMAL(10, 2);
    ToTalMoney DECIMAL(10, 2);
    FOREIGN KEY (InvoiceID) REFERENCES SalesInvoices(InvoiceID)
);

ALTER TABLE SalesInvoices

ADD CustomerName NVARCHAR (255) NOT NULL;

ALTER TABLE SalesInvoices

ADD Address VARCHAR(255) NOT NULL;

ALTER TABLE InvoiceItems

ADD ProductName VARCHAR(255) NOT NULL;

ALTER TABLE InvoiceItems

ADD IntoMoney DECIMAL(10, 2);

ALTER TABLE InvoiceItems

ADD ToTalMoney DECIMAL(10, 2);

Personid int IDENTITY(1,1) PRIMARY KEY,


using DevExpress.Utils.About;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VBSQLHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
                table.Rows.Add(spin_invoiceNumber.Text, spin_customerID.Value, date_date.Value, txt_name.Text,
                text_address.Text, spin_ID.Value, spin_productID.Value, spin_quantity.Value, spin_unitprice.Value,
                txt_productname.Text, spin_intomoney.Value, spin_totalmoney.Value);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            SaleInvoiceEntities saleInvoice = new SaleInvoiceEntities();
            //InvoiceItem invoiceItem = new InvoiceItem();



            SalesInvoiceModel.InvoiceNumber =Convert.ToInt32(spin_invoiceNumber.Text);
            SalesInvoiceModel.CustomerID = Convert.ToInt32(spin_customerID.Value); // convert to int
            SalesInvoiceModel.InVoiceDate = date_date.Value;
            SalesInvoiceModel.CustomerName = txt_name.Text;
            SalesInvoiceModel.Address = text_address.Text;
            InvoiceItemModel.InvoiceNumber = SalesInvoiceModel.InvoiceNumber;
            InvoiceItemModel.ProductID = Convert.ToInt32(spin_productID.Value);
            InvoiceItemModel.Quantity = Convert.ToInt32(spin_quantity.Value);
            InvoiceItemModel.UnitPrice = spin_unitprice.Value;
            InvoiceItemModel.ProductName = txt_productname.Text;
            InvoiceItemModel.IntoMoney = spin_intomoney.Value;
            InvoiceItemModel.ToTalMoney = spin_totalmoney.Value;
            saleInvoice.SalesInvoices.Add(SalesInvoiceModel);
            //thu dung vong lap foreach {} cho details(), InvoiceItems dang list
            saleInvoice.InvoiceItems.Add(InvoiceItemModel);
            
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

        }
    }
}  - I want insert all records from data gridview entry to SQL database
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;

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
            LoadData();
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
            LoadData();
        }
        

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (SaleInvoiceEntities saleInvoice = new SaleInvoiceEntities())
            {
                int invoiceNumberToDelete = Convert.ToInt32(spin_invoiceNumber.Text);
                int productIDToDelete = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ProductID"));

                // Find the sales invoice in the database
                SalesInvoiceModel = saleInvoice.SalesInvoices
                    .Include("InvoiceItems")  // Assuming there's a navigation property named "InvoiceItems"
                    .FirstOrDefault(s => s.InvoiceNumber == invoiceNumberToDelete);

                if (SalesInvoiceModel != null)
                {
                    // Find the specific InvoiceItemModel to delete
                    InvoiceItemModel = SalesInvoiceModel.InvoiceItems
                        .FirstOrDefault(item => item.ProductID == productIDToDelete);

                    if (InvoiceItemModel != null)
                    {
                        // Remove the specific InvoiceItemModel
                        saleInvoice.InvoiceItems.Remove(InvoiceItemModel);

                        saleInvoice.SaveChanges();
                    }
                }
            }
            gridControl1.DataSource = table;

        }

    }
}




+ 
private void BtnDelete_Click(object sender, EventArgs e)
        {
            //Xoá data ở grid, không tác động đến DB

            using (SaleInvoiceEntities saleInvoice = new SaleInvoiceEntities())
            {
                int invoiceNumberToDelete = Convert.ToInt32(spin_invoiceNumber.Text);
                int productIDToDelete = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ProductID"));

                // Find the sales invoice in the database
                SalesInvoiceModel = saleInvoice.SalesInvoices
                    .Include("InvoiceItems")  // Assuming there's a navigation property named "InvoiceItems"
                    .FirstOrDefault(s => s.InvoiceNumber == invoiceNumberToDelete);

                
                if (SalesInvoiceModel != null)
                {
                    // Find the specific InvoiceItemModel to delete
                    InvoiceItemModel = SalesInvoiceModel.InvoiceItems
                        .FirstOrDefault(item => item.ProductID == productIDToDelete);

                    if (InvoiceItemModel != null)
                    {
                        if (XtraMessageBox.Show($"Are you sure want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            // Remove the specific InvoiceItemModel
                            saleInvoice.InvoiceItems.Remove(InvoiceItemModel);
                        // gán data grid = InvoiceItem
                        saleInvoice.SaveChanges();
                    }
                }
                

                //LoadData();
            }

        }



The error message you are seeing, "CS1061 'DataGridView' does not contain a definition for 'GetFocusedRowCellValue' and no accessible extension method 'GetFocusedRowCellValue' accepting a first argument of type 'DataGridView' could be found," suggests that the DataGridView control does not have a method called 'GetFocusedRowCellValue'.

In Windows Forms, DataGridView does not have a built-in method called 'GetFocusedRowCellValue' like the one in DevExpress GridControl. To get the value of a cell in a DataGridView, you can use the following approach:

Assuming you want to retrieve the value from a specific cell in the currently selected row, you can use the DataGridView's `SelectedRows` property to get the selected row, and then access the cell value by specifying the column index or column name.

Here's how you can modify your code to retrieve the ProductID from the currently selected row:

```csharp
private void BtnDelete_Click(object sender, EventArgs e)
{
    // Check if any row is selected
    if (dataGridView1.SelectedRows.Count > 0)
    {
        // Get the selected row
        DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

        // Retrieve the ProductID from the selected row
        int productIDToDelete = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);

        // Continue with the deletion logic
        // ...
    }
    else
    {
        MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
```

In this code:

1. We check if any row is selected in the DataGridView using `dataGridView1.SelectedRows.Count`. If no rows are selected, we display a message to the user.

2. If a row is selected, we retrieve the selected row using `dataGridView1.SelectedRows[0]`.

3. We then access the cell value using `selectedRow.Cells["ProductID"].Value` to get the ProductID from the selected row.

Make sure to adjust the column name `"ProductID"` to match the actual name of the column in your DataGridView.

ProductiD
ProductID


private int GetCurrentInvoiceNumber()
        {
            // Assuming gridControl1's main view is GridView
            var gridView = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (gridView != null && gridView.FocusedRowHandle >= 0)
            {
                object row = gridView.GetRow(gridView.FocusedRowHandle);
                if (row is DataRowView dataRowView)
                {
                    // Assuming the column name is "InvoiceNumber" and it's of type int
                    return Convert.ToInt32(dataRowView["InvoiceNumber"]);
                }
            }

            // Return a default value or handle the case when no row is selected
            return -1; // -1 or any other value that indicates no selection
        }
        private void DeleteInvoiceItem(int itemID)
        {
            // Find the row with the given ItemID
            var rows = saleInvoiceDataSet1.InvoiceItems.Select($"ItemID = {itemID}");
            if (rows.Length > 0)
            {
                // Remove the found row
                saleInvoiceDataSet1.InvoiceItems.Rows.Remove(rows[0]);

                // Optionally, update the database here if you're using a database

                // Refresh gridControl2 to reflect the deletion
                int currentInvoiceNumber = GetCurrentInvoiceNumber(); // Implement this method
                PopulateInvoiceItems(currentInvoiceNumber);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the selected item's ID from gridControl2
            var gridView = gridControl2.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (gridView != null && gridView.FocusedRowHandle >= 0)
            {
                object row = gridView.GetRow(gridView.FocusedRowHandle);
                if (row is DataRowView dataRowView)
                {
                    int itemID = Convert.ToInt32(dataRowView["ItemID"]); // Replace "ItemID" with the actual column name

                    // Call the DeleteInvoiceItem method
                    DeleteInvoiceItem(itemID);
                }
            }
        }

chú đọc và tìm hiểu cho anh:
  + cách khai báo, add, remove 1 phần tử khỏi list
  + Gán source vào grid control
  + Cách lưu dữ liệu vào database
  + Cách tìm kiếm dữ liệu đã lưu ra và gán vào grid
  + Cách xóa 1 dòng khỏi database			
