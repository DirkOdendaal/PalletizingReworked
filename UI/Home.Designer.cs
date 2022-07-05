using System.Drawing;

namespace PalletizingReworked
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.bottomSidePanel = new System.Windows.Forms.Panel();
            this.pbSync = new System.Windows.Forms.PictureBox();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.btnPalletizing = new System.Windows.Forms.Button();
            this.btnProductionRun = new System.Windows.Forms.Button();
            this.pnlLandingPage = new System.Windows.Forms.Panel();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.pnlPrintSettings = new System.Windows.Forms.Panel();
            this.lblBarcodeHeading = new System.Windows.Forms.Label();
            this.tcSettingsBarcodes = new System.Windows.Forms.TabControl();
            this.tpBarcode = new System.Windows.Forms.TabPage();
            this.lblQR = new System.Windows.Forms.Label();
            this.numQRSize = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.numBarcodeHeight = new System.Windows.Forms.NumericUpDown();
            this.numBarcodeWidth = new System.Windows.Forms.NumericUpDown();
            this.btnTestPrint = new System.Windows.Forms.Button();
            this.lblBar = new System.Windows.Forms.Label();
            this.pbQR = new System.Windows.Forms.PictureBox();
            this.pnlBarcodeCheckBoxes = new System.Windows.Forms.Panel();
            this.cbBarcode = new System.Windows.Forms.CheckBox();
            this.cbQR = new System.Windows.Forms.CheckBox();
            this.pbBarcode = new System.Windows.Forms.PictureBox();
            this.tpWeight = new System.Windows.Forms.TabPage();
            this.lblWeightSize = new System.Windows.Forms.Label();
            this.numWeightTextSize = new System.Windows.Forms.NumericUpDown();
            this.lblSettingsWeight = new System.Windows.Forms.Label();
            this.btnTestKgPrint = new System.Windows.Forms.Button();
            this.pnlNextPallet = new System.Windows.Forms.Panel();
            this.numNextPallet = new System.Windows.Forms.NumericUpDown();
            this.lblNextPalletNum = new System.Windows.Forms.Label();
            this.pnlPrintCount = new System.Windows.Forms.Panel();
            this.numPrintLabelCount = new System.Windows.Forms.NumericUpDown();
            this.lblPrintCount = new System.Windows.Forms.Label();
            this.pnlPCName = new System.Windows.Forms.Panel();
            this.txtPCName = new System.Windows.Forms.TextBox();
            this.lblPCName = new System.Windows.Forms.Label();
            this.pnlWeightUnits = new System.Windows.Forms.Panel();
            this.ddWeightUnits = new System.Windows.Forms.ComboBox();
            this.lblWeightUnits = new System.Windows.Forms.Label();
            this.pnlBarcodePrefix = new System.Windows.Forms.Panel();
            this.txtBarcodePrefix = new System.Windows.Forms.TextBox();
            this.lblBarcodePrefix = new System.Windows.Forms.Label();
            this.pnlAvailablePresets = new System.Windows.Forms.Panel();
            this.lblScalePreset = new System.Windows.Forms.Label();
            this.ddPreset = new System.Windows.Forms.ComboBox();
            this.pnlSerialConnection = new System.Windows.Forms.Panel();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblComPort = new System.Windows.Forms.Label();
            this.ddBaudRate = new System.Windows.Forms.ComboBox();
            this.ddComPorts = new System.Windows.Forms.ComboBox();
            this.pnlSettingsFooter = new System.Windows.Forms.Panel();
            this.btnSettingsSave = new System.Windows.Forms.Button();
            this.btnSettingsClose = new System.Windows.Forms.Button();
            this.pnlSettingsHeader = new System.Windows.Forms.Panel();
            this.btnSettingsHeading = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlPalletizing = new System.Windows.Forms.Panel();
            this.ddgvPalletizing = new System.Windows.Forms.DataGridView();
            this.pnlPalletizingFooter = new System.Windows.Forms.Panel();
            this.lblUp = new System.Windows.Forms.Label();
            this.progressBarUp = new System.Windows.Forms.ProgressBar();
            this.btnUploadRecords = new System.Windows.Forms.Button();
            this.btnPallAddPallet = new System.Windows.Forms.Button();
            this.pnlPalletizingHeader = new System.Windows.Forms.Panel();
            this.btnPalletizingHeader = new System.Windows.Forms.Button();
            this.pnlAddPallet = new System.Windows.Forms.Panel();
            this.pnlAddPalletHeader = new System.Windows.Forms.Panel();
            this.btnAddPalletHeader = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.numAddPalletPallets = new System.Windows.Forms.NumericUpDown();
            this.btnAddPalletAdd = new System.Windows.Forms.Button();
            this.btnAddPalletCancel = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ddAddPalletBrand = new System.Windows.Forms.ComboBox();
            this.ddAddPalletGrade = new System.Windows.Forms.ComboBox();
            this.ddAddPalletCount = new System.Windows.Forms.ComboBox();
            this.ddAddPalletPackType = new System.Windows.Forms.ComboBox();
            this.numAddPalletPackQTY = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlScale1 = new System.Windows.Forms.Panel();
            this.txtAddPalletScaleWeight = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAddPalletCultivar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAddPalletProdUnit = new System.Windows.Forms.Label();
            this.lblAddPalletComm = new System.Windows.Forms.Label();
            this.lblAddPalletOrch = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAddPalletBlock = new System.Windows.Forms.Label();
            this.pnlCreateRun = new System.Windows.Forms.Panel();
            this.pnlCenterCreateRun = new System.Windows.Forms.Panel();
            this.ddCreateRunCultivar = new System.Windows.Forms.ComboBox();
            this.btnCreateRunSave = new System.Windows.Forms.Button();
            this.ddCreateRunComm = new System.Windows.Forms.ComboBox();
            this.lblCreateRunCultivar = new System.Windows.Forms.Label();
            this.ddCreateRunBlock = new System.Windows.Forms.ComboBox();
            this.ddCreateRunOrch = new System.Windows.Forms.ComboBox();
            this.ddCreateRunProdUnit = new System.Windows.Forms.ComboBox();
            this.lblCreateRunComm = new System.Windows.Forms.Label();
            this.lblCreateRunBlock = new System.Windows.Forms.Label();
            this.lblCreateRunOrchard = new System.Windows.Forms.Label();
            this.lblCreateRunProdUnit = new System.Windows.Forms.Label();
            this.pnlCreateRunHeading = new System.Windows.Forms.Panel();
            this.btnCreateRunHeading = new System.Windows.Forms.Button();
            this.btnCreateRunClose = new System.Windows.Forms.Button();
            this.contextMenuPalletizing = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printMassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPalletNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printBothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlNavigation.SuspendLayout();
            this.bottomSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSync)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            this.pnlLandingPage.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.pnlPrintSettings.SuspendLayout();
            this.tcSettingsBarcodes.SuspendLayout();
            this.tpBarcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQRSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBarcodeHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBarcodeWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            this.pnlBarcodeCheckBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).BeginInit();
            this.tpWeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeightTextSize)).BeginInit();
            this.pnlNextPallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNextPallet)).BeginInit();
            this.pnlPrintCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrintLabelCount)).BeginInit();
            this.pnlPCName.SuspendLayout();
            this.pnlWeightUnits.SuspendLayout();
            this.pnlBarcodePrefix.SuspendLayout();
            this.pnlAvailablePresets.SuspendLayout();
            this.pnlSerialConnection.SuspendLayout();
            this.pnlSettingsFooter.SuspendLayout();
            this.pnlSettingsHeader.SuspendLayout();
            this.pnlPalletizing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddgvPalletizing)).BeginInit();
            this.pnlPalletizingFooter.SuspendLayout();
            this.pnlPalletizingHeader.SuspendLayout();
            this.pnlAddPallet.SuspendLayout();
            this.pnlAddPalletHeader.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddPalletPallets)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddPalletPackQTY)).BeginInit();
            this.panel7.SuspendLayout();
            this.pnlScale1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlCreateRun.SuspendLayout();
            this.pnlCenterCreateRun.SuspendLayout();
            this.pnlCreateRunHeading.SuspendLayout();
            this.contextMenuPalletizing.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(178)))));
            this.pnlNavigation.Controls.Add(this.bottomSidePanel);
            this.pnlNavigation.Controls.Add(this.btnPalletizing);
            this.pnlNavigation.Controls.Add(this.btnProductionRun);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(169, 661);
            this.pnlNavigation.TabIndex = 1;
            // 
            // bottomSidePanel
            // 
            this.bottomSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(168)))));
            this.bottomSidePanel.Controls.Add(this.pbSync);
            this.bottomSidePanel.Controls.Add(this.pbSettings);
            this.bottomSidePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomSidePanel.Location = new System.Drawing.Point(0, 601);
            this.bottomSidePanel.Name = "bottomSidePanel";
            this.bottomSidePanel.Size = new System.Drawing.Size(169, 60);
            this.bottomSidePanel.TabIndex = 6;
            // 
            // pbSync
            // 
            this.pbSync.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSync.Image = ((System.Drawing.Image)(resources.GetObject("pbSync.Image")));
            this.pbSync.Location = new System.Drawing.Point(148, 36);
            this.pbSync.Name = "pbSync";
            this.pbSync.Size = new System.Drawing.Size(15, 21);
            this.pbSync.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSync.TabIndex = 3;
            this.pbSync.TabStop = false;
            // 
            // pbSettings
            // 
            this.pbSettings.BackColor = System.Drawing.Color.Transparent;
            this.pbSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSettings.Image = ((System.Drawing.Image)(resources.GetObject("pbSettings.Image")));
            this.pbSettings.Location = new System.Drawing.Point(3, 26);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(37, 31);
            this.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSettings.TabIndex = 0;
            this.pbSettings.TabStop = false;
            this.pbSettings.Click += new System.EventHandler(this.pbSettings_Click);
            // 
            // btnPalletizing
            // 
            this.btnPalletizing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPalletizing.FlatAppearance.BorderSize = 0;
            this.btnPalletizing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPalletizing.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold);
            this.btnPalletizing.ForeColor = System.Drawing.Color.White;
            this.btnPalletizing.Location = new System.Drawing.Point(0, 45);
            this.btnPalletizing.Name = "btnPalletizing";
            this.btnPalletizing.Size = new System.Drawing.Size(169, 50);
            this.btnPalletizing.TabIndex = 3;
            this.btnPalletizing.Text = "Palletizing";
            this.btnPalletizing.UseVisualStyleBackColor = true;
            this.btnPalletizing.Click += new System.EventHandler(this.btnPalletizing_Click);
            // 
            // btnProductionRun
            // 
            this.btnProductionRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductionRun.FlatAppearance.BorderSize = 0;
            this.btnProductionRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductionRun.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold);
            this.btnProductionRun.ForeColor = System.Drawing.Color.White;
            this.btnProductionRun.Location = new System.Drawing.Point(0, 0);
            this.btnProductionRun.Name = "btnProductionRun";
            this.btnProductionRun.Size = new System.Drawing.Size(169, 50);
            this.btnProductionRun.TabIndex = 2;
            this.btnProductionRun.Text = "Production Run";
            this.btnProductionRun.UseVisualStyleBackColor = true;
            this.btnProductionRun.Click += new System.EventHandler(this.btnProductionRun_Click);
            // 
            // pnlLandingPage
            // 
            this.pnlLandingPage.BackColor = System.Drawing.Color.Black;
            this.pnlLandingPage.BackgroundImage = global::Palletizing.Properties.Resources.scarce_skills_in_south_africa;
            this.pnlLandingPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLandingPage.Controls.Add(this.pnlSettings);
            this.pnlLandingPage.Controls.Add(this.pnlPalletizing);
            this.pnlLandingPage.Controls.Add(this.pnlAddPallet);
            this.pnlLandingPage.Controls.Add(this.pnlCreateRun);
            this.pnlLandingPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLandingPage.Location = new System.Drawing.Point(169, 0);
            this.pnlLandingPage.Name = "pnlLandingPage";
            this.pnlLandingPage.Size = new System.Drawing.Size(1015, 661);
            this.pnlLandingPage.TabIndex = 3;
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.Color.White;
            this.pnlSettings.Controls.Add(this.pnlPrintSettings);
            this.pnlSettings.Controls.Add(this.pnlNextPallet);
            this.pnlSettings.Controls.Add(this.pnlPrintCount);
            this.pnlSettings.Controls.Add(this.pnlPCName);
            this.pnlSettings.Controls.Add(this.pnlWeightUnits);
            this.pnlSettings.Controls.Add(this.pnlBarcodePrefix);
            this.pnlSettings.Controls.Add(this.pnlAvailablePresets);
            this.pnlSettings.Controls.Add(this.pnlSerialConnection);
            this.pnlSettings.Controls.Add(this.pnlSettingsFooter);
            this.pnlSettings.Controls.Add(this.pnlSettingsHeader);
            this.pnlSettings.Location = new System.Drawing.Point(19, 18);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(478, 266);
            this.pnlSettings.TabIndex = 4;
            this.pnlSettings.Visible = false;
            // 
            // pnlPrintSettings
            // 
            this.pnlPrintSettings.Controls.Add(this.lblBarcodeHeading);
            this.pnlPrintSettings.Controls.Add(this.tcSettingsBarcodes);
            this.pnlPrintSettings.Location = new System.Drawing.Point(409, 45);
            this.pnlPrintSettings.Name = "pnlPrintSettings";
            this.pnlPrintSettings.Size = new System.Drawing.Size(492, 517);
            this.pnlPrintSettings.TabIndex = 23;
            // 
            // lblBarcodeHeading
            // 
            this.lblBarcodeHeading.AutoSize = true;
            this.lblBarcodeHeading.Location = new System.Drawing.Point(21, 10);
            this.lblBarcodeHeading.Name = "lblBarcodeHeading";
            this.lblBarcodeHeading.Size = new System.Drawing.Size(70, 13);
            this.lblBarcodeHeading.TabIndex = 13;
            this.lblBarcodeHeading.Text = "Adjust Labels";
            // 
            // tcSettingsBarcodes
            // 
            this.tcSettingsBarcodes.Controls.Add(this.tpBarcode);
            this.tcSettingsBarcodes.Controls.Add(this.tpWeight);
            this.tcSettingsBarcodes.Location = new System.Drawing.Point(24, 27);
            this.tcSettingsBarcodes.Name = "tcSettingsBarcodes";
            this.tcSettingsBarcodes.SelectedIndex = 0;
            this.tcSettingsBarcodes.Size = new System.Drawing.Size(459, 478);
            this.tcSettingsBarcodes.TabIndex = 12;
            // 
            // tpBarcode
            // 
            this.tpBarcode.Controls.Add(this.lblQR);
            this.tpBarcode.Controls.Add(this.numQRSize);
            this.tpBarcode.Controls.Add(this.lblWidth);
            this.tpBarcode.Controls.Add(this.lblHeight);
            this.tpBarcode.Controls.Add(this.numBarcodeHeight);
            this.tpBarcode.Controls.Add(this.numBarcodeWidth);
            this.tpBarcode.Controls.Add(this.btnTestPrint);
            this.tpBarcode.Controls.Add(this.lblBar);
            this.tpBarcode.Controls.Add(this.pbQR);
            this.tpBarcode.Controls.Add(this.pnlBarcodeCheckBoxes);
            this.tpBarcode.Controls.Add(this.pbBarcode);
            this.tpBarcode.Location = new System.Drawing.Point(4, 22);
            this.tpBarcode.Name = "tpBarcode";
            this.tpBarcode.Padding = new System.Windows.Forms.Padding(3);
            this.tpBarcode.Size = new System.Drawing.Size(451, 452);
            this.tpBarcode.TabIndex = 0;
            this.tpBarcode.Text = "Barcode / QR";
            this.tpBarcode.UseVisualStyleBackColor = true;
            // 
            // lblQR
            // 
            this.lblQR.AutoSize = true;
            this.lblQR.Location = new System.Drawing.Point(270, 101);
            this.lblQR.Name = "lblQR";
            this.lblQR.Size = new System.Drawing.Size(27, 13);
            this.lblQR.TabIndex = 10;
            this.lblQR.Text = "Size";
            this.lblQR.Visible = false;
            // 
            // numQRSize
            // 
            this.numQRSize.Location = new System.Drawing.Point(313, 99);
            this.numQRSize.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numQRSize.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numQRSize.Name = "numQRSize";
            this.numQRSize.Size = new System.Drawing.Size(79, 20);
            this.numQRSize.TabIndex = 9;
            this.numQRSize.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numQRSize.Visible = false;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(146, 411);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 8;
            this.lblWidth.Text = "Width";
            this.lblWidth.Visible = false;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(146, 368);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 7;
            this.lblHeight.Text = "Height";
            this.lblHeight.Visible = false;
            // 
            // numBarcodeHeight
            // 
            this.numBarcodeHeight.Location = new System.Drawing.Point(208, 368);
            this.numBarcodeHeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numBarcodeHeight.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numBarcodeHeight.Name = "numBarcodeHeight";
            this.numBarcodeHeight.Size = new System.Drawing.Size(79, 20);
            this.numBarcodeHeight.TabIndex = 6;
            this.numBarcodeHeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numBarcodeHeight.Visible = false;
            // 
            // numBarcodeWidth
            // 
            this.numBarcodeWidth.Location = new System.Drawing.Point(208, 409);
            this.numBarcodeWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numBarcodeWidth.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numBarcodeWidth.Name = "numBarcodeWidth";
            this.numBarcodeWidth.Size = new System.Drawing.Size(79, 20);
            this.numBarcodeWidth.TabIndex = 5;
            this.numBarcodeWidth.Value = new decimal(new int[] {
            375,
            0,
            0,
            0});
            this.numBarcodeWidth.Visible = false;
            // 
            // btnTestPrint
            // 
            this.btnTestPrint.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTestPrint.FlatAppearance.BorderSize = 0;
            this.btnTestPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnTestPrint.ForeColor = System.Drawing.Color.White;
            this.btnTestPrint.Location = new System.Drawing.Point(355, 403);
            this.btnTestPrint.Name = "btnTestPrint";
            this.btnTestPrint.Size = new System.Drawing.Size(87, 33);
            this.btnTestPrint.TabIndex = 4;
            this.btnTestPrint.Text = "Test Print";
            this.btnTestPrint.UseVisualStyleBackColor = false;
            this.btnTestPrint.Visible = false;
            this.btnTestPrint.Click += new System.EventHandler(this.btnTestPrint_Click);
            // 
            // lblBar
            // 
            this.lblBar.AutoSize = true;
            this.lblBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBar.Location = new System.Drawing.Point(8, 429);
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(117, 20);
            this.lblBar.TabIndex = 3;
            this.lblBar.Text = "123456789123";
            this.lblBar.Visible = false;
            // 
            // pbQR
            // 
            this.pbQR.Location = new System.Drawing.Point(47, 53);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(205, 186);
            this.pbQR.TabIndex = 2;
            this.pbQR.TabStop = false;
            this.pbQR.Visible = false;
            // 
            // pnlBarcodeCheckBoxes
            // 
            this.pnlBarcodeCheckBoxes.Controls.Add(this.cbBarcode);
            this.pnlBarcodeCheckBoxes.Controls.Add(this.cbQR);
            this.pnlBarcodeCheckBoxes.Location = new System.Drawing.Point(47, 16);
            this.pnlBarcodeCheckBoxes.Name = "pnlBarcodeCheckBoxes";
            this.pnlBarcodeCheckBoxes.Size = new System.Drawing.Size(193, 31);
            this.pnlBarcodeCheckBoxes.TabIndex = 1;
            // 
            // cbBarcode
            // 
            this.cbBarcode.AutoSize = true;
            this.cbBarcode.Location = new System.Drawing.Point(98, 6);
            this.cbBarcode.Name = "cbBarcode";
            this.cbBarcode.Size = new System.Drawing.Size(66, 17);
            this.cbBarcode.TabIndex = 16;
            this.cbBarcode.Text = "Barcode";
            this.cbBarcode.UseVisualStyleBackColor = true;
            this.cbBarcode.CheckedChanged += new System.EventHandler(this.cbBarcode_CheckedChanged);
            // 
            // cbQR
            // 
            this.cbQR.AutoSize = true;
            this.cbQR.Location = new System.Drawing.Point(32, 7);
            this.cbQR.Name = "cbQR";
            this.cbQR.Size = new System.Drawing.Size(42, 17);
            this.cbQR.TabIndex = 15;
            this.cbQR.Text = "QR";
            this.cbQR.UseVisualStyleBackColor = true;
            this.cbQR.CheckedChanged += new System.EventHandler(this.cbQR_CheckedChanged);
            // 
            // pbBarcode
            // 
            this.pbBarcode.Location = new System.Drawing.Point(47, 267);
            this.pbBarcode.Name = "pbBarcode";
            this.pbBarcode.Size = new System.Drawing.Size(358, 84);
            this.pbBarcode.TabIndex = 0;
            this.pbBarcode.TabStop = false;
            this.pbBarcode.Visible = false;
            // 
            // tpWeight
            // 
            this.tpWeight.Controls.Add(this.lblWeightSize);
            this.tpWeight.Controls.Add(this.numWeightTextSize);
            this.tpWeight.Controls.Add(this.lblSettingsWeight);
            this.tpWeight.Controls.Add(this.btnTestKgPrint);
            this.tpWeight.Location = new System.Drawing.Point(4, 22);
            this.tpWeight.Name = "tpWeight";
            this.tpWeight.Padding = new System.Windows.Forms.Padding(3);
            this.tpWeight.Size = new System.Drawing.Size(451, 452);
            this.tpWeight.TabIndex = 1;
            this.tpWeight.Text = "Weight";
            this.tpWeight.UseVisualStyleBackColor = true;
            // 
            // lblWeightSize
            // 
            this.lblWeightSize.AutoSize = true;
            this.lblWeightSize.Location = new System.Drawing.Point(139, 282);
            this.lblWeightSize.Name = "lblWeightSize";
            this.lblWeightSize.Size = new System.Drawing.Size(27, 13);
            this.lblWeightSize.TabIndex = 12;
            this.lblWeightSize.Text = "Size";
            // 
            // numWeightTextSize
            // 
            this.numWeightTextSize.Location = new System.Drawing.Point(182, 280);
            this.numWeightTextSize.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numWeightTextSize.Name = "numWeightTextSize";
            this.numWeightTextSize.Size = new System.Drawing.Size(79, 20);
            this.numWeightTextSize.TabIndex = 11;
            this.numWeightTextSize.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // lblSettingsWeight
            // 
            this.lblSettingsWeight.AutoSize = true;
            this.lblSettingsWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsWeight.Location = new System.Drawing.Point(110, 157);
            this.lblSettingsWeight.Name = "lblSettingsWeight";
            this.lblSettingsWeight.Size = new System.Drawing.Size(180, 76);
            this.lblSettingsWeight.TabIndex = 6;
            this.lblSettingsWeight.Text = "1000";
            // 
            // btnTestKgPrint
            // 
            this.btnTestKgPrint.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTestKgPrint.FlatAppearance.BorderSize = 0;
            this.btnTestKgPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestKgPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnTestKgPrint.ForeColor = System.Drawing.Color.White;
            this.btnTestKgPrint.Location = new System.Drawing.Point(355, 413);
            this.btnTestKgPrint.Name = "btnTestKgPrint";
            this.btnTestKgPrint.Size = new System.Drawing.Size(87, 33);
            this.btnTestKgPrint.TabIndex = 5;
            this.btnTestKgPrint.Text = "Test Print";
            this.btnTestKgPrint.UseVisualStyleBackColor = false;
            this.btnTestKgPrint.Click += new System.EventHandler(this.btnTestKgPrint_Click);
            // 
            // pnlNextPallet
            // 
            this.pnlNextPallet.Controls.Add(this.numNextPallet);
            this.pnlNextPallet.Controls.Add(this.lblNextPalletNum);
            this.pnlNextPallet.Location = new System.Drawing.Point(80, 497);
            this.pnlNextPallet.Name = "pnlNextPallet";
            this.pnlNextPallet.Size = new System.Drawing.Size(323, 65);
            this.pnlNextPallet.TabIndex = 21;
            // 
            // numNextPallet
            // 
            this.numNextPallet.Location = new System.Drawing.Point(156, 26);
            this.numNextPallet.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numNextPallet.Name = "numNextPallet";
            this.numNextPallet.Size = new System.Drawing.Size(152, 20);
            this.numNextPallet.TabIndex = 8;
            // 
            // lblNextPalletNum
            // 
            this.lblNextPalletNum.AutoSize = true;
            this.lblNextPalletNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNextPalletNum.Location = new System.Drawing.Point(3, 26);
            this.lblNextPalletNum.Name = "lblNextPalletNum";
            this.lblNextPalletNum.Size = new System.Drawing.Size(129, 17);
            this.lblNextPalletNum.TabIndex = 9;
            this.lblNextPalletNum.Text = "Next Pallet Number";
            // 
            // pnlPrintCount
            // 
            this.pnlPrintCount.Controls.Add(this.numPrintLabelCount);
            this.pnlPrintCount.Controls.Add(this.lblPrintCount);
            this.pnlPrintCount.Location = new System.Drawing.Point(80, 428);
            this.pnlPrintCount.Name = "pnlPrintCount";
            this.pnlPrintCount.Size = new System.Drawing.Size(323, 65);
            this.pnlPrintCount.TabIndex = 22;
            // 
            // numPrintLabelCount
            // 
            this.numPrintLabelCount.Location = new System.Drawing.Point(156, 27);
            this.numPrintLabelCount.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPrintLabelCount.Name = "numPrintLabelCount";
            this.numPrintLabelCount.Size = new System.Drawing.Size(152, 20);
            this.numPrintLabelCount.TabIndex = 7;
            this.numPrintLabelCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblPrintCount
            // 
            this.lblPrintCount.AutoSize = true;
            this.lblPrintCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPrintCount.Location = new System.Drawing.Point(3, 26);
            this.lblPrintCount.Name = "lblPrintCount";
            this.lblPrintCount.Size = new System.Drawing.Size(131, 17);
            this.lblPrintCount.TabIndex = 9;
            this.lblPrintCount.Text = "Num Labels to print";
            // 
            // pnlPCName
            // 
            this.pnlPCName.Controls.Add(this.txtPCName);
            this.pnlPCName.Controls.Add(this.lblPCName);
            this.pnlPCName.Location = new System.Drawing.Point(80, 45);
            this.pnlPCName.Name = "pnlPCName";
            this.pnlPCName.Size = new System.Drawing.Size(323, 65);
            this.pnlPCName.TabIndex = 19;
            // 
            // txtPCName
            // 
            this.txtPCName.Location = new System.Drawing.Point(156, 23);
            this.txtPCName.MaxLength = 0;
            this.txtPCName.Name = "txtPCName";
            this.txtPCName.Size = new System.Drawing.Size(152, 20);
            this.txtPCName.TabIndex = 1;
            // 
            // lblPCName
            // 
            this.lblPCName.AutoSize = true;
            this.lblPCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPCName.Location = new System.Drawing.Point(3, 26);
            this.lblPCName.Name = "lblPCName";
            this.lblPCName.Size = new System.Drawing.Size(67, 17);
            this.lblPCName.TabIndex = 9;
            this.lblPCName.Text = "PC Name";
            // 
            // pnlWeightUnits
            // 
            this.pnlWeightUnits.Controls.Add(this.ddWeightUnits);
            this.pnlWeightUnits.Controls.Add(this.lblWeightUnits);
            this.pnlWeightUnits.Location = new System.Drawing.Point(80, 289);
            this.pnlWeightUnits.Name = "pnlWeightUnits";
            this.pnlWeightUnits.Size = new System.Drawing.Size(323, 62);
            this.pnlWeightUnits.TabIndex = 20;
            // 
            // ddWeightUnits
            // 
            this.ddWeightUnits.FormattingEnabled = true;
            this.ddWeightUnits.Items.AddRange(new object[] {
            "Kg",
            "g"});
            this.ddWeightUnits.Location = new System.Drawing.Point(156, 22);
            this.ddWeightUnits.Name = "ddWeightUnits";
            this.ddWeightUnits.Size = new System.Drawing.Size(152, 21);
            this.ddWeightUnits.TabIndex = 5;
            // 
            // lblWeightUnits
            // 
            this.lblWeightUnits.AutoSize = true;
            this.lblWeightUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblWeightUnits.Location = new System.Drawing.Point(3, 26);
            this.lblWeightUnits.Name = "lblWeightUnits";
            this.lblWeightUnits.Size = new System.Drawing.Size(86, 17);
            this.lblWeightUnits.TabIndex = 9;
            this.lblWeightUnits.Text = "Weight units";
            // 
            // pnlBarcodePrefix
            // 
            this.pnlBarcodePrefix.Controls.Add(this.txtBarcodePrefix);
            this.pnlBarcodePrefix.Controls.Add(this.lblBarcodePrefix);
            this.pnlBarcodePrefix.Location = new System.Drawing.Point(80, 357);
            this.pnlBarcodePrefix.Name = "pnlBarcodePrefix";
            this.pnlBarcodePrefix.Size = new System.Drawing.Size(323, 65);
            this.pnlBarcodePrefix.TabIndex = 18;
            // 
            // txtBarcodePrefix
            // 
            this.txtBarcodePrefix.Location = new System.Drawing.Point(156, 23);
            this.txtBarcodePrefix.MaxLength = 10;
            this.txtBarcodePrefix.Name = "txtBarcodePrefix";
            this.txtBarcodePrefix.Size = new System.Drawing.Size(152, 20);
            this.txtBarcodePrefix.TabIndex = 6;
            // 
            // lblBarcodePrefix
            // 
            this.lblBarcodePrefix.AutoSize = true;
            this.lblBarcodePrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblBarcodePrefix.Location = new System.Drawing.Point(3, 26);
            this.lblBarcodePrefix.Name = "lblBarcodePrefix";
            this.lblBarcodePrefix.Size = new System.Drawing.Size(139, 17);
            this.lblBarcodePrefix.TabIndex = 9;
            this.lblBarcodePrefix.Text = "Pallet Barcode Prefix";
            // 
            // pnlAvailablePresets
            // 
            this.pnlAvailablePresets.Controls.Add(this.lblScalePreset);
            this.pnlAvailablePresets.Controls.Add(this.ddPreset);
            this.pnlAvailablePresets.Location = new System.Drawing.Point(80, 224);
            this.pnlAvailablePresets.Name = "pnlAvailablePresets";
            this.pnlAvailablePresets.Size = new System.Drawing.Size(323, 59);
            this.pnlAvailablePresets.TabIndex = 17;
            // 
            // lblScalePreset
            // 
            this.lblScalePreset.AutoSize = true;
            this.lblScalePreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblScalePreset.Location = new System.Drawing.Point(3, 23);
            this.lblScalePreset.Name = "lblScalePreset";
            this.lblScalePreset.Size = new System.Drawing.Size(117, 17);
            this.lblScalePreset.TabIndex = 9;
            this.lblScalePreset.Text = "Available Presets";
            // 
            // ddPreset
            // 
            this.ddPreset.FormattingEnabled = true;
            this.ddPreset.Items.AddRange(new object[] {
            "FarmTrace Internal",
            "Massamatic",
            "Richter"});
            this.ddPreset.Location = new System.Drawing.Point(156, 19);
            this.ddPreset.Name = "ddPreset";
            this.ddPreset.Size = new System.Drawing.Size(152, 21);
            this.ddPreset.TabIndex = 4;
            // 
            // pnlSerialConnection
            // 
            this.pnlSerialConnection.Controls.Add(this.lblBaudRate);
            this.pnlSerialConnection.Controls.Add(this.lblComPort);
            this.pnlSerialConnection.Controls.Add(this.ddBaudRate);
            this.pnlSerialConnection.Controls.Add(this.ddComPorts);
            this.pnlSerialConnection.Location = new System.Drawing.Point(80, 116);
            this.pnlSerialConnection.Name = "pnlSerialConnection";
            this.pnlSerialConnection.Size = new System.Drawing.Size(323, 102);
            this.pnlSerialConnection.TabIndex = 16;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblBaudRate.Location = new System.Drawing.Point(6, 64);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(75, 17);
            this.lblBaudRate.TabIndex = 10;
            this.lblBaudRate.Text = "Baud Rate";
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblComPort.Location = new System.Drawing.Point(6, 17);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(69, 17);
            this.lblComPort.TabIndex = 9;
            this.lblComPort.Text = "COM Port";
            // 
            // ddBaudRate
            // 
            this.ddBaudRate.FormattingEnabled = true;
            this.ddBaudRate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.ddBaudRate.Location = new System.Drawing.Point(156, 64);
            this.ddBaudRate.Name = "ddBaudRate";
            this.ddBaudRate.Size = new System.Drawing.Size(152, 21);
            this.ddBaudRate.TabIndex = 3;
            // 
            // ddComPorts
            // 
            this.ddComPorts.BackColor = System.Drawing.Color.White;
            this.ddComPorts.FormattingEnabled = true;
            this.ddComPorts.Location = new System.Drawing.Point(156, 13);
            this.ddComPorts.Name = "ddComPorts";
            this.ddComPorts.Size = new System.Drawing.Size(152, 21);
            this.ddComPorts.TabIndex = 2;
            // 
            // pnlSettingsFooter
            // 
            this.pnlSettingsFooter.Controls.Add(this.btnSettingsSave);
            this.pnlSettingsFooter.Controls.Add(this.btnSettingsClose);
            this.pnlSettingsFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSettingsFooter.Location = new System.Drawing.Point(0, 206);
            this.pnlSettingsFooter.Name = "pnlSettingsFooter";
            this.pnlSettingsFooter.Size = new System.Drawing.Size(478, 60);
            this.pnlSettingsFooter.TabIndex = 14;
            // 
            // btnSettingsSave
            // 
            this.btnSettingsSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSettingsSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSettingsSave.FlatAppearance.BorderSize = 0;
            this.btnSettingsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnSettingsSave.ForeColor = System.Drawing.Color.White;
            this.btnSettingsSave.Location = new System.Drawing.Point(0, 0);
            this.btnSettingsSave.Name = "btnSettingsSave";
            this.btnSettingsSave.Size = new System.Drawing.Size(109, 60);
            this.btnSettingsSave.TabIndex = 3;
            this.btnSettingsSave.Text = "Save Settings";
            this.btnSettingsSave.UseVisualStyleBackColor = false;
            this.btnSettingsSave.Click += new System.EventHandler(this.btnSettingsSave_Click);
            // 
            // btnSettingsClose
            // 
            this.btnSettingsClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnSettingsClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSettingsClose.FlatAppearance.BorderSize = 0;
            this.btnSettingsClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSettingsClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnSettingsClose.ForeColor = System.Drawing.Color.White;
            this.btnSettingsClose.Location = new System.Drawing.Point(369, 0);
            this.btnSettingsClose.Name = "btnSettingsClose";
            this.btnSettingsClose.Size = new System.Drawing.Size(109, 60);
            this.btnSettingsClose.TabIndex = 6;
            this.btnSettingsClose.Text = "Back";
            this.btnSettingsClose.UseVisualStyleBackColor = false;
            this.btnSettingsClose.Click += new System.EventHandler(this.btnSettingsClose_Click);
            // 
            // pnlSettingsHeader
            // 
            this.pnlSettingsHeader.Controls.Add(this.btnSettingsHeading);
            this.pnlSettingsHeader.Controls.Add(this.btnLogout);
            this.pnlSettingsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSettingsHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlSettingsHeader.Name = "pnlSettingsHeader";
            this.pnlSettingsHeader.Size = new System.Drawing.Size(478, 39);
            this.pnlSettingsHeader.TabIndex = 0;
            // 
            // btnSettingsHeading
            // 
            this.btnSettingsHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(178)))));
            this.btnSettingsHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettingsHeading.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(178)))));
            this.btnSettingsHeading.FlatAppearance.BorderSize = 0;
            this.btnSettingsHeading.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(178)))));
            this.btnSettingsHeading.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(178)))));
            this.btnSettingsHeading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnSettingsHeading.ForeColor = System.Drawing.Color.White;
            this.btnSettingsHeading.Location = new System.Drawing.Point(0, 0);
            this.btnSettingsHeading.Name = "btnSettingsHeading";
            this.btnSettingsHeading.Size = new System.Drawing.Size(376, 39);
            this.btnSettingsHeading.TabIndex = 11;
            this.btnSettingsHeading.Text = "Settings";
            this.btnSettingsHeading.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(376, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(102, 39);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlPalletizing
            // 
            this.pnlPalletizing.BackColor = System.Drawing.Color.White;
            this.pnlPalletizing.Controls.Add(this.ddgvPalletizing);
            this.pnlPalletizing.Controls.Add(this.pnlPalletizingFooter);
            this.pnlPalletizing.Controls.Add(this.pnlPalletizingHeader);
            this.pnlPalletizing.Location = new System.Drawing.Point(525, 20);
            this.pnlPalletizing.Name = "pnlPalletizing";
            this.pnlPalletizing.Size = new System.Drawing.Size(525, 206);
            this.pnlPalletizing.TabIndex = 12;
            this.pnlPalletizing.Visible = false;
            // 
            // ddgvPalletizing
            // 
            this.ddgvPalletizing.AllowUserToAddRows = false;
            this.ddgvPalletizing.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ddgvPalletizing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ddgvPalletizing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ddgvPalletizing.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ddgvPalletizing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ddgvPalletizing.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ddgvPalletizing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ddgvPalletizing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ddgvPalletizing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ddgvPalletizing.DefaultCellStyle = dataGridViewCellStyle3;
            this.ddgvPalletizing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddgvPalletizing.EnableHeadersVisualStyles = false;
            this.ddgvPalletizing.Location = new System.Drawing.Point(0, 39);
            this.ddgvPalletizing.MultiSelect = false;
            this.ddgvPalletizing.Name = "ddgvPalletizing";
            this.ddgvPalletizing.ReadOnly = true;
            this.ddgvPalletizing.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ddgvPalletizing.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ddgvPalletizing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ddgvPalletizing.Size = new System.Drawing.Size(525, 107);
            this.ddgvPalletizing.TabIndex = 2;
            this.ddgvPalletizing.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ddgvPalletizing_CellFormatting);
            this.ddgvPalletizing.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ddgvPalletizing_CellContentClick);
            // 
            // pnlPalletizingFooter
            // 
            this.pnlPalletizingFooter.Controls.Add(this.lblUp);
            this.pnlPalletizingFooter.Controls.Add(this.progressBarUp);
            this.pnlPalletizingFooter.Controls.Add(this.btnUploadRecords);
            this.pnlPalletizingFooter.Controls.Add(this.btnPallAddPallet);
            this.pnlPalletizingFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPalletizingFooter.Location = new System.Drawing.Point(0, 146);
            this.pnlPalletizingFooter.Name = "pnlPalletizingFooter";
            this.pnlPalletizingFooter.Size = new System.Drawing.Size(525, 60);
            this.pnlPalletizingFooter.TabIndex = 1;
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.Location = new System.Drawing.Point(358, 8);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(98, 13);
            this.lblUp.TabIndex = 18;
            this.lblUp.Text = "Uploading Records";
            this.lblUp.Visible = false;
            // 
            // progressBarUp
            // 
            this.progressBarUp.Location = new System.Drawing.Point(278, 24);
            this.progressBarUp.Name = "progressBarUp";
            this.progressBarUp.Size = new System.Drawing.Size(258, 28);
            this.progressBarUp.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarUp.TabIndex = 17;
            this.progressBarUp.Visible = false;
            // 
            // btnUploadRecords
            // 
            this.btnUploadRecords.BackColor = System.Drawing.Color.Firebrick;
            this.btnUploadRecords.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUploadRecords.FlatAppearance.BorderSize = 0;
            this.btnUploadRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnUploadRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnUploadRecords.ForeColor = System.Drawing.Color.White;
            this.btnUploadRecords.Location = new System.Drawing.Point(416, 0);
            this.btnUploadRecords.Name = "btnUploadRecords";
            this.btnUploadRecords.Size = new System.Drawing.Size(109, 60);
            this.btnUploadRecords.TabIndex = 7;
            this.btnUploadRecords.Text = "UploadRecords";
            this.btnUploadRecords.UseVisualStyleBackColor = false;
            this.btnUploadRecords.Click += new System.EventHandler(this.btnUploadRecords_Click);
            // 
            // btnPallAddPallet
            // 
            this.btnPallAddPallet.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPallAddPallet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPallAddPallet.FlatAppearance.BorderSize = 0;
            this.btnPallAddPallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPallAddPallet.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnPallAddPallet.ForeColor = System.Drawing.Color.White;
            this.btnPallAddPallet.Location = new System.Drawing.Point(0, 0);
            this.btnPallAddPallet.Name = "btnPallAddPallet";
            this.btnPallAddPallet.Size = new System.Drawing.Size(109, 60);
            this.btnPallAddPallet.TabIndex = 4;
            this.btnPallAddPallet.Text = "Insert";
            this.btnPallAddPallet.UseVisualStyleBackColor = false;
            this.btnPallAddPallet.Click += new System.EventHandler(this.btnPallAddPallet_Click);
            // 
            // pnlPalletizingHeader
            // 
            this.pnlPalletizingHeader.Controls.Add(this.btnPalletizingHeader);
            this.pnlPalletizingHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPalletizingHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlPalletizingHeader.Name = "pnlPalletizingHeader";
            this.pnlPalletizingHeader.Size = new System.Drawing.Size(525, 39);
            this.pnlPalletizingHeader.TabIndex = 0;
            // 
            // btnPalletizingHeader
            // 
            this.btnPalletizingHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(178)))));
            this.btnPalletizingHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPalletizingHeader.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(178)))));
            this.btnPalletizingHeader.FlatAppearance.BorderSize = 0;
            this.btnPalletizingHeader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(178)))));
            this.btnPalletizingHeader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(178)))));
            this.btnPalletizingHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPalletizingHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnPalletizingHeader.ForeColor = System.Drawing.Color.White;
            this.btnPalletizingHeader.Location = new System.Drawing.Point(0, 0);
            this.btnPalletizingHeader.Name = "btnPalletizingHeader";
            this.btnPalletizingHeader.Size = new System.Drawing.Size(525, 39);
            this.btnPalletizingHeader.TabIndex = 1;
            this.btnPalletizingHeader.Text = "Palletizing";
            this.btnPalletizingHeader.UseVisualStyleBackColor = false;
            // 
            // pnlAddPallet
            // 
            this.pnlAddPallet.BackColor = System.Drawing.Color.White;
            this.pnlAddPallet.Controls.Add(this.pnlAddPalletHeader);
            this.pnlAddPallet.Controls.Add(this.panel5);
            this.pnlAddPallet.Location = new System.Drawing.Point(1067, 20);
            this.pnlAddPallet.Name = "pnlAddPallet";
            this.pnlAddPallet.Size = new System.Drawing.Size(816, 629);
            this.pnlAddPallet.TabIndex = 3;
            this.pnlAddPallet.Visible = false;
            // 
            // pnlAddPalletHeader
            // 
            this.pnlAddPalletHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(148)))));
            this.pnlAddPalletHeader.Controls.Add(this.btnAddPalletHeader);
            this.pnlAddPalletHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddPalletHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlAddPalletHeader.Name = "pnlAddPalletHeader";
            this.pnlAddPalletHeader.Size = new System.Drawing.Size(816, 39);
            this.pnlAddPalletHeader.TabIndex = 4;
            // 
            // btnAddPalletHeader
            // 
            this.btnAddPalletHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(178)))));
            this.btnAddPalletHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddPalletHeader.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(178)))));
            this.btnAddPalletHeader.FlatAppearance.BorderSize = 0;
            this.btnAddPalletHeader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(178)))));
            this.btnAddPalletHeader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(178)))));
            this.btnAddPalletHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPalletHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnAddPalletHeader.ForeColor = System.Drawing.Color.White;
            this.btnAddPalletHeader.Location = new System.Drawing.Point(0, 0);
            this.btnAddPalletHeader.Name = "btnAddPalletHeader";
            this.btnAddPalletHeader.Size = new System.Drawing.Size(816, 39);
            this.btnAddPalletHeader.TabIndex = 2;
            this.btnAddPalletHeader.Text = "Add Pallet";
            this.btnAddPalletHeader.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.numAddPalletPallets);
            this.panel5.Controls.Add(this.btnAddPalletAdd);
            this.panel5.Controls.Add(this.btnAddPalletCancel);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.pnlScale1);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(139, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(677, 591);
            this.panel5.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label15.Location = new System.Drawing.Point(60, 411);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(235, 31);
            this.label15.TabIndex = 35;
            this.label15.Text = "Number Of Pallets";
            // 
            // numAddPalletPallets
            // 
            this.numAddPalletPallets.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.numAddPalletPallets.Location = new System.Drawing.Point(111, 445);
            this.numAddPalletPallets.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAddPalletPallets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAddPalletPallets.Name = "numAddPalletPallets";
            this.numAddPalletPallets.Size = new System.Drawing.Size(93, 68);
            this.numAddPalletPallets.TabIndex = 35;
            this.numAddPalletPallets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddPalletAdd
            // 
            this.btnAddPalletAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddPalletAdd.FlatAppearance.BorderSize = 0;
            this.btnAddPalletAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPalletAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnAddPalletAdd.ForeColor = System.Drawing.Color.White;
            this.btnAddPalletAdd.Location = new System.Drawing.Point(156, 536);
            this.btnAddPalletAdd.Name = "btnAddPalletAdd";
            this.btnAddPalletAdd.Size = new System.Drawing.Size(166, 45);
            this.btnAddPalletAdd.TabIndex = 33;
            this.btnAddPalletAdd.Text = "Weigh And Add";
            this.btnAddPalletAdd.UseVisualStyleBackColor = false;
            this.btnAddPalletAdd.Click += new System.EventHandler(this.btnAddPalletAdd_Click);
            // 
            // btnAddPalletCancel
            // 
            this.btnAddPalletCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnAddPalletCancel.FlatAppearance.BorderSize = 0;
            this.btnAddPalletCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddPalletCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPalletCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnAddPalletCancel.ForeColor = System.Drawing.Color.White;
            this.btnAddPalletCancel.Location = new System.Drawing.Point(328, 536);
            this.btnAddPalletCancel.Name = "btnAddPalletCancel";
            this.btnAddPalletCancel.Size = new System.Drawing.Size(166, 45);
            this.btnAddPalletCancel.TabIndex = 34;
            this.btnAddPalletCancel.Text = "Cancel";
            this.btnAddPalletCancel.UseVisualStyleBackColor = false;
            this.btnAddPalletCancel.Click += new System.EventHandler(this.btnAddPalletCancel_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.ddAddPalletBrand);
            this.panel6.Controls.Add(this.ddAddPalletGrade);
            this.panel6.Controls.Add(this.ddAddPalletCount);
            this.panel6.Controls.Add(this.ddAddPalletPackType);
            this.panel6.Controls.Add(this.numAddPalletPackQTY);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(18, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(306, 394);
            this.panel6.TabIndex = 32;
            // 
            // ddAddPalletBrand
            // 
            this.ddAddPalletBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddAddPalletBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.ddAddPalletBrand.FormattingEnabled = true;
            this.ddAddPalletBrand.Location = new System.Drawing.Point(20, 76);
            this.ddAddPalletBrand.Name = "ddAddPalletBrand";
            this.ddAddPalletBrand.Size = new System.Drawing.Size(256, 29);
            this.ddAddPalletBrand.TabIndex = 37;
            this.ddAddPalletBrand.SelectedIndexChanged += new System.EventHandler(this.ddAddPalletBrand_SelectedIndexChanged);
            // 
            // ddAddPalletGrade
            // 
            this.ddAddPalletGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddAddPalletGrade.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.ddAddPalletGrade.FormattingEnabled = true;
            this.ddAddPalletGrade.Location = new System.Drawing.Point(23, 270);
            this.ddAddPalletGrade.Name = "ddAddPalletGrade";
            this.ddAddPalletGrade.Size = new System.Drawing.Size(253, 29);
            this.ddAddPalletGrade.TabIndex = 36;
            // 
            // ddAddPalletCount
            // 
            this.ddAddPalletCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddAddPalletCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddAddPalletCount.FormattingEnabled = true;
            this.ddAddPalletCount.Location = new System.Drawing.Point(21, 337);
            this.ddAddPalletCount.MaxDropDownItems = 10;
            this.ddAddPalletCount.Name = "ddAddPalletCount";
            this.ddAddPalletCount.Size = new System.Drawing.Size(255, 29);
            this.ddAddPalletCount.Sorted = true;
            this.ddAddPalletCount.TabIndex = 35;
            // 
            // ddAddPalletPackType
            // 
            this.ddAddPalletPackType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddAddPalletPackType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddAddPalletPackType.FormattingEnabled = true;
            this.ddAddPalletPackType.Location = new System.Drawing.Point(21, 136);
            this.ddAddPalletPackType.MaxDropDownItems = 10;
            this.ddAddPalletPackType.Name = "ddAddPalletPackType";
            this.ddAddPalletPackType.Size = new System.Drawing.Size(255, 29);
            this.ddAddPalletPackType.Sorted = true;
            this.ddAddPalletPackType.TabIndex = 33;
            this.ddAddPalletPackType.SelectedIndexChanged += new System.EventHandler(this.ddAddPalletPackType_SelectedIndexChanged);
            this.ddAddPalletPackType.DropDownClosed += new System.EventHandler(this.ddAddPalletPackType_DropDownClosed);
            // 
            // numAddPalletPackQTY
            // 
            this.numAddPalletPackQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAddPalletPackQTY.Location = new System.Drawing.Point(23, 203);
            this.numAddPalletPackQTY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numAddPalletPackQTY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAddPalletPackQTY.Name = "numAddPalletPackQTY";
            this.numAddPalletPackQTY.Size = new System.Drawing.Size(253, 29);
            this.numAddPalletPackQTY.TabIndex = 33;
            this.numAddPalletPackQTY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "Pack QTY";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 310);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 24);
            this.label14.TabIndex = 19;
            this.label14.Text = "Count / Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Grade";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel7.Controls.Add(this.label11);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(304, 30);
            this.panel7.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(50, -1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 31);
            this.label11.TabIndex = 1;
            this.label11.Text = "Pallet Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pack Type";
            // 
            // pnlScale1
            // 
            this.pnlScale1.Controls.Add(this.txtAddPalletScaleWeight);
            this.pnlScale1.Controls.Add(this.label13);
            this.pnlScale1.Location = new System.Drawing.Point(363, 411);
            this.pnlScale1.Name = "pnlScale1";
            this.pnlScale1.Size = new System.Drawing.Size(271, 119);
            this.pnlScale1.TabIndex = 31;
            // 
            // txtAddPalletScaleWeight
            // 
            this.txtAddPalletScaleWeight.Enabled = false;
            this.txtAddPalletScaleWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.txtAddPalletScaleWeight.Location = new System.Drawing.Point(18, 34);
            this.txtAddPalletScaleWeight.Name = "txtAddPalletScaleWeight";
            this.txtAddPalletScaleWeight.Size = new System.Drawing.Size(239, 68);
            this.txtAddPalletScaleWeight.TabIndex = 34;
            this.txtAddPalletScaleWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label13.Location = new System.Drawing.Point(64, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 31);
            this.label13.TabIndex = 0;
            this.label13.Text = "Weight (Kg)";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblAddPalletCultivar);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblAddPalletProdUnit);
            this.panel3.Controls.Add(this.lblAddPalletComm);
            this.panel3.Controls.Add(this.lblAddPalletOrch);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblAddPalletBlock);
            this.panel3.Location = new System.Drawing.Point(354, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 394);
            this.panel3.TabIndex = 25;
            // 
            // lblAddPalletCultivar
            // 
            this.lblAddPalletCultivar.AutoSize = true;
            this.lblAddPalletCultivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPalletCultivar.Location = new System.Drawing.Point(25, 338);
            this.lblAddPalletCultivar.Name = "lblAddPalletCultivar";
            this.lblAddPalletCultivar.Size = new System.Drawing.Size(47, 24);
            this.lblAddPalletCultivar.TabIndex = 25;
            this.lblAddPalletCultivar.Text = "Text";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "Cultivar";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(302, 30);
            this.panel4.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(253, 31);
            this.label12.TabIndex = 1;
            this.label12.Text = "Current Run Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Production Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Orchard";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Block";
            // 
            // lblAddPalletProdUnit
            // 
            this.lblAddPalletProdUnit.AutoSize = true;
            this.lblAddPalletProdUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPalletProdUnit.Location = new System.Drawing.Point(25, 71);
            this.lblAddPalletProdUnit.Name = "lblAddPalletProdUnit";
            this.lblAddPalletProdUnit.Size = new System.Drawing.Size(47, 24);
            this.lblAddPalletProdUnit.TabIndex = 13;
            this.lblAddPalletProdUnit.Text = "Text";
            // 
            // lblAddPalletComm
            // 
            this.lblAddPalletComm.AutoSize = true;
            this.lblAddPalletComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPalletComm.Location = new System.Drawing.Point(25, 268);
            this.lblAddPalletComm.Name = "lblAddPalletComm";
            this.lblAddPalletComm.Size = new System.Drawing.Size(47, 24);
            this.lblAddPalletComm.TabIndex = 20;
            this.lblAddPalletComm.Text = "Text";
            // 
            // lblAddPalletOrch
            // 
            this.lblAddPalletOrch.AutoSize = true;
            this.lblAddPalletOrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPalletOrch.Location = new System.Drawing.Point(25, 137);
            this.lblAddPalletOrch.Name = "lblAddPalletOrch";
            this.lblAddPalletOrch.Size = new System.Drawing.Size(47, 24);
            this.lblAddPalletOrch.TabIndex = 14;
            this.lblAddPalletOrch.Text = "Text";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Commodity";
            // 
            // lblAddPalletBlock
            // 
            this.lblAddPalletBlock.AutoSize = true;
            this.lblAddPalletBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPalletBlock.Location = new System.Drawing.Point(25, 204);
            this.lblAddPalletBlock.Name = "lblAddPalletBlock";
            this.lblAddPalletBlock.Size = new System.Drawing.Size(47, 24);
            this.lblAddPalletBlock.TabIndex = 15;
            this.lblAddPalletBlock.Text = "Text";
            // 
            // pnlCreateRun
            // 
            this.pnlCreateRun.BackColor = System.Drawing.Color.White;
            this.pnlCreateRun.Controls.Add(this.pnlCenterCreateRun);
            this.pnlCreateRun.Controls.Add(this.pnlCreateRunHeading);
            this.pnlCreateRun.Controls.Add(this.btnCreateRunClose);
            this.pnlCreateRun.Location = new System.Drawing.Point(19, 316);
            this.pnlCreateRun.Name = "pnlCreateRun";
            this.pnlCreateRun.Size = new System.Drawing.Size(588, 204);
            this.pnlCreateRun.TabIndex = 4;
            this.pnlCreateRun.Visible = false;
            // 
            // pnlCenterCreateRun
            // 
            this.pnlCenterCreateRun.Controls.Add(this.ddCreateRunCultivar);
            this.pnlCenterCreateRun.Controls.Add(this.btnCreateRunSave);
            this.pnlCenterCreateRun.Controls.Add(this.ddCreateRunComm);
            this.pnlCenterCreateRun.Controls.Add(this.lblCreateRunCultivar);
            this.pnlCenterCreateRun.Controls.Add(this.ddCreateRunBlock);
            this.pnlCenterCreateRun.Controls.Add(this.ddCreateRunOrch);
            this.pnlCenterCreateRun.Controls.Add(this.ddCreateRunProdUnit);
            this.pnlCenterCreateRun.Controls.Add(this.lblCreateRunComm);
            this.pnlCenterCreateRun.Controls.Add(this.lblCreateRunBlock);
            this.pnlCenterCreateRun.Controls.Add(this.lblCreateRunOrchard);
            this.pnlCenterCreateRun.Controls.Add(this.lblCreateRunProdUnit);
            this.pnlCenterCreateRun.Location = new System.Drawing.Point(289, 48);
            this.pnlCenterCreateRun.Name = "pnlCenterCreateRun";
            this.pnlCenterCreateRun.Size = new System.Drawing.Size(422, 460);
            this.pnlCenterCreateRun.TabIndex = 10;
            // 
            // ddCreateRunCultivar
            // 
            this.ddCreateRunCultivar.Enabled = false;
            this.ddCreateRunCultivar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddCreateRunCultivar.FormattingEnabled = true;
            this.ddCreateRunCultivar.Location = new System.Drawing.Point(53, 337);
            this.ddCreateRunCultivar.MaxDropDownItems = 10;
            this.ddCreateRunCultivar.Name = "ddCreateRunCultivar";
            this.ddCreateRunCultivar.Size = new System.Drawing.Size(213, 29);
            this.ddCreateRunCultivar.Sorted = true;
            this.ddCreateRunCultivar.TabIndex = 11;
            // 
            // btnCreateRunSave
            // 
            this.btnCreateRunSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateRunSave.FlatAppearance.BorderSize = 0;
            this.btnCreateRunSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRunSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnCreateRunSave.ForeColor = System.Drawing.Color.White;
            this.btnCreateRunSave.Location = new System.Drawing.Point(53, 397);
            this.btnCreateRunSave.Name = "btnCreateRunSave";
            this.btnCreateRunSave.Size = new System.Drawing.Size(213, 45);
            this.btnCreateRunSave.TabIndex = 7;
            this.btnCreateRunSave.Text = "Save Settings";
            this.btnCreateRunSave.UseVisualStyleBackColor = false;
            this.btnCreateRunSave.Click += new System.EventHandler(this.btnCreateRunSave_Click);
            // 
            // ddCreateRunComm
            // 
            this.ddCreateRunComm.Enabled = false;
            this.ddCreateRunComm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddCreateRunComm.FormattingEnabled = true;
            this.ddCreateRunComm.Location = new System.Drawing.Point(53, 263);
            this.ddCreateRunComm.MaxDropDownItems = 10;
            this.ddCreateRunComm.Name = "ddCreateRunComm";
            this.ddCreateRunComm.Size = new System.Drawing.Size(213, 29);
            this.ddCreateRunComm.Sorted = true;
            this.ddCreateRunComm.TabIndex = 10;
            this.ddCreateRunComm.SelectedIndexChanged += new System.EventHandler(this.ddCreateRunComm_SelectedIndexChanged);
            // 
            // lblCreateRunCultivar
            // 
            this.lblCreateRunCultivar.AutoSize = true;
            this.lblCreateRunCultivar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateRunCultivar.Location = new System.Drawing.Point(50, 313);
            this.lblCreateRunCultivar.Name = "lblCreateRunCultivar";
            this.lblCreateRunCultivar.Size = new System.Drawing.Size(65, 21);
            this.lblCreateRunCultivar.TabIndex = 11;
            this.lblCreateRunCultivar.Text = "Cultivar";
            // 
            // ddCreateRunBlock
            // 
            this.ddCreateRunBlock.Enabled = false;
            this.ddCreateRunBlock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddCreateRunBlock.FormattingEnabled = true;
            this.ddCreateRunBlock.Location = new System.Drawing.Point(53, 193);
            this.ddCreateRunBlock.MaxDropDownItems = 10;
            this.ddCreateRunBlock.Name = "ddCreateRunBlock";
            this.ddCreateRunBlock.Size = new System.Drawing.Size(213, 29);
            this.ddCreateRunBlock.Sorted = true;
            this.ddCreateRunBlock.TabIndex = 9;
            this.ddCreateRunBlock.SelectedIndexChanged += new System.EventHandler(this.ddCreateRunBlock_SelectedIndexChanged);
            // 
            // ddCreateRunOrch
            // 
            this.ddCreateRunOrch.Enabled = false;
            this.ddCreateRunOrch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddCreateRunOrch.FormattingEnabled = true;
            this.ddCreateRunOrch.Location = new System.Drawing.Point(53, 118);
            this.ddCreateRunOrch.MaxDropDownItems = 10;
            this.ddCreateRunOrch.Name = "ddCreateRunOrch";
            this.ddCreateRunOrch.Size = new System.Drawing.Size(213, 29);
            this.ddCreateRunOrch.Sorted = true;
            this.ddCreateRunOrch.TabIndex = 8;
            this.ddCreateRunOrch.SelectedIndexChanged += new System.EventHandler(this.ddCreateRunOrch_SelectedIndexChanged);
            // 
            // ddCreateRunProdUnit
            // 
            this.ddCreateRunProdUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddCreateRunProdUnit.FormattingEnabled = true;
            this.ddCreateRunProdUnit.Location = new System.Drawing.Point(53, 47);
            this.ddCreateRunProdUnit.MaxDropDownItems = 10;
            this.ddCreateRunProdUnit.Name = "ddCreateRunProdUnit";
            this.ddCreateRunProdUnit.Size = new System.Drawing.Size(213, 29);
            this.ddCreateRunProdUnit.Sorted = true;
            this.ddCreateRunProdUnit.TabIndex = 7;
            this.ddCreateRunProdUnit.SelectedIndexChanged += new System.EventHandler(this.ddCreateRunProdUnit_SelectedIndexChanged);
            // 
            // lblCreateRunComm
            // 
            this.lblCreateRunComm.AutoSize = true;
            this.lblCreateRunComm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateRunComm.Location = new System.Drawing.Point(50, 239);
            this.lblCreateRunComm.Name = "lblCreateRunComm";
            this.lblCreateRunComm.Size = new System.Drawing.Size(96, 21);
            this.lblCreateRunComm.TabIndex = 3;
            this.lblCreateRunComm.Text = "Commodity";
            // 
            // lblCreateRunBlock
            // 
            this.lblCreateRunBlock.AutoSize = true;
            this.lblCreateRunBlock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateRunBlock.Location = new System.Drawing.Point(50, 169);
            this.lblCreateRunBlock.Name = "lblCreateRunBlock";
            this.lblCreateRunBlock.Size = new System.Drawing.Size(50, 21);
            this.lblCreateRunBlock.TabIndex = 2;
            this.lblCreateRunBlock.Text = "Block";
            // 
            // lblCreateRunOrchard
            // 
            this.lblCreateRunOrchard.AutoSize = true;
            this.lblCreateRunOrchard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateRunOrchard.Location = new System.Drawing.Point(50, 94);
            this.lblCreateRunOrchard.Name = "lblCreateRunOrchard";
            this.lblCreateRunOrchard.Size = new System.Drawing.Size(69, 21);
            this.lblCreateRunOrchard.TabIndex = 1;
            this.lblCreateRunOrchard.Text = "Orchard";
            // 
            // lblCreateRunProdUnit
            // 
            this.lblCreateRunProdUnit.AutoSize = true;
            this.lblCreateRunProdUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateRunProdUnit.Location = new System.Drawing.Point(49, 23);
            this.lblCreateRunProdUnit.Name = "lblCreateRunProdUnit";
            this.lblCreateRunProdUnit.Size = new System.Drawing.Size(125, 21);
            this.lblCreateRunProdUnit.TabIndex = 0;
            this.lblCreateRunProdUnit.Text = "Production Unit";
            // 
            // pnlCreateRunHeading
            // 
            this.pnlCreateRunHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(178)))));
            this.pnlCreateRunHeading.Controls.Add(this.btnCreateRunHeading);
            this.pnlCreateRunHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCreateRunHeading.Location = new System.Drawing.Point(0, 0);
            this.pnlCreateRunHeading.Name = "pnlCreateRunHeading";
            this.pnlCreateRunHeading.Size = new System.Drawing.Size(588, 39);
            this.pnlCreateRunHeading.TabIndex = 9;
            // 
            // btnCreateRunHeading
            // 
            this.btnCreateRunHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(178)))));
            this.btnCreateRunHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateRunHeading.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(178)))));
            this.btnCreateRunHeading.FlatAppearance.BorderSize = 0;
            this.btnCreateRunHeading.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(178)))));
            this.btnCreateRunHeading.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(178)))));
            this.btnCreateRunHeading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRunHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnCreateRunHeading.ForeColor = System.Drawing.Color.White;
            this.btnCreateRunHeading.Location = new System.Drawing.Point(0, 0);
            this.btnCreateRunHeading.Name = "btnCreateRunHeading";
            this.btnCreateRunHeading.Size = new System.Drawing.Size(588, 39);
            this.btnCreateRunHeading.TabIndex = 0;
            this.btnCreateRunHeading.Text = "Create Run";
            this.btnCreateRunHeading.UseVisualStyleBackColor = false;
            // 
            // btnCreateRunClose
            // 
            this.btnCreateRunClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnCreateRunClose.FlatAppearance.BorderSize = 0;
            this.btnCreateRunClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateRunClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRunClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnCreateRunClose.ForeColor = System.Drawing.Color.White;
            this.btnCreateRunClose.Location = new System.Drawing.Point(390, 514);
            this.btnCreateRunClose.Name = "btnCreateRunClose";
            this.btnCreateRunClose.Size = new System.Drawing.Size(109, 45);
            this.btnCreateRunClose.TabIndex = 11;
            this.btnCreateRunClose.Text = "Back";
            this.btnCreateRunClose.UseVisualStyleBackColor = false;
            this.btnCreateRunClose.Click += new System.EventHandler(this.btnCreateRunClose_Click);
            // 
            // contextMenuPalletizing
            // 
            this.contextMenuPalletizing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printMassToolStripMenuItem,
            this.printPalletNumberToolStripMenuItem,
            this.printBothToolStripMenuItem});
            this.contextMenuPalletizing.Name = "contextMenuPalletizing";
            this.contextMenuPalletizing.Size = new System.Drawing.Size(179, 70);
            // 
            // printMassToolStripMenuItem
            // 
            this.printMassToolStripMenuItem.Name = "printMassToolStripMenuItem";
            this.printMassToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.printMassToolStripMenuItem.Text = "Print Mass";
            this.printMassToolStripMenuItem.Click += new System.EventHandler(this.printMassToolStripMenuItem_Click);
            // 
            // printPalletNumberToolStripMenuItem
            // 
            this.printPalletNumberToolStripMenuItem.Name = "printPalletNumberToolStripMenuItem";
            this.printPalletNumberToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.printPalletNumberToolStripMenuItem.Text = "Print Pallet Number";
            this.printPalletNumberToolStripMenuItem.Click += new System.EventHandler(this.printPalletNumberToolStripMenuItem_Click);
            // 
            // printBothToolStripMenuItem
            // 
            this.printBothToolStripMenuItem.Name = "printBothToolStripMenuItem";
            this.printBothToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.printBothToolStripMenuItem.Text = "Print Both";
            this.printBothToolStripMenuItem.Click += new System.EventHandler(this.printBothToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.pnlLandingPage);
            this.Controls.Add(this.pnlNavigation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnlNavigation.ResumeLayout(false);
            this.bottomSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSync)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            this.pnlLandingPage.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.pnlPrintSettings.ResumeLayout(false);
            this.pnlPrintSettings.PerformLayout();
            this.tcSettingsBarcodes.ResumeLayout(false);
            this.tpBarcode.ResumeLayout(false);
            this.tpBarcode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQRSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBarcodeHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBarcodeWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.pnlBarcodeCheckBoxes.ResumeLayout(false);
            this.pnlBarcodeCheckBoxes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).EndInit();
            this.tpWeight.ResumeLayout(false);
            this.tpWeight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeightTextSize)).EndInit();
            this.pnlNextPallet.ResumeLayout(false);
            this.pnlNextPallet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNextPallet)).EndInit();
            this.pnlPrintCount.ResumeLayout(false);
            this.pnlPrintCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrintLabelCount)).EndInit();
            this.pnlPCName.ResumeLayout(false);
            this.pnlPCName.PerformLayout();
            this.pnlWeightUnits.ResumeLayout(false);
            this.pnlWeightUnits.PerformLayout();
            this.pnlBarcodePrefix.ResumeLayout(false);
            this.pnlBarcodePrefix.PerformLayout();
            this.pnlAvailablePresets.ResumeLayout(false);
            this.pnlAvailablePresets.PerformLayout();
            this.pnlSerialConnection.ResumeLayout(false);
            this.pnlSerialConnection.PerformLayout();
            this.pnlSettingsFooter.ResumeLayout(false);
            this.pnlSettingsHeader.ResumeLayout(false);
            this.pnlPalletizing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddgvPalletizing)).EndInit();
            this.pnlPalletizingFooter.ResumeLayout(false);
            this.pnlPalletizingFooter.PerformLayout();
            this.pnlPalletizingHeader.ResumeLayout(false);
            this.pnlAddPallet.ResumeLayout(false);
            this.pnlAddPalletHeader.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddPalletPallets)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddPalletPackQTY)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.pnlScale1.ResumeLayout(false);
            this.pnlScale1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlCreateRun.ResumeLayout(false);
            this.pnlCenterCreateRun.ResumeLayout(false);
            this.pnlCenterCreateRun.PerformLayout();
            this.pnlCreateRunHeading.ResumeLayout(false);
            this.contextMenuPalletizing.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Panel bottomSidePanel;
        private System.Windows.Forms.PictureBox pbSettings;
        private System.Windows.Forms.Button btnPalletizing;
        private System.Windows.Forms.Button btnProductionRun;
        private System.Windows.Forms.PictureBox pbSync;
        private System.Windows.Forms.Panel pnlLandingPage;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Panel pnlSettingsFooter;
        private System.Windows.Forms.Button btnSettingsSave;
        private System.Windows.Forms.Button btnSettingsClose;
        private System.Windows.Forms.Panel pnlSettingsHeader;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlPrintSettings;
        private System.Windows.Forms.Label lblBarcodeHeading;
        private System.Windows.Forms.TabControl tcSettingsBarcodes;
        private System.Windows.Forms.TabPage tpBarcode;
        private System.Windows.Forms.Label lblQR;
        private System.Windows.Forms.NumericUpDown numQRSize;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.NumericUpDown numBarcodeHeight;
        private System.Windows.Forms.NumericUpDown numBarcodeWidth;
        private System.Windows.Forms.Button btnTestPrint;
        private System.Windows.Forms.Label lblBar;
        private System.Windows.Forms.PictureBox pbQR;
        private System.Windows.Forms.Panel pnlBarcodeCheckBoxes;
        private System.Windows.Forms.CheckBox cbBarcode;
        private System.Windows.Forms.CheckBox cbQR;
        private System.Windows.Forms.PictureBox pbBarcode;
        private System.Windows.Forms.TabPage tpWeight;
        private System.Windows.Forms.Label lblWeightSize;
        private System.Windows.Forms.NumericUpDown numWeightTextSize;
        private System.Windows.Forms.Label lblSettingsWeight;
        private System.Windows.Forms.Button btnTestKgPrint;
        private System.Windows.Forms.Panel pnlNextPallet;
        private System.Windows.Forms.NumericUpDown numNextPallet;
        private System.Windows.Forms.Label lblNextPalletNum;
        private System.Windows.Forms.Panel pnlPrintCount;
        private System.Windows.Forms.NumericUpDown numPrintLabelCount;
        private System.Windows.Forms.Label lblPrintCount;
        private System.Windows.Forms.Panel pnlPCName;
        private System.Windows.Forms.TextBox txtPCName;
        private System.Windows.Forms.Label lblPCName;
        private System.Windows.Forms.Panel pnlWeightUnits;
        private System.Windows.Forms.ComboBox ddWeightUnits;
        private System.Windows.Forms.Label lblWeightUnits;
        private System.Windows.Forms.Panel pnlBarcodePrefix;
        private System.Windows.Forms.TextBox txtBarcodePrefix;
        private System.Windows.Forms.Label lblBarcodePrefix;
        private System.Windows.Forms.Panel pnlAvailablePresets;
        private System.Windows.Forms.Label lblScalePreset;
        private System.Windows.Forms.ComboBox ddPreset;
        private System.Windows.Forms.Panel pnlSerialConnection;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.ComboBox ddBaudRate;
        private System.Windows.Forms.ComboBox ddComPorts;
        private System.Windows.Forms.Button btnSettingsHeading;
        private System.Windows.Forms.Panel pnlCreateRun;
        private System.Windows.Forms.Panel pnlCenterCreateRun;
        private System.Windows.Forms.ComboBox ddCreateRunCultivar;
        private System.Windows.Forms.Button btnCreateRunSave;
        private System.Windows.Forms.ComboBox ddCreateRunComm;
        private System.Windows.Forms.Label lblCreateRunCultivar;
        private System.Windows.Forms.ComboBox ddCreateRunBlock;
        private System.Windows.Forms.ComboBox ddCreateRunOrch;
        private System.Windows.Forms.ComboBox ddCreateRunProdUnit;
        private System.Windows.Forms.Label lblCreateRunComm;
        private System.Windows.Forms.Label lblCreateRunBlock;
        private System.Windows.Forms.Label lblCreateRunOrchard;
        private System.Windows.Forms.Label lblCreateRunProdUnit;
        private System.Windows.Forms.Panel pnlCreateRunHeading;
        private System.Windows.Forms.Button btnCreateRunHeading;
        private System.Windows.Forms.Button btnCreateRunClose;
        private System.Windows.Forms.Panel pnlPalletizing;
        private System.Windows.Forms.Panel pnlPalletizingFooter;
        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.ProgressBar progressBarUp;
        private System.Windows.Forms.Button btnUploadRecords;
        private System.Windows.Forms.Button btnPallAddPallet;
        private System.Windows.Forms.Panel pnlPalletizingHeader;
        private System.Windows.Forms.Button btnPalletizingHeader;
        private System.Windows.Forms.DataGridView ddgvPalletizing;
        private System.Windows.Forms.Panel pnlAddPallet;
        private System.Windows.Forms.Panel pnlAddPalletHeader;
        private System.Windows.Forms.Button btnAddPalletHeader;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numAddPalletPallets;
        private System.Windows.Forms.Button btnAddPalletAdd;
        private System.Windows.Forms.Button btnAddPalletCancel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox ddAddPalletBrand;
        private System.Windows.Forms.ComboBox ddAddPalletGrade;
        private System.Windows.Forms.ComboBox ddAddPalletCount;
        private System.Windows.Forms.ComboBox ddAddPalletPackType;
        private System.Windows.Forms.NumericUpDown numAddPalletPackQTY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlScale1;
        private System.Windows.Forms.TextBox txtAddPalletScaleWeight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAddPalletCultivar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAddPalletProdUnit;
        private System.Windows.Forms.Label lblAddPalletComm;
        private System.Windows.Forms.Label lblAddPalletOrch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAddPalletBlock;
        private System.Windows.Forms.ContextMenuStrip contextMenuPalletizing;
        private System.Windows.Forms.ToolStripMenuItem printMassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPalletNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printBothToolStripMenuItem;
    }
}

