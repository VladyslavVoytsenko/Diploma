namespace Diploma.ImageProcessing
{
    partial class BrightnessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrightnessForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterPreview = new Diploma.Controls.FilterPreview();
            this.label1 = new System.Windows.Forms.Label();
            this.brightnessBox = new System.Windows.Forms.TextBox();
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filterPreview);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // filterPreview
            // 
            this.filterPreview.Image = null;
            resources.ApplyResources(this.filterPreview, "filterPreview");
            this.filterPreview.Name = "filterPreview";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // brightnessBox
            // 
            resources.ApplyResources(this.brightnessBox, "brightnessBox");
            this.brightnessBox.Name = "brightnessBox";
            this.brightnessBox.TextChanged += new System.EventHandler(this.brightnessBox_TextChanged);
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.LargeChange = 1;
            resources.ApplyResources(this.brightnessTrackBar, "brightnessTrackBar");
            this.brightnessTrackBar.Maximum = 250;
            this.brightnessTrackBar.Minimum = -250;
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.TickFrequency = 50;
            this.brightnessTrackBar.ValueChanged += new System.EventHandler(this.brightnessTrackBar_ValueChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // BrightnessForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.brightnessTrackBar);
            this.Controls.Add(this.brightnessBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrightnessForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BrightnessForm_MouseDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Diploma.Controls.FilterPreview filterPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox brightnessBox;
        private System.Windows.Forms.TrackBar brightnessTrackBar;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}