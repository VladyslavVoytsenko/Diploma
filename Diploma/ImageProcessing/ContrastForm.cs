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
    public partial class ContrastForm : Form
    {
        private readonly ContrastCorrection filter = new ContrastCorrection();
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

        public ContrastForm()
        {
            InitializeComponent();

            contrastBox.Text = filter.Factor.ToString(CultureInfo.InvariantCulture);
            contrastTrackBar.Value = filter.Factor;

            filterPreview.Filter = filter;
        }

        private void contrastTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (!updating)
                contrastBox.Text = ((double)contrastTrackBar.Value).ToString(CultureInfo.InvariantCulture);
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
        
        private void contrastBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ReturnMessageBox(contrastBox);

                filter.Factor = (int)double.Parse(contrastBox.Text, CultureInfo.InvariantCulture);

                updating = true;
                contrastTrackBar.Value = filter.Factor;
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

        private void ContrastForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
