using AForge.Imaging;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Diploma.Controls
{
    public enum HuePickerType
    {
        Value,
        Region
    }

    public class HuePicker : Control
    {
        private HuePickerType type = HuePickerType.Value;
        private readonly Pen blackPen;
        private readonly Brush blackBrush;
        private readonly Pen whitePen;
        private readonly Brush whiteBrush;
        private Point ptCenter = new Point(0, 0);
        private Point ptMin = new Point(0, 0);
        private Point ptMax = new Point(0, 0);
        private int trackMode;
        private int min;
        private int max = 359;

        // Values changed event
        public event EventHandler ValuesChanged;

        // Min property
        [DefaultValue(0)]
        public int Min
        {
            get => min;
            set
            {
                min = Math.Max(0, Math.Min(359, value));
                Invalidate();
            }
        }

        // Max property
        [DefaultValue(359)]
        public int Max
        {
            get => max;
            set
            {
                max = Math.Max(0, Math.Min(359, value));
                Invalidate();
            }
        }

        // Type property
        [DefaultValue(HuePickerType.Value)]
        public HuePickerType Type
        {
            get => type;
            set
            {
                type = value;
                Invalidate();
            }
        }

        // Constructor
        public HuePicker()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw |
                ControlStyles.DoubleBuffer | ControlStyles.UserPaint, true);

            blackPen = new Pen(Color.Black, 1);
            blackBrush = new SolidBrush(Color.Black);
            whitePen = new Pen(Color.White, 1);
            whiteBrush = new SolidBrush(Color.White);
        }

        // Dispose
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                blackPen.Dispose();
                blackBrush.Dispose();
                whitePen.Dispose();
                whiteBrush.Dispose();
            }
            base.Dispose(disposing);
        }

        // Initialize component
        private void InitializeComponent()
        {
            MouseUp += HSLPicker_MouseUp;
            MouseMove += HSLPicker_MouseMove;
            MouseDown += HSLPicker_MouseDown;
        }

        // Paint control
        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            Rectangle rc = ClientRectangle;
            Brush brush;
            RGB rgb = new RGB();
            HSL hsl = new HSL();

            // get pie rectangle
            var rcPie = new Rectangle(4, 4, Math.Min(rc.Right, rc.Bottom) - 8, Math.Min(rc.Right, rc.Bottom) - 8);

            // init HSL value
            hsl.Luminance = (float)0.5;
            hsl.Saturation = (float)1.0;

            if (type == HuePickerType.Value)
            {
                // draw HSL pie
                for (int i = 0; i < 360; i++)
                {
                    hsl.Hue = i;
                    // convert from HSL to RGB
                    HSL.ToRGB(hsl, rgb);
                    // create brush
                    brush = new SolidBrush(rgb.Color);
                    // draw one hue value
                    g.FillPie(brush, rcPie, -i, -1);

                    brush.Dispose();
                }
            }
            else
            {
                // draw HSL pie
                for (int i = 0; i < 360; i++)
                {
                    if (min < max && i >= min && i <= max ||
                        min > max && (i >= min || i <= max))
                    {
                        hsl.Hue = i;
                        // convert from HSL to RGB
                        HSL.ToRGB(hsl, rgb);
                        // create brush
                        brush = new SolidBrush(rgb.Color);
                    }
                    else
                    {
                        brush = new SolidBrush(Color.FromArgb(128, 128, 128));
                    }

                    // draw one hue value
                    g.FillPie(brush, rcPie, -i, -1);

                    brush.Dispose();
                }
            }

            double halfWidth = (double)rcPie.Width / 2;
            double angleRad = -min * Math.PI / 180;
            double angleCos = Math.Cos(angleRad);
            double angleSin = Math.Sin(angleRad);

            double x = halfWidth * angleCos;
            double y = halfWidth * angleSin;

            ptCenter.X = rcPie.Left + (int)halfWidth;
            ptCenter.Y = rcPie.Top + (int)halfWidth;
            ptMin.X = rcPie.Left + (int)(halfWidth + x);
            ptMin.Y = rcPie.Top + (int)(halfWidth + y);

            // draw MIN pointer
            g.FillEllipse(blackBrush,
                rcPie.Left + (int)(halfWidth + x) - 4,
                rcPie.Top + (int)(halfWidth + y) - 4,
                8, 8);
            g.DrawLine(blackPen, ptCenter, ptMin);

            // check picker type
            if (type == HuePickerType.Region)
            {
                angleRad = -max * Math.PI / 180;
                angleCos = Math.Cos(angleRad);
                angleSin = Math.Sin(angleRad);

                x = halfWidth * angleCos;
                y = halfWidth * angleSin;

                ptMax.X = rcPie.Left + (int)(halfWidth + x);
                ptMax.Y = rcPie.Top + (int)(halfWidth + y);

                // draw MAX pointer
                g.FillEllipse(whiteBrush,
                    rcPie.Left + (int)(halfWidth + x) - 4,
                    rcPie.Top + (int)(halfWidth + y) - 4,
                    8, 8);
                g.DrawLine(whitePen, ptCenter, ptMax);
            }

            base.OnPaint(pe);
        }

        // On mouse down
        private void HSLPicker_MouseDown(object sender, MouseEventArgs e)
        {
            // check coordinates of MIN pointer
            if (e.X >= ptMin.X - 4 && e.Y >= ptMin.Y - 4 &&
                e.X < ptMin.X + 4 && e.Y < ptMin.Y + 4)
            {
                trackMode = 1;
            }
            if (type == HuePickerType.Region)
            {
                // check coordinates of MAX pointer
                if (e.X >= ptMax.X - 4 && e.Y >= ptMax.Y - 4 &&
                    e.X < ptMax.X + 4 && e.Y < ptMax.Y + 4)
                {
                    trackMode = 2;
                }
            }

            if (trackMode != 0)
                Capture = true;
        }

        // On mouse up
        private void HSLPicker_MouseUp(object sender, MouseEventArgs e)
        {
            if (trackMode != 0)
            {
                // release capture
                Capture = false;
                trackMode = 0;

                // notify client
                if (ValuesChanged != null)
                    ValuesChanged(this, EventArgs.Empty);
            }
        }

        // On mouse move
        private void HSLPicker_MouseMove(object sender, MouseEventArgs e)
        {
            if (trackMode != 0)
            {
                int dy = e.Y - ptCenter.Y;
                int dx = e.X - ptCenter.X;

                if (trackMode == 1)
                {
                    // MIN pointer tracking
                    if (dx == 0)
                    {
                        min = dy < 0 ? 90 : 270;
                    }
                    else
                    {
                        min = (int)(-Math.Atan((double)dy / dx) * 180 / Math.PI);

                        if (dx < 0)
                            min = 180 + min;
                        if (min < 0)
                            min = 360 + min;
                    }
                }
                else
                {
                    // MAX pointer tracking
                    if (dx == 0)
                    {
                        max = dy < 0 ? 90 : 270;
                    }
                    else
                    {
                        max = (int)(-Math.Atan((double)dy / dx) * 180 / Math.PI);

                        if (dx < 0)
                            max = 180 + max;
                        if (max < 0)
                            max = 360 + max;
                    }
                }

                // repaint control
                Invalidate();
            }
        }
    }
}
