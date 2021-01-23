using System;

namespace Prints
{
    public class ProductTag
    {
        private string priceCode;

        public string TagNumber { get; set; }
        public string GroupName { get; set; }
        public string ItemName { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public string PriceCode { get { return priceCode; } }

        public void UpdatePriceCode(char[] priceCodeConfig)
        {
            decimal costPrice = CostPrice + (CostPrice * 0.2M);
            string costPriceString = Convert.ToInt32(costPrice).ToString();
            string priceCode = string.Empty;

            foreach (char cp in costPriceString)
            {
                int indexNum = Convert.ToInt32(cp.ToString()) - 1;
                if (indexNum == -1)
                    indexNum = 9;

                priceCode = priceCode + priceCodeConfig[indexNum];
            }
            this.priceCode = priceCode;
        }
    }
}
