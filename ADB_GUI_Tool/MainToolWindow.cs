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
        String ApkFile = "";
        String PushFile = "";
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
            String ConnectCmdOutput = "";

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
                        PushFileBrowseButton.Enabled = true;
                        AospPathTextBox.Enabled = true;
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
                        InstallApkButton.Enabled = false;
                        InstallApkResetButton.Enabled = false;
                        EnRootCheckBox.Enabled = false;
                        EnRootCheckBox.Checked = false;
                        AdbRemountCheckBox.Enabled = false;
                        AdbRemountCheckBox.Checked = false;
                        PushFileBrowseButton.Enabled = false;
                        PushFileButton.Enabled = false;
                        PushFileResetButton.Enabled = false;
                        AospPathTextBox.Enabled = false;
                    }
                }
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
                SelectedApkLabel.Text = ApkFile.ToString();
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
            String InstallApkCmdOutput = "";
            string InstallApkCmd = "";

            if (EnD_CheckBox.Checked == true)
            {
                InstallApkCmd = "adb install -d " + ApkFile.ToString();
            }
            else if (EnR_CheckBox.Checked == true)
            {
                InstallApkCmd = "adb install -r " + ApkFile.ToString();
            }
            else
            {
                InstallApkCmd = "adb install " + ApkFile.ToString();
            }
            
            ExecuteCommand(InstallApkCmd.ToString());

            CmdLine.WaitForExit();

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

            ApkFile = null;
            SelectedApkLabel.Text = null;
            InstallApkButton.Enabled = false;
            EnD_CheckBox.Enabled = false;
            EnR_CheckBox.Enabled = false;
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
            SelectedApkLabel.Text = null;
            InstallApkButton.Enabled = false;
            InstallApkResetButton.Enabled = false;
            EnD_CheckBox.Enabled = false;
            EnR_CheckBox.Enabled = false;
        }

        private void EnRootCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EnRootCheckBox.Checked == true)
            {
                String AdbRootCmdOutput = "";

                EnRootCheckBox.Enabled = false;

                ExecuteCommand("adb root");

                AdbRootCmdOutput = CmdLine.StandardOutput.ReadToEnd();
                
                UpdateOutputTextBoxWindow(AdbRootCmdOutput.ToString());

                AdbRemountCheckBox.Enabled = true;
            }
        }

        private void AdbRemountCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AdbRemountCheckBox.Checked == true)
            {
                String AdbRemountCmdOutput = "";

                AdbRemountCheckBox.Enabled = false;
                
                ExecuteCommand("adb remount");
                
                AdbRemountCmdOutput = CmdLine.StandardOutput.ReadToEnd();

                UpdateOutputTextBoxWindow(AdbRemountCmdOutput.ToString());
            }
        }

        private void MainToolWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
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
                PushFilePathLabel.Text = PushFile.ToString();
                PushFileButton.Enabled = true;
                PushFileResetButton.Enabled = true;
            }
        }

        private void PushFileResetButton_Click(object sender, EventArgs e)
        {
            AospPathTextBox.Text = null;
            PushFilePathLabel.Text = null;
            PushFileButton.Enabled = false;
            PushFileResetButton.Enabled = false;
        }

        private void PushFileButton_Click(object sender, EventArgs e)
        {
            String PushFileCmdOutput = "";
            string PushFileCmd = "adb push " + PushFile.ToString() + " " + AospPathTextBox.Text.ToString();

            ExecuteCommand(PushFileCmd.ToString());

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

            PushFile = null;
            AospPathTextBox.Text = null;
            PushFilePathLabel.Text = null;
            PushFileButton.Enabled = false;
            PushFileResetButton.Enabled = false;
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
    }
}