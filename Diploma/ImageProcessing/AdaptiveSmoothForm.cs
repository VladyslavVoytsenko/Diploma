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
    public partial class AdaptiveSmoothForm : Form
    {
        private readonly AdaptiveSmoothing filter = new AdaptiveSmoothing(1.0);
        private double factor = 1.0;
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

        public AdaptiveSmoothForm()
        {
            InitializeComponent();

            factorBox.Text = factor.ToString(CultureInfo.InvariantCulture);
            trackBar.Value = (int)factor * 10;

            filterPreview.Filter = filter;
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

        private void factorBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ReturnMessageBox(factorBox);
                
                factor = Math.Max(0.1f, Math.Min(10.0f, double.Parse(factorBox.Text, CultureInfo.InvariantCulture)));

                updating = true;
                trackBar.Value = (int)(factor * 10);
                updating = false;

                filter.Factor = factor;
                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            if (!updating)
                factorBox.Text = ((double)trackBar.Value / 10).ToString(CultureInfo.InvariantCulture);
        }

        private void AdaptiveSmoothForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
