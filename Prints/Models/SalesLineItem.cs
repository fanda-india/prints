namespace Prints
{
    public class SalesLineItem
    {
        private string invoiceNumber;
        private string sareeNumber;
        private string description;
        private string hsnCode;

        public string InvoiceNumber { get => invoiceNumber; set => invoiceNumber = value.Trim(); }
        public int SerialNumber { get; set; }
        public string SareeNumber { get => sareeNumber; set => sareeNumber = value.Trim(); }
        public string Description { get => description; set => description = value.Trim(); }
        public string HsnCode { get => hsnCode; set => hsnCode = value.Trim(); }
        public decimal Rate { get; set; }
    }
}