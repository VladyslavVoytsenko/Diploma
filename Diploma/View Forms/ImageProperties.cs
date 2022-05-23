using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Diploma.View_Forms
{
    public partial class ImageProperties : Form
    {
        public ImageProperties(IReadOnlyList<string> properties)
        {
            InitializeComponent();

            fileNameBox.Text = properties[0];
            directoryBox.Text = properties[1];
            compressionBox.Text = properties[2];
            resolutionBox.Text = properties[3];
            originalSizeBox.Text = properties[4];
            currentSizeBox.Text = properties[5];
            originalColorsBox.Text = properties[6];
            currentColorsBox.Text = properties[7];
            diskSizeBox.Text = properties[8];
            memorySizeBox.Text = properties[9];
            directoryIndexBox.Text = properties[10];
            fileDateTimeBox.Text = properties[11];
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ImageProperties_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
