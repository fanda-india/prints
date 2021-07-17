﻿using Dapper;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Prints
{
    public partial class MainForm : Form
    {
        #region AppConfig

        private readonly char[] PriceCodeConfig;
        private readonly string InvoiceRDLC;
        private readonly string TagRPT;

        #endregion AppConfig

        private readonly string DataConnectionString;
        private string YearConnectionString;

        private Company SelectedCompany;
        private AccountingYear SelectedYear;

        private DateTime DateFrom;
        private DateTime DateTo;

        public MainForm()
        {
            InitializeComponent();

            #region AppConfig

            #region DataPath

            string dataPath = ConfigurationManager.AppSettings["DataPath"];
            if (string.IsNullOrEmpty(dataPath))
            {
                dataPath = @".\";
            }
            DataConnectionString = @"Provider=vfpoledb.1;Data Source=" + dataPath + ";Extended Properties=dBASE IV;Collating Sequence=machine;";

            #endregion DataPath

            #region PriceCode

            string priceCode = ConfigurationManager.AppSettings["PriceCode"];
            if (string.IsNullOrEmpty(priceCode))
                priceCode = "ABCDEFGHIJ";

            PriceCodeConfig = priceCode.ToCharArray();

            #endregion PriceCode

            #region InvoiceRDLC

            InvoiceRDLC = ConfigurationManager.AppSettings["InvoiceRDLC"];
            if (string.IsNullOrWhiteSpace(InvoiceRDLC))
                InvoiceRDLC = "Invoice";

            #endregion InvoiceRDLC

            #region TagRPT

            TagRPT = ConfigurationManager.AppSettings["TagRPT"];
            if (string.IsNullOrWhiteSpace(TagRPT))
                TagRPT = "TagPrinting2";

            #endregion TagRPT

            #endregion AppConfig
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadCompanies();

            foreach (DataGridViewColumn col in dgvGst.Columns)
            {
                if (col.DataPropertyName == "Qty" || col.DataPropertyName == "BeforeTax" ||
                    col.DataPropertyName == "IGSTPct" || col.DataPropertyName == "IGSTAmt" ||
                    col.DataPropertyName == "CGSTPct" || col.DataPropertyName == "CGSTAMT" ||
                    col.DataPropertyName == "SGSTPct" || col.DataPropertyName == "SGSTAMT" ||
                    col.DataPropertyName == "Total")
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                return;
            }

            //listSplit.SplitterDistance = (int)(listSplit.Width * 0.15);
            //contentSplit.SplitterDistance = (int)(contentSplit.Height * 0.90);
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

                cboMonth.SelectedIndex = dtpDate.Value.Month >= 4 && dtpDate.Value.Month <= 12
                    ? dtpDate.Value.Month - 4
                    : dtpDate.Value.Month + 8;
            }
        }

        private void lstMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstMenu.SelectedItem as string)
            {
                case "Invoices":
                    try
                    {
                        dgvInvoices.Visible = true;
                        dgvInvoices.Dock = DockStyle.Fill;
                        dgvGst.Visible = false;
                        dtpDate.Visible = true;
                        cboMonth.Visible = false;

                        chkFullyear.Visible = false;
                        tsbDuplicate.Visible = true;
                        EnableNavigation(true);

                        string fileExt = string.Format("{0:000}", SelectedCompany.Code);
                        LoadInvoices(fileExt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                        LoadInvoices("DBF");
                    }
                    break;

                case "GST Input Report":
                    try
                    {
                        dgvGst.Visible = true;
                        dgvGst.Dock = DockStyle.Fill;
                        dgvInvoices.Visible = false;
                        cboMonth.Visible = true;
                        cboMonth.Location = dtpDate.Location;
                        dtpDate.Visible = false;

                        chkFullyear.Visible = true;
                        tsbDuplicate.Visible = false;
                        EnableNavigation(!chkFullyear.Checked);

                        string fileExt = string.Format("{0:000}", SelectedCompany.Code);
                        LoadGSTReport(fileExt, GstReport.Input);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                        LoadGSTReport("DBF", GstReport.Input);
                    }

                    break;

                case "GST Output Report":
                    try
                    {
                        dgvGst.Visible = true;
                        dgvGst.Dock = DockStyle.Fill;
                        dgvInvoices.Visible = false;
                        cboMonth.Visible = true;
                        cboMonth.Location = dtpDate.Location;
                        dtpDate.Visible = false;

                        chkFullyear.Visible = true;
                        tsbDuplicate.Visible = false;
                        EnableNavigation(!chkFullyear.Checked);

                        string fileExt = string.Format("{0:000}", SelectedCompany.Code);
                        LoadGSTReport(fileExt, GstReport.Output);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                        LoadGSTReport("DBF", GstReport.Output);
                    }
                    break;

                case "Receipts":
                    tsbDuplicate.Visible = false;
                    LoadReceipts();
                    break;

                case "Tag Printing":
                    try
                    {
                        dgvInvoices.Visible = true;
                        dgvInvoices.Dock = DockStyle.Fill;
                        dgvGst.Visible = false;
                        dtpDate.Visible = true;
                        cboMonth.Visible = false;

                        chkFullyear.Visible = false;
                        tsbDuplicate.Visible = false;
                        EnableNavigation(true);

                        string fileExt = string.Format("{0:000}", SelectedCompany.Code);
                        LoadPurchases(fileExt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                        LoadPurchases("DBF");
                    }
                    break;
            }
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            switch (lstMenu.SelectedItem as string)
            {
                case "Invoices":
                    if (printListItemBindingSource.Current is PrintHeader printHeader)
                    {
                        try
                        {
                            string fileExt = string.Format("{0:000}", SelectedCompany.Code);
                            PrintInvoice(printHeader, fileExt);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                            PrintInvoice(printHeader, "DBF");
                        }
                    }

                    break;

                case "GST Input Report":
                    if (gstInputBindingSource.DataSource is List<GstInput> gstInputs)
                    {
                        PrintGstReport(DateFrom, DateTo, gstInputs);
                    }

                    break;

                case "GST Output Report":
                    if (gstInputBindingSource.DataSource is List<GstInput> gstOutputs)
                    {
                        PrintGstReport(DateFrom, DateTo, gstOutputs);
                    }

                    break;

                case "Tag Printing":
                    if (printListItemBindingSource.Current is PrintHeader tagPrint)
                    {
                        try
                        {
                            string fileExt = string.Format("{0:000}", SelectedCompany.Code);
                            PrintTag(tagPrint, fileExt);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                            PrintTag(tagPrint, "DBF");
                        }
                    }
                    break;
            }
        }

        private void tsbDuplicate_Click(object sender, EventArgs e)
        {
            switch (lstMenu.SelectedItem as string)
            {
                case "Invoices":
                    if (printListItemBindingSource.Current is PrintHeader printHeader)
                    {
                        try
                        {
                            string fileExt = string.Format("{0:000}", SelectedCompany.Code);
                            PrintInvoice(printHeader, fileExt, true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                            PrintInvoice(printHeader, "DBF", true);
                        }
                    }

                    break;
            }
        }

        #region Navigation

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (dtpDate.Visible)
                dtpDate.Value = SelectedYear.FromDate;
            else
                cboMonth.SelectedIndex = 0;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (dtpDate.Visible)
            {
                if (dtpDate.Value > SelectedYear.FromDate)
                    dtpDate.Value = dtpDate.Value.AddDays(-1);
            }
            else
            {
                if (cboMonth.SelectedIndex > 0)
                    cboMonth.SelectedIndex--;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (dtpDate.Visible)
            {
                if (dtpDate.Value < SelectedYear.ToDate)
                    dtpDate.Value = dtpDate.Value.AddDays(1);
            }
            else
            {
                if (cboMonth.SelectedIndex < (cboMonth.Items.Count - 1))
                    cboMonth.SelectedIndex++;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (dtpDate.Visible)
                dtpDate.Value = SelectedYear.ToDate;
            else
                cboMonth.SelectedIndex = cboMonth.Items.Count - 1;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            lstMenu_SelectedIndexChanged(this, null);
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstMenu_SelectedIndexChanged(this, null);
        }

        private void chkFullyear_CheckedChanged(object sender, EventArgs e)
        {
            EnableNavigation(!chkFullyear.Checked);
            lstMenu_SelectedIndexChanged(this, null);
        }

        #endregion Navigation

        private void EnableNavigation(bool enable = true)
        {
            btnFirst.Enabled = enable;
            btnPrev.Enabled = enable;
            btnNext.Enabled = enable;
            btnLast.Enabled = enable;
            cboMonth.Enabled = enable;
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
            {
                tscCompanies.SelectedIndex = 0;
            }
        }

        private void LoadYears()
        {
            if (SelectedCompany == null)
            {
                return;
            }

            tscYears.Items.Clear();
            tscYears.Text = "";
            try
            {
                var dirInfo = new DirectoryInfo(SelectedCompany.DataDir);
                var dirs = dirInfo.EnumerateDirectories("*");
                foreach (var dir in dirs)
                {
                    string dirName = dir.Name;

                    if (!dirName.StartsWith("AY", StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }

                    string fromYear = $"20{dirName.Substring(2, 2)}";
                    string toYear = $"20{dirName.Substring(5, 2)}";

                    if (string.IsNullOrEmpty(fromYear) || Convert.ToInt32(fromYear) <= 0)
                    {
                        continue;
                    }

                    if (string.IsNullOrEmpty(toYear) || Convert.ToInt32(toYear) <= 0)
                    {
                        continue;
                    }

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

        #region Reports

        private void LoadInvoices(string fileExtension)
        {
            string fileName = $"INV_HDR.{fileExtension}";
            using (var con = new OleDbConnection(YearConnectionString))
            {
                con.Open();
                string query = "SELECT BILL_NO AS Number, BILL_DT AS Date, REF_NO AS RefNumber, " +
                    "CODE AS PartyCode, NAME AS Party, CITY AS City, TOT_QTY AS TotalQty, " +
                    "SUB_TOT AS Subtotal, NET_AMT AS NetAmount " +
                    $"FROM {fileName} WHERE CAT='S' AND BILL_DT=CTOD('{dtpDate.Value:MM/dd/yyyy}') " +
                    "ORDER BY BILL_NO";

                var invoices = con.Query<PrintHeader>(query);
                printListItemBindingSource.DataSource = invoices;
            }
        }

        private void PrintInvoice(PrintHeader printHeader, string fileExt, bool isDuplicate = false)
        {
            string partyDbf = $"ACCTMAST.{fileExt}";
            string invoiceDbf = $"INV_HDR.{fileExt}";
            string salesDbf = $"SALES.{fileExt}";
            string stockDbf = $"SARSTOCK.{fileExt}";

            Party party;
            SalesHeader salesHeader;
            List<SalesLineItem> lineItems;
            using (var con = new OleDbConnection(YearConnectionString))
            {
                con.Open();
                string query = "SELECT CODE, NAME, ADDRESS, AREA, CITY, PIN AS PinCode, " +
                    "PHONE, SAL_TAX_NO AS GSTIN " +
                    $"FROM {partyDbf} WHERE CODE='{printHeader.PartyCode}'";
                party = con.QuerySingle<Party>(query);

                query = "SELECT BILL_NO AS Number, BILL_DT AS Date, REF_NO AS RefNumber, " +
                   "CODE AS PartyCode, TOT_QTY AS TotalQty, SUB_TOT AS Subtotal, " +
                   "PER_DISC1 AS Disc1Pct, DISCOUNT1 AS Disc1Amt, PER_DISC2 AS Disc2Pct, " +
                   "TOTALBTAX AS TotalBTax, " +
                   "PER_SGST AS SGSTPct, SGST AS SGSTAmt, PER_CGST CGSTPct, CGST AS CGSTAmt, " +
                   "PER_IGST AS IGSTPct, IGST AS IGSTAmt, PARCEL, NET_AMT AS NetAmount, PARTICULAR " +
                   $"FROM {invoiceDbf} WHERE BILL_NO='{printHeader.Number}'";
                salesHeader = con.QuerySingle<SalesHeader>(query);

                query = "SELECT s.BILL_NO AS InvoiceNumber, s.SL_NO AS SerialNumber, s.SAREE_NO AS SareeNumber, " +
                    "s.ITEM_NAME AS Description, s.ITEM_HSN AS HsnCode, s.PRICE AS Rate, p.NAME AS SupplierName " +
                    $"FROM {salesDbf} AS s " +
                    $"INNER JOIN ({stockDbf} AS t INNER JOIN {partyDbf} AS p ON t.CODE=p.CODE) ON s.SAREE_NO=t.SAREE_NO " +
                    $"WHERE s.BILL_NO='{printHeader.Number}' " +
                    $"ORDER BY s.BILL_NO, s.SL_NO";
                lineItems = con.Query<SalesLineItem>(query).ToList();
            }
            salesHeader.GSTIN = SelectedCompany.GSTIN;

            if (InvoiceRDLC == "InvoiceRagu")
            {
                using (var rptForm = new CrystalReportsForm(InvoiceRDLC, salesHeader, party, lineItems, isDuplicate))   // SelectedCompany.Name
                {
                    rptForm.ShowDialog(this);
                }
            }
            else
            {
                using (var rptForm = new ReportForm(InvoiceRDLC, SelectedCompany, party, salesHeader, lineItems))
                {
                    rptForm.ShowDialog(this);
                }
            }
        }

        private void LoadGSTReport(string fileExtension, GstReport report)
        {
            DateTime fromDate;
            DateTime toDate;
            if (chkFullyear.Checked)
            {
                fromDate = SelectedYear.FromDate;
                toDate = SelectedYear.ToDate;
            }
            else
            {
                int monthNumber = cboMonth.SelectedIndex >= 0 && cboMonth.SelectedIndex <= 8
                    ? cboMonth.SelectedIndex + 4
                    : cboMonth.SelectedIndex - 8;
                int yearNumber = monthNumber >= 4 && monthNumber <= 12
                    ? SelectedYear.FromDate.Year
                    : SelectedYear.ToDate.Year;

                fromDate = new DateTime(yearNumber, monthNumber, 1);
                toDate = new DateTime(yearNumber, monthNumber, DateTime.DaysInMonth(yearNumber, monthNumber));
            }
            this.DateFrom = fromDate;
            this.DateTo = toDate;

            string invHdr = $"INV_HDR.{fileExtension}";
            string acctMast = $"ACCTMAST.{fileExtension}";
            string jnlDtl = $"JOURNAL1.{fileExtension}";
            string jnlHdr = $"JOURNAL2.{fileExtension}";
            string rcpHdr = $"RCPTHDR.{fileExtension}";
            string rcpExp = $"RCPTEXP.{fileExtension}";

            using (var con = new OleDbConnection(YearConnectionString))
            {
                con.Open();

                string filter;
                if (report == GstReport.Input)
                    filter = "i.CAT IN ('P', 'R', 'K', 'J')";
                //filter = "i.CAT IN ('J')";
                else //if (report == GstReport.Output)
                    filter = "i.CAT IN ('S', 'U')";

                // Invoices and Raw-material purchase
                string query =
                    "SELECT a.SAL_TAX_NO AS GSTIN, a.NAME AS CustomerName, " +
                    "i.BILL_NO AS InvoiceNumber, i.BILL_DT AS InvoiceDate, " +
                    "i.REF_NO AS RefNumber, i.REF_DT AS RefDate, " +
                    "'HSN/SAC' AS HSNSACCode, i.TOT_QTY AS Qty, " +
                    "IIF(i.CAT='J', i.SUB_TOT-i.DISCOUNT1, i.SUB_TOT-i.DISCOUNT1+i.PARCEL) AS BeforeTax, " +
                    "i.PER_IGST AS IGSTPct, i.IGST AS IGSTAmt, " +   // i.PER_IGST
                    "i.PER_CGST AS CGSTPct, i.CGST AS CGSTAmt, " +
                    "i.PER_SGST AS SGSTPct, i.SGST AS SGSTAmt, i.NET_AMT AS Total " +
                    $"FROM {invHdr} AS i INNER JOIN {acctMast} AS a ON i.CODE=a.CODE " +
                    $"WHERE {filter} AND " +
                    $"i.BILL_DT >= CTOD('{fromDate:MM/dd/yyyy}') AND " +
                    $"i.BILL_DT <= CTOD('{toDate:MM/dd/yyyy}')";
                var invoices = con.Query<GstInput>(query)
                    .ToList();

                invoices
                    .ForEach(i =>
                    {
                        i.GSTIN = i.GSTIN.Trim();
                        i.CustomerName = i.CustomerName.Trim();
                        i.InvoiceNumber = i.InvoiceNumber.Trim();
                        i.RefNumber = i.RefNumber.Trim();
                        i.RefDate = i.RefDate?.Year == 1899 ? null : i.RefDate;
                    });

                if (report == GstReport.Input)
                    filter = "d.DB_CR = 'D'";
                else //if (report == GstReport.Output)
                    filter = "d.DB_CR = 'C'";
                // Journals
                query =
                    "SELECT h.BILL_NO BillNumber, a.SAL_TAX_NO AS GSTIN, a.NAME AS CustomerName, " +
                    "h.BILL_NO AS InvoiceNumber, h.BILL_DT AS InvoiceDate, " +
                    "d.REF_NO AS RefNumber, d.REF_DT AS RefDate, " +
                    "'HSN/SAC' AS HSNSACCode, d.Qty AS Qty, h.NET_AMOUNT AS Total, " +
                    "d.TAXCODE, d.TAXNAME, d.TAXAMOUNT " +
                    $"FROM {jnlHdr} AS h " +
                    "INNER JOIN " +
                    $"(SELECT BILL_NO, CODE AS TAXCODE, NAME AS TAXNAME, QTY, AMOUNT AS TAXAMOUNT, REF_NO, REF_DT, DB_CR FROM {jnlDtl}) AS d " +
                    "ON h.BILL_NO=d.BILL_NO " +
                    $"INNER JOIN {acctMast} AS a ON h.CODE=a.CODE " +
                    $"WHERE d.TAXCODE LIKE 'BI%' AND {filter} AND " +
                    $"h.BILL_DT >= CTOD('{fromDate:MM/dd/yyyy}') AND " +
                    $"h.BILL_DT <= CTOD('{toDate:MM/dd/yyyy}') " +
                    "ORDER BY h.BILL_NO";
                var journals = con.Query<TaxInput>(query)
                    .ToList();
                journals
                    .ForEach(i =>
                    {
                        i.GSTIN = i.GSTIN.Trim();
                        i.CustomerName = i.CustomerName.Trim();
                        i.InvoiceNumber = i.InvoiceNumber.Trim();
                        i.RefNumber = i.RefNumber.Trim();
                        i.RefDate = i.RefDate?.Year == 1899 ? null : i.RefDate;
                    });

                AddToInvoices(invoices, journals);

                if (report == GstReport.Input)
                {
                    // Receipts
                    query =
                        "SELECT h.BILL_NO BillNumber, a.SAL_TAX_NO GSTIN, a.NAME CustomerName, " +
                        "h.BILL_NO InvoiceNumber, h.BILL_DT InvoiceDate, " +
                        "'HSN/SAC' HSNSACCode, 0.0 AS Qty, h.EXP_TOT Total, " +
                        "e.TAXCODE, e.TAXNAME, e.TAXAMOUNT " +
                        $"FROM {rcpHdr} AS h " +
                        $"INNER JOIN " +
                        $"(SELECT BILL_NO, EXP_CODE AS TAXCODE, EXP_NAME AS TAXNAME, EXP_AMT AS TAXAMOUNT FROM {rcpExp}) AS e " +
                        $"ON h.BILL_NO=e.BILL_NO " +
                        $"INNER JOIN {acctMast} a ON h.CODE=a.CODE " +
                        $"WHERE e.TAXCODE LIKE 'BI%' AND " +
                        $"BILL_DT >= CTOD('{fromDate:MM/dd/yyyy}') AND " +
                        $"BILL_DT <= CTOD('{toDate:MM/dd/yyyy}') " +
                        "ORDER BY h.BILL_NO";
                    var expenses = con.Query<TaxInput>(query)
                        .ToList();
                    expenses
                        .ForEach(i =>
                        {
                            i.GSTIN = i.GSTIN.Trim();
                            i.CustomerName = i.CustomerName.Trim();
                            i.InvoiceNumber = i.InvoiceNumber.Trim();
                            //i.RefNumber = i.RefNumber.Trim();
                            //i.RefDate = i.RefDate?.Year == 1899 ? null : i.RefDate;
                        });
                    AddToInvoices(invoices, expenses);
                }

                gstInputBindingSource.DataSource = invoices
                    .OrderBy(i => string.IsNullOrWhiteSpace(i.GSTIN) ? 0 : 1)
                    .ThenBy(i => i.InvoiceNumber)
                    .ThenBy(i => i.InvoiceDate)
                    .ToList();
            }
        }

        private void AddToInvoices(List<GstInput> invoices, List<TaxInput> journals)
        {
            if (journals == null || journals.Count == 0)
                return;

            if (journals.Count > 1)
            {
                string billNumber = string.Empty;
                string gstin = string.Empty;
                string customerName = string.Empty;
                string invoiceNumber = string.Empty;
                DateTime? invoiceDate = null;
                string refNumber = string.Empty;
                DateTime? refDate = null;
                decimal qty = 0.0M;
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
                        invoiceDate = item.InvoiceDate.Value.Year == 1899 ? null : item.InvoiceDate;
                        refNumber = item.RefNumber;
                        refDate = item.RefDate;
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
                        {
                            invoices.Add(new GstInput
                            {
                                GSTIN = gstin,
                                CustomerName = customerName,
                                InvoiceNumber = invoiceNumber,
                                InvoiceDate = invoiceDate,
                                RefNumber = refNumber,
                                RefDate = refDate,
                                HSNSACCode = "HSN/SAC",
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

                        // STORE
                        gstin = item.GSTIN.Trim();
                        customerName = item.CustomerName.Trim();
                        invoiceNumber = item.InvoiceNumber.Trim();
                        invoiceDate = item.InvoiceDate.Value.Year == 1899 ? null : item.InvoiceDate;
                        refNumber = item.RefNumber;
                        refDate = item.RefDate;
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
                {
                    invoices.Add(new GstInput
                    {
                        GSTIN = gstin,
                        CustomerName = customerName,
                        InvoiceNumber = invoiceNumber,
                        InvoiceDate = invoiceDate,
                        RefNumber = refNumber,
                        RefDate = refDate,
                        HSNSACCode = "HSN/SAC",
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
            }
        }

        private void PrintGstReport(DateTime dateFrom, DateTime dateTo, List<GstInput> gstInputs)
        {
            using (var rptForm = new ReportForm(SelectedCompany, dateFrom, dateTo, gstInputs))
            {
                rptForm.ShowDialog(this);
            }
        }

        private void LoadReceipts()
        {
        }

        private void LoadPurchases(string fileExtension)
        {
            string fileName = $"INV_HDR.{fileExtension}";
            using (var con = new OleDbConnection(YearConnectionString))
            {
                con.Open();
                string query = "SELECT BILL_NO AS Number, BILL_DT AS Date, REF_NO AS RefNumber, " +
                    "CODE AS PartyCode, NAME AS Party, CITY AS City, TOT_QTY AS TotalQty, " +
                    "SUB_TOT AS Subtotal, NET_AMT AS NetAmount " +
                    $"FROM {fileName} WHERE CAT IN('P','O') AND BILL_DT=CTOD('{dtpDate.Value:MM/dd/yyyy}') " +
                    "ORDER BY BILL_NO";

                var invoices = con.Query<PrintHeader>(query);
                printListItemBindingSource.DataSource = invoices;
            }
        }

        private void PrintTag(PrintHeader printTag, string fileExt)
        {
            //string partyDbf = $"ACCTMAST.{fileExt}";
            //string invoiceDbf = $"INV_HDR.{fileExt}";
            string purchaseDbf = $"PURCHASE.{fileExt}";

            //Party party;
            //SalesHeader salesHeader;
            List<ProductTag> productTags;
            using (var con = new OleDbConnection(YearConnectionString))
            {
                con.Open();
                //string query = "SELECT NAME, ADDRESS, AREA, CITY, PIN AS PinCode, " +
                //    "PHONE, SAL_TAX_NO AS GSTIN " +
                //    $"FROM {partyDbf} WHERE CODE='{printTag.PartyCode}'";
                //party = con.QuerySingle<Party>(query);

                //query = "SELECT BILL_NO AS Number, BILL_DT AS Date, REF_NO AS RefNumber, " +
                //   "TOT_QTY AS TotalQty, SUB_TOT AS Subtotal, " +
                //   "PER_DISC1 AS Disc1Pct, DISCOUNT1 AS Disc1Amt, PER_DISC2 AS Disc2Pct, " +
                //   "PER_SGST AS SGSTPct, SGST AS SGSTAmt, PER_CGST CGSTPct, CGST AS CGSTAmt, " +
                //   "PER_IGST AS IGSTPct, IGST AS IGSTAmt, PARCEL, NET_AMT AS NetAmount, PARTICULAR " +
                //   $"FROM {invoiceDbf} WHERE BILL_NO='{printTag.Number}'";
                //salesHeader = con.QuerySingle<SalesHeader>(query);

                string query = "SELECT SAREE_NO AS TagNumber, GROUP_NAME AS GroupName, " +
                    "ITEM_NAME AS ItemName, COST AS CostPrice, SELL_PRICE AS SellingPrice " +
                    $"FROM {purchaseDbf} WHERE BILL_NO='{printTag.Number}'";
                productTags = con.Query<ProductTag>(query)
                    .ToList();
                foreach (var pt in productTags)
                {
                    pt.UpdatePriceCode(PriceCodeConfig);
                }
            }

            //using (var rptForm = new ReportForm(SelectedCompany.Name, productTags))
            //{
            //    rptForm.ShowDialog(this);
            //}
            using (var rptForm = new CrystalReportsForm(TagRPT, productTags))   // SelectedCompany.Name
            {
                rptForm.ShowDialog(this);
            }
        }

        #endregion Reports
    }

    internal enum GstReport
    {
        Input = 0,
        Output = 1
    }
}