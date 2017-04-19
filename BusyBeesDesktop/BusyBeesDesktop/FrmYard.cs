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
    public partial class FrmYard : Form
    {
        FrmMain frmMain;
        SQLiteConnection conn = new SQLiteConnection("Data Source=" + Path.GetPathRoot(System.Reflection.Assembly.GetEntryAssembly().Location) + @"BusyBees\Data\apiary.db");

        public FrmYard(FrmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;

            try
            {
                conn.Open();
                String sql = "SELECT * FROM Yard";
                SQLiteCommand cmd3 = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmd3.ExecuteReader();

                while (reader.Read())
                {
                    lstYard.Items.Add("Yard " + reader.GetDouble(0));
                }
            }
            catch (Exception m)
            {

                MessageBox.Show("Database Not found! Please import from the tablet!");
            }

            conn.Close();

        }

        private void FrmYard_Load(object sender, EventArgs e)
        {

        }

        private void FrmYard_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.Show();
        }

        private void lstYard_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String sql = "SELECT * FROM Yard where yardID =" + (lstYard.SelectedIndex +1);
                SQLiteCommand cmd3 = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmd3.ExecuteReader();

                while (reader.Read())
                {
                    lblLocation.Text = reader.GetString(1);
                    lblDesc.Text = reader.GetString(2);
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
