using System;

namespace Prints
{
    internal class SalesHeader
    {
        private string number;
        private string refNumber;
        private string particular;

        public string Number { get => number; set => number = value.Trim(); }
        public DateTime Date { get; set; }
        public string RefNumber { get => refNumber; set => refNumber = value.Trim(); }
        public int TotalQty { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Disc1Pct { get; set; }
        public decimal Disc1Amt { get; set; }
        public decimal Disc2Pct { get; set; }
        public decimal Disc2Amt { get; set; }
        public decimal SGSTPct { get; set; }
        public decimal SGSTAmt { get; set; }
        public decimal CGSTPct { get; set; }
        public decimal CGSTAmt { get; set; }
        public decimal IGSTPct { get; set; }
        public decimal IGSTAmt { get; set; }
        public decimal Parcel { get; set; }
        public decimal NetAmount { get; set; }
        public string Particular { get => particular; set => particular = value.Trim(); }
    }
}
