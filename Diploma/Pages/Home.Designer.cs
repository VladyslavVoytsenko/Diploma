using System;
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
        [Obsolete]
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
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.StatusLabelMousePosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelRGB = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelHSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReopen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
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
            this.MenuItemAdjustments = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemColorFiltering = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemChannels = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChannelsFiltering = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemExtractRedChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExtractGreenChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExtractBlueChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemContrast = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemBrightness = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBrightness = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonContrast = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonColorFiltering = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaturation = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHUE = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSmooth = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonResize = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCustomRotation = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPixellate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOilPainting = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGaussianBlur = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHSLFiltering = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPerlinNoise = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imageDisplay = new Diploma.Controls.DoubleBufferDisplay();
            this.printImage = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.toolStrip1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.BackColor = System.Drawing.Color.White;
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
            this.toolStripButtonFitImages});
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // toolStripButtonOpen
            // 
            resources.ApplyResources(this.toolStripButtonOpen, "toolStripButtonOpen");
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSaveAs
            // 
            resources.ApplyResources(this.toolStripButtonSaveAs, "toolStripButtonSaveAs");
            this.toolStripButtonSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveAs.Name = "toolStripButtonSaveAs";
            this.toolStripButtonSaveAs.Click += new System.EventHandler(this.toolStripButtonSaveAs_Click);
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonPrintImage
            // 
            resources.ApplyResources(this.toolStripButtonPrintImage, "toolStripButtonPrintImage");
            this.toolStripButtonPrintImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrintImage.Name = "toolStripButtonPrintImage";
            this.toolStripButtonPrintImage.Click += new System.EventHandler(this.toolStripButtonPrintImage_Click);
            // 
            // toolStripButtonDelete
            // 
            resources.ApplyResources(this.toolStripButtonDelete, "toolStripButtonDelete");
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripButtonUndo
            // 
            resources.ApplyResources(this.toolStripButtonUndo, "toolStripButtonUndo");
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // ImageProperties
            // 
            resources.ApplyResources(this.ImageProperties, "ImageProperties");
            this.ImageProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ImageProperties.Name = "ImageProperties";
            this.ImageProperties.Click += new System.EventHandler(this.ImageProperties_Click);
            // 
            // toolStripButtonPreviousImage
            // 
            resources.ApplyResources(this.toolStripButtonPreviousImage, "toolStripButtonPreviousImage");
            this.toolStripButtonPreviousImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPreviousImage.Name = "toolStripButtonPreviousImage";
            this.toolStripButtonPreviousImage.Click += new System.EventHandler(this.toolStripButtonPreviousImage_Click);
            // 
            // toolStripButtonNextImage
            // 
            resources.ApplyResources(this.toolStripButtonNextImage, "toolStripButtonNextImage");
            this.toolStripButtonNextImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNextImage.Name = "toolStripButtonNextImage";
            this.toolStripButtonNextImage.Click += new System.EventHandler(this.toolStripButtonNextImage_Click);
            // 
            // toolStripButtonZoomIn
            // 
            resources.ApplyResources(this.toolStripButtonZoomIn, "toolStripButtonZoomIn");
            this.toolStripButtonZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoomIn.Name = "toolStripButtonZoomIn";
            this.toolStripButtonZoomIn.Click += new System.EventHandler(this.toolStripButtonZoomIn_Click);
            // 
            // toolStripButtonZoomOut
            // 
            resources.ApplyResources(this.toolStripButtonZoomOut, "toolStripButtonZoomOut");
            this.toolStripButtonZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoomOut.Name = "toolStripButtonZoomOut";
            this.toolStripButtonZoomOut.Click += new System.EventHandler(this.toolStripButtonZoomOut_Click);
            // 
            // toolStripButtonFullScreen
            // 
            resources.ApplyResources(this.toolStripButtonFullScreen, "toolStripButtonFullScreen");
            this.toolStripButtonFullScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFullScreen.Name = "toolStripButtonFullScreen";
            this.toolStripButtonFullScreen.Click += new System.EventHandler(this.toolStripButtonFullScreen_Click);
            // 
            // toolStripButtonCrop
            // 
            resources.ApplyResources(this.toolStripButtonCrop, "toolStripButtonCrop");
            this.toolStripButtonCrop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCrop.Name = "toolStripButtonCrop";
            this.toolStripButtonCrop.Click += new System.EventHandler(this.toolStripButtonCrop_Click);
            // 
            // toolStripButtonRotateLeft
            // 
            resources.ApplyResources(this.toolStripButtonRotateLeft, "toolStripButtonRotateLeft");
            this.toolStripButtonRotateLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRotateLeft.Name = "toolStripButtonRotateLeft";
            this.toolStripButtonRotateLeft.Click += new System.EventHandler(this.toolStripButtonRotateLeft_Click);
            // 
            // toolStripButtonRotateRight
            // 
            resources.ApplyResources(this.toolStripButtonRotateRight, "toolStripButtonRotateRight");
            this.toolStripButtonRotateRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRotateRight.Name = "toolStripButtonRotateRight";
            this.toolStripButtonRotateRight.Click += new System.EventHandler(this.toolStripButtonRotateRight_Click);
            // 
            // FlipVertical
            // 
            resources.ApplyResources(this.FlipVertical, "FlipVertical");
            this.FlipVertical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FlipVertical.Name = "FlipVertical";
            this.FlipVertical.Click += new System.EventHandler(this.FlipVertical_Click);
            // 
            // FlipHorizontal
            // 
            resources.ApplyResources(this.FlipHorizontal, "FlipHorizontal");
            this.FlipHorizontal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FlipHorizontal.Name = "FlipHorizontal";
            this.FlipHorizontal.Click += new System.EventHandler(this.FlipHorizontal_Click);
            // 
            // toolStripButtonActualSize
            // 
            resources.ApplyResources(this.toolStripButtonActualSize, "toolStripButtonActualSize");
            this.toolStripButtonActualSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonActualSize.Name = "toolStripButtonActualSize";
            this.toolStripButtonActualSize.Click += new System.EventHandler(this.toolStripButtonActualSize_Click);
            // 
            // toolStripButtonFitImages
            // 
            resources.ApplyResources(this.toolStripButtonFitImages, "toolStripButtonFitImages");
            this.toolStripButtonFitImages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFitImages.Name = "toolStripButtonFitImages";
            this.toolStripButtonFitImages.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // statusBar
            // 
            resources.ApplyResources(this.statusBar, "statusBar");
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabelMousePosition,
            this.StatusLabelRGB,
            this.StatusLabelHSL});
            this.statusBar.Name = "statusBar";
            this.statusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // StatusLabelMousePosition
            // 
            this.StatusLabelMousePosition.Name = "StatusLabelMousePosition";
            resources.ApplyResources(this.StatusLabelMousePosition, "StatusLabelMousePosition");
            // 
            // StatusLabelRGB
            // 
            this.StatusLabelRGB.Name = "StatusLabelRGB";
            resources.ApplyResources(this.StatusLabelRGB, "StatusLabelRGB");
            // 
            // StatusLabelHSL
            // 
            this.StatusLabelHSL.Name = "StatusLabelHSL";
            resources.ApplyResources(this.StatusLabelHSL, "StatusLabelHSL");
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.mainMenu);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.mainMenu, "mainMenu");
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemEdit,
            this.MenuItemView,
            this.MenuItemImage,
            this.MenuItemAdjustments,
            this.MenuItemEffects});
            this.mainMenu.Name = "mainMenu";
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
            this.toolStripSeparator3,
            this.MenuItemExit});
            this.MenuItemFile.Name = "MenuItemFile";
            resources.ApplyResources(this.MenuItemFile, "MenuItemFile");
            // 
            // MenuItemOpen
            // 
            this.MenuItemOpen.Name = "MenuItemOpen";
            resources.ApplyResources(this.MenuItemOpen, "MenuItemOpen");
            this.MenuItemOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // MenuItemReopen
            // 
            resources.ApplyResources(this.MenuItemReopen, "MenuItemReopen");
            this.MenuItemReopen.Name = "MenuItemReopen";
            this.MenuItemReopen.Click += new System.EventHandler(this.MenuItemReopen_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // MenuItemSave
            // 
            resources.ApplyResources(this.MenuItemSave, "MenuItemSave");
            this.MenuItemSave.Name = "MenuItemSave";
            this.MenuItemSave.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // MenuItemSaveAs
            // 
            resources.ApplyResources(this.MenuItemSaveAs, "MenuItemSaveAs");
            this.MenuItemSaveAs.Name = "MenuItemSaveAs";
            this.MenuItemSaveAs.Click += new System.EventHandler(this.toolStripButtonSaveAs_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // MenuItemPrint
            // 
            resources.ApplyResources(this.MenuItemPrint, "MenuItemPrint");
            this.MenuItemPrint.Name = "MenuItemPrint";
            this.MenuItemPrint.Click += new System.EventHandler(this.toolStripButtonPrintImage_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            resources.ApplyResources(this.MenuItemExit, "MenuItemExit");
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
            resources.ApplyResources(this.MenuItemEdit, "MenuItemEdit");
            // 
            // MenuItemUndo
            // 
            resources.ApplyResources(this.MenuItemUndo, "MenuItemUndo");
            this.MenuItemUndo.Name = "MenuItemUndo";
            this.MenuItemUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // MenuItemCut
            // 
            resources.ApplyResources(this.MenuItemCut, "MenuItemCut");
            this.MenuItemCut.Name = "MenuItemCut";
            this.MenuItemCut.Click += new System.EventHandler(this.MenuItemCut_Click);
            // 
            // MenuItemCopy
            // 
            resources.ApplyResources(this.MenuItemCopy, "MenuItemCopy");
            this.MenuItemCopy.Name = "MenuItemCopy";
            this.MenuItemCopy.Click += new System.EventHandler(this.MenuItemCopy_Click);
            // 
            // MenuItemPaste
            // 
            this.MenuItemPaste.Name = "MenuItemPaste";
            resources.ApplyResources(this.MenuItemPaste, "MenuItemPaste");
            this.MenuItemPaste.Click += new System.EventHandler(this.MenuItemPaste_Click);
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
            this.MenuItemImageProperties});
            this.MenuItemView.Name = "MenuItemView";
            resources.ApplyResources(this.MenuItemView, "MenuItemView");
            // 
            // MenuItemShowToolbar
            // 
            this.MenuItemShowToolbar.Checked = true;
            this.MenuItemShowToolbar.CheckOnClick = true;
            this.MenuItemShowToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemShowToolbar.Name = "MenuItemShowToolbar";
            resources.ApplyResources(this.MenuItemShowToolbar, "MenuItemShowToolbar");
            this.MenuItemShowToolbar.Click += new System.EventHandler(this.MenuItemShowToolbar_Click);
            // 
            // MenuItemShowStatusBar
            // 
            this.MenuItemShowStatusBar.Checked = true;
            this.MenuItemShowStatusBar.CheckOnClick = true;
            this.MenuItemShowStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemShowStatusBar.Name = "MenuItemShowStatusBar";
            resources.ApplyResources(this.MenuItemShowStatusBar, "MenuItemShowStatusBar");
            this.MenuItemShowStatusBar.Click += new System.EventHandler(this.MenuItemShowStatusBar_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // MenuItemNextImage
            // 
            resources.ApplyResources(this.MenuItemNextImage, "MenuItemNextImage");
            this.MenuItemNextImage.Name = "MenuItemNextImage";
            this.MenuItemNextImage.Click += new System.EventHandler(this.toolStripButtonNextImage_Click);
            // 
            // MenuItemPreviousImage
            // 
            resources.ApplyResources(this.MenuItemPreviousImage, "MenuItemPreviousImage");
            this.MenuItemPreviousImage.Name = "MenuItemPreviousImage";
            this.MenuItemPreviousImage.Click += new System.EventHandler(this.toolStripButtonPreviousImage_Click);
            // 
            // MenuItemFirstImage
            // 
            resources.ApplyResources(this.MenuItemFirstImage, "MenuItemFirstImage");
            this.MenuItemFirstImage.Name = "MenuItemFirstImage";
            this.MenuItemFirstImage.Click += new System.EventHandler(this.MenuItemFirstImage_Click);
            // 
            // MenuItemLastImage
            // 
            resources.ApplyResources(this.MenuItemLastImage, "MenuItemLastImage");
            this.MenuItemLastImage.Name = "MenuItemLastImage";
            this.MenuItemLastImage.Click += new System.EventHandler(this.MenuItemLastImage_Click);
            // 
            // MenuItemRandomImage
            // 
            resources.ApplyResources(this.MenuItemRandomImage, "MenuItemRandomImage");
            this.MenuItemRandomImage.Name = "MenuItemRandomImage";
            this.MenuItemRandomImage.Click += new System.EventHandler(this.MenuItemRandomImage_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
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
            resources.ApplyResources(this.MenuItemZoom, "MenuItemZoom");
            this.MenuItemZoom.Name = "MenuItemZoom";
            // 
            // MenuItemZoomIn
            // 
            this.MenuItemZoomIn.Name = "MenuItemZoomIn";
            resources.ApplyResources(this.MenuItemZoomIn, "MenuItemZoomIn");
            this.MenuItemZoomIn.Click += new System.EventHandler(this.toolStripButtonZoomIn_Click);
            // 
            // MenuItemZoomOut
            // 
            this.MenuItemZoomOut.Name = "MenuItemZoomOut";
            resources.ApplyResources(this.MenuItemZoomOut, "MenuItemZoomOut");
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            resources.ApplyResources(this.toolStripSeparator11, "toolStripSeparator11");
            // 
            // MenuItem10
            // 
            this.MenuItem10.Name = "MenuItem10";
            resources.ApplyResources(this.MenuItem10, "MenuItem10");
            this.MenuItem10.Click += new System.EventHandler(this.MenuItem10_Click);
            // 
            // MenuItem25
            // 
            this.MenuItem25.Name = "MenuItem25";
            resources.ApplyResources(this.MenuItem25, "MenuItem25");
            this.MenuItem25.Click += new System.EventHandler(this.MenuItem25_Click);
            // 
            // MenuItem50
            // 
            this.MenuItem50.Name = "MenuItem50";
            resources.ApplyResources(this.MenuItem50, "MenuItem50");
            this.MenuItem50.Click += new System.EventHandler(this.MenuItem50_Click);
            // 
            // MenuItem75
            // 
            this.MenuItem75.Name = "MenuItem75";
            resources.ApplyResources(this.MenuItem75, "MenuItem75");
            this.MenuItem75.Click += new System.EventHandler(this.MenuItem75_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            // 
            // MenuItemActualSize
            // 
            this.MenuItemActualSize.Name = "MenuItemActualSize";
            resources.ApplyResources(this.MenuItemActualSize, "MenuItemActualSize");
            this.MenuItemActualSize.Click += new System.EventHandler(this.MenuItemActualSize_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
            // 
            // MenuItem150
            // 
            this.MenuItem150.Name = "MenuItem150";
            resources.ApplyResources(this.MenuItem150, "MenuItem150");
            this.MenuItem150.Click += new System.EventHandler(this.MenuItem150_Click);
            // 
            // MenuItem200
            // 
            this.MenuItem200.Name = "MenuItem200";
            resources.ApplyResources(this.MenuItem200, "MenuItem200");
            this.MenuItem200.Click += new System.EventHandler(this.MenuItem200_Click);
            // 
            // MenuItem400
            // 
            this.MenuItem400.Name = "MenuItem400";
            resources.ApplyResources(this.MenuItem400, "MenuItem400");
            this.MenuItem400.Click += new System.EventHandler(this.MenuItem400_Click);
            // 
            // MenuItem500
            // 
            this.MenuItem500.Name = "MenuItem500";
            resources.ApplyResources(this.MenuItem500, "MenuItem500");
            this.MenuItem500.Click += new System.EventHandler(this.MenuItem500_Click);
            // 
            // MenuItemFullScreen
            // 
            resources.ApplyResources(this.MenuItemFullScreen, "MenuItemFullScreen");
            this.MenuItemFullScreen.Name = "MenuItemFullScreen";
            this.MenuItemFullScreen.Click += new System.EventHandler(this.toolStripButtonFullScreen_Click);
            // 
            // MenuItemDelete
            // 
            resources.ApplyResources(this.MenuItemDelete, "MenuItemDelete");
            this.MenuItemDelete.Name = "MenuItemDelete";
            this.MenuItemDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
            // 
            // MenuItemCenterImages
            // 
            this.MenuItemCenterImages.Checked = true;
            this.MenuItemCenterImages.CheckOnClick = true;
            this.MenuItemCenterImages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemCenterImages.Name = "MenuItemCenterImages";
            resources.ApplyResources(this.MenuItemCenterImages, "MenuItemCenterImages");
            this.MenuItemCenterImages.Click += new System.EventHandler(this.MenuItemCenterImages_Click);
            // 
            // MenuItemFitImages
            // 
            this.MenuItemFitImages.CheckOnClick = true;
            this.MenuItemFitImages.Name = "MenuItemFitImages";
            resources.ApplyResources(this.MenuItemFitImages, "MenuItemFitImages");
            this.MenuItemFitImages.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // MenuItemImageProperties
            // 
            resources.ApplyResources(this.MenuItemImageProperties, "MenuItemImageProperties");
            this.MenuItemImageProperties.Name = "MenuItemImageProperties";
            this.MenuItemImageProperties.Click += new System.EventHandler(this.ImageProperties_Click);
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
            this.MenuItemCrop});
            this.MenuItemImage.Name = "MenuItemImage";
            resources.ApplyResources(this.MenuItemImage, "MenuItemImage");
            // 
            // MenuItemRotateLeft
            // 
            this.MenuItemRotateLeft.Name = "MenuItemRotateLeft";
            resources.ApplyResources(this.MenuItemRotateLeft, "MenuItemRotateLeft");
            this.MenuItemRotateLeft.Click += new System.EventHandler(this.toolStripButtonRotateLeft_Click);
            // 
            // MenuItemRotateRight
            // 
            this.MenuItemRotateRight.Name = "MenuItemRotateRight";
            resources.ApplyResources(this.MenuItemRotateRight, "MenuItemRotateRight");
            this.MenuItemRotateRight.Click += new System.EventHandler(this.toolStripButtonRotateRight_Click);
            // 
            // MenuItemCustomRotation
            // 
            this.MenuItemCustomRotation.Name = "MenuItemCustomRotation";
            resources.ApplyResources(this.MenuItemCustomRotation, "MenuItemCustomRotation");
            this.MenuItemCustomRotation.Click += new System.EventHandler(this.toolStripButtonCustomRotation_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // MenuItemHorizontalFlip
            // 
            this.MenuItemHorizontalFlip.Name = "MenuItemHorizontalFlip";
            resources.ApplyResources(this.MenuItemHorizontalFlip, "MenuItemHorizontalFlip");
            this.MenuItemHorizontalFlip.Click += new System.EventHandler(this.FlipHorizontal_Click);
            // 
            // MenuItemVerticalFlip
            // 
            this.MenuItemVerticalFlip.Name = "MenuItemVerticalFlip";
            resources.ApplyResources(this.MenuItemVerticalFlip, "MenuItemVerticalFlip");
            this.MenuItemVerticalFlip.Click += new System.EventHandler(this.FlipVertical_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            // 
            // MenuItemResize
            // 
            this.MenuItemResize.Name = "MenuItemResize";
            resources.ApplyResources(this.MenuItemResize, "MenuItemResize");
            this.MenuItemResize.Click += new System.EventHandler(this.toolStripButtonResize_Click);
            // 
            // MenuItemCrop
            // 
            this.MenuItemCrop.CheckOnClick = true;
            this.MenuItemCrop.Name = "MenuItemCrop";
            resources.ApplyResources(this.MenuItemCrop, "MenuItemCrop");
            this.MenuItemCrop.Click += new System.EventHandler(this.toolStripButtonCrop_Click);
            // 
            // MenuItemAdjustments
            // 
            this.MenuItemAdjustments.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemColorFiltering,
            this.toolStripSeparator17,
            this.MenuItemChannels,
            this.toolStripSeparator16,
            this.MenuItemContrast,
            this.MenuItemBrightness,
            this.MenuItemSaturation,
            this.MenuItemGammaCorrection,
            this.toolStripSeparator5,
            this.MenuItemHSLFiltering,
            this.MenuItemHueModifier});
            this.MenuItemAdjustments.Name = "MenuItemAdjustments";
            resources.ApplyResources(this.MenuItemAdjustments, "MenuItemAdjustments");
            // 
            // MenuItemColorFiltering
            // 
            this.MenuItemColorFiltering.Name = "MenuItemColorFiltering";
            resources.ApplyResources(this.MenuItemColorFiltering, "MenuItemColorFiltering");
            this.MenuItemColorFiltering.Click += new System.EventHandler(this.toolStripButtonColorFiltering_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            resources.ApplyResources(this.toolStripSeparator17, "toolStripSeparator17");
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
            resources.ApplyResources(this.MenuItemChannels, "MenuItemChannels");
            // 
            // MenuItemChannelsFiltering
            // 
            this.MenuItemChannelsFiltering.Name = "MenuItemChannelsFiltering";
            resources.ApplyResources(this.MenuItemChannelsFiltering, "MenuItemChannelsFiltering");
            this.MenuItemChannelsFiltering.Click += new System.EventHandler(this.MenuItemChannelsFiltering_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            resources.ApplyResources(this.toolStripSeparator14, "toolStripSeparator14");
            // 
            // MenuItemExtractRedChannel
            // 
            this.MenuItemExtractRedChannel.Name = "MenuItemExtractRedChannel";
            resources.ApplyResources(this.MenuItemExtractRedChannel, "MenuItemExtractRedChannel");
            this.MenuItemExtractRedChannel.Click += new System.EventHandler(this.MenuItemExtractRedChannel_Click);
            // 
            // MenuItemExtractGreenChannel
            // 
            this.MenuItemExtractGreenChannel.Name = "MenuItemExtractGreenChannel";
            resources.ApplyResources(this.MenuItemExtractGreenChannel, "MenuItemExtractGreenChannel");
            this.MenuItemExtractGreenChannel.Click += new System.EventHandler(this.MenuItemExtractGreenChannel_Click);
            // 
            // MenuItemExtractBlueChannel
            // 
            this.MenuItemExtractBlueChannel.Name = "MenuItemExtractBlueChannel";
            resources.ApplyResources(this.MenuItemExtractBlueChannel, "MenuItemExtractBlueChannel");
            this.MenuItemExtractBlueChannel.Click += new System.EventHandler(this.MenuItemExtractBlueChannel_Click);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            resources.ApplyResources(this.toolStripSeparator16, "toolStripSeparator16");
            // 
            // MenuItemContrast
            // 
            this.MenuItemContrast.Name = "MenuItemContrast";
            resources.ApplyResources(this.MenuItemContrast, "MenuItemContrast");
            this.MenuItemContrast.Click += new System.EventHandler(this.toolStripButtonContrast_Click);
            // 
            // MenuItemBrightness
            // 
            this.MenuItemBrightness.Name = "MenuItemBrightness";
            resources.ApplyResources(this.MenuItemBrightness, "MenuItemBrightness");
            this.MenuItemBrightness.Click += new System.EventHandler(this.toolStripButtonBrightness_Click);
            // 
            // MenuItemSaturation
            // 
            this.MenuItemSaturation.Name = "MenuItemSaturation";
            resources.ApplyResources(this.MenuItemSaturation, "MenuItemSaturation");
            this.MenuItemSaturation.Click += new System.EventHandler(this.toolStripButtonSaturation_Click);
            // 
            // MenuItemGammaCorrection
            // 
            this.MenuItemGammaCorrection.Name = "MenuItemGammaCorrection";
            resources.ApplyResources(this.MenuItemGammaCorrection, "MenuItemGammaCorrection");
            this.MenuItemGammaCorrection.Click += new System.EventHandler(this.MenuItemGammaCorrection_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // MenuItemHSLFiltering
            // 
            this.MenuItemHSLFiltering.Name = "MenuItemHSLFiltering";
            resources.ApplyResources(this.MenuItemHSLFiltering, "MenuItemHSLFiltering");
            this.MenuItemHSLFiltering.Click += new System.EventHandler(this.MenuItemHSLFiltering_Click);
            // 
            // MenuItemHueModifier
            // 
            this.MenuItemHueModifier.Name = "MenuItemHueModifier";
            resources.ApplyResources(this.MenuItemHueModifier, "MenuItemHueModifier");
            this.MenuItemHueModifier.Click += new System.EventHandler(this.toolStripButtonHUE_Click);
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
            this.MenuItemPixellate});
            this.MenuItemEffects.Name = "MenuItemEffects";
            resources.ApplyResources(this.MenuItemEffects, "MenuItemEffects");
            // 
            // MenuItemGrayscale
            // 
            this.MenuItemGrayscale.Name = "MenuItemGrayscale";
            resources.ApplyResources(this.MenuItemGrayscale, "MenuItemGrayscale");
            this.MenuItemGrayscale.Click += new System.EventHandler(this.MenuItemGrayscale_Click);
            // 
            // MenuItemSepia
            // 
            this.MenuItemSepia.Name = "MenuItemSepia";
            resources.ApplyResources(this.MenuItemSepia, "MenuItemSepia");
            this.MenuItemSepia.Click += new System.EventHandler(this.MenuItemSepia_Click);
            // 
            // MenuItemInvertColors
            // 
            this.MenuItemInvertColors.Name = "MenuItemInvertColors";
            resources.ApplyResources(this.MenuItemInvertColors, "MenuItemInvertColors");
            this.MenuItemInvertColors.Click += new System.EventHandler(this.MenuItemInvertColors_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
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
            resources.ApplyResources(this.MenuItemBlurAndSharpen, "MenuItemBlurAndSharpen");
            // 
            // MenuItemBlur
            // 
            this.MenuItemBlur.Name = "MenuItemBlur";
            resources.ApplyResources(this.MenuItemBlur, "MenuItemBlur");
            this.MenuItemBlur.Click += new System.EventHandler(this.MenuItemBlur_Click);
            // 
            // MenuItemSharpen
            // 
            this.MenuItemSharpen.Name = "MenuItemSharpen";
            resources.ApplyResources(this.MenuItemSharpen, "MenuItemSharpen");
            this.MenuItemSharpen.Click += new System.EventHandler(this.MenuItemSharpen_Click);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            resources.ApplyResources(this.toolStripMenuItem18, "toolStripMenuItem18");
            // 
            // MenuItemGaussianBlur
            // 
            this.MenuItemGaussianBlur.Name = "MenuItemGaussianBlur";
            resources.ApplyResources(this.MenuItemGaussianBlur, "MenuItemGaussianBlur");
            this.MenuItemGaussianBlur.Click += new System.EventHandler(this.MenuItemGaussianBlur_Click);
            // 
            // MenuItemGaussianSharpen
            // 
            this.MenuItemGaussianSharpen.Name = "MenuItemGaussianSharpen";
            resources.ApplyResources(this.MenuItemGaussianSharpen, "MenuItemGaussianSharpen");
            this.MenuItemGaussianSharpen.Click += new System.EventHandler(this.MenuItemGaussianSharpen_Click);
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
            resources.ApplyResources(this.MenuItemColors, "MenuItemColors");
            // 
            // MenuItemRed
            // 
            this.MenuItemRed.Name = "MenuItemRed";
            resources.ApplyResources(this.MenuItemRed, "MenuItemRed");
            this.MenuItemRed.Click += new System.EventHandler(this.MenuItemRed_Click);
            // 
            // MenuItemGreen
            // 
            this.MenuItemGreen.Name = "MenuItemGreen";
            resources.ApplyResources(this.MenuItemGreen, "MenuItemGreen");
            this.MenuItemGreen.Click += new System.EventHandler(this.MenuItemGreen_Click);
            // 
            // MenuItemBlue
            // 
            this.MenuItemBlue.Name = "MenuItemBlue";
            resources.ApplyResources(this.MenuItemBlue, "MenuItemBlue");
            this.MenuItemBlue.Click += new System.EventHandler(this.MenuItemBlue_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // MenuItemCyan
            // 
            this.MenuItemCyan.Name = "MenuItemCyan";
            resources.ApplyResources(this.MenuItemCyan, "MenuItemCyan");
            this.MenuItemCyan.Click += new System.EventHandler(this.MenuItemCyan_Click);
            // 
            // MenuItemMagenta
            // 
            this.MenuItemMagenta.Name = "MenuItemMagenta";
            resources.ApplyResources(this.MenuItemMagenta, "MenuItemMagenta");
            this.MenuItemMagenta.Click += new System.EventHandler(this.MenuItemMagenta_Click);
            // 
            // MenuItemYellow
            // 
            this.MenuItemYellow.Name = "MenuItemYellow";
            resources.ApplyResources(this.MenuItemYellow, "MenuItemYellow");
            this.MenuItemYellow.Click += new System.EventHandler(this.MenuItemYellow_Click);
            // 
            // toolStripSeparator24
            // 
            this.toolStripSeparator24.Name = "toolStripSeparator24";
            resources.ApplyResources(this.toolStripSeparator24, "toolStripSeparator24");
            // 
            // MenuItemRotateRGBChannels
            // 
            this.MenuItemRotateRGBChannels.Name = "MenuItemRotateRGBChannels";
            resources.ApplyResources(this.MenuItemRotateRGBChannels, "MenuItemRotateRGBChannels");
            this.MenuItemRotateRGBChannels.Click += new System.EventHandler(this.MenuItemRotateRGBChannels_Click);
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
            resources.ApplyResources(this.MenuItemBinarization, "MenuItemBinarization");
            // 
            // MenuItemThreshold
            // 
            this.MenuItemThreshold.Name = "MenuItemThreshold";
            resources.ApplyResources(this.MenuItemThreshold, "MenuItemThreshold");
            this.MenuItemThreshold.Click += new System.EventHandler(this.MenuItemThreshold_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            resources.ApplyResources(this.toolStripMenuItem15, "toolStripMenuItem15");
            // 
            // MenuItemThresholdWithErrorCarry
            // 
            this.MenuItemThresholdWithErrorCarry.Name = "MenuItemThresholdWithErrorCarry";
            resources.ApplyResources(this.MenuItemThresholdWithErrorCarry, "MenuItemThresholdWithErrorCarry");
            this.MenuItemThresholdWithErrorCarry.Click += new System.EventHandler(this.MenuItemThresholdWithErrorCarry_Click);
            // 
            // MenuItemOrderedDither
            // 
            this.MenuItemOrderedDither.Name = "MenuItemOrderedDither";
            resources.ApplyResources(this.MenuItemOrderedDither, "MenuItemOrderedDither");
            this.MenuItemOrderedDither.Click += new System.EventHandler(this.MenuItemOrderedDither_Click);
            // 
            // MenuItemFloydSteinberg
            // 
            this.MenuItemFloydSteinberg.Name = "MenuItemFloydSteinberg";
            resources.ApplyResources(this.MenuItemFloydSteinberg, "MenuItemFloydSteinberg");
            this.MenuItemFloydSteinberg.Click += new System.EventHandler(this.MenuItemFloydSteinberg_Click);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            resources.ApplyResources(this.toolStripMenuItem17, "toolStripMenuItem17");
            // 
            // MenuItemSISThreshold
            // 
            this.MenuItemSISThreshold.Name = "MenuItemSISThreshold";
            resources.ApplyResources(this.MenuItemSISThreshold, "MenuItemSISThreshold");
            this.MenuItemSISThreshold.Click += new System.EventHandler(this.MenuItemSISThreshold_Click);
            // 
            // MenuItemMorphology
            // 
            this.MenuItemMorphology.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemErosion,
            this.MenuItemDilatation,
            this.MenuItemOpening,
            this.MenuItemClosing});
            this.MenuItemMorphology.Name = "MenuItemMorphology";
            resources.ApplyResources(this.MenuItemMorphology, "MenuItemMorphology");
            // 
            // MenuItemErosion
            // 
            this.MenuItemErosion.Name = "MenuItemErosion";
            resources.ApplyResources(this.MenuItemErosion, "MenuItemErosion");
            this.MenuItemErosion.Click += new System.EventHandler(this.MenuItemErosion_Click);
            // 
            // MenuItemDilatation
            // 
            this.MenuItemDilatation.Name = "MenuItemDilatation";
            resources.ApplyResources(this.MenuItemDilatation, "MenuItemDilatation");
            this.MenuItemDilatation.Click += new System.EventHandler(this.MenuItemDilatation_Click);
            // 
            // MenuItemOpening
            // 
            this.MenuItemOpening.Name = "MenuItemOpening";
            resources.ApplyResources(this.MenuItemOpening, "MenuItemOpening");
            this.MenuItemOpening.Click += new System.EventHandler(this.MenuItemOpening_Click);
            // 
            // MenuItemClosing
            // 
            this.MenuItemClosing.Name = "MenuItemClosing";
            resources.ApplyResources(this.MenuItemClosing, "MenuItemClosing");
            this.MenuItemClosing.Click += new System.EventHandler(this.MenuItemClosing_Click);
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
            resources.ApplyResources(this.MenuItemEdgeDetectors, "MenuItemEdgeDetectors");
            // 
            // MenuItemEdges
            // 
            this.MenuItemEdges.Name = "MenuItemEdges";
            resources.ApplyResources(this.MenuItemEdges, "MenuItemEdges");
            this.MenuItemEdges.Click += new System.EventHandler(this.MenuItemEdges_Click);
            // 
            // MenuItemHomogenity
            // 
            this.MenuItemHomogenity.Name = "MenuItemHomogenity";
            resources.ApplyResources(this.MenuItemHomogenity, "MenuItemHomogenity");
            this.MenuItemHomogenity.Click += new System.EventHandler(this.MenuItemHomogenity_Click);
            // 
            // MenuItemDifference
            // 
            this.MenuItemDifference.Name = "MenuItemDifference";
            resources.ApplyResources(this.MenuItemDifference, "MenuItemDifference");
            this.MenuItemDifference.Click += new System.EventHandler(this.MenuItemDifference_Click);
            // 
            // MenuItemSobel
            // 
            this.MenuItemSobel.Name = "MenuItemSobel";
            resources.ApplyResources(this.MenuItemSobel, "MenuItemSobel");
            this.MenuItemSobel.Click += new System.EventHandler(this.MenuItemSobel_Click);
            // 
            // MenuItemCanny
            // 
            this.MenuItemCanny.Name = "MenuItemCanny";
            resources.ApplyResources(this.MenuItemCanny, "MenuItemCanny");
            this.MenuItemCanny.Click += new System.EventHandler(this.MenuItemCanny_Click);
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            resources.ApplyResources(this.toolStripSeparator18, "toolStripSeparator18");
            // 
            // MenuItemAdaptiveSmoothing
            // 
            this.MenuItemAdaptiveSmoothing.Name = "MenuItemAdaptiveSmoothing";
            resources.ApplyResources(this.MenuItemAdaptiveSmoothing, "MenuItemAdaptiveSmoothing");
            this.MenuItemAdaptiveSmoothing.Click += new System.EventHandler(this.toolStripButtonSmooth_Click);
            // 
            // MenuItemConservativeSmoothing
            // 
            this.MenuItemConservativeSmoothing.Name = "MenuItemConservativeSmoothing";
            resources.ApplyResources(this.MenuItemConservativeSmoothing, "MenuItemConservativeSmoothing");
            this.MenuItemConservativeSmoothing.Click += new System.EventHandler(this.MenuItemConservativeSmoothing_Click);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            resources.ApplyResources(this.toolStripSeparator19, "toolStripSeparator19");
            // 
            // MenuItemPerlinNoise
            // 
            this.MenuItemPerlinNoise.Name = "MenuItemPerlinNoise";
            resources.ApplyResources(this.MenuItemPerlinNoise, "MenuItemPerlinNoise");
            this.MenuItemPerlinNoise.Click += new System.EventHandler(this.MenuItemPerlinNoise_Click);
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            resources.ApplyResources(this.toolStripSeparator21, "toolStripSeparator21");
            // 
            // MenuItemOilPainting
            // 
            this.MenuItemOilPainting.Name = "MenuItemOilPainting";
            resources.ApplyResources(this.MenuItemOilPainting, "MenuItemOilPainting");
            this.MenuItemOilPainting.Click += new System.EventHandler(this.MenuItemOilPainting_Click);
            // 
            // MenuItemJitter
            // 
            this.MenuItemJitter.Name = "MenuItemJitter";
            resources.ApplyResources(this.MenuItemJitter, "MenuItemJitter");
            this.MenuItemJitter.Click += new System.EventHandler(this.MenuItemJitter_Click);
            // 
            // MenuItemPixellate
            // 
            this.MenuItemPixellate.Name = "MenuItemPixellate";
            resources.ApplyResources(this.MenuItemPixellate, "MenuItemPixellate");
            this.MenuItemPixellate.Click += new System.EventHandler(this.MenuItemPixellate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip2);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // toolStrip2
            // 
            resources.ApplyResources(this.toolStrip2, "toolStrip2");
            this.toolStrip2.BackColor = System.Drawing.Color.White;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBrightness,
            this.toolStripButtonContrast,
            this.toolStripButtonColorFiltering,
            this.toolStripButtonSaturation,
            this.toolStripButtonHUE,
            this.toolStripButtonSmooth,
            this.toolStripButtonResize,
            this.toolStripButtonCustomRotation,
            this.toolStripButtonPixellate,
            this.toolStripButtonOilPainting,
            this.toolStripButtonGaussianBlur,
            this.toolStripButtonHSLFiltering,
            this.toolStripButtonPerlinNoise});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // toolStripButtonBrightness
            // 
            resources.ApplyResources(this.toolStripButtonBrightness, "toolStripButtonBrightness");
            this.toolStripButtonBrightness.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBrightness.Name = "toolStripButtonBrightness";
            this.toolStripButtonBrightness.Click += new System.EventHandler(this.toolStripButtonBrightness_Click);
            // 
            // toolStripButtonContrast
            // 
            resources.ApplyResources(this.toolStripButtonContrast, "toolStripButtonContrast");
            this.toolStripButtonContrast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonContrast.Name = "toolStripButtonContrast";
            this.toolStripButtonContrast.Click += new System.EventHandler(this.toolStripButtonContrast_Click);
            // 
            // toolStripButtonColorFiltering
            // 
            resources.ApplyResources(this.toolStripButtonColorFiltering, "toolStripButtonColorFiltering");
            this.toolStripButtonColorFiltering.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonColorFiltering.Name = "toolStripButtonColorFiltering";
            this.toolStripButtonColorFiltering.Click += new System.EventHandler(this.toolStripButtonColorFiltering_Click);
            // 
            // toolStripButtonSaturation
            // 
            resources.ApplyResources(this.toolStripButtonSaturation, "toolStripButtonSaturation");
            this.toolStripButtonSaturation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaturation.Name = "toolStripButtonSaturation";
            this.toolStripButtonSaturation.Click += new System.EventHandler(this.toolStripButtonSaturation_Click);
            // 
            // toolStripButtonHUE
            // 
            resources.ApplyResources(this.toolStripButtonHUE, "toolStripButtonHUE");
            this.toolStripButtonHUE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHUE.Name = "toolStripButtonHUE";
            this.toolStripButtonHUE.Click += new System.EventHandler(this.toolStripButtonHUE_Click);
            // 
            // toolStripButtonSmooth
            // 
            resources.ApplyResources(this.toolStripButtonSmooth, "toolStripButtonSmooth");
            this.toolStripButtonSmooth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSmooth.Name = "toolStripButtonSmooth";
            this.toolStripButtonSmooth.Click += new System.EventHandler(this.toolStripButtonSmooth_Click);
            // 
            // toolStripButtonResize
            // 
            resources.ApplyResources(this.toolStripButtonResize, "toolStripButtonResize");
            this.toolStripButtonResize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonResize.Name = "toolStripButtonResize";
            this.toolStripButtonResize.Click += new System.EventHandler(this.toolStripButtonResize_Click);
            // 
            // toolStripButtonCustomRotation
            // 
            resources.ApplyResources(this.toolStripButtonCustomRotation, "toolStripButtonCustomRotation");
            this.toolStripButtonCustomRotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCustomRotation.Name = "toolStripButtonCustomRotation";
            this.toolStripButtonCustomRotation.Click += new System.EventHandler(this.toolStripButtonCustomRotation_Click);
            // 
            // toolStripButtonPixellate
            // 
            resources.ApplyResources(this.toolStripButtonPixellate, "toolStripButtonPixellate");
            this.toolStripButtonPixellate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPixellate.Name = "toolStripButtonPixellate";
            this.toolStripButtonPixellate.Click += new System.EventHandler(this.MenuItemPixellate_Click);
            // 
            // toolStripButtonOilPainting
            // 
            resources.ApplyResources(this.toolStripButtonOilPainting, "toolStripButtonOilPainting");
            this.toolStripButtonOilPainting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOilPainting.Name = "toolStripButtonOilPainting";
            this.toolStripButtonOilPainting.Click += new System.EventHandler(this.MenuItemOilPainting_Click);
            // 
            // toolStripButtonGaussianBlur
            // 
            resources.ApplyResources(this.toolStripButtonGaussianBlur, "toolStripButtonGaussianBlur");
            this.toolStripButtonGaussianBlur.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGaussianBlur.Name = "toolStripButtonGaussianBlur";
            this.toolStripButtonGaussianBlur.Click += new System.EventHandler(this.MenuItemGaussianBlur_Click);
            // 
            // toolStripButtonHSLFiltering
            // 
            resources.ApplyResources(this.toolStripButtonHSLFiltering, "toolStripButtonHSLFiltering");
            this.toolStripButtonHSLFiltering.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHSLFiltering.Name = "toolStripButtonHSLFiltering";
            this.toolStripButtonHSLFiltering.Click += new System.EventHandler(this.MenuItemHSLFiltering_Click);
            // 
            // toolStripButtonPerlinNoise
            // 
            resources.ApplyResources(this.toolStripButtonPerlinNoise, "toolStripButtonPerlinNoise");
            this.toolStripButtonPerlinNoise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPerlinNoise.Name = "toolStripButtonPerlinNoise";
            this.toolStripButtonPerlinNoise.Click += new System.EventHandler(this.MenuItemPerlinNoise_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.imageDisplay);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // imageDisplay
            // 
            this.imageDisplay.BackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.imageDisplay, "imageDisplay");
            this.imageDisplay.Name = "imageDisplay";
            this.imageDisplay.TabStop = false;
            this.imageDisplay.Click += new System.EventHandler(this.imageDisplay_Click);
            this.imageDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.imageDisplay_Paint);
            this.imageDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageDisplay_MouseDown);
            this.imageDisplay.MouseLeave += new System.EventHandler(this.imageDisplay_MouseLeave);
            this.imageDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageDisplay_MouseMove);
            this.imageDisplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageDisplay_MouseUp);
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
            resources.ApplyResources(this.printPreviewDialog, "printPreviewDialog");
            this.printPreviewDialog.Name = "printPreviewDialog";
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

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
        private System.Windows.Forms.StatusStrip statusBar;
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
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonBrightness;
        private System.Windows.Forms.ToolStripButton toolStripButtonContrast;
        private System.Windows.Forms.ToolStripButton toolStripButtonColorFiltering;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaturation;
        private System.Windows.Forms.ToolStripButton toolStripButtonHUE;
        private System.Windows.Forms.ToolStripButton toolStripButtonSmooth;
        private System.Windows.Forms.ToolStripButton toolStripButtonResize;
        private System.Windows.Forms.ToolStripButton toolStripButtonPixellate;
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
        private System.Windows.Forms.ToolStripMenuItem MenuItemAdjustments;
        private System.Windows.Forms.ToolStripMenuItem MenuItemColorFiltering;
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
        private System.Windows.Forms.ToolStripButton toolStripButtonOilPainting;
        private System.Windows.Forms.ToolStripButton toolStripButtonGaussianBlur;
        private System.Windows.Forms.ToolStripButton toolStripButtonHSLFiltering;
        private System.Windows.Forms.ToolStripButton toolStripButtonPerlinNoise;
    }
}