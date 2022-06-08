using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Diploma.ImageProcessing
{
    public partial class ThresholdForm : Form
    {
        private readonly Threshold filter = new Threshold();
        private byte threshold = 128;

        public Bitmap Image
        {
            set => filterPreview.Image = value;
        }

        public IFilter Filter => filter;

        public ThresholdForm()
        {
            InitializeComponent();

            thresholdBox.Text = threshold.ToString();
            slider.Min = threshold;

            // initial filter values
            filter.ThresholdValue = threshold;

            filterPreview.Filter = filter;
        }

        private void thresholdBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                slider.Min = threshold = byte.Parse(thresholdBox.Text);

                // refresh filter
                filter.ThresholdValue = threshold;
                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void slider_ValuesChanged(object sender, EventArgs e)
        {
            threshold = (byte)slider.Min;
            thresholdBox.Text = threshold.ToString();
        }
    }
}
