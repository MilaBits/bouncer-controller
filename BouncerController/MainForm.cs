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
        private EV3Messenger bouncerAMessenger;
        private EV3Messenger bouncerBMessenger;
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
        private bool LedTick;

        public MainForm() {
            InitializeComponent();
            fieldMessenger = new EV3Messenger();
            bouncerAMessenger = new EV3Messenger();
            bouncerBMessenger = new EV3Messenger();
            sensorAMessenger = new EV3Messenger();
            sensorBMessenger = new EV3Messenger();

            scoreboardForm = new ScoreboardForm();
            random = new Random();
            sensorStates = GenerateSensorStates();
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

        private void btnApplySettings_Click(object sender, EventArgs e) {
            ApplySettings();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            FillComLists();
        }

        private void btnScoreboard_Click(object sender, EventArgs e) {
            ToggleScoreboard();
        }

        private void btnDefaultTilt_Click(object sender, EventArgs e) {
            bouncerAMessenger.SendMessage("test", "");
        }
        #endregion

        private void FillComLists() {
            Cursor = Cursors.WaitCursor;
            List<string> coms = new List<string>();
            using (
                var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'")
            ) {
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
                if (comboBox.Enabled) {
                    comboBox.Items.Clear();
                    for (var i = 0; i < coms.Count; i++) {
                        string com = coms[i];
                        comboBox.Items.Add(com);
                    }
                }
            }
            Cursor = Cursors.Default;
        }

        private void UpdateButtonsAndConnectionInfo(string messenger, bool connected) {
            switch (messenger) {
                case "btnConnectBouncerA":
                    btnConnectBouncerA.Enabled = !connected;
                    cbbBouncerAComs.Enabled = !connected;
                    pnlBouncerAStatus.BackColor = connected ? Color.Green : Color.Red;
                    break;
                case "btnConnectBouncerB":
                    btnConnectBouncerB.Enabled = !connected;
                    cbbBouncerBComs.Enabled = !connected;
                    pnlBouncerBStatus.BackColor = connected ? Color.Green : Color.Red;
                    break;
                case "btnConnectSensorsA":
                    btnConnectSensorsA.Enabled = !connected;
                    cbbSensorsAComs.Enabled = !connected;
                    pnlSensorsAStatus.BackColor = connected ? Color.Green : Color.Red;
                    break;
                case "btnConnectSensorsB":
                    btnConnectSensorsB.Enabled = !connected;
                    cbbSensorsBComs.Enabled = !connected;
                    pnlSensorsBStatus.BackColor = connected ? Color.Green : Color.Red;
                    break;
                case "btnConnectField":
                    btnConnectField.Enabled = !connected;
                    cbbFieldComs.Enabled = !connected;
                    pnlFieldStatus.BackColor = connected ? Color.Green : Color.Red;
                    break;
                case "btnConnectArduinoA":
                    btnConnectArduinoA.Enabled = !connected;
                    cbbArduinoAComs.Enabled = !connected;
                    pnlArduinoAStatus.BackColor = connected ? Color.Green : Color.Red;
                    break;
                case "btnConnectArduinoB":
                    btnConnectArduinoB.Enabled = !connected;
                    cbbArduinoBComs.Enabled = !connected;
                    pnlArduinoBStatus.BackColor = connected ? Color.Green : Color.Red;
                    break;
            }
        }

        private void messageTimer_Tick(object sender, EventArgs e) {
            if (SharedData.timeLeft > 0) {
                if (fieldMessenger.IsConnected) {
                    EV3Message message = fieldMessenger.ReadMessage();
                    if (message != null && message.MailboxTitle == "Fire") {
                        if (message.ValueAsText == "A") {
                            if (bouncerAMessenger.IsConnected) bouncerAMessenger.SendMessage("Fire", "Fire");
                        } else if (message.ValueAsText == "B") {
                            if (bouncerBMessenger.IsConnected) bouncerBMessenger.SendMessage("Fire", "Fire");
                        }
                    } else if (message != null && message.MailboxTitle == "Score") {
                        if (message.ValueAsText == "A") {
                            SharedData.scoreA++;
                        } else if (message.ValueAsText == "B") {
                            SharedData.scoreB++;
                        }
                    }
                }

                if (bouncerAMessenger.IsConnected) {
                    EV3Message message = bouncerAMessenger.ReadMessage();
                    if (message != null && message.MailboxTitle == "Speed") {
                        tbBouncerASpeed.Text = message.ValueAsNumber.ToString();
                    }
                }

                if (bouncerBMessenger.IsConnected) {
                    EV3Message message = bouncerBMessenger.ReadMessage();
                    if (message != null && message.MailboxTitle == "Speed") {
                        tbBouncerBSpeed.Text = message.ValueAsNumber.ToString();
                    }
                }
                if (sensorAMessenger.IsConnected) {
                    SensorHandler(sensorAMessenger, bouncerAMessenger);
                }
                if (sensorBMessenger.IsConnected) {
                    SensorHandler(sensorBMessenger, bouncerBMessenger);
                }

                //log stuff
                //lbLog.Items.Add(String.Format("{0}{1}{2}{3}\n", sensorStates[0], sensorStates[1], sensorStates[2],
                    //sensorStates[3]));
                lbLog.SelectedIndex = lbLog.Items.Count - 1;
            }
        }

        private void SensorHandler(EV3Messenger receiver, EV3Messenger sender) {
            char team = ' ';
            if (receiver == sensorAMessenger) team = 'A';
            if (receiver == sensorBMessenger) team = 'B';
            if (team == ' ') return;

            EV3Message message = receiver.ReadMessage();
            if (message != null) {
                if (message.MailboxTitle == "Pressed") {
                    switch (Convert.ToInt16(message.ValueAsNumber)) {
                        case 0:
                            sender.SendMessage("Move", "Stop");
                            lbLog.Items.Add(team + "0: Stop");
                            break;
                        case 1:
                            if (sensorStates[0] == 1) {
                                sender.SendMessage("Move", "Right");
                                lbLog.Items.Add(team + "1: Right");
                            } else if (sensorStates[0] == 2) {
                                sender.SendMessage("Move", "Left");
                                lbLog.Items.Add(team + "1: Left");
                            }
                            break;
                        case 2:
                            if (sensorStates[1] == 1) {
                                sender.SendMessage("Move", "Right");
                                lbLog.Items.Add(team + "2: Right");
                            } else if (sensorStates[1] == 2) {
                                sender.SendMessage("Move", "Left");
                                lbLog.Items.Add(team + "2: Left");
                            }
                            break;
                        case 3:
                            if (sensorStates[2] == 1) {
                                sender.SendMessage("Move", "Right");
                                lbLog.Items.Add(team + "3: Right");
                            } else if (sensorStates[2] == 2) {
                                sender.SendMessage("Move", "Left");
                                lbLog.Items.Add(team + "3: Left");
                            }
                            break;
                        case 4:
                            if (sensorStates[3] == 1) {
                                sender.SendMessage("Move", "Right");
                                lbLog.Items.Add(team + "4: Right");
                            } else if (sensorStates[3] == 2) {
                                sender.SendMessage("Move", "Left");
                                lbLog.Items.Add(team + "4: Left");
                            }
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
                    //messageReceiveTimer.Stop();
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

        private void ToggleScoreboard() {
            if (scoreboardForm.Visible) {
                scoreboardForm.Hide();
            } else {
                scoreboardForm.Show();
            }
        }

        private void ApplySettings() {
            btnApplySettings.Enabled = false;

            if (bouncerAMessenger.IsConnected) {
                //Set speed of bouncerA
                bouncerAMessenger.SendMessage("Speed", Convert.ToInt16(nudSpeed.Value));
                bouncerAMessenger.SendMessage("Fire", "Fire");
                tbBouncerASpeed.Text = nudSpeed.Text;
            }

            if (bouncerBMessenger.IsConnected) {
                //Set speed of BouncerB
                bouncerBMessenger.SendMessage("Speed", Convert.ToInt16(nudSpeed.Value));
                tbBouncerBSpeed.Text = nudSpeed.Text;
            }

            if (sensorAMessenger.IsConnected) {
                //Generate sensor states
                sensorStates = GenerateSensorStates();
                string sensorString = String.Format("{0}{1}{2}{3}\n", sensorStates[0], sensorStates[1], sensorStates[2],
                    sensorStates[3]);

                //Send sensorstring to SensorsA
                sensorAMessenger.SendMessage("update", sensorString);

                if (arduinoA != null && arduinoA.IsOpen) {
                    SetPanel("A1", sensorStates[0]);
                    SetPanel("A2", sensorStates[1]);
                    SetPanel("A3", sensorStates[2]);
                    SetPanel("A4", sensorStates[3]);

                    arduinoA.Write(sensorString);
                    arduinoA.DiscardOutBuffer();
                    arduinoA.DiscardInBuffer();
                    lbLog.Items.Add("Sent: " + sensorString + " to ArduinoA");
                } else {
                    lbLog.Items.Add("Connection with ArduinoA is not open or connected");
                }
            }

            if (sensorBMessenger.IsConnected) {
                int[] sensorStates = GenerateSensorStates();
                string sensorString = String.Format("{0}{1}{2}{3}\n", sensorStates[0], sensorStates[1], sensorStates[2],
                    sensorStates[3]);

                sensorBMessenger.SendMessage("update", sensorString);

                if (arduinoB != null && arduinoB.IsOpen) {
                    SetPanel("B1", sensorStates[0]);
                    SetPanel("B2", sensorStates[1]);
                    SetPanel("B3", sensorStates[2]);
                    SetPanel("B4", sensorStates[3]);

                    arduinoB.Write(sensorString);
                    arduinoB.DiscardOutBuffer();
                    arduinoB.DiscardInBuffer();
                    lbLog.Items.Add("Sent: " + sensorString + " to ArduinoB");
                } else {
                    lbLog.Items.Add("Connection with ArduinoB is not open or connected");
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
                    pnlB1.BackColor = GetColor(sensorState);
                    break;
                case "B2":
                    pnlB2.BackColor = GetColor(sensorState);
                    break;
                case "B3":
                    pnlB3.BackColor = GetColor(sensorState);
                    break;
                case "B4":
                    pnlB4.BackColor = GetColor(sensorState);
                    break;
            }
        }

        private Color GetColor(int state) {
            switch (state) {
                case 0:
                    return Color.DimGray;
                case 1:
                    return Color.Red;
                case 2:
                    return Color.LimeGreen;
            }
            return Color.Black;
        }

        private void btnScoreStart_Click(object sender, EventArgs e) {
            SharedData.timeLeft = 300;
            SharedData.scoreA = 0;
            SharedData.scoreB = 0;
        }

        private void tmBlink_Tick(object sender, EventArgs e) {
            if (SharedData.timeLeft < 1) {
                LedTick = !LedTick;
                if (LedTick) {
                    if (arduinoA != null && arduinoA.IsOpen) arduinoA.Write("2121\n");
                    if (arduinoB != null && arduinoB.IsOpen) arduinoB.Write("2121\n");
                } else {
                    if (arduinoA != null && arduinoA.IsOpen) arduinoA.Write("1212\n");
                    if (arduinoB != null && arduinoB.IsOpen) arduinoB.Write("1212\n");
                }

                if (arduinoA != null && arduinoA.IsOpen) arduinoA.DiscardInBuffer();
                if (arduinoB != null && arduinoB.IsOpen) arduinoB.DiscardInBuffer();
            }
        }
    }
}