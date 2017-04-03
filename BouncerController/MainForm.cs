using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using EV3MessengerLib;
using System.Management;

namespace BouncerController {
    public partial class MainForm : Form {
        public EV3Messenger bouncerAMessenger;
        public EV3Messenger bouncerBMessenger;
        private EV3Messenger sensorAMessenger;
        private EV3Messenger sensorBMessenger;
        private EV3Messenger fieldMessenger;

        private SerialPort arduinoA;
        private SerialPort arduinoB;

        private Form controlForm;
        private Form scoreboardForm;

        private Timer messageReceiveTimer;
        private Random random;

        private int[] sensorStates;

        public MainForm() {
            InitializeComponent();
            fieldMessenger = new EV3Messenger();
            bouncerAMessenger = new EV3Messenger();
            bouncerBMessenger = new EV3Messenger();
            sensorAMessenger = new EV3Messenger();
            sensorBMessenger = new EV3Messenger();

            scoreboardForm = new ScoreboardForm();
            random = new Random();
        }

        private void FillComLists() {
            List<string> coms = new List<string>();
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'")) {
                var instances = new ManagementClass("Win32_SerialPort").GetInstances();
                foreach (ManagementObject port in instances) {
                    coms.Add(String.Format("{0}", port["deviceid"]));
                }
            }
            coms.Sort();
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
        }

