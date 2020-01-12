using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class AdminPanel : Form
    {
        int population;//the total users of the Database
        int totalAds;//the total Ads of the Database
        int movX;
        int movY;
        int mov;
        OleDbConnection conn = new OleDbConnection();
        public AdminPanel()
        {
            InitializeComponent();
            //initialization must be done here
            //Do not modify the String
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                   @"Data source=C:\teliko_solution\Database1.mdb;";
        }


        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
            this.Opacity = 1;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
                this.Opacity = .75;

            }
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manageAdsButton_Click(object sender, EventArgs e)
        {
            //displays form that edits any ad's details
            DisplayAdsAdmin daa = new DisplayAdsAdmin();
            daa.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            label2.Text = "Admin: " + Login.uname;//printing admin's username
            try
            {
                conn.Open();//displaying the population and total ads
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = conn;

                //retrieving the population of the app
                command1.CommandText = "SELECT count(user_id) FROM users";
                OleDbDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    population = reader.GetInt32(0);
                }
                populationLabel.Text = population.ToString();


                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;

                //retrieving the total ads of the app
                command.CommandText = "SELECT count(ad_id) FROM ads";
                OleDbDataReader reader1 = command.ExecuteReader();
                while (reader1.Read())
                {
                    totalAds = reader1.GetInt32(0);
                }
                tAdsLabel.Text = totalAds.ToString();
            }
            catch (Exception ex)
            {
                //message displayed in case there is an error detected
                MessageBox.Show("Failed to connect to data source");
            }
            finally
            {
                //closing up
                //for the time being there is no page to initiate
                conn.Close();
            }
        }

        private void manageUsersButton_Click(object sender, EventArgs e)
        {
            //displays form that edits any user's data
            DisplayUsersAdmin dua = new DisplayUsersAdmin();
            dua.ShowDialog();
        }

        private void insertAddBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void usage_DataBtn_Click(object sender, EventArgs e)
        {
            Usage_Data data = new Usage_Data();
            data.ShowDialog();
        }
    }
}
