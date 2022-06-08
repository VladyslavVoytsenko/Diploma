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
using System.Threading;
using System.Windows.Forms;
using Diploma.View_Forms;
using Point = System.Drawing.Point;

namespace Diploma.Pages
{
    public partial class Home : Form
    {
        [Obsolete("Obsolete")]
        public void SuperUpdate()
        {
           if (bitmap == null) return;
            Controls.Clear();
            InitializeComponent();
            deleteImage = true;
            imageDisplay.Invalidate();
            
        }
        

        [Obsolete("Obsolete")]
        public Home()
        {
            InitializeComponent();
            var levelControl = printPreviewDialog.TopLevelControl;
            if (levelControl != null)
                levelControl.Text = @"Print Preview";
            imageDisplay.Select();
        }

        #region Fields

        private string imageFile;                                       // name of the file we want to display
        
        private ArrayList imageFiles;                                   // list which contains all image files in the current folder
        
        private int currentFileIndex = -1;                              // index of the currently used file, if the value is -1 there is no open file    
        
        private FileInfo imageFileInfo;                                 // image file information
        
        private Bitmap bitmap;                                          // bitmap object of the image file we want to display
        private Bitmap deletedBitmap;                                   // image cleared from the screen (can be reopened)
        private Bitmap undoBitmap;                                      // bitmap for storing the state of the image before the last change
        private Bitmap zoomBitmap;                                      // bitmap for zooming

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
        #endregion


        




        #region Methods

