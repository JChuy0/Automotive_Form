namespace RRCAGApp
{
    partial class CarWashInvoiceForm
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
            this.lblPackagePrice = new System.Windows.Forms.Label();
            this.lblPackagePriceOutput = new System.Windows.Forms.Label();
            this.lblFragrancePrice = new System.Windows.Forms.Label();
            this.lblFragrancePriceOutput = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotalOutput = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTaxesOutput = new System.Windows.Forms.Label();
            this.lblTaxes = new System.Windows.Forms.Label();
            this.lblTotalOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPackagePrice
            // 
            this.lblPackagePrice.AutoSize = true;
            this.lblPackagePrice.Location = new System.Drawing.Point(542, 281);
            this.lblPackagePrice.Name = "lblPackagePrice";
            this.lblPackagePrice.Size = new System.Drawing.Size(103, 17);
            this.lblPackagePrice.TabIndex = 7;
            this.lblPackagePrice.Text = "Package Price:";
            // 
            // lblPackagePriceOutput
            // 
            this.lblPackagePriceOutput.Location = new System.Drawing.Point(651, 274);
            this.lblPackagePriceOutput.Name = "lblPackagePriceOutput";
            this.lblPackagePriceOutput.Size = new System.Drawing.Size(135, 30);
            this.lblPackagePriceOutput.TabIndex = 8;
            this.lblPackagePriceOutput.Text = "[PackagePrice]";
            this.lblPackagePriceOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFragrancePrice
            // 
            this.lblFragrancePrice.AutoSize = true;
            this.lblFragrancePrice.Location = new System.Drawing.Point(532, 311);
            this.lblFragrancePrice.Name = "lblFragrancePrice";
            this.lblFragrancePrice.Size = new System.Drawing.Size(113, 17);
            this.lblFragrancePrice.TabIndex = 9;
            this.lblFragrancePrice.Text = "Fragrance Price:";
            // 
            // lblFragrancePriceOutput
            // 
            this.lblFragrancePriceOutput.Location = new System.Drawing.Point(651, 304);
            this.lblFragrancePriceOutput.Name = "lblFragrancePriceOutput";
            this.lblFragrancePriceOutput.Size = new System.Drawing.Size(135, 30);
            this.lblFragrancePriceOutput.TabIndex = 10;
            this.lblFragrancePriceOutput.Text = "[Fragrance Price]";
            this.lblFragrancePriceOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(601, 401);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total:";
            // 
            // lblSubtotalOutput
            // 
            this.lblSubtotalOutput.Location = new System.Drawing.Point(651, 334);
            this.lblSubtotalOutput.Name = "lblSubtotalOutput";
            this.lblSubtotalOutput.Size = new System.Drawing.Size(135, 30);
            this.lblSubtotalOutput.TabIndex = 12;
            this.lblSubtotalOutput.Text = "[Subtotal]";
            this.lblSubtotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(581, 341);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(64, 17);
            this.lblSubtotal.TabIndex = 13;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblTaxesOutput
            // 
            this.lblTaxesOutput.Location = new System.Drawing.Point(651, 364);
            this.lblTaxesOutput.Name = "lblTaxesOutput";
            this.lblTaxesOutput.Size = new System.Drawing.Size(135, 30);
            this.lblTaxesOutput.TabIndex = 14;
            this.lblTaxesOutput.Text = "[Taxes]";
            this.lblTaxesOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaxes
            // 
            this.lblTaxes.AutoSize = true;
            this.lblTaxes.Location = new System.Drawing.Point(595, 371);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(50, 17);
            this.lblTaxes.TabIndex = 15;
            this.lblTaxes.Text = "Taxes:";
            // 
            // lblTotalOutput
            // 
            this.lblTotalOutput.Location = new System.Drawing.Point(651, 394);
            this.lblTotalOutput.Name = "lblTotalOutput";
            this.lblTotalOutput.Size = new System.Drawing.Size(135, 30);
            this.lblTotalOutput.TabIndex = 16;
            this.lblTotalOutput.Text = "[Total]";
            this.lblTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CarWashInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalOutput);
            this.Controls.Add(this.lblTaxes);
            this.Controls.Add(this.lblTaxesOutput);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblSubtotalOutput);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFragrancePriceOutput);
            this.Controls.Add(this.lblFragrancePrice);
            this.Controls.Add(this.lblPackagePriceOutput);
            this.Controls.Add(this.lblPackagePrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CarWashInvoiceForm";
            this.Text = "Car Wash Invoice";
            this.Controls.SetChildIndex(this.lblInvoiceTitle, 0);
            this.Controls.SetChildIndex(this.lblInvoiceDate, 0);
            this.Controls.SetChildIndex(this.lblPackagePrice, 0);
            this.Controls.SetChildIndex(this.lblPackagePriceOutput, 0);
            this.Controls.SetChildIndex(this.lblFragrancePrice, 0);
            this.Controls.SetChildIndex(this.lblFragrancePriceOutput, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.lblSubtotalOutput, 0);
            this.Controls.SetChildIndex(this.lblSubtotal, 0);
            this.Controls.SetChildIndex(this.lblTaxesOutput, 0);
            this.Controls.SetChildIndex(this.lblTaxes, 0);
            this.Controls.SetChildIndex(this.lblTotalOutput, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPackagePrice;
        private System.Windows.Forms.Label lblPackagePriceOutput;
        private System.Windows.Forms.Label lblFragrancePrice;
        private System.Windows.Forms.Label lblFragrancePriceOutput;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotalOutput;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTaxesOutput;
        private System.Windows.Forms.Label lblTaxes;
        private System.Windows.Forms.Label lblTotalOutput;
    }
}