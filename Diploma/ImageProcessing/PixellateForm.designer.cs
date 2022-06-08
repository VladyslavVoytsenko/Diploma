namespace Diploma.ImageProcessing
{
    partial class PixellateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PixellateForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.syncCheck = new System.Windows.Forms.CheckBox();
            this.heightTrackBar = new System.Windows.Forms.TrackBar();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterPreview = new Diploma.Controls.FilterPreview();
            this.widthTrackBar = new System.Windows.Forms.TrackBar();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heightTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthTrackBar)).BeginInit();
            this.SuspendLayout();
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
            // syncCheck
            // 
            this.syncCheck.Checked = true;
            this.syncCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.syncCheck, "syncCheck");
            this.syncCheck.Name = "syncCheck";
            // 
            // heightTrackBar
            // 
            resources.ApplyResources(this.heightTrackBar, "heightTrackBar");
            this.heightTrackBar.Maximum = 32;
            this.heightTrackBar.Minimum = 2;
            this.heightTrackBar.Name = "heightTrackBar";
            this.heightTrackBar.Value = 2;
            this.heightTrackBar.Scroll += new System.EventHandler(this.heightTrackBar_Scroll);
            // 
            // heightBox
            // 
            resources.ApplyResources(this.heightBox, "heightBox");
            this.heightBox.Name = "heightBox";
            this.heightBox.ReadOnly = true;
            this.heightBox.TabStop = false;
            this.heightBox.TextChanged += new System.EventHandler(this.heightBox_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
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
            this.filterPreview.TabStop = false;
            // 
            // widthTrackBar
            // 
            resources.ApplyResources(this.widthTrackBar, "widthTrackBar");
            this.widthTrackBar.Maximum = 32;
            this.widthTrackBar.Minimum = 2;
            this.widthTrackBar.Name = "widthTrackBar";
            this.widthTrackBar.Value = 2;
            this.widthTrackBar.Scroll += new System.EventHandler(this.widthTrackBar_Scroll);
            // 
            // widthBox
            // 
            resources.ApplyResources(this.widthBox, "widthBox");
            this.widthBox.Name = "widthBox";
            this.widthBox.ReadOnly = true;
            this.widthBox.TabStop = false;
            this.widthBox.TextChanged += new System.EventHandler(this.widthBox_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // PixellateForm
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.syncCheck);
            this.Controls.Add(this.heightTrackBar);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.widthTrackBar);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PixellateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PixellateForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.heightTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.widthTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.CheckBox syncCheck;
        private System.Windows.Forms.TrackBar heightTrackBar;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Diploma.Controls.FilterPreview filterPreview;
        private System.Windows.Forms.TrackBar widthTrackBar;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Label label1;
    }
}