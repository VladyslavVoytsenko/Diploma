using System;
using System.Drawing;
using System.Windows.Forms;

namespace Diploma.ImageProcessing
{
    partial class SaturationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaturationForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.saturationTrackBar = new System.Windows.Forms.TrackBar();
            this.saturationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterPreview = new Diploma.Controls.FilterPreview();
            ((System.ComponentModel.ISupportInitialize)(this.saturationTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // saturationTrackBar
            // 
            resources.ApplyResources(this.saturationTrackBar, "saturationTrackBar");
            this.saturationTrackBar.Maximum = 1000;
            this.saturationTrackBar.Minimum = -1000;
            this.saturationTrackBar.Name = "saturationTrackBar";
            this.saturationTrackBar.TickFrequency = 50;
            this.saturationTrackBar.ValueChanged += new System.EventHandler(this.saturationTrackBar_ValueChanged);
            // 
            // saturationBox
            // 
            resources.ApplyResources(this.saturationBox, "saturationBox");
            this.saturationBox.Name = "saturationBox";
            this.saturationBox.TextChanged += new System.EventHandler(this.saturationBox_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.filterPreview);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // filterPreview
            // 
            resources.ApplyResources(this.filterPreview, "filterPreview");
            this.filterPreview.Image = null;
            this.filterPreview.Name = "filterPreview";
            // 
            // SaturationForm
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.saturationTrackBar);
            this.Controls.Add(this.saturationBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaturationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaturationForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.saturationTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SaturationBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaturationTrackBar_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TrackBar saturationTrackBar;
        private System.Windows.Forms.TextBox saturationBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Diploma.Controls.FilterPreview filterPreview;

        //public Button AcceptButton { get; private set; }
        //public SizeF AutoScaleDimensions { get; private set; }
        //public AutoScaleMode AutoScaleMode { get; private set; }
        //public Button CancelButton { get; private set; }
        //public Size ClientSize { get; private set; }
    }
}