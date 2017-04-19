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
    public partial class FrmMedia : Form
    {
        FrmMain frmMain;
        List<PictureBox> pictureBoxList = new List<PictureBox>();

        static int brh = 0;
        public FrmMedia(FrmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;

        }
    
        private void FrmMedia_Load(object sender, EventArgs e)
        {
            int fileCount = Directory.GetFiles(Path.GetPathRoot(System.Reflection.Assembly.GetEntryAssembly().Location) + @"BusyBees\Images").Length;
           
         
            int local = 1;
            int counter=-1;
            for (int i = 0; i < fileCount; i++)
            {
                counter++;
                if ((counter*100) > 1150)
                {
                    local = local +100;
                    counter = 0;
                }

                PictureBox picture = new PictureBox
                {
                    Name = "pictureBox" + i,
                    Size = new Size(100, 100),
                    Location = new Point(counter * 100, local),
                    BorderStyle = BorderStyle.FixedSingle,
                   SizeMode = PictureBoxSizeMode.StretchImage
                };
                
                picture.ImageLocation = Path.GetPathRoot(System.Reflection.Assembly.GetEntryAssembly().Location) + @"BusyBees\Images\" + i + ".png";
                picture.Click += new EventHandler(pictureBox1_Click);
                pictureBoxList.Add(picture);
            }
            
            foreach (PictureBox p in pictureBoxList)
            {
                this.Controls.Add(p);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            FrmPicture frmPicture = new FrmPicture(picture.ImageLocation);
            frmPicture.Show();

        }
     

        private void FrmMedia_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.Show();
        }

       

    }
}
