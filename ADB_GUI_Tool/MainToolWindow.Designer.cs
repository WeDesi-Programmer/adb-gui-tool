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
            this.OverWriteRichTextBoxCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearRichTextBoxButton = new System.Windows.Forms.Button();
            this.AospPathLabel = new System.Windows.Forms.Label();
            this.FilePushLabel = new System.Windows.Forms.Label();
            this.AospPathTextBox = new System.Windows.Forms.TextBox();
            this.PushFileBrowseButton = new System.Windows.Forms.Button();
            this.PushFileButton = new System.Windows.Forms.Button();
            this.PushFileResetButton = new System.Windows.Forms.Button();
            this.PushFileGroupBox = new System.Windows.Forms.GroupBox();
            this.PushFilePathTextBox = new System.Windows.Forms.TextBox();
            this.ApkBrowseButton = new System.Windows.Forms.Button();
            this.ApkNameLabel = new System.Windows.Forms.Label();
            this.InstallApkGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectedApkTextBox = new System.Windows.Forms.TextBox();
            this.InstallApkResetButton = new System.Windows.Forms.Button();
            this.EnR_CheckBox = new System.Windows.Forms.CheckBox();
            this.EnD_CheckBox = new System.Windows.Forms.CheckBox();
            this.InstallApkButton = new System.Windows.Forms.Button();
            this.IpAddrLabel = new System.Windows.Forms.Label();
            this.EnRootCheckBox = new System.Windows.Forms.CheckBox();
            this.AdbRemountCheckBox = new System.Windows.Forms.CheckBox();
            this.ConnectivityGroupBox = new System.Windows.Forms.GroupBox();
            this.IpAddrTextBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.CmdOutputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AutoClearCheckBox = new System.Windows.Forms.CheckBox();
            this.PacketManagerGroupBox = new System.Windows.Forms.GroupBox();
            this.IsSystemAppCheckBox = new System.Windows.Forms.CheckBox();
            this.UninstallButton = new System.Windows.Forms.Button();
            this.EnableDisablePacketButton = new System.Windows.Forms.Button();
            this.PacketNameTextBox = new System.Windows.Forms.TextBox();
            this.PacketNameLabel = new System.Windows.Forms.Label();
            this.RawAdbCmdGroupBox = new System.Windows.Forms.GroupBox();
            this.RawAdbCmdTextBox = new System.Windows.Forms.TextBox();
            this.OutputGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PullFileGroupBox = new System.Windows.Forms.GroupBox();
            this.PullFileSaveToTextBox = new System.Windows.Forms.TextBox();
            this.PullFileResetButton = new System.Windows.Forms.Button();
            this.PullFileButton = new System.Windows.Forms.Button();
            this.SaveToLocationBrowseButton = new System.Windows.Forms.Button();
            this.PullFileTextBox = new System.Windows.Forms.TextBox();
            this.SavePulledFileLabel = new System.Windows.Forms.Label();
            this.AospFileLabel = new System.Windows.Forms.Label();
            this.PushFileGroupBox.SuspendLayout();
            this.InstallApkGroupBox.SuspendLayout();
            this.ConnectivityGroupBox.SuspendLayout();
            this.PacketManagerGroupBox.SuspendLayout();
            this.RawAdbCmdGroupBox.SuspendLayout();
            this.OutputGroupBox.SuspendLayout();
            this.PullFileGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OverWriteRichTextBoxCheckBox
            // 
            this.OverWriteRichTextBoxCheckBox.AutoSize = true;
            this.OverWriteRichTextBoxCheckBox.BackColor = System.Drawing.Color.Black;
            this.OverWriteRichTextBoxCheckBox.Checked = true;
            this.OverWriteRichTextBoxCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OverWriteRichTextBoxCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverWriteRichTextBoxCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.OverWriteRichTextBoxCheckBox.Location = new System.Drawing.Point(9, 18);
            this.OverWriteRichTextBoxCheckBox.Name = "OverWriteRichTextBoxCheckBox";
            this.OverWriteRichTextBoxCheckBox.Size = new System.Drawing.Size(106, 17);
            this.OverWriteRichTextBoxCheckBox.TabIndex = 15;
            this.OverWriteRichTextBoxCheckBox.Text = "Overwrite Output";
            this.OverWriteRichTextBoxCheckBox.UseVisualStyleBackColor = false;
            // 
            // ClearRichTextBoxButton
            // 
            this.ClearRichTextBoxButton.BackColor = System.Drawing.Color.White;
            this.ClearRichTextBoxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearRichTextBoxButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearRichTextBoxButton.ForeColor = System.Drawing.Color.Green;
            this.ClearRichTextBoxButton.Location = new System.Drawing.Point(499, 12);
            this.ClearRichTextBoxButton.Name = "ClearRichTextBoxButton";
            this.ClearRichTextBoxButton.Size = new System.Drawing.Size(75, 23);
            this.ClearRichTextBoxButton.TabIndex = 16;
            this.ClearRichTextBoxButton.Text = "Clear Output";
            this.ClearRichTextBoxButton.UseVisualStyleBackColor = false;
            this.ClearRichTextBoxButton.Click += new System.EventHandler(this.ClearRichTextBoxButton_Click);
            // 
            // AospPathLabel
            // 
            this.AospPathLabel.AutoSize = true;
            this.AospPathLabel.BackColor = System.Drawing.Color.Black;
            this.AospPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AospPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AospPathLabel.Location = new System.Drawing.Point(6, 21);
            this.AospPathLabel.Name = "AospPathLabel";
            this.AospPathLabel.Size = new System.Drawing.Size(64, 13);
            this.AospPathLabel.TabIndex = 0;
            this.AospPathLabel.Text = "AOSP Path:";
            // 
            // FilePushLabel
            // 
            this.FilePushLabel.AutoSize = true;
            this.FilePushLabel.BackColor = System.Drawing.Color.Black;
            this.FilePushLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilePushLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FilePushLabel.Location = new System.Drawing.Point(6, 47);
            this.FilePushLabel.Name = "FilePushLabel";
            this.FilePushLabel.Size = new System.Drawing.Size(65, 13);
            this.FilePushLabel.TabIndex = 1;
            this.FilePushLabel.Text = "File to Push:";
            // 
            // AospPathTextBox
            // 
            this.AospPathTextBox.BackColor = System.Drawing.Color.Black;
            this.AospPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AospPathTextBox.Enabled = false;
            this.AospPathTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AospPathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AospPathTextBox.Location = new System.Drawing.Point(77, 17);
            this.AospPathTextBox.Name = "AospPathTextBox";
            this.AospPathTextBox.Size = new System.Drawing.Size(317, 20);
            this.AospPathTextBox.TabIndex = 10;
            this.AospPathTextBox.TextChanged += new System.EventHandler(this.AospPathTextBox_TextChanged);
            // 
            // PushFileBrowseButton
            // 
            this.PushFileBrowseButton.BackColor = System.Drawing.Color.White;
            this.PushFileBrowseButton.Enabled = false;
            this.PushFileBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PushFileBrowseButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PushFileBrowseButton.ForeColor = System.Drawing.Color.Green;
            this.PushFileBrowseButton.Location = new System.Drawing.Point(213, 70);
            this.PushFileBrowseButton.Name = "PushFileBrowseButton";
            this.PushFileBrowseButton.Size = new System.Drawing.Size(88, 23);
            this.PushFileBrowseButton.TabIndex = 11;
            this.PushFileBrowseButton.Text = "Browse...";
            this.PushFileBrowseButton.UseVisualStyleBackColor = false;
            this.PushFileBrowseButton.Click += new System.EventHandler(this.PushFileBrowseButton_Click);
            // 
            // PushFileButton
            // 
            this.PushFileButton.BackColor = System.Drawing.Color.White;
            this.PushFileButton.Enabled = false;
            this.PushFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PushFileButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PushFileButton.ForeColor = System.Drawing.Color.Green;
            this.PushFileButton.Location = new System.Drawing.Point(309, 70);
            this.PushFileButton.Name = "PushFileButton";
            this.PushFileButton.Size = new System.Drawing.Size(85, 23);
            this.PushFileButton.TabIndex = 13;
            this.PushFileButton.Text = "PUSH";
            this.PushFileButton.UseVisualStyleBackColor = false;
            this.PushFileButton.Click += new System.EventHandler(this.PushFileButton_Click);
            // 
            // PushFileResetButton
            // 
            this.PushFileResetButton.BackColor = System.Drawing.Color.White;
            this.PushFileResetButton.Enabled = false;
            this.PushFileResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PushFileResetButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PushFileResetButton.ForeColor = System.Drawing.Color.Green;
            this.PushFileResetButton.Location = new System.Drawing.Point(9, 69);
            this.PushFileResetButton.Name = "PushFileResetButton";
            this.PushFileResetButton.Size = new System.Drawing.Size(85, 23);
            this.PushFileResetButton.TabIndex = 12;
            this.PushFileResetButton.Text = "Reset";
            this.PushFileResetButton.UseVisualStyleBackColor = false;
            this.PushFileResetButton.Click += new System.EventHandler(this.PushFileResetButton_Click);
            // 
            // PushFileGroupBox
            // 
            this.PushFileGroupBox.BackColor = System.Drawing.Color.Black;
            this.PushFileGroupBox.Controls.Add(this.PushFilePathTextBox);
            this.PushFileGroupBox.Controls.Add(this.PushFileResetButton);
            this.PushFileGroupBox.Controls.Add(this.PushFileButton);
            this.PushFileGroupBox.Controls.Add(this.PushFileBrowseButton);
            this.PushFileGroupBox.Controls.Add(this.AospPathTextBox);
            this.PushFileGroupBox.Controls.Add(this.FilePushLabel);
            this.PushFileGroupBox.Controls.Add(this.AospPathLabel);
            this.PushFileGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PushFileGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PushFileGroupBox.Location = new System.Drawing.Point(10, 247);
            this.PushFileGroupBox.Name = "PushFileGroupBox";
            this.PushFileGroupBox.Size = new System.Drawing.Size(409, 100);
            this.PushFileGroupBox.TabIndex = 5;
            this.PushFileGroupBox.TabStop = false;
            this.PushFileGroupBox.Text = "Push File";
            // 
            // PushFilePathTextBox
            // 
            this.PushFilePathTextBox.BackColor = System.Drawing.Color.Black;
            this.PushFilePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PushFilePathTextBox.Enabled = false;
            this.PushFilePathTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PushFilePathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PushFilePathTextBox.Location = new System.Drawing.Point(77, 43);
            this.PushFilePathTextBox.Name = "PushFilePathTextBox";
            this.PushFilePathTextBox.Size = new System.Drawing.Size(317, 20);
            this.PushFilePathTextBox.TabIndex = 8;
            // 
            // ApkBrowseButton
            // 
            this.ApkBrowseButton.BackColor = System.Drawing.Color.White;
            this.ApkBrowseButton.Enabled = false;
            this.ApkBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApkBrowseButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApkBrowseButton.ForeColor = System.Drawing.Color.Green;
            this.ApkBrowseButton.Location = new System.Drawing.Point(9, 19);
            this.ApkBrowseButton.Name = "ApkBrowseButton";
            this.ApkBrowseButton.Size = new System.Drawing.Size(82, 23);
            this.ApkBrowseButton.TabIndex = 5;
            this.ApkBrowseButton.Text = "Browse...";
            this.ApkBrowseButton.UseVisualStyleBackColor = false;
            this.ApkBrowseButton.Click += new System.EventHandler(this.ApkBrowseButton_Click);
            // 
            // ApkNameLabel
            // 
            this.ApkNameLabel.AutoSize = true;
            this.ApkNameLabel.BackColor = System.Drawing.Color.Black;
            this.ApkNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApkNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ApkNameLabel.Location = new System.Drawing.Point(10, 49);
            this.ApkNameLabel.Name = "ApkNameLabel";
            this.ApkNameLabel.Size = new System.Drawing.Size(50, 13);
            this.ApkNameLabel.TabIndex = 1;
            this.ApkNameLabel.Text = "APK File:";
            // 
            // InstallApkGroupBox
            // 
            this.InstallApkGroupBox.BackColor = System.Drawing.Color.Black;
            this.InstallApkGroupBox.Controls.Add(this.SelectedApkTextBox);
            this.InstallApkGroupBox.Controls.Add(this.InstallApkResetButton);
            this.InstallApkGroupBox.Controls.Add(this.EnR_CheckBox);
            this.InstallApkGroupBox.Controls.Add(this.EnD_CheckBox);
            this.InstallApkGroupBox.Controls.Add(this.InstallApkButton);
            this.InstallApkGroupBox.Controls.Add(this.ApkNameLabel);
            this.InstallApkGroupBox.Controls.Add(this.ApkBrowseButton);
            this.InstallApkGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallApkGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.InstallApkGroupBox.Location = new System.Drawing.Point(10, 84);
            this.InstallApkGroupBox.Name = "InstallApkGroupBox";
            this.InstallApkGroupBox.Size = new System.Drawing.Size(409, 76);
            this.InstallApkGroupBox.TabIndex = 4;
            this.InstallApkGroupBox.TabStop = false;
            this.InstallApkGroupBox.Text = "Install Application";
            // 
            // SelectedApkTextBox
            // 
            this.SelectedApkTextBox.BackColor = System.Drawing.Color.Black;
            this.SelectedApkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedApkTextBox.Enabled = false;
            this.SelectedApkTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedApkTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SelectedApkTextBox.Location = new System.Drawing.Point(62, 46);
            this.SelectedApkTextBox.Name = "SelectedApkTextBox";
            this.SelectedApkTextBox.Size = new System.Drawing.Size(332, 20);
            this.SelectedApkTextBox.TabIndex = 10;
            this.SelectedApkTextBox.TabStop = false;
            // 
            // InstallApkResetButton
            // 
            this.InstallApkResetButton.BackColor = System.Drawing.Color.White;
            this.InstallApkResetButton.Enabled = false;
            this.InstallApkResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstallApkResetButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallApkResetButton.ForeColor = System.Drawing.Color.Green;
            this.InstallApkResetButton.Location = new System.Drawing.Point(97, 19);
            this.InstallApkResetButton.Name = "InstallApkResetButton";
            this.InstallApkResetButton.Size = new System.Drawing.Size(75, 23);
            this.InstallApkResetButton.TabIndex = 6;
            this.InstallApkResetButton.Text = "Reset";
            this.InstallApkResetButton.UseVisualStyleBackColor = false;
            this.InstallApkResetButton.Click += new System.EventHandler(this.InstallApkResetButton_Click);
            // 
            // EnR_CheckBox
            // 
            this.EnR_CheckBox.AutoSize = true;
            this.EnR_CheckBox.BackColor = System.Drawing.Color.Black;
            this.EnR_CheckBox.Enabled = false;
            this.EnR_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnR_CheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EnR_CheckBox.Location = new System.Drawing.Point(269, 23);
            this.EnR_CheckBox.Name = "EnR_CheckBox";
            this.EnR_CheckBox.Size = new System.Drawing.Size(32, 17);
            this.EnR_CheckBox.TabIndex = 8;
            this.EnR_CheckBox.Text = "-r";
            this.EnR_CheckBox.UseVisualStyleBackColor = false;
            this.EnR_CheckBox.CheckedChanged += new System.EventHandler(this.EnR_CheckBox_CheckedChanged);
            // 
            // EnD_CheckBox
            // 
            this.EnD_CheckBox.AutoSize = true;
            this.EnD_CheckBox.BackColor = System.Drawing.Color.Black;
            this.EnD_CheckBox.Enabled = false;
            this.EnD_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnD_CheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EnD_CheckBox.Location = new System.Drawing.Point(226, 23);
            this.EnD_CheckBox.Name = "EnD_CheckBox";
            this.EnD_CheckBox.Size = new System.Drawing.Size(35, 17);
            this.EnD_CheckBox.TabIndex = 7;
            this.EnD_CheckBox.Text = "-d";
            this.EnD_CheckBox.UseVisualStyleBackColor = false;
            this.EnD_CheckBox.CheckedChanged += new System.EventHandler(this.EnD_CheckBox_CheckedChanged);
            // 
            // InstallApkButton
            // 
            this.InstallApkButton.BackColor = System.Drawing.Color.White;
            this.InstallApkButton.Enabled = false;
            this.InstallApkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstallApkButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallApkButton.ForeColor = System.Drawing.Color.Green;
            this.InstallApkButton.Location = new System.Drawing.Point(319, 19);
            this.InstallApkButton.Name = "InstallApkButton";
            this.InstallApkButton.Size = new System.Drawing.Size(75, 23);
            this.InstallApkButton.TabIndex = 9;
            this.InstallApkButton.Text = "INSTALL";
            this.InstallApkButton.UseVisualStyleBackColor = false;
            this.InstallApkButton.Click += new System.EventHandler(this.InstallApkButton_Click);
            // 
            // IpAddrLabel
            // 
            this.IpAddrLabel.AutoSize = true;
            this.IpAddrLabel.BackColor = System.Drawing.Color.Black;
            this.IpAddrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IpAddrLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.IpAddrLabel.Location = new System.Drawing.Point(6, 20);
            this.IpAddrLabel.Name = "IpAddrLabel";
            this.IpAddrLabel.Size = new System.Drawing.Size(61, 13);
            this.IpAddrLabel.TabIndex = 3;
            this.IpAddrLabel.Text = "IP Address:";
            // 
            // EnRootCheckBox
            // 
            this.EnRootCheckBox.AutoSize = true;
            this.EnRootCheckBox.BackColor = System.Drawing.Color.Black;
            this.EnRootCheckBox.Enabled = false;
            this.EnRootCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnRootCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EnRootCheckBox.Location = new System.Drawing.Point(226, 19);
            this.EnRootCheckBox.Name = "EnRootCheckBox";
            this.EnRootCheckBox.Size = new System.Drawing.Size(110, 17);
            this.EnRootCheckBox.TabIndex = 3;
            this.EnRootCheckBox.Text = "Enable ADB Root";
            this.EnRootCheckBox.UseVisualStyleBackColor = false;
            this.EnRootCheckBox.CheckedChanged += new System.EventHandler(this.EnRootCheckBox_CheckedChanged);
            // 
            // AdbRemountCheckBox
            // 
            this.AdbRemountCheckBox.AutoSize = true;
            this.AdbRemountCheckBox.BackColor = System.Drawing.Color.Black;
            this.AdbRemountCheckBox.Enabled = false;
            this.AdbRemountCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdbRemountCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AdbRemountCheckBox.Location = new System.Drawing.Point(226, 46);
            this.AdbRemountCheckBox.Name = "AdbRemountCheckBox";
            this.AdbRemountCheckBox.Size = new System.Drawing.Size(94, 17);
            this.AdbRemountCheckBox.TabIndex = 4;
            this.AdbRemountCheckBox.Text = "ADB Remount";
            this.AdbRemountCheckBox.UseVisualStyleBackColor = false;
            this.AdbRemountCheckBox.CheckedChanged += new System.EventHandler(this.AdbRemountCheckBox_CheckedChanged);
            // 
            // ConnectivityGroupBox
            // 
            this.ConnectivityGroupBox.BackColor = System.Drawing.Color.Black;
            this.ConnectivityGroupBox.Controls.Add(this.AdbRemountCheckBox);
            this.ConnectivityGroupBox.Controls.Add(this.EnRootCheckBox);
            this.ConnectivityGroupBox.Controls.Add(this.IpAddrLabel);
            this.ConnectivityGroupBox.Controls.Add(this.IpAddrTextBox);
            this.ConnectivityGroupBox.Controls.Add(this.ConnectButton);
            this.ConnectivityGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectivityGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ConnectivityGroupBox.Location = new System.Drawing.Point(10, 3);
            this.ConnectivityGroupBox.Name = "ConnectivityGroupBox";
            this.ConnectivityGroupBox.Size = new System.Drawing.Size(409, 74);
            this.ConnectivityGroupBox.TabIndex = 3;
            this.ConnectivityGroupBox.TabStop = false;
            this.ConnectivityGroupBox.Text = "Connectivity";
            // 
            // IpAddrTextBox
            // 
            this.IpAddrTextBox.BackColor = System.Drawing.Color.Black;
            this.IpAddrTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IpAddrTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IpAddrTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.IpAddrTextBox.Location = new System.Drawing.Point(68, 17);
            this.IpAddrTextBox.Name = "IpAddrTextBox";
            this.IpAddrTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IpAddrTextBox.Size = new System.Drawing.Size(118, 20);
            this.IpAddrTextBox.TabIndex = 0;
            this.IpAddrTextBox.TextChanged += new System.EventHandler(this.IpAddrTextBox_TextChanged);
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.White;
            this.ConnectButton.Enabled = false;
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.ForeColor = System.Drawing.Color.Green;
            this.ConnectButton.Location = new System.Drawing.Point(9, 43);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(177, 22);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // CmdOutputRichTextBox
            // 
            this.CmdOutputRichTextBox.BackColor = System.Drawing.Color.Black;
            this.CmdOutputRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CmdOutputRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdOutputRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CmdOutputRichTextBox.Location = new System.Drawing.Point(9, 41);
            this.CmdOutputRichTextBox.Name = "CmdOutputRichTextBox";
            this.CmdOutputRichTextBox.ReadOnly = true;
            this.CmdOutputRichTextBox.Size = new System.Drawing.Size(565, 370);
            this.CmdOutputRichTextBox.TabIndex = 0;
            this.CmdOutputRichTextBox.TabStop = false;
            this.CmdOutputRichTextBox.Text = "";
            // 
            // AutoClearCheckBox
            // 
            this.AutoClearCheckBox.AutoSize = true;
            this.AutoClearCheckBox.BackColor = System.Drawing.Color.Black;
            this.AutoClearCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AutoClearCheckBox.Location = new System.Drawing.Point(10, 488);
            this.AutoClearCheckBox.Name = "AutoClearCheckBox";
            this.AutoClearCheckBox.Size = new System.Drawing.Size(75, 17);
            this.AutoClearCheckBox.TabIndex = 14;
            this.AutoClearCheckBox.Text = "Auto Clear";
            this.AutoClearCheckBox.UseVisualStyleBackColor = false;
            // 
            // PacketManagerGroupBox
            // 
            this.PacketManagerGroupBox.Controls.Add(this.IsSystemAppCheckBox);
            this.PacketManagerGroupBox.Controls.Add(this.UninstallButton);
            this.PacketManagerGroupBox.Controls.Add(this.EnableDisablePacketButton);
            this.PacketManagerGroupBox.Controls.Add(this.PacketNameTextBox);
            this.PacketManagerGroupBox.Controls.Add(this.PacketNameLabel);
            this.PacketManagerGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacketManagerGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PacketManagerGroupBox.Location = new System.Drawing.Point(10, 166);
            this.PacketManagerGroupBox.Name = "PacketManagerGroupBox";
            this.PacketManagerGroupBox.Size = new System.Drawing.Size(409, 75);
            this.PacketManagerGroupBox.TabIndex = 17;
            this.PacketManagerGroupBox.TabStop = false;
            this.PacketManagerGroupBox.Text = "Packet Manager";
            // 
            // IsSystemAppCheckBox
            // 
            this.IsSystemAppCheckBox.AutoSize = true;
            this.IsSystemAppCheckBox.Enabled = false;
            this.IsSystemAppCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsSystemAppCheckBox.Location = new System.Drawing.Point(78, 47);
            this.IsSystemAppCheckBox.Name = "IsSystemAppCheckBox";
            this.IsSystemAppCheckBox.Size = new System.Drawing.Size(82, 17);
            this.IsSystemAppCheckBox.TabIndex = 4;
            this.IsSystemAppCheckBox.Text = "System App";
            this.IsSystemAppCheckBox.UseVisualStyleBackColor = true;
            // 
            // UninstallButton
            // 
            this.UninstallButton.BackColor = System.Drawing.Color.White;
            this.UninstallButton.Enabled = false;
            this.UninstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UninstallButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UninstallButton.ForeColor = System.Drawing.Color.Green;
            this.UninstallButton.Location = new System.Drawing.Point(166, 44);
            this.UninstallButton.Name = "UninstallButton";
            this.UninstallButton.Size = new System.Drawing.Size(95, 23);
            this.UninstallButton.TabIndex = 3;
            this.UninstallButton.Text = "Uninstall";
            this.UninstallButton.UseVisualStyleBackColor = false;
            this.UninstallButton.Click += new System.EventHandler(this.UninstallButton_Click);
            // 
            // EnableDisablePacketButton
            // 
            this.EnableDisablePacketButton.BackColor = System.Drawing.Color.White;
            this.EnableDisablePacketButton.Enabled = false;
            this.EnableDisablePacketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnableDisablePacketButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnableDisablePacketButton.ForeColor = System.Drawing.Color.Green;
            this.EnableDisablePacketButton.Location = new System.Drawing.Point(269, 44);
            this.EnableDisablePacketButton.Name = "EnableDisablePacketButton";
            this.EnableDisablePacketButton.Size = new System.Drawing.Size(125, 23);
            this.EnableDisablePacketButton.TabIndex = 2;
            this.EnableDisablePacketButton.Text = "Disable Packet";
            this.EnableDisablePacketButton.UseVisualStyleBackColor = false;
            this.EnableDisablePacketButton.Click += new System.EventHandler(this.EnableDisablePacketButton_Click);
            // 
            // PacketNameTextBox
            // 
            this.PacketNameTextBox.BackColor = System.Drawing.Color.Black;
            this.PacketNameTextBox.Enabled = false;
            this.PacketNameTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacketNameTextBox.ForeColor = System.Drawing.Color.Lime;
            this.PacketNameTextBox.Location = new System.Drawing.Point(77, 18);
            this.PacketNameTextBox.Name = "PacketNameTextBox";
            this.PacketNameTextBox.Size = new System.Drawing.Size(317, 20);
            this.PacketNameTextBox.TabIndex = 1;
            this.PacketNameTextBox.TextChanged += new System.EventHandler(this.PacketNameTextBox_TextChanged);
            // 
            // PacketNameLabel
            // 
            this.PacketNameLabel.AutoSize = true;
            this.PacketNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacketNameLabel.Location = new System.Drawing.Point(6, 20);
            this.PacketNameLabel.Name = "PacketNameLabel";
            this.PacketNameLabel.Size = new System.Drawing.Size(75, 13);
            this.PacketNameLabel.TabIndex = 0;
            this.PacketNameLabel.Text = "Packet Name:";
            // 
            // RawAdbCmdGroupBox
            // 
            this.RawAdbCmdGroupBox.Controls.Add(this.RawAdbCmdTextBox);
            this.RawAdbCmdGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RawAdbCmdGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RawAdbCmdGroupBox.Location = new System.Drawing.Point(442, 8);
            this.RawAdbCmdGroupBox.Name = "RawAdbCmdGroupBox";
            this.RawAdbCmdGroupBox.Size = new System.Drawing.Size(580, 53);
            this.RawAdbCmdGroupBox.TabIndex = 18;
            this.RawAdbCmdGroupBox.TabStop = false;
            this.RawAdbCmdGroupBox.Text = "Raw ADB Command";
            // 
            // RawAdbCmdTextBox
            // 
            this.RawAdbCmdTextBox.BackColor = System.Drawing.Color.Black;
            this.RawAdbCmdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RawAdbCmdTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RawAdbCmdTextBox.ForeColor = System.Drawing.Color.Lime;
            this.RawAdbCmdTextBox.Location = new System.Drawing.Point(9, 20);
            this.RawAdbCmdTextBox.Name = "RawAdbCmdTextBox";
            this.RawAdbCmdTextBox.Size = new System.Drawing.Size(565, 20);
            this.RawAdbCmdTextBox.TabIndex = 0;
            this.RawAdbCmdTextBox.WordWrap = false;
            this.RawAdbCmdTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RawAdbCmdTextBox_KeyDown);
            // 
            // OutputGroupBox
            // 
            this.OutputGroupBox.Controls.Add(this.CmdOutputRichTextBox);
            this.OutputGroupBox.Controls.Add(this.ClearRichTextBoxButton);
            this.OutputGroupBox.Controls.Add(this.OverWriteRichTextBoxCheckBox);
            this.OutputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.OutputGroupBox.Location = new System.Drawing.Point(442, 68);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(580, 421);
            this.OutputGroupBox.TabIndex = 19;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "Output Window";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(440, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Free to use GUI overlay Tool for ADB                                             " +
    "                                      by WeDesi Programmer - Enjoy!";
            // 
            // PullFileGroupBox
            // 
            this.PullFileGroupBox.BackColor = System.Drawing.Color.Black;
            this.PullFileGroupBox.Controls.Add(this.PullFileSaveToTextBox);
            this.PullFileGroupBox.Controls.Add(this.PullFileResetButton);
            this.PullFileGroupBox.Controls.Add(this.PullFileButton);
            this.PullFileGroupBox.Controls.Add(this.SaveToLocationBrowseButton);
            this.PullFileGroupBox.Controls.Add(this.PullFileTextBox);
            this.PullFileGroupBox.Controls.Add(this.SavePulledFileLabel);
            this.PullFileGroupBox.Controls.Add(this.AospFileLabel);
            this.PullFileGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PullFileGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PullFileGroupBox.Location = new System.Drawing.Point(10, 353);
            this.PullFileGroupBox.Name = "PullFileGroupBox";
            this.PullFileGroupBox.Size = new System.Drawing.Size(409, 100);
            this.PullFileGroupBox.TabIndex = 14;
            this.PullFileGroupBox.TabStop = false;
            this.PullFileGroupBox.Text = "Pull File";
            // 
            // PullFileSaveToTextBox
            // 
            this.PullFileSaveToTextBox.BackColor = System.Drawing.Color.Black;
            this.PullFileSaveToTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PullFileSaveToTextBox.Enabled = false;
            this.PullFileSaveToTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PullFileSaveToTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PullFileSaveToTextBox.Location = new System.Drawing.Point(77, 43);
            this.PullFileSaveToTextBox.Name = "PullFileSaveToTextBox";
            this.PullFileSaveToTextBox.Size = new System.Drawing.Size(317, 20);
            this.PullFileSaveToTextBox.TabIndex = 8;
            // 
            // PullFileResetButton
            // 
            this.PullFileResetButton.BackColor = System.Drawing.Color.White;
            this.PullFileResetButton.Enabled = false;
            this.PullFileResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PullFileResetButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PullFileResetButton.ForeColor = System.Drawing.Color.Green;
            this.PullFileResetButton.Location = new System.Drawing.Point(9, 69);
            this.PullFileResetButton.Name = "PullFileResetButton";
            this.PullFileResetButton.Size = new System.Drawing.Size(85, 23);
            this.PullFileResetButton.TabIndex = 12;
            this.PullFileResetButton.Text = "Reset";
            this.PullFileResetButton.UseVisualStyleBackColor = false;
            // 
            // PullFileButton
            // 
            this.PullFileButton.BackColor = System.Drawing.Color.White;
            this.PullFileButton.Enabled = false;
            this.PullFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PullFileButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PullFileButton.ForeColor = System.Drawing.Color.Green;
            this.PullFileButton.Location = new System.Drawing.Point(309, 70);
            this.PullFileButton.Name = "PullFileButton";
            this.PullFileButton.Size = new System.Drawing.Size(85, 23);
            this.PullFileButton.TabIndex = 13;
            this.PullFileButton.Text = "PULL";
            this.PullFileButton.UseVisualStyleBackColor = false;
            this.PullFileButton.Click += new System.EventHandler(this.PullFileButton_Click);
            // 
            // SaveToLocationBrowseButton
            // 
            this.SaveToLocationBrowseButton.BackColor = System.Drawing.Color.White;
            this.SaveToLocationBrowseButton.Enabled = false;
            this.SaveToLocationBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveToLocationBrowseButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveToLocationBrowseButton.ForeColor = System.Drawing.Color.Green;
            this.SaveToLocationBrowseButton.Location = new System.Drawing.Point(213, 70);
            this.SaveToLocationBrowseButton.Name = "SaveToLocationBrowseButton";
            this.SaveToLocationBrowseButton.Size = new System.Drawing.Size(88, 23);
            this.SaveToLocationBrowseButton.TabIndex = 11;
            this.SaveToLocationBrowseButton.Text = "Save to...";
            this.SaveToLocationBrowseButton.UseVisualStyleBackColor = false;
            this.SaveToLocationBrowseButton.Click += new System.EventHandler(this.SaveToLocationBrowseButton_Click);
            // 
            // PullFileTextBox
            // 
            this.PullFileTextBox.BackColor = System.Drawing.Color.Black;
            this.PullFileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PullFileTextBox.Enabled = false;
            this.PullFileTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PullFileTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PullFileTextBox.Location = new System.Drawing.Point(77, 17);
            this.PullFileTextBox.Name = "PullFileTextBox";
            this.PullFileTextBox.Size = new System.Drawing.Size(317, 20);
            this.PullFileTextBox.TabIndex = 10;
            this.PullFileTextBox.TextChanged += new System.EventHandler(this.PullFileTextBox_TextChanged);
            // 
            // SavePulledFileLabel
            // 
            this.SavePulledFileLabel.AutoSize = true;
            this.SavePulledFileLabel.BackColor = System.Drawing.Color.Black;
            this.SavePulledFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePulledFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SavePulledFileLabel.Location = new System.Drawing.Point(6, 47);
            this.SavePulledFileLabel.Name = "SavePulledFileLabel";
            this.SavePulledFileLabel.Size = new System.Drawing.Size(47, 13);
            this.SavePulledFileLabel.TabIndex = 1;
            this.SavePulledFileLabel.Text = "Save to:";
            // 
            // AospFileLabel
            // 
            this.AospFileLabel.AutoSize = true;
            this.AospFileLabel.BackColor = System.Drawing.Color.Black;
            this.AospFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AospFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AospFileLabel.Location = new System.Drawing.Point(6, 21);
            this.AospFileLabel.Name = "AospFileLabel";
            this.AospFileLabel.Size = new System.Drawing.Size(58, 13);
            this.AospFileLabel.TabIndex = 0;
            this.AospFileLabel.Text = "AOSP File:";
            // 
            // MainToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1034, 511);
            this.Controls.Add(this.PullFileGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RawAdbCmdGroupBox);
            this.Controls.Add(this.PacketManagerGroupBox);
            this.Controls.Add(this.AutoClearCheckBox);
            this.Controls.Add(this.PushFileGroupBox);
            this.Controls.Add(this.InstallApkGroupBox);
            this.Controls.Add(this.ConnectivityGroupBox);
            this.Controls.Add(this.OutputGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainToolWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADB GUI Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainToolWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainToolWindow_Load);
            this.PushFileGroupBox.ResumeLayout(false);
            this.PushFileGroupBox.PerformLayout();
            this.InstallApkGroupBox.ResumeLayout(false);
            this.InstallApkGroupBox.PerformLayout();
            this.ConnectivityGroupBox.ResumeLayout(false);
            this.ConnectivityGroupBox.PerformLayout();
            this.PacketManagerGroupBox.ResumeLayout(false);
            this.PacketManagerGroupBox.PerformLayout();
            this.RawAdbCmdGroupBox.ResumeLayout(false);
            this.RawAdbCmdGroupBox.PerformLayout();
            this.OutputGroupBox.ResumeLayout(false);
            this.OutputGroupBox.PerformLayout();
            this.PullFileGroupBox.ResumeLayout(false);
            this.PullFileGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox OverWriteRichTextBoxCheckBox;
        private System.Windows.Forms.Button ClearRichTextBoxButton;
        private System.Windows.Forms.Label AospPathLabel;
        private System.Windows.Forms.Label FilePushLabel;
        private System.Windows.Forms.TextBox AospPathTextBox;
        private System.Windows.Forms.Button PushFileBrowseButton;
        private System.Windows.Forms.Button PushFileButton;
        private System.Windows.Forms.Button PushFileResetButton;
        private System.Windows.Forms.GroupBox PushFileGroupBox;
        private System.Windows.Forms.Button ApkBrowseButton;
        private System.Windows.Forms.Label ApkNameLabel;
        private System.Windows.Forms.GroupBox InstallApkGroupBox;
        private System.Windows.Forms.TextBox SelectedApkTextBox;
        private System.Windows.Forms.Button InstallApkResetButton;
        private System.Windows.Forms.CheckBox EnR_CheckBox;
        private System.Windows.Forms.CheckBox EnD_CheckBox;
        private System.Windows.Forms.Button InstallApkButton;
        private System.Windows.Forms.Label IpAddrLabel;
        private System.Windows.Forms.CheckBox EnRootCheckBox;
        private System.Windows.Forms.CheckBox AdbRemountCheckBox;
        private System.Windows.Forms.GroupBox ConnectivityGroupBox;
        private System.Windows.Forms.TextBox IpAddrTextBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.RichTextBox CmdOutputRichTextBox;
        private System.Windows.Forms.TextBox PushFilePathTextBox;
        private System.Windows.Forms.CheckBox AutoClearCheckBox;
        private System.Windows.Forms.GroupBox PacketManagerGroupBox;
        private System.Windows.Forms.TextBox PacketNameTextBox;
        private System.Windows.Forms.Label PacketNameLabel;
        private System.Windows.Forms.Button EnableDisablePacketButton;
        private System.Windows.Forms.Button UninstallButton;
        private System.Windows.Forms.CheckBox IsSystemAppCheckBox;
        private System.Windows.Forms.GroupBox RawAdbCmdGroupBox;
        private System.Windows.Forms.TextBox RawAdbCmdTextBox;
        private System.Windows.Forms.GroupBox OutputGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox PullFileGroupBox;
        private System.Windows.Forms.TextBox PullFileSaveToTextBox;
        private System.Windows.Forms.Button PullFileResetButton;
        private System.Windows.Forms.Button PullFileButton;
        private System.Windows.Forms.Button SaveToLocationBrowseButton;
        private System.Windows.Forms.TextBox PullFileTextBox;
        private System.Windows.Forms.Label SavePulledFileLabel;
        private System.Windows.Forms.Label AospFileLabel;
    }
}

