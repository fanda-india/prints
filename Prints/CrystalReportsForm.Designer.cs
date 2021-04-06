
namespace Prints
{
    partial class CrystalReportsForm
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tagPrinting2 = new Prints.TagPrinting2();
            this.tagKbSilks = new Prints.TagKbSilks();
            this.invoiceRagu1 = new Prints.InvoiceRagu();
            this.tagKBS1 = new Prints.TagKBS();
            this.invoiceRaguDuplicate1 = new Prints.InvoiceRaguDuplicate();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.tagPrinting2;
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tagPrinting2
            // 
            this.tagPrinting2.FileName = "rassdk://C:\\Users\\tbala\\AppData\\Local\\Temp\\temp_c72d13f7-918d-46d1-8082-da8d390a5" +
    "045.rpt";
            // 
            // CrystalReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "CrystalReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tag Printing";
            this.Load += new System.EventHandler(this.CrystalReportsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        //private TagPrinting tagPrinting;
        private TagPrinting2 tagPrinting2;
        private TagKbSilks tagKbSilks;
        private InvoiceRagu invoiceRagu1;
        private TagKBS tagKBS1;
        private InvoiceRaguDuplicate invoiceRaguDuplicate1;
    }
}