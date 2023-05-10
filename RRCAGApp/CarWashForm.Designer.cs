namespace RRCAGApp
{
    partial class CarWashForm
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
            this.mnuCarWash = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPackage = new System.Windows.Forms.Label();
            this.lblFragrance = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstExterior = new System.Windows.Forms.ListBox();
            this.lblExterior = new System.Windows.Forms.Label();
            this.lstInterior = new System.Windows.Forms.ListBox();
            this.lblInterior = new System.Windows.Forms.Label();
            this.cboPackage = new System.Windows.Forms.ComboBox();
            this.cboFragrance = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblPST = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.lblGST = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.mnuCarWash.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuCarWash
            // 
            this.mnuCarWash.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuCarWash.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuCarWash.Location = new System.Drawing.Point(0, 0);
            this.mnuCarWash.Name = "mnuCarWash";
            this.mnuCarWash.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.mnuCarWash.Size = new System.Drawing.Size(474, 28);
            this.mnuCarWash.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateInvoiceToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // generateInvoiceToolStripMenuItem
            // 
            this.generateInvoiceToolStripMenuItem.Name = "generateInvoiceToolStripMenuItem";
            this.generateInvoiceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.generateInvoiceToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.generateInvoiceToolStripMenuItem.Text = "Generate &Invoice";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(286, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(27, 53);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(70, 18);
            this.lblPackage.TabIndex = 0;
            this.lblPackage.Text = "Package:";
            // 
            // lblFragrance
            // 
            this.lblFragrance.AutoSize = true;
            this.lblFragrance.Location = new System.Drawing.Point(250, 53);
            this.lblFragrance.Name = "lblFragrance";
            this.lblFragrance.Size = new System.Drawing.Size(79, 18);
            this.lblFragrance.TabIndex = 0;
            this.lblFragrance.Text = "Fragrance:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstExterior);
            this.groupBox1.Controls.Add(this.lblExterior);
            this.groupBox1.Controls.Add(this.lstInterior);
            this.groupBox1.Controls.Add(this.lblInterior);
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // lstExterior
            // 
            this.lstExterior.Enabled = false;
            this.lstExterior.FormattingEnabled = true;
            this.lstExterior.ItemHeight = 18;
            this.lstExterior.Location = new System.Drawing.Point(241, 64);
            this.lstExterior.Name = "lstExterior";
            this.lstExterior.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstExterior.Size = new System.Drawing.Size(180, 112);
            this.lstExterior.Sorted = true;
            this.lstExterior.TabIndex = 0;
            this.lstExterior.TabStop = false;
            // 
            // lblExterior
            // 
            this.lblExterior.AutoSize = true;
            this.lblExterior.Location = new System.Drawing.Point(238, 36);
            this.lblExterior.Name = "lblExterior";
            this.lblExterior.Size = new System.Drawing.Size(63, 18);
            this.lblExterior.TabIndex = 0;
            this.lblExterior.Text = "Exterior:";
            // 
            // lstInterior
            // 
            this.lstInterior.Enabled = false;
            this.lstInterior.FormattingEnabled = true;
            this.lstInterior.ItemHeight = 18;
            this.lstInterior.Location = new System.Drawing.Point(18, 64);
            this.lstInterior.Name = "lstInterior";
            this.lstInterior.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstInterior.Size = new System.Drawing.Size(180, 112);
            this.lstInterior.Sorted = true;
            this.lstInterior.TabIndex = 0;
            this.lstInterior.TabStop = false;
            // 
            // lblInterior
            // 
            this.lblInterior.AutoSize = true;
            this.lblInterior.Location = new System.Drawing.Point(15, 36);
            this.lblInterior.Name = "lblInterior";
            this.lblInterior.Size = new System.Drawing.Size(57, 18);
            this.lblInterior.TabIndex = 0;
            this.lblInterior.Text = "Interior:";
            // 
            // cboPackage
            // 
            this.cboPackage.BackColor = System.Drawing.SystemColors.Window;
            this.cboPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPackage.FormattingEnabled = true;
            this.cboPackage.Location = new System.Drawing.Point(30, 86);
            this.cboPackage.Name = "cboPackage";
            this.cboPackage.Size = new System.Drawing.Size(180, 26);
            this.cboPackage.TabIndex = 1;
            // 
            // cboFragrance
            // 
            this.cboFragrance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFragrance.FormattingEnabled = true;
            this.cboFragrance.Location = new System.Drawing.Point(252, 86);
            this.cboFragrance.Name = "cboFragrance";
            this.cboFragrance.Size = new System.Drawing.Size(180, 26);
            this.cboFragrance.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "PST:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "GST:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSubtotal.Location = new System.Drawing.Point(332, 380);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(124, 25);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPST
            // 
            this.lblPST.BackColor = System.Drawing.SystemColors.Control;
            this.lblPST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPST.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPST.Location = new System.Drawing.Point(332, 416);
            this.lblPST.Name = "lblPST";
            this.lblPST.Size = new System.Drawing.Size(124, 25);
            this.lblPST.TabIndex = 0;
            this.lblPST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(250, 387);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(66, 18);
            this.label0.TabIndex = 0;
            this.label0.Text = "Subtotal:";
            // 
            // lblGST
            // 
            this.lblGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGST.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGST.Location = new System.Drawing.Point(332, 452);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(124, 25);
            this.lblGST.TabIndex = 0;
            this.lblGST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.Location = new System.Drawing.Point(332, 488);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(124, 25);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CarWashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 533);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblGST);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.lblPST);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboFragrance);
            this.Controls.Add(this.cboPackage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFragrance);
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.mnuCarWash);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuCarWash;
            this.MaximizeBox = false;
            this.Name = "CarWashForm";
            this.ShowIcon = false;
            this.Text = "Car Wash";
            this.mnuCarWash.ResumeLayout(false);
            this.mnuCarWash.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCarWash;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Label lblFragrance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboPackage;
        private System.Windows.Forms.ComboBox cboFragrance;
        private System.Windows.Forms.ListBox lstExterior;
        private System.Windows.Forms.Label lblExterior;
        private System.Windows.Forms.ListBox lstInterior;
        private System.Windows.Forms.Label lblInterior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblPST;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ToolStripMenuItem generateInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}