using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prints.Models
{
    public class ProductTag
    {
        public string SupplierName { get; set; }
        public string TagNumber { get; set; }
        public string GroupName { get; set; }
        public string ItemName { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }
    }
}
