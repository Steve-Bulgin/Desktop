using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusyBeesDesktop
{
    public partial class FrmMedia : Form
    {
        FrmMain frmMain;
        List<PictureBox> pictureBoxList = new List<PictureBox>();
        string hivefromlv;
        string hiveid;
        SQLiteConnection conn = new SQLiteConnection("Data Source=" + @"G:\Visual Studio 2015\Projects\BeeApiaryData\apiary.db");

        static int brh = 0;
        public FrmMedia(FrmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;

        }
    
        private void FrmMedia_Load(object sender, EventArgs e)
        {

            //fill the list boxes with hives
            try
            {
                conn.Open();
                String sql = "SELECT * FROM Hive";
                SQLiteCommand cmd3 = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmd3.ExecuteReader();

                while (reader.Read())
                {
                    lstHiveMedia.Items.Add("Hive " + reader.GetDouble(0));
                }
            }
            catch (Exception m)
            {

                MessageBox.Show("Database Not found! Please import from the tablet!");
            }

            conn.Close();

        }

        private void lstHiveMedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxList.Clear();

            RemoveControls(this, typeof(PictureBox));

            hivefromlv = lstHiveMedia.GetItemText(lstHiveMedia.SelectedItem);
            hiveid = Regex.Match(hivefromlv, @"((?<=Hive )\d+)").ToString();

            string[] folders = Directory.GetDirectories(@"G:\Visual Studio 2015\Projects\BeeApiaryData\Images");

            foreach (string folder in folders)
            {
                if (folder == @"G:\Visual Studio 2015\Projects\BeeApiaryData\Images\" + hiveid)
                {
                    string[] images = Directory.GetFiles(@"G:\Visual Studio 2015\Projects\BeeApiaryData\Images\" + hiveid);

                    //Up-Down
                    int local = 50;
                    //Left Right?
                    int counter = 140;

                    foreach (string image in images)
                    {
                        string imgname = Regex.Match(image, @"(\d+)[_](\d+)(?=.jpg)").ToString();
                        if (image != @"G:\Visual Studio 2015\Projects\BeeApiaryData\Images\" + hiveid + @"\Thumbs.db")
                        {


                            
                            if ((counter * 100) > 1150)
                            {
                                local = local;
                                counter = counter + 100;
                            }

                            PictureBox picture = new PictureBox
                            {
                                Name = "pictureBox" + imgname,
                                Size = new Size(100, 100),
                                Location = new Point(counter, local),
                                BorderStyle = BorderStyle.FixedSingle,
                                SizeMode = PictureBoxSizeMode.StretchImage
                            };

                            picture.ImageLocation = (@"G:\Visual Studio 2015\Projects\BeeApiaryData\Images\" + hiveid + @"\") + imgname + ".jpg";
                            picture.Click += new EventHandler(pictureBox1_Click);
                            pictureBoxList.Add(picture);




                            foreach (PictureBox p in pictureBoxList)
                            {
                                this.Controls.Add(p);
                            }
                            //Console.WriteLine(System.Reflection.Assembly.GetEntryAssembly().Location);

                            
                        }
                    }

                }
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


        private void RemoveControls(Control control, Type type)
        {
            List<Control> controls = new List<Control>();

            Stack<Control> stack = new Stack<Control>();
            stack.Push(control);

            while (stack.Count > 0)
            {
                Control ctrl = stack.Pop();
                foreach (Control child in ctrl.Controls)
                {
                    if (child.GetType() == type)
                    {
                        controls.Add(child);
                    }
                    else if (true == child.HasChildren)
                    {
                        stack.Push(child);
                    }
                }
            }

            foreach (Control ctrl in controls)
            {
                control.Controls.Remove(ctrl);
                ctrl.Dispose();
            }
        }
    }


    
}






