
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
            this.listSplit = new System.Windows.Forms.SplitContainer();
            this.lstMenu = new System.Windows.Forms.ListBox();
            this.contentSplit = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printListItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listSplit)).BeginInit();
            this.listSplit.Panel1.SuspendLayout();
            this.listSplit.Panel2.SuspendLayout();
            this.listSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contentSplit)).BeginInit();
            this.contentSplit.Panel1.SuspendLayout();
            this.contentSplit.Panel2.SuspendLayout();
            this.contentSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printListItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listSplit
            // 
            this.listSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSplit.Location = new System.Drawing.Point(0, 39);
            this.listSplit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listSplit.Name = "listSplit";
            // 
            // listSplit.Panel1
            // 
            this.listSplit.Panel1.Controls.Add(this.lstMenu);
            // 
            // listSplit.Panel2
            // 
            this.listSplit.Panel2.Controls.Add(this.contentSplit);
            this.listSplit.Size = new System.Drawing.Size(1036, 505);
            this.listSplit.SplitterDistance = 203;
            this.listSplit.SplitterWidth = 7;
            this.listSplit.TabIndex = 1;
            // 
            // lstMenu
            // 
            this.lstMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMenu.FormattingEnabled = true;
            this.lstMenu.ItemHeight = 21;
            this.lstMenu.Items.AddRange(new object[] {
            "Invoices",
            "GST Input Report",
            "GST Output Report",
            "Receipts"});
            this.lstMenu.Location = new System.Drawing.Point(0, 0);
            this.lstMenu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(203, 505);
            this.lstMenu.TabIndex = 0;
            this.lstMenu.Click += new System.EventHandler(this.lstMenu_Click);
            // 
            // contentSplit
            // 
            this.contentSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentSplit.Location = new System.Drawing.Point(0, 0);
            this.contentSplit.Name = "contentSplit";
            this.contentSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // contentSplit.Panel1
            // 
            this.contentSplit.Panel1.Controls.Add(this.dataGridView1);
            // 
            // contentSplit.Panel2
            // 
            this.contentSplit.Panel2.Controls.Add(this.dtpDate);
            this.contentSplit.Panel2.Controls.Add(this.btnFirst);
            this.contentSplit.Panel2.Controls.Add(this.btnPrev);
            this.contentSplit.Panel2.Controls.Add(this.btnNext);
            this.contentSplit.Panel2.Controls.Add(this.btnLast);
            this.contentSplit.Panel2.Margin = new System.Windows.Forms.Padding(10);
            this.contentSplit.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.contentSplit.Size = new System.Drawing.Size(826, 505);
            this.contentSplit.SplitterDistance = 453;
            this.contentSplit.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.refNumberDataGridViewTextBoxColumn,
            this.partyDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.totalQtyDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.netAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.printListItemBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(826, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(466, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(146, 29);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.Value = new System.DateTime(2020, 11, 17, 0, 0, 0, 0);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirst.Location = new System.Drawing.Point(264, 4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(95, 32);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.Location = new System.Drawing.Point(365, 4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(95, 32);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(618, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 32);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast.Location = new System.Drawing.Point(719, 4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(95, 32);
            this.btnLast.TabIndex = 0;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(87, 36);
            this.toolStripLabel1.Text = "Company:";
            // 
            // tscCompanies
            // 
            this.tscCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscCompanies.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tscCompanies.Name = "tscCompanies";
            this.tscCompanies.Size = new System.Drawing.Size(300, 39);
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
            this.toolStripLabel2.Size = new System.Drawing.Size(138, 36);
            this.toolStripLabel2.Text = "Accounting Year:";
            // 
            // tscYears
            // 
            this.tscYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscYears.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tscYears.Name = "tscYears";
            this.tscYears.Size = new System.Drawing.Size(150, 39);
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
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tscCompanies,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.tscYears,
            this.toolStripSeparator2,
            this.tsbPrint,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1036, 39);
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
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
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
            this.refNumberDataGridViewTextBoxColumn.HeaderText = "RefNumber";
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
            this.totalQtyDataGridViewTextBoxColumn.HeaderText = "TotalQty";
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
            this.netAmountDataGridViewTextBoxColumn.HeaderText = "NetAmount";
            this.netAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.netAmountDataGridViewTextBoxColumn.Name = "netAmountDataGridViewTextBoxColumn";
            this.netAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.netAmountDataGridViewTextBoxColumn.Width = 110;
            // 
            // printListItemBindingSource
            // 
            this.printListItemBindingSource.DataSource = typeof(Prints.PrintHeader);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 544);
            this.Controls.Add(this.listSplit);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(852, 581);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prints";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.listSplit.Panel1.ResumeLayout(false);
            this.listSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listSplit)).EndInit();
            this.listSplit.ResumeLayout(false);
            this.contentSplit.Panel1.ResumeLayout(false);
            this.contentSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contentSplit)).EndInit();
            this.contentSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printListItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer listSplit;
        private System.Windows.Forms.ListBox lstMenu;
        private System.Windows.Forms.SplitContainer contentSplit;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netAmountDataGridViewTextBoxColumn;
    }
}