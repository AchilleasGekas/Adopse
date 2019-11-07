using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace Aggelies_FormsApp
{
    
    public partial class Form1 : Form
    {
        //establishing a new connection
        OleDbConnection conn = new OleDbConnection();
 
        public Form1()
        {
            InitializeComponent();
            //initialization must be done here
            //Do not modify String
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                   @"Data source= C:\Users\zero\source\repos\" +
                   @"Aggelies-FormsApp\databases\users.mdb";
        }

       

        private void regButton_Click(object sender, EventArgs e)
        {
            //initiating the Register Form
            Register reg = new Register();
            this.Hide();
            reg.ShowDialog();
            this.Close();

        }

        private void uLogInButton_Click(object sender, EventArgs e)
        {
            try
            {
                //opening the new connection
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;

                //submitting the query for the user authentication later
                command.CommandText = "SELECT * FROM users WHERE username='"
                                      + usernameTextBox.Text + "' and pass='" + passTextBox.Text + "'";

                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {

                    count = 1;
                }

                //currently visualizing the authentication
                //temporarily until the next page is made
                if (count == 1)
                {
                    label3.Text = "Authentication Complete.";
                }
                else if (count == 0)
                {
                    label3.Text = "Authentication Failed.";
                }

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
                //the LogInUI remains until there will be a new page
                conn.Close();
            }
        }

        private void aLogInButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                //opening the new connection
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;

                //submitting the query for the admin authentication later
                command.CommandText = "SELECT * FROM admins WHERE username='"
                                      + usernameTextBox.Text + "' and pass='" + passTextBox.Text + "'";

                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {

                    count = 1;
                }

                if (count == 1)
                {
                    label3.Text = "Authentication Complete.";
                }
                else if (count == 0)
                {
                    label3.Text = "Authentication Failed.";
                }

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
                //the LogInUI remains until there will be a new page
                conn.Close();
            }
        }

        
    }
}
