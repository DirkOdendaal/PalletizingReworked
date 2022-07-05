using Palletizing.Manager;
using PalletizingReworked.Classes;
using PalletizingReworked.Manager;
using PalletizingReworked.Models;

using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace PalletizingReworked
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        //Tools
        private ToolTip tooltipPackType = new ToolTip();
        private SerialPort _serialPort;
        private ManagementEventWatcher watcherAttach;
        private ManagementEventWatcher watcherRemove;
        private BindingSource _bindingSource = new BindingSource();

        //Database helpers
        private UserManager _userManager = new UserManager();
        private ScaleSettingsManager _scaleManager = new ScaleSettingsManager();
        private BlocksManager _blockManager = new BlocksManager();
        private BrandManager _brandManager = new BrandManager();
        private PackManager _packManager = new PackManager();
        private CreateRunManager _createRunManager = new CreateRunManager();
        private GradeManager _gradeManager = new GradeManager();
        private Count_SizeManager _countManager = new Count_SizeManager();
        private PalletsManager _palletManager = new PalletsManager();

        //Models
        private PalletRecord _selectedRecord = new PalletRecord();
        private ScaleSettings _settings = new ScaleSettings();

        //Controllers
        private APIController _api = new APIController();
        private LabelPrintController _print = new LabelPrintController();

        //Home Section
        private void pbSettings_Click(object sender, EventArgs e)
        {
            pnlsettings_Load();
        }

        private void btnProductionRun_Click(object sender, EventArgs e)
        {
            pnlCreateRun_Load();
        }

        private async void Home_Load(object sender, EventArgs e)
        {
            try
            {
                //Ui Elements and bindings
                ddAddPalletPackType.DrawMode = DrawMode.OwnerDrawFixed;
                ddAddPalletPackType.DrawItem += ddPackType_DrawItem;
                ddAddPalletPackType.DropDownClosed += ddAddPalletPackType_DropDownClosed;
                this.pnlSettings.Parent = pnlLandingPage;
                this.pnlCreateRun.Parent = pnlLandingPage;
                this.pnlPalletizing.Parent = pnlLandingPage;
                this.pnlAddPallet.Parent = pnlLandingPage;

                this.pnlAddPallet.Dock = DockStyle.Fill;
                this.pnlSettings.Dock = DockStyle.Fill;
                this.pnlCreateRun.Dock = DockStyle.Fill;
                this.pnlPalletizing.Dock = DockStyle.Fill;

                //Ansure auth and database creation
                int authed = 0;
                using (var context = new ApplicationDbContext())
                {
                    await context.Database.EnsureCreatedAsync();
                }


                User user = _userManager.GetUser();
                _settings = _scaleManager.GetSettings();

                if (user != null)
                {
                    authed = user.auth;
                    //Palletizing DataGridView Binding
                    _bindingSource.DataSource = _palletManager.GetAll();
                    ddgvPalletizing.DataSource = _bindingSource;

                    ddgvPalletizing.Columns["key"].Visible = false;

                    //Master Data Collection
                    _blockManager.DeleteAllBlocks();
                    await _api.annualCensus();
                    await _api.pullBrand();
                    await _api.pullPack();
                    await _api.pullGrade();
                    await _api.pullCount();
                }
                else if (authed == 0 || user == null)
                {
                    Login login = new Login();
                    login.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Settings Section
        private void pnlsettings_Load()
        {
            initWatchers();
            getComPorts();
            populateSettings();
            popQR();
            popBarcodes();
            pnlAddPallet.Visible = false;
            pnlCreateRun.Visible = false;
            pnlPalletizing.Visible = false;
            pnlSettings.Visible = true;
        }

        private void initWatchers()
        {
            // Add USB plugged event watching
            watcherAttach = new ManagementEventWatcher();
            watcherAttach.EventArrived += new EventArrivedEventHandler(watcher_EventArrived);
            watcherAttach.Query = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2");
            watcherAttach.Start();

            // Add USB unplugged event watching
            watcherRemove = new ManagementEventWatcher();
            watcherRemove.EventArrived += new EventArrivedEventHandler(watcher_EventRemoved);
            watcherRemove.Query = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 3");
            watcherRemove.Start();
        }

        void watcher_EventArrived(object sender, EventArrivedEventArgs e)
        {
            try
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(getComPorts));
                    return;
                }
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(@"errorlog.txt"))
                {
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine(ex.ToString());
                    sw.WriteLine("-----");
                }
                MessageBox.Show(ex.Message);
            }
        }

        void watcher_EventRemoved(object sender, EventArrivedEventArgs e)
        {
            try
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(getComPorts));
                    return;
                }
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(@"errorlog.txt"))
                {
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine(ex.ToString());
                    sw.WriteLine("-----");
                }
                MessageBox.Show(ex.Message);
            }
        }
        public void DisposeWatchers()
        {
            try
            {
                watcherAttach.Stop();
                watcherRemove.Stop();
                watcherAttach.Dispose();
                watcherRemove.Dispose();
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(@"errorlog.txt"))
                {
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine(ex.ToString());
                    sw.WriteLine("-----");
                }
                MessageBox.Show(ex.Message);
            }
        }

        void getComPorts()
        {
            ddComPorts.Items.Clear();
            ddComPorts.Items.AddRange(SerialPort.GetPortNames());
        }

        private void btnSettingsClose_Click(object sender, EventArgs e)
        {
            DisposeWatchers();
            pnlSettings.Visible = false;
        }

        private void cbQR_CheckedChanged(object sender, EventArgs e)
        {
            if (cbQR.Checked == true)
            {
                btnTestPrint.Visible = true;

                pbQR.Visible = true;
                lblQR.Visible = true;
                numQRSize.Visible = true;
            }
            else
            {
                btnTestPrint.Visible = false;

                pbQR.Visible = false;
                lblQR.Visible = false;
                numQRSize.Visible = false;
            }
        }

        private void cbBarcode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBarcode.Checked == true)
            {
                pbBarcode.Visible = true;
                numBarcodeHeight.Visible = true;
                lblHeight.Visible = true;
                numBarcodeWidth.Visible = true;
                lblWidth.Visible = true;
                btnTestPrint.Visible = true;
            }
            else
            {
                pbBarcode.Visible = false;
                numBarcodeHeight.Visible = false;
                lblHeight.Visible = false;
                numBarcodeWidth.Visible = false;
                lblWidth.Visible = false;
                btnTestPrint.Visible = false;
            }
        }

        public void populateSettings()
        {
            try
            {
                _settings = _scaleManager.GetSettings();
                if (_settings == null)
                    return;
                lblBar.Text = $"{_settings.prefix}123456789123";
                lblSettingsWeight.Text = $"1000{_settings.units}";
                txtPCName.Text = _settings.pcName;
                txtBarcodePrefix.Text = _settings.prefix;
                ddBaudRate.Text = _settings.baudRate;
                ddComPorts.Text = _settings.commPort;
                ddPreset.Text = _settings.scalePreset;
                ddWeightUnits.Text = _settings.units;
                numPrintLabelCount.Value = _settings.printCount;
                numNextPallet.Value = _settings.palId;
                switch (_settings.printLab)
                {
                    case "QR":
                        cbQR.Checked = true;
                        break;
                    case "BAR":
                        cbBarcode.Checked = true;
                        break;
                    case "BARQR":
                        cbBarcode.Checked = true;
                        cbQR.Checked = true;
                        break;
                    default:
                        cbQR.Checked = false;
                        cbBarcode.Checked = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void popQR()
        {
            //QR Code
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(lblBar.Text, QRCodeGenerator.ECCLevel.H);
            QRCode qrCode = new QRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(20);

            var qr = new Bitmap(qrCodeImage.Width, qrCodeImage.Height);

            using (var graphics = Graphics.FromImage(qr))
            using (var font = new Font("Lato", 40))
            using (var brush = new SolidBrush(Color.Black))
            using (var format = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Far
            })
            {
                graphics.Clear(Color.White);
                graphics.DrawImage(qrCodeImage, 0, 0);
                graphics.DrawString(lblBar.Text, font, brush, qr.Width / 2, qr.Height, format);
            }

            pbQR.Image = qr;
            pbQR.SizeMode = PictureBoxSizeMode.Zoom;
            pbQR.Image.Save(@"QR.jpg");
        }

        private void popBarcodes()
        {
            try
            {
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                var barcodeImage = barcode.Draw(lblBar.Text, 20);

                var barImage = new Bitmap(barcodeImage.Width, barcodeImage.Height + 20); // 20 is bottom padding, adjust to your text

                using (var graphics = Graphics.FromImage(barImage))
                using (var font = new Font("Lato", 10))
                using (var brush = new SolidBrush(Color.Black))
                using (var format = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Far
                })
                {
                    graphics.Clear(Color.White);
                    graphics.DrawImage(barcodeImage, 0, 0);
                    graphics.DrawString(lblBar.Text, font, brush, barImage.Width / 2, barImage.Height, format);
                }

                pbBarcode.Image = barImage;
                pbBarcode.SizeMode = PictureBoxSizeMode.Zoom;
                pbBarcode.Image.Save(@"barcode.jpg");
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(@"errorlog.txt"))
                {
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine(ex.ToString());
                    sw.WriteLine("-----");
                }
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are You Sure You Want To Logout?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (_userManager.DeleteCurrentUser())
                    Application.Restart();
            }
        }

        private void btnSettingsSave_Click(object sender, EventArgs e)
        {
            try
            {
                DisposeWatchers();
                _scaleManager.DeleteCurrentSettings();
                string commport, baudrate, scalePreset, prefix, units, pcName, printLab = null;
                int printCount, palid, barHeight, barwidth, qrSize, textSize = 0;
                commport = ddComPorts.Text;
                baudrate = ddBaudRate.Text;
                scalePreset = ddPreset.Text;
                prefix = txtBarcodePrefix.Text;
                units = ddWeightUnits.Text;
                pcName = txtPCName.Text;
                printCount = (int)numPrintLabelCount.Value;
                palid = (int)numNextPallet.Value;
                if (cbQR.Checked == true && cbBarcode.Checked == false)
                    printLab = "QR";
                if (cbBarcode.Checked == true && cbQR.Checked == false)
                    printLab = "BAR";
                if (cbBarcode.Checked == true && cbQR.Checked == true)
                    printLab = "BARQR";
                barHeight = (int)numBarcodeHeight.Value;
                barwidth = (int)numBarcodeWidth.Value;
                qrSize = (int)numQRSize.Value;
                textSize = (int)numWeightTextSize.Value;

                ScaleSettings settings = new ScaleSettings();
                settings.scalePreset = scalePreset;
                settings.prefix = prefix;
                settings.units = units;
                settings.pcName = pcName;
                settings.commPort = commport;
                settings.baudRate = baudrate;
                settings.printCount = printCount;
                settings.palId = palid;
                settings.printLab = printLab;
                settings.barHeight = barHeight;
                settings.barWidth = barwidth;
                settings.qrSize = qrSize;
                settings.textSize = textSize;

                if (_scaleManager.Add(settings))
                {
                    MessageBox.Show("Settings Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlSettings.Visible = false;
                    pnlLandingPage.Visible = true;
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnTestPrint_Click(object sender, EventArgs e)
        {
            _settings = new ScaleSettings();
            _print.printLabel(_settings.printLab);
            MessageBox.Show("Check Printout", "Printing Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTestKgPrint_Click(object sender, EventArgs e)
        {
            LabelPrintController print = new LabelPrintController();
            print.printMass(lblSettingsWeight.Text, Convert.ToSingle(numWeightTextSize.Value));
            MessageBox.Show("Check Printout", "Printing Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Create Run Section
        private void pnlCreateRun_Load()
        {
            resetRunUi();
            pnlAddPallet.Visible = false;
            pnlSettings.Visible = false;
            pnlPalletizing.Visible = false;
            pnlCreateRun.Visible = true;
            List<string> prodUnit;
            prodUnit = _blockManager.GetProdUnitListUnique();
            ddCreateRunProdUnit.Items.AddRange(prodUnit.ToArray());
        }

        private void resetRunUi()
        {
            ddCreateRunProdUnit.Items.Clear();
            ddCreateRunOrch.Items.Clear();
            ddCreateRunBlock.Items.Clear();
            ddCreateRunComm.Items.Clear();
            ddCreateRunCultivar.Items.Clear();

            ddCreateRunProdUnit.SelectedIndex = -1;
            ddCreateRunOrch.SelectedIndex = -1;
            ddCreateRunBlock.SelectedIndex = -1;
            ddCreateRunComm.SelectedIndex = -1;
            ddCreateRunCultivar.SelectedIndex = -1;

            ddCreateRunProdUnit.Text = string.Empty;
            ddCreateRunOrch.Text = string.Empty;
            ddCreateRunBlock.Text = string.Empty;
            ddCreateRunComm.Text = string.Empty;
            ddCreateRunCultivar.Text = string.Empty;

            ddCreateRunProdUnit.Enabled = true;
            ddCreateRunOrch.Enabled = false;
            ddCreateRunBlock.Enabled = false;
            ddCreateRunComm.Enabled = false;
            ddCreateRunCultivar.Enabled = false;
        }

        private void btnCreateRunClose_Click(object sender, EventArgs e)
        {
            pnlCreateRun.Visible = false;
        }

        private void btnCreateRunSave_Click(object sender, EventArgs e)
        {
            Guid obj = Guid.NewGuid();
            Blocks blocks;
            CreateRun run = new CreateRun();
            blocks = _blockManager.GetRunRecord(ddCreateRunProdUnit.SelectedItem.ToString(), ddCreateRunOrch.SelectedItem.ToString(), ddCreateRunBlock.SelectedItem.ToString());
            run.Id = obj.ToString();
            run.prodUnitName = blocks.prodUnitName;
            run.prodUnitId = blocks.prodUnitID;
            run.blockName = blocks.blockNo;
            run.blockId = blocks.blockID;
            run.orchardname = blocks.orchNum;
            run.orchardId = blocks.orchID;
            run.commodity = ddCreateRunComm.SelectedItem.ToString();
            run.cultivar = ddCreateRunCultivar.SelectedItem.ToString();

            _createRunManager.DelteCurrentRun();
            _createRunManager.Add(run);
            pnlCreateRun.Visible = false;
        }

        private void ddCreateRunProdUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddCreateRunProdUnit.Enabled = false;
            ddCreateRunOrch.Enabled = true;
            List<string> orch;
            orch = _blockManager.GetOrchListUniqueFilter(ddCreateRunProdUnit.SelectedItem.ToString());
            ddCreateRunOrch.Items.AddRange(orch.ToArray());
        }

        private void ddCreateRunOrch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddCreateRunOrch.Enabled = false;
            ddCreateRunBlock.Enabled = true;
            List<string> blocks;
            blocks = _blockManager.GetBlocksListUniqueFilter(ddCreateRunOrch.SelectedItem.ToString());
            ddCreateRunBlock.Items.AddRange(blocks.ToArray());
        }

        private void ddCreateRunBlock_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddCreateRunBlock.Enabled = false;
            ddCreateRunComm.Enabled = true;
            List<string> comm;
            comm = _blockManager.GetCommListUniqueFilter(ddCreateRunProdUnit.SelectedItem.ToString(), ddCreateRunBlock.SelectedItem.ToString());
            ddCreateRunComm.Items.AddRange(comm.ToArray());
        }

        private void ddCreateRunComm_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddCreateRunComm.Enabled = false;
            ddCreateRunCultivar.Enabled = true;
            List<string> cult;
            cult = _blockManager.GetCultListUniqueFilter(ddCreateRunComm.SelectedItem.ToString());
            ddCreateRunCultivar.Items.AddRange(cult.ToArray());
        }

        //Palletizing section
        private void btnPalletizing_Click(object sender, EventArgs e)
        {
            pnlPalletizing_Load();
        }

        private void resetAddPallUi()
        {
            ddAddPalletBrand.Items.Clear();
            ddAddPalletPackType.Items.Clear();
            ddAddPalletGrade.Items.Clear();
            ddAddPalletCount.Items.Clear();

            ddAddPalletBrand.SelectedIndex = -1;
            ddAddPalletPackType.SelectedIndex = -1;
            ddAddPalletGrade.SelectedIndex = -1;
            ddAddPalletCount.SelectedIndex = -1;

            ddAddPalletBrand.Text = string.Empty;
            ddAddPalletPackType.Text = string.Empty;
            ddAddPalletGrade.Text = string.Empty;
            ddAddPalletCount.Text = string.Empty;
        }

        private void pnlPalletizing_Load()
        {
            //_bindingSource.ResetBindings(false);
            pnlAddPallet.Visible = false;
            pnlSettings.Visible = false;
            pnlCreateRun.Visible = false;
            pnlPalletizing.Visible = true;
        }

        private bool pnlAddPallet_load()
        {
            List<string> brand;
            List<string> pack;
            List<string> grade;
            List<string> count;
            ScaleSettings settings; ;
            CreateRun run;
            settings = _scaleManager.GetSettings();
            run = _createRunManager.GetRun();
            if (settings == null || run == null)
            {
                MessageBox.Show("Please Ensure you have created a run and all settings are filled in", "Required steps not taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            //Master Data Collection From Tables EF
            brand = _brandManager.GetAll();
            pack = _packManager.GetAll();
            grade = _gradeManager.GetAll();
            count = _countManager.GetCountCommFiltered(run.commodity);

            lblAddPalletProdUnit.Text = run.prodUnitName;
            lblAddPalletOrch.Text = run.orchardname;
            lblAddPalletBlock.Text = run.blockName;
            lblAddPalletComm.Text = run.commodity;
            lblAddPalletCultivar.Text = run.cultivar;

            ddAddPalletBrand.Items.AddRange(brand.ToArray());
            ddAddPalletPackType.Items.AddRange(pack.ToArray());
            ddAddPalletGrade.Items.AddRange(grade.ToArray());
            ddAddPalletCount.Items.AddRange(count.ToArray());

            //Serial Conncetion Init
            _serialPort = new SerialPort(_settings.commPort);
            _serialPort.BaudRate = Convert.ToInt32(_settings.baudRate);
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            try
            {
                _serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check the following to resolve the issue;" +
                    "\r\n\r\n1. Ensure the cable is connected and working properly." +
                    "\r\n2. Ensure the correct settings are set; eg. Baud Rate, COM port." +
                    "\r\n3. Reinstall scale COM port drivers." +
                    "\r\n\r\n Or contact system administrator. ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnPallAddPallet_Click(object sender, EventArgs e)
        {
            resetAddPallUi();
            bool run = pnlAddPallet_load();
            if (!run)
                return;
            pnlCreateRun.Visible = false;
            pnlPalletizing.Visible = false;
            pnlSettings.Visible = false;
            pnlAddPallet.Visible = true;
        }

        private void btnAddPalletCancel_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.DataReceived -= new SerialDataReceivedEventHandler(DataReceivedHandler);
                _serialPort.Close();
                pnlCreateRun.Visible = false;
                pnlPalletizing.Visible = true;
                pnlSettings.Visible = false;
                pnlAddPallet.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ddAddPalletBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddAddPalletPackType.Items.Clear();
            List<string> pack;
            pack = _packManager.GetPackTypeFilterd(ddAddPalletBrand.SelectedItem.ToString());
            ddAddPalletPackType.Items.AddRange(pack.ToArray());
            ddAddPalletPackType.Items.Add("Other...");
        }

        private void ddPackType_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                if (e.Index < 0) { return; }
                string text = this.ddAddPalletPackType.GetItemText(ddAddPalletPackType.Items[e.Index]);
                e.DrawBackground();
                using (SolidBrush br = new SolidBrush(e.ForeColor))
                { e.Graphics.DrawString(text, e.Font, br, e.Bounds); }

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                { this.tooltipPackType.Show(text, ddAddPalletPackType, e.Bounds.Right, e.Bounds.Bottom); }
                else { this.tooltipPackType.Hide(ddAddPalletPackType); }
                e.DrawFocusRectangle();
            }
            catch (IndexOutOfRangeException ex)
            {
                using (StreamWriter sw = File.AppendText(@"errorlog.txt"))
                {
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine(ex.ToString());
                    sw.WriteLine("-----");
                }
                MessageBox.Show(ex.ToString());
            }
        }

        private void ddAddPalletPackType_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> pack = new List<string>();

            if (ddAddPalletPackType.SelectedItem.ToString() == "Other...")
            {
                ddAddPalletPackType.Items.Clear();
                pack = _packManager.GetAll();
                ddAddPalletPackType.Items.AddRange(pack.ToArray());
            }
            if (ddAddPalletPackType.SelectedIndex != -1)
            {
                int qty = Convert.ToInt32(_packManager.GetPackCountFilterd(ddAddPalletPackType.SelectedItem.ToString()));
                numAddPalletPackQTY.Value = qty;
            }
        }

        private void ddAddPalletPackType_DropDownClosed(object sender, EventArgs e)
        {
            tooltipPackType.Hide(ddAddPalletPackType);
        }

        private void btnAddPalletAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.Close();
                _serialPort.DataReceived -= new SerialDataReceivedEventHandler(DataReceivedHandler);
                Guid guid = Guid.NewGuid();
                string timestamp = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                string Date = DateTime.Now.Date.ToString();
                CreateRun run;
                _settings = _scaleManager.GetSettings();
                run = _createRunManager.GetRun();

                string recordId = guid.ToString().Replace("-", string.Empty);
                _selectedRecord.Id = recordId;
                _selectedRecord.Pallet_Number = $"{_settings.prefix}{_settings.palId}";
                _selectedRecord.prodUnitId = run.prodUnitId;
                _selectedRecord.Production_Unit = run.prodUnitName;
                _selectedRecord.orchId = run.orchardId;
                _selectedRecord.Orchard = run.orchardname;
                _selectedRecord.blockId = run.blockId;
                _selectedRecord.Block = run.blockName;
                _selectedRecord.Commodity = run.commodity;
                _selectedRecord.Cultivar = run.cultivar;
                _selectedRecord.Grade = ddAddPalletGrade.SelectedItem.ToString();
                _selectedRecord.Brand = ddAddPalletBrand.SelectedItem.ToString();
                _selectedRecord.Count_Size = ddAddPalletCount.SelectedItem.ToString();
                _selectedRecord.Pack_Type = ddAddPalletPackType.SelectedItem.ToString();
                _selectedRecord.Pack_QTY = numAddPalletPackQTY.Value.ToString();
                _selectedRecord.Weight = txtAddPalletScaleWeight.Text;
                _selectedRecord.Timestamp = timestamp;
                _selectedRecord.Date = Date;
                _selectedRecord.PC_Name = _settings.pcName;

                _palletManager.Add(_selectedRecord);
                _scaleManager.UpdateSettings();
                UpdateRecord(_selectedRecord);
                pnlPalletizing_Load();
                _print.printMass(_selectedRecord.Weight, _settings.textSize);
                _print.printLabel(_settings.printLab);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void UpdateRecord(PalletRecord record)
        {
            APIController api = new APIController();
            string newKey = await api.addPallet(record).ConfigureAwait(true);
            _selectedRecord.key = newKey;
        }

        private void ddgvPalletizing_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = ddgvPalletizing.Rows[e.RowIndex];
            var value = row.Cells["key"].Value;
            if (value == null)
            {
                row.DefaultCellStyle.BackColor = Color.Firebrick;
                return;
            }
            if (e.RowIndex % 2 == 0)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            }
        }

        private void ddgvPalletizing_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                switch (e.Button)
                {
                    case MouseButtons.Right:
                        {
                            ddgvPalletizing.CurrentCell = ddgvPalletizing.Rows[e.RowIndex].Cells[e.ColumnIndex];
                            ddgvPalletizing.Rows[e.RowIndex].Selected = true;
                            ddgvPalletizing.Focus();
                            contextMenuPalletizing.Show(MousePosition.X, MousePosition.Y);//places the menu at the pointer position

                            //Get Record from _palletManager
                            string pallNumber = ddgvPalletizing.Rows[e.RowIndex].Cells[1].Value.ToString();
                            _selectedRecord = _palletManager.GetPallet(pallNumber);
                        }
                        break;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(@"errorlog.txt"))
                {
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine(ex.ToString());
                    sw.WriteLine("-----");
                }
                return;
            }
        }

        private void printMassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _settings = _scaleManager.GetSettings();
            _print.printMass($"{_selectedRecord.Weight}{_settings.units}", _settings.textSize);
        }

        private void printPalletNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _settings = _scaleManager.GetSettings();
            _print.printLabel(_settings.printLab);
        }

        private void printBothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _settings = _scaleManager.GetSettings();
            _print.printLabel(_settings.printLab);
            _print.printMass($"{_selectedRecord.Weight}{_settings.units}", _settings.textSize);
        }

        private async void btnUploadRecords_Click(object sender, EventArgs e)
        {
            List<PalletRecord> nonUploadedList = _palletManager.GetNotUploadPallet();
            foreach (PalletRecord pallet in nonUploadedList)
            {
                string newKey = await _api.addPallet(pallet);
                pallet.key = newKey;
            }
        }

        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            char[] chararr = new char[] { };
            _serialPort = (SerialPort)sender;
            try
            {
                if (_serialPort.IsOpen)
                {
                    string indata = string.Empty;
                    switch (_settings.scalePreset)
                    {
                        case "Farmtrace Internal":
                            //Fill Later
                            break;
                        case "Massamatic":
                            //Fill Later
                            break;
                        case "Richter":
                            indata = _serialPort.ReadTo("\x0D");
                            UpdateTextBox(indata);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(@"errorlog.txt"))
                {
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine(ex.ToString());
                    sw.WriteLine("-----");
                }
            }
        }

        private void UpdateTextBox(string value)
        {

            if (value.Length > 0 && value.Contains(" "))
            {
                value = value.Remove(0, value.IndexOf(" "));
            }

            txtAddPalletScaleWeight.Text = GetNumbers(value.ToString());
        }

        private static string GetNumbers(string input)
        {
            return new string(input.Where(c => char.IsDigit(c)).ToArray());
        }
    }
}
