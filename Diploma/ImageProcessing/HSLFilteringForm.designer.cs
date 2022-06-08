namespace Diploma.ImageProcessing
{
    partial class HslFilteringForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HslFilteringForm));
            this.fillTypeCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.updateLCheck = new System.Windows.Forms.CheckBox();
            this.fillLBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.updateSCheck = new System.Windows.Forms.CheckBox();
            this.fillSBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.updateHCheck = new System.Windows.Forms.CheckBox();
            this.fillHBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.filterPreview = new Diploma.Controls.FilterPreview();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.luminanceSlider = new AForge.Controls.ColorSlider();
            this.maxLBox = new System.Windows.Forms.TextBox();
            this.minLBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saturationSlider = new AForge.Controls.ColorSlider();
            this.maxSBox = new System.Windows.Forms.TextBox();
            this.minSBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxHBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.minHBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.huePicker = new Diploma.Controls.HuePicker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fillTypeCombo
            // 
            this.fillTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fillTypeCombo.Items.AddRange(new object[] {
            resources.GetString("fillTypeCombo.Items"),
            resources.GetString("fillTypeCombo.Items1")});
            resources.ApplyResources(this.fillTypeCombo, "fillTypeCombo");
            this.fillTypeCombo.Name = "fillTypeCombo";
            this.fillTypeCombo.SelectedIndexChanged += new System.EventHandler(this.fillTypeCombo_SelectedIndexChanged);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.updateLCheck);
            this.groupBox4.Controls.Add(this.fillLBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.updateSCheck);
            this.groupBox4.Controls.Add(this.fillSBox);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.updateHCheck);
            this.groupBox4.Controls.Add(this.fillHBox);
            this.groupBox4.Controls.Add(this.label7);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // updateLCheck
            // 
            this.updateLCheck.Checked = true;
            this.updateLCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.updateLCheck, "updateLCheck");
            this.updateLCheck.Name = "updateLCheck";
            this.updateLCheck.CheckedChanged += new System.EventHandler(this.updateLCheck_CheckedChanged);
            // 
            // fillLBox
            // 
            resources.ApplyResources(this.fillLBox, "fillLBox");
            this.fillLBox.Name = "fillLBox";
            this.fillLBox.TextChanged += new System.EventHandler(this.fillLBox_TextChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // updateSCheck
            // 
            this.updateSCheck.Checked = true;
            this.updateSCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.updateSCheck, "updateSCheck");
            this.updateSCheck.Name = "updateSCheck";
            this.updateSCheck.CheckedChanged += new System.EventHandler(this.updateSCheck_CheckedChanged);
            // 
            // fillSBox
            // 
            resources.ApplyResources(this.fillSBox, "fillSBox");
            this.fillSBox.Name = "fillSBox";
            this.fillSBox.TextChanged += new System.EventHandler(this.fillSBox_TextChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // updateHCheck
            // 
            this.updateHCheck.Checked = true;
            this.updateHCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.updateHCheck, "updateHCheck");
            this.updateHCheck.Name = "updateHCheck";
            this.updateHCheck.CheckedChanged += new System.EventHandler(this.updateHCheck_CheckedChanged);
            // 
            // fillHBox
            // 
            resources.ApplyResources(this.fillHBox, "fillHBox");
            this.fillHBox.Name = "fillHBox";
            this.fillHBox.TextChanged += new System.EventHandler(this.fillHBox_TextChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.filterPreview);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // filterPreview
            // 
            this.filterPreview.Image = null;
            resources.ApplyResources(this.filterPreview, "filterPreview");
            this.filterPreview.Name = "filterPreview";
            this.filterPreview.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.luminanceSlider);
            this.groupBox3.Controls.Add(this.maxLBox);
            this.groupBox3.Controls.Add(this.minLBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // luminanceSlider
            // 
            resources.ApplyResources(this.luminanceSlider, "luminanceSlider");
            this.luminanceSlider.Name = "luminanceSlider";
            this.luminanceSlider.Type = AForge.Controls.ColorSlider.ColorSliderType.InnerGradient;
            this.luminanceSlider.ValuesChanged += new System.EventHandler(this.luminanceSlider_ValuesChanged);
            // 
            // maxLBox
            // 
            resources.ApplyResources(this.maxLBox, "maxLBox");
            this.maxLBox.Name = "maxLBox";
            this.maxLBox.TextChanged += new System.EventHandler(this.maxLBox_TextChanged);
            // 
            // minLBox
            // 
            resources.ApplyResources(this.minLBox, "minLBox");
            this.minLBox.Name = "minLBox";
            this.minLBox.TextChanged += new System.EventHandler(this.minLBox_TextChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saturationSlider);
            this.groupBox2.Controls.Add(this.maxSBox);
            this.groupBox2.Controls.Add(this.minSBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // saturationSlider
            // 
            resources.ApplyResources(this.saturationSlider, "saturationSlider");
            this.saturationSlider.Name = "saturationSlider";
            this.saturationSlider.Type = AForge.Controls.ColorSlider.ColorSliderType.InnerGradient;
            this.saturationSlider.ValuesChanged += new System.EventHandler(this.saturationSlider_ValuesChanged);
            // 
            // maxSBox
            // 
            resources.ApplyResources(this.maxSBox, "maxSBox");
            this.maxSBox.Name = "maxSBox";
            this.maxSBox.TextChanged += new System.EventHandler(this.maxSBox_TextChanged);
            // 
            // minSBox
            // 
            resources.ApplyResources(this.minSBox, "minSBox");
            this.minSBox.Name = "minSBox";
            this.minSBox.TextChanged += new System.EventHandler(this.minSBox_TextChanged);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxHBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.minHBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.huePicker);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // maxHBox
            // 
            resources.ApplyResources(this.maxHBox, "maxHBox");
            this.maxHBox.Name = "maxHBox";
            this.maxHBox.TextChanged += new System.EventHandler(this.maxHBox_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // minHBox
            // 
            resources.ApplyResources(this.minHBox, "minHBox");
            this.minHBox.Name = "minHBox";
            this.minHBox.TextChanged += new System.EventHandler(this.minHBox_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // huePicker
            // 
            resources.ApplyResources(this.huePicker, "huePicker");
            this.huePicker.Name = "huePicker";
            this.huePicker.Type = Diploma.Controls.HuePickerType.Region;
            this.huePicker.ValuesChanged += new System.EventHandler(this.huePicker_ValuesChanged);
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
            // HslFilteringForm
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.fillTypeCombo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HslFilteringForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HslFilteringForm_MouseDown);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox fillTypeCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox updateLCheck;
        private System.Windows.Forms.TextBox fillLBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox updateSCheck;
        private System.Windows.Forms.TextBox fillSBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox updateHCheck;
        private System.Windows.Forms.TextBox fillHBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private Diploma.Controls.FilterPreview filterPreview;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox maxLBox;
        private System.Windows.Forms.TextBox minLBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox maxSBox;
        private System.Windows.Forms.TextBox minSBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox maxHBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox minHBox;
        private System.Windows.Forms.Label label1;
        private Diploma.Controls.HuePicker huePicker;
        private AForge.Controls.ColorSlider luminanceSlider;
        private AForge.Controls.ColorSlider saturationSlider;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}