namespace Prints
{
    internal class SalesLineItem
    {
        private string sareeNumber;
        private string description;
        private string hsnCode;

        public int SerialNumber { get; set; }
        public string SareeNumber { get => sareeNumber; set => sareeNumber = value.Trim(); }
        public string Description { get => description; set => description = value.Trim(); }
        public string HsnCode { get => hsnCode; set => hsnCode = value.Trim(); }
        public decimal Rate { get; set; }
    }
}
