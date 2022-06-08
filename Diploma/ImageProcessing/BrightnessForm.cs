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
    public partial class BrightnessForm : Form
    {
        private readonly BrightnessCorrection filter = new BrightnessCorrection();
        
        private bool updating;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        
        public Bitmap Image
        {
            set => filterPreview.Image = value;
        }

        public IFilter Filter => filter;

        public BrightnessForm()
        {
            InitializeComponent();

            brightnessBox.Text = filter.AdjustValue.ToString(CultureInfo.InvariantCulture);
            brightnessTrackBar.Value = filter.AdjustValue;

            filterPreview.Filter = filter;
        }

        private void brightnessTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (!updating)
                brightnessBox.Text = ((double)brightnessTrackBar.Value).ToString(CultureInfo.InvariantCulture);
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
        
        private void brightnessBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ReturnMessageBox(brightnessBox);

                filter.AdjustValue = (int)double.Parse(brightnessBox.Text, CultureInfo.InvariantCulture);

                updating = true;
                brightnessTrackBar.Value = filter.AdjustValue;
                updating = false;

                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            
        }

        private void BrightnessForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

    }
}
