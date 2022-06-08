namespace Diploma.ImageProcessing
{
    partial class ResizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResizeForm));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.methodCombo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.factorButton = new System.Windows.Forms.RadioButton();
            this.factorBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sizeButton = new System.Windows.Forms.RadioButton();
            this.ratioCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.resizeTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // methodCombo
            // 
            resources.ApplyResources(this.methodCombo, "methodCombo");
            this.methodCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodCombo.FormattingEnabled = true;
            this.methodCombo.Items.AddRange(new object[] {
            resources.GetString("methodCombo.Items"),
            resources.GetString("methodCombo.Items1"),
            resources.GetString("methodCombo.Items2")});
            this.methodCombo.Name = "methodCombo";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // factorButton
            // 
            resources.ApplyResources(this.factorButton, "factorButton");
            this.factorButton.Checked = true;
            this.factorButton.Name = "factorButton";
            this.factorButton.TabStop = true;
            this.factorButton.UseVisualStyleBackColor = true;
            this.factorButton.CheckedChanged += new System.EventHandler(this.factorButton_CheckedChanged);
            // 
            // factorBox
            // 
            resources.ApplyResources(this.factorBox, "factorBox");
            this.factorBox.Name = "factorBox";
            this.factorBox.TextChanged += new System.EventHandler(this.factorBox_TextChanged);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // sizeButton
            // 
            resources.ApplyResources(this.sizeButton, "sizeButton");
            this.sizeButton.Name = "sizeButton";
            this.sizeButton.TabStop = true;
            this.sizeButton.UseVisualStyleBackColor = true;
            this.sizeButton.CheckedChanged += new System.EventHandler(this.sizeButton_CheckedChanged);
            // 
            // ratioCheck
            // 
            resources.ApplyResources(this.ratioCheck, "ratioCheck");
            this.ratioCheck.Checked = true;
            this.ratioCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ratioCheck.Name = "ratioCheck";
            this.ratioCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // widthBox
            // 
            resources.ApplyResources(this.widthBox, "widthBox");
            this.widthBox.Name = "widthBox";
            this.widthBox.TextChanged += new System.EventHandler(this.widthBox_TextChanged);
            // 
            // heightBox
            // 
            resources.ApplyResources(this.heightBox, "heightBox");
            this.heightBox.Name = "heightBox";
            this.heightBox.TextChanged += new System.EventHandler(this.heightBox_TextChanged);
            // 
            // resizeTrackBar
            // 
            resources.ApplyResources(this.resizeTrackBar, "resizeTrackBar");
            this.resizeTrackBar.Maximum = 500;
            this.resizeTrackBar.Minimum = 1;
            this.resizeTrackBar.Name = "resizeTrackBar";
            this.resizeTrackBar.TickFrequency = 25;
            this.resizeTrackBar.Value = 200;
            this.resizeTrackBar.ValueChanged += new System.EventHandler(this.resizeTrackBar_ValueChanged);
            // 
            // ResizeForm
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ratioCheck);
            this.Controls.Add(this.sizeButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.factorBox);
            this.Controls.Add(this.factorButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.methodCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.resizeTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResizeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizeForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox methodCombo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton factorButton;
        private System.Windows.Forms.TextBox factorBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton sizeButton;
        private System.Windows.Forms.CheckBox ratioCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TrackBar resizeTrackBar;
    }
}