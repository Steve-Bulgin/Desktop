using PortableDevices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusyBeesDesktop
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            string root1 = Path.GetPathRoot(System.Reflection.Assembly.GetEntryAssembly().Location) + @"\BusyBees\Images";
            string root2 = Path.GetPathRoot(System.Reflection.Assembly.GetEntryAssembly().Location) + @"BusyBees\Data";
            System.IO.Directory.CreateDirectory(root1);
            System.IO.Directory.CreateDirectory(root2);
        }
        
        private void btnViewHive_Click(object sender, EventArgs e)
        {
            FrmHive frmHive = new FrmHive(this);
            frmHive.Show();
            this.Hide();

        }

        private void btnViewYard_Click(object sender, EventArgs e)
        {
            FrmYard frmYard = new FrmYard(this);
            frmYard.Show();
            this.Hide();
        }

        private void btnViewQueen_Click(object sender, EventArgs e)
        {
            FrmQueen frmQueen = new FrmQueen(this);
            frmQueen.Show();
            this.Hide();

        }

        private void btnViewMedia_Click(object sender, EventArgs e)
        {
            FrmMedia frmMedia = new FrmMedia(this);
            frmMedia.Show();
            this.Hide();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = "test.txt";
            string sourcePath = @"U:\Tablet\BeeApiaryData\";
            string targetPath = @"C:\Users\jcioanca1632\Desktop\test";

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            
            // To copy all the files in one directory to another directory.
            // Get the files in the source folder. (To recursively iterate through
            // all subfolders under the current directory, see
            // "How to: Iterate Through a Directory Tree.")
            // Note: Check for target path was performed previously
            //       in this code example.
            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            else
            {
                MessageBox.Show("Source path does not exist!");
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = "test.txt";
            string sourcePath = @"C:\Users\jcioanca1632\Desktop\DesktopFolder";
            string targetPath = @"C:\Users\jcioanca1632\Desktop\AppFolder";

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);



            // To copy all the files in one directory to another directory.
            // Get the files in the source folder. (To recursively iterate through
            // all subfolders under the current directory, see
            // "How to: Iterate Through a Directory Tree.")
            // Note: Check for target path was performed previously
            //       in this code example.
            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            else
            {
                MessageBox.Show("Source path does not exist!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var drives = DriveInfo.GetDrives();

            var removableFatDrives = drives.Where(
                    c => c.DriveType == DriveType.Removable &&
                    c.DriveFormat == "FAT" &&
                    c.IsReady);

            var andriods = from c in removableFatDrives
                           from d in c.RootDirectory.EnumerateDirectories()
                           where d.Name.Contains("Galaxy Tab S2")
                           select c;

            MessageBox.Show(andriods.ToString());
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
