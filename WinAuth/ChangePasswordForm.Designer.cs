﻿namespace WinAuth
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.introLabel = new MetroFramework.Controls.MetroLabel();
            this.machineCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.userCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.passwordCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.passwordField = new MetroFramework.Controls.MetroTextBox();
            this.verifyField = new MetroFramework.Controls.MetroTextBox();
            this.verifyFieldLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordFieldLabel = new MetroFramework.Controls.MetroLabel();
            this.machineLabel = new MetroFramework.Controls.MetroLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.yubikeyBox = new MetroFramework.Controls.MetroCheckBox();
            this.yubiSlotToggle = new MetroFramework.Controls.MetroToggle();
            this.yubiPressToggle = new MetroFramework.Controls.MetroToggle();
            this.yubiSecretUpdateButton = new MetroFramework.Controls.MetroButton();
            this.yubiCreateSecretButton = new MetroFramework.Controls.MetroButton();
            this.yubiSecretField = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.yubikeyStatusLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.yubikeyCheckButton = new MetroFramework.Controls.MetroButton();
            this.yubikeyCreateButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.yubiPanelExistsText = new MetroFramework.Controls.MetroLabel();
            this.yubiPanelIntro = new System.Windows.Forms.Panel();
            this.yubiPanelConfigure = new System.Windows.Forms.Panel();
            this.yubiConfigureIntroLabel = new MetroFramework.Controls.MetroLabel();
            this.yubiPanelExists = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.yubiPanelIntro.SuspendLayout();
            this.yubiPanelConfigure.SuspendLayout();
            this.yubiPanelExists.SuspendLayout();
            this.SuspendLayout();
            // 
            // introLabel
            // 
            this.introLabel.Location = new System.Drawing.Point(23, 60);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(718, 42);
            this.introLabel.TabIndex = 1;
            this.introLabel.Text = "Select how you would like to protect your authenticators. Using a password is str" +
    "ongly recommended, otherwise your data could be read and stolen by malware runni" +
    "ng on your computer.";
            // 
            // machineCheckbox
            // 
            this.machineCheckbox.AutoSize = true;
            this.machineCheckbox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.machineCheckbox.Location = new System.Drawing.Point(43, 349);
            this.machineCheckbox.Name = "machineCheckbox";
            this.machineCheckbox.Size = new System.Drawing.Size(296, 19);
            this.machineCheckbox.TabIndex = 3;
            this.machineCheckbox.Text = "Encrypt to only be useable on this computer";
            this.machineCheckbox.UseSelectable = true;
            this.machineCheckbox.CheckedChanged += new System.EventHandler(this.machineCheckbox_CheckedChanged);
            // 
            // userCheckbox
            // 
            this.userCheckbox.AutoSize = true;
            this.userCheckbox.Enabled = false;
            this.userCheckbox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.userCheckbox.Location = new System.Drawing.Point(64, 380);
            this.userCheckbox.Name = "userCheckbox";
            this.userCheckbox.Size = new System.Drawing.Size(310, 19);
            this.userCheckbox.TabIndex = 4;
            this.userCheckbox.Text = "And only by the current user on this computer";
            this.userCheckbox.UseSelectable = true;
            // 
            // passwordCheckbox
            // 
            this.passwordCheckbox.AutoSize = true;
            this.passwordCheckbox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.passwordCheckbox.Location = new System.Drawing.Point(27, 119);
            this.passwordCheckbox.Name = "passwordCheckbox";
            this.passwordCheckbox.Size = new System.Drawing.Size(214, 19);
            this.passwordCheckbox.TabIndex = 0;
            this.passwordCheckbox.Text = "Protect with my own password";
            this.passwordCheckbox.UseSelectable = true;
            this.passwordCheckbox.CheckedChanged += new System.EventHandler(this.passwordCheckbox_CheckedChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(27, 141);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(714, 50);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = resources.GetString("passwordLabel.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WinAuth.Properties.Resources.BluePixel;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(23, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(723, 1);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::WinAuth.Properties.Resources.BluePixel;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(24, 419);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(723, 1);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(666, 627);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseSelectable = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(585, 627);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseSelectable = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // passwordField
            // 
            this.passwordField.Enabled = false;
            this.passwordField.Location = new System.Drawing.Point(124, 194);
            this.passwordField.MaxLength = 32767;
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '●';
            this.passwordField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordField.SelectedText = "";
            this.passwordField.Size = new System.Drawing.Size(262, 23);
            this.passwordField.TabIndex = 1;
            this.passwordField.UseSelectable = true;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // verifyField
            // 
            this.verifyField.Enabled = false;
            this.verifyField.Location = new System.Drawing.Point(124, 223);
            this.verifyField.MaxLength = 32767;
            this.verifyField.Name = "verifyField";
            this.verifyField.PasswordChar = '●';
            this.verifyField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.verifyField.SelectedText = "";
            this.verifyField.Size = new System.Drawing.Size(262, 23);
            this.verifyField.TabIndex = 2;
            this.verifyField.UseSelectable = true;
            this.verifyField.UseSystemPasswordChar = true;
            // 
            // verifyFieldLabel
            // 
            this.verifyFieldLabel.AutoSize = true;
            this.verifyFieldLabel.Location = new System.Drawing.Point(41, 224);
            this.verifyFieldLabel.Name = "verifyFieldLabel";
            this.verifyFieldLabel.Size = new System.Drawing.Size(41, 19);
            this.verifyFieldLabel.TabIndex = 5;
            this.verifyFieldLabel.Text = "Verify";
            // 
            // passwordFieldLabel
            // 
            this.passwordFieldLabel.AutoSize = true;
            this.passwordFieldLabel.Location = new System.Drawing.Point(41, 195);
            this.passwordFieldLabel.Name = "passwordFieldLabel";
            this.passwordFieldLabel.Size = new System.Drawing.Size(63, 19);
            this.passwordFieldLabel.TabIndex = 5;
            this.passwordFieldLabel.Text = "Password";
            // 
            // machineLabel
            // 
            this.machineLabel.Location = new System.Drawing.Point(23, 275);
            this.machineLabel.Name = "machineLabel";
            this.machineLabel.Size = new System.Drawing.Size(718, 63);
            this.machineLabel.TabIndex = 1;
            this.machineLabel.Text = resources.GetString("machineLabel.Text");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::WinAuth.Properties.Resources.BluePixel;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(24, 614);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(723, 1);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;

            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(78, 43);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(135, 23);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Require button press";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(3, 49);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(42, 23);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Slot";
            // 
            // yubikeyStatusLabel
            // 
            this.yubikeyStatusLabel.Location = new System.Drawing.Point(419, 434);
            this.yubikeyStatusLabel.Name = "yubikeyStatusLabel";
            this.yubikeyStatusLabel.Size = new System.Drawing.Size(322, 27);
            this.yubikeyStatusLabel.TabIndex = 1;
            this.yubikeyStatusLabel.Text = "Status";
            this.yubikeyStatusLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.yubikeyStatusLabel.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(3, 1);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(692, 47);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Your YubiKey must support Challenge-Response using HMAC-SHA1 in one of its slots." +
    " Use the YubiKey personalization tool to configure the slot or click the Configu" +
    "re Slot button.";
            // 
            // yubikeyCheckButton
            // 
            this.yubikeyCheckButton.Location = new System.Drawing.Point(81, 89);
            this.yubikeyCheckButton.Name = "yubikeyCheckButton";
            this.yubikeyCheckButton.Size = new System.Drawing.Size(100, 23);
            this.yubikeyCheckButton.TabIndex = 5;
            this.yubikeyCheckButton.Text = "Use Slot";
            this.yubikeyCheckButton.UseSelectable = true;
            // 
            // yubikeyCreateButton
            // 
            this.yubikeyCreateButton.Location = new System.Drawing.Point(190, 89);
            this.yubikeyCreateButton.Name = "yubikeyCreateButton";
            this.yubikeyCreateButton.Size = new System.Drawing.Size(100, 23);
            this.yubikeyCreateButton.TabIndex = 5;
            this.yubikeyCreateButton.Text = "Configure Slot";
            this.yubikeyCreateButton.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Location = new System.Drawing.Point(-1, 11);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(73, 23);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Passphrase";
            // 
            // yubiPanelExistsText
            // 
            this.yubiPanelExistsText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yubiPanelExistsText.Location = new System.Drawing.Point(14, 16);
            this.yubiPanelExistsText.Name = "yubiPanelExistsText";
            this.yubiPanelExistsText.Size = new System.Drawing.Size(260, 51);
            this.yubiPanelExistsText.TabIndex = 13;
            this.yubiPanelExistsText.Text = "Your YubiKey has already been assigned to protect your authenticators.  To remove" +
    " it you must untick the above checkbox and click OK.";
            // 
            // yubiPanelIntro
            // 
            this.yubiPanelIntro.Controls.Add(this.yubiPanelConfigure);
            this.yubiPanelIntro.Controls.Add(this.yubiConfigureIntroLabel);
            this.yubiPanelIntro.Controls.Add(this.metroLabel1);
            this.yubiPanelIntro.Controls.Add(this.yubiSlotToggle);
            this.yubiPanelIntro.Controls.Add(this.metroLabel3);
            this.yubiPanelIntro.Controls.Add(this.yubikeyCheckButton);
            this.yubiPanelIntro.Controls.Add(this.yubikeyCreateButton);
            this.yubiPanelIntro.Enabled = false;
            this.yubiPanelIntro.Location = new System.Drawing.Point(43, 463);
            this.yubiPanelIntro.Name = "yubiPanelIntro";
            this.yubiPanelIntro.Size = new System.Drawing.Size(698, 149);
            this.yubiPanelIntro.TabIndex = 14;
            // 
            // yubiPanelConfigure
            // 
            this.yubiPanelConfigure.Controls.Add(this.metroLabel4);
            this.yubiPanelConfigure.Controls.Add(this.yubiPressToggle);
            this.yubiPanelConfigure.Controls.Add(this.yubiSecretField);
            this.yubiPanelConfigure.Controls.Add(this.yubiSecretUpdateButton);
            this.yubiPanelConfigure.Controls.Add(this.yubiCreateSecretButton);
            this.yubiPanelConfigure.Controls.Add(this.metroLabel5);
            this.yubiPanelConfigure.Location = new System.Drawing.Point(3, 70);
            this.yubiPanelConfigure.Name = "yubiPanelConfigure";
            this.yubiPanelConfigure.Size = new System.Drawing.Size(692, 76);
            this.yubiPanelConfigure.TabIndex = 12;
            // 
            // yubiConfigureIntroLabel
            // 
            this.yubiConfigureIntroLabel.Location = new System.Drawing.Point(151, 49);
            this.yubiConfigureIntroLabel.Name = "yubiConfigureIntroLabel";
            this.yubiConfigureIntroLabel.Size = new System.Drawing.Size(536, 23);
            this.yubiConfigureIntroLabel.TabIndex = 1;
            this.yubiConfigureIntroLabel.Text = "Enter a pass phrase, or choose Random, then press Update Slot to configure your Y" +
    "ubikey.";
            // 
            // yubiPanelExists
            // 
            this.yubiPanelExists.Controls.Add(this.yubiPanelExistsText);
            this.yubiPanelExists.Location = new System.Drawing.Point(447, 330);
            this.yubiPanelExists.Name = "yubiPanelExists";
            this.yubiPanelExists.Size = new System.Drawing.Size(291, 69);
            this.yubiPanelExists.TabIndex = 15;
            this.yubiPanelExists.Visible = false;
            // 
            // ChangePasswordForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(772, 673);
            this.Controls.Add(this.yubiPanelExists);
            this.Controls.Add(this.yubiPanelIntro);
            this.Controls.Add(this.yubikeyBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.yubikeyStatusLabel);
            this.Controls.Add(this.verifyField);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.verifyFieldLabel);
            this.Controls.Add(this.passwordFieldLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.machineLabel);
            this.Controls.Add(this.passwordCheckbox);
            this.Controls.Add(this.userCheckbox);
            this.Controls.Add(this.machineCheckbox);
            this.Controls.Add(this.introLabel);
            this.Name = "ChangePasswordForm";
            this.Resizable = false;
            this.Text = "Protection";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.Shown += new System.EventHandler(this.ChangePasswordForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.yubiPanelIntro.ResumeLayout(false);
            this.yubiPanelIntro.PerformLayout();
            this.yubiPanelConfigure.ResumeLayout(false);
            this.yubiPanelConfigure.PerformLayout();
            this.yubiPanelExists.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel introLabel;
        private MetroFramework.Controls.MetroCheckBox machineCheckbox;
        private MetroFramework.Controls.MetroCheckBox userCheckbox;
        private MetroFramework.Controls.MetroCheckBox passwordCheckbox;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton okButton;
        private MetroFramework.Controls.MetroTextBox passwordField;
        private MetroFramework.Controls.MetroTextBox verifyField;
        private MetroFramework.Controls.MetroLabel verifyFieldLabel;
        private MetroFramework.Controls.MetroLabel passwordFieldLabel;
        private MetroFramework.Controls.MetroLabel machineLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroCheckBox yubikeyBox;
        private MetroFramework.Controls.MetroLabel yubikeyStatusLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton yubikeyCreateButton;
        private MetroFramework.Controls.MetroButton yubikeyCheckButton;
        private MetroFramework.Controls.MetroTextBox yubiSecretField;
        private MetroFramework.Controls.MetroButton yubiCreateSecretButton;
        private MetroFramework.Controls.MetroButton yubiSecretUpdateButton;
        private MetroFramework.Controls.MetroToggle yubiSlotToggle;
        private MetroFramework.Controls.MetroToggle yubiPressToggle;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel yubiPanelExistsText;
        private System.Windows.Forms.Panel yubiPanelIntro;
        private System.Windows.Forms.Panel yubiPanelConfigure;
        private System.Windows.Forms.Panel yubiPanelExists;
        private MetroFramework.Controls.MetroLabel yubiConfigureIntroLabel;

    }
}