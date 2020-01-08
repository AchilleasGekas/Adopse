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
    public partial class LogIn : Form
    {
        //retrieve the username for the whole application from HERE
        //this is the current session's username
        public static String uname=""; 
        //establishing a new connection
        OleDbConnection conn = new OleDbConnection();

        public LogIn()
        {
            InitializeComponent();
            //initialization must be done here
            //Do not modify the String
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                   @"Data source= C:\Users\Akuma\source\repos\" +
                   @"LogInRegister\databases\Database1.mdb";
        }



        private void textBox1_TextChanged(object sender, EventArgs e)//ignore
        {

        }

        private void uLogInButton_Click(object sender, EventArgs e)
        {
            try
            {
                string attr = "";
                //opening the new connection
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;

                //submitting the query for the user authentication later
                command.CommandText = "SELECT attr FROM users WHERE username='"
                                      + usernameTextBox.Text + "' and passwd='" + passTextBox.Text + "'";

                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = 1;
                    attr = reader.GetString(0); //retrieving the attribute of the user/admin

                }

                //currently visualizing the authentication
                if (count == 1)
                {
                    if (attr == "admin") {
                        uname = usernameTextBox.Text;
                        MessageBox.Show("Admin authentication complete");
                    }
                    else
                    {
                        uname = usernameTextBox.Text;
                        MessageBox.Show("User authentication complete");
                    }

                    
                }
                else if (count == 0)
                {
                    MessageBox.Show("Authentication Failed.");
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

           //Redirection to the next form can be placed here
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            //initiating the Register Form
            Register reg = new Register();
            reg.ShowDialog();
        }

        

        private void button2_Click(object sender, EventArgs e)//displays the user's data (temporary)
        {
            UserPanel dataDisplay = new UserPanel();
            this.Hide();
            dataDisplay.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)//ignore
        {

        }

        private void button3_Click(object sender, EventArgs e)//initiating the admin management form (temporary)
        {
            AdminPanel adminManagement = new AdminPanel();
            this.Hide();
            adminManagement.ShowDialog();
            this.Close();
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)//ignore
        {
        }
    }
}
