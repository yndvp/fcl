
namespace FitnessCenterLab
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.lineShape1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.personalTrainingRadioButton = new System.Windows.Forms.RadioButton();
            this.membershipRadioButton = new System.Windows.Forms.RadioButton();
            this.juiceBarRadioButton = new System.Windows.Forms.RadioButton();
            this.equipmentRadioButton = new System.Windows.Forms.RadioButton();
            this.clothingRadioButton = new System.Windows.Forms.RadioButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.memberIDLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.imageVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.welcomeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.promotionsTextBox = new System.Windows.Forms.TextBox();
            this.departmentPictureBox = new System.Windows.Forms.PictureBox();
            this.memberIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Haan Baekje B", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(561, 66);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Look Sharp Fitness Center";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lineShape1
            // 
            this.lineShape1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lineShape1.Location = new System.Drawing.Point(15, 64);
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.Size = new System.Drawing.Size(530, 2);
            this.lineShape1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.personalTrainingRadioButton);
            this.groupBox1.Controls.Add(this.membershipRadioButton);
            this.groupBox1.Controls.Add(this.juiceBarRadioButton);
            this.groupBox1.Controls.Add(this.equipmentRadioButton);
            this.groupBox1.Controls.Add(this.clothingRadioButton);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(18, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Department";
            // 
            // personalTrainingRadioButton
            // 
            this.personalTrainingRadioButton.AutoSize = true;
            this.personalTrainingRadioButton.Location = new System.Drawing.Point(16, 172);
            this.personalTrainingRadioButton.Name = "personalTrainingRadioButton";
            this.personalTrainingRadioButton.Size = new System.Drawing.Size(141, 19);
            this.personalTrainingRadioButton.TabIndex = 4;
            this.personalTrainingRadioButton.TabStop = true;
            this.personalTrainingRadioButton.Text = "Personal Training";
            this.personalTrainingRadioButton.UseVisualStyleBackColor = true;
            this.personalTrainingRadioButton.CheckedChanged += new System.EventHandler(this.personalTrainingRadioButton_CheckedChanged);
            // 
            // membershipRadioButton
            // 
            this.membershipRadioButton.AutoSize = true;
            this.membershipRadioButton.Location = new System.Drawing.Point(16, 134);
            this.membershipRadioButton.Name = "membershipRadioButton";
            this.membershipRadioButton.Size = new System.Drawing.Size(106, 19);
            this.membershipRadioButton.TabIndex = 3;
            this.membershipRadioButton.TabStop = true;
            this.membershipRadioButton.Text = "Membership";
            this.membershipRadioButton.UseVisualStyleBackColor = true;
            this.membershipRadioButton.CheckedChanged += new System.EventHandler(this.membershipRadioButton_CheckedChanged);
            // 
            // juiceBarRadioButton
            // 
            this.juiceBarRadioButton.AutoSize = true;
            this.juiceBarRadioButton.Location = new System.Drawing.Point(16, 96);
            this.juiceBarRadioButton.Name = "juiceBarRadioButton";
            this.juiceBarRadioButton.Size = new System.Drawing.Size(88, 19);
            this.juiceBarRadioButton.TabIndex = 2;
            this.juiceBarRadioButton.TabStop = true;
            this.juiceBarRadioButton.Text = "Juice Bar";
            this.juiceBarRadioButton.UseVisualStyleBackColor = true;
            this.juiceBarRadioButton.CheckedChanged += new System.EventHandler(this.juiceBarRadioButton_CheckedChanged);
            // 
            // equipmentRadioButton
            // 
            this.equipmentRadioButton.AutoSize = true;
            this.equipmentRadioButton.Location = new System.Drawing.Point(16, 59);
            this.equipmentRadioButton.Name = "equipmentRadioButton";
            this.equipmentRadioButton.Size = new System.Drawing.Size(192, 19);
            this.equipmentRadioButton.TabIndex = 1;
            this.equipmentRadioButton.TabStop = true;
            this.equipmentRadioButton.Text = "Equipment / Accessories";
            this.equipmentRadioButton.UseVisualStyleBackColor = true;
            this.equipmentRadioButton.CheckedChanged += new System.EventHandler(this.equipmentRadioButton_CheckedChanged);
            // 
            // clothingRadioButton
            // 
            this.clothingRadioButton.AutoSize = true;
            this.clothingRadioButton.Location = new System.Drawing.Point(16, 24);
            this.clothingRadioButton.Name = "clothingRadioButton";
            this.clothingRadioButton.Size = new System.Drawing.Size(81, 19);
            this.clothingRadioButton.TabIndex = 0;
            this.clothingRadioButton.TabStop = true;
            this.clothingRadioButton.Text = "Clothing";
            this.clothingRadioButton.UseVisualStyleBackColor = true;
            this.clothingRadioButton.CheckedChanged += new System.EventHandler(this.clothingRadioButton_CheckedChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(256, 107);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 15);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // memberIDLabel
            // 
            this.memberIDLabel.AutoSize = true;
            this.memberIDLabel.Location = new System.Drawing.Point(256, 149);
            this.memberIDLabel.Name = "memberIDLabel";
            this.memberIDLabel.Size = new System.Drawing.Size(76, 15);
            this.memberIDLabel.TabIndex = 4;
            this.memberIDLabel.Text = "Member ID";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(340, 107);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(205, 25);
            this.nameTextBox.TabIndex = 2;
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(456, 365);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(89, 28);
            this.signInButton.TabIndex = 4;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // printButton
            // 
            this.printButton.Enabled = false;
            this.printButton.Location = new System.Drawing.Point(456, 399);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(89, 28);
            this.printButton.TabIndex = 5;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(456, 433);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(89, 28);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(456, 467);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(89, 28);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(418, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Yunna Jang";
            // 
            // imageVisibleCheckBox
            // 
            this.imageVisibleCheckBox.AutoSize = true;
            this.imageVisibleCheckBox.Enabled = false;
            this.imageVisibleCheckBox.Location = new System.Drawing.Point(18, 524);
            this.imageVisibleCheckBox.Name = "imageVisibleCheckBox";
            this.imageVisibleCheckBox.Size = new System.Drawing.Size(113, 19);
            this.imageVisibleCheckBox.TabIndex = 8;
            this.imageVisibleCheckBox.Text = "Image Visible";
            this.imageVisibleCheckBox.UseVisualStyleBackColor = true;
            this.imageVisibleCheckBox.CheckedChanged += new System.EventHandler(this.imageVisibleCheckBox_CheckedChanged);
            // 
            // welcomeRichTextBox
            // 
            this.welcomeRichTextBox.Location = new System.Drawing.Point(259, 204);
            this.welcomeRichTextBox.Name = "welcomeRichTextBox";
            this.welcomeRichTextBox.Size = new System.Drawing.Size(286, 72);
            this.welcomeRichTextBox.TabIndex = 13;
            this.welcomeRichTextBox.TabStop = false;
            this.welcomeRichTextBox.Text = "";
            this.welcomeRichTextBox.Visible = false;
            // 
            // promotionsTextBox
            // 
            this.promotionsTextBox.Location = new System.Drawing.Point(259, 282);
            this.promotionsTextBox.Name = "promotionsTextBox";
            this.promotionsTextBox.Size = new System.Drawing.Size(286, 25);
            this.promotionsTextBox.TabIndex = 14;
            this.promotionsTextBox.TabStop = false;
            this.promotionsTextBox.Visible = false;
            // 
            // departmentPictureBox
            // 
            this.departmentPictureBox.InitialImage = null;
            this.departmentPictureBox.Location = new System.Drawing.Point(18, 314);
            this.departmentPictureBox.Name = "departmentPictureBox";
            this.departmentPictureBox.Size = new System.Drawing.Size(219, 204);
            this.departmentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.departmentPictureBox.TabIndex = 15;
            this.departmentPictureBox.TabStop = false;
            this.departmentPictureBox.Visible = false;
            // 
            // memberIDMaskedTextBox
            // 
            this.memberIDMaskedTextBox.Location = new System.Drawing.Point(340, 144);
            this.memberIDMaskedTextBox.Mask = "0000";
            this.memberIDMaskedTextBox.Name = "memberIDMaskedTextBox";
            this.memberIDMaskedTextBox.Size = new System.Drawing.Size(39, 25);
            this.memberIDMaskedTextBox.TabIndex = 3;
            this.memberIDMaskedTextBox.ValidatingType = typeof(int);
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 563);
            this.Controls.Add(this.memberIDMaskedTextBox);
            this.Controls.Add(this.departmentPictureBox);
            this.Controls.Add(this.promotionsTextBox);
            this.Controls.Add(this.welcomeRichTextBox);
            this.Controls.Add(this.imageVisibleCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.memberIDLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lineShape1);
            this.Controls.Add(this.titleLabel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIgn In Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label lineShape1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton personalTrainingRadioButton;
        private System.Windows.Forms.RadioButton membershipRadioButton;
        private System.Windows.Forms.RadioButton juiceBarRadioButton;
        private System.Windows.Forms.RadioButton equipmentRadioButton;
        private System.Windows.Forms.RadioButton clothingRadioButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label memberIDLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox imageVisibleCheckBox;
        private System.Windows.Forms.RichTextBox welcomeRichTextBox;
        private System.Windows.Forms.TextBox promotionsTextBox;
        private System.Windows.Forms.PictureBox departmentPictureBox;
        private System.Windows.Forms.MaskedTextBox memberIDMaskedTextBox;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}

