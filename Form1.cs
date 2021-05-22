using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessCenterLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            welcomeRichTextBox.Visible = true;
            welcomeRichTextBox.Text = "Welcome " + nameTextBox.Text + Environment.NewLine + "Member ID " + memberIDMaskedTextBox.Text;
            promotionsTextBox.Visible = true;
            groupBox1.Enabled = true;
            nameLabel.Visible = false;
            nameTextBox.Visible = false;
            memberIDLabel.Visible = false;
            memberIDMaskedTextBox.Visible = false;
            signInButton.Enabled = false;
            printButton.Enabled = true;
            clearButton.Enabled = true;
            imageVisibleCheckBox.Enabled = true;
        }

        private void clothingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            promotionsTextBox.Text = "Offering gym wear";
            departmentPictureBox.Image = FitnessCenterLab.Properties.Resources.clothing;
        }

        private void equipmentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            promotionsTextBox.Text = "20 types of exercise equipment";
            departmentPictureBox.Image = FitnessCenterLab.Properties.Resources.equipment;
        }

        private void juiceBarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            promotionsTextBox.Text = "Free servings of Wheat Berry Shake";
            departmentPictureBox.Image = FitnessCenterLab.Properties.Resources.juicebar;

        }

        private void membershipRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            promotionsTextBox.Text = "Special membership discount";
            departmentPictureBox.Image = FitnessCenterLab.Properties.Resources.membership;
        }

        private void personalTrainingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            promotionsTextBox.Text = "Offering customized personal training";
            departmentPictureBox.Image = FitnessCenterLab.Properties.Resources.pt;
        }

        private void imageVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(imageVisibleCheckBox.Checked)
            {
                departmentPictureBox.Visible = true;
            } else
            {
                departmentPictureBox.Visible = false;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            welcomeRichTextBox.Visible = false;
            welcomeRichTextBox.Text = "";
            promotionsTextBox.Visible = false;
            promotionsTextBox.Text = "";
            groupBox1.Enabled = false;
            clothingRadioButton.Checked = false;
            equipmentRadioButton.Checked = false;
            juiceBarRadioButton.Checked = false;
            membershipRadioButton.Checked = false;
            personalTrainingRadioButton.Checked = false;
            nameLabel.Visible = true;
            nameTextBox.Visible = true;
            nameTextBox.Text = "";
            memberIDLabel.Visible = true;
            memberIDMaskedTextBox.Visible = true;
            memberIDMaskedTextBox.Text = "";
            signInButton.Enabled = true;
            printButton.Enabled = false;
            clearButton.Enabled = false;
            imageVisibleCheckBox.Checked = false;
            imageVisibleCheckBox.Enabled = false;
            departmentPictureBox.Image = null;
            departmentPictureBox.Visible = false; 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }
    }
}
