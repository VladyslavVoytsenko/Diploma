﻿using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Diploma.ImageProcessing
{
    public partial class ContrastForm : Form
    {
        private ContrastCorrection filter = new ContrastCorrection();
        private bool updating = false;

        public Bitmap Image
        {
            set { filterPreview.Image = value; }
        }

        public IFilter Filter
        {
            get { return filter; }
        }

        public ContrastForm()
        {
            InitializeComponent();

            contrastBox.Text = filter.Factor.ToString(CultureInfo.InvariantCulture);
            contrastTrackBar.Value = (int)(filter.Factor);

            filterPreview.Filter = filter;
        }

        private void contrastTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (!updating)
                contrastBox.Text = ((double)contrastTrackBar.Value).ToString(CultureInfo.InvariantCulture);
        }

        private void contrastBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.contrastBox.Text.Contains(','))
                {
                    MessageBox.Show(this, "Incorrect decimal separator, use dot ( . ) instead of comma ( , )!", "Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                filter.Factor = (int)double.Parse(contrastBox.Text, CultureInfo.InvariantCulture);

                updating = true;
                contrastTrackBar.Value = (int)(filter.Factor);
                updating = false;

                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }
    }
}
