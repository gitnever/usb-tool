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

namespace USBTool
{
    public partial class AppForm : Form
    {

        private bool isMoving = false;

        private int moveX;
        private int moveY;

        private DriveInfo selectedDrive;

        private string isoPath = "";

        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            foreach(DriveInfo drive in DriveInfo.GetDrives())
            {
                if(drive.DriveType == DriveType.Removable)
                {
                    if(drive.IsReady)
                    {
                        DriveList.Items.Add(drive.RootDirectory.ToString().Substring(0, 1) + ":\\ - " + drive.VolumeLabel);
                    }
                }
            }
            DriveList.SelectedIndex = 0;
            FileSystemSelection.SelectedIndex = 0;
        }

        #region Top Buttons

        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MiniAppButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Move App

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            moveX = e.X;
            moveY = e.Y;
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
                Cursor.Current = Cursors.SizeAll;
            }
            else
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
        }

        #endregion

        private void DriveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DriveList.SelectedIndex != 0)
            {
                var letter = DriveList.Text[0];
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (drive.DriveType == DriveType.Removable)
                    {
                        if (drive.IsReady)
                        {
                            if (drive.RootDirectory.ToString().Substring(0, 1) == letter.ToString())
                            {
                                selectedDrive = drive;
                            }
                        }
                    }
                }
                textBox1.Text = selectedDrive.VolumeLabel;

                return;
            }
            textBox1.Text = "...";
        }

        public static bool FormatUSB(char driveLetter, string name = "USB", string system = "NTFS", bool speed = true, bool enableCompression = false, int? cluterSize = null)
        {
            bool success = false;

            if (!Char.IsLetter(driveLetter))
            {
                return false;
            }

            string drive = driveLetter + ":";
            try
            {
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
            }
            catch (Exception)
            {
                // ERREUR
            }

            return success;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            bool success = FormatUSB(Char.Parse(selectedDrive.RootDirectory.ToString().Substring(0, 1)), textBox1.Text, FileSystemSelection.Text, UseSpeedFormatage.Checked, false, null);
            if(success)
            {
                if(WriteIsoFile.Checked)
                {
                    if(isoPath.Length >= 5)
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Formatage terminé. Une erreur s'est produite lors de la gravure de l'image disque.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Une erreur est survenue !");
            }
        }

        private void BrowseForIso_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
                openFile.Filter = "Images Disque (*.iso)|*.iso";
                openFile.FilterIndex = 2;
                openFile.RestoreDirectory = true;

                if(openFile.ShowDialog() == DialogResult.OK)
                {

                    filePath = openFile.FileName;

                    isoPath = filePath;

                    label5.Text = openFile.SafeFileName;

                }
            }

        }
    }

}
