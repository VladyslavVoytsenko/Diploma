namespace Diploma.ImageProcessing
{
    partial class CustomRotationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomRotationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.methodCombo = new System.Windows.Forms.ComboBox();
            this.angleBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.blueBox = new System.Windows.Forms.TextBox();
            this.greenBox = new System.Windows.Forms.TextBox();
            this.redBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.Button();
            this.coverBox = new System.Windows.Forms.Button();
            this.keepSizeCheck = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // methodCombo
            // 
            this.methodCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodCombo.FormattingEnabled = true;
            this.methodCombo.Items.AddRange(new object[] {
            resources.GetString("methodCombo.Items"),
            resources.GetString("methodCombo.Items1"),
            resources.GetString("methodCombo.Items2")});
            resources.ApplyResources(this.methodCombo, "methodCombo");
            this.methodCombo.Name = "methodCombo";
            // 
            // angleBox
            // 
            this.angleBox.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.angleBox, "angleBox");
            this.angleBox.Name = "angleBox";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blueBox);
            this.groupBox1.Controls.Add(this.greenBox);
            this.groupBox1.Controls.Add(this.redBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.colorBox);
            this.groupBox1.Controls.Add(this.coverBox);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // blueBox
            // 
            resources.ApplyResources(this.blueBox, "blueBox");
            this.blueBox.Name = "blueBox";
            this.blueBox.TextChanged += new System.EventHandler(this.blueBox_TextChanged);
            // 
            // greenBox
            // 
            resources.ApplyResources(this.greenBox, "greenBox");
            this.greenBox.Name = "greenBox";
            this.greenBox.TextChanged += new System.EventHandler(this.greenBox_TextChanged);
            // 
            // redBox
            // 
            resources.ApplyResources(this.redBox, "redBox");
            this.redBox.Name = "redBox";
            this.redBox.TextChanged += new System.EventHandler(this.redBox_TextChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
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
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.Black;
            this.colorBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.colorBox, "colorBox");
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
            this.coverBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.coverBox, "coverBox");
            this.coverBox.Name = "coverBox";
            this.coverBox.UseVisualStyleBackColor = false;
            // 
            // keepSizeCheck
            // 
            resources.ApplyResources(this.keepSizeCheck, "keepSizeCheck");
            this.keepSizeCheck.Name = "keepSizeCheck";
            this.keepSizeCheck.UseVisualStyleBackColor = true;
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
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // CustomRotationForm
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.keepSizeCheck);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.angleBox);
            this.Controls.Add(this.methodCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomRotationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CustomRotationForm_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox methodCombo;
        private System.Windows.Forms.TextBox angleBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox keepSizeCheck;
        private System.Windows.Forms.TextBox blueBox;
        private System.Windows.Forms.TextBox greenBox;
        private System.Windows.Forms.TextBox redBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button colorBox;
        private System.Windows.Forms.Button coverBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}