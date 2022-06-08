using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Diploma.ImageProcessing
{
    public partial class CustomRotationForm : Form
    {
        private BaseRotateFilter filter;
        private int redColor;
        private int greenColor;
        private int blueColor;
        private bool updating;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);


        public IFilter Filter => filter;

        public CustomRotationForm()
        {
            InitializeComponent();

            angleBox.Text = @"45";
            redBox.Text = @"0";
            greenBox.Text = @"0";
            blueBox.Text = @"0";

            UpdateFillColor();

            methodCombo.SelectedIndex = 1;
        }
        
        private void UpdateFillColor()
        {
            try
            {
                colorBox.BackColor = colorBox.FlatAppearance.MouseDownBackColor
                    = colorBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, redColor, greenColor, blueColor);
                colorBox.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    Equals(Thread.CurrentThread.CurrentUICulture, new CultureInfo("uk"))
                        ? @"Редактор зображень"
                        : @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool CheckRgbValue(int color)
        {
            if (color >= 0 && color <= 255)
            {
                return true;
            }

            if (Equals(Thread.CurrentThread.CurrentUICulture, new  CultureInfo("uk")))
            {
                MessageBox.Show(this, @"Введено неправильне значення RGB, має бути 0-255!", @"Редактор зображень", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(this, @"Incorrect RGB value entered, must be 0-255!", @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            return false;
        }

        private void redBox_TextChanged(object sender, EventArgs e)
        {
            redColor = int.Parse(redBox.Text);
            if (!updating && CheckRgbValue(redColor))
                UpdateFillColor();
        }

        private void greenBox_TextChanged(object sender, EventArgs e)
        {
            greenColor = int.Parse(greenBox.Text);
            if (!updating && CheckRgbValue(greenColor))
                UpdateFillColor();
        }

        private void blueBox_TextChanged(object sender, EventArgs e)
        {
            blueColor = int.Parse(blueBox.Text);
            if (!updating && CheckRgbValue(blueColor))
                UpdateFillColor();
        }

        private void colorBox_MouseMove(object sender, MouseEventArgs e)
        {
            colorBox.Cursor = Cursors.Arrow;
        }

        private void colorBox_MouseDown(object sender, MouseEventArgs e)
        {
            colorBox.FlatAppearance.BorderSize = 0;
            colorBox.Size = new Size(68, 18);
            colorBox.Location = new Point(67, 44);
        }

        private void colorBox_MouseUp(object sender, MouseEventArgs e)
        {
            colorBox.Size = new Size(70, 20);
            colorBox.Location = new Point(66, 43);
            colorBox.FlatAppearance.BorderSize = 1;
        }

        private void colorBox_Click(object sender, EventArgs e)
        {
            ActiveControl = redBox;

            ColorDialog dialog = new ColorDialog();
            dialog.FullOpen = true;
            dialog.ShowHelp = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                colorBox.BackColor = colorBox.FlatAppearance.MouseDownBackColor
                    = colorBox.FlatAppearance.MouseOverBackColor = dialog.Color;
                updating = true;
                redBox.Text = dialog.Color.R.ToString();
                greenBox.Text = dialog.Color.G.ToString();
                blueBox.Text = dialog.Color.B.ToString();
                updating = false;
            }
        }

        private void colorBox_MouseClick(object sender, MouseEventArgs e)
        {
            colorBox.FlatAppearance.BorderSize = 1;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                // get rotation angle
                double angle = double.Parse(angleBox.Text);

                // create appropriate rotation filter
                switch (methodCombo.SelectedIndex)
                {
                    case 0:
                        filter = new RotateNearestNeighbor(angle);
                        break;
                    case 1:
                        filter = new RotateBilinear(angle);
                        break;
                    case 2:
                        filter = new RotateBicubic(angle);
                        break;
                }

                // fill color
                filter.FillColor = Color.FromArgb(
                    byte.Parse(redBox.Text),
                    byte.Parse(greenBox.Text),
                    byte.Parse(blueBox.Text));

                // keep size
                filter.KeepSize = keepSizeCheck.Checked;

                // close dialog
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception)
            {
                if (Equals(Thread.CurrentThread.CurrentUICulture, new  CultureInfo("uk")))
                {
                    MessageBox.Show(this, @"Введено неправильні значення!", @"Помилка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(this, @"Incorrect values are entered!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CustomRotationForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
