namespace Diploma.ImageProcessing
{
    partial class GaussianBlurForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GaussianBlurForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.filterPreview = new Diploma.Controls.FilterPreview();
            this.sizeTrackBar = new System.Windows.Forms.TrackBar();
            this.sizeBox = new System.Windows.Forms.TextBox();
            this.sigmaBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sigmaTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.filterPreview);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // filterPreview
            // 
            resources.ApplyResources(this.filterPreview, "filterPreview");
            this.filterPreview.Image = null;
            this.filterPreview.Name = "filterPreview";
            // 
            // sizeTrackBar
            // 
            resources.ApplyResources(this.sizeTrackBar, "sizeTrackBar");
            this.sizeTrackBar.LargeChange = 1;
            this.sizeTrackBar.Maximum = 9;
            this.sizeTrackBar.Name = "sizeTrackBar";
            this.sizeTrackBar.Value = 1;
            this.sizeTrackBar.ValueChanged += new System.EventHandler(this.sizeTrackBar_ValueChanged);
            // 
            // sizeBox
            // 
            resources.ApplyResources(this.sizeBox, "sizeBox");
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.TextChanged += new System.EventHandler(this.sizeBox_TextChanged);
            // 
            // sigmaBox
            // 
            resources.ApplyResources(this.sigmaBox, "sigmaBox");
            this.sigmaBox.Name = "sigmaBox";
            this.sigmaBox.TextChanged += new System.EventHandler(this.sigmaBox_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // sigmaTrackBar
            // 
            resources.ApplyResources(this.sigmaTrackBar, "sigmaTrackBar");
            this.sigmaTrackBar.Maximum = 50;
            this.sigmaTrackBar.Name = "sigmaTrackBar";
            this.sigmaTrackBar.TickFrequency = 2;
            this.sigmaTrackBar.ValueChanged += new System.EventHandler(this.sigmaTrackBar_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // GaussianBlurForm
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.sizeTrackBar);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.sigmaBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sigmaTrackBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GaussianBlurForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GaussianBlurForm_MouseDown);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private Diploma.Controls.FilterPreview filterPreview;
        private System.Windows.Forms.TrackBar sizeTrackBar;
        private System.Windows.Forms.TextBox sizeBox;
        private System.Windows.Forms.TextBox sigmaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar sigmaTrackBar;
        private System.Windows.Forms.Label label1;
    }
}