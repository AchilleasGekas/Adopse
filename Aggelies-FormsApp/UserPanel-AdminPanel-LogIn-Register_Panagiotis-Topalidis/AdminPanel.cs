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
namespace LogInRegister
{
    public partial class AdminPanel : Form
    {
        int population;//the total users of the Database
        int totalAds;//the total Ads of the Database

        OleDbConnection conn = new OleDbConnection();
        public AdminPanel()
        {
            InitializeComponent();
            //initialization must be done here
            //Do not modify the String
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                   @"Data source= C:\Users\Akuma\source\repos\" +
                   @"LogInRegister\databases\Database1.mdb";
        }

        private void label2_Click(object sender, EventArgs e)//ignore
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            label2.Text = "Admin: " + LogIn.uname;//printing admin's username
            try
            {
                conn.Open();//displaying the population and totalads
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

        private void button1_Click(object sender, EventArgs e)
        {
            //displays form that edits any user's data
            DisplayUsersAdmin dua = new DisplayUsersAdmin();
            dua.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //displays for that edits any ad's details
            DisplayAdsAdmin daa = new DisplayAdsAdmin();
            daa.ShowDialog();
        }
    }
}
