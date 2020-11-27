using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prints
{
    internal class SalesLineItem
    {
        private string sareeNumber;
        private string description;

        public int SerialNumber { get; set; }
        public string SareeNumber { get => sareeNumber; set => sareeNumber = value.Trim(); }
        public string Description { get => description; set => description = value.Trim(); }
        public decimal Rate { get; set; }
    }
}