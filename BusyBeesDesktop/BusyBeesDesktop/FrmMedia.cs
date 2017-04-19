using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
            MessageBox.Show(lstHiveMedia.GetItemText(lstHiveMedia.SelectedItem));
        }


        //int fileCount = Directory.GetFiles(@"G:\Visual Studio 2015\Projects\BeeApiaryData\Images\1").Length;


        //int local = 10;
        //int counter=10;
        //for (int i = 0; i < fileCount; i++)
        //{
        //    counter++;
        //    if ((counter*100) > 1150)
        //    {
        //        local = local +100;
        //        counter = 0;
        //    }

        //    PictureBox picture = new PictureBox
        //    {
        //        Name = "pictureBox" + i,
        //        Size = new Size(100, 100),
        //        Location = new Point(counter * 100, local),
        //        BorderStyle = BorderStyle.FixedSingle,
        //        SizeMode = PictureBoxSizeMode.StretchImage
        //    };

        //    picture.ImageLocation = (@"G:\Visual Studio 2015\Projects\BeeApiaryData\Images\1\") + i + ".jpg";
        //    picture.Click += new EventHandler(pictureBox1_Click);
        //    pictureBoxList.Add(picture);
        //}

        //foreach (PictureBox p in pictureBoxList)
        //{
        //    this.Controls.Add(p);
        //}
    }

    //private void pictureBox1_Click(object sender, EventArgs e)
    //{
    //    PictureBox picture = (PictureBox)sender;
    //    FrmPicture frmPicture = new FrmPicture(picture.ImageLocation);
    //    frmPicture.Show();

    //}


    //private void FrmMedia_FormClosing(object sender, FormClosingEventArgs e)
    //{
    //    frmMain.Show();
    //}

    //private void lstHiveMedia_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    // Get hive Information into the text boxes
    //    try
    //    {
    //        conn.Open();
    //        String sql = "SELECT * FROM Hive Where hiveID =" + (listHive.SelectedIndex + 1);
    //        SQLiteCommand cmd3 = new SQLiteCommand(sql, conn);
    //        SQLiteDataReader reader = cmd3.ExecuteReader();

    //        while (reader.Read())
    //        {
    //            lblHive.Text = reader.GetString(1);
    //            //  lblSplit.Text = reader.GetString(2).ToString();
    //            lblType.Text = reader.GetString(3);
    //            lblSource.Text = reader.GetDouble(4).ToString();
    //            lblConfig.Text = reader.GetString(5);
    //            lblYard.Text = reader.GetDouble(6).ToString();
    //        }

    //        conn.Close();
    //    }
    //    catch (Exception m)
    //    {

    //        MessageBox.Show("An Error Occured" + m.Message);
    //    }








    }