        private void UpdateButtonsAndConnectionInfo(string messenger, bool connected) {
            switch (messenger) {
                case "btnConnectBouncerA":
                    btnConnectBouncerA.Enabled = !connected;
                    cbbBouncerAComs.Enabled = !connected;
                    if (connected) {
                        pnlBouncerAStatus.BackColor = Color.Green;
                    } else {
                        pnlBouncerAStatus.BackColor = Color.Red;
                    }
                    break;
                case "btnConnectBouncerB":
                    btnConnectBouncerB.Enabled = !connected;
                    cbbBouncerBComs.Enabled = !connected;
                    if (connected) {
                        pnlBouncerBStatus.BackColor = Color.Green;
                    } else {
                        pnlBouncerBStatus.BackColor = Color.Red;
                    }
                    break;
                case "btnConnectSensorsA":
                    btnConnectSensorsA.Enabled = !connected;
                    cbbSensorsAComs.Enabled = !connected;
                    if (connected) {
                        pnlSensorsAStatus.BackColor = Color.Green;
                    } else {
                        pnlSensorsAStatus.BackColor = Color.Red;
                    }
                    break;
                case "btnConnectField":
                    btnConnectField.Enabled = !connected;
                    cbbFieldComs.Enabled = !connected;
                    if (connected) {
                        pnlFieldStatus.BackColor = Color.Green;
                    } else {
                        pnlFieldStatus.BackColor = Color.Red;
                    }
                    break;
                case "btnConnectArduinoA":
                    btnConnectArduinoA.Enabled = !connected;
                    cbbArduinoAComs.Enabled = !connected;
                    if (connected) {
                        pnlArduinoAStatus.BackColor = Color.Green;
                    } else {
                        pnlArduinoAStatus.BackColor = Color.Red;
                    }
                    break;
                case "btnConnectArduinoB":
                    btnConnectArduinoB.Enabled = !connected;
                    cbbArduinoBComs.Enabled = !connected;
                    if (connected) {
                        pnlArduinoBStatus.BackColor = Color.Green;
                    } else {
                        pnlArduinoBStatus.BackColor = Color.Red;
                    }
                    break;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            FillComLists();
            Cursor = Cursors.Default;
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
                            tbBouncerASpeed.Text = message.ValueAsNumber.ToString();
                            break;
                    }
                }
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e) {
            lbLog.Items.Clear();
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
            bouncerAMessenger.SendMessage("test", "");
        }

        private void connectToEV3(string port, EV3Messenger messenger, object sender) {
            if (messenger != null) {
                if (!messenger.IsConnected) {
                    if (messenger.Connect(port)) {
                        UpdateButtonsAndConnectionInfo(((Button)sender).Name, true);
                        messageTimer.Start();
                        lbMessageTimer.Text = "MessageTimer: Running";
                    } else {
                        MessageBox.Show("Failed to connect to serial port '" + port + "'.\n"
                                        + "Is your EV3 connected to that serial port? Or is it using another one?");
                    }
                } else {
                    messageReceiveTimer.Stop();
                    lbMessageTimer.Text = "MessageTimer: Stopped";
                    messenger.Disconnect();
                    UpdateButtonsAndConnectionInfo(((Button)sender).Name, false);
                }
            }
        }

        private void connectToArduino(string port, object sender) {
            switch (((Button)sender).Name) {
                case "btnConnectArduinoA":
                    arduinoA = new SerialPort(port, 9600);
                    arduinoA.WriteTimeout = 500;
                    arduinoA.Open();
                    UpdateButtonsAndConnectionInfo(((Button)sender).Name, true);
                    break;
                case "btnConnectArduinoB":
                    arduinoB = new SerialPort(port, 9600);
                    arduinoB.WriteTimeout = 500;
                    arduinoB.Open();
                    UpdateButtonsAndConnectionInfo(((Button)sender).Name, true);
                    break;
                default:
                    UpdateButtonsAndConnectionInfo(((Button)sender).Name, false);
                    MessageBox.Show("Failed to connect to serial port '" + port + "'.\n"
                                    + "Is your Arduino connected to that serial port? Or is it using another one?");
                    break;
            }
            messageTimer.Start();
        }

        #region Button Handling
        private void btnConnectField_Click(object sender, EventArgs e) {
            connectToEV3(cbbFieldComs.Text.ToUpper(), fieldMessenger, sender);
        }

        private void btnConnectBouncerA_Click(object sender, EventArgs e) {
            connectToEV3(cbbBouncerAComs.Text.ToUpper(), bouncerAMessenger, sender);
        }

        private void btnConnectBouncerB_Click(object sender, EventArgs e) {
            connectToEV3(cbbBouncerBComs.Text.ToUpper(), bouncerBMessenger, sender);
        }

        private void btnConnectSensorsA_Click(object sender, EventArgs e) {
            connectToEV3(cbbSensorsAComs.Text.ToUpper(), sensorAMessenger, sender);
        }

        private void btnConnectSensorsB_Click(object sender, EventArgs e) {
            connectToEV3(cbbSensorsBComs.Text.ToUpper(), sensorBMessenger, sender);
        }

        private void btnConnectArduinoA_Click(object sender, EventArgs e) {
            connectToArduino(cbbArduinoAComs.Text.ToUpper(), sender);
        }

        private void btnConnectArduinoB_Click(object sender, EventArgs e) {
            connectToArduino(cbbArduinoBComs.Text.ToUpper(), sender);
        }
        #endregion

        private void btnApplySettings_Click(object sender, EventArgs e) {
            btnApplySettings.Enabled = false;
            if (bouncerAMessenger.IsConnected) {
                bouncerAMessenger.SendMessage("update", Convert.ToInt16(nudSpeed.Value));
                tbBouncerASpeed.Text = nudSpeed.Text;

                bouncerAMessenger.SendMessage("Message", "test");
            }

            if (bouncerBMessenger.IsConnected) {
                bouncerBMessenger.SendMessage("update", Convert.ToInt16(nudSpeed.Value));
                tbBouncerBSpeed.Text = nudSpeed.Text;

                bouncerBMessenger.SendMessage("Message", "test");
            }

            if (sensorAMessenger.IsConnected) {
                sensorStates = GenerateSensorStates();
                string sensorString = String.Format("{0}{1}{2}{3}\n", sensorStates[0], sensorStates[1], sensorStates[2],
                    sensorStates[3]);

                sensorAMessenger.SendMessage("update", "" + CheckToInt(cbA1) + CheckToInt(cbA2) + CheckToInt(cbA3) + CheckToInt(cbA4));

                if (arduinoA.IsOpen) {
                    SetPanel("A1", sensorStates[0]);
                    SetPanel("A2", sensorStates[1]);
                    SetPanel("A3", sensorStates[2]);
                    SetPanel("A4", sensorStates[3]);

                    arduinoA.Write(sensorString);
                    arduinoA.DiscardOutBuffer();
                    arduinoA.DiscardInBuffer();
                    lbLog.Items.Add("Sent: " + sensorString + " to ArduinoA");
                }

            }
            if (sensorBMessenger.IsConnected) {
                int[] sensorStates = GenerateSensorStates();
                string sensorString = String.Format("{0}{1}{2}{3}\n", sensorStates[0], sensorStates[1], sensorStates[2],
                    sensorStates[3]);

                sensorAMessenger.SendMessage("update", "" + CheckToInt(cbB1) + CheckToInt(cbB2) + CheckToInt(cbB3) + CheckToInt(cbB4));

                if (arduinoA.IsOpen) {
                    SetPanel("B1", sensorStates[0]);
                    SetPanel("B2", sensorStates[1]);
                    SetPanel("B3", sensorStates[2]);
                    SetPanel("B4", sensorStates[3]);

                    arduinoA.Write(sensorString);
                    arduinoA.DiscardOutBuffer();
                    arduinoA.DiscardInBuffer();
                    lbLog.Items.Add("Sent: " + sensorString + " to ArduinoB");
                }
            }

            btnApplySettings.Enabled = true;
        }

        private int[] GenerateSensorStates() {
            int lightPos1 = random.Next(0, 4);
            int lightPos2 = random.Next(0, 4);

            while (lightPos1 == lightPos2) {
                lightPos2 = random.Next(0, 4);
            }
            int[] sensorString = { 0, 0, 0, 0 };
            sensorString[lightPos1] = 1;
            sensorString[lightPos2] = 2;
            return sensorString;
        }

        private void SetPanel(string sensor, int sensorState) {
            switch (sensor) {
                case "A1":
                    pnlA1.BackColor = GetColor(sensorState);
                    break;
                case "A2":
                    pnlA2.BackColor = GetColor(sensorState);
                    break;
                case "A3":
                    pnlA3.BackColor = GetColor(sensorState);
                    break;
                case "A4":
                    pnlA4.BackColor = GetColor(sensorState);
                    break;
                case "B1":
                    pnlA1.BackColor = GetColor(sensorState);
                    break;
                case "B2":
                    pnlA2.BackColor = GetColor(sensorState);
                    break;
                case "B3":
                    pnlA3.BackColor = GetColor(sensorState);
                    break;
                case "B4":
                    pnlA4.BackColor = GetColor(sensorState);
                    break;
            }
        }

        private Color GetColor(int state) {
            switch (state) {
                case 0:
                    return Color.DimGray;
                    break;
                case 1:
                    return Color.Red;
                    break;
                case 2:
                    return Color.LimeGreen;
                    break;
            }
            return Color.Black;
        }

        private int CheckToInt(CheckBox cb) {
            if (cb.Checked)
                return 1;
            return 0;
        }

        private void cbA1_CheckedChanged(object sender, EventArgs e) {
        }

        private void lbLog_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
