using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Diploma.ImageProcessing
{
    public partial class HueModifierForm : Form
    {
        private readonly HueModifier filter = new HueModifier();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);


        public Bitmap Image
        {
            set => filterPreview.Image = value;
        }

        public IFilter Filter => filter;

        public HueModifierForm()
        {
            InitializeComponent();

            hueBox.Text = filter.Hue.ToString();
            huePicker.Min = filter.Hue;

            filterPreview.Filter = filter;
        }

        private void huePicker_ValuesChanged(object sender, EventArgs e)
        {
            hueBox.Text = huePicker.Min.ToString();
        }

        private void hueBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                huePicker.Min = filter.Hue = int.Parse(hueBox.Text);
                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void HueModifierForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
