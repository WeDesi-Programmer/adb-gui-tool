namespace ADB_GUI_Tool
{
    partial class MainToolWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainToolWindow));
            this.CmdOutputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.IpAddrTextBox = new System.Windows.Forms.TextBox();
            this.ConnectivityGroupBox = new System.Windows.Forms.GroupBox();
            this.AdbRemountCheckBox = new System.Windows.Forms.CheckBox();
            this.EnRootCheckBox = new System.Windows.Forms.CheckBox();
            this.IpAddrLabel = new System.Windows.Forms.Label();
            this.InstallApkGroupBox = new System.Windows.Forms.GroupBox();
            this.InstallApkResetButton = new System.Windows.Forms.Button();
            this.EnR_CheckBox = new System.Windows.Forms.CheckBox();
            this.EnD_CheckBox = new System.Windows.Forms.CheckBox();
            this.InstallApkButton = new System.Windows.Forms.Button();
            this.SelectedApkLabel = new System.Windows.Forms.Label();
            this.ApkNameLabel = new System.Windows.Forms.Label();
            this.ApkBrowseButton = new System.Windows.Forms.Button();
            this.PushFileGroupBox = new System.Windows.Forms.GroupBox();
            this.PushFileResetButton = new System.Windows.Forms.Button();
            this.PushFilePathLabel = new System.Windows.Forms.Label();
            this.PushFileButton = new System.Windows.Forms.Button();
            this.PushFileBrowseButton = new System.Windows.Forms.Button();
            this.AospPathTextBox = new System.Windows.Forms.TextBox();
            this.FilePushLabel = new System.Windows.Forms.Label();
            this.AospPathLabel = new System.Windows.Forms.Label();
            this.ClearRichTextBoxButton = new System.Windows.Forms.Button();
            this.OverWriteRichTextBoxCheckBox = new System.Windows.Forms.CheckBox();
            this.ConnectivityGroupBox.SuspendLayout();
            this.InstallApkGroupBox.SuspendLayout();
            this.PushFileGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdOutputRichTextBox
            // 
            this.CmdOutputRichTextBox.BackColor = System.Drawing.Color.Black;
            this.CmdOutputRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CmdOutputRichTextBox.ForeColor = System.Drawing.Color.Lime;
            this.CmdOutputRichTextBox.Location = new System.Drawing.Point(425, 12);
            this.CmdOutputRichTextBox.Name = "CmdOutputRichTextBox";
            this.CmdOutputRichTextBox.ReadOnly = true;
            this.CmdOutputRichTextBox.Size = new System.Drawing.Size(363, 426);
            this.CmdOutputRichTextBox.TabIndex = 0;
            this.CmdOutputRichTextBox.TabStop = false;
            this.CmdOutputRichTextBox.Text = "";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Enabled = false;
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ConnectButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConnectButton.Location = new System.Drawing.Point(112, 16);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(82, 39);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // IpAddrTextBox
            // 
            this.IpAddrTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.IpAddrTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IpAddrTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.IpAddrTextBox.Location = new System.Drawing.Point(6, 35);
            this.IpAddrTextBox.Name = "IpAddrTextBox";
            this.IpAddrTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IpAddrTextBox.Size = new System.Drawing.Size(100, 20);
            this.IpAddrTextBox.TabIndex = 1;
            this.IpAddrTextBox.TextChanged += new System.EventHandler(this.IpAddrTextBox_TextChanged);
            // 
            // ConnectivityGroupBox
            // 
            this.ConnectivityGroupBox.Controls.Add(this.AdbRemountCheckBox);
            this.ConnectivityGroupBox.Controls.Add(this.EnRootCheckBox);
            this.ConnectivityGroupBox.Controls.Add(this.IpAddrLabel);
            this.ConnectivityGroupBox.Controls.Add(this.IpAddrTextBox);
            this.ConnectivityGroupBox.Controls.Add(this.ConnectButton);
            this.ConnectivityGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectivityGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConnectivityGroupBox.Location = new System.Drawing.Point(10, 3);
            this.ConnectivityGroupBox.Name = "ConnectivityGroupBox";
            this.ConnectivityGroupBox.Size = new System.Drawing.Size(409, 62);
            this.ConnectivityGroupBox.TabIndex = 3;
            this.ConnectivityGroupBox.TabStop = false;
            this.ConnectivityGroupBox.Text = "Connectivity";
            // 
            // AdbRemountCheckBox
            // 
            this.AdbRemountCheckBox.AutoSize = true;
            this.AdbRemountCheckBox.Enabled = false;
            this.AdbRemountCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdbRemountCheckBox.Location = new System.Drawing.Point(213, 37);
            this.AdbRemountCheckBox.Name = "AdbRemountCheckBox";
            this.AdbRemountCheckBox.Size = new System.Drawing.Size(94, 17);
            this.AdbRemountCheckBox.TabIndex = 5;
            this.AdbRemountCheckBox.Text = "ADB Remount";
            this.AdbRemountCheckBox.UseVisualStyleBackColor = true;
            this.AdbRemountCheckBox.CheckedChanged += new System.EventHandler(this.AdbRemountCheckBox_CheckedChanged);
            // 
            // EnRootCheckBox
            // 
            this.EnRootCheckBox.AutoSize = true;
            this.EnRootCheckBox.Enabled = false;
            this.EnRootCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnRootCheckBox.Location = new System.Drawing.Point(213, 16);
            this.EnRootCheckBox.Name = "EnRootCheckBox";
            this.EnRootCheckBox.Size = new System.Drawing.Size(110, 17);
            this.EnRootCheckBox.TabIndex = 4;
            this.EnRootCheckBox.Text = "Enable ADB Root";
            this.EnRootCheckBox.UseVisualStyleBackColor = true;
            this.EnRootCheckBox.CheckedChanged += new System.EventHandler(this.EnRootCheckBox_CheckedChanged);
            // 
            // IpAddrLabel
            // 
            this.IpAddrLabel.AutoSize = true;
            this.IpAddrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IpAddrLabel.Location = new System.Drawing.Point(7, 16);
            this.IpAddrLabel.Name = "IpAddrLabel";
            this.IpAddrLabel.Size = new System.Drawing.Size(61, 13);
            this.IpAddrLabel.TabIndex = 3;
            this.IpAddrLabel.Text = "IP Address:";
            // 
            // InstallApkGroupBox
            // 
            this.InstallApkGroupBox.Controls.Add(this.InstallApkResetButton);
            this.InstallApkGroupBox.Controls.Add(this.EnR_CheckBox);
            this.InstallApkGroupBox.Controls.Add(this.EnD_CheckBox);
            this.InstallApkGroupBox.Controls.Add(this.InstallApkButton);
            this.InstallApkGroupBox.Controls.Add(this.SelectedApkLabel);
            this.InstallApkGroupBox.Controls.Add(this.ApkNameLabel);
            this.InstallApkGroupBox.Controls.Add(this.ApkBrowseButton);
            this.InstallApkGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallApkGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InstallApkGroupBox.Location = new System.Drawing.Point(10, 72);
            this.InstallApkGroupBox.Name = "InstallApkGroupBox";
            this.InstallApkGroupBox.Size = new System.Drawing.Size(409, 76);
            this.InstallApkGroupBox.TabIndex = 4;
            this.InstallApkGroupBox.TabStop = false;
            this.InstallApkGroupBox.Text = "Install Application";
            // 
            // InstallApkResetButton
            // 
            this.InstallApkResetButton.Enabled = false;
            this.InstallApkResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallApkResetButton.Location = new System.Drawing.Point(87, 19);
            this.InstallApkResetButton.Name = "InstallApkResetButton";
            this.InstallApkResetButton.Size = new System.Drawing.Size(75, 23);
            this.InstallApkResetButton.TabIndex = 7;
            this.InstallApkResetButton.Text = "Reset";
            this.InstallApkResetButton.UseVisualStyleBackColor = true;
            this.InstallApkResetButton.Click += new System.EventHandler(this.InstallApkResetButton_Click);
            // 
            // EnR_CheckBox
            // 
            this.EnR_CheckBox.AutoSize = true;
            this.EnR_CheckBox.Enabled = false;
            this.EnR_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnR_CheckBox.Location = new System.Drawing.Point(269, 23);
            this.EnR_CheckBox.Name = "EnR_CheckBox";
            this.EnR_CheckBox.Size = new System.Drawing.Size(32, 17);
            this.EnR_CheckBox.TabIndex = 5;
            this.EnR_CheckBox.Text = "-r";
            this.EnR_CheckBox.UseVisualStyleBackColor = true;
            this.EnR_CheckBox.CheckedChanged += new System.EventHandler(this.EnR_CheckBox_CheckedChanged);
            // 
            // EnD_CheckBox
            // 
            this.EnD_CheckBox.AutoSize = true;
            this.EnD_CheckBox.Enabled = false;
            this.EnD_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnD_CheckBox.Location = new System.Drawing.Point(226, 23);
            this.EnD_CheckBox.Name = "EnD_CheckBox";
            this.EnD_CheckBox.Size = new System.Drawing.Size(35, 17);
            this.EnD_CheckBox.TabIndex = 4;
            this.EnD_CheckBox.Text = "-d";
            this.EnD_CheckBox.UseVisualStyleBackColor = true;
            this.EnD_CheckBox.CheckedChanged += new System.EventHandler(this.EnD_CheckBox_CheckedChanged);
            // 
            // InstallApkButton
            // 
            this.InstallApkButton.Enabled = false;
            this.InstallApkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallApkButton.Location = new System.Drawing.Point(319, 19);
            this.InstallApkButton.Name = "InstallApkButton";
            this.InstallApkButton.Size = new System.Drawing.Size(75, 23);
            this.InstallApkButton.TabIndex = 3;
            this.InstallApkButton.Text = "INSTALL";
            this.InstallApkButton.UseVisualStyleBackColor = true;
            this.InstallApkButton.Click += new System.EventHandler(this.InstallApkButton_Click);
            // 
            // SelectedApkLabel
            // 
            this.SelectedApkLabel.AutoSize = true;
            this.SelectedApkLabel.Location = new System.Drawing.Point(76, 48);
            this.SelectedApkLabel.Name = "SelectedApkLabel";
            this.SelectedApkLabel.Size = new System.Drawing.Size(0, 13);
            this.SelectedApkLabel.TabIndex = 2;
            // 
            // ApkNameLabel
            // 
            this.ApkNameLabel.AutoSize = true;
            this.ApkNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApkNameLabel.Location = new System.Drawing.Point(10, 49);
            this.ApkNameLabel.Name = "ApkNameLabel";
            this.ApkNameLabel.Size = new System.Drawing.Size(50, 13);
            this.ApkNameLabel.TabIndex = 1;
            this.ApkNameLabel.Text = "APK File:";
            // 
            // ApkBrowseButton
            // 
            this.ApkBrowseButton.Enabled = false;
            this.ApkBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApkBrowseButton.Location = new System.Drawing.Point(6, 19);
            this.ApkBrowseButton.Name = "ApkBrowseButton";
            this.ApkBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.ApkBrowseButton.TabIndex = 0;
            this.ApkBrowseButton.Text = "Browse...";
            this.ApkBrowseButton.UseVisualStyleBackColor = true;
            this.ApkBrowseButton.Click += new System.EventHandler(this.ApkBrowseButton_Click);
            // 
            // PushFileGroupBox
            // 
            this.PushFileGroupBox.Controls.Add(this.PushFileResetButton);
            this.PushFileGroupBox.Controls.Add(this.PushFilePathLabel);
            this.PushFileGroupBox.Controls.Add(this.PushFileButton);
            this.PushFileGroupBox.Controls.Add(this.PushFileBrowseButton);
            this.PushFileGroupBox.Controls.Add(this.AospPathTextBox);
            this.PushFileGroupBox.Controls.Add(this.FilePushLabel);
            this.PushFileGroupBox.Controls.Add(this.AospPathLabel);
            this.PushFileGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PushFileGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PushFileGroupBox.Location = new System.Drawing.Point(10, 155);
            this.PushFileGroupBox.Name = "PushFileGroupBox";
            this.PushFileGroupBox.Size = new System.Drawing.Size(409, 100);
            this.PushFileGroupBox.TabIndex = 5;
            this.PushFileGroupBox.TabStop = false;
            this.PushFileGroupBox.Text = "Push File";
            // 
            // PushFileResetButton
            // 
            this.PushFileResetButton.Enabled = false;
            this.PushFileResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PushFileResetButton.Location = new System.Drawing.Point(6, 71);
            this.PushFileResetButton.Name = "PushFileResetButton";
            this.PushFileResetButton.Size = new System.Drawing.Size(85, 23);
            this.PushFileResetButton.TabIndex = 7;
            this.PushFileResetButton.Text = "Reset";
            this.PushFileResetButton.UseVisualStyleBackColor = true;
            this.PushFileResetButton.Click += new System.EventHandler(this.PushFileResetButton_Click);
            // 
            // PushFilePathLabel
            // 
            this.PushFilePathLabel.AutoSize = true;
            this.PushFilePathLabel.Location = new System.Drawing.Point(76, 46);
            this.PushFilePathLabel.Name = "PushFilePathLabel";
            this.PushFilePathLabel.Size = new System.Drawing.Size(0, 13);
            this.PushFilePathLabel.TabIndex = 6;
            // 
            // PushFileButton
            // 
            this.PushFileButton.Enabled = false;
            this.PushFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PushFileButton.Location = new System.Drawing.Point(309, 70);
            this.PushFileButton.Name = "PushFileButton";
            this.PushFileButton.Size = new System.Drawing.Size(85, 23);
            this.PushFileButton.TabIndex = 4;
            this.PushFileButton.Text = "PUSH";
            this.PushFileButton.UseVisualStyleBackColor = true;
            this.PushFileButton.Click += new System.EventHandler(this.PushFileButton_Click);
            // 
            // PushFileBrowseButton
            // 
            this.PushFileBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PushFileBrowseButton.Location = new System.Drawing.Point(213, 70);
            this.PushFileBrowseButton.Name = "PushFileBrowseButton";
            this.PushFileBrowseButton.Size = new System.Drawing.Size(85, 23);
            this.PushFileBrowseButton.TabIndex = 3;
            this.PushFileBrowseButton.Text = "Browse...";
            this.PushFileBrowseButton.UseVisualStyleBackColor = true;
            this.PushFileBrowseButton.Click += new System.EventHandler(this.PushFileBrowseButton_Click);
            // 
            // AospPathTextBox
            // 
            this.AospPathTextBox.Enabled = false;
            this.AospPathTextBox.Location = new System.Drawing.Point(77, 17);
            this.AospPathTextBox.Name = "AospPathTextBox";
            this.AospPathTextBox.Size = new System.Drawing.Size(317, 20);
            this.AospPathTextBox.TabIndex = 2;
            // 
            // FilePushLabel
            // 
            this.FilePushLabel.AutoSize = true;
            this.FilePushLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilePushLabel.Location = new System.Drawing.Point(12, 46);
            this.FilePushLabel.Name = "FilePushLabel";
            this.FilePushLabel.Size = new System.Drawing.Size(65, 13);
            this.FilePushLabel.TabIndex = 1;
            this.FilePushLabel.Text = "File to Push:";
            // 
            // AospPathLabel
            // 
            this.AospPathLabel.AutoSize = true;
            this.AospPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AospPathLabel.Location = new System.Drawing.Point(12, 20);
            this.AospPathLabel.Name = "AospPathLabel";
            this.AospPathLabel.Size = new System.Drawing.Size(64, 13);
            this.AospPathLabel.TabIndex = 0;
            this.AospPathLabel.Text = "AOSP Path:";
            // 
            // ClearRichTextBoxButton
            // 
            this.ClearRichTextBoxButton.Location = new System.Drawing.Point(344, 415);
            this.ClearRichTextBoxButton.Name = "ClearRichTextBoxButton";
            this.ClearRichTextBoxButton.Size = new System.Drawing.Size(75, 23);
            this.ClearRichTextBoxButton.TabIndex = 8;
            this.ClearRichTextBoxButton.Text = "Clear Output";
            this.ClearRichTextBoxButton.UseVisualStyleBackColor = true;
            this.ClearRichTextBoxButton.Click += new System.EventHandler(this.ClearRichTextBoxButton_Click);
            // 
            // OverWriteRichTextBoxCheckBox
            // 
            this.OverWriteRichTextBoxCheckBox.AutoSize = true;
            this.OverWriteRichTextBoxCheckBox.Location = new System.Drawing.Point(227, 419);
            this.OverWriteRichTextBoxCheckBox.Name = "OverWriteRichTextBoxCheckBox";
            this.OverWriteRichTextBoxCheckBox.Size = new System.Drawing.Size(106, 17);
            this.OverWriteRichTextBoxCheckBox.TabIndex = 9;
            this.OverWriteRichTextBoxCheckBox.Text = "Overwrite Output";
            this.OverWriteRichTextBoxCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OverWriteRichTextBoxCheckBox);
            this.Controls.Add(this.ClearRichTextBoxButton);
            this.Controls.Add(this.PushFileGroupBox);
            this.Controls.Add(this.InstallApkGroupBox);
            this.Controls.Add(this.CmdOutputRichTextBox);
            this.Controls.Add(this.ConnectivityGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainToolWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADB GUI Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainToolWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainToolWindow_Load);
            this.ConnectivityGroupBox.ResumeLayout(false);
            this.ConnectivityGroupBox.PerformLayout();
            this.InstallApkGroupBox.ResumeLayout(false);
            this.InstallApkGroupBox.PerformLayout();
            this.PushFileGroupBox.ResumeLayout(false);
            this.PushFileGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CmdOutputRichTextBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox IpAddrTextBox;
        private System.Windows.Forms.GroupBox ConnectivityGroupBox;
        private System.Windows.Forms.Label IpAddrLabel;
        private System.Windows.Forms.GroupBox InstallApkGroupBox;
        private System.Windows.Forms.Button ApkBrowseButton;
        private System.Windows.Forms.Label ApkNameLabel;
        private System.Windows.Forms.Label SelectedApkLabel;
        private System.Windows.Forms.Button InstallApkButton;
        private System.Windows.Forms.CheckBox EnR_CheckBox;
        private System.Windows.Forms.CheckBox EnD_CheckBox;
        private System.Windows.Forms.Button InstallApkResetButton;
        private System.Windows.Forms.CheckBox EnRootCheckBox;
        private System.Windows.Forms.CheckBox AdbRemountCheckBox;
        private System.Windows.Forms.GroupBox PushFileGroupBox;
        private System.Windows.Forms.Label AospPathLabel;
        private System.Windows.Forms.TextBox AospPathTextBox;
        private System.Windows.Forms.Label FilePushLabel;
        private System.Windows.Forms.Button PushFileBrowseButton;
        private System.Windows.Forms.Button PushFileButton;
        private System.Windows.Forms.Label PushFilePathLabel;
        private System.Windows.Forms.Button PushFileResetButton;
        private System.Windows.Forms.Button ClearRichTextBoxButton;
        private System.Windows.Forms.CheckBox OverWriteRichTextBoxCheckBox;
    }
}

