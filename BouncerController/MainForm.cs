using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EV3MessengerLib;
using System.Management;

namespace BouncerController {
    public partial class MainForm : Form {
        private EV3Messenger bouncerAMessenger;
        private EV3Messenger bouncerBMessenger;
        private EV3Messenger sensorAMessenger;
        private EV3Messenger sensorBMessenger;
        private EV3Messenger fieldMessenger;
        private Form controlForm;
        private Form scoreboardForm;

        private Timer messageReceiveTimer;

        public MainForm() {
            InitializeComponent();
            bouncerAMessenger = bouncerBMessenger = sensorAMessenger = sensorBMessenger = fieldMessenger = new EV3Messenger();

            controlForm = new ControlForm();
            scoreboardForm = new ScoreboardForm();
        }

        private void FillComLists() {
            List<string> coms = new List<string>();
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'")) {
                var instances = new ManagementClass("Win32_SerialPort").GetInstances();
                foreach (ManagementObject port in instances) {
                    coms.Add(String.Format("{0}", port["deviceid"]));
                }
            }
            ComboBox[] comLists =
            {
                cbbFieldComs,
                cbbArduinoAComs, cbbArduinoBComs,
                cbbBouncerAComs, cbbBouncerBComs,
                cbbSensorsAComs, cbbSensorsBComs
            };

            foreach (var comboBox in comLists) {
                comboBox.Items.Clear();
                for (var i = 0; i < coms.Count; i++) {
                    string com = coms[i];
                    comboBox.Items.Add(com);
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

        }

        private void UpdateButtonsAndConnectionInfo() {
            bool isConnected = bouncerAMessenger.IsConnected;

            btnConnectBouncerA.Enabled = !isConnected;

            if (isConnected) {
                btnConnectBouncerA.Text = "Disconnect";
                tslConnection.Text = "Connected: " + bouncerAMessenger.Port;
                tspConnection.Value = 100;
                messageTimer.Start();
            } else {
                btnConnectBouncerA.Text = "Connect";
                tslConnection.Text = "Not Connected";
                tspConnection.Value = 0;
                messageTimer.Stop();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) {

            FillComLists();
        }

        private void messageTimer_Tick(object sender, EventArgs e) {
            if (bouncerAMessenger.IsConnected) {
                EV3Message message = bouncerAMessenger.ReadMessage();
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
            if (Convert.ToInt16(lbTimer.Text) < 10) {
                lbTimer.Text = (Convert.ToInt16(lbTimer.Text) + 1).ToString();
            } else {
                lbTimer.Text = "0";
            }
        }

        private void btnSend_Click(object sender, EventArgs e) {
            if (bouncerAMessenger.IsConnected) {
                string[] words = tbLogInput.Text.Split(':');
                if (words.Length == 2) {
                    //ev3Messenger.SendMessage(words[0], words[1]);
                    bouncerAMessenger.SendMessage("abc", "test");
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

        private void btnDefaultTilt_Click(object sender, EventArgs e) {
        }

        private void btnReset_Click(object sender, EventArgs e) {
        }

        private void btnConnectBouncerA_Click(object sender, EventArgs e) {
            if (btnConnectBouncerA.Text == "Connect") {
                //String port = cbbComPorts.Text.Substring(0,cbbComPorts.Text.IndexOf(' '));
                String port = cbbBouncerAComs.Text;
                if (bouncerAMessenger.Connect(port)) {
                    UpdateButtonsAndConnectionInfo();
                    lbLog.Items.Clear();
                    messageTimer.Start();
                } else {
                    MessageBox.Show("Failed to connect to serial port '" + port + "'.\n"
                        + "Is your EV3 connected to that serial port? Or is it using another one?");
                }
            } else {
                //messageReceiveTimer.Stop();
                bouncerAMessenger.Disconnect();
                UpdateButtonsAndConnectionInfo();
            }
        }
    }
}
