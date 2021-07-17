using System;
using System.Configuration;

namespace Prints
{
    internal class PrintHeader
    {
        private string number;
        private string refNumber;
        private string partyCode;
        private string party;
        private string city;

        public string Number { get => number; set => number = value.Trim(); }
        public DateTime Date { get; set; }
        public string RefNumber { get => refNumber; set => refNumber = value.Trim(); }
        public string PartyCode { get => partyCode; set => partyCode = value.Trim(); }
        public string Party { get => party; set => party = value.Trim(); }
        public string City { get => city; set => city = value.Trim(); }
        public int TotalQty { get; set; }
        public decimal Subtotal { get; set; }
        public decimal NetAmount { get; set; }
        public string TranCode { get; set; }
    }

    //public class PrintListItemMap : EntityMap<PrintListItem>
    //{
    //    public PrintListItemMap()
    //    {
    //        Map(p => p.Number).ToColumn("BILL_NO");
    //        Map(p => p.Date).ToColumn("BILL_DT");
    //        Map(p => p.RefNumber).ToColumn("REF_NO");
    //        Map(p => p.RefDate).ToColumn("REF_DT");
    //        Map(p => p.Party).ToColumn("NAME");
    //        Map(p => p.City).ToColumn("CITY");
    //        Map(p => p.TotalQty).ToColumn("TOT_QTY");
    //        Map(p => p.Subtotal).ToColumn("SUB_TOT");
    //        Map(p => p.NetAmount).ToColumn("NET_AMT");
    //    }
    //}
}
