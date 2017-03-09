using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EV3MessengerLib;

namespace BouncerController {
    public partial class Form1 : Form {
        private EV3Messenger ev3Messenger;

        public Form1() {
            InitializeComponent();
        }

        private void FillComList() {
            String[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);

            cbbComPorts.Items.Clear();
            foreach (String port in ports) {
                cbbComPorts.Items.Add(port);
            }
        }

        private void cbbComPorts_Click(object sender, EventArgs e) {
            FillComList();
        }

        private void btnConnect_Click(object sender, EventArgs e) {
            if (btnConnect.Text == "Connect") {
                String port = cbbComPorts.Text;
                if (ev3Messenger.Connect(port)) {
                    UpdateButtonsAndConnectionInfo();
                    lbLog.Items.Clear();
                    //messageReceiveTimer.Start();
                } else {
                    MessageBox.Show("Failed to connect to serial port '" + port + "'.\n"
                        + "Is your EV3 connected to that serial port? Or is it using another one?");
                }
            } else {
                //messageReceiveTimer.Stop();
                ev3Messenger.Disconnect();
                UpdateButtonsAndConnectionInfo();
            }
        }

        private void UpdateButtonsAndConnectionInfo() {
            bool isConnected = ev3Messenger.IsConnected;

            cbbComPorts.Enabled = !isConnected;

            if (isConnected) {
                btnConnect.Text = "Disconnect";
                tslConnection.Text = "Connected: " + ev3Messenger.Port;
                tspConnection.Value = 100;
            } else {
                btnConnect.Text = "Connect";
                tslConnection.Text = "Not Connected";
                tspConnection.Value = 0;
            }
        }

        private void cbbComPorts_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
