using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Diploma.ImageProcessing
{
    public partial class BrightnessForm : Form
    {
        private readonly BrightnessCorrection filter = new BrightnessCorrection();
        
        private bool updating;

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

        private void brightnessBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (brightnessBox.Text.Contains(','))
                {
                    MessageBox.Show(this, "Incorrect decimal separator, use dot ( . ) instead of comma ( , )!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

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
    }
}
