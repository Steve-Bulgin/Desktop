using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace BusyBeesDesktop
{
    public partial class FrmHive : Form
    {
        FrmMain frmMain;

        SQLiteConnection conn = new SQLiteConnection("Data Source=" + Path.GetPathRoot(System.Reflection.Assembly.GetEntryAssembly().Location) + @"BusyBees\BeeApiaryData\apiary.db");
        public FrmHive(FrmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;

            //fill the list boxes with hives
            try
            {
                conn.Open();
                String sql = "SELECT * FROM Hive";
                SQLiteCommand cmd3 = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmd3.ExecuteReader();

                while (reader.Read())
                {
                    listHive.Items.Add("Hive " + reader.GetDouble(0));
                }
            }
            catch (Exception m)
            {

                MessageBox.Show("Database Not found! Please import from the tablet!");
            }

            conn.Close();

        }

        private void FrmHive_Load(object sender, EventArgs e)
        {

        }

        private void FrmHive_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.Show();
        }

        private void listHive_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get hive Information into the text boxes
            try
            {
                conn.Open();
                String sql = "SELECT * FROM Hive Where hiveID =" + (listHive.SelectedIndex + 1);
                SQLiteCommand cmd3 = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmd3.ExecuteReader();

                while (reader.Read())
                {
                    lblHive.Text = reader.GetString(1);
                    //  lblSplit.Text = reader.GetString(2).ToString();
                    lblType.Text = reader.GetString(3);
                    lblSource.Text = reader.GetDouble(4).ToString();
                    lblConfig.Text = reader.GetString(5);
                    lblYard.Text = reader.GetDouble(6).ToString();
                }

                conn.Close();
            }
            catch (Exception m)
            {

                MessageBox.Show("An Error Occured" + m.Message);
            }

          




                

        }
    }
}
