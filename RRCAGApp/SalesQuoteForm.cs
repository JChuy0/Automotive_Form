/******************************************
* Name: Jason Chuy
* Course: BIT, Programming 2, Section 1
* Date Created: March 16, 2020
* Date Last Edited: April 19, 2020
*******************************************/

/**
* VehicleSalesQuote: The program will give the user a sales quote for a new vehicle based on the options they chose.
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
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chuy.Jason.Business;
using RRCAG.Data;

namespace RRCAGApp
{
    public partial class SalesQuoteForm : Form
    {
        private BindingSource vehicleBindingSource;
        private DataSet dataSet;
        private DataTable vehicleTable;

        public SalesQuoteForm(DataSet p)
        {
            InitializeComponent();

            this.dataSet = new DataSet();
            this.dataSet = p;

            vehicleTable = dataSet.Tables["VehicleStock"];

            this.vehicleBindingSource = new BindingSource();
            

            this.closeToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            this.vehicleInformationToolStripMenuItem.Click += VehicleInformationToolStripMenuItem_Click;

            this.vehicleBindingSource.PositionChanged += UserInput_ContentsChanged;
            this.txtTradeInValue.TextChanged += UserInput_ContentsChanged;

            this.btnCalculateQuote.Click += BtnCalculateQuote_Click;
            this.btnReset.Click += BtnReset_Click;

            this.chkStereoSystem.CheckedChanged += Options_Changed;
            this.chkLeatherInterior.CheckedChanged += Options_Changed;
            this.chkComputerNavigation.CheckedChanged += Options_Changed;

            this.radStandard.CheckedChanged += Options_Changed;
            this.radPearlized.CheckedChanged += Options_Changed;
            this.radCustomizedDetailing.CheckedChanged += Options_Changed;

            this.nudNoOfYears.ValueChanged += Options_Changed;
            this.nudAnnualInterestRate.ValueChanged += Options_Changed;

            BindControls();
            this.cboVehicle.SelectedIndex = -1;

        }


        /// <summary>
        /// Closes the SalesQuoteForm.
        /// </summary>
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Creates and displays a new instance of the VehicleInformationForm.
        /// </summary>
        private void VehicleInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string stocknumber = vehicleTable.Rows[cboVehicle.SelectedIndex]["StockNumber"].ToString(),
               year = vehicleTable.Rows[cboVehicle.SelectedIndex]["ManufacturedYear"].ToString(),
               make = vehicleTable.Rows[cboVehicle.SelectedIndex]["Make"].ToString(),
               model = vehicleTable.Rows[cboVehicle.SelectedIndex]["Model"].ToString();

            VehicleInformationForm vehicleInformationForm = new VehicleInformationForm(vehicleBindingSource);
            vehicleInformationForm.Text = $"{stocknumber} - {year} {make} {model}";
            vehicleInformationForm.ShowDialog();
        }


        /// <summary>
        /// Creates and returns a instance of the SalesQuote class.
        /// </summary>
        /// <returns>Return: An instance of the SalesQuote class.</returns>
        private SalesQuote CreateNewQuote()
        {
            decimal vehiclePrice = (decimal)(double)(vehicleTable.Rows[cboVehicle.SelectedIndex]["BasePrice"]),
                    tradeInAmount = Convert.ToDecimal(txtTradeInValue.Text),
                    salesTaxRate = 0.13m;

            SalesQuote testQuote = new SalesQuote(vehiclePrice, tradeInAmount, salesTaxRate);

            return testQuote;
        }


        /// <summary>
        /// Clears all of the summary and finance textboxes when the contents of a textbox changes.
        /// </summary>
        private void UserInput_ContentsChanged(object sender, EventArgs e)
        {
            ClearLabels();

            if(cboVehicle.SelectedIndex >= 0)
            {
                vehicleInformationToolStripMenuItem.Enabled = true;
            }
        }

        /// <summary>
        /// Updates the summary and finance labels when the value for the accessory checkboxes, 
        ///     exteriorfinish radio buttons, or finance number up/downs changes.
        /// </summary>
        private void Options_Changed(object sender, EventArgs e)
        {
            UpdateAll();
        }


        /// <summary>
        /// When the calc button is clicked, it attempts to validate vehiclesaleprice and tradein.
        ///     If validation is successful, a new salesquote object is created and the summary and finance labels are updated.
        /// </summary>
        private void BtnCalculateQuote_Click(object sender, EventArgs e)
        {
            if(DataValidation())
            {
                SalesQuote testQuote = CreateNewQuote();

                testQuote.AccessoriesChosen = AccessoriesPicked();
                testQuote.ExteriorFinishChosen = ExteriorFinishPicked();

                UpdateSummary(testQuote);
                UpdateFinance(testQuote);
            }
        }


        /// <summary>
        /// When the event is raised a dialogbox appears. If the user clicks yes, the form will be reset to its initial state.
        /// </summary>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to reset the form?", "Reset Form", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                ClearLabels();
                ClearErrorMessages();
                this.cboVehicle.SelectedIndex = -1;
                this.txtTradeInValue.Text = "0";
                this.nudNoOfYears.Value = 1;
                this.nudAnnualInterestRate.Value = 5;

                this.chkStereoSystem.Checked = false;
                this.chkLeatherInterior.Checked = false;
                this.chkComputerNavigation.Checked = false;
                this.radStandard.Checked = true;

                this.cboVehicle.Focus();
                vehicleInformationToolStripMenuItem.Enabled = false;
            }
        }


        /// <summary>
        /// The value (true or false) of the accessories checkboxes are added to a string variable.
        /// The string is then put through a switch case to determine which acessories have been chosen.
        /// And the result is returned to the method that had called accessoriesPicked.
        /// </summary>
        /// <returns>Return: Returns the value of the Accessories enum.</returns>
        private Accessories AccessoriesPicked()
        {
            Accessories accessory = Accessories.None;

            if (chkStereoSystem.Checked && !chkLeatherInterior.Checked && !chkComputerNavigation.Checked)
            {
                accessory = Accessories.StereoSystem;
            }
            else if (!chkStereoSystem.Checked && chkLeatherInterior.Checked && !chkComputerNavigation.Checked)
            {
                accessory = Accessories.LeatherInterior;
            }
            else if (!chkStereoSystem.Checked && !chkLeatherInterior.Checked && chkComputerNavigation.Checked)
            {
                accessory = Accessories.ComputerNavigation;
            }
            else if (chkStereoSystem.Checked && chkLeatherInterior.Checked && !chkComputerNavigation.Checked)
            {
                accessory = Accessories.StereoAndLeather;
            }
            else if (chkStereoSystem.Checked && !chkLeatherInterior.Checked && chkComputerNavigation.Checked)
            {
                accessory = Accessories.StereoAndNavigation;
            }
            else if (!chkStereoSystem.Checked && chkLeatherInterior.Checked && chkComputerNavigation.Checked)
            {
                accessory = Accessories.LeatherAndNavigation;
            }
            else if (chkStereoSystem.Checked && chkLeatherInterior.Checked && chkComputerNavigation.Checked)
            {
                accessory = Accessories.All;
            }


            return accessory;
        }


        /// <summary>
        /// Returns the value of exterior based on which radio button was selected.
        /// </summary>
        /// <returns>Return: The value of exteriorFinish.</returns>
        private ExteriorFinish ExteriorFinishPicked()
        {
            ExteriorFinish exterior = ExteriorFinish.None;

            if(radStandard.Checked)
            {
                exterior = ExteriorFinish.Standard;
            }
            else if (radPearlized.Checked)
            {
                exterior = ExteriorFinish.Pearlized;
            }
            else if (radCustomizedDetailing.Checked)
            {
                exterior = ExteriorFinish.Custom;
            }

            return exterior;
        }


        /// <summary>
        /// Checks to see if VehicleSalePrice and TradeInValue contain valid values.
        ///     If an error occurs, a value of false is returned. Otherwise a value of true is returned.
        /// </summary>
        /// <returns>Return: True or False</returns>
        private bool DataValidation()
        {
            bool isValid = true;

            ClearErrorMessages();

            if(cboVehicle.SelectedIndex < 0)
            {
                isValid = false;
                errorProvider1.SetError(this.cboVehicle, "A vehicle must be selected.");
            }

            try
            {
                SalesQuote testQuote = new SalesQuote(1, 0, 0.1m);
                testQuote.TradeInAmount = Convert.ToDecimal(this.txtTradeInValue.Text);
            }
            catch (FormatException)
            {
                isValid = false;

                if (this.txtTradeInValue.Text == string.Empty)
                {
                    errorProvider1.SetError(this.txtTradeInValue, "Trade-in value is a required field.");
                }
                else
                {
                    errorProvider1.SetError(this.txtTradeInValue, "Trade-in value cannot contain letters or special characters.");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                isValid = false;
                errorProvider1.SetError(this.txtTradeInValue, "Trade-in value cannot be less than 0.");
            }

            

            if (isValid)
            {
                decimal vehiclePrice = (decimal)(double)(vehicleTable.Rows[cboVehicle.SelectedIndex]["BasePrice"]);
                decimal tradeInAmount = Convert.ToDecimal(this.txtTradeInValue.Text);

                if (vehiclePrice < tradeInAmount)
                {
                    isValid = false;
                    errorProvider1.SetError(this.txtTradeInValue, "Trade-in value cannot exceed the vehicle sale price.");
                }
            }

            return isValid;
        }



        /// <summary>
        /// Updates the accessories chosen.
        /// </summary>
        /// <param name="testQuote">An instance of the SalesQuote object.</param>
        private void UpdateAccessories(SalesQuote testQuote)
        {
            testQuote.AccessoriesChosen = AccessoriesPicked();
        }

        /// <summary>
        /// Updates the exterior finish chosen.
        /// </summary>
        /// <param name="testQuote">An instance of the SalesQuote object.</param>
        private void UpdateExteriorFinish(SalesQuote testQuote)
        {
            testQuote.ExteriorFinishChosen = ExteriorFinishPicked();
        }


        /// <summary>
        /// Updates the summary textboxes with any new values it was given.
        /// </summary>
        /// <param name="testQuote">An instance of the SalesQuote class.</param>
        private void UpdateSummary(SalesQuote testQuote)
        {
            this.lblSummaryVehicleSalePrice.Text = (testQuote.VehicleSalePrice).ToString("C");
            this.lblSummaryOptions.Text = (testQuote.AccessoryCost + testQuote.ExteriorFinishCost).ToString("N");
            this.lblSummarySubtotal.Text = (testQuote.SubTotal).ToString("C");
            this.lblSummarySalesTax.Text = (testQuote.SalesTax).ToString("N");
            this.lblSummaryTotal.Text = (testQuote.Total).ToString("C");
            this.lblSummaryTradein.Text = "-" + (testQuote.TradeInAmount).ToString("N");
            this.lblSummaryAmountDue.Text = (testQuote.AmountDue).ToString("C");
        }

        /// <summary>
        /// Calculates the monthly payment based on the amount due, number of years selected, and interest rate.
        /// </summary>
        /// <param name="testQuote">An instance of the SalesQuote class.</param>
        private void UpdateFinance(SalesQuote testQuote)
        {
            if (this.lblSummaryAmountDue.Text != string.Empty)
            {
                decimal rate = (((decimal)this.nudAnnualInterestRate.Value) / 1200);
                int numberOfPaymentPeriods = ((int)this.nudNoOfYears.Value) * 12;
                decimal presentValue = testQuote.AmountDue;

                this.lblMonthlyPayment.Text = (Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue)).ToString("C");
            }
        }


        /// <summary>
        /// Updates the salesquote object using any new values it was given.
        ///     It then displays the updated values in the summary and finance textboxes.
        /// </summary>
        private void UpdateAll()
        {
            if (this.lblSummaryVehicleSalePrice.Text != string.Empty)
            {
                SalesQuote testQuote = CreateNewQuote();
                UpdateAccessories(testQuote);
                UpdateExteriorFinish(testQuote);
                UpdateSummary(testQuote);
                UpdateFinance(testQuote);
            }
        }


        /// <summary>
        /// This will clear all of the output labels within summary and the monthlyPayment label in Finance.
        /// </summary>
        private void ClearLabels()
        {
            this.lblSummaryVehicleSalePrice.Text = string.Empty;
            this.lblSummaryOptions.Text = string.Empty;
            this.lblSummarySubtotal.Text = string.Empty;
            this.lblSummarySalesTax.Text = string.Empty;
            this.lblSummaryTotal.Text = string.Empty;
            this.lblSummaryTradein.Text = string.Empty;
            this.lblSummaryAmountDue.Text = string.Empty;
            this.lblMonthlyPayment.Text = string.Empty;
        }

        /// <summary>
        /// Clears the error messages beside the vehicle sale price and trade-in textboxes.
        /// </summary>
        private void ClearErrorMessages()
        {
            errorProvider1.SetError(cboVehicle, string.Empty);
            errorProvider1.SetError(txtTradeInValue, string.Empty);
        }


        /// <summary>
        /// Handles the databinding and formatting for the SalesQuoteForm.
        /// </summary>
        private void BindControls()
        {
            this.vehicleBindingSource.DataSource = vehicleTable;
            this.cboVehicle.DataSource = this.vehicleBindingSource;

            this.cboVehicle.DisplayMember = "StockNumber";
            this.cboVehicle.ValueMember = "BasePrice";
        }
    }
}
