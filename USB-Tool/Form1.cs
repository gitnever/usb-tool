using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace USB_Tool
{
    public partial class USBTool : Form
    {

        private bool isRuning;
        private DriveInfo selectedDrive;

        public USBTool()
        {
            InitializeComponent();
        }

        private void USBTool_Load(object sender, EventArgs e)
        {
            isRuning = false;
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    if(drive.IsReady)
                    {
                        // MessageBox.Show(drive.RootDirectory.ToString().Substring(0, 1));
                        comboBox1.Items.Add(drive.RootDirectory.ToString().Substring(0, 1) + ":\\ -" + " " + drive.VolumeLabel);
                    }
                }
            }
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
        }

        public static bool FormatUSB(char driveLetter, string name= "USB", string system = "NTFS", bool speed = true, bool enableCompression = false, int? cluterSize = null)
        {
            bool success = false;

            if(!Char.IsLetter(driveLetter))
            {
                return false;
            }

            string drive = driveLetter + ":";
            try {
                var driveInfo = new DriveInfo(drive);
                var processStartInfo = new ProcessStartInfo();
                processStartInfo.FileName = "format.com";
                processStartInfo.CreateNoWindow = true;
                processStartInfo.WorkingDirectory = Environment.SystemDirectory;
                processStartInfo.Arguments = "/FS:" + system +
                    " /Y" +
                    " /V:" + name +
                    (speed ? " /Q" : "") +
                    ((system == "NTFS" && enableCompression) ? " /C" : "") +
                    (cluterSize.HasValue ? " /A:" + cluterSize.Value : "") +
                    " " + drive;
                processStartInfo.UseShellExecute = false;
                processStartInfo.CreateNoWindow = true;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.RedirectStandardInput = true;
                var formatProcess = Process.Start(processStartInfo);
                var swStandardInput = formatProcess.StandardInput;
                swStandardInput.WriteLine();
                formatProcess.WaitForExit();
                success = true;
            }catch(Exception)
            {
                // ERREUR
            }

            return success;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool ok = FormatUSB(Char.Parse(selectedDrive.RootDirectory.ToString().Substring(0, 1)), textBox2.Text, comboBox2.Text, checkBox1.Checked, false, null);
            if(ok)
            {
                MessageBox.Show("Formatage terminé !");
            } else
            {
                MessageBox.Show("Une erreur est survenue !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!isRuning)
            {
                Application.Exit();
            } else
            {
                MessageBox.Show("Erreur, une opération est en cours ! Veuillez patienter...");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                var letter = comboBox1.Text[0];
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (drive.DriveType == DriveType.Removable)
                    {
                        if (drive.IsReady)
                        {
                            if(drive.RootDirectory.ToString().Substring(0, 1) == letter.ToString())
                            {
                                selectedDrive = drive;
                            }
                        }
                    }
                }

                textBox1.Text = (selectedDrive.TotalFreeSpace / 1000000000) + " Go(s) libres sur " + (selectedDrive.TotalSize / 1000000000) + " Go(s).";
                textBox2.Text = selectedDrive.VolumeLabel;

                return;
            }
            textBox1.Text = "...";
            textBox2.Text = "...";
        }
    }

}
