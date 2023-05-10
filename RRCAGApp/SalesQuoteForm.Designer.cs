namespace RRCAGApp
{
    partial class SalesQuoteForm
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
            this.components = new System.ComponentModel.Container();
            this.lblVehicleSalePrice = new System.Windows.Forms.Label();
            this.lblTradeInValue = new System.Windows.Forms.Label();
            this.txtTradeInValue = new System.Windows.Forms.TextBox();
            this.grpAccessories = new System.Windows.Forms.GroupBox();
            this.chkComputerNavigation = new System.Windows.Forms.CheckBox();
            this.chkLeatherInterior = new System.Windows.Forms.CheckBox();
            this.chkStereoSystem = new System.Windows.Forms.CheckBox();
            this.grpExteriorFinish = new System.Windows.Forms.GroupBox();
            this.radCustomizedDetailing = new System.Windows.Forms.RadioButton();
            this.radPearlized = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblSummaryVehicleSalePrice = new System.Windows.Forms.Label();
            this.lblSummaryOptions = new System.Windows.Forms.Label();
            this.lblSummarySubtotal = new System.Windows.Forms.Label();
            this.lblSummarySalesTax = new System.Windows.Forms.Label();
            this.lblSummaryTotal = new System.Windows.Forms.Label();
            this.lblSummaryTradein = new System.Windows.Forms.Label();
            this.lblSummaryAmountDue = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblTradeIn = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVehicleSalesPrice = new System.Windows.Forms.Label();
            this.grpFinance = new System.Windows.Forms.GroupBox();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.nudAnnualInterestRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAnnualInterestrate = new System.Windows.Forms.Label();
            this.lblNoOfYears = new System.Windows.Forms.Label();
            this.nudNoOfYears = new System.Windows.Forms.NumericUpDown();
            this.btnCalculateQuote = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboVehicle = new System.Windows.Forms.ComboBox();
            this.mnuVehicleSalesQuote = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAccessories.SuspendLayout();
            this.grpExteriorFinish.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.grpFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.mnuVehicleSalesQuote.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVehicleSalePrice
            // 
            this.lblVehicleSalePrice.AutoSize = true;
            this.lblVehicleSalePrice.Location = new System.Drawing.Point(103, 59);
            this.lblVehicleSalePrice.Name = "lblVehicleSalePrice";
            this.lblVehicleSalePrice.Size = new System.Drawing.Size(58, 17);
            this.lblVehicleSalePrice.TabIndex = 0;
            this.lblVehicleSalePrice.Text = "Vehicle:";
            // 
            // lblTradeInValue
            // 
            this.lblTradeInValue.AutoSize = true;
            this.lblTradeInValue.Location = new System.Drawing.Point(55, 99);
            this.lblTradeInValue.Name = "lblTradeInValue";
            this.lblTradeInValue.Size = new System.Drawing.Size(106, 17);
            this.lblTradeInValue.TabIndex = 1;
            this.lblTradeInValue.Text = "Trade-in Value:";
            // 
            // txtTradeInValue
            // 
            this.errorProvider1.SetIconPadding(this.txtTradeInValue, 3);
            this.txtTradeInValue.Location = new System.Drawing.Point(167, 99);
            this.txtTradeInValue.Name = "txtTradeInValue";
            this.txtTradeInValue.Size = new System.Drawing.Size(142, 22);
            this.txtTradeInValue.TabIndex = 1;
            this.txtTradeInValue.Text = "0";
            this.txtTradeInValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpAccessories
            // 
            this.grpAccessories.Controls.Add(this.chkComputerNavigation);
            this.grpAccessories.Controls.Add(this.chkLeatherInterior);
            this.grpAccessories.Controls.Add(this.chkStereoSystem);
            this.grpAccessories.Location = new System.Drawing.Point(29, 152);
            this.grpAccessories.Name = "grpAccessories";
            this.grpAccessories.Size = new System.Drawing.Size(280, 178);
            this.grpAccessories.TabIndex = 2;
            this.grpAccessories.TabStop = false;
            this.grpAccessories.Text = "Accessories";
            // 
            // chkComputerNavigation
            // 
            this.chkComputerNavigation.AutoSize = true;
            this.chkComputerNavigation.Location = new System.Drawing.Point(29, 126);
            this.chkComputerNavigation.Name = "chkComputerNavigation";
            this.chkComputerNavigation.Size = new System.Drawing.Size(162, 21);
            this.chkComputerNavigation.TabIndex = 4;
            this.chkComputerNavigation.Text = "Computer Navigation";
            this.chkComputerNavigation.UseVisualStyleBackColor = true;
            // 
            // chkLeatherInterior
            // 
            this.chkLeatherInterior.AutoSize = true;
            this.chkLeatherInterior.Location = new System.Drawing.Point(30, 83);
            this.chkLeatherInterior.Name = "chkLeatherInterior";
            this.chkLeatherInterior.Size = new System.Drawing.Size(127, 21);
            this.chkLeatherInterior.TabIndex = 3;
            this.chkLeatherInterior.Text = "Leather Interior";
            this.chkLeatherInterior.UseVisualStyleBackColor = true;
            // 
            // chkStereoSystem
            // 
            this.chkStereoSystem.AutoSize = true;
            this.chkStereoSystem.Location = new System.Drawing.Point(30, 41);
            this.chkStereoSystem.Name = "chkStereoSystem";
            this.chkStereoSystem.Size = new System.Drawing.Size(122, 21);
            this.chkStereoSystem.TabIndex = 2;
            this.chkStereoSystem.Text = "Stereo System";
            this.chkStereoSystem.UseVisualStyleBackColor = true;
            // 
            // grpExteriorFinish
            // 
            this.grpExteriorFinish.Controls.Add(this.radCustomizedDetailing);
            this.grpExteriorFinish.Controls.Add(this.radPearlized);
            this.grpExteriorFinish.Controls.Add(this.radStandard);
            this.grpExteriorFinish.Location = new System.Drawing.Point(29, 349);
            this.grpExteriorFinish.Name = "grpExteriorFinish";
            this.grpExteriorFinish.Size = new System.Drawing.Size(280, 168);
            this.grpExteriorFinish.TabIndex = 5;
            this.grpExteriorFinish.TabStop = false;
            this.grpExteriorFinish.Text = "Exterior Finish";
            // 
            // radCustomizedDetailing
            // 
            this.radCustomizedDetailing.AutoSize = true;
            this.radCustomizedDetailing.Location = new System.Drawing.Point(29, 119);
            this.radCustomizedDetailing.Name = "radCustomizedDetailing";
            this.radCustomizedDetailing.Size = new System.Drawing.Size(161, 21);
            this.radCustomizedDetailing.TabIndex = 5;
            this.radCustomizedDetailing.Text = "Customized Detailing";
            this.radCustomizedDetailing.UseVisualStyleBackColor = true;
            // 
            // radPearlized
            // 
            this.radPearlized.AutoSize = true;
            this.radPearlized.Location = new System.Drawing.Point(29, 78);
            this.radPearlized.Name = "radPearlized";
            this.radPearlized.Size = new System.Drawing.Size(88, 21);
            this.radPearlized.TabIndex = 5;
            this.radPearlized.Text = "Pearlized";
            this.radPearlized.UseVisualStyleBackColor = true;
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Checked = true;
            this.radStandard.Location = new System.Drawing.Point(30, 38);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(87, 21);
            this.radStandard.TabIndex = 5;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblSummaryVehicleSalePrice);
            this.grpSummary.Controls.Add(this.lblSummaryOptions);
            this.grpSummary.Controls.Add(this.lblSummarySubtotal);
            this.grpSummary.Controls.Add(this.lblSummarySalesTax);
            this.grpSummary.Controls.Add(this.lblSummaryTotal);
            this.grpSummary.Controls.Add(this.lblSummaryTradein);
            this.grpSummary.Controls.Add(this.lblSummaryAmountDue);
            this.grpSummary.Controls.Add(this.lblAmountDue);
            this.grpSummary.Controls.Add(this.lblTradeIn);
            this.grpSummary.Controls.Add(this.lblSubtotal);
            this.grpSummary.Controls.Add(this.lblOptions);
            this.grpSummary.Controls.Add(this.lblSalesTax);
            this.grpSummary.Controls.Add(this.lblTotal);
            this.grpSummary.Controls.Add(this.lblVehicleSalesPrice);
            this.grpSummary.Location = new System.Drawing.Point(352, 45);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(380, 336);
            this.grpSummary.TabIndex = 6;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // lblSummaryVehicleSalePrice
            // 
            this.lblSummaryVehicleSalePrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblSummaryVehicleSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryVehicleSalePrice.Location = new System.Drawing.Point(190, 35);
            this.lblSummaryVehicleSalePrice.Name = "lblSummaryVehicleSalePrice";
            this.lblSummaryVehicleSalePrice.Size = new System.Drawing.Size(160, 23);
            this.lblSummaryVehicleSalePrice.TabIndex = 8;
            this.lblSummaryVehicleSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummaryOptions
            // 
            this.lblSummaryOptions.BackColor = System.Drawing.SystemColors.Control;
            this.lblSummaryOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryOptions.Location = new System.Drawing.Point(190, 75);
            this.lblSummaryOptions.Name = "lblSummaryOptions";
            this.lblSummaryOptions.Size = new System.Drawing.Size(160, 23);
            this.lblSummaryOptions.TabIndex = 9;
            this.lblSummaryOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummarySubtotal
            // 
            this.lblSummarySubtotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblSummarySubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummarySubtotal.Location = new System.Drawing.Point(190, 118);
            this.lblSummarySubtotal.Name = "lblSummarySubtotal";
            this.lblSummarySubtotal.Size = new System.Drawing.Size(160, 23);
            this.lblSummarySubtotal.TabIndex = 10;
            this.lblSummarySubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummarySalesTax
            // 
            this.lblSummarySalesTax.BackColor = System.Drawing.SystemColors.Control;
            this.lblSummarySalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummarySalesTax.Location = new System.Drawing.Point(190, 160);
            this.lblSummarySalesTax.Name = "lblSummarySalesTax";
            this.lblSummarySalesTax.Size = new System.Drawing.Size(160, 23);
            this.lblSummarySalesTax.TabIndex = 11;
            this.lblSummarySalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummaryTotal
            // 
            this.lblSummaryTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblSummaryTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryTotal.Location = new System.Drawing.Point(190, 200);
            this.lblSummaryTotal.Name = "lblSummaryTotal";
            this.lblSummaryTotal.Size = new System.Drawing.Size(160, 23);
            this.lblSummaryTotal.TabIndex = 12;
            this.lblSummaryTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummaryTradein
            // 
            this.lblSummaryTradein.BackColor = System.Drawing.SystemColors.Control;
            this.lblSummaryTradein.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryTradein.Location = new System.Drawing.Point(190, 240);
            this.lblSummaryTradein.Name = "lblSummaryTradein";
            this.lblSummaryTradein.Size = new System.Drawing.Size(160, 23);
            this.lblSummaryTradein.TabIndex = 13;
            this.lblSummaryTradein.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummaryAmountDue
            // 
            this.lblSummaryAmountDue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSummaryAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryAmountDue.Location = new System.Drawing.Point(190, 285);
            this.lblSummaryAmountDue.Name = "lblSummaryAmountDue";
            this.lblSummaryAmountDue.Size = new System.Drawing.Size(160, 23);
            this.lblSummaryAmountDue.TabIndex = 14;
            this.lblSummaryAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(90, 290);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(90, 17);
            this.lblAmountDue.TabIndex = 7;
            this.lblAmountDue.Text = "Amount Due:";
            // 
            // lblTradeIn
            // 
            this.lblTradeIn.AutoSize = true;
            this.lblTradeIn.Location = new System.Drawing.Point(114, 245);
            this.lblTradeIn.Name = "lblTradeIn";
            this.lblTradeIn.Size = new System.Drawing.Size(66, 17);
            this.lblTradeIn.TabIndex = 6;
            this.lblTradeIn.Text = "Trade-in:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(116, 123);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(64, 17);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(120, 80);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(61, 17);
            this.lblOptions.TabIndex = 2;
            this.lblOptions.Text = "Options:";
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(64, 165);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(116, 17);
            this.lblSalesTax.TabIndex = 4;
            this.lblSalesTax.Text = "Sales Tax (13%):";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(136, 205);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // lblVehicleSalesPrice
            // 
            this.lblVehicleSalesPrice.AutoSize = true;
            this.lblVehicleSalesPrice.Location = new System.Drawing.Point(44, 40);
            this.lblVehicleSalesPrice.Name = "lblVehicleSalesPrice";
            this.lblVehicleSalesPrice.Size = new System.Drawing.Size(136, 17);
            this.lblVehicleSalesPrice.TabIndex = 1;
            this.lblVehicleSalesPrice.Text = "Vehicle\'s Sale Price:";
            this.lblVehicleSalesPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpFinance
            // 
            this.grpFinance.Controls.Add(this.lblMonthlyPayment);
            this.grpFinance.Controls.Add(this.nudAnnualInterestRate);
            this.grpFinance.Controls.Add(this.label2);
            this.grpFinance.Controls.Add(this.lblAnnualInterestrate);
            this.grpFinance.Controls.Add(this.lblNoOfYears);
            this.grpFinance.Controls.Add(this.nudNoOfYears);
            this.grpFinance.Location = new System.Drawing.Point(352, 387);
            this.grpFinance.Name = "grpFinance";
            this.grpFinance.Size = new System.Drawing.Size(380, 130);
            this.grpFinance.TabIndex = 7;
            this.grpFinance.TabStop = false;
            this.grpFinance.Text = "Finance";
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(252, 79);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(112, 23);
            this.lblMonthlyPayment.TabIndex = 6;
            this.lblMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudAnnualInterestRate
            // 
            this.nudAnnualInterestRate.DecimalPlaces = 2;
            this.nudAnnualInterestRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudAnnualInterestRate.Location = new System.Drawing.Point(139, 80);
            this.nudAnnualInterestRate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudAnnualInterestRate.Name = "nudAnnualInterestRate";
            this.nudAnnualInterestRate.Size = new System.Drawing.Size(87, 22);
            this.nudAnnualInterestRate.TabIndex = 5;
            this.nudAnnualInterestRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monthly Payment";
            // 
            // lblAnnualInterestrate
            // 
            this.lblAnnualInterestrate.AutoSize = true;
            this.lblAnnualInterestrate.Location = new System.Drawing.Point(137, 27);
            this.lblAnnualInterestrate.Name = "lblAnnualInterestrate";
            this.lblAnnualInterestrate.Size = new System.Drawing.Size(89, 34);
            this.lblAnnualInterestrate.TabIndex = 2;
            this.lblAnnualInterestrate.Text = "Annual\r\nInterest Rate";
            // 
            // lblNoOfYears
            // 
            this.lblNoOfYears.AutoSize = true;
            this.lblNoOfYears.Location = new System.Drawing.Point(24, 44);
            this.lblNoOfYears.Name = "lblNoOfYears";
            this.lblNoOfYears.Size = new System.Drawing.Size(87, 17);
            this.lblNoOfYears.TabIndex = 1;
            this.lblNoOfYears.Text = "No. of Years";
            // 
            // nudNoOfYears
            // 
            this.nudNoOfYears.Location = new System.Drawing.Point(26, 80);
            this.nudNoOfYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNoOfYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoOfYears.Name = "nudNoOfYears";
            this.nudNoOfYears.Size = new System.Drawing.Size(87, 22);
            this.nudNoOfYears.TabIndex = 4;
            this.nudNoOfYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalculateQuote
            // 
            this.btnCalculateQuote.Location = new System.Drawing.Point(604, 541);
            this.btnCalculateQuote.Name = "btnCalculateQuote";
            this.btnCalculateQuote.Size = new System.Drawing.Size(128, 39);
            this.btnCalculateQuote.TabIndex = 8;
            this.btnCalculateQuote.Text = "Calculate Quote";
            this.btnCalculateQuote.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(29, 541);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 39);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // cboVehicle
            // 
            this.cboVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicle.FormattingEnabled = true;
            this.errorProvider1.SetIconPadding(this.cboVehicle, 3);
            this.cboVehicle.Location = new System.Drawing.Point(167, 59);
            this.cboVehicle.Name = "cboVehicle";
            this.cboVehicle.Size = new System.Drawing.Size(142, 24);
            this.cboVehicle.TabIndex = 0;
            // 
            // mnuVehicleSalesQuote
            // 
            this.mnuVehicleSalesQuote.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuVehicleSalesQuote.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.mnuVehicleSalesQuote.Location = new System.Drawing.Point(0, 0);
            this.mnuVehicleSalesQuote.Name = "mnuVehicleSalesQuote";
            this.mnuVehicleSalesQuote.Size = new System.Drawing.Size(762, 28);
            this.mnuVehicleSalesQuote.TabIndex = 10;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleInformationToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // vehicleInformationToolStripMenuItem
            // 
            this.vehicleInformationToolStripMenuItem.Enabled = false;
            this.vehicleInformationToolStripMenuItem.Name = "vehicleInformationToolStripMenuItem";
            this.vehicleInformationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.vehicleInformationToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.vehicleInformationToolStripMenuItem.Text = "Vehicle &Information";
            // 
            // VehicleSalesQuote
            // 
            this.AcceptButton = this.btnCalculateQuote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 592);
            this.Controls.Add(this.cboVehicle);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculateQuote);
            this.Controls.Add(this.grpFinance);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpExteriorFinish);
            this.Controls.Add(this.grpAccessories);
            this.Controls.Add(this.txtTradeInValue);
            this.Controls.Add(this.lblTradeInValue);
            this.Controls.Add(this.lblVehicleSalePrice);
            this.Controls.Add(this.mnuVehicleSalesQuote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuVehicleSalesQuote;
            this.MaximizeBox = false;
            this.Name = "VehicleSalesQuote";
            this.Text = "Vehicle Sales Quote";
            this.grpAccessories.ResumeLayout(false);
            this.grpAccessories.PerformLayout();
            this.grpExteriorFinish.ResumeLayout(false);
            this.grpExteriorFinish.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.grpFinance.ResumeLayout(false);
            this.grpFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.mnuVehicleSalesQuote.ResumeLayout(false);
            this.mnuVehicleSalesQuote.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehicleSalePrice;
        private System.Windows.Forms.Label lblTradeInValue;
        private System.Windows.Forms.TextBox txtTradeInValue;
        private System.Windows.Forms.GroupBox grpAccessories;
        private System.Windows.Forms.CheckBox chkComputerNavigation;
        private System.Windows.Forms.CheckBox chkLeatherInterior;
        private System.Windows.Forms.CheckBox chkStereoSystem;
        private System.Windows.Forms.GroupBox grpExteriorFinish;
        private System.Windows.Forms.RadioButton radCustomizedDetailing;
        private System.Windows.Forms.RadioButton radPearlized;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblTradeIn;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblVehicleSalesPrice;
        private System.Windows.Forms.GroupBox grpFinance;
        private System.Windows.Forms.Label lblAnnualInterestrate;
        private System.Windows.Forms.Label lblNoOfYears;
        private System.Windows.Forms.NumericUpDown nudNoOfYears;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudAnnualInterestRate;
        private System.Windows.Forms.Button btnCalculateQuote;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblSummaryAmountDue;
        private System.Windows.Forms.Label lblSummaryTradein;
        private System.Windows.Forms.Label lblSummaryVehicleSalePrice;
        private System.Windows.Forms.Label lblSummaryOptions;
        private System.Windows.Forms.Label lblSummarySubtotal;
        private System.Windows.Forms.Label lblSummarySalesTax;
        private System.Windows.Forms.Label lblSummaryTotal;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.MenuStrip mnuVehicleSalesQuote;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleInformationToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboVehicle;
    }
}