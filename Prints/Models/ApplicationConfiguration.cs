﻿namespace Prints.Models
{
    internal class ApplicationConfiguration
    {
        public string DataPath { get; set; }
        public char[] PriceCodeConfig { get; set; }
        public string InvoiceForm { get; set; }
        public string InvoiceReport { get; set; }
        public string TagReport { get; set; }
    }
}