using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADB_GUI_Tool
{
    public partial class MainToolWindow : Form
    {
        Process CmdLine = new Process();
        string ApkFile = "";
        string PushFile = "";
        string PullFileFolder = "";

        public MainToolWindow()
        {
            InitializeComponent();
        }

        private void MainToolWindow_Load(object sender, EventArgs e)
        {
            //Start the command line on start up
            CmdLine.StartInfo.FileName = "cmd.exe";
            CmdLine.StartInfo.RedirectStandardInput = true;
            CmdLine.StartInfo.RedirectStandardOutput = true;
            CmdLine.StartInfo.CreateNoWindow = true;
            CmdLine.StartInfo.UseShellExecute = false;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            string ConnectCmdOutput = "";
            string TitleBarText = "";

            if (IpAddrTextBox.Text != "")
            {
                if (ConnectButton.Text == "Connect")
                {
                    string AdbCmd = "adb connect " + IpAddrTextBox.Text;

                    ExecuteCommand(AdbCmd.ToString());

                    ConnectCmdOutput = CmdLine.StandardOutput.ReadToEnd();

                    UpdateOutputTextBoxWindow(ConnectCmdOutput.ToString());

                    if (ConnectCmdOutput.Contains("connected to") == true)
                    {
                        ConnectButton.Text = "Disconnect";
                        IpAddrTextBox.Enabled = false;
                        ApkBrowseButton.Enabled = true;
                        EnRootCheckBox.Enabled = true;
                        AospPathTextBox.Enabled = true;
                        PacketNameTextBox.Enabled = true;
                        PullFileTextBox.Enabled = true;                       

                        //Update title bar here...
                        TitleBarText = "ADB GUI Tool - Connected to " + IpAddrTextBox.Text;
                    }
                    else
                    {
                        MessageBox.Show("Either not an IP Address or check output window!", "ADB GUI Tool - Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    ExecuteCommand("adb disconnect");

                    ConnectCmdOutput = CmdLine.StandardOutput.ReadToEnd();

                    UpdateOutputTextBoxWindow(ConnectCmdOutput.ToString());

                    if (ConnectCmdOutput.Contains("disconnected everything") == true)
                    {
                        ConnectButton.Text = "Connect";
                        IpAddrTextBox.Enabled = true;
                        ApkBrowseButton.Enabled = false;
                        SelectedApkTextBox.Text = null;
                        InstallApkButton.Enabled = false;
                        InstallApkResetButton.Enabled = false;
                        EnRootCheckBox.Enabled = false;
                        EnRootCheckBox.Checked = false;
                        AdbRemountCheckBox.Enabled = false;
                        AdbRemountCheckBox.Checked = false;
                        PushFilePathTextBox.Text = null;
                        PushFileBrowseButton.Enabled = false;
                        PushFileButton.Enabled = false;
                        PushFileResetButton.Enabled = false;
                        AospPathTextBox.Text = null;
                        AospPathTextBox.Enabled = false;
                        PacketNameTextBox.Text = null;
                        PacketNameTextBox.Enabled = false;
                        IsSystemAppCheckBox.Enabled = false;
                        UninstallButton.Enabled = false;
                        EnableDisablePacketButton.Enabled = false;
                        SaveToLocationBrowseButton.Enabled = false;
                        PullFileButton.Enabled = false;
                        PullFileResetButton.Enabled = false;
                        RootedLabel.Visible = false;
                        RemountedLabel.Visible = false;

                        //Update title bar here...
                        TitleBarText = "ADB GUI Tool - Disconnected";
                    }
                }

                //Update Main Form Tile Bar Text
                this.Text = TitleBarText;
            }
            else
            {
                MessageBox.Show("Please enter an IP Address!", "ADB GUI Tool - Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void IpAddrTextBox_TextChanged(object sender, EventArgs e)
        {
            ConnectButton.Enabled = true;
        }

        private void ApkBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ApkSelectDialog = new OpenFileDialog();
            ApkSelectDialog.Title = "Select an Android Application File";
            ApkSelectDialog.Filter = "Android Application Files (*.apk)|*.apk";

            if (ApkSelectDialog.ShowDialog() == DialogResult.OK)
            {
                ApkFile = ApkSelectDialog.FileName;
                SelectedApkTextBox.Text = ApkFile.ToString();
                if (ApkFile.ToString() != "")
                {
                    InstallApkButton.Enabled = true;
                    InstallApkResetButton.Enabled = true;
                    EnD_CheckBox.Enabled = true;
                    EnR_CheckBox.Enabled = true;
                }

            }
        }

        private void InstallApkButton_Click(object sender, EventArgs e)
        {
            string InstallApkCmdOutput = "";
            string InstallApkCmd = "";

            if (EnD_CheckBox.Checked == true)
            {
                InstallApkCmd = "adb install -d " + "\"" + ApkFile.ToString() + "\"";
            }
            else if (EnR_CheckBox.Checked == true)
            {
                InstallApkCmd = "adb install -r " + "\"" + ApkFile.ToString() + "\"";
            }
            else
            {
                InstallApkCmd = "adb install " + "\"" + ApkFile.ToString() + "\"";
            }

            StartProcessingRequestedCommand();

            ExecuteCommand(InstallApkCmd.ToString());

            CmdLine.WaitForExit();

            RequestedCommandCompleted();

            InstallApkCmdOutput = CmdLine.StandardOutput.ReadToEnd();

            UpdateOutputTextBoxWindow(InstallApkCmdOutput.ToString());

            if (InstallApkCmdOutput.Contains("Success") == true)
            {
                MessageBox.Show("Success to install APK onto the Android Device!", "ADB GUI Tool - APK Installation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to install APK onto the Android Device!", "ADB GUI Tool - APK Installation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (AutoClearCheckBox.Checked == true)
            {
                ApkFile = null;
                SelectedApkTextBox.Text = null;
                InstallApkButton.Enabled = false;
                EnD_CheckBox.Enabled = false;
                EnR_CheckBox.Enabled = false;
            }

        }

        private void EnD_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EnD_CheckBox.Checked == true)
            {
                EnR_CheckBox.Checked = false;
                EnR_CheckBox.Enabled = false;
            }

            if (EnD_CheckBox.Checked == false)
            {
                EnR_CheckBox.Enabled = true;
            }
        }

        private void EnR_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EnR_CheckBox.Checked == true)
            {
                EnD_CheckBox.Checked = false;
                EnD_CheckBox.Enabled = false;
            }

            if (EnR_CheckBox.Checked == false)
            {
                EnD_CheckBox.Enabled = true;
            }
        }

        private void InstallApkResetButton_Click(object sender, EventArgs e)
        {
            SelectedApkTextBox.Text = null;
            InstallApkButton.Enabled = false;
            InstallApkResetButton.Enabled = false;
            EnD_CheckBox.Enabled = false;
            EnR_CheckBox.Enabled = false;
        }

        private void EnRootCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EnRootCheckBox.Checked == true)
            {
                string AdbRootCmdOutput = "";

                ExecuteCommand("adb root");

                AdbRootCmdOutput = CmdLine.StandardOutput.ReadToEnd();

                UpdateOutputTextBoxWindow(AdbRootCmdOutput.ToString());

                if ( (string.IsNullOrEmpty(AdbRootCmdOutput)) || (AdbRootCmdOutput.Contains("adbd is already running as root") == true) )
                {
                    EnRootCheckBox.Enabled = false;

                    AdbRemountCheckBox.Enabled = true;

                    RootedLabel.Visible = true;

                    MessageBox.Show("ADB is running as ROOT now for the Android Device!", "ADB GUI Tool - ROOT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    EnRootCheckBox.Checked = false;

                    MessageBox.Show("Failed to run as ROOT for the Android Device!", "ADB GUI Tool - ROOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AdbRemountCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AdbRemountCheckBox.Checked == true)
            {
                string AdbRemountCmdOutput = "";

                ExecuteCommand("adb remount");

                AdbRemountCmdOutput = CmdLine.StandardOutput.ReadToEnd();

                UpdateOutputTextBoxWindow(AdbRemountCmdOutput.ToString());

                if (AdbRemountCmdOutput.Contains("remount succeeded") == true)
                {
                    AdbRemountCheckBox.Enabled = false;

                    RemountedLabel.Visible = true;

                    MessageBox.Show("ADB REMOUNT is succesful on the Android Device!", "ADB GUI Tool - REMOUNT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    AdbRemountCheckBox.Checked = false;

                    MessageBox.Show("Failed to REMOUNT on the Android Device!", "ADB GUI Tool - REMOUNT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                RemountedLabel.Visible = true;
            }
        }

        private void MainToolWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Enabled = false;
            CmdLine.Close();
        }

        private void PushFileBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog PushFileSelectDialog = new OpenFileDialog();
            PushFileSelectDialog.Title = "Select a File to Push";
            PushFileSelectDialog.Filter = "All Files (*.*)|*.*";

            if (PushFileSelectDialog.ShowDialog() == DialogResult.OK)
            {
                PushFile = PushFileSelectDialog.FileName;
                PushFilePathTextBox.Text = PushFile.ToString();
                PushFileResetButton.Enabled = true;
            }
        }

        private void PushFileResetButton_Click(object sender, EventArgs e)
        {
            AospPathTextBox.Text = null;
            PushFilePathTextBox.Text = null;
            PushFileButton.Enabled = false;
            PushFileResetButton.Enabled = false;
        }

        private void PushFileButton_Click(object sender, EventArgs e)
        {
            string PushFileCmdOutput = "";

            if ( (string.IsNullOrWhiteSpace(AospPathTextBox.Text)) && (AospPathTextBox.Text.Length >= 0) )
            {
                MessageBox.Show("Android Device Path contains Whitespace!", "ADB GUI Tool - Push File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string PushFileCmd = "adb push " + "\"" + PushFile.ToString() + "\"" + " " + AospPathTextBox.Text.ToString();

                StartProcessingRequestedCommand();

                ExecuteCommand(PushFileCmd.ToString());

                CmdLine.WaitForExit();

                RequestedCommandCompleted();

                PushFileCmdOutput = CmdLine.StandardOutput.ReadToEnd();

                UpdateOutputTextBoxWindow(PushFileCmdOutput.ToString());

                if (PushFileCmdOutput.Contains("1 file pushed") == true)
                {
                    MessageBox.Show("Success to PUSH a file onto the Android Device!", "ADB GUI Tool - Push File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to PUSH a file onto the Android Device!", "ADB GUI Tool - Push File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (AutoClearCheckBox.Checked == true)
                {
                    PushFile = null;
                    AospPathTextBox.Text = null;
                    PushFilePathTextBox.Text = null;
                    PushFileButton.Enabled = false;
                    PushFileResetButton.Enabled = false;
                }
            }
        }

        private void ClearRichTextBoxButton_Click(object sender, EventArgs e)
        {
            CmdOutputRichTextBox.Text = null;
        }

        private void ExecuteCommand(string CmdString)
        {
            CmdLine.Start();
            CmdLine.StandardInput.WriteLine(CmdString.ToString());
            CmdLine.StandardInput.Flush();
            CmdLine.StandardInput.Close();
        }

        private void UpdateOutputTextBoxWindow(string OutputStream)
        {
            if (OverWriteRichTextBoxCheckBox.Checked == true)
            {
                CmdOutputRichTextBox.Text = OutputStream.ToString();
            }
            else
            {
                CmdOutputRichTextBox.AppendText(OutputStream.ToString());
            }
        }

        private void PacketNameTextBox_TextChanged(object sender, EventArgs e)
        {
            IsSystemAppCheckBox.Enabled = true;
            IsSystemAppCheckBox.Checked = false;
            UninstallButton.Enabled = true;
            EnableDisablePacketButton.Enabled = true;
        }

        private void UninstallButton_Click(object sender, EventArgs e)
        {
            string UninstallPacketCmdOutput = "";
            string UninstallPacketFileCmd = "";

            if (IsSystemAppCheckBox.Checked == true)
            {
                UninstallPacketFileCmd = "adb uninstall -k --user 0 " + PacketNameTextBox.Text;
            }
            else
            {
                UninstallPacketFileCmd = "adb uninstall " + PacketNameTextBox.Text;
            }

            StartProcessingRequestedCommand();

            ExecuteCommand(UninstallPacketFileCmd.ToString());

            CmdLine.WaitForExit();

            RequestedCommandCompleted();
            
            UninstallPacketCmdOutput = CmdLine.StandardOutput.ReadToEnd();

            UpdateOutputTextBoxWindow(UninstallPacketCmdOutput.ToString());

            if (UninstallPacketCmdOutput.Contains("Success") == true)
            {
                MessageBox.Show("Success to Uninstall packet from the Android Device!", "ADB GUI Tool - Uinstall Packet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to Uinstall Packet from the Android Device!\nCheck Packet Name is correct!!!", "ADB GUI Tool - Uinstall Packet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (AutoClearCheckBox.Checked == true)
            {
                UninstallPacketFileCmd = null;
                IsSystemAppCheckBox.Checked = false;
                IsSystemAppCheckBox.Enabled = false;
                PacketNameTextBox.Text = null;
                UninstallButton.Enabled = false;
                EnableDisablePacketButton.Enabled = false;
            }

            PacketNameTextBox.Text = null;
        }

        private void EnableDisablePacketButton_Click(object sender, EventArgs e)
        {
            string EnableDisablePacketCmdOutput = "";
            string PacketManagerCmd = "";

            if (EnableDisablePacketButton.Text == "Disable Packet")
            {
                PacketManagerCmd = "adb shell pm disable " + PacketNameTextBox.Text;

                ExecuteCommand(PacketManagerCmd.ToString());

                EnableDisablePacketCmdOutput = CmdLine.StandardOutput.ReadToEnd();

                UpdateOutputTextBoxWindow(EnableDisablePacketCmdOutput.ToString());

                if (EnableDisablePacketCmdOutput.Contains("disabled") == true)
                {
                    EnableDisablePacketButton.Text = "Enable Packet";
                }
                else
                {
                    MessageBox.Show("Either Packet Name is incorrect or check output window!", "ADB GUI Tool - Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                PacketManagerCmd = "adb shell pm enable " + PacketNameTextBox.Text;

                ExecuteCommand(PacketManagerCmd.ToString());

                EnableDisablePacketCmdOutput = CmdLine.StandardOutput.ReadToEnd();

                UpdateOutputTextBoxWindow(EnableDisablePacketCmdOutput.ToString());

                if (EnableDisablePacketCmdOutput.Contains("enabled") == true)
                {
                    EnableDisablePacketButton.Text = "Disable Packet";
                }
                else
                {
                    MessageBox.Show("Either Packet Name is incorrect or check output window", "ADB GUI Tool - Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void RawAdbCmdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string ExecuteRawAdbCmdOutput = "";

                ExecuteCommand(RawAdbCmdTextBox.Text.ToString());

                ExecuteRawAdbCmdOutput = CmdLine.StandardOutput.ReadToEnd();

                UpdateOutputTextBoxWindow(ExecuteRawAdbCmdOutput.ToString());

                RawAdbCmdTextBox.Text = null;
            }
        }

        private void PullFileButton_Click(object sender, EventArgs e)
        {
            string PullFileCmdOutput = "";

            if ((string.IsNullOrWhiteSpace(PullFileTextBox.Text)) && (PullFileTextBox.Text.Length >= 0))
            {
                MessageBox.Show("Android Device Path contains Whitespace!", "ADB GUI Tool - Pull File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string PullFileCmd = "adb pull " + PullFileTextBox.Text.ToString() + " " + "\"" + PullFileFolder.ToString() + "\"" ;

                StartProcessingRequestedCommand();

                ExecuteCommand(PullFileCmd.ToString());

                CmdLine.WaitForExit();

                RequestedCommandCompleted();

                PullFileCmdOutput = CmdLine.StandardOutput.ReadToEnd();

                UpdateOutputTextBoxWindow(PullFileCmdOutput.ToString());

                if (PullFileCmdOutput.Contains("1 file pulled") == true)
                {
                    MessageBox.Show("Successfully to PULLed a file from the Android Device!", "ADB GUI Tool - Pull File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to PULL a file from the Android Device!", "ADB GUI Tool - Pull File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (AutoClearCheckBox.Checked == true)
                {
                    PullFileFolder = null;
                    PullFileTextBox.Text = null;
                    PullFileSaveToTextBox.Text = null;
                    PullFileButton.Enabled = false;
                    PullFileResetButton.Enabled = false;
                }
            }
        }

        private void SaveToLocationBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog PushFileSelectDialog = new FolderBrowserDialog();
            PushFileSelectDialog.Description = "Select a File to save file being Pulled from Android device...";

            if (PushFileSelectDialog.ShowDialog() == DialogResult.OK)
            {
                PullFileFolder = PushFileSelectDialog.SelectedPath;
                PullFileSaveToTextBox.Text = PullFileFolder.ToString();
                PullFileButton.Enabled = true;
            }   
        }

        private void PullFileTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveToLocationBrowseButton.Enabled = true;
            PullFileResetButton.Enabled = true;
        }

        private void AospPathTextBox_TextChanged(object sender, EventArgs e)
        {
            PushFileBrowseButton.Enabled = true;
            PushFileResetButton.Enabled = true;
        }

        private void StartProcessingRequestedCommand()
        {
            this.Cursor = Cursors.WaitCursor;
            this.Enabled = false;
        }

        private void RequestedCommandCompleted()
        {
            this.Cursor = Cursors.Default;
            this.Enabled = true;
        }

        private void OverWriteRichTextBoxCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AospPathLabel_Click(object sender, EventArgs e)
        {

        }

        private void FilePushLabel_Click(object sender, EventArgs e)
        {

        }

        private void PushFileGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void PushFilePathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApkNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void InstallApkGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void SelectedApkTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IpAddrLabel_Click(object sender, EventArgs e)
        {

        }

        private void ConnectivityGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void CmdOutputRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AutoClearCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PacketManagerGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void IsSystemAppCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PacketNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void RawAdbCmdGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void RawAdbCmdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PullFileGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void PullFileSaveToTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PullFileResetButton_Click(object sender, EventArgs e)
        {

        }

        private void SavePulledFileLabel_Click(object sender, EventArgs e)
        {

        }

        private void AospFileLabel_Click(object sender, EventArgs e)
        {

        }

        private void RootedLabel_Click(object sender, EventArgs e)
        {

        }

        private void RemountedLabel_Click(object sender, EventArgs e)
        {

        }
    }
}