using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using Diploma.ImageProcessing;
using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Point = System.Drawing.Point;

namespace Diploma.Pages
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            var topLevelControl = printPreviewDialog.TopLevelControl;
            this.printPreviewDialog.TopLevelControl.Text = "Print Preview";
            //SetMenuItems(false);
            imageDisplay.Select();
        }

        #region ClassArrayPoints

        private class ArrayPoints
        {
            private int index;
            private Point[] points;

            public ArrayPoints(int size )
            {
                if (size < 0)  size = 2; 
                points = new Point[size];
            }

            public void SetPoint(int x, int y)
            {
                if(index>=points.Length) index = 0;
                points[index] = new Point(x, y);
                index++;
            }

            public void ResetPoints() => index = 0;

            public int GetCountPoints() { return index; }

            public Point[] GetPoints() { return points; }
        }

        #endregion

        #region Fields

        private string imageFile;                                       // name of the file we want to display
        private ArrayList imageFiles;                                   // list which contains all image files in the current folder
        private int currentFileIndex = -1;                              // index of the currently used file, if the value is -1 there is no open file                    
        private FileInfo imageFileInfo;                                 // image file information
        private Bitmap bitmap;                                          // bitmap object of the image file we want to display
        private Bitmap deletedBitmap;                                   // image cleared from the screen (can be reopened)
        private Bitmap undoBitmap;                                      // bitmap for storing the state of the image before the last change
        private Bitmap zoomBitmap;                                      // bitmap for zooming
        private Bitmap resetBitmap;                                      // bitmap for reset image
        private PointF position;                                        // point from which the image is drawn
        private float zoom = 1.00F;                                     // current image zoom
        private float zoomFactor = 1.00F;                               // zoom factor, used when changing image dimensions
        private bool fitImagesToWindow;                                 // size image to fit the window dimensions
        private bool deleteImage;                                       // clear image from the window
        private bool isDeleted;                                         // image is deleted/cleared
        private bool toGrayscale;                                       // convert image to 8 bpp grayscale
        private bool cropping;                                          // image cropping
        private bool cropped;                                           // image cropped
        private bool dragging;                                          // mouse drag
        private bool fullScreen;                                        // image is in full screen mode
        private bool croppingState;                                     // cropping state
        private bool centerImagesState;                                 // image centering state
        private bool fitImagesState;                                    // fit images to window state
        private bool toolBarShowState;                                  // toolbar visibility state
        private bool statusBarShowState;                                // status bar visibility state
        private bool PencilTool = false;                                        // pen tool
        
        private int formTop;                                            // window top position
        private int formLeft;                                           // window left position
        private int formWidth;                                          // window width
        private int formHeight;                                         // window height
        private FormWindowState formState = FormWindowState.Normal;     // window state
        private const string Filter =                                   // filter for Open and Save dialogs
                                "All Supported Formats|*.jpg;*.jpeg;*.bmp;*.gif;*.png;*.tif;*.tiff|"
                                + "JPEG - Joint Photographic Experts Group|*.jpg;*.jpeg|"
                                + "BMP - Windows Bitmap|*.bmp|"
                                + "GIF - CompuServe Graphics Interchange Format|*.gif|"
                                + "PNG - Portable Network Graphics|*.png|"
                                + "TIFF - Tagged Image File Format|*.tif;*.tiff|"
                                + "All Files (*.*)|*.*";
        private Point bitmapPoint;                                      // image coordinates (x,y)
        private Point displayStartPoint;                                // cropping start point on the display
        private Point displayEndPoint;                                  // cropping end point on the display
        private Point cropStartPoint;                                   // cropping start point on the image
        private Point cropEndPoint;                                     // cropping end point on the image
        private Rectangle selection;                                    // cropping selection rectangle
                                                                        //private MailAddress from_email;
                                                                        //private object data;
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 3f);
        #endregion


        #region ClassObjects
        private ArrayPoints arrayPoints = new ArrayPoints(2);
        #endregion




        #region Methods

        private void ResetForm()
        {
            //StatusLabelDepth.Available = StatusLabelFileIndex.Available = StatusLabelZoom.Available =
            //StatusLabelFileSize.Available = StatusLabelDateTime.Available = false;
            //StatusLabelDimensions.Text = "No file loaded (use File->Open)";
            //StatusLabelDimensions.BorderSides = ToolStripStatusLabelBorderSides.None;
            Text = "ImageEditor";
            MenuItemReopen.Enabled = true;
            MenuItemUndo.Enabled = false;
            toolStripButtonUndo.Enabled = false;
            SetMenuItems(false);
        }
        private void CheckZoom()
        {
            zoom = zoomFactor;
            if (zoom < 0.09F || zoom > 5.01F)
            {
                MessageBox.Show("Image zoom must be between 10 and 500% !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (zoom < 0.09F)
                    zoomFactor += 0.10F;
                else
                    zoomFactor -= 0.10F;
                zoom = zoomFactor;
            }
        }

        public void ApplyFilterInPlace(IInPlaceFilter filter)
        {
            try
            {
                SetUndo();
                filter.ApplyInPlace(bitmap);
                MenuItemUndo.Enabled = true;
                toolStripButtonUndo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.imageDisplay.Invalidate();
        }

        private ImageFormat FormatFromExtension(string ext)
        {
            if (ext.IndexOf('.') > 0)
                ext = ext.Substring(ext.LastIndexOf('.') + 1);
            switch (ext.ToLower())
            {
                case "jpg":
                case "jpeg":
                    return ImageFormat.Jpeg;
                case "bmp":
                    return ImageFormat.Bmp;
                case "gif":
                    return ImageFormat.Gif;
                case "png":
                    return ImageFormat.Png;
                case "tif":
                case "tiff":
                    return ImageFormat.Tiff;
            }
            return null;
        }

        private void SaveImage(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                throw new Exception("Unspecified file name.");

            if (File.Exists(filePath) && (File.GetAttributes(filePath) & FileAttributes.ReadOnly) != 0)
                throw new Exception("File exists and is read-only!");

            ImageFormat format = FormatFromExtension(filePath);
            if (format == null)
                throw new Exception("Unsupported image format.");

            MemoryStream mss = new MemoryStream();
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);

            if (Equals(format, ImageFormat.Jpeg))
            {
                ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
                ImageCodecInfo ici = null;
                foreach (ImageCodecInfo codec in codecs)
                {
                    if (codec.MimeType == "image/jpeg")
                        ici = codec;
                }
                EncoderParameters ep = new EncoderParameters(1);
                ep.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)85);
                if (ici != null) bitmap.Save(mss, ici, ep);
            }
            else
                bitmap.Save(mss, format);
            byte[] array = mss.ToArray();
            fs.Write(array, 0, array.Length);

            mss.Close();
            fs.Close();
            mss.Dispose();
            fs.Dispose();

            Stream st = File.Open(GetFilePath(), FileMode.Open, FileAccess.Read, FileShare.Read);
            byte[] b = new byte[st.Length];
            st.Read(b, 0, b.Length);
            MemoryStream ms = new MemoryStream(b);
            deletedBitmap = (Bitmap)System.Drawing.Image.FromStream(ms, true);
        }


        private string ReturnBitDepth(string pixFormat)
        {
            string bitDepth;
            switch (pixFormat)
            {
                case "Format1bppIndexed":
                    bitDepth = "1 BPP";
                    break;
                case "Format4bppIndexed":
                    bitDepth = "4 BPP";
                    break;
                case "Format8bppIndexed":
                    bitDepth = "8 BPP";
                    break;
                case "Format16bppGrayScale":
                case "Format16bppRgb555":
                case "Format16bppRgb565":
                case "Format16bppArgb1555":
                    bitDepth = "16 BPP";
                    break;
                case "Format24bppRgb":
                    bitDepth = "24 BPP";
                    break;
                case "Format32bppRgb":
                case "Format32bppArgb":
                case "Format32bppPArgb":
                    bitDepth = "32 BPP";
                    break;
                case "Format48bppRgb":
                    bitDepth = "48 BPP";
                    break;
                case "Format64bppArgb":
                case "Format64bppPArgb":
                    bitDepth = "64 BPP";
                    break;
                default:
                    bitDepth = "Unknown pixel format";
                    break;
            }
            return bitDepth;
        }

        private string ColorsFromPixelFormat(string pixelFormat)
        {
            string colors;
            switch (pixelFormat)
            {
                case "Format1bppIndexed":
                    colors = "2 (1 bit per pixel)";
                    break;
                case "Format4bppIndexed":
                    colors = "16 (4 bits per pixel)";
                    break;
                case "Format8bppIndexed":
                    colors = "256 (8 bits per pixel)";
                    break;
                case "Format16bppGrayScale":
                case "Format16bppRgb555":
                case "Format16bppRgb565":
                case "Format16bppArgb1555":
                    colors = "65536 (16 bits per pixel)";
                    break;
                case "Format24bppRgb":
                    colors = "16777216 (24 bits per pixel)";
                    break;
                case "Format32bppRgb":
                case "Format32bppArgb":
                case "Format32bppPArgb":
                    colors = "16777216 (32 bits per pixel)";
                    break;
                default:
                    colors = "Unknown";
                    break;
            }
            return colors;
        }

        private void SetMenuItems(bool enabledState)
        {
            ToolStripButton[] toolStripButtons = new ToolStripButton[] { toolStripButtonSaveAs, toolStripButton1, toolStripButtonPrintImage ,
            toolStripButtonDelete,toolStripButtonUndo, ImageProperties, toolStripButtonZoomIn, toolStripButtonZoomOut, toolStripButtonFullScreen,
            toolStripButtonCrop, toolStripButtonRotateLeft, toolStripButtonRotateRight, FlipVertical, FlipHorizontal, toolStripButtonActualSize,
            toolStripButtonFitImages, toolStripButtonSend, toolStripButtonReset, toolStripButtonBrightness, toolStripButtonContrast, toolStripButtonColorFiltering,
            toolStripButtonSaturation, toolStripButtonHUE, toolStripButtonSmooth, toolStripButtonResize, toolStripButtonCustomRotation};

           // ToolStripButton[] toolStripButtonsNextPrev = new ToolStripButton[] { toolStripButtonPreviousImage, toolStripButtonNextImage };
            foreach (ToolStripButton button in toolStripButtons)
            {
                button.Enabled = enabledState;
            }

            this.MenuItemSave.Enabled = this.MenuItemSaveAs.Enabled = this.MenuItemPrint.Enabled =
                 this.MenuItemZoom.Enabled = this.MenuItemImageProperties.Enabled = this.MenuItemFullScreen.Enabled =
                this.MenuItemDelete.Enabled = this.MenuItemHistogram.Enabled  = this.MenuItemCut.Enabled = this.MenuItemCopy.Enabled = enabledState;

            this.MenuItemImage.Visible = this.MenuItemAdjustments.Visible = this.MenuItemEffects.Visible = enabledState;

            this.toolStripButtonSaveAs.Enabled = this.toolStripButtonDelete.Enabled = this.toolStripButtonPrintImage.Enabled = this.toolStripButtonCrop.Enabled =
                 this.toolStripButtonActualSize.Enabled = this.toolStripButtonFitImages.Enabled = this.toolStripButtonRotateLeft.Enabled = this.toolStripButtonRotateRight.Enabled =
                 this.toolStripButtonFullScreen.Enabled = enabledState;

            if (imageFiles.Count > 1)
            {
                MenuItemPreviousImage.Enabled = MenuItemNextImage.Enabled = MenuItemFirstImage.Enabled =
                    MenuItemLastImage.Enabled = MenuItemRandomImage.Enabled =
                toolStripButtonPreviousImage.Enabled = toolStripButtonNextImage.Enabled = enabledState;
            }

            MenuItemZoom.Enabled = toolStripButtonZoomIn.Enabled = toolStripButtonZoomOut.Enabled = enabledState;

        }

            private void ExitFullScreen()
        {
            fullScreen = false;
            cropping = croppingState;
            //if (centerImagesState)
            //    //MenuItemCenterImages.Checked = true;
            //else
            //    //MenuItemCenterImages.Checked = false;
            fitImagesToWindow = fitImagesState;
            BackColor = SystemColors.ControlDark;
            imageDisplay.BackColor = SystemColors.ControlDark;
            //this.mainMenu.Visible = true;
            //if (toolBarShowState)
            //{
            //    MenuItemShowToolbar.Checked = true;
            //    this.toolBar.Visible = true;
            //}
            //else
            //{
            //    MenuItemShowToolbar.Checked = false;
            //    this.toolBar.Visible = false;
            //}
            //if (statusBarShowState)
            //{
            //    MenuItemShowStatusBar.Checked = true;
            //    this.statusBar.Visible = true;
            //}
            //else
            //{
            //    MenuItemShowStatusBar.Checked = false;
            //    this.statusBar.Visible = false;
            //}
            //this.FormBorderStyle = FormBorderStyle.Sizable;
            toolStrip1.Visible = true;
            toolStrip2.Visible = true;
            statusBar.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            //panel3.Visible = true;
            WindowState = (FormWindowState)FormBorderStyle.None;
            Top = formTop;
            Left = formLeft;
            WindowState = formState;
            Width = formWidth;
            Height = formHeight;
        }
        private void SetUndo()
        {
            undoBitmap?.Dispose();
            undoBitmap = (Bitmap)bitmap.Clone();
        }

        private static Bitmap ColorToGrayscale(Bitmap bmp)
        {
            int w = bmp.Width,
                h = bmp.Height,
                r, ic, oc,
                outputStride, bytesPerPixel;
            PixelFormat pfIn = bmp.PixelFormat;
            ColorPalette palette;
            Bitmap output;
            BitmapData bmpData, outputData;

            output = new Bitmap(w, h, PixelFormat.Format8bppIndexed);

            palette = output.Palette;
            for (var i = 0; i < 256; i++)
            {
                Color tmp = Color.FromArgb(255, i, i, i);
                palette.Entries[i] = Color.FromArgb(255, i, i, i);
            }
            output.Palette = palette;

            if (pfIn == PixelFormat.Format8bppIndexed)
            {
                output = (Bitmap)bmp.Clone();

                output.Palette = palette;

                return output;
            }

            switch (pfIn)
            {
                case PixelFormat.Format24bppRgb: bytesPerPixel = 3; break;
                case PixelFormat.Format32bppArgb: bytesPerPixel = 4; break;
                case PixelFormat.Format32bppRgb: bytesPerPixel = 4; break;
                default: throw new InvalidOperationException("Image format not supported");
            }

            bmpData = bmp.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.ReadOnly, pfIn);
            outputData = output.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
            var bmpStride = bmpData.Stride;
            outputStride = outputData.Stride;

            unsafe
            {
                byte* bmpPtr = (byte*)bmpData.Scan0.ToPointer(),
                outputPtr = (byte*)outputData.Scan0.ToPointer();

                if (bytesPerPixel == 3)
                {
                    for (r = 0; r < h; r++)
                        for (ic = oc = 0; oc < w; ic += 3, ++oc)
                            outputPtr[r * outputStride + oc] = (byte)(int)
                                (0.299f * bmpPtr[r * bmpStride + ic] +
                                 0.587f * bmpPtr[r * bmpStride + ic + 1] +
                                 0.114f * bmpPtr[r * bmpStride + ic + 2]);
                }
                else
                {
                    for (r = 0; r < h; r++)
                        for (ic = oc = 0; oc < w; ic += 4, ++oc)
                            outputPtr[r * outputStride + oc] = (byte)(int)
                                ((bmpPtr[r * bmpStride + ic] / 255.0f) *
                                (0.299f * bmpPtr[r * bmpStride + ic + 1] +
                                 0.587f * bmpPtr[r * bmpStride + ic + 2] +
                                 0.114f * bmpPtr[r * bmpStride + ic + 3]));
                }
            }

            bmp.UnlockBits(bmpData);
            output.UnlockBits(outputData);

            return output;
        }

        private void ApplyFilter(IFilter filter)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                SetUndo();

                Bitmap newBitmap = filter.Apply(bitmap);
                if (cropped)
                    newBitmap = filter.Apply(zoomBitmap);

                if (toGrayscale)
                {
                    Bitmap tempBitmap = ColorToGrayscale(newBitmap);
                    bitmap = (Bitmap)tempBitmap.Clone();
                    tempBitmap.Dispose();
                    toGrayscale = false;
                }
                else
                {
                    bitmap = new Bitmap(newBitmap.Size.Width, newBitmap.Size.Height, PixelFormat.Format24bppRgb);
                    Graphics g = Graphics.FromImage(bitmap);
                    g.DrawImage(newBitmap, new Point(0, 0));
                    g.Dispose();
                }
                newBitmap.Dispose();
                MenuItemUndo.Enabled = true;
                toolStripButtonUndo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            imageDisplay.Invalidate();
        }

        private Point CalculateMouseOverImagePosition(int mouseX, int mouseY)
        {
            Point point = new Point();
            if (zoomBitmap.Width <= imageDisplay.Width && zoomBitmap.Height <= imageDisplay.Height)
            {
                point.X = mouseX - (int)position.X;
                point.Y = mouseY - (int)position.Y;
            }
            else
            {
                if (fitImagesToWindow)
                {
                    point.X = mouseX - (int)position.X;
                    point.Y = mouseY - (int)position.Y;
                }
                else
                {
                    point.X = imageDisplay.AutoScrollOffset.X + mouseX - (int)position.X;
                    point.Y = imageDisplay.AutoScrollOffset.Y + mouseY - (int)position.Y;
                }
            }
            return point;
        }

        private void ProcessDirectory()
        {
            ArrayList fileTypes = new ArrayList();
            fileTypes.Add("*.JPG");
            fileTypes.Add("*.JPEG");
            fileTypes.Add("*.BMP");
            fileTypes.Add("*.GIF");
            fileTypes.Add("*.PNG");
            fileTypes.Add("*.TIF");

            imageFiles = new ArrayList();
            string[] files;
            foreach (string type in fileTypes)
            {
                files = Directory.GetFiles(Directory.GetCurrentDirectory(), type); if (files.Length > 0) imageFiles.AddRange(files);
            }
            if (imageFiles.Count > 0)
            {
                imageFiles.Sort(); if (imageFile != "") currentFileIndex = imageFiles.IndexOf(imageFile);
            }
            else
                currentFileIndex = -1;
        }
        private string GetFilePath()
        {
            if (currentFileIndex > imageFiles.Count - 1)
                currentFileIndex = 0;
            return imageFiles[currentFileIndex].ToString();
        }
        private void ShowPicture()
        {
            try
            {
                if (isDeleted)
                {
                    bitmap = (Bitmap)deletedBitmap.Clone();
                }
                else
                {
                    FileStream st = File.Open(GetFilePath(), FileMode.Open, FileAccess.Read, FileShare.Read);
                    byte[] b = new byte[st.Length];
                    st.Read(b, 0, b.Length); MemoryStream ms = new MemoryStream(b);
                    bitmap = (Bitmap)System.Drawing.Image.FromStream(ms, true);
                    zoomBitmap = new Bitmap(bitmap, new Size(bitmap.Width, bitmap.Height));
                    deletedBitmap = (Bitmap)bitmap.Clone();
                    resetBitmap = (Bitmap)bitmap.Clone();
                }

                printImage.DocumentName = Path.GetFileName(GetFilePath()); if (bitmap.Width > bitmap.Height) printImage.DefaultPageSettings.Landscape = true;
                else printImage.DefaultPageSettings.Landscape = false;
                //printPreviewDialog.PrintPreviewControl.Document.DefaultPageSettings = printImage.DefaultPageSettings;

                SetMenuItems(true); 
                zoomFactor = 1.00F;
                this.imageDisplay.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private Bitmap GenerateSurface(Bitmap imgParent, List<Bitmap> surfImgs, ToothSurfaceMaterial material)
        //{
        //    Bitmap mask = new Bitmap(imgParent.Width, imgParent.Height,
        //                   System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

        //    using (Graphics g = Graphics.FromImage(mask))
        //    {
        //        foreach (Bitmap img in surfImgs)
        //        {
        //            g.DrawImage(img, System.Drawing.Point.Empty);
        //        }
        //    }

        //    Bitmap output = new Bitmap(mask.Width, mask.Height,
        //                   System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

        //    using (Graphics g = Graphics.FromImage(output))
        //    {
        //        if (material.HatchStyle != null)
        //        {
        //            HatchBrush hb = new HatchBrush((HatchStyle)material.HatchStyle, material.FgColor, material.BgColor);
        //            g.FillRectangle(hb, new Rectangle(0, 0, output.Width, output.Height));
        //        }
        //        else
        //        {
        //            SolidBrush sb = new SolidBrush(material.FgColor);
        //            g.FillRectangle(sb, new Rectangle(0, 0, output.Width, output.Height));
        //        }

        //    }

        //    var rect = new Rectangle(0, 0, output.Width, output.Height);
        //    var bitsMask = mask.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
        //    var bitsOutput = output.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
        //    unsafe
        //    {
        //        int offset = 0;
        //        for (int y = 0; y < mask.Height; y++)
        //        {
        //            byte* ptrMask = (byte*)bitsMask.Scan0 + y * bitsMask.Stride;
        //            byte* ptrOutput = (byte*)bitsOutput.Scan0 + y * bitsOutput.Stride;
        //            for (int x = 0; x < mask.Width; x++)
        //            {
        //                offset = 4 * x + 3;
        //                ptrOutput[offset] = (byte)(ptrMask[offset] * 0.7);
        //            }
        //        }
        //    }
        //    mask.UnlockBits(bitsMask);
        //    output.UnlockBits(bitsOutput);

        //    return output;

        //}

        #endregion

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Open Image File";
            openFileDialog.Filter = Filter;
            openFileDialog.Multiselect = false;
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageFile = openFileDialog.FileName;
                    Directory.SetCurrentDirectory(Directory.GetParent(imageFile)?.FullName ?? string.Empty);
                    ProcessDirectory();
                    zoomFactor = 1.00F;
                    isDeleted = false;
                    if (currentFileIndex != -1)
                        ShowPicture();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void toolStripButtonSaveAs_Click(object sender, EventArgs e)
        {
            string filePath =GetFilePath();
            string fileName = Path.GetFileName(filePath);

            saveFileDialog.Title = "Save Image As";
            saveFileDialog.Filter = Filter;
            saveFileDialog.FileName = fileName;
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.AddExtension = true;
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog.FileName;
                    filePath = Path.GetFullPath(fileName);

                    SaveImage(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void imageDisplay_Paint(object sender, PaintEventArgs e)
        {
            
            if (deleteImage)
            {
                bitmap = null;
                if (imageDisplay.AutoScroll)
                {
                    imageDisplay.AutoScroll = false;
                }
                ResetForm();
                isDeleted = true; deleteImage = false; return;
            }

            if (bitmap == null) return;
            try
            {
                
                Graphics g = e.Graphics; g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                if (cropped)
                {
                    zoomFactor = 1.0F;
                    cropped = false;
                }

                if (bitmap.Width * zoomFactor <= imageDisplay.Width && bitmap.Height * zoomFactor <= imageDisplay.Height)
                {
                    CheckZoom(); 
                    this.imageDisplay.AutoScroll = false;
                    if (MenuItemCenterImages.Checked)
                    {
                    position.X = (imageDisplay.Width - bitmap.Width * zoomFactor) / 2;
                    position.Y = (imageDisplay.Height - bitmap.Height * zoomFactor) / 2;
                    }
                    else
                    {
                    position.X = 0;
                    position.Y = 0;
                    }

                    g.DrawImage(bitmap, new RectangleF(position.X, position.Y, bitmap.Width * zoomFactor, bitmap.Height * zoomFactor));

                    if (fullScreen)
                    {
                        string fileIndex = " [" + (currentFileIndex + 1).ToString() + "/" + imageFiles.Count.ToString() + "]";
                        g.DrawString(GetFilePath() + fileIndex, new Font("Segoe UI", 10, GraphicsUnit.Point), Brushes.Lime, new Point(2, 2));
                    }

                    zoomBitmap = new Bitmap(bitmap, new Size((int)(bitmap.Width * zoomFactor), (int)(bitmap.Height * zoomFactor)));

                    this.Text = Path.GetFileName(GetFilePath()) + " - Image editor";
                }
                else
                {
                    if (fitImagesToWindow)
                    {
                        this.imageDisplay.AutoScroll = false;

                        int maxWidth = imageDisplay.Width, maxHeight = imageDisplay.Height; int width = bitmap.Width, height = bitmap.Height;
                        float ratio = (float)width / (float)height;
                        width = maxWidth;
                        height = (int)Math.Floor(maxWidth / ratio);

                        if (height > maxHeight)
                        {
                            height = maxHeight;
                            width = (int)Math.Floor(maxHeight * ratio);
                        }

                        position.X = 0;
                        position.Y = 0;
                        if (MenuItemCenterImages.Checked)
                        {
                        if (height < imageDisplay.Height)
                        {
                            position.X = 0;
                            position.Y = (imageDisplay.Height - height) / 2;
                        }
                        else
                        {
                            position.X = (imageDisplay.Width - width) / 2;
                            position.Y = 0;
                        }
                        }

                        g.DrawImage(bitmap, new RectangleF(position.X, position.Y, width, height));

                        if (fullScreen)
                        {
                            string fileIndex = " [" + (currentFileIndex + 1).ToString() + "/" + imageFiles.Count.ToString() + "]";
                            g.DrawString(GetFilePath() + fileIndex, new Font("Segoe UI", 10, GraphicsUnit.Point), Brushes.Lime, new Point(2, 2));
                        }

                        zoomBitmap = new Bitmap(bitmap, new Size(width, height));

                        zoom = (float)Math.Min((float)width / bitmap.Width, (float)height / bitmap.Height);
                    }
                    else
                    {
                        CheckZoom();
                        imageDisplay.AutoScroll = true;

                        float zoomWidth = bitmap.Width * zoomFactor;
                        float zoomHeight = bitmap.Height * zoomFactor;
                        Size zoomSize = new Size((int)zoomWidth, (int)zoomHeight);

                        imageDisplay.AutoScrollMinSize = zoomSize;
                        position.X = imageDisplay.AutoScrollPosition.X;
                        position.Y = imageDisplay.AutoScrollPosition.Y;

                        if (MenuItemCenterImages.Checked && (zoomSize.Height < imageDisplay.Height || zoomSize.Width < imageDisplay.Width))
                        {
                            if (zoomSize.Height < imageDisplay.Height)
                            {
                                position.X = imageDisplay.AutoScrollPosition.X;
                                position.Y = (imageDisplay.Height - zoomSize.Height) / 2;
                            }
                            else
                            {
                                position.X = (imageDisplay.Width - zoomSize.Width) / 2;
                                position.Y = imageDisplay.AutoScrollPosition.Y;
                            }
                        }

                        g.DrawImage(bitmap, new RectangleF(position.X, position.Y, zoomSize.Width, zoomSize.Height));

                        zoomBitmap = new Bitmap(bitmap, new Size(zoomSize.Width, zoomSize.Height));

                        this.Text = Path.GetFileName(GetFilePath()) + " - Image Editor";
                    }
                }
                if (dragging)
                {
                    Pen pen = Pens.Lime;
                    g.DrawRectangle(pen, selection);
                }
                else
                {
                    //ShowStatusBarInfo();

                    MenuItemReopen.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        

        private void toolStripButtonPrintImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printImage.Print();
                }
            }
            catch (InvalidPrinterException ex)
            {
                MessageBox.Show(ex.Message, "Image editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            deleteImage = true;
            this.imageDisplay.Invalidate();
        }

        private void imageDisplay_Click(object sender, EventArgs e)
        {
            if (fullScreen)
                ExitFullScreen();
        }

        

        private void imageDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (cropping && this.Cursor == Cursors.Cross)
                {
                    dragging = true;

                    displayStartPoint = e.Location;
                    cropStartPoint = bitmapPoint;

                    selection = new Rectangle(new Point(displayStartPoint.X, displayStartPoint.Y), new Size());
                }
            }
            PencilTool = true;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void imageDisplay_MouseLeave(object sender, EventArgs e)
        {
            StatusLabelMousePosition.Visible = false;
            StatusLabelRGB.Visible = false;
            StatusLabelHSL.Visible = false;
            this.Cursor = Cursors.Default;
        }

        
       


        private void imageDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            if (bitmap != null)
            {
                bitmapPoint = CalculateMouseOverImagePosition(e.X, e.Y);
                int posX = bitmapPoint.X, posY = bitmapPoint.Y;

                if (zoomBitmap.Width <= imageDisplay.Width && zoomBitmap.Height <= imageDisplay.Height)
                {
                    if (posX < 0 || posY < 0 || posX >= zoomBitmap.Width || posY >= zoomBitmap.Height ||
                        e.X < position.X || e.X > position.X + zoomBitmap.Width || e.Y < position.Y || e.Y > position.Y + zoomBitmap.Height)
                    {
                        StatusLabelMousePosition.Visible = false;
                        StatusLabelRGB.Visible = false;
                        StatusLabelHSL.Visible = false;
                        this.Cursor = Cursors.Default;
                        return;
                    }
                }
                else
                {
                    if (fitImagesToWindow)
                    {
                        int maxWidth = imageDisplay.Width, maxHeight = imageDisplay.Height;
                        int width = bitmap.Width, height = bitmap.Height;

                        float ratio = (float)width / (float)height;

                        width = maxWidth;
                        height = (int)Math.Floor(maxWidth / ratio);

                        if (height > maxHeight)
                        {
                            height = maxHeight;
                            width = (int)Math.Floor(maxHeight * ratio);
                        }

                        if (posX < 0 || posY < 0 || posX >= width || posY >= height ||
                            e.X < position.X || e.X > position.X + width || e.Y < position.Y || e.Y > position.Y + height)
                        {
                            StatusLabelMousePosition.Visible = false;
                            StatusLabelRGB.Visible = false;
                            StatusLabelHSL.Visible = false;
                            Cursor = Cursors.Default;
                            return;
                        }
                    }
                    else
                    {
                        if (posX < 0 || posY < 0 || posX >= zoomBitmap.Width || posY >= zoomBitmap.Height ||
                            e.X < position.X || e.X > position.X + zoomBitmap.Width || e.Y < position.Y || e.Y > position.Y + zoomBitmap.Height)
                        {
                            StatusLabelMousePosition.Visible = false;
                            StatusLabelRGB.Visible = false;
                            StatusLabelHSL.Visible = false;
                            Cursor = Cursors.Default;
                            return;
                        }
                    }
                }

                //if (PencilTool)
                //{
                //    pen.StartCap = LineCap.Round;
                //    pen.EndCap = LineCap.Round;
                //    arrayPoints.SetPoint(e.X, e.Y);
                //    graphics = Graphics.FromImage(bitmap);
                //    if (arrayPoints.GetCountPoints() >= 2)
                //    {
                //        graphics.DrawLines(pen,arrayPoints.GetPoints());
                //        arrayPoints.SetPoint(e.X,e.Y);
                //    }
                //    imageDisplay.Invalidate();
                //}

                Color color = zoomBitmap.GetPixel(posX, posY);
                RGB rgbColor = new RGB(color);
                HSL hslColor = HSL.FromRGB(rgbColor);

                StatusLabelMousePosition.Visible = true;
                StatusLabelMousePosition.Text = "X: " + posX + " Y: " + posY;

                StatusLabelRGB.Visible = true;
                StatusLabelRGB.Text = "R: " + rgbColor.Red + " G: " + rgbColor.Green + " B: " + rgbColor.Blue;

                StatusLabelHSL.Visible = true;
                StatusLabelHSL.Text = "H: " + hslColor.Hue + " S: " + hslColor.Saturation.ToString("0.000", CultureInfo.InvariantCulture) + " L: " + hslColor.Luminance.ToString("0.000", CultureInfo.InvariantCulture);

                if (!cropping) return;
                Cursor = Cursors.Cross;
                if (!dragging) return;
                displayEndPoint = e.Location;
                cropEndPoint = bitmapPoint;

                selection.Width = displayEndPoint.X - selection.X;
                selection.Height = displayEndPoint.Y - selection.Y;

                imageDisplay.Invalidate();
            }
        }

       

        private void imageDisplay_MouseUp(object sender, MouseEventArgs e)
        {
            //PencilTool = false;
            //arrayPoints.ResetPoints();
            if (e.Button != MouseButtons.Left) return;
            if (!dragging) return;
            displayEndPoint = e.Location;
            
            if (displayEndPoint.X > displayStartPoint.X && displayEndPoint.Y > displayStartPoint.Y)
            {
                cropped = true;
                if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                    toGrayscale = true;
                        
                ApplyFilter(new Crop(new Rectangle(cropStartPoint.X, cropStartPoint.Y, cropEndPoint.X - cropStartPoint.X + 1, cropEndPoint.Y - cropStartPoint.Y + 1)));
            }

            cropping = dragging = false;
            Cursor = Cursors.Default;
            MenuItemCrop.Checked = toolStripButtonCrop.Checked = false;
            
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            if (undoBitmap == null) return;
            bitmap = (Bitmap)undoBitmap.Clone();
            undoBitmap.Dispose();
            MenuItemUndo.Enabled = false;
            toolStripButtonUndo.Enabled = false;
            imageDisplay.Invalidate();
        }

        private void ImageProperties_Click(object sender, EventArgs e)
        {
            string filename = Path.GetFileName(GetFilePath());
            string directory = Directory.GetCurrentDirectory();

            ImageFormat imageFormat = FormatFromExtension(GetFilePath());
            string compression;
            switch (imageFormat.ToString())
            {
                case "Jpeg":
                    compression = "JPEG";
                    break;
                case "Bmp":
                case "Tiff":
                    compression = "None";
                    break;
                case "Gif":
                    compression = "GIF - LZW";
                    break;
                case "Png":
                    compression = "PNG - ZIP";
                    break;
                default:
                    compression = "Unknown";
                    break;
            }

            string resolution = bitmap.HorizontalResolution + " x " + bitmap.VerticalResolution + " DPI";
            string originalSize = deletedBitmap.Width + " x " + deletedBitmap.Height + " pixels";
            string currentSize = bitmap.Width + " x " + bitmap.Height + " pixels";

            PixelFormat pixelFormatOriginal = deletedBitmap.PixelFormat;
            PixelFormat pixelFormatCurrent = bitmap.PixelFormat;
            string originalColors = ColorsFromPixelFormat(pixelFormatOriginal.ToString());
            string currentColors = ColorsFromPixelFormat(pixelFormatCurrent.ToString());

            imageFileInfo = new FileInfo(imageFiles[currentFileIndex].ToString());
            long byteSize = imageFileInfo.Length;
            float kiloByteSize = (float)byteSize / 1024F;
            float megaByteSize = kiloByteSize / 1024F;
            string diskSize = (kiloByteSize >= 1024F ? megaByteSize.ToString("#.00", CultureInfo.InvariantCulture) + " MB" : kiloByteSize.ToString("#.00", CultureInfo.InvariantCulture) + " KB") + " (" + byteSize.ToString() + " bytes)";

            string pixelFormat = pixelFormatCurrent.ToString();
            string bpp = ReturnBitDepth(pixelFormat);
            float currentBitSize = bitmap.Width * (float)bitmap.Height * Int32.Parse(bpp.Remove(bpp.IndexOf(" ", StringComparison.Ordinal)));
            float currentByteSize = currentBitSize / 8F;
            float currentKiloByteSize = currentByteSize / 1024F;
            float currentMegaByteSize = currentKiloByteSize / 1024F;
            string currentMemorySize = (currentKiloByteSize >= 1024F ? currentMegaByteSize.ToString("#.00", CultureInfo.InvariantCulture) + " MB" : currentKiloByteSize.ToString("#.00", CultureInfo.InvariantCulture) + " KB") + " (" + currentByteSize.ToString() + " bytes)";

            string currentDirectoryIndex = (currentFileIndex + 1).ToString() + " / " + imageFiles.Count.ToString();
            string fileDateTime = imageFileInfo.CreationTimeUtc.ToString(CultureInfo.InvariantCulture);

            string[] properties = new string[12];
            properties[0] = filename;
            properties[1] = directory;
            properties[2] = compression;
            properties[3] = resolution;
            properties[4] = originalSize;
            properties[5] = currentSize;
            properties[6] = originalColors;
            properties[7] = currentColors;
            properties[8] = diskSize;
            properties[9] = currentMemorySize;
            properties[10] = currentDirectoryIndex;
            properties[11] = fileDateTime;

            ImageProperties form = new ImageProperties(properties);
            form.ShowDialog();
        }

        private void toolStripButtonFullScreen_Click(object sender, EventArgs e)
        {
            croppingState = cropping;
            centerImagesState = MenuItemCenterImages.Checked;
            fitImagesState = fitImagesToWindow;
            toolBarShowState = MenuItemShowToolbar.Checked;
            statusBarShowState = MenuItemShowStatusBar.Checked;
            formTop = Top;
            formLeft = Left;
            formWidth = Width;
            formHeight = Height;
            formState = WindowState;
            fullScreen = true;
            cropping = false;
            Cursor = Cursors.Default;
            MenuItemCenterImages.Checked = true;
            fitImagesToWindow = true;
            BackColor = Color.Black;
            imageDisplay.BackColor = Color.Black;
            toolStrip1.Visible = false;
            toolStrip2.Visible = false;
            statusBar.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            //panel3.Visible = false;
            FormBorderStyle = FormBorderStyle.None;
            Top = 0;
            Left = 0;
            
            //MainWindow.WindowState = FormWindowState.Maximized;
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void toolStripButtonCrop_Click(object sender, EventArgs e)
        {
            if (cropping)
            {
                cropping = false;
                MenuItemCrop.Checked = toolStripButtonCrop.Checked = false;
                Cursor = Cursors.Default;
            }
            else
            {
                cropping = true;
                MenuItemCrop.Checked = toolStripButtonCrop.Checked = true;
            }
        }

        private void toolStripButtonPreviousImage_Click(object sender, EventArgs e)
        {
            bitmap.Dispose();
            deletedBitmap.Dispose();
            currentFileIndex--;
            if (currentFileIndex < 0)
                currentFileIndex = imageFiles.Count - 1;
            ShowPicture();
        }

        private void toolStripButtonNextImage_Click(object sender, EventArgs e)
        {
            bitmap.Dispose(); deletedBitmap.Dispose();
            currentFileIndex++;
            if (currentFileIndex >= imageFiles.Count)
                currentFileIndex = 0;
            ShowPicture();
        }

        private void toolStripButtonZoomIn_Click(object sender, EventArgs e)
        {
            zoomFactor += 0.10F;
            imageDisplay.Invalidate();
            WindowState = (FormWindowState)FormBorderStyle.None;
        }

        private void toolStripButtonZoomOut_Click(object sender, EventArgs e)
        {
            zoomFactor -= 0.10F;
            imageDisplay.Invalidate();
            WindowState = (FormWindowState)FormBorderStyle.None;
        }

        private void toolStripButtonRotateLeft_Click(object sender, EventArgs e)
        {
            SetUndo();
            bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
            MenuItemUndo.Enabled = true;
            toolStripButtonUndo.Enabled = true;
            imageDisplay.Invalidate();
        }

        private void toolStripButtonRotateRight_Click(object sender, EventArgs e)
        {
            SetUndo();
            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            MenuItemUndo.Enabled = true;
            toolStripButtonUndo.Enabled = true;
            imageDisplay.Invalidate();
        }

        private void FlipVertical_Click(object sender, EventArgs e)
        {
            SetUndo();
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            MenuItemUndo.Enabled = true;
            toolStripButtonUndo.Enabled = true;
            imageDisplay.Invalidate();
        }

        private void FlipHorizontal_Click(object sender, EventArgs e)
        {
            SetUndo();
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
            MenuItemUndo.Enabled = true;
            toolStripButtonUndo.Enabled = true;
            imageDisplay.Invalidate();
        }

        private void toolStripButtonActualSize_Click(object sender, EventArgs e)
        {
            zoomFactor = 1.00F;
            imageDisplay.Invalidate();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string filePath = GetFilePath(); try
            {
                SaveImage(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (fitImagesToWindow)
            {
                MenuItemFitImages.Checked = toolStripButtonFitImages.Checked = false;
                fitImagesToWindow = false;
            }
            else
            {
                MenuItemFitImages.Checked = toolStripButtonFitImages.Checked = true;
                fitImagesToWindow = true;
            }
            imageDisplay.Invalidate();
        }

        

        private void toolStripButtonCustomRotation_Click(object sender, EventArgs e)
        {
            CustomRotationForm form = new CustomRotationForm();

            if (form.ShowDialog() != DialogResult.OK) return;
            if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                toGrayscale = true;
            ApplyFilter(form.Filter);
        }

        private void printImage_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                Rectangle rcImage = new Rectangle(0, 0, 0, 0);

                if (bitmap.Width <= e.MarginBounds.Width && bitmap.Height <= e.MarginBounds.Height)
                {
                    rcImage.X = (int)(e.MarginBounds.Width / 2 - bitmap.Width / 2 + e.MarginBounds.X);
                    rcImage.Y = (int)(e.MarginBounds.Height / 2 - bitmap.Height / 2 + e.MarginBounds.Y);

                    rcImage.Width = bitmap.Width;
                    rcImage.Height = bitmap.Height;
                }
                else
                {
                    int maxWidth = e.MarginBounds.Width, maxHeight = e.MarginBounds.Height; int width = bitmap.Width, height = bitmap.Height;
                    float ratio = (float)width / height;

                    width = maxWidth;
                    height = (int)Math.Floor(maxWidth / ratio);

                    if (height > maxHeight)
                    {
                        height = maxHeight;
                        width = (int)Math.Floor(maxHeight * ratio);
                    }

                    if (height < e.MarginBounds.Height)
                    {
                        rcImage.X = e.MarginBounds.X;
                        rcImage.Y = e.MarginBounds.Height / 2 - height / 2 + e.MarginBounds.Y;
                    }
                    else
                    {
                        rcImage.X = e.MarginBounds.Width / 2 - width / 2 + e.MarginBounds.X;
                        rcImage.Y = e.MarginBounds.Y;
                    }

                    rcImage.Width = width;
                    rcImage.Height = height;
                }

                g.DrawImage(bitmap, rcImage, 0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel);

                e.HasMorePages = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonBrightness_Click(object sender, EventArgs e)
        {

            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                MessageBox.Show(@"Brightness adjustment using HSL color space is available for 24 bpp RGB images only!", @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            BrightnessForm form = new BrightnessForm();
            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                ApplyFilter(form.Filter);
            }
        }

        private void toolStripButtonReset_Click(object sender, EventArgs e)
        {
            if (bitmap == null && resetBitmap == null) return;
            bitmap = (Bitmap)resetBitmap.Clone();
            resetBitmap.Dispose();
            MenuItemUndo.Enabled = false;
            toolStripButtonUndo.Enabled = false;
            imageDisplay.Invalidate();
            toolStripButtonReset.Enabled = false;
        }

        private void toolStripButtonContrast_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                MessageBox.Show(@"Contrast adjustment using HSL color space is available for 24 bpp RGB images only!", @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ContrastForm form = new ContrastForm();
            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                ApplyFilter(form.Filter);
            }
        }

        

        private void toolStripButtonColorFiltering_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                MessageBox.Show("Color filtering can be applied to 24 bpp RGB images only!", "Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ColorFilteringForm form = new ColorFilteringForm();
            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                ApplyFilter(form.Filter);
            }
        }

        private void toolStripButtonSaturation_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                MessageBox.Show("Saturation adjustment using HSL color space is available for 24 bpp RGB images only!", "Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SaturationForm form = new SaturationForm();
            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                ApplyFilter(form.Filter);
            }
        }

        private void toolStripButtonSend_Click(object sender, EventArgs e)
        {
            //Cursor.Current = Cursors.WaitCursor;
            //try
            //{
            //    SmtpClient client = new SmtpClient("details here");
            //    MailMessage message = new MailMessage();
            //    message.From = new MailAddress("email here");
            //    string mailBox = txtBugAdd.Text.Trim();
            //    message.To.Add(mailBox);
            //    string mailFrom = txtEmailFromBug.Text.Trim();
            //    message.CC.Add(mailFrom);
            //    string mailCC = txtMailCCBug.Text.Trim();
            //    message.Bcc.Add(mailCC);
            //    message.IsBodyHtml = true;
            //    message.Body = "Bug Report - please see below: " +
            //        "\n" + "<br>" + "<b>" + "1. What were you doing at the time of the error?" + "</b>" +
            //            "\n" + "<br>" + rtbTimeOfError.Text +
            //            "\n" + "<br>" + "<b>" + "2. Are you able to repeat the steps and achieve the same error?" + "</b>" +
            //            "\n" + "<br>" + rtbCanRepeat.Text +
            //            "\n" + "<br>" + "<b>" + "3. Does this problem happen again if you change any of the details you have entered?" + "</b>" +
            //            "\n" + "<br>" + rtbChangeDetails.Text;
            //    message.Subject = "Bug Report";
            //    var image = bitmap;
            //    using (var ms = new MemoryStream())
            //    {
            //        image.Save(ms, ImageFormat.Jpeg);
            //        message.Attachments.Add(new Attachment(ms, "Screenshot.jpg"));
            //        client.Credentials = new System.Net.NetworkCredential("credentials here");
            //        client.Port = System.Convert.ToInt32(25);
            //        client.Send(message);
            //    }
            //    new Endpage().Show();
            //    this.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("my comment here");
            //}
            bitmap.Save("img.bmp");

            using (var msg = new MailMessage())
            {
                msg.From = new MailAddress("14voytsenko@gmail.com");
                msg.To.Add("voytsenko.vladyslav@chnu.edu.ua");
                msg.Subject = "Test";
                msg.Body = "Test";
                msg.Attachments.Add(new Attachment(@"img.bmp"));
                using (var smtp = new SmtpClient())
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;
                    smtp.Timeout = 20000;
                    smtp.Credentials = new NetworkCredential("14voytsenko@gmail.com", "Vlad1516082001");
                    try
                    {
                        smtp.Send(msg);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
        }

        private void toolStripButtonHUE_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                MessageBox.Show("Hue modifier is available for 24 bpp RGB images only!", "Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            HueModifierForm form = new HueModifierForm();
            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                ApplyFilter(form.Filter);
            }
        }

        private void toolStripButtonSmooth_Click(object sender, EventArgs e)
        {
            AdaptiveSmoothForm form = new AdaptiveSmoothForm();

            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                    toGrayscale = true;
                ApplyFilter(form.Filter);
            }
        }

        private void toolStripButtonResize_Click(object sender, EventArgs e)
        {
            Size bitmapSize = bitmap.Size;
            ResizeForm form = new ResizeForm(bitmapSize);

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                    toGrayscale = true;
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemReopen_Click(object sender, EventArgs e)
        {
            ShowPicture();
            isDeleted = false;
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemCut_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Clipboard.SetDataObject(bitmap, true);
                deleteImage = true;
                this.imageDisplay.Invalidate();
            }
            else
                MessageBox.Show(this, "There is no image to cut!", "Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MenuItemCopy_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Clipboard.SetDataObject(bitmap, true);
            }
            else
                MessageBox.Show(this, "There is no image to copy!", "Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MenuItemPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Bitmap))
            {
                if (bitmap != null)
                {
                    MenuItemPreviousImage.Enabled = MenuItemNextImage.Enabled = MenuItemFirstImage.Enabled = MenuItemLastImage.Enabled = 
                        MenuItemRandomImage.Enabled = toolStripButtonPreviousImage.Enabled = toolStripButtonNextImage.Enabled = false;
                }

                Bitmap newBitmap = (Bitmap)Clipboard.GetDataObject().GetData(DataFormats.Bitmap);
                bitmap = newBitmap.Clone(new Rectangle(0, 0, newBitmap.Width, newBitmap.Height), PixelFormat.Format24bppRgb);
                newBitmap.Dispose();

                string drive = Environment.GetEnvironmentVariable("SystemDrive");
                Directory.CreateDirectory(drive + "\\Temp");
                string filePath = drive + "\\Temp\\Clipboard.bmp";
                SaveImage(filePath);
                imageFile = filePath;
                Directory.SetCurrentDirectory(Directory.GetParent(imageFile).FullName.ToString());
                ProcessDirectory();
                zoomFactor = 1.00F;
                isDeleted = false;
                ShowPicture();
            }
            else
                MessageBox.Show(this, "There is no image to paste!", "Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MenuItemShowToolbar_Click(object sender, EventArgs e)
        {
            if (MenuItemShowToolbar.Checked)
            {
                toolStrip1.Visible = true;
                toolStrip2.Visible = true;
                panel1.Height = 65;
                panel2.Visible = true;
            }
            else
            {
                toolStrip1.Visible = false;
                toolStrip2.Visible = false;
                panel1.Height = 25;
                panel2.Visible = false;
            }
        }

        private void MenuItemShowStatusBar_Click(object sender, EventArgs e)
        {
            if (MenuItemShowStatusBar.Checked)
                statusBar.Visible = true;
            else
                statusBar.Visible = false;
        }

        private void MenuItemFirstImage_Click(object sender, EventArgs e)
        {
            bitmap.Dispose();
            deletedBitmap.Dispose();
            currentFileIndex = 0;
            ShowPicture();
        }

        private void MenuItemLastImage_Click(object sender, EventArgs e)
        {
            bitmap.Dispose();
            deletedBitmap.Dispose();
            currentFileIndex = imageFiles.Count - 1;
            ShowPicture();
        }

        private void MenuItemRandomImage_Click(object sender, EventArgs e)
        {
            bitmap.Dispose();
            deletedBitmap.Dispose();
            Random random = new Random();
            currentFileIndex = random.Next(imageFiles.Count); ShowPicture();
        }

        private void MenuItem10_Click(object sender, EventArgs e)
        {
            zoomFactor = 0.10F;
            this.imageDisplay.Invalidate();
        }

        private void MenuItem25_Click(object sender, EventArgs e)
        {
            zoomFactor = 0.25F;
            this.imageDisplay.Invalidate();
        }

        private void MenuItem50_Click(object sender, EventArgs e)
        {
            zoomFactor = 0.50F;
            this.imageDisplay.Invalidate();
        }

        private void MenuItem75_Click(object sender, EventArgs e)
        {
            zoomFactor = 0.75F;
            this.imageDisplay.Invalidate();
        }

        private void MenuItemActualSize_Click(object sender, EventArgs e)
        {
            zoomFactor = 1.00F;
            this.imageDisplay.Invalidate();
        }

        private void MenuItem150_Click(object sender, EventArgs e)
        {
            zoomFactor = 1.50F;
            this.imageDisplay.Invalidate();
        }

        private void MenuItem200_Click(object sender, EventArgs e)
        {
            zoomFactor = 2.00F;
            this.imageDisplay.Invalidate();
        }

        private void MenuItem400_Click(object sender, EventArgs e)
        {
            zoomFactor = 4.00F;
            this.imageDisplay.Invalidate();
        }

        private void MenuItem500_Click(object sender, EventArgs e)
        {
            zoomFactor = 5.00F;
            this.imageDisplay.Invalidate();
        }

        private void MenuItemCenterImages_Click(object sender, EventArgs e)
        {
            this.imageDisplay.Invalidate();
        }

        [Obsolete]
        private void MenuItemGrayscale_Click(object sender, EventArgs e)
        {
            ImageFormat format = FormatFromExtension(GetFilePath());

            if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed || bitmap.PixelFormat == PixelFormat.Format16bppGrayScale)
            {
                if (format == ImageFormat.Gif)
                {
                    MessageBox.Show("Source pixel format is not supported by the filter.", "Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("The image is already grayscale!", "Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            toGrayscale = true;
            ApplyFilter(new GrayscaleBT709());
        }

        private void MenuItemSepia_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Sepia());
        }

        private void MenuItemInvertColors_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Invert());
        }

        private void toolStripButtonPen_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuItemBlur_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Blur());
        }

        private void MenuItemSharpen_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Sharpen());
        }

        private void MenuItemRed_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new ChannelFiltering(new AForge.IntRange(0, 255), new IntRange(0, 0), new IntRange(0, 0)));
        }

        private void MenuItemGreen_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new ChannelFiltering(new IntRange(0, 0), new IntRange(0, 255), new IntRange(0, 0)));
        }

        private void MenuItemBlue_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new ChannelFiltering(new IntRange(0, 0), new IntRange(0, 0), new IntRange(0, 255)));
        }

        private void MenuItemCyan_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new ChannelFiltering(new IntRange(0, 0), new IntRange(0, 255), new IntRange(0, 255)));
        }

        private void MenuItemMagenta_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new ChannelFiltering(new IntRange(0, 255), new IntRange(0, 0), new IntRange(0, 255)));
        }

        private void MenuItemYellow_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new ChannelFiltering(new IntRange(0, 255), new IntRange(0, 255), new IntRange(0, 0)));
        }

        private void MenuItemRotateRGBChannels_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new RotateChannels());
        }

        private void MenuItemChannelsFiltering_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                MessageBox.Show("Euclidean color filtering can be applied to 24 bpp RGB images only!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            EuclideanColorFilteringForm form = new EuclideanColorFilteringForm();
            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                ApplyFilter(form.Filter);
            }
        }
    }
}
