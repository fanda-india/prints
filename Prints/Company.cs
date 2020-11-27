using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prints
{
    internal class Company
    {
        private string name;
        private string address;
        private string city;
        private string phone1;
        private string phone2;
        private string fax;
        private string pan;
        private string gstin;
        private string cst;
        private string areacode;
        private string bankName;
        private string bankAcctNum;
        private string bankIfsc;
        private string dataDir;

        public int Code { get; set; }
        public string Name { get => name; set => name = value.Trim(); }
        public string Address { get => address; set => address = value.Trim(); }
        public string City { get => city; set => city = value.Trim(); }
        public string Phone1 { get => phone1; set => phone1 = value.Trim(); }
        public string Phone2 { get => phone2; set => phone2 = value.Trim(); }
        public string Fax { get => fax; set => fax = value.Trim(); }
        public string PAN { get => pan; set => pan = value.Trim(); }
        public string GSTIN { get => gstin; set => gstin = value.Trim(); }
        public string CST { get => cst; set => cst = value.Trim(); }
        public string Areacode { get => areacode; set => areacode = value.Trim(); }
        public string BankName { get => bankName; set => bankName = value.Trim(); }
        public string BankAcctNum { get => bankAcctNum; set => bankAcctNum = value.Trim(); }
        public string BankIfsc { get => bankIfsc; set => bankIfsc = value.Trim(); }

        public string DataDir { get => dataDir; set => dataDir = value.Trim(); }

        public override string ToString()
        {
            return Name;
        }
    }
}