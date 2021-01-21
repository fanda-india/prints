
namespace Prints
{
    partial class TagPrintingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.updCols = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.updHeight = new System.Windows.Forms.NumericUpDown();
            this.updWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Columns:";
            // 
            // updCols
            // 
            this.updCols.Location = new System.Drawing.Point(76, 12);
            this.updCols.Name = "updCols";
            this.updCols.Size = new System.Drawing.Size(118, 23);
            this.updCols.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size:";
            // 
            // updHeight
            // 
            this.updHeight.Location = new System.Drawing.Point(138, 42);
            this.updHeight.Name = "updHeight";
            this.updHeight.Size = new System.Drawing.Size(56, 23);
            this.updHeight.TabIndex = 3;
            // 
            // updWidth
            // 
            this.updWidth.Location = new System.Drawing.Point(76, 42);
            this.updWidth.Name = "updWidth";
            this.updWidth.Size = new System.Drawing.Size(56, 23);
            this.updWidth.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "(in inches)";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(29, 96);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(110, 96);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TagPrintingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(209, 127);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updWidth);
            this.Controls.Add(this.updHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updCols);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TagPrintingForm";
            this.Text = "Tag Printing";
            ((System.ComponentModel.ISupportInitialize)(this.updCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown updCols;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown updHeight;
        private System.Windows.Forms.NumericUpDown updWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}