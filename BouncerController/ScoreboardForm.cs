using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncerController {
    public partial class ScoreboardForm : Form {
        public ScoreboardForm() {
            InitializeComponent();
        }

        #region Draggable Window
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override void WndProc(ref Message m) {
            switch (m.Msg) {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    if ((int)m.Result == HTCLIENT) {
                        m.Result = (IntPtr)HTCAPTION;
                    }

                    return;
            }

            base.WndProc(ref m);
        }
        #endregion
        
        private bool maximized;
        private Point oldPosition;
        private int oldWidth;
        private int oldHeight;

        private void btnMinimize_Click(object sender, EventArgs e) {
            if (!maximized) {

                oldPosition = new Point(Left, Top);
                oldWidth = Width;
                oldHeight = Height;

                Left = 0;
                Top = 0;
                Width = Screen.GetWorkingArea(MousePosition).Width;
                Height = Screen.GetWorkingArea(MousePosition).Height;
                maximized = true;
            } else
            {

                Top = oldPosition.Y;
                Left = oldPosition.X;
                Width = oldWidth;
                Height = oldHeight;
                maximized = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Hide();
        }
    }
}
