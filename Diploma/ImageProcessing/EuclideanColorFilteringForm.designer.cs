

namespace Diploma.ImageProcessing
{
    partial class EuclideanColorFilteringForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EuclideanColorFilteringForm));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterPreview = new Diploma.Controls.FilterPreview();
            this.redSlider = new AForge.Controls.ColorSlider();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radiusBox = new System.Windows.Forms.TextBox();
            this.radiusTrackBar = new System.Windows.Forms.TrackBar();
            this.greenSlider = new AForge.Controls.ColorSlider();
            this.blueSlider = new AForge.Controls.ColorSlider();
            this.fillTypeCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.blueBox = new System.Windows.Forms.TextBox();
            this.greenBox = new System.Windows.Forms.TextBox();
            this.redBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.fillBBox = new System.Windows.Forms.TextBox();
            this.fillGBox = new System.Windows.Forms.TextBox();
            this.fillRBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.Button();
            this.coverBox = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusTrackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Name = "okButton";
            this.toolTip.SetToolTip(this.okButton, resources.GetString("okButton.ToolTip"));
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Name = "cancelButton";
            this.toolTip.SetToolTip(this.cancelButton, resources.GetString("cancelButton.ToolTip"));
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.filterPreview);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // filterPreview
            // 
            resources.ApplyResources(this.filterPreview, "filterPreview");
            this.filterPreview.Image = null;
            this.filterPreview.Name = "filterPreview";
            this.toolTip.SetToolTip(this.filterPreview, resources.GetString("filterPreview.ToolTip"));
            // 
            // redSlider
            // 
            resources.ApplyResources(this.redSlider, "redSlider");
            this.redSlider.DoubleArrow = false;
            this.redSlider.EndColor = System.Drawing.Color.Red;
            this.redSlider.Name = "redSlider";
            this.redSlider.TabStop = false;
            this.toolTip.SetToolTip(this.redSlider, resources.GetString("redSlider.ToolTip"));
            this.redSlider.ValuesChanged += new System.EventHandler(this.redSlider_ValuesChanged);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.radiusBox);
            this.groupBox3.Controls.Add(this.radiusTrackBar);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
            // 
            // radiusBox
            // 
            resources.ApplyResources(this.radiusBox, "radiusBox");
            this.radiusBox.Name = "radiusBox";
            this.toolTip.SetToolTip(this.radiusBox, resources.GetString("radiusBox.ToolTip"));
            this.radiusBox.TextChanged += new System.EventHandler(this.radiusBox_TextChanged);
            // 
            // radiusTrackBar
            // 
            resources.ApplyResources(this.radiusTrackBar, "radiusTrackBar");
            this.radiusTrackBar.Maximum = 450;
            this.radiusTrackBar.Minimum = 1;
            this.radiusTrackBar.Name = "radiusTrackBar";
            this.radiusTrackBar.TickFrequency = 10;
            this.toolTip.SetToolTip(this.radiusTrackBar, resources.GetString("radiusTrackBar.ToolTip"));
            this.radiusTrackBar.Value = 100;
            this.radiusTrackBar.Scroll += new System.EventHandler(this.radiusTrackBar_Scroll);
            // 
            // greenSlider
            // 
            resources.ApplyResources(this.greenSlider, "greenSlider");
            this.greenSlider.DoubleArrow = false;
            this.greenSlider.EndColor = System.Drawing.Color.Lime;
            this.greenSlider.Name = "greenSlider";
            this.greenSlider.TabStop = false;
            this.toolTip.SetToolTip(this.greenSlider, resources.GetString("greenSlider.ToolTip"));
            this.greenSlider.ValuesChanged += new System.EventHandler(this.greenSlider_ValuesChanged);
            // 
            // blueSlider
            // 
            resources.ApplyResources(this.blueSlider, "blueSlider");
            this.blueSlider.DoubleArrow = false;
            this.blueSlider.EndColor = System.Drawing.Color.Blue;
            this.blueSlider.Name = "blueSlider";
            this.blueSlider.TabStop = false;
            this.toolTip.SetToolTip(this.blueSlider, resources.GetString("blueSlider.ToolTip"));
            this.blueSlider.ValuesChanged += new System.EventHandler(this.blueSlider_ValuesChanged);
            // 
            // fillTypeCombo
            // 
            resources.ApplyResources(this.fillTypeCombo, "fillTypeCombo");
            this.fillTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fillTypeCombo.FormattingEnabled = true;
            this.fillTypeCombo.Items.AddRange(new object[] {
            resources.GetString("fillTypeCombo.Items"),
            resources.GetString("fillTypeCombo.Items1")});
            this.fillTypeCombo.Name = "fillTypeCombo";
            this.toolTip.SetToolTip(this.fillTypeCombo, resources.GetString("fillTypeCombo.ToolTip"));
            this.fillTypeCombo.SelectedIndexChanged += new System.EventHandler(this.fillTypeCombo_SelectedIndexChanged);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.toolTip.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.blueBox);
            this.groupBox2.Controls.Add(this.blueSlider);
            this.groupBox2.Controls.Add(this.redSlider);
            this.groupBox2.Controls.Add(this.greenBox);
            this.groupBox2.Controls.Add(this.greenSlider);
            this.groupBox2.Controls.Add(this.redBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // blueBox
            // 
            resources.ApplyResources(this.blueBox, "blueBox");
            this.blueBox.Name = "blueBox";
            this.toolTip.SetToolTip(this.blueBox, resources.GetString("blueBox.ToolTip"));
            this.blueBox.TextChanged += new System.EventHandler(this.blueBox_TextChanged);
            // 
            // greenBox
            // 
            resources.ApplyResources(this.greenBox, "greenBox");
            this.greenBox.Name = "greenBox";
            this.toolTip.SetToolTip(this.greenBox, resources.GetString("greenBox.ToolTip"));
            this.greenBox.TextChanged += new System.EventHandler(this.greenBox_TextChanged);
            // 
            // redBox
            // 
            resources.ApplyResources(this.redBox, "redBox");
            this.redBox.Name = "redBox";
            this.toolTip.SetToolTip(this.redBox, resources.GetString("redBox.ToolTip"));
            this.redBox.TextChanged += new System.EventHandler(this.redBox_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.fillBBox);
            this.groupBox5.Controls.Add(this.fillGBox);
            this.groupBox5.Controls.Add(this.fillRBox);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.colorBox);
            this.groupBox5.Controls.Add(this.coverBox);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox5, resources.GetString("groupBox5.ToolTip"));
            // 
            // fillBBox
            // 
            resources.ApplyResources(this.fillBBox, "fillBBox");
            this.fillBBox.Name = "fillBBox";
            this.toolTip.SetToolTip(this.fillBBox, resources.GetString("fillBBox.ToolTip"));
            this.fillBBox.TextChanged += new System.EventHandler(this.fillBox_TextChanged);
            // 
            // fillGBox
            // 
            resources.ApplyResources(this.fillGBox, "fillGBox");
            this.fillGBox.Name = "fillGBox";
            this.toolTip.SetToolTip(this.fillGBox, resources.GetString("fillGBox.ToolTip"));
            this.fillGBox.TextChanged += new System.EventHandler(this.fillBox_TextChanged);
            // 
            // fillRBox
            // 
            resources.ApplyResources(this.fillRBox, "fillRBox");
            this.fillRBox.Name = "fillRBox";
            this.toolTip.SetToolTip(this.fillRBox, resources.GetString("fillRBox.ToolTip"));
            this.fillRBox.TextChanged += new System.EventHandler(this.fillBox_TextChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.toolTip.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.toolTip.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.toolTip.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // colorBox
            // 
            resources.ApplyResources(this.colorBox, "colorBox");
            this.colorBox.BackColor = System.Drawing.Color.Black;
            this.colorBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.colorBox.Name = "colorBox";
            this.toolTip.SetToolTip(this.colorBox, resources.GetString("colorBox.ToolTip"));
            this.colorBox.UseVisualStyleBackColor = false;
            this.colorBox.Click += new System.EventHandler(this.colorBox_Click);
            this.colorBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorBox_MouseClick);
            this.colorBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.colorBox_MouseDown);
            this.colorBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.colorBox_MouseMove);
            this.colorBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.colorBox_MouseUp);
            // 
            // coverBox
            // 
            resources.ApplyResources(this.coverBox, "coverBox");
            this.coverBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.coverBox.Name = "coverBox";
            this.toolTip.SetToolTip(this.coverBox, resources.GetString("coverBox.ToolTip"));
            this.coverBox.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.Name = "button1";
            this.toolTip.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
            this.button1.UseVisualStyleBackColor = false;
            // 
            // EuclideanColorFilteringForm
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fillTypeCombo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EuclideanColorFilteringForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EuclideanColorFilteringForm_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusTrackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private Diploma.Controls.FilterPreview filterPreview;
        private System.Windows.Forms.GroupBox groupBox3;
        private AForge.Controls.ColorSlider redSlider;
        private AForge.Controls.ColorSlider greenSlider;
        private AForge.Controls.ColorSlider blueSlider;
        private System.Windows.Forms.ComboBox fillTypeCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox blueBox;
        private System.Windows.Forms.TextBox greenBox;
        private System.Windows.Forms.TextBox redBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar radiusTrackBar;
        private System.Windows.Forms.TextBox radiusBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox fillBBox;
        private System.Windows.Forms.TextBox fillGBox;
        private System.Windows.Forms.TextBox fillRBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button colorBox;
        private System.Windows.Forms.Button coverBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip;

    }
}