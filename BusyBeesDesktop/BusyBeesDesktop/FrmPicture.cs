using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusyBeesDesktop
{
    public partial class FrmPicture : Form
    {
        string path;
        public FrmPicture(string path)
        {
            InitializeComponent();
            this.path = path;
        }

        private void FrmPicture_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = path;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
