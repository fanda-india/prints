namespace Prints
{
    internal class Party
    {
        private string name;
        private string address;
        private string area;
        private string city;
        private string pinCode;
        private string phone;
        private string gstin;

        public string Name { get => name; set => name = value.Trim(); }
        public string Address { get => address; set => address = value.Trim(); }
        public string Area { get => area; set => area = value.Trim(); }
        public string City { get => city; set => city = value.Trim(); }
        public string PinCode { get => pinCode; set => pinCode = value.Trim(); }
        public string Phone { get => phone; set => phone = value.Trim(); }
        public string GSTIN { get => gstin; set => gstin = value.Trim(); }
    }
}