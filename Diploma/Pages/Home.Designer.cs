using Diploma.Controls;

namespace Diploma.Pages
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrintImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.ImageProperties = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPreviousImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNextImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFullScreen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCrop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRotateLeft = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRotateRight = new System.Windows.Forms.ToolStripButton();
            this.FlipVertical = new System.Windows.Forms.ToolStripButton();
            this.FlipHorizontal = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonActualSize = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFitImages = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReset = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSend = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabelMousePosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelRGB = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelHSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.printImage = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.toolStripButtonBrightness = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonContrast = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonColorFiltering = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaturation = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHUE = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSmooth = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonResize = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton26 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton27 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCustomRotation = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.imageDisplay = new Diploma.Controls.DoubleBufferDisplay();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReopen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemShowToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemShowStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemNextImage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPreviousImage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFirstImage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLastImage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRandomImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem50 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem75 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemActualSize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem150 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem200 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem400 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem500 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFullScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemCenterImages = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFitImages = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemImageProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHistogram = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemImageStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemImage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRotateLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRotateRight = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCustomRotation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemHorizontalFlip = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemVerticalFlip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemResize = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCrop = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemShrink = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAdjustments = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemColorFiltering = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEucledianColorFiltering = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemChannels = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChannelsFiltering = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemExtractRedChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExtractGreenChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExtractBlueChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemBrightness = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemContrast = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSaturation = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemGammaCorrection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemHSLFiltering = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHueModifier = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEffects = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemGrayscale = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSepia = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInvertColors = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemBlurAndSharpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemBlur = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSharpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemGaussianBlur = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemGaussianSharpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemColors = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRed = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemCyan = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemMagenta = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemYellow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator24 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemRotateRGBChannels = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemBinarization = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemThreshold = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemThresholdWithErrorCarry = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOrderedDither = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFloydSteinberg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSISThreshold = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemMorphology = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemErosion = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDilatation = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpening = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemClosing = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEdgeDetectors = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEdges = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHomogenity = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDifference = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSobel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCanny = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemAdaptiveSmoothing = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConservativeSmoothing = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemPerlinNoise = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemOilPainting = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemJitter = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPixellate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemMean = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemMedian = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripButtonSaveAs,
            this.toolStripButton1,
            this.toolStripButtonPrintImage,
            this.toolStripButtonDelete,
            this.toolStripButtonUndo,
            this.ImageProperties,
            this.toolStripButtonPreviousImage,
            this.toolStripButtonNextImage,
            this.toolStripButtonZoomIn,
            this.toolStripButtonZoomOut,
            this.toolStripButtonFullScreen,
            this.toolStripButtonCrop,
            this.toolStripButtonRotateLeft,
            this.toolStripButtonRotateRight,
            this.FlipVertical,
            this.FlipHorizontal,
            this.toolStripButtonActualSize,
            this.toolStripButtonFitImages,
            this.toolStripButtonReset,
            this.toolStripButtonSend});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1072, 40);
            this.toolStrip1.TabIndex = 1;
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.AutoSize = false;
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonOpen.Text = "toolStripButton1";
            this.toolStripButtonOpen.ToolTipText = "Open Image File";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSaveAs
            // 
            this.toolStripButtonSaveAs.AutoSize = false;
            this.toolStripButtonSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveAs.Enabled = false;
            this.toolStripButtonSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveAs.Image")));
            this.toolStripButtonSaveAs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveAs.Name = "toolStripButtonSaveAs";
            this.toolStripButtonSaveAs.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonSaveAs.Text = "toolStripButton1";
            this.toolStripButtonSaveAs.ToolTipText = "Save Image As";
            this.toolStripButtonSaveAs.Click += new System.EventHandler(this.toolStripButtonSaveAs_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton1.Text = "toolStripButtonSaveImage";
            this.toolStripButton1.ToolTipText = "Save Image";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonPrintImage
            // 
            this.toolStripButtonPrintImage.AutoSize = false;
            this.toolStripButtonPrintImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrintImage.Enabled = false;
            this.toolStripButtonPrintImage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrintImage.Image")));
            this.toolStripButtonPrintImage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonPrintImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrintImage.Name = "toolStripButtonPrintImage";
            this.toolStripButtonPrintImage.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonPrintImage.Text = "toolStripButton1";
            this.toolStripButtonPrintImage.ToolTipText = "Print Image";
            this.toolStripButtonPrintImage.Click += new System.EventHandler(this.toolStripButtonPrintImage_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.AutoSize = false;
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Enabled = false;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonDelete.Text = "toolStripButtonDelete";
            this.toolStripButtonDelete.ToolTipText = "Delete (Clear Display)";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.AutoSize = false;
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUndo.Enabled = false;
            this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
            this.toolStripButtonUndo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonUndo.Text = "toolStripButton1";
            this.toolStripButtonUndo.ToolTipText = "Undo";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // ImageProperties
            // 
            this.ImageProperties.AutoSize = false;
            this.ImageProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ImageProperties.Enabled = false;
            this.ImageProperties.Image = ((System.Drawing.Image)(resources.GetObject("ImageProperties.Image")));
            this.ImageProperties.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ImageProperties.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImageProperties.Name = "ImageProperties";
            this.ImageProperties.Size = new System.Drawing.Size(40, 40);
            this.ImageProperties.Text = "toolStripButton1";
            this.ImageProperties.ToolTipText = "Image Properties";
            this.ImageProperties.Click += new System.EventHandler(this.ImageProperties_Click);
            // 
            // toolStripButtonPreviousImage
            // 
            this.toolStripButtonPreviousImage.AutoSize = false;
            this.toolStripButtonPreviousImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPreviousImage.Enabled = false;
            this.toolStripButtonPreviousImage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPreviousImage.Image")));
            this.toolStripButtonPreviousImage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonPreviousImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPreviousImage.Name = "toolStripButtonPreviousImage";
            this.toolStripButtonPreviousImage.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonPreviousImage.Text = "toolStripButton1";
            this.toolStripButtonPreviousImage.ToolTipText = "Previous Image in Directory";
            this.toolStripButtonPreviousImage.Click += new System.EventHandler(this.toolStripButtonPreviousImage_Click);
            // 
            // toolStripButtonNextImage
            // 
            this.toolStripButtonNextImage.AutoSize = false;
            this.toolStripButtonNextImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNextImage.Enabled = false;
            this.toolStripButtonNextImage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNextImage.Image")));
            this.toolStripButtonNextImage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonNextImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNextImage.Name = "toolStripButtonNextImage";
            this.toolStripButtonNextImage.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonNextImage.Text = "toolStripButton1";
            this.toolStripButtonNextImage.ToolTipText = "Next Image in Directory";
            this.toolStripButtonNextImage.Click += new System.EventHandler(this.toolStripButtonNextImage_Click);
            // 
            // toolStripButtonZoomIn
            // 
            this.toolStripButtonZoomIn.AutoSize = false;
            this.toolStripButtonZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoomIn.Enabled = false;
            this.toolStripButtonZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonZoomIn.Image")));
            this.toolStripButtonZoomIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZoomIn.Name = "toolStripButtonZoomIn";
            this.toolStripButtonZoomIn.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonZoomIn.Text = "toolStripButton1";
            this.toolStripButtonZoomIn.ToolTipText = "Zoom In";
            this.toolStripButtonZoomIn.Click += new System.EventHandler(this.toolStripButtonZoomIn_Click);
            // 
            // toolStripButtonZoomOut
            // 
            this.toolStripButtonZoomOut.AutoSize = false;
            this.toolStripButtonZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoomOut.Enabled = false;
            this.toolStripButtonZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonZoomOut.Image")));
            this.toolStripButtonZoomOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZoomOut.Name = "toolStripButtonZoomOut";
            this.toolStripButtonZoomOut.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonZoomOut.Text = "toolStripButton1";
            this.toolStripButtonZoomOut.ToolTipText = "Zoom Out";
            this.toolStripButtonZoomOut.Click += new System.EventHandler(this.toolStripButtonZoomOut_Click);
            // 
            // toolStripButtonFullScreen
            // 
            this.toolStripButtonFullScreen.AutoSize = false;
            this.toolStripButtonFullScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFullScreen.Enabled = false;
            this.toolStripButtonFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFullScreen.Image")));
            this.toolStripButtonFullScreen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonFullScreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFullScreen.Name = "toolStripButtonFullScreen";
            this.toolStripButtonFullScreen.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonFullScreen.Text = "toolStripButton1";
            this.toolStripButtonFullScreen.ToolTipText = "Full Screen";
            this.toolStripButtonFullScreen.Click += new System.EventHandler(this.toolStripButtonFullScreen_Click);
            // 
            // toolStripButtonCrop
            // 
            this.toolStripButtonCrop.AutoSize = false;
            this.toolStripButtonCrop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCrop.Enabled = false;
            this.toolStripButtonCrop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCrop.Image")));
            this.toolStripButtonCrop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonCrop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCrop.Name = "toolStripButtonCrop";
            this.toolStripButtonCrop.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonCrop.ToolTipText = "Crop Image";
            this.toolStripButtonCrop.Click += new System.EventHandler(this.toolStripButtonCrop_Click);
            // 
            // toolStripButtonRotateLeft
            // 
            this.toolStripButtonRotateLeft.AutoSize = false;
            this.toolStripButtonRotateLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRotateLeft.Enabled = false;
            this.toolStripButtonRotateLeft.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRotateLeft.Image")));
            this.toolStripButtonRotateLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonRotateLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRotateLeft.Name = "toolStripButtonRotateLeft";
            this.toolStripButtonRotateLeft.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonRotateLeft.ToolTipText = "Rotate Left";
            this.toolStripButtonRotateLeft.Click += new System.EventHandler(this.toolStripButtonRotateLeft_Click);
            // 
            // toolStripButtonRotateRight
            // 
            this.toolStripButtonRotateRight.AutoSize = false;
            this.toolStripButtonRotateRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRotateRight.Enabled = false;
            this.toolStripButtonRotateRight.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRotateRight.Image")));
            this.toolStripButtonRotateRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonRotateRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRotateRight.Name = "toolStripButtonRotateRight";
            this.toolStripButtonRotateRight.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonRotateRight.ToolTipText = "Rotate Right";
            this.toolStripButtonRotateRight.Click += new System.EventHandler(this.toolStripButtonRotateRight_Click);
            // 
            // FlipVertical
            // 
            this.FlipVertical.AutoSize = false;
            this.FlipVertical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FlipVertical.Enabled = false;
            this.FlipVertical.Image = ((System.Drawing.Image)(resources.GetObject("FlipVertical.Image")));
            this.FlipVertical.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FlipVertical.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FlipVertical.Name = "FlipVertical";
            this.FlipVertical.Size = new System.Drawing.Size(40, 40);
            this.FlipVertical.Text = "toolStripButton1";
            this.FlipVertical.ToolTipText = "Flip Vertical";
            this.FlipVertical.Click += new System.EventHandler(this.FlipVertical_Click);
            // 
            // FlipHorizontal
            // 
            this.FlipHorizontal.AutoSize = false;
            this.FlipHorizontal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FlipHorizontal.Enabled = false;
            this.FlipHorizontal.Image = ((System.Drawing.Image)(resources.GetObject("FlipHorizontal.Image")));
            this.FlipHorizontal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FlipHorizontal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FlipHorizontal.Name = "FlipHorizontal";
            this.FlipHorizontal.Size = new System.Drawing.Size(40, 40);
            this.FlipHorizontal.Text = "toolStripButton1";
            this.FlipHorizontal.ToolTipText = "Flip Horizontal";
            this.FlipHorizontal.Click += new System.EventHandler(this.FlipHorizontal_Click);
            // 
            // toolStripButtonActualSize
            // 
            this.toolStripButtonActualSize.AutoSize = false;
            this.toolStripButtonActualSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonActualSize.Enabled = false;
            this.toolStripButtonActualSize.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonActualSize.Image")));
            this.toolStripButtonActualSize.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonActualSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonActualSize.Name = "toolStripButtonActualSize";
            this.toolStripButtonActualSize.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonActualSize.ToolTipText = "Actual Size";
            this.toolStripButtonActualSize.Click += new System.EventHandler(this.toolStripButtonActualSize_Click);
            // 
            // toolStripButtonFitImages
            // 
            this.toolStripButtonFitImages.AutoSize = false;
            this.toolStripButtonFitImages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFitImages.Enabled = false;
            this.toolStripButtonFitImages.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFitImages.Image")));
            this.toolStripButtonFitImages.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonFitImages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFitImages.Name = "toolStripButtonFitImages";
            this.toolStripButtonFitImages.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonFitImages.ToolTipText = "Fit Images to Window";
            this.toolStripButtonFitImages.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButtonReset
            // 
            this.toolStripButtonReset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonReset.AutoSize = false;
            this.toolStripButtonReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReset.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReset.Image")));
            this.toolStripButtonReset.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReset.Name = "toolStripButtonReset";
            this.toolStripButtonReset.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonReset.ToolTipText = "Reset Image";
            this.toolStripButtonReset.Click += new System.EventHandler(this.toolStripButtonReset_Click);
            // 
            // toolStripButtonSend
            // 
            this.toolStripButtonSend.AutoSize = false;
            this.toolStripButtonSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSend.Enabled = false;
            this.toolStripButtonSend.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSend.Image")));
            this.toolStripButtonSend.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSend.Name = "toolStripButtonSend";
            this.toolStripButtonSend.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonSend.ToolTipText = "Send Image";
            this.toolStripButtonSend.Click += new System.EventHandler(this.toolStripButtonSend_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabelMousePosition,
            this.StatusLabelRGB,
            this.StatusLabelHSL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 655);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1072, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabelMousePosition
            // 
            this.StatusLabelMousePosition.Name = "StatusLabelMousePosition";
            this.StatusLabelMousePosition.Size = new System.Drawing.Size(0, 20);
            // 
            // StatusLabelRGB
            // 
            this.StatusLabelRGB.Name = "StatusLabelRGB";
            this.StatusLabelRGB.Size = new System.Drawing.Size(0, 20);
            // 
            // StatusLabelHSL
            // 
            this.StatusLabelHSL.Name = "StatusLabelHSL";
            this.StatusLabelHSL.Size = new System.Drawing.Size(0, 20);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.mainMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 65);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 590);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.imageDisplay);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(40, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 590);
            this.panel3.TabIndex = 6;
            // 
            // printImage
            // 
            this.printImage.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printImage_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // toolStripButtonBrightness
            // 
            this.toolStripButtonBrightness.AutoSize = false;
            this.toolStripButtonBrightness.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBrightness.Enabled = false;
            this.toolStripButtonBrightness.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBrightness.Image")));
            this.toolStripButtonBrightness.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonBrightness.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBrightness.Name = "toolStripButtonBrightness";
            this.toolStripButtonBrightness.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonBrightness.ToolTipText = "Brightness";
            this.toolStripButtonBrightness.Click += new System.EventHandler(this.toolStripButtonBrightness_Click);
            // 
            // toolStripButtonContrast
            // 
            this.toolStripButtonContrast.AutoSize = false;
            this.toolStripButtonContrast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonContrast.Enabled = false;
            this.toolStripButtonContrast.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonContrast.Image")));
            this.toolStripButtonContrast.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonContrast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonContrast.Name = "toolStripButtonContrast";
            this.toolStripButtonContrast.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonContrast.ToolTipText = "Contrast";
            this.toolStripButtonContrast.Click += new System.EventHandler(this.toolStripButtonContrast_Click);
            // 
            // toolStripButtonColorFiltering
            // 
            this.toolStripButtonColorFiltering.AutoSize = false;
            this.toolStripButtonColorFiltering.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonColorFiltering.Enabled = false;
            this.toolStripButtonColorFiltering.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonColorFiltering.Image")));
            this.toolStripButtonColorFiltering.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonColorFiltering.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColorFiltering.Name = "toolStripButtonColorFiltering";
            this.toolStripButtonColorFiltering.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonColorFiltering.Text = "Color Filtering";
            this.toolStripButtonColorFiltering.Click += new System.EventHandler(this.toolStripButtonColorFiltering_Click);
            // 
            // toolStripButtonSaturation
            // 
            this.toolStripButtonSaturation.AutoSize = false;
            this.toolStripButtonSaturation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaturation.Enabled = false;
            this.toolStripButtonSaturation.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaturation.Image")));
            this.toolStripButtonSaturation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSaturation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaturation.Name = "toolStripButtonSaturation";
            this.toolStripButtonSaturation.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonSaturation.Text = "toolStripButton15";
            this.toolStripButtonSaturation.ToolTipText = "Saturation";
            this.toolStripButtonSaturation.Click += new System.EventHandler(this.toolStripButtonSaturation_Click);
            // 
            // toolStripButtonHUE
            // 
            this.toolStripButtonHUE.AutoSize = false;
            this.toolStripButtonHUE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHUE.Enabled = false;
            this.toolStripButtonHUE.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHUE.Image")));
            this.toolStripButtonHUE.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonHUE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHUE.Name = "toolStripButtonHUE";
            this.toolStripButtonHUE.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonHUE.Text = "toolStripButton15";
            this.toolStripButtonHUE.ToolTipText = "Hue Modifier";
            this.toolStripButtonHUE.Click += new System.EventHandler(this.toolStripButtonHUE_Click);
            // 
            // toolStripButtonSmooth
            // 
            this.toolStripButtonSmooth.AutoSize = false;
            this.toolStripButtonSmooth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSmooth.Enabled = false;
            this.toolStripButtonSmooth.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSmooth.Image")));
            this.toolStripButtonSmooth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSmooth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSmooth.Name = "toolStripButtonSmooth";
            this.toolStripButtonSmooth.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonSmooth.Text = "toolStripButton15";
            this.toolStripButtonSmooth.ToolTipText = "Adaptive Smoothing";
            this.toolStripButtonSmooth.Click += new System.EventHandler(this.toolStripButtonSmooth_Click);
            // 
            // toolStripButtonResize
            // 
            this.toolStripButtonResize.AutoSize = false;
            this.toolStripButtonResize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonResize.Enabled = false;
            this.toolStripButtonResize.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonResize.Image")));
            this.toolStripButtonResize.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonResize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonResize.Name = "toolStripButtonResize";
            this.toolStripButtonResize.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonResize.Text = "toolStripButton15";
            this.toolStripButtonResize.ToolTipText = "Resize Image";
            this.toolStripButtonResize.Click += new System.EventHandler(this.toolStripButtonResize_Click);
            // 
            // toolStripButton26
            // 
            this.toolStripButton26.AutoSize = false;
            this.toolStripButton26.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton26.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton26.Image")));
            this.toolStripButton26.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton26.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton26.Name = "toolStripButton26";
            this.toolStripButton26.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton26.Text = "toolStripButton15";
            // 
            // toolStripButton27
            // 
            this.toolStripButton27.AutoSize = false;
            this.toolStripButton27.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton27.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton27.Image")));
            this.toolStripButton27.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton27.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton27.Name = "toolStripButton27";
            this.toolStripButton27.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton27.Text = "toolStripButton15";
            // 
            // toolStripButtonCustomRotation
            // 
            this.toolStripButtonCustomRotation.AutoSize = false;
            this.toolStripButtonCustomRotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCustomRotation.Enabled = false;
            this.toolStripButtonCustomRotation.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCustomRotation.Image")));
            this.toolStripButtonCustomRotation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonCustomRotation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCustomRotation.Name = "toolStripButtonCustomRotation";
            this.toolStripButtonCustomRotation.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonCustomRotation.Text = "toolStripButton15";
            this.toolStripButtonCustomRotation.ToolTipText = "Custom Rotation";
            this.toolStripButtonCustomRotation.Click += new System.EventHandler(this.toolStripButtonCustomRotation_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.White;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBrightness,
            this.toolStripButtonContrast,
            this.toolStripButtonColorFiltering,
            this.toolStripButtonSaturation,
            this.toolStripButtonHUE,
            this.toolStripButtonSmooth,
            this.toolStripButtonResize,
            this.toolStripButton26,
            this.toolStripButton27,
            this.toolStripButtonCustomRotation});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(40, 590);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // imageDisplay
            // 
            this.imageDisplay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.imageDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageDisplay.Location = new System.Drawing.Point(0, 0);
            this.imageDisplay.Name = "imageDisplay";
            this.imageDisplay.Size = new System.Drawing.Size(1032, 590);
            this.imageDisplay.TabIndex = 3;
            this.imageDisplay.TabStop = false;
            this.imageDisplay.Click += new System.EventHandler(this.imageDisplay_Click);
            this.imageDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.imageDisplay_Paint);
            this.imageDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageDisplay_MouseDown);
            this.imageDisplay.MouseLeave += new System.EventHandler(this.imageDisplay_MouseLeave);
            this.imageDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageDisplay_MouseMove);
            this.imageDisplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageDisplay_MouseUp);
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.White;
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemEdit,
            this.MenuItemView,
            this.MenuItemImage,
            this.MenuItemAdjustments,
            this.MenuItemEffects});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1072, 25);
            this.mainMenu.TabIndex = 1;
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemOpen,
            this.MenuItemReopen,
            this.toolStripMenuItem1,
            this.MenuItemSave,
            this.MenuItemSaveAs,
            this.toolStripSeparator4,
            this.MenuItemPrint,
            this.MenuItemPrintPreview,
            this.MenuItemPageSetup,
            this.toolStripSeparator3,
            this.MenuItemExit});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(39, 21);
            this.MenuItemFile.Text = "&File";
            // 
            // MenuItemOpen
            // 
            this.MenuItemOpen.Name = "MenuItemOpen";
            this.MenuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuItemOpen.Size = new System.Drawing.Size(208, 22);
            this.MenuItemOpen.Text = "&Open...";
            this.MenuItemOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // MenuItemReopen
            // 
            this.MenuItemReopen.Enabled = false;
            this.MenuItemReopen.Name = "MenuItemReopen";
            this.MenuItemReopen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.MenuItemReopen.Size = new System.Drawing.Size(208, 22);
            this.MenuItemReopen.Text = "&Reopen";
            this.MenuItemReopen.Click += new System.EventHandler(this.MenuItemReopen_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(205, 6);
            // 
            // MenuItemSave
            // 
            this.MenuItemSave.Enabled = false;
            this.MenuItemSave.Name = "MenuItemSave";
            this.MenuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuItemSave.Size = new System.Drawing.Size(208, 22);
            this.MenuItemSave.Text = "&Save";
            this.MenuItemSave.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // MenuItemSaveAs
            // 
            this.MenuItemSaveAs.Enabled = false;
            this.MenuItemSaveAs.Name = "MenuItemSaveAs";
            this.MenuItemSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.MenuItemSaveAs.Size = new System.Drawing.Size(208, 22);
            this.MenuItemSaveAs.Text = "Save &As...";
            this.MenuItemSaveAs.Click += new System.EventHandler(this.toolStripButtonSaveAs_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(205, 6);
            // 
            // MenuItemPrint
            // 
            this.MenuItemPrint.Enabled = false;
            this.MenuItemPrint.Name = "MenuItemPrint";
            this.MenuItemPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.MenuItemPrint.Size = new System.Drawing.Size(208, 22);
            this.MenuItemPrint.Text = "&Print...";
            this.MenuItemPrint.Click += new System.EventHandler(this.toolStripButtonPrintImage_Click);
            // 
            // MenuItemPrintPreview
            // 
            this.MenuItemPrintPreview.Enabled = false;
            this.MenuItemPrintPreview.Name = "MenuItemPrintPreview";
            this.MenuItemPrintPreview.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.MenuItemPrintPreview.Size = new System.Drawing.Size(208, 22);
            this.MenuItemPrintPreview.Text = "Print Pre&view...";
            this.MenuItemPrintPreview.Click += new System.EventHandler(this.MenuItemPrintPreview_Click);
            // 
            // MenuItemPageSetup
            // 
            this.MenuItemPageSetup.Enabled = false;
            this.MenuItemPageSetup.Name = "MenuItemPageSetup";
            this.MenuItemPageSetup.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.MenuItemPageSetup.Size = new System.Drawing.Size(208, 22);
            this.MenuItemPageSetup.Text = "Page Set&up...";
            this.MenuItemPageSetup.Click += new System.EventHandler(this.MenuItemPageSetup_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(205, 6);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.ShortcutKeyDisplayString = "Esc";
            this.MenuItemExit.Size = new System.Drawing.Size(208, 22);
            this.MenuItemExit.Text = "E&xit";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // MenuItemEdit
            // 
            this.MenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemUndo,
            this.toolStripMenuItem4,
            this.MenuItemCut,
            this.MenuItemCopy,
            this.MenuItemPaste});
            this.MenuItemEdit.Name = "MenuItemEdit";
            this.MenuItemEdit.Size = new System.Drawing.Size(42, 21);
            this.MenuItemEdit.Text = "E&dit";
            // 
            // MenuItemUndo
            // 
            this.MenuItemUndo.Enabled = false;
            this.MenuItemUndo.Name = "MenuItemUndo";
            this.MenuItemUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.MenuItemUndo.Size = new System.Drawing.Size(180, 22);
            this.MenuItemUndo.Text = "&Undo";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuItemCut
            // 
            this.MenuItemCut.Enabled = false;
            this.MenuItemCut.Name = "MenuItemCut";
            this.MenuItemCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.MenuItemCut.Size = new System.Drawing.Size(180, 22);
            this.MenuItemCut.Text = "Cu&t";
            // 
            // MenuItemCopy
            // 
            this.MenuItemCopy.Enabled = false;
            this.MenuItemCopy.Name = "MenuItemCopy";
            this.MenuItemCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.MenuItemCopy.Size = new System.Drawing.Size(180, 22);
            this.MenuItemCopy.Text = "&Copy";
            // 
            // MenuItemPaste
            // 
            this.MenuItemPaste.Name = "MenuItemPaste";
            this.MenuItemPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.MenuItemPaste.Size = new System.Drawing.Size(180, 22);
            this.MenuItemPaste.Text = "&Paste";
            // 
            // MenuItemView
            // 
            this.MenuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemShowToolbar,
            this.MenuItemShowStatusBar,
            this.toolStripSeparator8,
            this.MenuItemNextImage,
            this.MenuItemPreviousImage,
            this.MenuItemFirstImage,
            this.MenuItemLastImage,
            this.MenuItemRandomImage,
            this.toolStripMenuItem6,
            this.MenuItemZoom,
            this.MenuItemFullScreen,
            this.MenuItemDelete,
            this.toolStripMenuItem7,
            this.MenuItemCenterImages,
            this.MenuItemFitImages,
            this.toolStripSeparator7,
            this.MenuItemImageProperties,
            this.MenuItemHistogram,
            this.MenuItemImageStatistics});
            this.MenuItemView.Name = "MenuItemView";
            this.MenuItemView.Size = new System.Drawing.Size(47, 21);
            this.MenuItemView.Text = "&View";
            // 
            // MenuItemShowToolbar
            // 
            this.MenuItemShowToolbar.Checked = true;
            this.MenuItemShowToolbar.CheckOnClick = true;
            this.MenuItemShowToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemShowToolbar.Name = "MenuItemShowToolbar";
            this.MenuItemShowToolbar.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.MenuItemShowToolbar.Size = new System.Drawing.Size(269, 22);
            this.MenuItemShowToolbar.Text = "Show &Toolbar";
            // 
            // MenuItemShowStatusBar
            // 
            this.MenuItemShowStatusBar.Checked = true;
            this.MenuItemShowStatusBar.CheckOnClick = true;
            this.MenuItemShowStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemShowStatusBar.Name = "MenuItemShowStatusBar";
            this.MenuItemShowStatusBar.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MenuItemShowStatusBar.Size = new System.Drawing.Size(269, 22);
            this.MenuItemShowStatusBar.Text = "Show Status &Bar";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(266, 6);
            // 
            // MenuItemNextImage
            // 
            this.MenuItemNextImage.Enabled = false;
            this.MenuItemNextImage.Name = "MenuItemNextImage";
            this.MenuItemNextImage.ShortcutKeyDisplayString = "Right";
            this.MenuItemNextImage.Size = new System.Drawing.Size(269, 22);
            this.MenuItemNextImage.Text = "&Next Image in Directory";
            // 
            // MenuItemPreviousImage
            // 
            this.MenuItemPreviousImage.Enabled = false;
            this.MenuItemPreviousImage.Name = "MenuItemPreviousImage";
            this.MenuItemPreviousImage.ShortcutKeyDisplayString = "Left";
            this.MenuItemPreviousImage.Size = new System.Drawing.Size(269, 22);
            this.MenuItemPreviousImage.Text = "&Previous Image in Directory";
            // 
            // MenuItemFirstImage
            // 
            this.MenuItemFirstImage.Enabled = false;
            this.MenuItemFirstImage.Name = "MenuItemFirstImage";
            this.MenuItemFirstImage.ShortcutKeyDisplayString = "Home";
            this.MenuItemFirstImage.Size = new System.Drawing.Size(269, 22);
            this.MenuItemFirstImage.Text = "&First Image in Directory";
            // 
            // MenuItemLastImage
            // 
            this.MenuItemLastImage.Enabled = false;
            this.MenuItemLastImage.Name = "MenuItemLastImage";
            this.MenuItemLastImage.ShortcutKeyDisplayString = "End";
            this.MenuItemLastImage.Size = new System.Drawing.Size(269, 22);
            this.MenuItemLastImage.Text = "&Last Image in Directory";
            // 
            // MenuItemRandomImage
            // 
            this.MenuItemRandomImage.Enabled = false;
            this.MenuItemRandomImage.Name = "MenuItemRandomImage";
            this.MenuItemRandomImage.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.MenuItemRandomImage.Size = new System.Drawing.Size(269, 22);
            this.MenuItemRandomImage.Text = "&Random Image in Directory";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(266, 6);
            // 
            // MenuItemZoom
            // 
            this.MenuItemZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemZoomIn,
            this.MenuItemZoomOut,
            this.toolStripSeparator11,
            this.MenuItem10,
            this.MenuItem25,
            this.MenuItem50,
            this.MenuItem75,
            this.toolStripSeparator9,
            this.MenuItemActualSize,
            this.toolStripSeparator10,
            this.MenuItem150,
            this.MenuItem200,
            this.MenuItem400,
            this.MenuItem500});
            this.MenuItemZoom.Enabled = false;
            this.MenuItemZoom.Name = "MenuItemZoom";
            this.MenuItemZoom.Size = new System.Drawing.Size(269, 22);
            this.MenuItemZoom.Text = "&Zoom";
            // 
            // MenuItemZoomIn
            // 
            this.MenuItemZoomIn.Name = "MenuItemZoomIn";
            this.MenuItemZoomIn.ShortcutKeyDisplayString = "+";
            this.MenuItemZoomIn.Size = new System.Drawing.Size(152, 22);
            this.MenuItemZoomIn.Text = "&Zoom In";
            // 
            // MenuItemZoomOut
            // 
            this.MenuItemZoomOut.Name = "MenuItemZoomOut";
            this.MenuItemZoomOut.ShortcutKeyDisplayString = "-";
            this.MenuItemZoomOut.Size = new System.Drawing.Size(152, 22);
            this.MenuItemZoomOut.Text = "Zoom &Out";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(149, 6);
            // 
            // MenuItem10
            // 
            this.MenuItem10.Name = "MenuItem10";
            this.MenuItem10.Size = new System.Drawing.Size(152, 22);
            this.MenuItem10.Text = "10%";
            // 
            // MenuItem25
            // 
            this.MenuItem25.Name = "MenuItem25";
            this.MenuItem25.Size = new System.Drawing.Size(152, 22);
            this.MenuItem25.Text = "25%";
            // 
            // MenuItem50
            // 
            this.MenuItem50.Name = "MenuItem50";
            this.MenuItem50.Size = new System.Drawing.Size(152, 22);
            this.MenuItem50.Text = "50%";
            // 
            // MenuItem75
            // 
            this.MenuItem75.Name = "MenuItem75";
            this.MenuItem75.Size = new System.Drawing.Size(152, 22);
            this.MenuItem75.Text = "75%";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(149, 6);
            // 
            // MenuItemActualSize
            // 
            this.MenuItemActualSize.Name = "MenuItemActualSize";
            this.MenuItemActualSize.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.MenuItemActualSize.Size = new System.Drawing.Size(152, 22);
            this.MenuItemActualSize.Text = "100%";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(149, 6);
            // 
            // MenuItem150
            // 
            this.MenuItem150.Name = "MenuItem150";
            this.MenuItem150.Size = new System.Drawing.Size(152, 22);
            this.MenuItem150.Text = "150%";
            // 
            // MenuItem200
            // 
            this.MenuItem200.Name = "MenuItem200";
            this.MenuItem200.Size = new System.Drawing.Size(152, 22);
            this.MenuItem200.Text = "200%";
            // 
            // MenuItem400
            // 
            this.MenuItem400.Name = "MenuItem400";
            this.MenuItem400.Size = new System.Drawing.Size(152, 22);
            this.MenuItem400.Text = "400%";
            // 
            // MenuItem500
            // 
            this.MenuItem500.Name = "MenuItem500";
            this.MenuItem500.Size = new System.Drawing.Size(152, 22);
            this.MenuItem500.Text = "500%";
            // 
            // MenuItemFullScreen
            // 
            this.MenuItemFullScreen.Enabled = false;
            this.MenuItemFullScreen.Name = "MenuItemFullScreen";
            this.MenuItemFullScreen.ShortcutKeyDisplayString = "Enter";
            this.MenuItemFullScreen.Size = new System.Drawing.Size(269, 22);
            this.MenuItemFullScreen.Text = "F&ull Screen";
            // 
            // MenuItemDelete
            // 
            this.MenuItemDelete.Enabled = false;
            this.MenuItemDelete.Name = "MenuItemDelete";
            this.MenuItemDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.MenuItemDelete.Size = new System.Drawing.Size(269, 22);
            this.MenuItemDelete.Text = "&Delete (Clear Display)";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(266, 6);
            // 
            // MenuItemCenterImages
            // 
            this.MenuItemCenterImages.Checked = true;
            this.MenuItemCenterImages.CheckOnClick = true;
            this.MenuItemCenterImages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemCenterImages.Name = "MenuItemCenterImages";
            this.MenuItemCenterImages.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.MenuItemCenterImages.Size = new System.Drawing.Size(269, 22);
            this.MenuItemCenterImages.Text = "&Center Images in Window";
            // 
            // MenuItemFitImages
            // 
            this.MenuItemFitImages.CheckOnClick = true;
            this.MenuItemFitImages.Name = "MenuItemFitImages";
            this.MenuItemFitImages.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.MenuItemFitImages.Size = new System.Drawing.Size(269, 22);
            this.MenuItemFitImages.Text = "Fit Images to &Window";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(266, 6);
            // 
            // MenuItemImageProperties
            // 
            this.MenuItemImageProperties.Enabled = false;
            this.MenuItemImageProperties.Name = "MenuItemImageProperties";
            this.MenuItemImageProperties.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.MenuItemImageProperties.Size = new System.Drawing.Size(269, 22);
            this.MenuItemImageProperties.Text = "Image Pr&operties...";
            // 
            // MenuItemHistogram
            // 
            this.MenuItemHistogram.Enabled = false;
            this.MenuItemHistogram.Name = "MenuItemHistogram";
            this.MenuItemHistogram.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.MenuItemHistogram.Size = new System.Drawing.Size(269, 22);
            this.MenuItemHistogram.Text = "&Histogram...";
            // 
            // MenuItemImageStatistics
            // 
            this.MenuItemImageStatistics.Enabled = false;
            this.MenuItemImageStatistics.Name = "MenuItemImageStatistics";
            this.MenuItemImageStatistics.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.MenuItemImageStatistics.Size = new System.Drawing.Size(269, 22);
            this.MenuItemImageStatistics.Text = "Image &Statistics...";
            // 
            // MenuItemImage
            // 
            this.MenuItemImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemRotateLeft,
            this.MenuItemRotateRight,
            this.MenuItemCustomRotation,
            this.toolStripSeparator6,
            this.MenuItemHorizontalFlip,
            this.MenuItemVerticalFlip,
            this.toolStripMenuItem5,
            this.MenuItemResize,
            this.MenuItemCrop,
            this.MenuItemShrink});
            this.MenuItemImage.Name = "MenuItemImage";
            this.MenuItemImage.Size = new System.Drawing.Size(56, 21);
            this.MenuItemImage.Text = "I&mage";
            this.MenuItemImage.Visible = false;
            // 
            // MenuItemRotateLeft
            // 
            this.MenuItemRotateLeft.Name = "MenuItemRotateLeft";
            this.MenuItemRotateLeft.ShortcutKeyDisplayString = "L";
            this.MenuItemRotateLeft.Size = new System.Drawing.Size(221, 22);
            this.MenuItemRotateLeft.Text = "Rotate &Left";
            // 
            // MenuItemRotateRight
            // 
            this.MenuItemRotateRight.Name = "MenuItemRotateRight";
            this.MenuItemRotateRight.ShortcutKeyDisplayString = "R";
            this.MenuItemRotateRight.Size = new System.Drawing.Size(221, 22);
            this.MenuItemRotateRight.Text = "Rotate &Right";
            // 
            // MenuItemCustomRotation
            // 
            this.MenuItemCustomRotation.Name = "MenuItemCustomRotation";
            this.MenuItemCustomRotation.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.MenuItemCustomRotation.Size = new System.Drawing.Size(221, 22);
            this.MenuItemCustomRotation.Text = "&Custom Rotation...";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(218, 6);
            // 
            // MenuItemHorizontalFlip
            // 
            this.MenuItemHorizontalFlip.Name = "MenuItemHorizontalFlip";
            this.MenuItemHorizontalFlip.ShortcutKeyDisplayString = "";
            this.MenuItemHorizontalFlip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.MenuItemHorizontalFlip.Size = new System.Drawing.Size(221, 22);
            this.MenuItemHorizontalFlip.Text = "&Horizontal Flip";
            // 
            // MenuItemVerticalFlip
            // 
            this.MenuItemVerticalFlip.Name = "MenuItemVerticalFlip";
            this.MenuItemVerticalFlip.ShortcutKeyDisplayString = "";
            this.MenuItemVerticalFlip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.MenuItemVerticalFlip.Size = new System.Drawing.Size(221, 22);
            this.MenuItemVerticalFlip.Text = "&Vertical Flip";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(218, 6);
            // 
            // MenuItemResize
            // 
            this.MenuItemResize.Name = "MenuItemResize";
            this.MenuItemResize.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
            this.MenuItemResize.Size = new System.Drawing.Size(221, 22);
            this.MenuItemResize.Text = "Re&size...";
            // 
            // MenuItemCrop
            // 
            this.MenuItemCrop.CheckOnClick = true;
            this.MenuItemCrop.Name = "MenuItemCrop";
            this.MenuItemCrop.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.MenuItemCrop.Size = new System.Drawing.Size(221, 22);
            this.MenuItemCrop.Text = "Cr&op";
            // 
            // MenuItemShrink
            // 
            this.MenuItemShrink.Name = "MenuItemShrink";
            this.MenuItemShrink.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.MenuItemShrink.Size = new System.Drawing.Size(221, 22);
            this.MenuItemShrink.Text = "Shrin&k...";
            // 
            // MenuItemAdjustments
            // 
            this.MenuItemAdjustments.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemColorFiltering,
            this.MenuItemEucledianColorFiltering,
            this.toolStripSeparator17,
            this.MenuItemChannels,
            this.toolStripSeparator16,
            this.MenuItemBrightness,
            this.MenuItemContrast,
            this.MenuItemSaturation,
            this.MenuItemGammaCorrection,
            this.toolStripSeparator5,
            this.MenuItemHSLFiltering,
            this.MenuItemHueModifier});
            this.MenuItemAdjustments.Name = "MenuItemAdjustments";
            this.MenuItemAdjustments.Size = new System.Drawing.Size(91, 21);
            this.MenuItemAdjustments.Text = "&Adjustments";
            this.MenuItemAdjustments.Visible = false;
            // 
            // MenuItemColorFiltering
            // 
            this.MenuItemColorFiltering.Name = "MenuItemColorFiltering";
            this.MenuItemColorFiltering.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.MenuItemColorFiltering.Size = new System.Drawing.Size(304, 22);
            this.MenuItemColorFiltering.Text = "Color &Filtering...";
            // 
            // MenuItemEucledianColorFiltering
            // 
            this.MenuItemEucledianColorFiltering.Name = "MenuItemEucledianColorFiltering";
            this.MenuItemEucledianColorFiltering.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.MenuItemEucledianColorFiltering.Size = new System.Drawing.Size(304, 22);
            this.MenuItemEucledianColorFiltering.Text = "&Euclidean Color Filtering...";
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(301, 6);
            // 
            // MenuItemChannels
            // 
            this.MenuItemChannels.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemChannelsFiltering,
            this.toolStripSeparator14,
            this.MenuItemExtractRedChannel,
            this.MenuItemExtractGreenChannel,
            this.MenuItemExtractBlueChannel});
            this.MenuItemChannels.Name = "MenuItemChannels";
            this.MenuItemChannels.Size = new System.Drawing.Size(304, 22);
            this.MenuItemChannels.Text = "Cha&nnels";
            // 
            // MenuItemChannelsFiltering
            // 
            this.MenuItemChannelsFiltering.Name = "MenuItemChannelsFiltering";
            this.MenuItemChannelsFiltering.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.MenuItemChannelsFiltering.Size = new System.Drawing.Size(264, 22);
            this.MenuItemChannelsFiltering.Text = "&Channels Filtering...";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(261, 6);
            // 
            // MenuItemExtractRedChannel
            // 
            this.MenuItemExtractRedChannel.Name = "MenuItemExtractRedChannel";
            this.MenuItemExtractRedChannel.Size = new System.Drawing.Size(264, 22);
            this.MenuItemExtractRedChannel.Text = "Extract &Red Channel";
            // 
            // MenuItemExtractGreenChannel
            // 
            this.MenuItemExtractGreenChannel.Name = "MenuItemExtractGreenChannel";
            this.MenuItemExtractGreenChannel.Size = new System.Drawing.Size(264, 22);
            this.MenuItemExtractGreenChannel.Text = "Extract &Green Channel";
            // 
            // MenuItemExtractBlueChannel
            // 
            this.MenuItemExtractBlueChannel.Name = "MenuItemExtractBlueChannel";
            this.MenuItemExtractBlueChannel.Size = new System.Drawing.Size(264, 22);
            this.MenuItemExtractBlueChannel.Text = "Extract &Blue Channel";
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(301, 6);
            // 
            // MenuItemBrightness
            // 
            this.MenuItemBrightness.Name = "MenuItemBrightness";
            this.MenuItemBrightness.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.MenuItemBrightness.Size = new System.Drawing.Size(304, 22);
            this.MenuItemBrightness.Text = "&Brightness...";
            // 
            // MenuItemContrast
            // 
            this.MenuItemContrast.Name = "MenuItemContrast";
            this.MenuItemContrast.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.MenuItemContrast.Size = new System.Drawing.Size(304, 22);
            this.MenuItemContrast.Text = "&Contrast...";
            // 
            // MenuItemSaturation
            // 
            this.MenuItemSaturation.Name = "MenuItemSaturation";
            this.MenuItemSaturation.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MenuItemSaturation.Size = new System.Drawing.Size(304, 22);
            this.MenuItemSaturation.Text = "&Saturation...";
            // 
            // MenuItemGammaCorrection
            // 
            this.MenuItemGammaCorrection.Name = "MenuItemGammaCorrection";
            this.MenuItemGammaCorrection.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.MenuItemGammaCorrection.Size = new System.Drawing.Size(304, 22);
            this.MenuItemGammaCorrection.Text = "&Gamma Correction...";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(301, 6);
            // 
            // MenuItemHSLFiltering
            // 
            this.MenuItemHSLFiltering.Name = "MenuItemHSLFiltering";
            this.MenuItemHSLFiltering.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.MenuItemHSLFiltering.Size = new System.Drawing.Size(304, 22);
            this.MenuItemHSLFiltering.Text = "&HSL Filtering...";
            // 
            // MenuItemHueModifier
            // 
            this.MenuItemHueModifier.Name = "MenuItemHueModifier";
            this.MenuItemHueModifier.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.MenuItemHueModifier.Size = new System.Drawing.Size(304, 22);
            this.MenuItemHueModifier.Text = "Hue &Modifier...";
            // 
            // MenuItemEffects
            // 
            this.MenuItemEffects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemGrayscale,
            this.MenuItemSepia,
            this.MenuItemInvertColors,
            this.toolStripMenuItem3,
            this.MenuItemBlurAndSharpen,
            this.MenuItemColors,
            this.MenuItemBinarization,
            this.MenuItemMorphology,
            this.MenuItemEdgeDetectors,
            this.toolStripSeparator18,
            this.MenuItemAdaptiveSmoothing,
            this.MenuItemConservativeSmoothing,
            this.toolStripSeparator19,
            this.MenuItemPerlinNoise,
            this.toolStripSeparator21,
            this.MenuItemOilPainting,
            this.MenuItemJitter,
            this.MenuItemPixellate,
            this.toolStripSeparator20,
            this.MenuItemMean,
            this.MenuItemMedian});
            this.MenuItemEffects.Name = "MenuItemEffects";
            this.MenuItemEffects.Size = new System.Drawing.Size(58, 21);
            this.MenuItemEffects.Text = "&Effects";
            this.MenuItemEffects.Visible = false;
            // 
            // MenuItemGrayscale
            // 
            this.MenuItemGrayscale.Name = "MenuItemGrayscale";
            this.MenuItemGrayscale.ShortcutKeyDisplayString = "";
            this.MenuItemGrayscale.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.MenuItemGrayscale.Size = new System.Drawing.Size(287, 22);
            this.MenuItemGrayscale.Text = "&Grayscale";
            // 
            // MenuItemSepia
            // 
            this.MenuItemSepia.Name = "MenuItemSepia";
            this.MenuItemSepia.ShortcutKeyDisplayString = "";
            this.MenuItemSepia.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.MenuItemSepia.Size = new System.Drawing.Size(287, 22);
            this.MenuItemSepia.Text = "Sepia &Tone";
            // 
            // MenuItemInvertColors
            // 
            this.MenuItemInvertColors.Name = "MenuItemInvertColors";
            this.MenuItemInvertColors.ShortcutKeyDisplayString = "";
            this.MenuItemInvertColors.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.MenuItemInvertColors.Size = new System.Drawing.Size(287, 22);
            this.MenuItemInvertColors.Text = "&Invert Colors";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(284, 6);
            // 
            // MenuItemBlurAndSharpen
            // 
            this.MenuItemBlurAndSharpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemBlur,
            this.MenuItemSharpen,
            this.toolStripMenuItem18,
            this.MenuItemGaussianBlur,
            this.MenuItemGaussianSharpen});
            this.MenuItemBlurAndSharpen.Name = "MenuItemBlurAndSharpen";
            this.MenuItemBlurAndSharpen.Size = new System.Drawing.Size(287, 22);
            this.MenuItemBlurAndSharpen.Text = "Blur && &Sharpen";
            // 
            // MenuItemBlur
            // 
            this.MenuItemBlur.Name = "MenuItemBlur";
            this.MenuItemBlur.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.MenuItemBlur.Size = new System.Drawing.Size(257, 22);
            this.MenuItemBlur.Text = "&Blur";
            // 
            // MenuItemSharpen
            // 
            this.MenuItemSharpen.Name = "MenuItemSharpen";
            this.MenuItemSharpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.MenuItemSharpen.Size = new System.Drawing.Size(257, 22);
            this.MenuItemSharpen.Text = "&Sharpen";
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(254, 6);
            // 
            // MenuItemGaussianBlur
            // 
            this.MenuItemGaussianBlur.Name = "MenuItemGaussianBlur";
            this.MenuItemGaussianBlur.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.B)));
            this.MenuItemGaussianBlur.Size = new System.Drawing.Size(257, 22);
            this.MenuItemGaussianBlur.Text = "&Gaussian Blur...";
            // 
            // MenuItemGaussianSharpen
            // 
            this.MenuItemGaussianSharpen.Name = "MenuItemGaussianSharpen";
            this.MenuItemGaussianSharpen.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.MenuItemGaussianSharpen.Size = new System.Drawing.Size(257, 22);
            this.MenuItemGaussianSharpen.Text = "G&aussian Sharpen...";
            // 
            // MenuItemColors
            // 
            this.MenuItemColors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemRed,
            this.MenuItemGreen,
            this.MenuItemBlue,
            this.toolStripMenuItem2,
            this.MenuItemCyan,
            this.MenuItemMagenta,
            this.MenuItemYellow,
            this.toolStripSeparator24,
            this.MenuItemRotateRGBChannels});
            this.MenuItemColors.Name = "MenuItemColors";
            this.MenuItemColors.Size = new System.Drawing.Size(287, 22);
            this.MenuItemColors.Text = "&Colors";
            // 
            // MenuItemRed
            // 
            this.MenuItemRed.Name = "MenuItemRed";
            this.MenuItemRed.Size = new System.Drawing.Size(240, 22);
            this.MenuItemRed.Text = "&Red";
            // 
            // MenuItemGreen
            // 
            this.MenuItemGreen.Name = "MenuItemGreen";
            this.MenuItemGreen.Size = new System.Drawing.Size(240, 22);
            this.MenuItemGreen.Text = "Gr&een";
            // 
            // MenuItemBlue
            // 
            this.MenuItemBlue.Name = "MenuItemBlue";
            this.MenuItemBlue.Size = new System.Drawing.Size(240, 22);
            this.MenuItemBlue.Text = "&Blue";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(237, 6);
            // 
            // MenuItemCyan
            // 
            this.MenuItemCyan.Name = "MenuItemCyan";
            this.MenuItemCyan.Size = new System.Drawing.Size(240, 22);
            this.MenuItemCyan.Text = "&Cyan";
            // 
            // MenuItemMagenta
            // 
            this.MenuItemMagenta.Name = "MenuItemMagenta";
            this.MenuItemMagenta.Size = new System.Drawing.Size(240, 22);
            this.MenuItemMagenta.Text = "&Magenta";
            // 
            // MenuItemYellow
            // 
            this.MenuItemYellow.Name = "MenuItemYellow";
            this.MenuItemYellow.Size = new System.Drawing.Size(240, 22);
            this.MenuItemYellow.Text = "&Yellow";
            // 
            // toolStripSeparator24
            // 
            this.toolStripSeparator24.Name = "toolStripSeparator24";
            this.toolStripSeparator24.Size = new System.Drawing.Size(237, 6);
            // 
            // MenuItemRotateRGBChannels
            // 
            this.MenuItemRotateRGBChannels.Name = "MenuItemRotateRGBChannels";
            this.MenuItemRotateRGBChannels.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.MenuItemRotateRGBChannels.Size = new System.Drawing.Size(240, 22);
            this.MenuItemRotateRGBChannels.Text = "Rotate RGB Cha&nnels";
            // 
            // MenuItemBinarization
            // 
            this.MenuItemBinarization.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemThreshold,
            this.toolStripMenuItem15,
            this.MenuItemThresholdWithErrorCarry,
            this.MenuItemOrderedDither,
            this.MenuItemFloydSteinberg,
            this.toolStripMenuItem17,
            this.MenuItemSISThreshold});
            this.MenuItemBinarization.Name = "MenuItemBinarization";
            this.MenuItemBinarization.Size = new System.Drawing.Size(287, 22);
            this.MenuItemBinarization.Text = "&Binarization";
            // 
            // MenuItemThreshold
            // 
            this.MenuItemThreshold.Name = "MenuItemThreshold";
            this.MenuItemThreshold.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
            this.MenuItemThreshold.Size = new System.Drawing.Size(230, 22);
            this.MenuItemThreshold.Text = "&Threshold...";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(227, 6);
            // 
            // MenuItemThresholdWithErrorCarry
            // 
            this.MenuItemThresholdWithErrorCarry.Name = "MenuItemThresholdWithErrorCarry";
            this.MenuItemThresholdWithErrorCarry.Size = new System.Drawing.Size(230, 22);
            this.MenuItemThresholdWithErrorCarry.Text = "Threshold with Error &Carry";
            // 
            // MenuItemOrderedDither
            // 
            this.MenuItemOrderedDither.Name = "MenuItemOrderedDither";
            this.MenuItemOrderedDither.Size = new System.Drawing.Size(230, 22);
            this.MenuItemOrderedDither.Text = "&Ordered Dither";
            // 
            // MenuItemFloydSteinberg
            // 
            this.MenuItemFloydSteinberg.Name = "MenuItemFloydSteinberg";
            this.MenuItemFloydSteinberg.Size = new System.Drawing.Size(230, 22);
            this.MenuItemFloydSteinberg.Text = "&Floyd-Steinberg";
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(227, 6);
            // 
            // MenuItemSISThreshold
            // 
            this.MenuItemSISThreshold.Name = "MenuItemSISThreshold";
            this.MenuItemSISThreshold.Size = new System.Drawing.Size(230, 22);
            this.MenuItemSISThreshold.Text = "SIS Thres&hold";
            // 
            // MenuItemMorphology
            // 
            this.MenuItemMorphology.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemErosion,
            this.MenuItemDilatation,
            this.MenuItemOpening,
            this.MenuItemClosing});
            this.MenuItemMorphology.Name = "MenuItemMorphology";
            this.MenuItemMorphology.Size = new System.Drawing.Size(287, 22);
            this.MenuItemMorphology.Text = "Morp&hology";
            // 
            // MenuItemErosion
            // 
            this.MenuItemErosion.Name = "MenuItemErosion";
            this.MenuItemErosion.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.I)));
            this.MenuItemErosion.Size = new System.Drawing.Size(202, 22);
            this.MenuItemErosion.Text = "&Erosion";
            // 
            // MenuItemDilatation
            // 
            this.MenuItemDilatation.Name = "MenuItemDilatation";
            this.MenuItemDilatation.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.N)));
            this.MenuItemDilatation.Size = new System.Drawing.Size(202, 22);
            this.MenuItemDilatation.Text = "&Dilatation";
            // 
            // MenuItemOpening
            // 
            this.MenuItemOpening.Name = "MenuItemOpening";
            this.MenuItemOpening.Size = new System.Drawing.Size(202, 22);
            this.MenuItemOpening.Text = "&Opening";
            // 
            // MenuItemClosing
            // 
            this.MenuItemClosing.Name = "MenuItemClosing";
            this.MenuItemClosing.Size = new System.Drawing.Size(202, 22);
            this.MenuItemClosing.Text = "&Closing";
            // 
            // MenuItemEdgeDetectors
            // 
            this.MenuItemEdgeDetectors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemEdges,
            this.MenuItemHomogenity,
            this.MenuItemDifference,
            this.MenuItemSobel,
            this.MenuItemCanny});
            this.MenuItemEdgeDetectors.Name = "MenuItemEdgeDetectors";
            this.MenuItemEdgeDetectors.Size = new System.Drawing.Size(287, 22);
            this.MenuItemEdgeDetectors.Text = "&Edge Detectors";
            // 
            // MenuItemEdges
            // 
            this.MenuItemEdges.Name = "MenuItemEdges";
            this.MenuItemEdges.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.E)));
            this.MenuItemEdges.Size = new System.Drawing.Size(189, 22);
            this.MenuItemEdges.Text = "&Edges";
            // 
            // MenuItemHomogenity
            // 
            this.MenuItemHomogenity.Name = "MenuItemHomogenity";
            this.MenuItemHomogenity.Size = new System.Drawing.Size(189, 22);
            this.MenuItemHomogenity.Text = "&Homogenity";
            // 
            // MenuItemDifference
            // 
            this.MenuItemDifference.Name = "MenuItemDifference";
            this.MenuItemDifference.Size = new System.Drawing.Size(189, 22);
            this.MenuItemDifference.Text = "&Difference";
            // 
            // MenuItemSobel
            // 
            this.MenuItemSobel.Name = "MenuItemSobel";
            this.MenuItemSobel.Size = new System.Drawing.Size(189, 22);
            this.MenuItemSobel.Text = "&Sobel";
            // 
            // MenuItemCanny
            // 
            this.MenuItemCanny.Name = "MenuItemCanny";
            this.MenuItemCanny.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.MenuItemCanny.Size = new System.Drawing.Size(189, 22);
            this.MenuItemCanny.Text = "&Canny...";
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(284, 6);
            // 
            // MenuItemAdaptiveSmoothing
            // 
            this.MenuItemAdaptiveSmoothing.Name = "MenuItemAdaptiveSmoothing";
            this.MenuItemAdaptiveSmoothing.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
            this.MenuItemAdaptiveSmoothing.Size = new System.Drawing.Size(287, 22);
            this.MenuItemAdaptiveSmoothing.Text = "&Adaptive Smoothing...";
            // 
            // MenuItemConservativeSmoothing
            // 
            this.MenuItemConservativeSmoothing.Name = "MenuItemConservativeSmoothing";
            this.MenuItemConservativeSmoothing.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.H)));
            this.MenuItemConservativeSmoothing.Size = new System.Drawing.Size(287, 22);
            this.MenuItemConservativeSmoothing.Text = "Co&nservative Smoothing";
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(284, 6);
            // 
            // MenuItemPerlinNoise
            // 
            this.MenuItemPerlinNoise.Name = "MenuItemPerlinNoise";
            this.MenuItemPerlinNoise.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.P)));
            this.MenuItemPerlinNoise.Size = new System.Drawing.Size(287, 22);
            this.MenuItemPerlinNoise.Text = "&Perlin Noise...";
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(284, 6);
            // 
            // MenuItemOilPainting
            // 
            this.MenuItemOilPainting.Name = "MenuItemOilPainting";
            this.MenuItemOilPainting.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.O)));
            this.MenuItemOilPainting.Size = new System.Drawing.Size(287, 22);
            this.MenuItemOilPainting.Text = "&Oil Painting...";
            // 
            // MenuItemJitter
            // 
            this.MenuItemJitter.Name = "MenuItemJitter";
            this.MenuItemJitter.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.J)));
            this.MenuItemJitter.Size = new System.Drawing.Size(287, 22);
            this.MenuItemJitter.Text = "&Jitter";
            // 
            // MenuItemPixellate
            // 
            this.MenuItemPixellate.Name = "MenuItemPixellate";
            this.MenuItemPixellate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.MenuItemPixellate.Size = new System.Drawing.Size(287, 22);
            this.MenuItemPixellate.Text = "Pi&xellate...";
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(284, 6);
            // 
            // MenuItemMean
            // 
            this.MenuItemMean.Name = "MenuItemMean";
            this.MenuItemMean.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.M)));
            this.MenuItemMean.Size = new System.Drawing.Size(287, 22);
            this.MenuItemMean.Text = "&Mean";
            // 
            // MenuItemMedian
            // 
            this.MenuItemMedian.Name = "MenuItemMedian";
            this.MenuItemMedian.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D)));
            this.MenuItemMedian.Size = new System.Drawing.Size(287, 22);
            this.MenuItemMedian.Text = "Me&dian";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 680);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ToolStripButton toolStripButtonSend;

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveAs;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrintImage;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ToolStripButton ImageProperties;
        private System.Windows.Forms.ToolStripButton toolStripButtonPreviousImage;
        private System.Windows.Forms.ToolStripButton toolStripButtonNextImage;
        private System.Windows.Forms.ToolStripButton toolStripButtonZoomIn;
        private System.Windows.Forms.ToolStripButton toolStripButtonZoomOut;
        private System.Windows.Forms.ToolStripButton toolStripButtonFullScreen;
        private System.Windows.Forms.ToolStripButton toolStripButtonCrop;
        private System.Windows.Forms.ToolStripButton toolStripButtonRotateLeft;
        private System.Windows.Forms.ToolStripButton toolStripButtonRotateRight;
        private System.Windows.Forms.ToolStripButton FlipVertical;
        private System.Windows.Forms.ToolStripButton FlipHorizontal;
        private System.Windows.Forms.ToolStripButton toolStripButtonActualSize;
        private System.Windows.Forms.ToolStripButton toolStripButtonFitImages;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelMousePosition;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelRGB;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelHSL;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Diploma.Controls.DoubleBufferDisplay imageDisplay;
        private System.Drawing.Printing.PrintDocument printImage;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButtonReset;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonBrightness;
        private System.Windows.Forms.ToolStripButton toolStripButtonContrast;
        private System.Windows.Forms.ToolStripButton toolStripButtonColorFiltering;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaturation;
        private System.Windows.Forms.ToolStripButton toolStripButtonHUE;
        private System.Windows.Forms.ToolStripButton toolStripButtonSmooth;
        private System.Windows.Forms.ToolStripButton toolStripButtonResize;
        private System.Windows.Forms.ToolStripButton toolStripButton26;
        private System.Windows.Forms.ToolStripButton toolStripButton27;
        private System.Windows.Forms.ToolStripButton toolStripButtonCustomRotation;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReopen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPrint;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPrintPreview;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPageSetup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCut;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPaste;
        private System.Windows.Forms.ToolStripMenuItem MenuItemView;
        private System.Windows.Forms.ToolStripMenuItem MenuItemShowToolbar;
        private System.Windows.Forms.ToolStripMenuItem MenuItemShowStatusBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNextImage;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPreviousImage;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFirstImage;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLastImage;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRandomImage;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem MenuItemZoom;
        private System.Windows.Forms.ToolStripMenuItem MenuItemZoomIn;
        private System.Windows.Forms.ToolStripMenuItem MenuItemZoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem MenuItem10;
        private System.Windows.Forms.ToolStripMenuItem MenuItem25;
        private System.Windows.Forms.ToolStripMenuItem MenuItem50;
        private System.Windows.Forms.ToolStripMenuItem MenuItem75;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem MenuItemActualSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem MenuItem150;
        private System.Windows.Forms.ToolStripMenuItem MenuItem200;
        private System.Windows.Forms.ToolStripMenuItem MenuItem400;
        private System.Windows.Forms.ToolStripMenuItem MenuItem500;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFullScreen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCenterImages;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFitImages;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem MenuItemImageProperties;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHistogram;
        private System.Windows.Forms.ToolStripMenuItem MenuItemImageStatistics;
        private System.Windows.Forms.ToolStripMenuItem MenuItemImage;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRotateLeft;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRotateRight;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCustomRotation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHorizontalFlip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemVerticalFlip;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem MenuItemResize;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCrop;
        private System.Windows.Forms.ToolStripMenuItem MenuItemShrink;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAdjustments;
        private System.Windows.Forms.ToolStripMenuItem MenuItemColorFiltering;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEucledianColorFiltering;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChannels;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChannelsFiltering;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExtractRedChannel;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExtractGreenChannel;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExtractBlueChannel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripMenuItem MenuItemBrightness;
        private System.Windows.Forms.ToolStripMenuItem MenuItemContrast;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSaturation;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGammaCorrection;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHSLFiltering;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHueModifier;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEffects;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGrayscale;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSepia;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInvertColors;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MenuItemBlurAndSharpen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemBlur;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSharpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGaussianBlur;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGaussianSharpen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemColors;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRed;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGreen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemBlue;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCyan;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMagenta;
        private System.Windows.Forms.ToolStripMenuItem MenuItemYellow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator24;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRotateRGBChannels;
        private System.Windows.Forms.ToolStripMenuItem MenuItemBinarization;
        private System.Windows.Forms.ToolStripMenuItem MenuItemThreshold;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem MenuItemThresholdWithErrorCarry;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOrderedDither;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFloydSteinberg;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSISThreshold;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMorphology;
        private System.Windows.Forms.ToolStripMenuItem MenuItemErosion;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDilatation;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOpening;
        private System.Windows.Forms.ToolStripMenuItem MenuItemClosing;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEdgeDetectors;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEdges;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHomogenity;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDifference;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSobel;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCanny;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAdaptiveSmoothing;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConservativeSmoothing;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPerlinNoise;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOilPainting;
        private System.Windows.Forms.ToolStripMenuItem MenuItemJitter;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPixellate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMean;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMedian;
    }
}