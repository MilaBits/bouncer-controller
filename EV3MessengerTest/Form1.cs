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

namespace EV3MessengerTest {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private EV3Messenger ev3Messenger = new EV3Messenger();

        private void Form1_Load(object sender, EventArgs e) {
            foreach (string portName in SerialPort.GetPortNames()) {
                comboBox1.Items.Add(portName);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (!ev3Messenger.IsConnected)
            {
                ev3Messenger.Connect(comboBox1.Text.ToUpper());
                flowLayoutPanel1.BackColor = Color.Green;
            }
            else
            {
                ev3Messenger.Disconnect();
                flowLayoutPanel1.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ev3Messenger.SendMessage("test", "test");
        }
    }
}
