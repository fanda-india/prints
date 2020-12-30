using System;

namespace Prints
{
    internal class AccountingYear
    {
        private string yearDir;
        private string yearName;

        public string YearDir { get => yearDir; set => yearDir = value.Trim(); }
        public string YearName { get => yearName; set => yearName = value.Trim(); }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public override string ToString()
        {
            return YearName;
        }
    }
}