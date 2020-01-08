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
using System.Text.RegularExpressions;

namespace LogInRegister
{
    public partial class UserPanel : Form
    {
        String passwd;
        String fname;
        String lname;
        String address;
        String email;
        String phone;

        //establishing a new connection
        OleDbConnection conn = new OleDbConnection();

        public UserPanel()
        {
            InitializeComponent();
            //initialization must be done here
            //Do not modify the String
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                   @"Data source= C:\Users\Akuma\source\repos\" +
                   @"LogInRegister\databases\Database1.mdb";
        }


            
        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            //updating constantly the username textbox 
            //in order to prevent it from being editted
            usernameTextBox.Text = LogIn.uname;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = conn;

                //submitting the query for the user authentication later
                command1.CommandText = "SELECT passwd, first_name, last_name, address, email, telephone FROM users WHERE username='"
                                      + LogIn.uname + "'";
                OleDbDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    passwd = reader.GetString(0);
                    fname = reader.GetString(1);
                    lname = reader.GetString(2);
                    address = reader.GetString(3);
                    email = reader.GetString(4);
                    phone = reader.GetString(5);
                }
                usernameTextBox.Text = LogIn.uname;
                passwordTextBox.Text = passwd;
                nameTextBox.Text = fname;
                snameTextBox.Text = lname;
                addressTextBox.Text = address;
                emailTextBox.Text = email;
                phoneTextBox.Text = phone;
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

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int follow = 0;//used to check if the registration will close or not
            //total report, in case data inputed are not as expected
            String report = "REGISTRATION IS NOT COMPLETE\n\n";
            try
            {
                //opening the new connection
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;

                command.CommandText = "UPDATE users " +
                                           "SET passwd=@passwd,first_name=@first_name,last_name=@last_name," +
                                           "email=@email,address=@address,telephone=@telephone " +
                                           "WHERE username='"+LogIn.uname+"'";


                //checking data before passing them to the database
                if (Regex.IsMatch(passwordTextBox.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$") && passwordTextBox.Text.Length < 16)
                {
                    command.Parameters.AddWithValue("@passwd", passwordTextBox.Text);
                }
                else
                {
                    report = report + "- Password must be between 8-15 characters and numbers including at east one lowercase, uppercase letter and a number\n";

                }

                if (Regex.IsMatch(nameTextBox.Text, @"^[a-zA-Z]+$") && nameTextBox.Text.Length < 15)
                {
                    command.Parameters.AddWithValue("@first_name", nameTextBox.Text);
                }
                else
                {
                    report = report + "- First name must include only characters and less than 15\n";

                }

                if (Regex.IsMatch(snameTextBox.Text, @"^[a-zA-Z]+$") && snameTextBox.Text.Length < 15)
                {
                    command.Parameters.AddWithValue("@last_name", snameTextBox.Text);
                }
                else
                {
                    report = report + "- Last name must include only characters and less than 15\n";

                }

                //yes, extensively long Regular Expression
                if (Regex.IsMatch(emailTextBox.Text, @"\A(?:[a-z0-9]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z](?:[a-z]*[a-z])?)\Z"))
                {
                    command.Parameters.AddWithValue("@email", emailTextBox.Text);
                }
                else
                {
                    report = report + "- Invalid email\n";

                }

                if (Regex.IsMatch(addressTextBox.Text, @"^[a-zA-Z0-9\s]+$") && addressTextBox.Text.Length < 15)
                {
                    command.Parameters.AddWithValue("@address", addressTextBox.Text);
                }
                else
                {
                    report = report + "- Address must include only characters and numbers\n";

                }

                if (Regex.IsMatch(phoneTextBox.Text, @"^[0-9]+$") && phoneTextBox.Text.Length == 10)
                {
                    command.Parameters.AddWithValue("@telephone", phoneTextBox.Text);
                }
                else
                {
                    report = report + "- Phone Number must include only numbers and have 10 digits length\n";

                }


                command.ExecuteNonQuery();//executing the query 


            }
            catch (Exception ex)
            {
                //message displayed in case there is an error detected
                MessageBox.Show(report);
                follow = 1;
            }
            finally
            {
                //closing up and initiating the LogInUI Form
                conn.Close();
                //if registration is completed the form closes and return to the previous form
                if (follow == 0)
                {
                    MessageBox.Show("Data has been successfully updated");
                    LogIn log = new LogIn();
                    this.Hide();
                    log.ShowDialog();
                    this.Close();
                }

            }
        }
    }
}
