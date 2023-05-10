/******************************************
* Name: Jason Chuy
* Course: BIT, Programming 2, Section 1
* Date Created: March 16, 2020
* Date Last Edited: April 19, 2020
*******************************************/

/**
* RRCAutomotiveGroup: Serves as the launcher for the entire program.
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
using System.IO;
using System.Data.OleDb;
using System.Diagnostics;

namespace RRCAGApp
{
    public partial class RRCAutomotiveGroupForm : Form
    {
        public RRCAutomotiveGroupForm()
        {
            InitializeComponent();
            salesQuoteToolStripMenuItem.Click += SalesQuoteToolStripMenuItem_Click;
            carWashToolStripMenuItem.Click += CarWashToolStripMenuItem_Click;
            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            vehicleToolStripMenuItem.Click += vehicleToolStripMenuItem_Click;
        }

        /// <summary>
        /// Attempts to query the database to see if any vehicles are in stock.
        /// </summary>
        private void SalesQuoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool vehiclesInStock = true;

                string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source='AMDatabase.mdb'";
                OleDbConnection connection;

                connection = new OleDbConnection();
                connection.ConnectionString = connectionString;

                OleDbCommand selectCommand = new OleDbCommand("SELECT * FROM VehicleStock WHERE soldby = 0", connection);
                connection.Open();


                OleDbDataReader reader = selectCommand.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("There are no vehicles in stock.", "Sales Quote Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    vehiclesInStock = false;
                }

                reader.Close();
                connection.Close();

                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = selectCommand;

                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet, "VehicleStock");

                if (vehiclesInStock)
                {
                    SalesQuoteForm salesQuote = new SalesQuoteForm(dataSet);
                    salesQuote.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to load vehcle data.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Creates new instance of the CarWashForm if the fragrances file exists. 
        /// </summary>
        private void CarWashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = @"fragrances.txt";

            if (File.Exists(path))
            {
                CarWashForm carWashForm = new CarWashForm();
                carWashForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Fragrances data file not found.", "Data File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Opens the about form.
        /// </summary>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBoxForm about = new AboutBoxForm();
            about.ShowDialog();
        }


        /// <summary>
        /// Closes the launcher.
        /// </summary>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Attempts to query the database and fill the dataset with data from the VehicleStock table.
        /// </summary>
        private void vehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool errorFlag = false;

            try
            {
                string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source='AMDatabase.mdb'";
                OleDbConnection connection;

                connection = new OleDbConnection();
                connection.ConnectionString = connectionString;

                OleDbCommand selectCommand = new OleDbCommand("SELECT * FROM VehicleStock", connection);
                connection.Open();

                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = selectCommand;

                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet, "VehicleStock");
                connection.Close();
            }
            catch (Exception)
            {
                errorFlag = true;
                MessageBox.Show("Unable to load vehicle data.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!errorFlag)
            {
                VehicleDataForm vehicleDataForm = new VehicleDataForm();
                vehicleDataForm.ShowDialog();
            }
        }


    }
}
