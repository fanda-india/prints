using Dapper;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Odbc;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Prints
{
    public partial class MainForm : Form
    {
        private readonly string DataConnectionString;
        private string YearConnectionString;

        private Company SelectedCompany;
        private AccountingYear SelectedYear;

        public MainForm()
        {
            InitializeComponent();

            string dataPath = ConfigurationManager.AppSettings["DataPath"];
            if (string.IsNullOrEmpty(dataPath))
            {
                dataPath = @".\";
            }
            DataConnectionString = @"Provider=vfpoledb.1;Data Source=" + dataPath + ";Extended Properties=dBASE IV;Collating Sequence=machine;";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadCompanies();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                return;
            listSplit.SplitterDistance = (int)(listSplit.Width * 0.15);
            contentSplit.SplitterDistance = (int)(contentSplit.Height * 0.90);
        }

        private void tscCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCompany = tscCompanies.SelectedItem as Company;
            if (SelectedCompany != null)
            {
                Text = $"Prints - {SelectedCompany.Name}";
                LoadYears();
            }
        }

        private void tscYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedYear = tscYears.SelectedItem as AccountingYear;
            if (SelectedYear != null)
            {
                Text = $"Prints - {SelectedCompany.Name} - {SelectedYear.YearName}";

                //string filePath = DataPath + "COMP" + SelectedCompany.Code + "\\" + SelectedYear.YearDir + "\\";
                string filePath = Path.Combine(SelectedCompany.DataDir, SelectedYear.YearDir) + "\\";
                YearConnectionString = @"Provider=vfpoledb.1;Data Source=" + filePath + ";Extended Properties=dBASE IV;Collating Sequence=machine;";

                //lvwList.Items.Clear();
                //printListItemBindingSource.DataSource = null;
                lstMenu.SelectedIndex = -1;
                dtpDate.MaxDate = DateTime.Today;
                dtpDate.MinDate = SelectedYear.FromDate;
                dtpDate.MaxDate = SelectedYear.ToDate;
                dtpDate.Value = new DateTime(Math.Min(SelectedYear.ToDate.Ticks, DateTime.Today.Ticks));
            }
        }

        private void lstMenu_Click(object sender, EventArgs e)
        {
            string menuItem = lstMenu.SelectedItem as string;
            switch (menuItem)
            {
                case "Invoices":
                    try
                    {
                        string fileExt = string.Format("{0:000}", SelectedCompany.Code);
                        LoadInvoices(fileExt);
                    }
                    catch (Exception ex)
                    {
                        LoadInvoices("DBF");
                    }
                    break;

                case "Receipts":
                    LoadReceipts();
                    break;

                case "GST Input Report":
                    try
                    {
                        string fileExt = string.Format("{0:000}", SelectedCompany.Code);
                        LoadGSTInputReport(fileExt);
                    }
                    catch (Exception ex)
                    {
                        LoadGSTInputReport("DBF");
                    }

                    break;
            }
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            var printHeader = printListItemBindingSource.Current as PrintHeader;
            if (printHeader != null)
            {
                try
                {
                    string fileExt = string.Format("{0:000}", SelectedCompany.Code);
                    PrintInvoice(printHeader, fileExt);
                }
                catch
                {
                    PrintInvoice(printHeader, "DBF");
                }
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            dtpDate.Value = SelectedYear.FromDate;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (dtpDate.Value > SelectedYear.FromDate)
            {
                dtpDate.Value = dtpDate.Value.AddDays(-1);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (dtpDate.Value < SelectedYear.ToDate)
            {
                dtpDate.Value = dtpDate.Value.AddDays(1);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            dtpDate.Value = SelectedYear.ToDate;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            lstMenu_Click(this, null);
        }

        private void LoadCompanies()
        {
            tscCompanies.Items.Clear();

            string query = "SELECT COMP_CODE AS Code, COMP_NAME AS Name, COMP_ADDR AS Address, " +
                "COMP_CITY AS City, COMP_PH1 AS Phone1, COMP_PH2 AS Phone2, COMP_FAX AS Fax, " +
                "COMP_ITPAN AS PAN, COMP_TNGST AS GSTIN, COMP_CST AS CST, COMP_ACODE AS AreaCode, " +
                "BANK_NAME AS BankName, BANK_ACNO AS BankAcctNum, BANK_IFSC AS BankIfsc, " +
                "DATA_DIR AS DataDir FROM COMPANY";
            using (var con = new OleDbConnection(DataConnectionString))
            {
                con.Open();
                var companies = con.Query<Company>(query);
                foreach (var company in companies)
                {
                    tscCompanies.Items.Add(company);
                }
            }

            if (tscCompanies.Items.Count > 0)
                tscCompanies.SelectedIndex = 0;
        }

        private void LoadYears()
        {
            if (SelectedCompany == null)
                return;

            tscYears.Items.Clear();
            tscYears.Text = "";
            try
            {
                var dirInfo = new DirectoryInfo(SelectedCompany.DataDir);
                var dirs = dirInfo.EnumerateDirectories("*");
                foreach (var dir in dirs)
                {
                    string dirName = dir.Name;

                    if (!dirName.StartsWith("AY"))
                        continue;

                    string fromYear = $"20{dirName.Substring(2, 2)}";
                    string toYear = $"20{dirName.Substring(5, 2)}";

                    if (string.IsNullOrEmpty(fromYear) || Convert.ToInt32(fromYear) <= 0)
                        continue;
                    if (string.IsNullOrEmpty(toYear) || Convert.ToInt32(toYear) <= 0)
                        continue;

                    var year = new AccountingYear
                    {
                        YearDir = dirName,
                        YearName = $"{fromYear}-{toYear}",
                        FromDate = new DateTime(Convert.ToInt32(fromYear), 4, 1),
                        ToDate = new DateTime(Convert.ToInt32(toYear), 3, 31)
                    };

                    tscYears.Items.Add(year);
                }
            }
            catch { }
            if (tscYears.Items.Count > 0)
            {
                tscYears.SelectedIndex = tscYears.Items.Count - 1;
            }

            //lvwList.Items.Clear();
            //printListItemBindingSource.DataSource = null;
        }

        private void LoadInvoices(string fileExtension)
        {
            string fileName = $"INV_HDR.{fileExtension}";
            using (var con = new OleDbConnection(YearConnectionString))
            {
                con.Open();
                string query = "SELECT BILL_NO AS Number, BILL_DT AS Date, REF_NO AS RefNumber, " +
                    "CODE AS PartyCode, NAME AS Party, CITY AS City, TOT_QTY AS TotalQty, " +
                    "SUB_TOT AS Subtotal, NET_AMT AS NetAmount " +
                    $"FROM {fileName} WHERE CAT='S' AND BILL_DT=CTOD('{dtpDate.Value.ToString("MM/dd/yyyy")}')";

                var invoices = con.Query<PrintHeader>(query);
                printListItemBindingSource.DataSource = invoices;
            }
        }

        private void PrintInvoice(PrintHeader printHeader, string fileExt)
        {
            string partyDbf = $"ACCTMAST.{fileExt}";
            string invoiceDbf = $"INV_HDR.{fileExt}";
            string salesDbf = $"SALES.{fileExt}";

            Party party;
            SalesHeader salesHeader;
            List<SalesLineItem> lineItems;
            using (var con = new OleDbConnection(YearConnectionString))
            {
                con.Open();
                string query = "SELECT NAME, ADDRESS, AREA, CITY, PIN AS PinCode, " +
                    "PHONE, SAL_TAX_NO AS GSTIN " +
                    $"FROM {partyDbf} WHERE CODE='{printHeader.PartyCode}'";
                party = con.QuerySingle<Party>(query);

                query = "SELECT BILL_NO AS Number, BILL_DT AS Date, REF_NO AS RefNumber, " +
                   "TOT_QTY AS TotalQty, SUB_TOT AS Subtotal, " +
                   "PER_DISC1 AS Disc1Pct, DISCOUNT1 AS Disc1Amt, PER_DISC2 AS Disc2Pct, " +
                   "PER_SGST AS SGSTPct, SGST AS SGSTAmt, PER_CGST CGSTPct, CGST AS CGSTAmt, " +
                   "PER_IGST AS IGSTPct, IGST AS IGSTAmt, PARCEL, NET_AMT AS NetAmount, PARTICULAR " +
                   $"FROM {invoiceDbf} WHERE BILL_NO='{printHeader.Number}'";
                salesHeader = con.QuerySingle<SalesHeader>(query);

                query = "SELECT SL_NO AS SerialNumber, SAREE_NO AS SareeNumber, " +
                    "ITEM_NAME AS Description, PRICE AS Rate " +
                    $"FROM {salesDbf} WHERE BILL_NO='{printHeader.Number}'";
                lineItems = con.Query<SalesLineItem>(query).ToList();
            }

            using (var rptForm = new ReportForm(SelectedCompany, party, salesHeader, lineItems))
            {
                rptForm.ShowDialog(this);
            }
        }

        private void LoadGSTInputReport(string fileExtension, DateTime fromDate = default, DateTime toDate = default)
        {
            fromDate = new DateTime(2019, 4, 1);
            toDate = new DateTime(2020, 4, 30);

            string invHdr = $"INV_HDR.{fileExtension}";
            string acctMast = $"ACCTMAST.{fileExtension}";
            string jnlDtl = $"JOURNAL1.{fileExtension}";
            string jnlHdr = $"JOURNAL2.{fileExtension}";
            using (var con = new OleDbConnection(YearConnectionString))
            {
                con.Open();
                // Invoices
                string query =
                    "SELECT a.SAL_TAX_NO AS GSTIN, a.NAME AS CustomerName, " +
                    "i.BILL_NO AS InvoiceNumber, i.BILL_DT AS InvoiceDate, " +
                    "i.REF_NO AS DebitNoteNumber, i.REF_DT AS DebitNoteDate, " +
                    "'HSN/SAC' AS HSNSACCode, i.TOT_QTY AS Qty, i.SUB_TOT-i.DISCOUNT1 AS BeforeTax, " +
                    "i.PER_IGST AS IGSTPct, i.IGST AS IGSTAmt, " +
                    "i.PER_CGST AS CGSTPct, i.CGST AS CGSTAmt, " +
                    "i.PER_SGST AS SGSTPct, i.SGST AS SGSTAmt, i.NET_AMT AS Total " +
                    $"FROM {invHdr} AS i INNER JOIN {acctMast} AS a ON i.CODE=a.CODE " +
                    $"WHERE CAT IN ('P', 'R', 'K', 'J') AND " +
                    $"BILL_DT >= CTOD('{fromDate.ToString("MM/dd/yyyy")}') AND " +
                    $"BILL_DT <= CTOD('{toDate.ToString("MM/dd/yyyy")}')";
                var invoices = con.Query<GstInput>(query)
                    .ToList();

                // Journals
                query =
                    "SELECT h.BILL_NO BillNumber, a.SAL_TAX_NO AS GSTIN, a.NAME AS CustomerName, " +
                    "d.REF_NO AS InvoiceNumber, d.REF_DT AS InvoiceDate, " +
                    "'HSN/SAC' AS HSNSACCode, d.Qty AS Qty, h.NET_AMOUNT AS Total, " +
                    "d.TAXCODE, d.TAXNAME, d.TAXAMOUNT " +
                    $"FROM {jnlHdr} AS h " +
                    "INNER JOIN " +
                    $"(SELECT BILL_NO, CODE AS TAXCODE, NAME AS TAXNAME, QTY, AMOUNT AS TAXAMOUNT, REF_NO, REF_DT FROM {jnlDtl}) AS d " +
                    "ON h.BILL_NO=d.BILL_NO " +
                    $"INNER JOIN {acctMast} AS a ON h.CODE=a.CODE " +
                    $"WHERE d.TAXCODE LIKE 'BI%' AND " +
                    $"BILL_DT >= CTOD('{fromDate.ToString("MM/dd/yyyy")}') AND " +
                    $"BILL_DT <= CTOD('{toDate.ToString("MM/dd/yyyy")}')";
                var journals = con.Query<TaxInput>(query)
                    .ToList();

                if (journals.Count > 1)
                {
                    string billNumber = string.Empty;
                    string gstin = string.Empty;
                    string customerName = string.Empty;
                    string invoiceNumber = string.Empty;
                    DateTime invoiceDate = default;
                    int qty = 0;
                    decimal beforeTax = 0.0m;
                    decimal igstPct = 0.0m;
                    decimal igstAmt = 0.0m;
                    decimal cgstPct = 0.0m;
                    decimal cgstAmt = 0.0m;
                    decimal sgstPct = 0.0m;
                    decimal sgstAmt = 0.0m;
                    decimal total = 0.0m;
                    foreach (TaxInput item in journals)
                    {
                        if (billNumber == item.BillNumber)
                        {
                            gstin = item.GSTIN.Trim();
                            customerName = item.CustomerName.Trim();
                            invoiceNumber = item.InvoiceNumber.Trim();
                            invoiceDate = item.InvoiceDate;
                            qty = item.Qty;
                            total = item.Total;

                            // Tax identification
                            string taxName = item.TaxName.Trim();
                            string resultString = Regex.Match(taxName, @"^[0-9]([.,][0-9]{1,3})?").Value;
                            decimal.TryParse(resultString, out decimal taxPct); // 2.5[%] IGST
                            if (taxPct > 0)
                            {
                                if (item.TaxName.Contains("Igst"))
                                {
                                    igstPct = taxPct;
                                    igstAmt = item.TaxAmount;
                                }
                                else if (item.TaxName.Contains("Cgst"))
                                {
                                    cgstPct = taxPct;
                                    cgstAmt = item.TaxAmount;
                                }
                                else if (item.TaxName.Contains("Sgst"))
                                {
                                    sgstPct = taxPct;
                                    sgstAmt = item.TaxAmount;
                                }
                            }

                            beforeTax = total - (igstAmt + cgstAmt + sgstAmt);
                        }
                        else
                        {
                            if (!string.IsNullOrWhiteSpace(billNumber) && beforeTax != total)
                                invoices.Add(new GstInput
                                {
                                    GSTIN = gstin,
                                    CustomerName = customerName,
                                    InvoiceNumber = invoiceNumber,
                                    HSNSACCode = "HSN/SAC",
                                    InvoiceDate = invoiceDate,
                                    Qty = qty,
                                    BeforeTax = beforeTax,
                                    IGSTPct = igstPct,
                                    IGSTAmt = igstAmt,
                                    CGSTPct = cgstPct,
                                    CGSTAmt = cgstAmt,
                                    SGSTPct = sgstPct,
                                    SGSTAmt = sgstAmt,
                                    Total = total,
                                });

                            // STORE
                            gstin = item.GSTIN.Trim();
                            customerName = item.CustomerName.Trim();
                            invoiceNumber = item.InvoiceNumber.Trim();
                            invoiceDate = item.InvoiceDate;
                            qty = item.Qty;
                            total = item.Total;
                            beforeTax = 0.0m;
                            igstPct = 0.0m;
                            igstAmt = 0.0m;
                            cgstPct = 0.0m;
                            cgstAmt = 0.0m;
                            sgstPct = 0.0m;
                            sgstAmt = 0.0m;
                            // Tax identification
                            string taxName = item.TaxName.Trim();
                            string resultString = Regex.Match(taxName, @"^[0-9]([.,][0-9]{1,3})?").Value;
                            decimal.TryParse(resultString, out decimal taxPct); // 2.5[%] IGST
                            if (taxPct > 0)
                            {
                                if (item.TaxName.Contains("Igst"))
                                {
                                    igstPct = taxPct;
                                    igstAmt = item.TaxAmount;
                                }
                                else if (item.TaxName.Contains("Cgst"))
                                {
                                    cgstPct = taxPct;
                                    cgstAmt = item.TaxAmount;
                                }
                                else if (item.TaxName.Contains("Sgst"))
                                {
                                    sgstPct = taxPct;
                                    sgstAmt = item.TaxAmount;
                                }
                            }
                            beforeTax = total - (igstAmt + cgstAmt + sgstAmt);
                            billNumber = item.BillNumber;
                        }
                    }
                    if (!string.IsNullOrWhiteSpace(billNumber) && beforeTax != total)
                        invoices.Add(new GstInput
                        {
                            GSTIN = gstin,
                            CustomerName = customerName,
                            InvoiceNumber = invoiceNumber,
                            HSNSACCode = "HSN/SAC",
                            InvoiceDate = invoiceDate,
                            Qty = qty,
                            BeforeTax = beforeTax,
                            IGSTPct = igstPct,
                            IGSTAmt = igstAmt,
                            CGSTPct = cgstPct,
                            CGSTAmt = cgstAmt,
                            SGSTPct = sgstPct,
                            SGSTAmt = sgstAmt,
                            Total = total,
                        });
                }
                printListItemBindingSource.DataSource = invoices;
            }
        }

        private void LoadReceipts()
        {
        }
    }
}