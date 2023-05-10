namespace RRCAGApp
{
    partial class InvoiceForm
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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCityProvincePostal = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblInvoiceTitle = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(12, 9);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(361, 38);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "RRC Automotive Group";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(16, 60);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(143, 17);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "777 Inheritance Drive";
            // 
            // lblCityProvincePostal
            // 
            this.lblCityProvincePostal.AutoSize = true;
            this.lblCityProvincePostal.Location = new System.Drawing.Point(16, 86);
            this.lblCityProvincePostal.Name = "lblCityProvincePostal";
            this.lblCityProvincePostal.Size = new System.Drawing.Size(178, 17);
            this.lblCityProvincePostal.TabIndex = 2;
            this.lblCityProvincePostal.Text = "Winnipeg, Manitoba, I0I 0I0";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(16, 114);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(98, 17);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "204-867-5309";
            // 
            // lblInvoiceTitle
            // 
            this.lblInvoiceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceTitle.Location = new System.Drawing.Point(14, 167);
            this.lblInvoiceTitle.Name = "lblInvoiceTitle";
            this.lblInvoiceTitle.Size = new System.Drawing.Size(231, 29);
            this.lblInvoiceTitle.TabIndex = 4;
            this.lblInvoiceTitle.Text = "[Invoice Title]";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.Location = new System.Drawing.Point(699, 15);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(89, 23);
            this.lblInvoiceDate.TabIndex = 5;
            this.lblInvoiceDate.Text = "04/02/2020";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(651, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date:";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.lblInvoiceTitle);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCityProvincePostal);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCompanyName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceForm";
            this.ShowIcon = false;
            this.Text = "[Form Title]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCityProvincePostal;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDate;
        protected internal System.Windows.Forms.Label lblInvoiceDate;
        protected internal System.Windows.Forms.Label lblInvoiceTitle;
    }
}