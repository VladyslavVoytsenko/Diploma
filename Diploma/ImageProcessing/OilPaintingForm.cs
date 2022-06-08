using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Diploma.ImageProcessing
{
    public partial class OilPaintingForm : Form
    {
        private OilPainting filter = new OilPainting(7);

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Bitmap Image
        {
            set => filterPreview.Image = value;
        }

        public IFilter Filter => filter;

        public OilPaintingForm()
        {
            InitializeComponent();

            trackBar.Value = (filter.BrushSize - 3) / 2;

            filterPreview.Filter = filter;
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            int v = trackBar.Value * 2 + 3;
            sizeBox.Text = v.ToString();
        }

        private void sizeBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filter.BrushSize = int.Parse(sizeBox.Text);
                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void OilPaintingForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
