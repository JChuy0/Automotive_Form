/******************************************
* Name: Jason Chuy
* Course: BIT, Programming 2, Section 1
* Date Created: April 5, 2020
* Date Last Edited: April 19, 2020
*******************************************/

/**
* VehicleInformationForm: Displays data on the selected vehicle.
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
using System.Diagnostics;

namespace RRCAGApp
{
    public partial class VehicleInformationForm : Form
    {
        BindingSource vehicleBindingSource;
        VehicleInformationForm vehicleInformationForm;

        public VehicleInformationForm(BindingSource p)
        {
            InitializeComponent();

            this.btnClose.Click += BtnClose_Click;

            vehicleBindingSource = new BindingSource();
            vehicleBindingSource = p;

            BindControls();


            // Converts the current row of the binding source into a data row view object.
            // Then evaluates the value from the "Automatic" column and displays the correct text in the transmission label.
            DataRowView dataRowView = (DataRowView)vehicleBindingSource.Current;

            if (dataRowView.Row["Automatic"].Equals(true))
            {
                lblTransmissionOutput.Text = "Automatic";
            }
            else
            {
                lblTransmissionOutput.Text = "Manual";
            }
            
        }


        /// <summary>
        /// Used to set the title of the VehicleInformationForm.
        /// </summary>
        public VehicleInformationForm VehicleInfoForm
        {
            set
            {
                vehicleInformationForm = value;
            }
        }


        /// <summary>
        /// Closes the VehicleInformationForm.
        /// </summary>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Handles the databinding and formatting for the CarWashForm.
        /// </summary>
        private void BindControls()
        {
            Binding stockIdBinding = new Binding("Text", vehicleBindingSource, "StockNumber");
            Binding yearBinding = new Binding("Text", vehicleBindingSource, "ManufacturedYear");
            Binding manufacturerBinding = new Binding("Text", vehicleBindingSource, "Make");
            Binding modelBinding = new Binding("Text", vehicleBindingSource, "Model");
            Binding mileageBinding = new Binding("Text", vehicleBindingSource, "Mileage");
            Binding colourBinding = new Binding("Text", vehicleBindingSource, "Colour");
            Binding basePriceBinding = new Binding("Text", vehicleBindingSource, "BasePrice");

            lblStockIDOutput.DataBindings.Add(stockIdBinding);
            lblYearOutput.DataBindings.Add(yearBinding);
            lblManufacturerOutput.DataBindings.Add(manufacturerBinding);
            lblModelOutput.DataBindings.Add(modelBinding);
            lblMileageOutput.DataBindings.Add(mileageBinding);
            lblColourOutput.DataBindings.Add(colourBinding);
            lblBasePriceOutput.DataBindings.Add(basePriceBinding);

            stockIdBinding.FormattingEnabled = true;
            yearBinding.FormattingEnabled = true;
            manufacturerBinding.FormattingEnabled = true;
            modelBinding.FormattingEnabled = true;
            mileageBinding.FormattingEnabled = true;
            colourBinding.FormattingEnabled = true;
            basePriceBinding.FormattingEnabled = true;

            mileageBinding.FormatString = "N0";
            basePriceBinding.FormatString = "C";
        }
    }
}
