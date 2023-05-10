/******************************************
* Name: Jason Chuy
* Course: BIT, Programming 2, Section 1
* Date Created: April 5, 2020
* Date Last Edited: April 14, 2020
*******************************************/

/**
* CarWashInvoiceForm: Displays an invoice for a carwash.
*
* @author Jason Chuy
* @version 1.0
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chuy.Jason.Business;

namespace RRCAGApp
{
    public partial class CarWashInvoiceForm : InvoiceForm
    {
        private CarWashInvoice carWashInvoice;
        BindingSource bindingSource;

        public CarWashInvoiceForm(CarWashInvoice p)
        {
            InitializeComponent();
            carWashInvoice = p;

            this.bindingSource = new BindingSource();

            BindControls();
            UpdateLabels();
        }

        /// <summary>
        /// Updates the title, date and taxes labels.
        /// </summary>
        private void UpdateLabels()
        {
            decimal taxesCharged = carWashInvoice.ProvincialSalesTaxCharged + carWashInvoice.GoodsAndServicesTaxCharged;
            
            lblInvoiceTitle.Text = "Car Wash Invoice";
            lblInvoiceDate.Text = Convert.ToString(DateTime.Now);

            lblTaxesOutput.Text = (taxesCharged).ToString("N");
        }


        /// <summary>
        /// Handles the databinding and formatting for the CarWashInvoiceForm.
        /// </summary>
        private void BindControls()
        {
            this.bindingSource.DataSource = carWashInvoice;

            Binding packagePriceBinding = new Binding("Text", bindingSource, "PackageCost");
            Binding fragrancePriceBinding = new Binding("Text", bindingSource, "FragranceCost");
            Binding subTotalBinding = new Binding("Text", bindingSource, "Subtotal");
            Binding totalBinding = new Binding("Text", bindingSource, "Total");

            lblPackagePriceOutput.DataBindings.Add(packagePriceBinding);
            lblFragrancePriceOutput.DataBindings.Add(fragrancePriceBinding);
            lblSubtotalOutput.DataBindings.Add(subTotalBinding);
            lblTotalOutput.DataBindings.Add(totalBinding);

            packagePriceBinding.FormattingEnabled = true;
            fragrancePriceBinding.FormattingEnabled = true;
            subTotalBinding.FormattingEnabled = true;
            totalBinding.FormattingEnabled = true;

            packagePriceBinding.FormatString = "C";
            fragrancePriceBinding.FormatString = "N";
            subTotalBinding.FormatString = "C";
            totalBinding.FormatString = "C";

        }
    }
}
