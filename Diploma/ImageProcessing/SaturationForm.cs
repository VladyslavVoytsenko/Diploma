﻿using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Diploma.ImageProcessing
{
    public partial class SaturationForm : Form
    {
        private SaturationCorrection filter = new SaturationCorrection();
        private bool updating = false;

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

        private void saturationBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.saturationBox.Text.Contains(','))
                {
                    MessageBox.Show(this, "Incorrect decimal separator, use dot ( . ) instead of comma ( , )!", "Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

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
    }
}
