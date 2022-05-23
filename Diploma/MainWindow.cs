using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma
{
    public partial class MainWindow : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private readonly Pages.Home home = new Pages.Home();
        public MainWindow()
        {
            InitializeComponent();
            //Pages.Home home = new Pages.Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.panelDesktopPane.Controls.Add(home);
            OpenChildForm(PagesContainer.Home);
            Text = String.Empty;
            ControlBox = false;
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void OpenChildForm(Form childForm)
        {
            activeForm?.Hide();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(childForm);
            panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        [Obsolete("Obsolete")]
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(PagesContainer.Home);
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(PagesContainer.Settings);
        }

        
    }
}
