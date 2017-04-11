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
            MoveLabels();
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

        private int scoreA;
        private int scoreB;
        private int time;
        private TimeSpan timespan;

        private void btnMinimize_Click(object sender, EventArgs e) {
            if (!maximized) {
                Screen screen = Screen.FromPoint(Cursor.Position);

                oldPosition = new Point(Left, Top);
                oldWidth = Width;
                oldHeight = Height;

                Left = screen.Bounds.X;
                Top = screen.Bounds.Y;
                Width = screen.Bounds.Width;
                Height = screen.Bounds.Height;
                maximized = true;

                MoveLabels();
            } else {
                Top = oldPosition.Y;
                Left = oldPosition.X;
                Width = oldWidth;
                Height = oldHeight;
                maximized = false;
            }
        }

        private void MoveLabels() {
            lbTime.Location = new Point((scorePanel.Width / 2) - (lbTime.Width / 2), scorePanel.Height / 7 - lbTime.Height / 2);

            lbScoreA.Location = new Point((scorePanel.Width / 3) - (lbScoreA.Width / 2), scorePanel.Height / 3 * 2 - lbScoreA.Height / 2);
            lbScoreALabel.Location = new Point((scorePanel.Width / 3) - (lbScoreALabel.Width / 2), scorePanel.Height / 3 * 2 - lbScoreALabel.Height / 2 - scorePanel.Height / 4);
            
            lbDivider.Location = new Point((scorePanel.Width / 2) - (lbDivider.Width / 2), scorePanel.Height / 3 * 2 - lbDivider.Height / 2);

            lbScoreB.Location = new Point((scorePanel.Width / 3 * 2) - (lbScoreB.Width / 2), scorePanel.Height / 3 * 2 - lbScoreB.Height / 2);
            lbScoreBLabel.Location = new Point((scorePanel.Width / 3 * 2) - (lbScoreBLabel.Width / 2), scorePanel.Height / 3 * 2 - lbScoreBLabel.Height / 2 - scorePanel.Height / 4);
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Hide();
        }

        private void ScoreboardForm_Load(object sender, EventArgs e) {

            lbTime.ForeColor = Color.FromArgb(115, 87, 94);
            lbDivider.ForeColor = Color.FromArgb(115, 87, 94);
            lbScoreA.ForeColor = Color.FromArgb(5, 182, 215);
            lbScoreB.ForeColor = Color.FromArgb(5, 182, 215);
            lbScoreALabel.ForeColor = Color.FromArgb(5, 182, 215);
            lbScoreBLabel.ForeColor = Color.FromArgb(5, 182, 215);
        }

        public void UpdateScore(Team team) {
            switch (team) {
                case Team.A:
                    scoreA++;
                    lbScoreA.Text = scoreA.ToString();
                    break;
                case Team.B:
                    scoreB++;
                    lbScoreB.Text = scoreB.ToString();
                    break;
            }
        }

        public enum Team {
            A, B
        }

        private void tmUpdate_Tick(object sender, EventArgs e) {
            if (Visible) {
                if (SharedData.timeLeft == 300) {
                    lbTime.Visible = true;
                    lbTime.ForeColor = Color.FromArgb(115, 87, 94);
                }
                
                if (SharedData.timeLeft >= 0) {
                    lbScoreA.Text = SharedData.scoreA.ToString();
                    lbScoreB.Text = SharedData.scoreB.ToString();
                    timespan = TimeSpan.FromSeconds(SharedData.timeLeft);
                    lbTime.Text = "TIME: " + timespan.ToString(@"m\:ss");

                    if (Convert.ToInt16(SharedData.timeLeft) <= 5) {
                        if (lbTime.ForeColor == Color.Red)
                            lbTime.ForeColor = Color.FromArgb(115, 87, 94);
                        else
                            lbTime.ForeColor = Color.Red;
                    }

                    if (SharedData.timeLeft > 0) {
                        SharedData.timeLeft--;
                    }
                }
            }
        }
    }
}
