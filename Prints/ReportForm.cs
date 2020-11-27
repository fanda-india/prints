using Microsoft.Reporting.WinForms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prints
{
    internal partial class ReportForm : Form
    {
        private readonly Company company;
        private readonly Party party;
        private readonly SalesHeader header;
        private readonly List<SalesLineItem> lineItems;

        public ReportForm(Company company, Party party, SalesHeader header, List<SalesLineItem> lineItems)
        {
            InitializeComponent();
            this.company = company;
            this.party = party;
            this.header = header;
            this.lineItems = lineItems;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            cboInvoiceType.SelectedIndex = 0;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowReport();
        }

        private void ShowReport()
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
                new ReportParameter("PartyCity", party.City),
                new ReportParameter("PartyPinCode", party.PinCode),
                new ReportParameter("PartyPhone", party.Phone),
                new ReportParameter("PartyGSTIN", party.GSTIN),
                new ReportParameter("BillNumber", header.Number),
                new ReportParameter("BillDate", header.Date.ToString("dd-MM-yyyy")),
                new ReportParameter("TotalQty", header.TotalQty.ToString()),
                new ReportParameter("Subtotal", header.Subtotal.ToString()),
                new ReportParameter("Disc1Amt", header.Disc1Amt.ToString()),
                new ReportParameter("SGSTPct", header.SGSTPct==0 ? string.Empty: header.SGSTPct.ToString()),
                new ReportParameter("SGSTAmt", header.SGSTAmt==0 ? string.Empty: header.SGSTAmt.ToString()),
                new ReportParameter("CGSTPct", header.CGSTPct==0? string.Empty : header.CGSTPct.ToString()),
                new ReportParameter("CGSTAmt", header.CGSTAmt==0 ? string.Empty : header.CGSTAmt.ToString()),
                new ReportParameter("IGSTPct", header.IGSTPct==0 ? string.Empty : header.IGSTPct.ToString()),
                new ReportParameter("IGSTAmt", header.IGSTAmt==0 ? string.Empty : header.IGSTAmt.ToString()),
                new ReportParameter("Parcel", header.Parcel==0 ? string.Empty: header.Parcel.ToString()),
                new ReportParameter("InWords", "Rupees "+InWords(header.NetAmount,true)+" only"),
                new ReportParameter("NetAmount", header.NetAmount.ToString()),
                new ReportParameter("SelectedBy", selectedBy),
                new ReportParameter("SendThrough", sendThrough),
                new ReportParameter("InvoiceType", invoiceType)
            };
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("SalesLineItems", lineItems));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.RefreshReport();
        }

        private string InWords(decimal? numbers, Boolean paisaconversion = false)
        {
            var pointindex = numbers.ToString().IndexOf(".");
            var paisaamt = 0;
            if (pointindex > 0)
                paisaamt = Convert.ToInt32(numbers.ToString().Substring(pointindex + 1, 2));

            int number = Convert.ToInt32(numbers);

            if (number == 0) return "Zero";
            if (number == -2147483648) return "Minus Two Hundred and Fourteen Crore Seventy Four Lakh Eighty Three Thousand Six Hundred and Forty Eight";
            int[] num = new int[4];
            int first = 0;
            int u, h, t;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            if (number < 0)
            {
                sb.Append("Minus ");
                number = -number;
            }
            string[] words0 = { "", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine " };
            string[] words1 = { "Ten ", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ", "Fifteen ", "Sixteen ", "Seventeen ", "Eighteen ", "Nineteen " };
            string[] words2 = { "Twenty ", "Thirty ", "Forty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " };
            string[] words3 = { "Thousand ", "Lakh ", "Crore " };
            num[0] = number % 1000; // units
            num[1] = number / 1000;
            num[2] = number / 100000;
            num[1] = num[1] - 100 * num[2]; // thousands
            num[3] = number / 10000000; // crores
            num[2] = num[2] - 100 * num[3]; // lakhs
            for (int i = 3; i > 0; i--)
            {
                if (num[i] != 0)
                {
                    first = i;
                    break;
                }
            }
            for (int i = first; i >= 0; i--)
            {
                if (num[i] == 0) continue;
                u = num[i] % 10; // ones
                t = num[i] / 10;
                h = num[i] / 100; // hundreds
                t = t - 10 * h; // tens
                if (h > 0) sb.Append(words0[h] + "Hundred ");
                if (u > 0 || t > 0)
                {
                    if (h > 0 || i == 0) sb.Append("and ");
                    if (t == 0)
                        sb.Append(words0[u]);
                    else if (t == 1)
                        sb.Append(words1[u]);
                    else
                        sb.Append(words2[t - 2] + words0[u]);
                }
                if (i != 0) sb.Append(words3[i - 1]);
            }

            if (paisaamt == 0 && paisaconversion == false)
            {
                sb.Append("ruppes only");
            }
            else if (paisaamt > 0)
            {
                var paisatext = InWords(paisaamt, true);
                sb.AppendFormat("rupees {0} paise only", paisatext);
            }
            return sb.ToString().TrimEnd();
        }
    }
}
