
namespace Prints
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscCompanies = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tscYears = new System.Windows.Forms.ToolStripComboBox();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDuplicate = new System.Windows.Forms.ToolStripButton();
            this.lstMenu = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGst = new System.Windows.Forms.DataGridView();
            this.gSTINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitNoteNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitNoteDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hSNSACCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beforeTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGSTPctDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGSTAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGSTPctDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGSTAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGSTPctDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGSTAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gstInputBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printListItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.chkFullyear = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gstInputBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printListItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(703, 522);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(114, 27);
            this.dtpDate.TabIndex = 4;
            this.dtpDate.Value = new System.DateTime(2020, 11, 17, 0, 0, 0, 0);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirst.Location = new System.Drawing.Point(547, 522);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(74, 28);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.Location = new System.Drawing.Point(625, 522);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(74, 28);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(821, 522);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 28);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast.Location = new System.Drawing.Point(899, 522);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(74, 28);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(75, 36);
            this.toolStripLabel1.Text = "Company:";
            // 
            // tscCompanies
            // 
            this.tscCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscCompanies.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tscCompanies.Name = "tscCompanies";
            this.tscCompanies.Size = new System.Drawing.Size(234, 39);
            this.tscCompanies.SelectedIndexChanged += new System.EventHandler(this.tscCompanies_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(119, 36);
            this.toolStripLabel2.Text = "Accounting Year:";
            // 
            // tscYears
            // 
            this.tscYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscYears.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tscYears.Name = "tscYears";
            this.tscYears.Size = new System.Drawing.Size(118, 39);
            this.tscYears.SelectedIndexChanged += new System.EventHandler(this.tscYears_SelectedIndexChanged);
            // 
            // tsbPrint
            // 
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrint.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(36, 36);
            this.tsbPrint.Text = "Print";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tscCompanies,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.tscYears,
            this.toolStripSeparator2,
            this.tsbPrint,
            this.toolStripSeparator3,
            this.tsbDuplicate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(984, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbDuplicate
            // 
            this.tsbDuplicate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDuplicate.Image = ((System.Drawing.Image)(resources.GetObject("tsbDuplicate.Image")));
            this.tsbDuplicate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDuplicate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDuplicate.Name = "tsbDuplicate";
            this.tsbDuplicate.Size = new System.Drawing.Size(36, 36);
            this.tsbDuplicate.Text = "Duplicate";
            this.tsbDuplicate.Visible = false;
            this.tsbDuplicate.Click += new System.EventHandler(this.tsbDuplicate_Click);
            // 
            // lstMenu
            // 
            this.lstMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstMenu.FormattingEnabled = true;
            this.lstMenu.IntegralHeight = false;
            this.lstMenu.ItemHeight = 20;
            this.lstMenu.Items.AddRange(new object[] {
            "Invoices",
            "GST Input Report",
            "GST Output Report",
            "Tag Printing"});
            this.lstMenu.Location = new System.Drawing.Point(13, 44);
            this.lstMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(190, 503);
            this.lstMenu.TabIndex = 1;
            this.lstMenu.SelectedIndexChanged += new System.EventHandler(this.lstMenu_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvGst);
            this.groupBox1.Controls.Add(this.dgvInvoices);
            this.groupBox1.Location = new System.Drawing.Point(210, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 473);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // dgvGst
            // 
            this.dgvGst.AllowUserToAddRows = false;
            this.dgvGst.AllowUserToDeleteRows = false;
            this.dgvGst.AutoGenerateColumns = false;
            this.dgvGst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gSTINDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.invoiceNumberDataGridViewTextBoxColumn,
            this.invoiceDateDataGridViewTextBoxColumn,
            this.debitNoteNumberDataGridViewTextBoxColumn,
            this.debitNoteDateDataGridViewTextBoxColumn,
            this.hSNSACCodeDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.beforeTaxDataGridViewTextBoxColumn,
            this.iGSTPctDataGridViewTextBoxColumn,
            this.iGSTAmtDataGridViewTextBoxColumn,
            this.cGSTPctDataGridViewTextBoxColumn,
            this.cGSTAmtDataGridViewTextBoxColumn,
            this.sGSTPctDataGridViewTextBoxColumn,
            this.sGSTAmtDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgvGst.DataSource = this.gstInputBindingSource;
            this.dgvGst.Location = new System.Drawing.Point(44, 74);
            this.dgvGst.Name = "dgvGst";
            this.dgvGst.ReadOnly = true;
            this.dgvGst.RowHeadersWidth = 51;
            this.dgvGst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGst.Size = new System.Drawing.Size(607, 373);
            this.dgvGst.TabIndex = 1;
            this.dgvGst.Visible = false;
            // 
            // gSTINDataGridViewTextBoxColumn
            // 
            this.gSTINDataGridViewTextBoxColumn.DataPropertyName = "GSTIN";
            this.gSTINDataGridViewTextBoxColumn.HeaderText = "GSTIN";
            this.gSTINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gSTINDataGridViewTextBoxColumn.Name = "gSTINDataGridViewTextBoxColumn";
            this.gSTINDataGridViewTextBoxColumn.ReadOnly = true;
            this.gSTINDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // invoiceNumberDataGridViewTextBoxColumn
            // 
            this.invoiceNumberDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNumber";
            this.invoiceNumberDataGridViewTextBoxColumn.HeaderText = "Invoice No.";
            this.invoiceNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.invoiceNumberDataGridViewTextBoxColumn.Name = "invoiceNumberDataGridViewTextBoxColumn";
            this.invoiceNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // invoiceDateDataGridViewTextBoxColumn
            // 
            this.invoiceDateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.HeaderText = "Invoice Date";
            this.invoiceDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.invoiceDateDataGridViewTextBoxColumn.Name = "invoiceDateDataGridViewTextBoxColumn";
            this.invoiceDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // debitNoteNumberDataGridViewTextBoxColumn
            // 
            this.debitNoteNumberDataGridViewTextBoxColumn.DataPropertyName = "RefNumber";
            this.debitNoteNumberDataGridViewTextBoxColumn.HeaderText = "Ref.Number";
            this.debitNoteNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.debitNoteNumberDataGridViewTextBoxColumn.Name = "debitNoteNumberDataGridViewTextBoxColumn";
            this.debitNoteNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.debitNoteNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // debitNoteDateDataGridViewTextBoxColumn
            // 
            this.debitNoteDateDataGridViewTextBoxColumn.DataPropertyName = "RefDate";
            this.debitNoteDateDataGridViewTextBoxColumn.HeaderText = "Ref.Date";
            this.debitNoteDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.debitNoteDateDataGridViewTextBoxColumn.Name = "debitNoteDateDataGridViewTextBoxColumn";
            this.debitNoteDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.debitNoteDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // hSNSACCodeDataGridViewTextBoxColumn
            // 
            this.hSNSACCodeDataGridViewTextBoxColumn.DataPropertyName = "HSNSACCode";
            this.hSNSACCodeDataGridViewTextBoxColumn.HeaderText = "HSNSAC Code";
            this.hSNSACCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hSNSACCodeDataGridViewTextBoxColumn.Name = "hSNSACCodeDataGridViewTextBoxColumn";
            this.hSNSACCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.hSNSACCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // beforeTaxDataGridViewTextBoxColumn
            // 
            this.beforeTaxDataGridViewTextBoxColumn.DataPropertyName = "BeforeTax";
            this.beforeTaxDataGridViewTextBoxColumn.HeaderText = "Before Tax";
            this.beforeTaxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.beforeTaxDataGridViewTextBoxColumn.Name = "beforeTaxDataGridViewTextBoxColumn";
            this.beforeTaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.beforeTaxDataGridViewTextBoxColumn.Width = 125;
            // 
            // iGSTPctDataGridViewTextBoxColumn
            // 
            this.iGSTPctDataGridViewTextBoxColumn.DataPropertyName = "IGSTPct";
            this.iGSTPctDataGridViewTextBoxColumn.HeaderText = "IGST %";
            this.iGSTPctDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iGSTPctDataGridViewTextBoxColumn.Name = "iGSTPctDataGridViewTextBoxColumn";
            this.iGSTPctDataGridViewTextBoxColumn.ReadOnly = true;
            this.iGSTPctDataGridViewTextBoxColumn.Width = 125;
            // 
            // iGSTAmtDataGridViewTextBoxColumn
            // 
            this.iGSTAmtDataGridViewTextBoxColumn.DataPropertyName = "IGSTAmt";
            this.iGSTAmtDataGridViewTextBoxColumn.HeaderText = "IGST Amount";
            this.iGSTAmtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iGSTAmtDataGridViewTextBoxColumn.Name = "iGSTAmtDataGridViewTextBoxColumn";
            this.iGSTAmtDataGridViewTextBoxColumn.ReadOnly = true;
            this.iGSTAmtDataGridViewTextBoxColumn.Width = 125;
            // 
            // cGSTPctDataGridViewTextBoxColumn
            // 
            this.cGSTPctDataGridViewTextBoxColumn.DataPropertyName = "CGSTPct";
            this.cGSTPctDataGridViewTextBoxColumn.HeaderText = "CGST %";
            this.cGSTPctDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cGSTPctDataGridViewTextBoxColumn.Name = "cGSTPctDataGridViewTextBoxColumn";
            this.cGSTPctDataGridViewTextBoxColumn.ReadOnly = true;
            this.cGSTPctDataGridViewTextBoxColumn.Width = 125;
            // 
            // cGSTAmtDataGridViewTextBoxColumn
            // 
            this.cGSTAmtDataGridViewTextBoxColumn.DataPropertyName = "CGSTAmt";
            this.cGSTAmtDataGridViewTextBoxColumn.HeaderText = "CGST Amount";
            this.cGSTAmtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cGSTAmtDataGridViewTextBoxColumn.Name = "cGSTAmtDataGridViewTextBoxColumn";
            this.cGSTAmtDataGridViewTextBoxColumn.ReadOnly = true;
            this.cGSTAmtDataGridViewTextBoxColumn.Width = 125;
            // 
            // sGSTPctDataGridViewTextBoxColumn
            // 
            this.sGSTPctDataGridViewTextBoxColumn.DataPropertyName = "SGSTPct";
            this.sGSTPctDataGridViewTextBoxColumn.HeaderText = "SGST %";
            this.sGSTPctDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sGSTPctDataGridViewTextBoxColumn.Name = "sGSTPctDataGridViewTextBoxColumn";
            this.sGSTPctDataGridViewTextBoxColumn.ReadOnly = true;
            this.sGSTPctDataGridViewTextBoxColumn.Width = 125;
            // 
            // sGSTAmtDataGridViewTextBoxColumn
            // 
            this.sGSTAmtDataGridViewTextBoxColumn.DataPropertyName = "SGSTAmt";
            this.sGSTAmtDataGridViewTextBoxColumn.HeaderText = "SGST Amount";
            this.sGSTAmtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sGSTAmtDataGridViewTextBoxColumn.Name = "sGSTAmtDataGridViewTextBoxColumn";
            this.sGSTAmtDataGridViewTextBoxColumn.ReadOnly = true;
            this.sGSTAmtDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // gstInputBindingSource
            // 
            this.gstInputBindingSource.DataSource = typeof(Prints.Tax);
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AllowUserToOrderColumns = true;
            this.dgvInvoices.AutoGenerateColumns = false;
            this.dgvInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.refNumberDataGridViewTextBoxColumn,
            this.partyDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.totalQtyDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.netAmountDataGridViewTextBoxColumn});
            this.dgvInvoices.DataSource = this.printListItemBindingSource;
            this.dgvInvoices.Location = new System.Drawing.Point(5, 23);
            this.dgvInvoices.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.RowHeadersWidth = 45;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(578, 384);
            this.dgvInvoices.TabIndex = 0;
            this.dgvInvoices.Visible = false;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Invoice No.";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 110;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 110;
            // 
            // refNumberDataGridViewTextBoxColumn
            // 
            this.refNumberDataGridViewTextBoxColumn.DataPropertyName = "RefNumber";
            this.refNumberDataGridViewTextBoxColumn.HeaderText = "Ref.No.";
            this.refNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.refNumberDataGridViewTextBoxColumn.Name = "refNumberDataGridViewTextBoxColumn";
            this.refNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.refNumberDataGridViewTextBoxColumn.Width = 110;
            // 
            // partyDataGridViewTextBoxColumn
            // 
            this.partyDataGridViewTextBoxColumn.DataPropertyName = "Party";
            this.partyDataGridViewTextBoxColumn.HeaderText = "Party";
            this.partyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partyDataGridViewTextBoxColumn.Name = "partyDataGridViewTextBoxColumn";
            this.partyDataGridViewTextBoxColumn.ReadOnly = true;
            this.partyDataGridViewTextBoxColumn.Width = 200;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Width = 110;
            // 
            // totalQtyDataGridViewTextBoxColumn
            // 
            this.totalQtyDataGridViewTextBoxColumn.DataPropertyName = "TotalQty";
            this.totalQtyDataGridViewTextBoxColumn.HeaderText = "Total Qty";
            this.totalQtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalQtyDataGridViewTextBoxColumn.Name = "totalQtyDataGridViewTextBoxColumn";
            this.totalQtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalQtyDataGridViewTextBoxColumn.Width = 110;
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            this.subtotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.subtotalDataGridViewTextBoxColumn.Width = 110;
            // 
            // netAmountDataGridViewTextBoxColumn
            // 
            this.netAmountDataGridViewTextBoxColumn.DataPropertyName = "NetAmount";
            this.netAmountDataGridViewTextBoxColumn.HeaderText = "Net Amount";
            this.netAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.netAmountDataGridViewTextBoxColumn.Name = "netAmountDataGridViewTextBoxColumn";
            this.netAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.netAmountDataGridViewTextBoxColumn.Width = 110;
            // 
            // printListItemBindingSource
            // 
            this.printListItemBindingSource.DataSource = typeof(Prints.PrintHeader);
            // 
            // cboMonth
            // 
            this.cboMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December",
            "January",
            "February",
            "March"});
            this.cboMonth.Location = new System.Drawing.Point(428, 522);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(114, 28);
            this.cboMonth.TabIndex = 8;
            this.cboMonth.Visible = false;
            this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.cboMonth_SelectedIndexChanged);
            // 
            // chkFullyear
            // 
            this.chkFullyear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkFullyear.AutoSize = true;
            this.chkFullyear.Location = new System.Drawing.Point(210, 521);
            this.chkFullyear.Name = "chkFullyear";
            this.chkFullyear.Size = new System.Drawing.Size(162, 24);
            this.chkFullyear.TabIndex = 9;
            this.chkFullyear.Text = "Full Accounting Year";
            this.chkFullyear.UseVisualStyleBackColor = true;
            this.chkFullyear.Visible = false;
            this.chkFullyear.CheckedChanged += new System.EventHandler(this.chkFullyear_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.chkFullyear);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lstMenu);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(666, 478);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prints";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gstInputBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printListItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tscCompanies;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox tscYears;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.BindingSource printListItemBindingSource;
        private System.Windows.Forms.BindingSource gstInputBindingSource;
        private System.Windows.Forms.ListBox lstMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGst;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSTINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitNoteNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitNoteDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hSNSACCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beforeTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGSTPctDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGSTAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGSTPctDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGSTAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGSTPctDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGSTAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox chkFullyear;
        private System.Windows.Forms.ToolStripButton tsbDuplicate;
    }
}