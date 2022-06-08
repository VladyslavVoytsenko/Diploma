namespace Diploma.ImageProcessing
{
    partial class ChannelFilteringForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChannelFilteringForm));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterPreview = new Diploma.Controls.FilterPreview();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.redSlider = new AForge.Controls.ColorSlider();
            this.maxRBox = new System.Windows.Forms.TextBox();
            this.fillRBox = new System.Windows.Forms.TextBox();
            this.minRBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.greenSlider = new AForge.Controls.ColorSlider();
            this.fillGBox = new System.Windows.Forms.TextBox();
            this.maxGBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.minGBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fillBBox = new System.Windows.Forms.TextBox();
            this.blueSlider = new AForge.Controls.ColorSlider();
            this.label9 = new System.Windows.Forms.Label();
            this.maxBBox = new System.Windows.Forms.TextBox();
            this.minBBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.redFillTypeCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.greenFillTypeCombo = new System.Windows.Forms.ComboBox();
            this.blueFillTypeCombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
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
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.redSlider);
            this.groupBox2.Controls.Add(this.maxRBox);
            this.groupBox2.Controls.Add(this.fillRBox);
            this.groupBox2.Controls.Add(this.minRBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // redSlider
            // 
            resources.ApplyResources(this.redSlider, "redSlider");
            this.redSlider.EndColor = System.Drawing.Color.Red;
            this.redSlider.Name = "redSlider";
            this.redSlider.TabStop = false;
            this.redSlider.Type = AForge.Controls.ColorSlider.ColorSliderType.InnerGradient;
            this.redSlider.ValuesChanged += new System.EventHandler(this.redSlider_ValuesChanged);
            // 
            // maxRBox
            // 
            resources.ApplyResources(this.maxRBox, "maxRBox");
            this.maxRBox.Name = "maxRBox";
            this.maxRBox.TextChanged += new System.EventHandler(this.maxRBox_TextChanged);
            // 
            // fillRBox
            // 
            resources.ApplyResources(this.fillRBox, "fillRBox");
            this.fillRBox.Name = "fillRBox";
            this.fillRBox.TextChanged += new System.EventHandler(this.fillRBox_TextChanged);
            // 
            // minRBox
            // 
            resources.ApplyResources(this.minRBox, "minRBox");
            this.minRBox.Name = "minRBox";
            this.minRBox.TextChanged += new System.EventHandler(this.minRBox_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.greenSlider);
            this.groupBox3.Controls.Add(this.fillGBox);
            this.groupBox3.Controls.Add(this.maxGBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.minGBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // greenSlider
            // 
            resources.ApplyResources(this.greenSlider, "greenSlider");
            this.greenSlider.EndColor = System.Drawing.Color.Lime;
            this.greenSlider.Name = "greenSlider";
            this.greenSlider.TabStop = false;
            this.greenSlider.Type = AForge.Controls.ColorSlider.ColorSliderType.InnerGradient;
            this.greenSlider.ValuesChanged += new System.EventHandler(this.greenSlider_ValuesChanged);
            // 
            // fillGBox
            // 
            resources.ApplyResources(this.fillGBox, "fillGBox");
            this.fillGBox.Name = "fillGBox";
            this.fillGBox.TextChanged += new System.EventHandler(this.fillGBox_TextChanged);
            // 
            // maxGBox
            // 
            resources.ApplyResources(this.maxGBox, "maxGBox");
            this.maxGBox.Name = "maxGBox";
            this.maxGBox.TextChanged += new System.EventHandler(this.maxGBox_TextChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // minGBox
            // 
            resources.ApplyResources(this.minGBox, "minGBox");
            this.minGBox.Name = "minGBox";
            this.minGBox.TextChanged += new System.EventHandler(this.minGBox_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.fillBBox);
            this.groupBox4.Controls.Add(this.blueSlider);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.maxBBox);
            this.groupBox4.Controls.Add(this.minBBox);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // fillBBox
            // 
            resources.ApplyResources(this.fillBBox, "fillBBox");
            this.fillBBox.Name = "fillBBox";
            this.fillBBox.TextChanged += new System.EventHandler(this.fillBBox_TextChanged);
            // 
            // blueSlider
            // 
            resources.ApplyResources(this.blueSlider, "blueSlider");
            this.blueSlider.EndColor = System.Drawing.Color.Blue;
            this.blueSlider.Name = "blueSlider";
            this.blueSlider.TabStop = false;
            this.blueSlider.Type = AForge.Controls.ColorSlider.ColorSliderType.InnerGradient;
            this.blueSlider.ValuesChanged += new System.EventHandler(this.blueSlider_ValuesChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // maxBBox
            // 
            resources.ApplyResources(this.maxBBox, "maxBBox");
            this.maxBBox.Name = "maxBBox";
            this.maxBBox.TextChanged += new System.EventHandler(this.maxBBox_TextChanged);
            // 
            // minBBox
            // 
            resources.ApplyResources(this.minBBox, "minBBox");
            this.minBBox.Name = "minBBox";
            this.minBBox.TextChanged += new System.EventHandler(this.minBBox_TextChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // redFillTypeCombo
            // 
            resources.ApplyResources(this.redFillTypeCombo, "redFillTypeCombo");
            this.redFillTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.redFillTypeCombo.FormattingEnabled = true;
            this.redFillTypeCombo.Items.AddRange(new object[] {
            resources.GetString("redFillTypeCombo.Items"),
            resources.GetString("redFillTypeCombo.Items1")});
            this.redFillTypeCombo.Name = "redFillTypeCombo";
            this.redFillTypeCombo.SelectedIndexChanged += new System.EventHandler(this.redFillTypeCombo_SelectedIndexChanged);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // greenFillTypeCombo
            // 
            resources.ApplyResources(this.greenFillTypeCombo, "greenFillTypeCombo");
            this.greenFillTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.greenFillTypeCombo.FormattingEnabled = true;
            this.greenFillTypeCombo.Items.AddRange(new object[] {
            resources.GetString("greenFillTypeCombo.Items"),
            resources.GetString("greenFillTypeCombo.Items1")});
            this.greenFillTypeCombo.Name = "greenFillTypeCombo";
            this.greenFillTypeCombo.SelectedIndexChanged += new System.EventHandler(this.greenFillTypeCombo_SelectedIndexChanged);
            // 
            // blueFillTypeCombo
            // 
            resources.ApplyResources(this.blueFillTypeCombo, "blueFillTypeCombo");
            this.blueFillTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blueFillTypeCombo.FormattingEnabled = true;
            this.blueFillTypeCombo.Items.AddRange(new object[] {
            resources.GetString("blueFillTypeCombo.Items"),
            resources.GetString("blueFillTypeCombo.Items1")});
            this.blueFillTypeCombo.Name = "blueFillTypeCombo";
            this.blueFillTypeCombo.SelectedIndexChanged += new System.EventHandler(this.blueFillTypeCombo_SelectedIndexChanged);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // ChannelFilteringForm
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.blueFillTypeCombo);
            this.Controls.Add(this.greenFillTypeCombo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.redFillTypeCombo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChannelFilteringForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChannelFilteringForm_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private Diploma.Controls.FilterPreview filterPreview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox maxRBox;
        private System.Windows.Forms.TextBox minRBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxGBox;
        private System.Windows.Forms.TextBox minGBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maxBBox;
        private System.Windows.Forms.TextBox minBBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fillBBox;
        private System.Windows.Forms.TextBox fillGBox;
        private System.Windows.Forms.TextBox fillRBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private AForge.Controls.ColorSlider redSlider;
        private AForge.Controls.ColorSlider greenSlider;
        private AForge.Controls.ColorSlider blueSlider;
        private System.Windows.Forms.ComboBox redFillTypeCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox greenFillTypeCombo;
        private System.Windows.Forms.ComboBox blueFillTypeCombo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
    }
}