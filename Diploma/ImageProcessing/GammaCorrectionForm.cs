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
    public partial class GammaCorrectionForm : Form
    {
        private readonly GammaCorrection filter = new GammaCorrection();
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
        
        private void gammaBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ReturnMessageBox(gammaBox);
                

                filter.Gamma = double.Parse(gammaBox.Text, CultureInfo.InvariantCulture);

                updating = true;
                gammaTrackBar.Value = (int)(filter.Gamma * 1000);
                updating = false;

                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void GammaCorrectionForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
