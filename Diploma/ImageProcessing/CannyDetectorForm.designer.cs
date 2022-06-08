namespace Diploma.ImageProcessing
{
    partial class CannyDetectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CannyDetectorForm));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.filterPreview = new Diploma.Controls.FilterPreview();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.thresholdSlider = new AForge.Controls.ColorSlider();
            this.highThresholdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lowThresholdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sigmaTrackBar = new System.Windows.Forms.TrackBar();
            this.sigmaBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.filterPreview);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // filterPreview
            // 
            this.filterPreview.Image = null;
            resources.ApplyResources(this.filterPreview, "filterPreview");
            this.filterPreview.Name = "filterPreview";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.thresholdSlider);
            this.groupBox2.Controls.Add(this.highThresholdBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lowThresholdBox);
            this.groupBox2.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // thresholdSlider
            // 
            resources.ApplyResources(this.thresholdSlider, "thresholdSlider");
            this.thresholdSlider.Name = "thresholdSlider";
            this.thresholdSlider.ValuesChanged += new System.EventHandler(this.thresholdSlider_ValuesChanged);
            // 
            // highThresholdBox
            // 
            resources.ApplyResources(this.highThresholdBox, "highThresholdBox");
            this.highThresholdBox.Name = "highThresholdBox";
            this.highThresholdBox.TextChanged += new System.EventHandler(this.highThresholdBox_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lowThresholdBox
            // 
            resources.ApplyResources(this.lowThresholdBox, "lowThresholdBox");
            this.lowThresholdBox.Name = "lowThresholdBox";
            this.lowThresholdBox.TextChanged += new System.EventHandler(this.lowThresholdBox_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sigmaTrackBar);
            this.groupBox1.Controls.Add(this.sigmaBox);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // sigmaTrackBar
            // 
            resources.ApplyResources(this.sigmaTrackBar, "sigmaTrackBar");
            this.sigmaTrackBar.Maximum = 40;
            this.sigmaTrackBar.Name = "sigmaTrackBar";
            this.sigmaTrackBar.TickFrequency = 2;
            this.sigmaTrackBar.ValueChanged += new System.EventHandler(this.sigmaTrackBar_ValueChanged);
            // 
            // sigmaBox
            // 
            resources.ApplyResources(this.sigmaBox, "sigmaBox");
            this.sigmaBox.Name = "sigmaBox";
            this.sigmaBox.TextChanged += new System.EventHandler(this.sigmaBox_TextChanged);
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
            // 
            // CannyDetectorForm
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CannyDetectorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CannyDetectorForm_MouseDown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private Diploma.Controls.FilterPreview filterPreview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox highThresholdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lowThresholdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar sigmaTrackBar;
        private System.Windows.Forms.TextBox sigmaBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private AForge.Controls.ColorSlider thresholdSlider;
    }
}