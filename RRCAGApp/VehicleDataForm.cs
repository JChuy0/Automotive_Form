/******************************************
* Name: Jason Chuy
* Course: BIT, Programming 2, Section 1
* Date Created: April 16, 2020
* Date Last Edited: April 19, 2020
*******************************************/

/**
* VehicleDataForm: Displays data on all vehicles in the VehicleStock database..
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
using System.Data.OleDb;
using System.Diagnostics;

namespace RRCAGApp
{
    public partial class VehicleDataForm : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter adapter;
        DataSet dataSet;
        BindingSource bindingSource;


        public VehicleDataForm()
        {
            InitializeComponent();

            this.bindingSource = new BindingSource();

            this.Load += VehicleDataForm_Load;
            this.FormClosing += VehicleDataForm_Closing;
            this.mnuFileSave.Click += SaveToolStripMenuItem_Click;
            this.mnuEditDelete.Click += DeleteToolStripMenuItem_Click;
            this.dgvVehicleData.CellEnter += DgvVehicleData_HasChanges;
            this.dgvVehicleData.RowHeaderMouseClick += DgvVehicleDataRowHeader_Click;
            this.dgvVehicleData.CellClick += DataGridView_Click;
        }

        /// <summary>
        /// Handles the load event for the VehucleData form.
        /// </summary>
        private void VehicleDataForm_Load(object sender, EventArgs e)
        {
            RetrieveDataFromDatabase();
            BindControls();

            this.dgvVehicleData.Columns["ID"].Visible = false;
            this.dgvVehicleData.Columns["SoldBy"].Visible = false;

            OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder();
            commandBuilder.DataAdapter = adapter;

            commandBuilder.ConflictOption = ConflictOption.OverwriteChanges;

            adapter.InsertCommand = commandBuilder.GetInsertCommand();
            adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            adapter.DeleteCommand = commandBuilder.GetDeleteCommand();

            this.dgvVehicleData.RowsAdded += DgvVehicledata_RowAdded;
            adapter.RowUpdated += Adapter_RowUpdated;
        }


        /// <summary>
        /// If changes are made to the datagridview, the forms caption will change and the save menu item will be enabled.
        /// </summary>
        private void DgvVehicleData_HasChanges(object sender, EventArgs e)
        {
            if (this.dataSet.HasChanges())
            {
                this.Text = "* Vehicle Data";
                mnuFileSave.Enabled = true;
            }
        }


        /// <summary>
        /// When a row header is clicked, and the selected row is not the insert row, the delete menu item is enabled.
        /// </summary>
        private void DgvVehicleDataRowHeader_Click(object sender, EventArgs e)
        {
            if(dgvVehicleData.CurrentRow.IsNewRow != true)
            {
                mnuEditDelete.Enabled = true;
            }
        }


        /// <summary>
        /// This ensures that the delete menu item is only enabled while a rowheader is selected.
        /// </summary>
        private void DataGridView_Click(object sender, EventArgs e)
        {
            mnuEditDelete.Enabled = false;
        }


        /// <summary>
        /// If a new row is added, sets the value of the SoldBy column to 0.
        /// </summary>
        private void DgvVehicledata_RowAdded(object sender, EventArgs e)
        {
            DataGridViewRow newRow = dgvVehicleData.CurrentRow;

            if (newRow != null)
            {
                newRow.Cells["SoldBy"].Value = 0;
            }
        }


        /// <summary>
        /// Handles the RowUpdated event of the DataAdapter.
        /// </summary>
        private void Adapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            Debug.WriteLine("Start of rowupdated event.");

            // When the update is an Insert (new record)
            if (e.StatementType == StatementType.Insert)
            {
                // Creates a new command
                // @@IDENTITY - a database value that returns the last-inserted identity 
                // (AutoNumber) value from the last statement
                OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY", this.connection);

                // Assigns the ID value of the new row in the database to the DataColumn "ID" 
                // of the new
                // DataRow in the DataTable
                // ***
                // ExecuteScalar - Executes the command and returns the value of first column 
                // of the first row returned
                // e.Row - reference to the DataRow being updated from the DataTable.
                // e.Row["ID"] - reference to the "ID" DataColumn in the DataRow.
                e.Row["ID"] = (int)cmd.ExecuteScalar();

                Debug.WriteLine("Within if statement of rowupdated event");
            }
        }


        /// <summary>
        /// Saves changes to the VehicleStock table.
        /// </summary>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Start of save event");

            if (this.dataSet.HasChanges())
            {
                try
                {
                    dgvVehicleData.EndEdit();
                    bindingSource.EndEdit();
                    adapter.Update(this.dataSet, "VehicleStock");
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occurred while saving the changes to the vehicle data.", "Save Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }

            if (!this.dataSet.HasChanges())
            {
                this.Text = "Vehicle Data";
            }

        }


        /// <summary>
        /// Removes the selected row from the Data Grid View.
        /// </summary>
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvVehicleData.CurrentRow;
            string stockid = (row.Cells["StockNumber"].Value).ToString();


            DialogResult dr = MessageBox.Show($"Are you sure you want to delete stock item {stockid}?", "Delete Stock Item", MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(dr == DialogResult.Yes)
            {
                try
                {
                    dgvVehicleData.Rows.RemoveAt(dgvVehicleData.CurrentRow.Index);
                    mnuEditDelete.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occurred while deleting the selected vehicle.", "Deletion Error", MessageBoxButtons.OK, 
                                          MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

            }
        }


        /// <summary>
        /// Retrieves the data from the database.
        /// </summary>
        private void RetrieveDataFromDatabase()
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source='AMDatabase.mdb'";

            connection = new OleDbConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            
            OleDbCommand selectCommand = new OleDbCommand();
            selectCommand.CommandText = "SELECT * FROM VehicleStock";
            selectCommand.Connection = connection;

            adapter = new OleDbDataAdapter();
            adapter.SelectCommand = selectCommand;

            dataSet = new DataSet();

            adapter.Fill(dataSet, "VehicleStock");
        }



        /// <summary>
        /// If there are unsaved chnages, the user is asked if they want to save before closing the form.
        /// Closes and disposes of the connection just before the form closes.
        /// </summary>
        private void VehicleDataForm_Closing(object sender, FormClosingEventArgs e)
        {
            bool errorFlag = false;

            if (this.dataSet.HasChanges())
            {
                DialogResult dr = MessageBox.Show("Do you wish to save the changes?", "Save", MessageBoxButtons.YesNoCancel, 
                                                         MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        dgvVehicleData.EndEdit();
                        bindingSource.EndEdit();
                        adapter.Update(this.dataSet, "VehicleStock");
                    }
                    catch (Exception)
                    {
                        errorFlag = true;
                        dr = MessageBox.Show("An error occurred while saving. Do you still wish to close?", "Save Error", 
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                    }

                    if (errorFlag &&(dr == DialogResult.No))
                    {
                        e.Cancel = true;
                    }
                }
                else if(dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

            connection.Close();
            connection.Dispose();
        }


        /// <summary>
        /// Handles the databinding for VehicleDataForm.
        /// </summary>
        private void BindControls()
        {
            this.bindingSource.DataSource = dataSet.Tables["VehicleStock"];
            dgvVehicleData.DataSource = bindingSource;
        }

    }
}
