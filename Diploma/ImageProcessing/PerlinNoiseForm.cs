using AForge.Imaging.Filters;
using AForge.Imaging.Textures;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Diploma.ImageProcessing
{
    public partial class PerlinNoiseForm : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private int imageWidth;
        private int imageHeight;

        public Bitmap Image
        {
            set
            {
                filterPreview.Image = value;
                imageWidth = value.Width;
                imageHeight = value.Height;
            }
        }

        public IFilter Filter { get; private set; }

        [Obsolete("Obsolete")]
        public PerlinNoiseForm()
        {
            InitializeComponent();

            effectComboBox.SelectedIndex = 0;
        }

        [Obsolete("Obsolete")]
        private void effectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (effectComboBox.SelectedIndex)
            {
                case 0:			// Marble effect
                    Filter = new Texturer(new MarbleTexture(imageWidth / 96, imageHeight / 48), 0.7f, 0.3f);
                    break;
                case 1:			// Wood effect
                    Filter = new Texturer(new WoodTexture(), 0.7f, 0.3f);
                    break;
                case 2:			// Clouds
                    Filter = new Texturer(new CloudsTexture(), 0.7f, 0.3f);
                    break;
                case 3:			// Labyrinth
                    Filter = new Texturer(new LabyrinthTexture(), 0.7f, 0.3f);
                    break;
                case 4:			// Textile
                    Filter = new Texturer(new TextileTexture(), 0.7f, 0.3f);
                    break;
                case 5:			// Dirty
                    var f = new TexturedFilter(new CloudsTexture(), new Sepia())
                    {
                        PreserveLevel = 0.30f,
                        FilterLevel = 0.90f
                    };

                    Filter = f;

                    break;
                case 6:			// Rusty
                    Filter = new TexturedFilter(new CloudsTexture(), new Sepia(), new GrayscaleBT709());

                    break;
            }

            filterPreview.Filter = Filter;
        }

        private void PerlinNoiseForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
