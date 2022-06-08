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
    public partial class GaussianSharpenForm : Form
    {
        private readonly GaussianSharpen filter = new GaussianSharpen();
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

        public GaussianSharpenForm()
        {
            InitializeComponent();

            // set edit boxes
            sigmaBox.Text = filter.Sigma.ToString(CultureInfo.InvariantCulture);
            sizeBox.Text = filter.Size.ToString();

            // set sliders
            sigmaTrackBar.Value = (int)((filter.Sigma - 0.5) * 20);
            sizeTrackBar.Value = (filter.Size - 3) / 2;

            filterPreview.Filter = filter;
        }

        private void sigmaTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (updating) return;
            double v = (double)sigmaTrackBar.Value / 20 + 0.5;
            sigmaBox.Text = v.ToString(CultureInfo.InvariantCulture);
        }

        private void sizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (updating) return;
            var v = sizeTrackBar.Value * 2 + 3;
            sizeBox.Text = v.ToString();
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

                filter.Sigma = double.Parse(sigmaBox.Text, CultureInfo.InvariantCulture);

                updating = true;
                sigmaTrackBar.Value = (int)((filter.Sigma - 0.5) * 20);
                updating = false;

                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void sizeBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filter.Size = int.Parse(sizeBox.Text);

                updating = true;
                sizeTrackBar.Value = (filter.Size - 3) / 2;
                updating = false;

                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void GaussianSharpenForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
