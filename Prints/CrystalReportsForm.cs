using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace Prints
{
    public partial class CrystalReportsForm : Form
    {
        private readonly string ReportName;

        // Print tags

        private readonly List<ProductTag> ProductTags;

        // Invoice

        private readonly SalesHeader SalesHeader;
        private readonly Party Party;
        private readonly List<SalesLineItem> SalesLineItems;
        private bool IsDuplicate;

        #region Constructors

        public CrystalReportsForm(string reportName, List<ProductTag> productTags)
        {
            InitializeComponent();

            Text = "Tag Printing";

            ReportName = reportName;
            ProductTags = productTags;
        }

        public CrystalReportsForm(string reportName, SalesHeader header,
            Party party, List<SalesLineItem> items, bool isDuplicate = false)
        {
            InitializeComponent();

            Text = "Invoice Printing";

            ReportName = reportName;
            SalesHeader = header;
            Party = party;
            SalesLineItems = items;
            IsDuplicate = isDuplicate;
        }

        #endregion Constructors

        private void CrystalReportsForm_Load(object sender, EventArgs e)
        {
            switch (ReportName.ToLower())
            {
                case "tagprinting2":
                    tagPrinting2.SetDataSource(ProductTags);
                    crystalReportViewer1.ReportSource = tagPrinting2;
                    break;

                case "tagkbsilks":
                    tagKbSilks.SetDataSource(ProductTags);
                    crystalReportViewer1.ReportSource = tagKbSilks;
                    break;

                case "tagkbs":
                    tagKBS1.SetDataSource(ProductTags);
                    crystalReportViewer1.ReportSource = tagKBS1;
                    break;

                case "invoiceragu":

                    SalesHeader.NetAmount = Math.Round(SalesHeader.NetAmount, 0, MidpointRounding.AwayFromZero);
                    SalesHeader.AmountInWords = "Rupees " + PrintHelper.InWords(SalesHeader.NetAmount, true).ToLower() + " only";

                    if (IsDuplicate)
                    {
                        invoiceRaguDuplicate1.Database.Tables["Prints_SalesHeader"].SetDataSource(new[] { SalesHeader });
                        invoiceRaguDuplicate1.Database.Tables["Prints_Party"].SetDataSource(new[] { Party });
                        invoiceRaguDuplicate1.Database.Tables["Prints_SalesLineItem"].SetDataSource(SalesLineItems);
                        crystalReportViewer1.ReportSource = invoiceRaguDuplicate1;
                    }
                    else
                    {
                        invoiceRagu1.Database.Tables["Prints_SalesHeader"].SetDataSource(new[] { SalesHeader });
                        invoiceRagu1.Database.Tables["Prints_Party"].SetDataSource(new[] { Party });
                        invoiceRagu1.Database.Tables["Prints_SalesLineItem"].SetDataSource(SalesLineItems);
                        crystalReportViewer1.ReportSource = invoiceRagu1;
                    }
                    break;
            }
            //TagPrinting21.SetDataSource(ProductTags);
        }
    }
}