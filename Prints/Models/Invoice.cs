using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prints.Models
{
    public class Invoice
    {
        public SalesHeader Header { get; set; }
        public Party Party { get; set; }
        public List<SalesLineItem> LineItems { get; set; }

        public Invoice(SalesHeader header, Party party, List<SalesLineItem> lineItems)
        {
            Header = header;
            Party = party;
            LineItems = lineItems;
        }
    }
}