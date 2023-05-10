/******************************************
* Name: Jason Chuy
* Course: BIT, Programming 2, Section 1
* Date Created: April 5, 2020
* Date Last Edited: April 14, 2020
*******************************************/

/**
* CarWashForm: Displays a list of services and cost based on the selected package and fragrance.
*
* @author Jason Chuy
* @version 1.0
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chuy.Jason.Business;

namespace RRCAGApp
{
    public partial class CarWashForm : Form
    {
        private List<CarWashItem> packagesList;
        private List<CarWashItem> fragrancesList;
        private List<string> interiorList;
        private List<string> exteriorList;
        private CarWashInvoice carWashInvoice;

        private BindingSource carWashInvoicesBindingSource;
        private BindingSource packagesBindingSource;
        private BindingSource fragrancesBindingSource;
        private BindingSource interiorBindingSource;
        private BindingSource exteriorBindingSource;

        CarWashInvoiceForm carWashInvoiceForm;
        private bool corruptFile = false;


        public CarWashForm()
        {
            InitializeComponent();
            this.carWashInvoicesBindingSource = new BindingSource();
            this.packagesBindingSource = new BindingSource();
            this.fragrancesBindingSource = new BindingSource();
            this.interiorBindingSource = new BindingSource();
            this.exteriorBindingSource = new BindingSource();

            this.Load += CarWashForm_Load;

            this.packagesBindingSource.PositionChanged += ComboBox_SelectedIndexChanged;
            this.fragrancesBindingSource.PositionChanged += ComboBox_SelectedIndexChanged;
            this.exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            this.generateInvoiceToolStripMenuItem.Click += GenerateInvoiceToolStripMenuItem_Click;

            this.carWashInvoice = new CarWashInvoice(0.07m, 0.05m);
            this.packagesList = new List<CarWashItem>();
            this.fragrancesList = new List<CarWashItem>();
            this.interiorList = new List<string>();
            this.exteriorList = new List<string>();

            this.packagesList.Add(new CarWashItem("Standard", 7.5m));
            this.packagesList.Add(new CarWashItem("Deluxe", 15));
            this.packagesList.Add(new CarWashItem("Executive", 35));
            this.packagesList.Add(new CarWashItem("Luxury", 55));
        }


        /// <summary>
        /// When the CarWashInvoiceForm is closed, the combo boxes on the CarWashForm will be set to "Standard" and "Pine".
        /// </summary>
        private void CarWashInvoiceForm_Close(object sender, EventArgs e)
        {
            cboPackage.SelectedIndex = 0;
            cboFragrance.SelectedIndex = 4;
        }


        /// <summary>
        /// Opens an instance of the CarWashInvoiceForm.
        /// </summary>
        private void GenerateInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carWashInvoiceForm = new CarWashInvoiceForm(carWashInvoice);
            this.carWashInvoiceForm.FormClosed += CarWashInvoiceForm_Close;
            this.carWashInvoiceForm.ShowDialog();

        }


        /// <summary>
        /// Closes the CarWashForm.
        /// </summary>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Updates the carWashInvoice object.
        /// </summary>
        private void UpdateCarWashInvoice()
        {
            if(cboPackage.SelectedIndex >= 0 && cboFragrance.SelectedIndex >= 0)
            {
                decimal packageCost = (packagesList[cboPackage.SelectedIndex].Cost),
                        fragranceCost = (fragrancesList[cboFragrance.SelectedIndex].Cost);


                carWashInvoice.PackageCost = packageCost;
                carWashInvoice.FragranceCost = fragranceCost;
                
              //  Debug.WriteLine(packagesList[cboPackage.SelectedIndex]);
            }
            
            carWashInvoicesBindingSource.ResetBindings(false);
        }
        

        /// <summary>
        /// Updates the list of interior services.
        /// </summary>
        private void UpdateInteriorResponse()
        {
            interiorList.Clear();

            if (cboPackage.SelectedIndex >= 0 && cboFragrance.SelectedIndex >= 0)
            {
                string type = string.Format("Fragrance - {0}", fragrancesList[cboFragrance.SelectedIndex].Type);

                switch (cboPackage.SelectedIndex)
                {
                    case 3:
                        interiorList.Add("Interior Protection Coat");
                        goto case 2;
                    case 2:
                        interiorList.Add("Shampoo Upholstry");
                        goto case 1;
                    case 1:
                        interiorList.Add("Shampoo Carpets");
                        goto case 0;
                    case 0:
                        interiorList.Add(type);
                        break;
                }
            }
            interiorBindingSource.ResetBindings(false);
        }


        /// <summary>
        /// Updates the list of exterior services.
        /// </summary>
        private void UpdateExteriorResponse()
        {
            exteriorList.Clear();

            if (cboPackage.SelectedIndex >= 0 && cboFragrance.SelectedIndex >= 0)
            {
                switch (cboPackage.SelectedIndex)
                {
                    case 3:
                        exteriorList.Add("Detail Engine Compartment");
                        goto case 2;
                    case 2:
                        exteriorList.Add("Wheel Polish");
                        goto case 1;
                    case 1:
                        exteriorList.Add("Hand Wax");
                        goto case 0;
                    case 0:
                        exteriorList.Add("Hand Wash");
                        break;
                }
            }
            exteriorBindingSource.ResetBindings(false);
        }


        /// <summary>
        /// Updates the carwashinvoice object and listboxes.
        /// </summary>
        private void UpdateAll()
        {
            UpdateCarWashInvoice();
            UpdateInteriorResponse();
            UpdateExteriorResponse();
        }


        /// <summary>
        /// Reads a text file and adds the contents to a list of fragrances.
        /// </summary>
        private void PopulateFragranceList()
        {
            try
            {
                List<string> type = new List<string>();
                List<decimal> cost = new List<decimal>();
                char[] delimiters = { ',', '\n' };

                string path = @"fragrances.txt";
                string filetest = File.ReadAllText(path);

                string[] txtFile = filetest.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < txtFile.Length; i++)
                {
                    if ((i % 2) == 0)
                    {
                        type.Add(txtFile[i]);
                    }

                    if (((i + 1) % 2) == 0)
                    {
                        cost.Add(Convert.ToDecimal(txtFile[i]));
                    }
                }

                for (int i = 0; i < type.Count; i++)
                {
                    this.fragrancesList.Add(new CarWashItem(type[i], cost[i]));
                }

                fragrancesList.Sort();
            }
            catch (Exception)
            {
                corruptFile = true;

                MessageBox.Show("An error occurred while reading the data file.", "DataFile Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }


        /// <summary>
        /// Occurs when the value from either combo box changes.
        /// </summary>
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAll();
        }


        /// <summary>
        /// If the fragrance file is not corrupted, the form is set to its initial state.
        /// </summary>
        private void CarWashForm_Load(object sender, EventArgs e)
        {
            PopulateFragranceList();

            if (!corruptFile)
            {
                BindControls();
                cboPackage.SelectedIndex = 0;
                cboFragrance.SelectedIndex = 4;

                UpdateAll();
            }
        }


        /// <summary>
        /// Handles the databinding and formatting for the CarWashForm.
        /// </summary>
        private void BindControls()
        {
            this.carWashInvoicesBindingSource.DataSource = this.carWashInvoice;
            this.packagesBindingSource.DataSource = this.packagesList;
            this.fragrancesBindingSource.DataSource = this.fragrancesList;
            this.interiorBindingSource.DataSource = this.interiorList;
            this.exteriorBindingSource.DataSource = this.exteriorList;

            this.cboPackage.DataSource = this.packagesBindingSource;
            this.cboFragrance.DataSource = this.fragrancesBindingSource;
            this.lstInterior.DataSource = this.interiorBindingSource;
            this.lstExterior.DataSource = this.exteriorBindingSource;

            this.cboPackage.DisplayMember = "type";
            this.cboPackage.ValueMember = "cost";

            this.cboFragrance.DisplayMember = "type";
            this.cboFragrance.ValueMember = "cost";

            Binding subtotalBinding = new Binding("Text", carWashInvoicesBindingSource, "SubTotal");
            Binding PSTBinding = new Binding("Text", carWashInvoicesBindingSource, "ProvincialSalesTaxCharged");
            Binding GSTBinding = new Binding("Text", carWashInvoicesBindingSource, "GoodsAndServicesTaxCharged");
            Binding totalBinding = new Binding("Text", carWashInvoicesBindingSource, "Total");


            lblSubtotal.DataBindings.Add(subtotalBinding);
            lblPST.DataBindings.Add(PSTBinding);
            lblGST.DataBindings.Add(GSTBinding);
            lblTotal.DataBindings.Add(totalBinding);

            subtotalBinding.FormattingEnabled = true;
            PSTBinding.FormattingEnabled = true;
            GSTBinding.FormattingEnabled = true;
            totalBinding.FormattingEnabled = true;

            subtotalBinding.FormatString = "C";
            PSTBinding.FormatString = "N";
            GSTBinding.FormatString = "N";
            totalBinding.FormatString = "C";
        }

    }

}








