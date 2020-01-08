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
    public partial class Register : Form
    {
        double nextID;
        //establishing a new connection
        OleDbConnection conn = new OleDbConnection();

        public Register()
        {
            InitializeComponent();
            //initialization must be done here
            //Do not modify the String
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                   @"Data source= C:\Users\Akuma\source\repos\" +
                   @"LogInRegister\databases\Database1.mdb";
        }

        private void confButton_Click(object sender, EventArgs e)
        {
            
            int isNull = 0;//used to check if reader is null
            int follow = 0;//used to check if the registration will close or not
            //total report, in case data inputed are not as expected
            String report ="REGISTRATION IS NOT COMPLETE\n\n"; 
            try
            {
                //opening the new connection
                conn.Open();

                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = conn;

                
                command2.CommandText = "SELECT username FROM users where username='" + usernameTextBox.Text + "'";

                OleDbDataReader reader2 = command2.ExecuteReader();

                if (reader2.Read())//if reader reads data, username already exists
                {
                    isNull = 1;
                    
                }


                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = conn;

                //retrieving the last entry in order to increase the id manually
                command1.CommandText = "SELECT TOP 1 * FROM users ORDER BY user_id DESC";

                OleDbDataReader reader = command1.ExecuteReader();

                while (reader.Read())
                {

                    nextID = reader.GetDouble(0); //retrieving the attribute of the user/admin

                }
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;

                command.CommandText = "insert into users " +
                                           "(user_id,username,passwd,first_name,last_name,email,address,attr,telephone) " +
                                           "values (@user_id,@username,@passwd,@first_name," +
                                           "@last_name,@email,@address,@attr,@telephone)";

                //checking data before passing them to the database using Regular Expressions
                command.Parameters.AddWithValue("@user_id", nextID + 1);

                if (isNull == 0 && Regex.IsMatch(usernameTextBox.Text, @"^[a-zA-Z0-9]+$") && usernameTextBox.Text.Length < 12)
                {
                
                    command.Parameters.AddWithValue("@username", usernameTextBox.Text);
                   
                }
                else
                {
                    report = report + "- Username already exist or is longer than 12 characters or has special characters\n";
                }
                
                

                if (Regex.IsMatch(passwordTextBox.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$") && passwordTextBox.Text.Length < 16)
                {
                    command.Parameters.AddWithValue("@passwd", passwordTextBox.Text);
                }
                else
                {
                    report = report + "- Password must be between 8-15 characters and numbers including at east one lowercase, uppercase letter and a number\n";

                }

                if (Regex.IsMatch(firstNameTextBox.Text, @"^[a-zA-Z]+$") && firstNameTextBox.Text.Length < 15)
                {
                    command.Parameters.AddWithValue("@first_name", firstNameTextBox.Text);
                }
                else
                {
                    report = report + "- First name must include only characters and less than 15\n";
                    
                }

                if (Regex.IsMatch(lastNameTextBox.Text, @"^[a-zA-Z]+$") && lastNameTextBox.Text.Length < 15)
                {
                    command.Parameters.AddWithValue("@last_name", lastNameTextBox.Text);
                }
                else
                {
                    report = report + "- First name must include only characters and less than 15\n";
                    
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

                command.Parameters.AddWithValue("@attr", "User");

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
                    MessageBox.Show("Registration complete");
                    LogIn log = new LogIn();
                    this.Hide();
                    log.ShowDialog();
                    this.Close();
                }
            }
        }


        
        private void retButton_Click(object sender, EventArgs e)
        {
            //closing up the Registration Form 
            this.Close();
        }
    }
}
