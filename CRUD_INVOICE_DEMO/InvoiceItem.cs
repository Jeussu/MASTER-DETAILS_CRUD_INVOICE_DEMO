//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD_INVOICE_DEMO
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceItem
    {
        public int ItemID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> IntoMoney { get; set; }
        public Nullable<decimal> ToTalMoney { get; set; }
        public int InvoiceNumber { get; set; }
    
        public virtual SalesInvoice SalesInvoice { get; set; }
    }
}