        private void ResetForm()
        {
            //Text = "ImageEditor";
            MenuItemReopen.Enabled = true;
            MenuItemUndo.Enabled = false;
            toolStripButtonUndo.Enabled = false;
            SetMenuItems(false);
        }
        private void CheckZoom()
        {
            zoom = zoomFactor;
            if (!(zoom < 0.09F) && !(zoom > 5.01F)) return;
            if (Equals(Thread.CurrentThread.CurrentUICulture, new CultureInfo("uk")))
            {
                MessageBox.Show(@"Масштаб зображення має бути від 10 до 500% !", @"Застереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                MessageBox.Show(@"Image zoom must be between 10 and 500% !", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
              
            if (zoom < 0.09F)
                zoomFactor += 0.10F;
            else
                zoomFactor -= 0.10F;
            zoom = zoomFactor;
        }

        private void ApplyFilterInPlace(IInPlaceFilter filter)
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
                    MessageBox.Show(ex.Message, @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            imageDisplay.Invalidate();
        }

        private static ImageFormat FormatFromExtension(string ext)
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
                ep.Param[0] = new EncoderParameter(Encoder.Quality, (long)85);
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
            var b = new byte[st.Length];
            var read = st.Read(b, 0, b.Length);
            var ms = new MemoryStream(b);
            deletedBitmap = (Bitmap)System.Drawing.Image.FromStream(ms, true);
        }


        private static string ReturnBitDepth(string pixFormat)
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

        private static string ColorsFromPixelFormat(string pixelFormat)
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
            var toolStripButtons = new[] { toolStripButtonSaveAs, toolStripButton1, toolStripButtonPrintImage ,
            toolStripButtonDelete,toolStripButtonUndo, ImageProperties, toolStripButtonZoomIn, toolStripButtonZoomOut, toolStripButtonFullScreen,
            toolStripButtonCrop, toolStripButtonRotateLeft, toolStripButtonRotateRight, FlipVertical, FlipHorizontal, toolStripButtonActualSize,
            toolStripButtonFitImages, toolStripButtonBrightness, toolStripButtonContrast, toolStripButtonColorFiltering, toolStripButtonPerlinNoise,
            toolStripButtonSaturation, toolStripButtonHUE, toolStripButtonSmooth, toolStripButtonResize, toolStripButtonCustomRotation, toolStripButtonPixellate, toolStripButtonOilPainting, toolStripButtonGaussianBlur, toolStripButtonHSLFiltering};

           // ToolStripButton[] toolStripButtonsNextPrev = new ToolStripButton[] { toolStripButtonPreviousImage, toolStripButtonNextImage };
            foreach (var button in toolStripButtons)
            {
                button.Enabled = enabledState;
            }

            MenuItemSave.Enabled = MenuItemSaveAs.Enabled = MenuItemPrint.Enabled =
                 MenuItemZoom.Enabled = MenuItemImageProperties.Enabled = MenuItemFullScreen.Enabled =
                MenuItemDelete.Enabled  = MenuItemCut.Enabled = MenuItemCopy.Enabled = enabledState;

            MenuItemImage.Visible = MenuItemAdjustments.Visible = MenuItemEffects.Visible = enabledState;

            toolStripButtonSaveAs.Enabled = toolStripButtonDelete.Enabled = toolStripButtonPrintImage.Enabled = toolStripButtonCrop.Enabled =
                 toolStripButtonActualSize.Enabled = toolStripButtonFitImages.Enabled = toolStripButtonRotateLeft.Enabled = toolStripButtonRotateRight.Enabled =
                 toolStripButtonFullScreen.Enabled = enabledState;

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
            MenuItemCenterImages.Checked = centerImagesState;
            fitImagesToWindow = fitImagesState;
            BackColor = SystemColors.ControlDark;
            imageDisplay.BackColor = SystemColors.ControlDark;
            mainMenu.Visible = true;
            MenuItemShowToolbar.Checked = toolBarShowState;
            if (statusBarShowState)
            {
                MenuItemShowStatusBar.Checked = true;
                statusBar.Visible = true;
            }
            else
            {
                MenuItemShowStatusBar.Checked = false;
                statusBar.Visible = false;
            }
            //FormBorderStyle = FormBorderStyle.Sizable;
            toolStrip1.Visible = true;
            toolStrip2.Visible = true;
            statusBar.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            //panel3.Visible = true;
            WindowState = (FormWindowState) FormBorderStyle.None;
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
                h = bmp.Height;
            int bytesPerPixel;
            PixelFormat pfIn = bmp.PixelFormat;

            var output = new Bitmap(w, h, PixelFormat.Format8bppIndexed);

            var palette = output.Palette;
            for (var i = 0; i < 256; i++)
            {
                Color.FromArgb(255, i, i, i);
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
                case PixelFormat.Indexed:
                case PixelFormat.Gdi:
                case PixelFormat.Alpha:
                case PixelFormat.PAlpha:
                case PixelFormat.Extended:
                case PixelFormat.Canonical:
                case PixelFormat.Undefined:
                case PixelFormat.Format1bppIndexed:
                case PixelFormat.Format4bppIndexed:
                case PixelFormat.Format8bppIndexed:
                case PixelFormat.Format16bppGrayScale:
                case PixelFormat.Format16bppRgb555:
                case PixelFormat.Format16bppRgb565:
                case PixelFormat.Format16bppArgb1555:
                case PixelFormat.Format32bppPArgb:
                case PixelFormat.Format48bppRgb:
                case PixelFormat.Format64bppArgb:
                case PixelFormat.Format64bppPArgb:
                case PixelFormat.Max:
                default: throw new InvalidOperationException("Image format not supported");
            }

            var bmpData = bmp.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.ReadOnly, pfIn);
            var outputData = output.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
            var bmpStride = bmpData.Stride;
            var outputStride = outputData.Stride;

            unsafe
            {
                byte* bmpPtr = (byte*)bmpData.Scan0.ToPointer(),
                outputPtr = (byte*)outputData.Scan0.ToPointer();

                int r;
                int ic;
                int oc;
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

        private void ShowStatusBarInfo()
        {
            string pixFormat = bitmap.PixelFormat.ToString();
            string bitDepth = ReturnBitDepth(pixFormat);
        
            NumberFormatInfo numberFormat = NumberFormatInfo.InvariantInfo;
            float zoomPercent = zoom * 100;

            imageFileInfo = new FileInfo(imageFiles[currentFileIndex].ToString());
            long byteSize = imageFileInfo.Length;
            float kiloByteSize = byteSize / 1024F;
            float megaByteSize = kiloByteSize / 1024F;
        }

        private void ApplyFilter(IFilter filter)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                SetUndo();

                var newBitmap = filter.Apply(bitmap);
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
                    var g = Graphics.FromImage(bitmap);
                    g.DrawImage(newBitmap, new Point(0, 0));
                    g.Dispose();
                }
                newBitmap.Dispose();
                MenuItemUndo.Enabled = true;
                toolStripButtonUndo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ArrayList fileTypes = new ArrayList
            {
                "*.JPG",
                "*.JPEG",
                "*.BMP",
                "*.GIF",
                "*.PNG",
                "*.TIF"
            };

