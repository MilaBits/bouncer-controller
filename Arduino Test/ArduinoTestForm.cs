using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Arduino_Test {
    public partial class ArduinoTestForm : Form {
        private SerialPort port;
        private bool isConnected = false;
        private string lastMessage = "";

        public ArduinoTestForm() {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e) {
            port = new SerialPort(cbbComPorts.Text, Convert.ToInt16(cbbBaud.Text));
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

            port.Open();
            isConnected = true;
            updateUI();
            tmInbox.Start();
        }

        private void port_DataReceived(object sender, EventArgs e) {
            //rtbLog.Invoke(new Action(() => rtbLog.Text += String.Format("[{0}] {1}", DateTime.Now.ToString("T"), port.ReadLine())));
            lastMessage = port.ReadLine();
        }

        private void updateUI() {
            if (isConnected) {
                pbConnected.Value = 100;
                btnDisconnect.Enabled = isConnected;
                btnConnect.Enabled = !isConnected;
                cbbBaud.Enabled = !isConnected;
                cbbComPorts.Enabled = !isConnected;
                lbCom.Visible = isConnected;
            } else {
                pbConnected.Value = 0;
                btnDisconnect.Enabled = isConnected;
                btnConnect.Enabled = !isConnected;
                cbbBaud.Enabled = !isConnected;
                cbbComPorts.Enabled = !isConnected;
                lbCom.Visible = isConnected;
            }
        }

        private void ArduinoTestForm_Load(object sender, EventArgs e) {
            foreach (string port in SerialPort.GetPortNames()) {
                cbbComPorts.Items.Add(port);
            }
            updateUI();
        }

        private void btnDisconnect_Click(object sender, EventArgs e) {
            port.Close();
            isConnected = false;
            updateUI();
            tmInbox.Stop();
        }

        private void btnSend_Click(object sender, EventArgs e) {
            if (port.IsOpen) {
                port.Write(tbMessage.Text + '\n');
            }
        }

        private void tmInbox_Tick(object sender, EventArgs e) {
            rtbLog.Text += string.Format("[{0:T}] {1}", DateTime.Now, lastMessage);
        }

        private void rtbLog_TextChanged(object sender, EventArgs e) {

            rtbLog.SelectionStart = rtbLog.Text.Length - 1;
            rtbLog.ScrollToCaret();
        }
    }
}
