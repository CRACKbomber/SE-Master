using SE_Master.UserControls;
using System.Runtime.InteropServices;

namespace SE_Master
{
    public partial class SEMaster : Form
    {
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        private void Move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public SEMaster()
        {
            InitializeComponent();
            UC_ZIP uc = new();
            addUserControl(uc);
        }

        private void MinimizeForm(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Minimized;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(67)))));
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
        }

        private void Button2_MouseHover(object sender, EventArgs e)
        {
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(67)))));
        }

        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
        }
        private void Button3_MouseHover(object sender, EventArgs e)
        {
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(67)))));
        }

        private void Button3_MouseLeave(object sender, EventArgs e)
        {
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
        }

        private void Button_info(object sender, EventArgs e)
        {
            InfoBox infoForm = new();
            infoForm.ShowDialog();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock= DockStyle.Fill;
            ActivePage.Controls.Clear();
            ActivePage.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void SEZIPtab_Click(object sender, EventArgs e)
        {
            UC_ZIP uc = new();
            addUserControl(uc);
        }

        private void SEMGDtab_Click(object sender, EventArgs e)
        {
            UC_MGD uc = new();
            addUserControl(uc);
        }

        private void SERTEtab_Click(object sender, EventArgs e)
        {
            UC_RTE uc = new();
            addUserControl(uc);
        }

        private void SESVRtab_Click(object sender, EventArgs e)
        {
            UC_SVR uc = new();
            addUserControl(uc);
        }

        private void SEXBXtab_Click(object sender, EventArgs e)
        {
            UC_XBX uc = new();
            addUserControl(uc);
        }
    }
}