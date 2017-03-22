using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using MonoBrick.EV3;

namespace MonoBrickTest {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            var brick = new Brick<Sensor, Sensor, Sensor, Sensor>("USB");
            tbName.Text = brick.GetRunningProgram();
        }

        private void btnSendByte_Click(object sender, EventArgs e) {
            
        }
    }
}
