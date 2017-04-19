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
    public partial class FrmQueen : Form
    {
        FrmMain frmMain;
        SQLiteConnection conn = new SQLiteConnection("Data Source=" + Path.GetPathRoot(System.Reflection.Assembly.GetEntryAssembly().Location) + @"BusyBees\Data\apiary.db");

        public FrmQueen(FrmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
            try
            {
              
                conn.Open();
                String sql = "SELECT * FROM Queen";
                SQLiteCommand cmd3 = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmd3.ExecuteReader();

                while (reader.Read())
                {
                    lstQueen.Items.Add("Queen" + reader.GetDouble(0));
                }
            }
            catch (Exception m)
            {

                MessageBox.Show("Database Not found! Please import from the tablet!");
            }

            conn.Close();
        }

        private void FrmQueen_Load(object sender, EventArgs e)
        {

        }

        private void FrmQueen_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.Show();
        }

        private void lstQueen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                String sql = "SELECT * FROM Queen Where queenID = " + (lstQueen.SelectedIndex+1);
                SQLiteCommand cmd3 = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmd3.ExecuteReader();

                while (reader.Read())
                {
                    lblDate.Text = reader.GetString(1);
                    lblReplaced.Text =   reader.GetString(2);
                    lblHive.Text =   reader.GetDouble(3).ToString();
                }
            }
            catch (Exception m)
            {

                MessageBox.Show("An Error Occured" + m.Message);
            }

            conn.Close();
        }
    }
}
