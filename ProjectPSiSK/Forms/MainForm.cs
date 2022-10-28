using Microsoft.VisualBasic;
using ProjectPSiSK.Models;
using ProjectPSiSK.Services;
using System.IO.Ports;

namespace ProjectPSiSK
{
    public partial class MainForm : Form
    {
        private SerialPortService _serialPortClass;
        private FileService _fileClass;
        private IoTHubService _ioTHubService;
        public MainForm()
        {
            _serialPortClass = new SerialPortService(500, 500);
            _fileClass = new FileService();
            _ioTHubService = new IoTHubService();
            InitializeComponent();


            cbBoxPort.Items.AddRange(_serialPortClass.GetPortNames());
            _serialPortClass._serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            //Disabled on start
            btnClose.Enabled = false;
            ckBoxWriteLine.Enabled = false;
            ckBoxEnterSending.Enabled = false;
            btnSend.Enabled = false;
            txBoxOut.Enabled = false;
            ckBoxLogTXT.Enabled = false;
            ckBoxView.Enabled = false;
            btnDelete.Enabled = false;
            txBoxIn.Enabled = false;
            txBoxIn.ReadOnly = true;
            btnStartIoT.Enabled = false;
            btnStopIoT.Enabled = false;
            txDivId.Enabled = false;
            txDivKey.Enabled = false;
            txHostIoT.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (_serialPortClass.OpenPort(
                    cbBoxPort.Text,
                    cbBoxRate.Text,
                    cbBoxDataB.Text,
                    cbBoxStopB.Text,
                    cbBoxParityB.Text
                ))
            {
                pgBarStatus.Value = 100;
                btnClose.Enabled = true;
                btnOpen.Enabled = false;
                labelStatus.Text = "ON";
                labelStatus.ForeColor = Color.Green;
                cbBoxPort.Enabled = false;
                cbBoxRate.Enabled = false;
                cbBoxDataB.Enabled = false;
                cbBoxParityB.Enabled = false;
                cbBoxStopB.Enabled = false;
                ckBoxWriteLine.Enabled = true;
                ckBoxEnterSending.Enabled = true;
                btnSend.Enabled = true;
                txBoxOut.Enabled = true;
                ckBoxLogTXT.Enabled = true;
                ckBoxView.Enabled = true;
                btnDelete.Enabled = true;
                txBoxIn.Enabled = true;
                btnStartIoT.Enabled = true;
                btnStopIoT.Enabled = false;
                txDivId.Enabled = true;
                txDivKey.Enabled = true;
                txHostIoT.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_serialPortClass.ClosePort())
            {
                pgBarStatus.Value = 0;
                btnClose.Enabled = false;
                btnOpen.Enabled = true;
                labelStatus.Text = "OFF";
                labelStatus.ForeColor = Color.Red;
                cbBoxPort.Enabled = true;
                cbBoxRate.Enabled = true;
                cbBoxDataB.Enabled = true;
                cbBoxParityB.Enabled = true;
                cbBoxStopB.Enabled = true;
                ckBoxWriteLine.Enabled = false;
                ckBoxEnterSending.Enabled = false;
                btnSend.Enabled = false;
                txBoxOut.Enabled = false;
                ckBoxLogTXT.Enabled = false;
                ckBoxView.Enabled = false;
                btnDelete.Enabled = false;
                txBoxIn.Enabled = false;
                btnStopIoT_Click(sender, e);
                btnStartIoT.Enabled = false;
                txDivId.Enabled = false;
                txDivKey.Enabled = false;
                txHostIoT.Enabled = false;
            }
        }

        private void ckBoxEnterSending_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxEnterSending.Checked)
            {
                _serialPortClass.SendByEnter = true;
            }
            else
            {
                _serialPortClass.SendByEnter = false;
            }
        }

        private void ckBoxWriteLine_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxWriteLine.Checked)
            {
                _serialPortClass.WriteLine = true;
            }
            else
            {
                _serialPortClass.WriteLine = false;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (_serialPortClass.SendData(txBoxOut.Text)) txBoxOut.Text = "";
        }

        private void txBoxOut_TextChanged(object sender, EventArgs e)
        {
            if (ckBoxEnterSending.Checked)
            {
                txBoxOut.Text = txBoxOut.Text.Replace(Environment.NewLine, "");
            }
        }

        private void txBoxOut_KeyDown(object sender, KeyEventArgs e)
        {
            if (ckBoxEnterSending.Checked && e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);
            }
        }

        private void ckBoxView_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxView.Checked)
            {
                _serialPortClass.ViewData = true;
            }
            else
            {
                _serialPortClass.ViewData = false;
            }
        }

        private void ckBoxLogTXT_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxLogTXT.Checked)
            {
                _serialPortClass.LogToTxt = true;
            }
            else
            {
                _serialPortClass.LogToTxt = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txBoxIn.Text = "";
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            if (InvokeRequired)
                Invoke(DataReceivedHandler, sender, e);
            else
            {
                string data = _serialPortClass.ReadData();
                if (_serialPortClass.ViewData)
                {
                    txBoxIn.Text += data + System.Environment.NewLine;
                }

                if (_serialPortClass.LogToTxt)
                {
                    _fileClass.WriteFIle(data);
                }

                if (_ioTHubService.IsEnable)
                {
                    _ioTHubService.Send(new MessageModel(data));
                }
            }
        }

        private void btnStartIoT_Click(object sender, EventArgs e)
        {
            if (_ioTHubService.StartSendIoT(
                    txDivId.Text,
                    txDivKey.Text,
                    txHostIoT.Text
                ))
            {
                btnStartIoT.Enabled = false;
                btnStopIoT.Enabled = true;
                txDivId.Enabled = false;
                txDivKey.Enabled = false;
                txHostIoT.Enabled = false;
                labelStatusIoT.Text = "ON";
                labelStatusIoT.ForeColor = Color.Green;
                pgBarIot.Value = 100;
            }
        }

        private void btnStopIoT_Click(object sender, EventArgs e)
        {
            _ioTHubService.StopSendIoT();
            btnStartIoT.Enabled = true;
            btnStopIoT.Enabled = false;
            txDivId.Enabled = true;
            txDivKey.Enabled = true;
            txHostIoT.Enabled = true;
            labelStatusIoT.Text = "OFF";
            labelStatusIoT.ForeColor = Color.Red;
            pgBarIot.Value = 0;
        }
    }
}