using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Diploma.ImageProcessing
{
    public partial class PixellateForm : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Pixellate filter = new Pixellate(8);

        public Bitmap Image
        {
            set => filterPreview.Image = value;
        }

        public IFilter Filter => filter;

        public PixellateForm()
        {
            InitializeComponent();

            widthBox.Text = filter.PixelWidth.ToString();
            heightBox.Text = filter.PixelHeight.ToString();

            widthTrackBar.Value = filter.PixelWidth;
            heightTrackBar.Value = filter.PixelHeight;

            filterPreview.Filter = filter;
        }

        private void widthBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filter.PixelWidth = int.Parse(widthBox.Text);
                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void widthTrackBar_Scroll(object sender, EventArgs e)
        {
            widthBox.Text = widthTrackBar.Value.ToString();
            if (!syncCheck.Checked) return;
            heightTrackBar.Value = widthTrackBar.Value;
            heightBox.Text = widthBox.Text;
        }

        private void heightBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filter.PixelHeight = int.Parse(heightBox.Text);
                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void heightTrackBar_Scroll(object sender, EventArgs e)
        {
            heightBox.Text = heightTrackBar.Value.ToString();
            if (!syncCheck.Checked) return;
            widthTrackBar.Value = heightTrackBar.Value;
            widthBox.Text = heightBox.Text;
        }

        private void PixellateForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
