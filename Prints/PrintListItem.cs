using System;

namespace WinReports
{
    public class PrintListItem
    {
        public string Number { get; set; }

        public DateTime Date { get; set; }
        public string RefNumber { get; set; }

        // public DateTime RefDate { get; set; }
        public string Party { get; set; }

        public string City { get; set; }
        public int TotalQty { get; set; }
        public decimal Subtotal { get; set; }
        public decimal NetAmount { get; set; }
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