            imageFiles = new ArrayList();
            foreach (string type in fileTypes)
            {
                var files = Directory.GetFiles(Directory.GetCurrentDirectory(), type);
                if (files.Length > 0) imageFiles.AddRange(files);
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
                    var read = st.Read(b, 0, b.Length);
                    MemoryStream ms = new MemoryStream(b);
                    bitmap = (Bitmap)System.Drawing.Image.FromStream(ms, true);
                    zoomBitmap = new Bitmap(bitmap, new Size(bitmap.Width, bitmap.Height));
                    deletedBitmap = (Bitmap)bitmap.Clone();
                }

                printImage.DocumentName = Path.GetFileName(GetFilePath()); 
                printImage.DefaultPageSettings.Landscape = bitmap.Width > bitmap.Height;
                //printPreviewDialog.PrintPreviewControl.Document.DefaultPageSettings = printImage.DefaultPageSettings;

                SetMenuItems(true);
                zoomFactor = 1.00F;
                imageDisplay.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = @"Open Image File";
            openFileDialog.Filter = Filter;
            openFileDialog.Multiselect = false;
            try
            {
                if (openFileDialog.ShowDialog() != DialogResult.OK) return;
                imageFile = openFileDialog.FileName;
                Directory.SetCurrentDirectory(Directory.GetParent(imageFile)?.FullName ?? string.Empty);
                ProcessDirectory();
                zoomFactor = 1.00F;
                isDeleted = false;
                if (currentFileIndex != -1)
                    ShowPicture();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void toolStripButtonSaveAs_Click(object sender, EventArgs e)
        {
            var filePath =GetFilePath();
            var fileName = Path.GetFileName(filePath);

            saveFileDialog.Title = @"Save Image As";
            saveFileDialog.Filter = Filter;
            saveFileDialog.FileName = fileName;
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.AddExtension = true;
            try
            {
                if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
                fileName = saveFileDialog.FileName;
                filePath = Path.GetFullPath(fileName);

                SaveImage(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                
                var g = e.Graphics; 
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                if (cropped)
                {
                    zoomFactor = 1.0F;
                    cropped = false;
                }

                if (bitmap.Width * zoomFactor <= imageDisplay.Width && bitmap.Height * zoomFactor <= imageDisplay.Height)
                {
                    CheckZoom(); 
                    imageDisplay.AutoScroll = false;
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
                        var fileIndex = " [" + (currentFileIndex + 1) + "/" + imageFiles.Count + "]";
                        g.DrawString(GetFilePath() + fileIndex, new Font("Segoe UI", 12, GraphicsUnit.Point), Brushes.Chocolate, new Point(2, 2));
                    }

                    zoomBitmap = new Bitmap(bitmap, new Size((int)(bitmap.Width * zoomFactor), (int)(bitmap.Height * zoomFactor)));

                    Text = Path.GetFileName(GetFilePath()) + @" - Image editor";
                }
                else
                {
                    if (fitImagesToWindow)
                    {
                        imageDisplay.AutoScroll = false;

                        int maxWidth = imageDisplay.Width, maxHeight = imageDisplay.Height; int width = bitmap.Width, height = bitmap.Height;
                        float ratio = width / (float)height;
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
                                if (imageDisplay != null)
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
                            var fileIndex = " [" + (currentFileIndex + 1) + "/" + imageFiles.Count + "]";
                            g.DrawString(GetFilePath() + fileIndex, new Font("Segoe UI", 12, GraphicsUnit.Point), Brushes.Indigo, new Point(2, 2));
                        }

                        zoomBitmap = new Bitmap(bitmap, new Size(width, height));

                        zoom = Math.Min((float)width / bitmap.Width, (float)height / bitmap.Height);
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

                        this.Text = Path.GetFileName(GetFilePath()) + @" - Image Editor";
                    }
                }
                if (dragging)
                {
                    var pen = Pens.Brown;
                    g.DrawRectangle(pen, selection);
                }
                else
                {
                    ShowStatusBarInfo();

                    MenuItemReopen.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, @"Image editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            deleteImage = true;
            imageDisplay.Invalidate();
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
                if (cropping && Cursor == Cursors.Cross)
                {
                    dragging = true;

                    displayStartPoint = e.Location;
                    cropStartPoint = bitmapPoint;

                    selection = new Rectangle(new Point(displayStartPoint.X, displayStartPoint.Y), new Size());
                    imageDisplay.Invalidate();
                }
            }
            FormBorderStyle = FormBorderStyle.None;
        }

        private void imageDisplay_MouseLeave(object sender, EventArgs e)
        {
            StatusLabelMousePosition.Visible = false;
            StatusLabelRGB.Visible = false;
            StatusLabelHSL.Visible = false;
            Cursor = Cursors.Default;
        }

        
       


        private void imageDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            if (bitmap == null) return;
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
                    Cursor = Cursors.Default;
                    return;
                }
            }
            else
            {
                if (fitImagesToWindow)
                {
                    int maxWidth = imageDisplay.Width, maxHeight = imageDisplay.Height;
                    int width = bitmap.Width, height = bitmap.Height;

                    var ratio = width / (float)height;

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

            Color color = zoomBitmap.GetPixel(posX, posY);
            RGB rgbColor = new RGB(color);
            HSL hslColor = HSL.FromRGB(rgbColor);

            StatusLabelMousePosition.Visible = true;
            StatusLabelMousePosition.Text = @"X: " + posX + @" Y: " + posY;

            StatusLabelRGB.Visible = true;
            StatusLabelRGB.Text = @"R: " + rgbColor.Red + @" G: " + rgbColor.Green + @" B: " + rgbColor.Blue;

            StatusLabelHSL.Visible = true;
            StatusLabelHSL.Text = @"H: " + hslColor.Hue + @" S: " + hslColor.Saturation.ToString("0.000", CultureInfo.InvariantCulture) + @" L: " + hslColor.Luminance.ToString("0.000", CultureInfo.InvariantCulture);

            if (!cropping) return;
            Cursor = Cursors.Cross;
            if (!dragging) return;
            displayEndPoint = e.Location;
            cropEndPoint = bitmapPoint;

            selection.Width = displayEndPoint.X - selection.X;
            selection.Height = displayEndPoint.Y - selection.Y;

            imageDisplay.Invalidate();
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
            float kiloByteSize = byteSize / 1024F;
            float megaByteSize = kiloByteSize / 1024F;
            string diskSize = (kiloByteSize >= 1024F ? megaByteSize.ToString("#.00", CultureInfo.InvariantCulture) + " MB" : kiloByteSize.ToString("#.00", CultureInfo.InvariantCulture) + " KB") + " (" + byteSize + " bytes)";

            string pixelFormat = pixelFormatCurrent.ToString();
            string bpp = ReturnBitDepth(pixelFormat);
            float currentBitSize = bitmap.Width * (float)bitmap.Height * Int32.Parse(bpp.Remove(bpp.IndexOf(" ", StringComparison.Ordinal)));
            float currentByteSize = currentBitSize / 8F;
            float currentKiloByteSize = currentByteSize / 1024F;
            float currentMegaByteSize = currentKiloByteSize / 1024F;
            string currentMemorySize = (currentKiloByteSize >= 1024F ? currentMegaByteSize.ToString("#.00", CultureInfo.InvariantCulture) + " MB" : currentKiloByteSize.ToString("#.00", CultureInfo.InvariantCulture) + " KB") + " (" + currentByteSize + " bytes)";

            string currentDirectoryIndex = (currentFileIndex + 1) + " / " + imageFiles.Count;
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
                MessageBox.Show(ex.Message, @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    rcImage.X = e.MarginBounds.Width / 2 - bitmap.Width / 2 + e.MarginBounds.X;
                    rcImage.Y = e.MarginBounds.Height / 2 - bitmap.Height / 2 + e.MarginBounds.Y;

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
                MessageBox.Show(ex.Message, @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonBrightness_Click(object sender, EventArgs e)
        {

            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                if (Equals(Thread.CurrentThread.CurrentUICulture, new CultureInfo("uk")))
                {
                    MessageBox.Show(@"Регулювання яскравості з використанням кольорового простору HSL доступна тільки для зображень RGB 24 bpp!", @"Редактор зображень", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else
                {
                    MessageBox.Show(@"Brightness adjustment using HSL color space is available for 24 bpp RGB images only!", @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return;
            }

            BrightnessForm form = new BrightnessForm();
            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                ApplyFilter(form.Filter);
            }
        }

        private void toolStripButtonContrast_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                if (Equals(Thread.CurrentThread.CurrentUICulture, new CultureInfo("uk")))
                {
                    MessageBox.Show(@"Налаштування контрасту за допомогою колірного простору HSL доступне лише для RGB-зображень 24 bpp!", @"Редактор зображень", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else
                {
                    MessageBox.Show(@"Contrast adjustment using HSL color space is available for 24 bpp RGB images only!", @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
                if (Equals(Thread.CurrentThread.CurrentUICulture, new CultureInfo("uk")))
                {
                    MessageBox.Show(@"Фільтрування кольорів можна застосувати лише до зображень RGB 24 bpp!", @"Редактор зображень", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(@"Color filtering can be applied to 24 bpp RGB images only!", @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
                if (Equals(Thread.CurrentThread.CurrentUICulture, new CultureInfo("uk")))
                {
                    MessageBox.Show(@"Регулювання насиченості за допомогою колірного простору HSL доступне лише для зображень RGB 24 bpp!", @"Редактор зображень", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else
                {
                    MessageBox.Show(@"Saturation adjustment using HSL color space is available for 24 bpp RGB images only!", @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return;
            }
            var form = new SaturationForm();
            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                ApplyFilter(form.Filter);
            }
        }

        private void toolStripButtonHUE_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                if (Equals(Thread.CurrentThread.CurrentUICulture, new CultureInfo("uk")))
                {
                    MessageBox.Show(@"Модифікатор відтінку доступний лише для зображень RGB 24 bpp!", @"Редактор зображень", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(@"Hue modifier is available for 24 bpp RGB images only!", @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
            var form = new AdaptiveSmoothForm();

            form.Image = bitmap;

            if (form.ShowDialog() != DialogResult.OK) return;
            if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                toGrayscale = true;
            ApplyFilter(form.Filter);
        }

        private void toolStripButtonResize_Click(object sender, EventArgs e)
        {
            Size bitmapSize = bitmap.Size;
            ResizeForm form = new ResizeForm(bitmapSize);

            if (form.ShowDialog() != DialogResult.OK) return;
            if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                toGrayscale = true;
            ApplyFilter(form.Filter);
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
                imageDisplay.Invalidate();
            }
            else if (Equals(Thread.CurrentThread.CurrentUICulture, new CultureInfo("uk")))
            {
                MessageBox.Show(this, @"Нема зображення, яке потрібно вирізати!", @"Редактор зображень", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(this, @"There is no image to cut!", @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuItemCopy_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Clipboard.SetDataObject(bitmap, true);
            }
            else if (Equals(Thread.CurrentThread.CurrentUICulture, new CultureInfo("uk")))
            {
                MessageBox.Show(this, @"Немає зображення для копіювання!", @"Редактор зображень", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(this, @"There is no image to copy!", @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuItemPaste_Click(object sender, EventArgs e)
        {
            // ReSharper disable once PossibleNullReferenceException
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Bitmap))
            {
                if (bitmap != null)
                {
                    MenuItemPreviousImage.Enabled = MenuItemNextImage.Enabled = MenuItemFirstImage.Enabled = MenuItemLastImage.Enabled = 
                        MenuItemRandomImage.Enabled = toolStripButtonPreviousImage.Enabled = toolStripButtonNextImage.Enabled = false;
                }

                var newBitmap = (Bitmap)Clipboard.GetDataObject()?.GetData(DataFormats.Bitmap);
                if (newBitmap != null)
                {
                    bitmap = newBitmap.Clone(new Rectangle(0, 0, newBitmap.Width, newBitmap.Height),
                        PixelFormat.Format24bppRgb);
                    newBitmap.Dispose();
                }

                string drive = Environment.GetEnvironmentVariable("SystemDrive");
                Directory.CreateDirectory(drive + "\\Temp");
                string filePath = drive + "\\Temp\\Clipboard.bmp";
                SaveImage(filePath);
                imageFile = filePath;
                Directory.SetCurrentDirectory(Directory.GetParent(imageFile)?.FullName ?? string.Empty);
                ProcessDirectory();
                zoomFactor = 1.00F;
                isDeleted = false;
                ShowPicture();
            }
            else
            {
                if (Equals(Thread.CurrentThread.CurrentUICulture, new CultureInfo("uk")))
                {
                    MessageBox.Show(this, @"Немає зображення для вставлення!", @"Редактор зображень", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this, @"There is no image to paste!", @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            statusBar.Visible = MenuItemShowStatusBar.Checked;
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
            var random = new Random();
            currentFileIndex = random.Next(imageFiles.Count); ShowPicture();
        }

        private void MenuItem10_Click(object sender, EventArgs e)
        {
            zoomFactor = 0.10F;
            imageDisplay.Invalidate();
        }

        private void MenuItem25_Click(object sender, EventArgs e)
        {
            zoomFactor = 0.25F;
            imageDisplay.Invalidate();
        }

        private void MenuItem50_Click(object sender, EventArgs e)
        {
            zoomFactor = 0.50F;
            imageDisplay.Invalidate();
        }

        private void MenuItem75_Click(object sender, EventArgs e)
        {
            zoomFactor = 0.75F;
            imageDisplay.Invalidate();
        }

        private void MenuItemActualSize_Click(object sender, EventArgs e)
        {
            zoomFactor = 1.00F;
            imageDisplay.Invalidate();
        }

        private void MenuItem150_Click(object sender, EventArgs e)
        {
            zoomFactor = 1.50F;
            imageDisplay.Invalidate();
        }

        private void MenuItem200_Click(object sender, EventArgs e)
        {
            zoomFactor = 2.00F;
            imageDisplay.Invalidate();
        }

        private void MenuItem400_Click(object sender, EventArgs e)
        {
            zoomFactor = 4.00F;
            imageDisplay.Invalidate();
        }

        private void MenuItem500_Click(object sender, EventArgs e)
        {
            zoomFactor = 5.00F;
            imageDisplay.Invalidate();
        }

        private void MenuItemCenterImages_Click(object sender, EventArgs e)
        {
            imageDisplay.Invalidate();
        }

        [Obsolete]
        private void MenuItemGrayscale_Click(object sender, EventArgs e)
        {
            var format = FormatFromExtension(GetFilePath());

            if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed || bitmap.PixelFormat == PixelFormat.Format16bppGrayScale)
            {
                if (Equals(format, ImageFormat.Gif))
                {
                    if (Equals(Thread.CurrentThread.CurrentUICulture, new CultureInfo("uk")))
                    {
                        MessageBox.Show(@"Формат вихідного пікселя не підтримується фільтром.", @"Редактор зображень", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(@"Source pixel format is not supported by the filter.", @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    return;
                }

                if (Equals(Thread.CurrentThread.CurrentUICulture, new CultureInfo("uk")))
                {
                    MessageBox.Show(@"Зображення вже має відтінки сірого!", @"Редактор зображень", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(@"The image is already grayscale!", @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                return;
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
            ApplyFilterInPlace(new ChannelFiltering(new IntRange(0, 255), new IntRange(0, 0), new IntRange(0, 0)));
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
                if (Equals(Thread.CurrentThread.CurrentUICulture, new CultureInfo("uk")))
                {
                    MessageBox.Show(@"Фільтрування каналів може бути застосовано лише до RGB-зображень 24 bpp!", @"Редактор зображень", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(@"Channels filtering can be applied to 24 bpp RGB images only!", @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
                return;
            }

            ChannelFilteringForm form = new ChannelFilteringForm();
            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemExtractRedChannel_Click(object sender, EventArgs e)
        {
            ApplyFilter(new ExtractChannel(RGB.R));
        }

        private void MenuItemExtractGreenChannel_Click(object sender, EventArgs e)
        {
            ApplyFilter(new ExtractChannel(RGB.G));
        }

        private void MenuItemExtractBlueChannel_Click(object sender, EventArgs e)
        {
            ApplyFilter(new ExtractChannel(RGB.B));
        }

        private void MenuItemGammaCorrection_Click(object sender, EventArgs e)
        {
            GammaCorrectionForm form = new GammaCorrectionForm();

            form.Image = bitmap;

            if (form.ShowDialog() != DialogResult.OK) return;
            if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                toGrayscale = true;
            ApplyFilter(form.Filter);
        }

        private void MenuItemGaussianBlur_Click(object sender, EventArgs e)
        {
            GaussianBlurForm form = new GaussianBlurForm();

            form.Image = bitmap;

            if (form.ShowDialog() != DialogResult.OK) return;
            if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                toGrayscale = true;
            ApplyFilter(form.Filter);
        }

        private void MenuItemGaussianSharpen_Click(object sender, EventArgs e)
        {
            GaussianSharpenForm form = new GaussianSharpenForm();

            form.Image = bitmap;

            if (form.ShowDialog() != DialogResult.OK) return;
            if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                toGrayscale = true;
            ApplyFilter(form.Filter);
        }

        private void MenuItemConservativeSmoothing_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new ConservativeSmoothing());
        }

        private void MenuItemPixellate_Click(object sender, EventArgs e)
        {
            PixellateForm form = new PixellateForm();

            form.Image = bitmap;

            if (form.ShowDialog() != DialogResult.OK) return;
            if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                toGrayscale = true;
            ApplyFilter(form.Filter);
        }

        private void MenuItemJitter_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Jitter(1));
        }

        private void MenuItemOilPainting_Click(object sender, EventArgs e)
        {
            OilPaintingForm form = new OilPaintingForm();

            form.Image = bitmap;

            if (form.ShowDialog() != DialogResult.OK) return;
            if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                toGrayscale = true;
            ApplyFilter(form.Filter);
        }

        [Obsolete("Obsolete")]
        private void MenuItemPerlinNoise_Click(object sender, EventArgs e)
        {
            PerlinNoiseForm form = new PerlinNoiseForm();

            form.Image = bitmap;

            if (form.ShowDialog() != DialogResult.OK) return;
            if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                toGrayscale = true;
            ApplyFilter(form.Filter);
        }

        private void MenuItemEdges_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Edges());
        }

        private void MenuItemHomogenity_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                ReturnMessageBox();
                return;
            }
            ApplyFilterInPlace(new HomogenityEdgeDetector());
        }

        private void MenuItemThreshold_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format8bppIndexed && bitmap.PixelFormat != PixelFormat.Format16bppGrayScale)
            {
                ReturnMessageBox();
                return;
            }
            ThresholdForm form = new ThresholdForm();

            form.Image = bitmap;

            if (form.ShowDialog() != DialogResult.OK) return;
            toGrayscale = true;
            ApplyFilter(form.Filter);
        }

        private void MenuItemThresholdWithErrorCarry_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                ReturnMessageBox();
                return;
            }
            ApplyFilterInPlace(new ThresholdWithCarry());
        }

        private void MenuItemOrderedDither_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                ReturnMessageBox();
                return;
            }
            ApplyFilterInPlace(new OrderedDithering());
        }

        private void MenuItemFloydSteinberg_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                ReturnMessageBox();
                return;
            }
            ApplyFilterInPlace(new FloydSteinbergDithering());
        }

        private void MenuItemSISThreshold_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                ReturnMessageBox();
                return;
            }
            ApplyFilterInPlace(new SISThreshold());
        }

        private void MenuItemErosion_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Erosion());
        }

        private void MenuItemDilatation_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Dilatation());
        }

        private void MenuItemOpening_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Opening());
        }

        private void MenuItemClosing_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Closing());
        }

        private static void ReturnMessageBox()
        {
            if (Equals(Thread.CurrentThread.CurrentUICulture, new  CultureInfo("uk")))
            {
                MessageBox.Show(@"Фільтр приймає для обробки лише 8 bpp зображень у відтінках сірого! Спочатку потрібно перетворити зображення у відтінки сірого за допомогою Ефекти->Відтінки сірого.", @"Редактор зображень", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(@"The filter accepts only 8 bpp grayscale images for processing! You should first convert the image to grayscale using Effects->Grayscale.", @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void MenuItemSobel_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                ReturnMessageBox();
                return;
            }
            ApplyFilterInPlace(new SobelEdgeDetector());
        }

        private void MenuItemCanny_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                ReturnMessageBox();
                return;
            }
            CannyDetectorForm form = new CannyDetectorForm();

            form.Image = bitmap;

            if (form.ShowDialog() != DialogResult.OK) return;
            toGrayscale = true;
            ApplyFilter(form.Filter);
        }

        private void MenuItemDifference_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                ReturnMessageBox();
                return;
            }
            ApplyFilterInPlace(new DifferenceEdgeDetector());
        }

        private void MenuItemHSLFiltering_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                if (Equals(Thread.CurrentThread.CurrentUICulture, new CultureInfo("uk")))
                {
                    MessageBox.Show(@"HSL-фільтрація доступна лише для RGB-зображень 24 bpp!", @"Редактор зображень", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(@"HSL filtering is available for 24 bpp RGB images only!", @"Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return;
            }

            var form = new HslFilteringForm();
            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                ApplyFilter(form.Filter);
            }
        }
    }
}
