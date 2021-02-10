using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prints
{
    public partial class CrystalReportsForm : Form
    {
        //private readonly string CompanyName;
        private readonly List<ProductTag> ProductTags;

        public CrystalReportsForm(string companyName, List<ProductTag> productTags)
        {
            InitializeComponent();

            //CompanyName = companyName;
            ProductTags = productTags;
        }

        private void CrystalReportsForm_Load(object sender, EventArgs e)
        {
            TagPrinting21.SetDataSource(ProductTags);
        }
    }
}