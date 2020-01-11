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
    public partial class Login : Form
    {

        //retrieve the username for the whole application from HERE
        //this is the current "session's" username
        public static String uname = "";
        //establishing a new connection
        OleDbConnection conn = new OleDbConnection();

        public Login()
        {
            InitializeComponent();
            //initialization must be done here
            //Do not modify the String
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                   @"Data source= C:\Users\Akuma\source\repos\" +
                   @"LogInRegister\databases\Database1.mdb";
        }


        Register r = new Register();

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void passwdTxtBox_Click(object sender, EventArgs e)
        {
            passwdTxtBox.Clear();
            passwdTxtBox.PasswordChar = '*';
            panel2.BackColor = Color.FromArgb(90, 82, 255);
            passwdTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel1.BackColor = Color.White;
            usernameTxtBox.ForeColor = Color.FromArgb(90, 82, 255);


        }

        private void usernameTxtBox_Click(object sender, EventArgs e)
        {
            usernameTxtBox.Clear();
            panel1.BackColor = Color.FromArgb(90, 82, 255);
            usernameTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel2.BackColor = Color.White;
            passwdTxtBox.ForeColor = Color.FromArgb(90, 82, 255);


        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            //initiating the Register Form
            Register reg = new Register();
            reg.ShowDialog();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            //let blank to avoid confusion
        }

        private void usernameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //usernameTxtBox.Clear();
            panel1.BackColor = Color.FromArgb(90, 82, 255);
            usernameTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel2.BackColor = Color.White;
            passwdTxtBox.ForeColor = Color.FromArgb(90, 82, 255);


            try
            {
                string attr = "";
                //opening the new connection
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;

                //submitting the query for the user authentication later
                command.CommandText = "SELECT attr FROM users WHERE username='"
                                      + usernameTxtBox.Text + "' and passwd='" + passwdTxtBox.Text + "'";

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
                    if (attr == "Admin")
                    {
                        uname = usernameTxtBox.Text;
                        MessageBox.Show("Admin authentication complete");
                    }
                    else
                    {
                        uname = usernameTxtBox.Text;
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
                conn.Close();
            }

            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
            

            //Any redirection to the next form can be placed here
        }
    }
}
