using System;

namespace Prints
{
    internal class GstInput
    {
        public string GSTIN { get; set; }
        public string CustomerName { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; } = null;
        public string RefNumber { get; set; }
        public DateTime? RefDate { get; set; } = null;
        public string HSNSACCode { get; set; }
        public decimal Qty { get; set; }
        public decimal BeforeTax { get; set; }
        public decimal IGSTPct { get; set; }
        public decimal IGSTAmt { get; set; }
        public decimal CGSTPct { get; set; }
        public decimal CGSTAmt { get; set; }
        public decimal SGSTPct { get; set; }
        public decimal SGSTAmt { get; set; }
        public decimal Total { get; set; }
    }

    internal class TaxInput
    {
        public string GSTIN { get; set; }
        public string CustomerName { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; } = null;
        public string RefNumber { get; set; }
        public DateTime? RefDate { get; set; } = null;
        public string HSNSACCode { get; set; }
        public int Qty { get; set; }
        public string TaxCode { get; set; }
        public string TaxName { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal Total { get; set; }
        public string BillNumber { get; set; }  // get CGST and SGST
    }
}
