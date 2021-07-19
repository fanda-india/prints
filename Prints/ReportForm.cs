using Microsoft.Reporting.WinForms;

using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Prints
{
    internal partial class ReportForm : Form
    {
        private readonly Company company;

        // Invoice

        private readonly Party party;
        private readonly SalesHeader header;
        private readonly List<SalesLineItem> lineItems;

        // GstInput

        private readonly DateTime dateFrom;
        private readonly DateTime dateTo;
        private readonly List<Tax> gstInputs;

        // Tag Printing

        private readonly string companyName;
        private readonly List<ProductTag> productTags;

        private readonly string tranName;

        #region Constructors

        public ReportForm()
        {
            InitializeComponent();
        }

        public ReportForm(string invoiceRDLC, Company company, Party party,
            SalesHeader header, List<SalesLineItem> lineItems,
            string formText = "Invoice",
            string tranName = "") : this()
        {
            this.company = company;
            this.party = party;
            this.header = header;
            this.lineItems = lineItems;
            this.tranName = tranName;

            Text = formText;
            reportViewer1.LocalReport.ReportEmbeddedResource = $"Prints.{invoiceRDLC}.rdlc";

            if (formText == "Debit Note")
            {
                lblInvoiceType.Visible = false;
                cboInvoiceType.Visible = false;
                btnShow.Visible = false;
                ShowInvoice();
            }
        }

        public ReportForm(Company company, DateTime dateFrom, DateTime dateTo, List<Tax> gstInputs) : this()
        {
            this.company = company;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
            this.gstInputs = gstInputs;

            lblInvoiceType.Visible = false;
            cboInvoiceType.Visible = false;
            btnShow.Visible = false;
            Text = "GST Report";

            ShowGstInput();
        }

        public ReportForm(string companyName, List<ProductTag> productTags) : this()
        {
            this.companyName = companyName;
            this.productTags = productTags;

            lblInvoiceType.Visible = false;
            cboInvoiceType.Visible = false;
            btnShow.Visible = false;
            Text = "Tag Printing";

            PrintTags();
        }

        #endregion Constructors

        private void ReportForm_Load(object sender, EventArgs e)
        {
            cboInvoiceType.SelectedIndex = 0;
            btnShow.PerformClick();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowInvoice();
        }

        #region Invoice

        private void ShowInvoice()
        {
            string[] partiular = header.Particular.Split(',');
            string selectedBy = string.Empty;
            string sendThrough = string.Empty;
            if (partiular.Length == 1)
            {
                selectedBy = partiular[0];
            }
            else if (partiular.Length > 1)
            {
                selectedBy = partiular[0];
                sendThrough = partiular[1];
            }
            string invoiceType = cboInvoiceType.SelectedItem as string;
            invoiceType = invoiceType == null ? "ORIGINAL" : invoiceType;

            ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter("CompanyName", company.Name),
                new ReportParameter("CompanyAddress", company.Address),
                new ReportParameter("CompanyCity", company.City),
                new ReportParameter("CompanyPhone1", company.Phone1),
                new ReportParameter("CompanyPhone2", company.Phone2),
                new ReportParameter("CompanyFax", company.Fax),
                new ReportParameter("CompanyPAN", company.PAN),
                new ReportParameter("CompanyGSTIN", company.GSTIN),
                new ReportParameter("CompanyAreaCode", company.Areacode),
                new ReportParameter("CompanyBankName", company.BankName),
                new ReportParameter("CompanyBankAcctNum", company.BankAcctNum),
                new ReportParameter("CompanyBankIfsc", company.BankIfsc),
                new ReportParameter("PartyName", party.Name),
                new ReportParameter("PartyAddress", party.Address),
                new ReportParameter("PartyArea", party.Area),
                new ReportParameter("PartyCity", party.City),
                new ReportParameter("PartyPinCode", party.PinCode),
                new ReportParameter("PartyPhone", party.Phone),
                new ReportParameter("PartyGSTIN", party.GSTIN),
                new ReportParameter("BillNumber", header.Number.Substring(header.Number.Length-5)),
                new ReportParameter("BillDate", header.Date.ToString("dd-MM-yyyy")),
                new ReportParameter("TotalQty", header.TotalQty.ToString()),
                new ReportParameter("Subtotal", header.Subtotal.ToString()),
                new ReportParameter("Disc1Pct", header.Disc1Pct.ToString()),
                new ReportParameter("Disc1Amt", header.Disc1Amt.ToString()),
                new ReportParameter("TotalBTax", header.TotalBTax==0 ? (header.Subtotal-header.Disc1Amt).ToString() : header.TotalBTax.ToString()),
                new ReportParameter("SGSTPct", header.SGSTPct==0 ? string.Empty : header.SGSTPct.ToString()),
                new ReportParameter("SGSTAmt", header.SGSTAmt==0 ? string.Empty : header.SGSTAmt.ToString()),
                new ReportParameter("CGSTPct", header.CGSTPct==0? string.Empty : header.CGSTPct.ToString()),
                new ReportParameter("CGSTAmt", header.CGSTAmt==0 ? string.Empty : header.CGSTAmt.ToString()),
                new ReportParameter("IGSTPct", header.IGSTPct==0 ? string.Empty : header.IGSTPct.ToString()),
                new ReportParameter("IGSTAmt", header.IGSTAmt==0 ? string.Empty : header.IGSTAmt.ToString()),
                new ReportParameter("Parcel", header.Parcel==0 ? string.Empty: header.Parcel.ToString()),
                new ReportParameter("InWords", "Rupees "+PrintHelper.InWords(header.NetAmount,true).ToLower()+" only"),
                new ReportParameter("NetAmount", header.NetAmount.ToString()),
                new ReportParameter("SelectedBy", selectedBy),
                new ReportParameter("SendThrough", sendThrough),
                new ReportParameter("InvoiceType", invoiceType.ToUpper()),
                new ReportParameter("LUTNumber", tranName.ToLower().Contains("international") ? company.CST : string.Empty)
            };
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("SalesLineItems", lineItems));
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
        }

        #endregion Invoice

        #region GstInput

        private void ShowGstInput()
        {
            ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter("CompanyName", company.Name),
                new ReportParameter("DateFrom", dateFrom.ToString("dd-MM-yyyy")),
                new ReportParameter("DateTo", dateTo.ToString("dd-MM-yyyy"))
            };
            reportViewer1.LocalReport.ReportEmbeddedResource = "Prints.GstInput.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("GstInput", gstInputs));
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
        }

        #endregion GstInput

        #region TagPrinting

        private void PrintTags()
        {
            ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter("CompanyName", companyName)
            };
            reportViewer1.LocalReport.ReportEmbeddedResource = "Prints.TagPrinting.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ProductTags", productTags));
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }

        #endregion TagPrinting
    }
}
