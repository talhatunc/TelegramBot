using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TelegramBot.Forms;

namespace TelegramBot
{
    public partial class FormMain : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        private UserControl activeForm = null;
        private Panel leftBorderBtn;
        private UserControl formHome = new Forms.FormHome();
        public FormMain()
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 40);
            leftBorderBtn.BackColor = System.Drawing.Color.FromArgb(62, 104, 182);
            leftBorderBtn.Visible = false;
            leftBorderBtn.BackColor = Color.FromArgb(0, 126, 249);
            Controls.Add(leftBorderBtn);
            InitializeComponent();
            this.panelScreen.Controls.Add(formHome);
            formHome.Hide();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, this.ClientSize.Width, this.ClientSize.Height, 15, 15)
            );
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public void OpenChildForm(UserControl childForm)
        {
            formHome.Hide();
            CloseActiveForm();
            activeForm = childForm;
            this.panelScreen.Controls.Add(activeForm);
            activeForm.Show();
        }

        private void CloseActiveForm()
        {
            if (activeForm != null)
            {
                this.Controls.Remove(activeForm);
                activeForm.Dispose();
                activeForm = null;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            CloseActiveForm();
            formHome.Show();
            leftBorderBtn.Height = btnHome.Height;
            leftBorderBtn.Top = btnHome.Top;
            leftBorderBtn.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(46, 51, 73);
            leftBorderBtn.Visible = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            UserControl childForm = new Forms.FormHome();
            leftBorderBtn.Height = btnSettings.Height;
            leftBorderBtn.Top = btnSettings.Top;
            leftBorderBtn.Left = btnSettings.Left;
            leftBorderBtn.Visible = true;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCommands_Leave(object sender, EventArgs e)
        {
            btnCommands.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnConfig_Leave(object sender, EventArgs e)
        {
            btnConfig.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCommands_Click(object sender, EventArgs e)
        {
            UserControl childForm = new Forms.FormCommands();
            OpenChildForm(childForm);
            leftBorderBtn.Height = btnCommands.Height;
            leftBorderBtn.Top = btnCommands.Top;
            leftBorderBtn.Left = btnCommands.Left;
            leftBorderBtn.Visible = true;
            btnCommands.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            UserControl childForm = new Forms.FormConfiguration();
            OpenChildForm(childForm);
            leftBorderBtn.Height = btnConfig.Height;
            leftBorderBtn.Top = btnConfig.Top;
            leftBorderBtn.Left = btnConfig.Left;
            leftBorderBtn.Visible = true;
            btnConfig.BackColor = Color.FromArgb(46, 51, 73);
        }
    }
}
