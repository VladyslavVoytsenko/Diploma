﻿using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Diploma.ImageProcessing
{
    public partial class GammaCorrectionForm : Form
    {
        private GammaCorrection filter = new GammaCorrection();
        private bool updating = false;

        public Bitmap Image
        {
            set { filterPreview.Image = value; }
        }

        public IFilter Filter
        {
            get { return filter; }
        }

        public GammaCorrectionForm()
        {
            InitializeComponent();

            gammaBox.Text = filter.Gamma.ToString(CultureInfo.InvariantCulture);
            gammaTrackBar.Value = (int)(filter.Gamma * 1000);

            filterPreview.Filter = filter;
        }

        private void gammaTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (!updating)
                gammaBox.Text = ((double)gammaTrackBar.Value / 1000).ToString(CultureInfo.InvariantCulture);
        }

        private void gammaBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.gammaBox.Text.Contains(','))
                {
                    MessageBox.Show(this, "Incorrect decimal separator, use dot ( . ) instead of comma ( , )!", "Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                filter.Gamma = double.Parse(gammaBox.Text, CultureInfo.InvariantCulture);

                updating = true;
                gammaTrackBar.Value = (int)(filter.Gamma * 1000);
                updating = false;

                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
            }
        }
    }
}
