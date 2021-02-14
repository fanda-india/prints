using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prints
{
    public partial class CrystalReportsForm : Form
    {
        private readonly string TagRPT;

        //private readonly string CompanyName;
        private readonly List<ProductTag> ProductTags;

        public CrystalReportsForm(string tagRpt, string companyName, List<ProductTag> productTags)
        {
            InitializeComponent();

            TagRPT = tagRpt;
            //CompanyName = companyName;
            ProductTags = productTags;
        }

        private void CrystalReportsForm_Load(object sender, EventArgs e)
        {
            switch (TagRPT.ToLower())
            {
                case "tagprinting":
                    tagPrinting.SetDataSource(ProductTags);
                    crystalReportViewer1.ReportSource = tagPrinting;
                    break;

                case "tagprinting2":
                    tagPrinting2.SetDataSource(ProductTags);
                    crystalReportViewer1.ReportSource = tagPrinting2;
                    break;

                case "tagkbsilks":
                    tagKbSilks.SetDataSource(ProductTags);
                    crystalReportViewer1.ReportSource = tagKbSilks;
                    break;
            }
            //TagPrinting21.SetDataSource(ProductTags);
        }
    }
}