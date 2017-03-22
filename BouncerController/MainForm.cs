using System;
using System.Windows.Forms;
using EV3MessengerLib;
using System.Management;

namespace BouncerController {
    public partial class MainForm : Form {
        private EV3Messenger ev3Messenger;
        private Form controlForm;
        private Form scoreboardForm;

        public MainForm() {
            InitializeComponent();
            ev3Messenger = new EV3Messenger();

            controlForm = new ControlForm();
            scoreboardForm = new ScoreboardForm();
        }

        private void FillComList() {
            cbbComPorts.Items.Clear();
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'")) {
                var instances = new ManagementClass("Win32_SerialPort").GetInstances();
                foreach (ManagementObject port in instances) {
                    cbbComPorts.Items.Add(String.Format("{0}", port["deviceid"]));
                }
            }
            //string[] ports = SerialPort.GetPortNames();
            //foreach (string portName in ports)
            //{
            //    cbbComPorts.Items.Add(portName);
            //}
            
        }

        private void cbbComPorts_Click(object sender, EventArgs e) {
        }

        private void btnConnect_Click(object sender, EventArgs e) {
            toggleTop(false);
            if (btnConnect.Text == "Connect") {
                //String port = cbbComPorts.Text.Substring(0,cbbComPorts.Text.IndexOf(' '));
                String port = cbbComPorts.Text;
                if (ev3Messenger.Connect(port)) {
                    UpdateButtonsAndConnectionInfo();
                    lbLog.Items.Clear();
                    messageTimer.Start();
                } else {
                    MessageBox.Show("Failed to connect to serial port '" + port + "'.\n"
                        + "Is your EV3 connected to that serial port? Or is it using another one?");
                }
            } else {
                //messageReceiveTimer.Stop();
                ev3Messenger.Disconnect();
                UpdateButtonsAndConnectionInfo();
            }
            toggleTop(true);
        }

        private void UpdateButtonsAndConnectionInfo() {
            bool isConnected = ev3Messenger.IsConnected;

            cbbComPorts.Enabled = !isConnected;

            if (isConnected) {
                btnConnect.Text = "Disconnect";
                tslConnection.Text = "Connected: " + ev3Messenger.Port;
                tspConnection.Value = 100;
                messageTimer.Enabled = true;
            } else {
                btnConnect.Text = "Connect";
                tslConnection.Text = "Not Connected";
                tspConnection.Value = 0;
                messageTimer.Enabled = false;
            }
        }

        private void cbbComPorts_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            toggleTop(false);
            FillComList();
            toggleTop(true);
        }

        private void toggleTop(bool toggleOn) {
            btnRefresh.Enabled = cbbComPorts.Enabled = btnConnect.Enabled = toggleOn;
            lbScanning.Visible = !toggleOn;
            if (!toggleOn) {
                this.Cursor = Cursors.WaitCursor;
            } else {
                this.Cursor = Cursors.Default;
            }
        }

        private void messageTimer_Tick(object sender, EventArgs e) {
            if (ev3Messenger.IsConnected) {
                EV3Message message = ev3Messenger.ReadMessage();
                if (message != null) {
                    switch (message.MailboxTitle) {
                        case "Message":
                            lbLog.Items.Add(message);
                            lbLog.SelectedIndex = lbLog.Items.Count - 1;
                            break;
                        case "Tilt":
                            tbTilt1.Text = message.ValueAsNumber.ToString();
                            break;
                        case "Speed":
                            tbSpeed.Text = message.ValueAsNumber.ToString();
                            break;
                    }
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e) {
            if (ev3Messenger.IsConnected) {
                string[] words = tbLogInput.Text.Split(':');
                if (words.Length == 2) {
                    ev3Messenger.SendMessage(words[0], words[1]);
                } else {
                    lbLog.Items.Add("Wrong format, use <mailbox:message>");
                }
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e) {
            lbLog.Items.Clear();
        }

        private void cbControlMode_CheckedChanged(object sender, EventArgs e) {
            if (cbControlMode.Checked) {
                controlForm.Show();
                moveChildWindow(controlForm);
            } else {
                controlForm.Hide();
            }
        }

        private void MainForm_Resize(object sender, EventArgs e) {
            moveChildWindow(controlForm);
        }

        private void moveChildWindow(Form form) {
            if (form != null) {
                form.Top = this.Top;
                form.Left = this.Left + this.Width - 12;
            }
        }


        private void MainForm_Move(object sender, EventArgs e) {
            moveChildWindow(controlForm);
        }

        private void btnScoreboard_Click(object sender, EventArgs e) {
            if (scoreboardForm.Visible) {
                scoreboardForm.Hide();
            } else {
                scoreboardForm.Show();
            }
        }
    }
}
