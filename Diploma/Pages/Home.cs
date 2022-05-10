using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Point = System.Drawing.Point;

namespace Diploma.Pages
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            //this.printPreviewDialog.TopLevelControl.Text = "Print Preview";
            //StatusLabelDimensions.Text = "No file loaded (use File->Open)";
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

        #endregion

        #region Methods
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
                }

                printImage.DocumentName = Path.GetFileName(GetFilePath()); if (bitmap.Width > bitmap.Height) printImage.DefaultPageSettings.Landscape = true;
                else printImage.DefaultPageSettings.Landscape = false;
                //printPreviewDialog.PrintPreviewControl.Document.DefaultPageSettings = printImage.DefaultPageSettings;

                //SetMenuItems(true); zoomFactor = 1.00F;
                imageDisplay.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetFilePath()
        {
            if (currentFileIndex > imageFiles.Count - 1)
                currentFileIndex = 0;
            return imageFiles[currentFileIndex].ToString();
        }


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
                    Directory.SetCurrentDirectory(Directory.GetParent(imageFile).FullName.ToString()); 
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

            if (format == ImageFormat.Jpeg)
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
                bitmap.Save(mss, ici, ep);
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

        private ImageFormat FormatFromExtension(string filePath)
        {
            if (filePath.IndexOf('.') > 0)
                filePath = filePath.Substring(filePath.LastIndexOf('.') + 1);
            switch (filePath.ToLower())
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

        private void toolStripButtonSaveAs_Click(object sender, EventArgs e)
        {
            string filePath = GetFilePath();
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

        private void ResetForm()
        {
            //StatusLabelDepth.Available = StatusLabelFileIndex.Available = StatusLabelZoom.Available =
            //StatusLabelFileSize.Available = StatusLabelDateTime.Available = false;
            //StatusLabelDimensions.Text = "No file loaded (use File->Open)";
            //StatusLabelDimensions.BorderSides = ToolStripStatusLabelBorderSides.None;
            this.Text = "ImageEditor";
            //this.MenuItemReopen.Enabled = true;
            //this.MenuItemUndo.Enabled = false;
            this.toolStripButtonUndo.Enabled = false;
           // SetMenuItems(false);
        }

        private void imageDisplay_Paint(object sender, PaintEventArgs e)
        {
            if (deleteImage)
            {
                bitmap = null;
                if (this.imageDisplay.AutoScroll)
                {
                    this.imageDisplay.AutoScroll = false;
                }
                ResetForm();
                isDeleted = true; deleteImage = false; return;
            }

            if (bitmap != null)
            {
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
                        CheckZoom(); this.imageDisplay.AutoScroll = false;
                        //if (MenuItemCenterImages.Checked)
                        //{
                            position.X = (imageDisplay.Width - bitmap.Width * zoomFactor) / 2;
                            position.Y = (imageDisplay.Height - bitmap.Height * zoomFactor) / 2;
                        //}
                        //else
                        //{
                        //    position.X = 0;
                        //    position.Y = 0;
                        //}

                        g.DrawImage(bitmap, new RectangleF(position.X, position.Y, bitmap.Width * zoomFactor, bitmap.Height * zoomFactor));

                        if (fullScreen)
                        {
                            string fileIndex = " [" + (currentFileIndex + 1).ToString() + "/" + imageFiles.Count.ToString() + "]";
                            g.DrawString(GetFilePath() + fileIndex, new Font("Segoe UI", 10, GraphicsUnit.Point), Brushes.Lime, new Point(2, 2));
                        }

                        zoomBitmap = new Bitmap(bitmap, new Size((int)(bitmap.Width * zoomFactor), (int)(bitmap.Height * zoomFactor)));

                        this.Text = Path.GetFileName(GetFilePath()) + " - SPixel";
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
                            //if (MenuItemCenterImages.Checked)
                            //{
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
                            //}

                            g.DrawImage(bitmap, new RectangleF(position.X, position.Y, width, height));

                            if (fullScreen)
                            {
                                string fileIndex = " [" + (currentFileIndex + 1).ToString() + "/" + imageFiles.Count.ToString() + "]";
                                g.DrawString(GetFilePath() + fileIndex, new Font("Segoe UI", 10, GraphicsUnit.Point), Brushes.Lime, new Point(2, 2));
                            }

                            zoomBitmap = new Bitmap(bitmap, new Size(width, height));

                            zoom = (float)Math.Min((float)width / bitmap.Width, (float)height / bitmap.Height);

                            this.Text = Path.GetFileName(GetFilePath()) + " - SPixel (Zoom: " + width.ToString() + " x " + height.ToString() + ")";
                        }
                        else
                        {
                            CheckZoom();
                            this.imageDisplay.AutoScroll = true;

                            float zoomWidth = (float)bitmap.Width * zoomFactor;
                            float zoomHeight = (float)bitmap.Height * zoomFactor;
                            Size zoomSize = new Size((int)zoomWidth, (int)zoomHeight);

                            this.imageDisplay.AutoScrollMinSize = zoomSize;
                            position.X = imageDisplay.AutoScrollPosition.X;
                            position.Y = imageDisplay.AutoScrollPosition.Y;

                            if (/*MenuItemCenterImages.Checked &&*/ (zoomSize.Height < imageDisplay.Height || zoomSize.Width < imageDisplay.Width))
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

                            this.Text = Path.GetFileName(GetFilePath()) + " - SPixel";
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

                        // MenuItemReopen.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

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
    }
}
