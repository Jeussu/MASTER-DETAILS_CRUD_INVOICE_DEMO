namespace CRUD_INVOICE_DEMO
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.salesInvoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleInvoiceDataSet1 = new CRUD_INVOICE_DEMO.SaleInvoiceDataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInvoiceNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInVoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.invoiceItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceNumber1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIntoMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToTalMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            this.salesInvoicesTableAdapter = new CRUD_INVOICE_DEMO.SaleInvoiceDataSet1TableAdapters.SalesInvoicesTableAdapter();
            this.invoiceItemsTableAdapter = new CRUD_INVOICE_DEMO.SaleInvoiceDataSet1TableAdapters.InvoiceItemsTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleInvoiceDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.salesInvoicesBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(15, 58);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(939, 225);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // salesInvoicesBindingSource
            // 
            this.salesInvoicesBindingSource.DataMember = "SalesInvoices";
            this.salesInvoicesBindingSource.DataSource = this.saleInvoiceDataSet1;
            // 
            // saleInvoiceDataSet1
            // 
            this.saleInvoiceDataSet1.DataSetName = "SaleInvoiceDataSet1";
            this.saleInvoiceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvoiceNumber,
            this.colCustomerID,
            this.colInVoiceDate,
            this.colCustomerName,
            this.colAddress});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colInvoiceNumber
            // 
            this.colInvoiceNumber.FieldName = "InvoiceNumber";
            this.colInvoiceNumber.Name = "colInvoiceNumber";
            this.colInvoiceNumber.Visible = true;
            this.colInvoiceNumber.VisibleIndex = 0;
            // 
            // colCustomerID
            // 
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Visible = true;
            this.colCustomerID.VisibleIndex = 1;
            // 
            // colInVoiceDate
            // 
            this.colInVoiceDate.FieldName = "InVoiceDate";
            this.colInVoiceDate.Name = "colInVoiceDate";
            this.colInVoiceDate.Visible = true;
            this.colInVoiceDate.VisibleIndex = 2;
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 3;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 4;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.invoiceItemsBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(15, 289);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(939, 120);
            this.gridControl2.TabIndex = 8;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // invoiceItemsBindingSource
            // 
            this.invoiceItemsBindingSource.DataMember = "InvoiceItems";
            this.invoiceItemsBindingSource.DataSource = this.saleInvoiceDataSet1;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemID,
            this.colInvoiceNumber1,
            this.colProductID,
            this.colQuantity,
            this.colUnitPrice,
            this.colProductName,
            this.colIntoMoney,
            this.colToTalMoney});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colItemID
            // 
            this.colItemID.FieldName = "ItemID";
            this.colItemID.Name = "colItemID";
            this.colItemID.Visible = true;
            this.colItemID.VisibleIndex = 0;
            // 
            // colInvoiceNumber1
            // 
            this.colInvoiceNumber1.FieldName = "InvoiceNumber";
            this.colInvoiceNumber1.Name = "colInvoiceNumber1";
            this.colInvoiceNumber1.Visible = true;
            this.colInvoiceNumber1.VisibleIndex = 1;
            // 
            // colProductID
            // 
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            this.colProductID.Visible = true;
            this.colProductID.VisibleIndex = 2;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 3;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 4;
            // 
            // colProductName
            // 
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 5;
            // 
            // colIntoMoney
            // 
            this.colIntoMoney.FieldName = "IntoMoney";
            this.colIntoMoney.Name = "colIntoMoney";
            this.colIntoMoney.Visible = true;
            this.colIntoMoney.VisibleIndex = 6;
            // 
            // colToTalMoney
            // 
            this.colToTalMoney.FieldName = "ToTalMoney";
            this.colToTalMoney.Name = "colToTalMoney";
            this.colToTalMoney.Visible = true;
            this.colToTalMoney.VisibleIndex = 7;
            // 
            // salesInvoicesTableAdapter
            // 
            this.salesInvoicesTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceItemsTableAdapter
            // 
            this.invoiceItemsTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(409, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch1_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown2);
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(666, 28);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(75, 23);
            this.btnAdd1.TabIndex = 9;
            this.btnAdd1.Text = "Add";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(848, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(757, 29);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 426);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Name = "Form2";
            this.Text = "Search InvoiceItem";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleInvoiceDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private DevExpress.XtraGrid.GridControl gridControl1;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNumber;
    private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
    private DevExpress.XtraGrid.Columns.GridColumn colInVoiceDate;
    private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
    private DevExpress.XtraGrid.Columns.GridColumn colAddress;
    private DevExpress.XtraGrid.GridControl gridControl2;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    private SaleInvoiceDataSet1 saleInvoiceDataSet1;
    private System.Windows.Forms.BindingSource salesInvoicesBindingSource;
    private SaleInvoiceDataSet1TableAdapters.SalesInvoicesTableAdapter salesInvoicesTableAdapter;
    private System.Windows.Forms.BindingSource invoiceItemsBindingSource;
    private SaleInvoiceDataSet1TableAdapters.InvoiceItemsTableAdapter invoiceItemsTableAdapter;
    private DevExpress.XtraGrid.Columns.GridColumn colItemID;
    private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNumber1;
    private DevExpress.XtraGrid.Columns.GridColumn colProductID;
    private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
    private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
    private DevExpress.XtraGrid.Columns.GridColumn colProductName;
    private DevExpress.XtraGrid.Columns.GridColumn colIntoMoney;
    private DevExpress.XtraGrid.Columns.GridColumn colToTalMoney;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Button btnAdd1;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnUpdate;
    }
}