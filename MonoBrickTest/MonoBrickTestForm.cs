using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using MonoBrick.EV3;

namespace MonoBrickTest {
    public partial class MonoBrickTestForm : Form {
        private Brick<Sensor, Sensor, Sensor, Sensor> _EV3;

        public MonoBrickTestForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            _EV3 = new Brick<Sensor, Sensor, Sensor, Sensor>("USB");
            _EV3.Connection.Open();
        }

        private void btnSendByte_Click(object sender, EventArgs e) {
            tbName.Text = _EV3.GetRunningProgram();
        }
    }
}
