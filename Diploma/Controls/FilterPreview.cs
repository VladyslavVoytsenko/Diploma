using AForge.Imaging.Filters;
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Windows.Forms;

namespace Diploma.Controls
{
    public class FilterPreview : Control
    {
        private Bitmap previewImage;
        private Bitmap image;
        private IFilter filter;
        private readonly Pen blackPen = new Pen(Color.Black, 1);
        private readonly Cursor cursorHand;
        private readonly Cursor cursorHandMove;
        private int areaWidth, areaHeight;
        private int imageX, imageY;
        private bool tracking ;
        private int startTrackingX, startTrackingY;
        private int oldImageX, oldImageY;

        // Image property
        [Browsable(false)]
        public Bitmap Image
        {
            set
            {
                image = value;

                if (value != null)
                {
                    // calculate size of preview area
                    areaWidth = Math.Min(ClientRectangle.Width - 2, image.Width);
                    areaHeight = Math.Min(ClientRectangle.Height - 2, image.Height);

                    // calculate image position
                    imageX = (image.Width - areaWidth) >> 1;
                    imageY = (image.Height - areaHeight) >> 1;
                }

                RefreshFilter();
            }
        }

        // Filter property
        [Browsable(false)]
        public IFilter Filter
        {
            set
            {
                filter = value;
                RefreshFilter();
            }
        }

        // Constructor
        public FilterPreview()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.UserPaint, true);

            // load cursors
            cursorHand = Cursors.Hand;
            cursorHandMove = Cursors.WaitCursor;
        }

        // Dispose
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                blackPen.Dispose();

                if (previewImage != null)
                {
                    previewImage.Dispose();
                    cursorHand.Dispose();
                    cursorHandMove.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        // Initialize control
        private void InitializeComponent()
        {
            MouseUp += FilterPreview_MouseUp;
            MouseMove += FilterPreview_MouseMove;
            MouseDown += FilterPreview_MouseDown;
        }

        // Paint control
        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH", MessageId = "type: System.Byte[]")]
        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            Rectangle rc = ClientRectangle;
            int width = rc.Width;
            int height = rc.Height;

            // calculate size of preview area
            if (image != null)
            {
                width = areaWidth + 2;
                height = areaHeight + 2;
            }
            // calculate position of preview area
            var x = (rc.Width - width) >> 1;
            var y = (rc.Height - height) >> 1;

            // draw rectangle
            g.DrawRectangle(blackPen, x, y, width - 1, height - 1);

            x++;
            y++;

            if (image != null)
            {
                if (previewImage == null)
                {
                    // draw original image
                    g.DrawImage(image, new Rectangle(x, y, areaWidth, areaHeight), imageX, imageY, areaWidth, areaHeight, GraphicsUnit.Pixel);
                }
                else
                {
                    // draw preview image
                    g.DrawImage(previewImage, x, y, areaWidth, areaHeight);
                }
            }

            // Calling the base class OnPaint
            base.OnPaint(pe);
        }

        // Refresh preview
        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH", MessageId = "type: System.Byte[]")]
        public void RefreshFilter()
        {
            // release old image
            if (previewImage != null)
            {
                previewImage.Dispose();
                previewImage = null;
            }

            if ((image != null) && (filter != null))
            {
                Bitmap tmp = image.Clone(new Rectangle(imageX, imageY, areaWidth, areaHeight), image.PixelFormat);

                try
                {
                    previewImage = filter.Apply(tmp);
                }
                catch (Exception)
                {
                    // ignored
                }

                // release temp image
                tmp.Dispose();
            }

            // repaint
            Invalidate();
        }

        // On mouse move
        private void FilterPreview_MouseMove(object sender, MouseEventArgs e)
        {
            if (image == null) return;
            if (!tracking)
            {
                // calculate position of preview area
                int x = ((ClientRectangle.Width - areaWidth - 2) >> 1) + 1;
                int y = ((ClientRectangle.Height - areaHeight - 2) >> 1) + 1;

                // check mouse coordinates
                if ((e.X >= x) && (e.Y >= y) &&
                    (e.X < x + areaWidth) && (e.Y < y + areaHeight))
                {
                    Cursor = cursorHand;
                }
                else
                    Cursor = Cursors.Default;
            }
            else
            {
                int dx = e.X - startTrackingX;
                int dy = e.Y - startTrackingY;

                imageX = Math.Max(0, Math.Min(image.Width - areaWidth, oldImageX - dx));
                imageY = Math.Max(0, Math.Min(image.Height - areaHeight, oldImageY - dy));

                Invalidate();

                Cursor = cursorHandMove;
            }
        }

        // On mouse button down
        private void FilterPreview_MouseDown(object sender, MouseEventArgs e)
        {
            if ((image == null) || (e.Button != MouseButtons.Left)) return;
            // start tracking
            tracking = true;
            Capture = true;

            startTrackingX = e.X;
            startTrackingY = e.Y;

            oldImageX = imageX;
            oldImageY = imageY;

            // release preview image
            if (previewImage != null)
            {
                previewImage.Dispose();
                previewImage = null;
            }
            // repaint
            Invalidate();

            // set cursor
            Cursor = cursorHandMove;
        }

        // On mouse button up
        private void FilterPreview_MouseUp(object sender, MouseEventArgs e)
        {
            if (!tracking) return;
            // stop tracking
            tracking = false;
            Capture = false;

            RefreshFilter();

            // set cursor
            Cursor = cursorHand;
        }
    }
}
