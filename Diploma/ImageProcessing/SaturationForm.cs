using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Diploma.ImageProcessing
{
    public partial class SaturationForm : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private readonly SaturationCorrection filter = new SaturationCorrection();
        private bool updating;

        public Bitmap Image
        {
            set => filterPreview.Image = value;
        }

        public IFilter Filter => filter;

        public SaturationForm()
        {
            InitializeComponent();

            saturationBox.Text = (filter.AdjustValue/1000.0).ToString(CultureInfo.InvariantCulture);
            saturationTrackBar.Value = (int)filter.AdjustValue*1000 ;

            filterPreview.Filter = filter;
        }

        private void saturationTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (!updating)
                saturationBox.Text = (saturationTrackBar.Value / 1000.0).ToString(CultureInfo.InvariantCulture);
        }
        
        private void ReturnMessageBox(Control textBox)
        {
            if (!textBox.Text.Contains(',')) return;
            if (Equals(Thread.CurrentThread.CurrentUICulture, new  CultureInfo("uk")))
            {
                MessageBox.Show(this, @"Неправильний десятковий роздільник, використовуйте крапку ( . ) замість коми ( , )!", @"Редактор зображень", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(this, @"Incorrect decimal separator, use dot ( . ) instead of comma ( , )!", @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void saturationBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ReturnMessageBox(saturationBox);

                filter.AdjustValue = float.Parse(saturationBox.Text, CultureInfo.InvariantCulture);

                updating = true;
                saturationTrackBar.Value = (int)filter.AdjustValue*1000;
                updating = false;

                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void SaturationForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
