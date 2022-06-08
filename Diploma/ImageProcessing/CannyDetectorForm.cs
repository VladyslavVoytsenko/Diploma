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
    public partial class CannyDetectorForm : Form
    {
        private readonly CannyEdgeDetector filter = new CannyEdgeDetector();
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

        public CannyDetectorForm()
        {
            InitializeComponent();

            // set edit boxes
            sigmaBox.Text = filter.GaussianSigma.ToString(CultureInfo.InvariantCulture);
            lowThresholdBox.Text = filter.LowThreshold.ToString();
            highThresholdBox.Text = filter.HighThreshold.ToString();

            // set sliders
            sigmaTrackBar.Value = (int)((filter.GaussianSigma - 1.0) * 20);
            thresholdSlider.Min = filter.LowThreshold;
            thresholdSlider.Max = filter.HighThreshold;

            filterPreview.Filter = filter;
        }

        private void sigmaTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (!updating)
            {
                double v = (double)sigmaTrackBar.Value / 20 + 1.0;
                sigmaBox.Text = v.ToString(CultureInfo.InvariantCulture);
            }
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

        private void sigmaBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ReturnMessageBox(sigmaBox);

                filter.GaussianSigma = double.Parse(sigmaBox.Text, CultureInfo.InvariantCulture);

                updating = true;
                sigmaTrackBar.Value = (int)((filter.GaussianSigma - 1.0) * 20);
                updating = false;

                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void lowThresholdBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                thresholdSlider.Min = int.Parse(lowThresholdBox.Text);

                filter.LowThreshold = byte.Parse(lowThresholdBox.Text);

                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void highThresholdBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                thresholdSlider.Max = int.Parse(highThresholdBox.Text);

                filter.HighThreshold = byte.Parse(highThresholdBox.Text);

                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void thresholdSlider_ValuesChanged(object sender, EventArgs e)
        {
            lowThresholdBox.Text = thresholdSlider.Min.ToString();
            highThresholdBox.Text = thresholdSlider.Max.ToString();
        }

        private void CannyDetectorForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
