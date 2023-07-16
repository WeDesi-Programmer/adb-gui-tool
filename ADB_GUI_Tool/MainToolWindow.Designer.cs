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
            this.IpAddrLabel = new System.Windows.Forms.Label();
            this.InstallApkGroupBox = new System.Windows.Forms.GroupBox();
            this.ApkBrowseButton = new System.Windows.Forms.Button();
            this.ApkNameLabel = new System.Windows.Forms.Label();
            this.SelectedApkLabel = new System.Windows.Forms.Label();
            this.InstallApkButton = new System.Windows.Forms.Button();
            this.EnD_CheckBox = new System.Windows.Forms.CheckBox();
            this.EnR_CheckBox = new System.Windows.Forms.CheckBox();
            this.InstallApkResetButton = new System.Windows.Forms.Button();
            this.EnRootCheckBox = new System.Windows.Forms.CheckBox();
            this.ConnectivityGroupBox.SuspendLayout();
            this.InstallApkGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdOutputRichTextBox
            // 
            this.CmdOutputRichTextBox.BackColor = System.Drawing.Color.Black;
            this.CmdOutputRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CmdOutputRichTextBox.ForeColor = System.Drawing.Color.Lime;
            this.CmdOutputRichTextBox.Location = new System.Drawing.Point(425, 12);
            this.CmdOutputRichTextBox.Name = "CmdOutputRichTextBox";
            this.CmdOutputRichTextBox.Size = new System.Drawing.Size(363, 426);
            this.CmdOutputRichTextBox.TabIndex = 0;
            this.CmdOutputRichTextBox.Text = "";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Enabled = false;
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // ApkNameLabel
            // 
            this.ApkNameLabel.AutoSize = true;
            this.ApkNameLabel.Location = new System.Drawing.Point(10, 49);
            this.ApkNameLabel.Name = "ApkNameLabel";
            this.ApkNameLabel.Size = new System.Drawing.Size(59, 13);
            this.ApkNameLabel.TabIndex = 1;
            this.ApkNameLabel.Text = "APK File:";
            // 
            // SelectedApkLabel
            // 
            this.SelectedApkLabel.AutoSize = true;
            this.SelectedApkLabel.Location = new System.Drawing.Point(76, 48);
            this.SelectedApkLabel.Name = "SelectedApkLabel";
            this.SelectedApkLabel.Size = new System.Drawing.Size(0, 13);
            this.SelectedApkLabel.TabIndex = 2;
            // 
            // InstallApkButton
            // 
            this.InstallApkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallApkButton.Location = new System.Drawing.Point(319, 19);
            this.InstallApkButton.Name = "InstallApkButton";
            this.InstallApkButton.Size = new System.Drawing.Size(75, 23);
            this.InstallApkButton.TabIndex = 3;
            this.InstallApkButton.Text = "INSTALL";
            this.InstallApkButton.UseVisualStyleBackColor = true;
            this.InstallApkButton.Click += new System.EventHandler(this.InstallApkButton_Click);
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
            // EnRootCheckBox
            // 
            this.EnRootCheckBox.AutoSize = true;
            this.EnRootCheckBox.Enabled = false;
            this.EnRootCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnRootCheckBox.Location = new System.Drawing.Point(214, 12);
            this.EnRootCheckBox.Name = "EnRootCheckBox";
            this.EnRootCheckBox.Size = new System.Drawing.Size(110, 17);
            this.EnRootCheckBox.TabIndex = 4;
            this.EnRootCheckBox.Text = "Enable ADB Root";
            this.EnRootCheckBox.UseVisualStyleBackColor = true;
            this.EnRootCheckBox.CheckedChanged += new System.EventHandler(this.EnRootCheckBox_CheckedChanged);
            // 
            // MainToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InstallApkGroupBox);
            this.Controls.Add(this.CmdOutputRichTextBox);
            this.Controls.Add(this.ConnectivityGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainToolWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADB GUI Tool";
            this.Load += new System.EventHandler(this.MainToolWindow_Load);
            this.ConnectivityGroupBox.ResumeLayout(false);
            this.ConnectivityGroupBox.PerformLayout();
            this.InstallApkGroupBox.ResumeLayout(false);
            this.InstallApkGroupBox.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

