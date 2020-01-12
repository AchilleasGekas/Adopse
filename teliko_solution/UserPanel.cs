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

namespace WindowsFormsApp1
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

        int movX;
        int movY;
        int mov;
        public UserPanel()
        {
            InitializeComponent();
            //initialization must be done here
            //Do not modify the String
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                   @"Data source=C:\teliko_solution\Database1.mdb;";
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

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //this.aCTIVITY_USERTableAdapter.Insert(Login.uname, DateTime.Today,"UPDATE",Global.getIP());
            int follow = 0;//used to check if the registration will close or not
            //total report, in case data inputed are not as expected
            String report = "UPDATE COULD NOT BE DONE\n\n";
            try
            {
                //opening the new connection
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;

                command.CommandText = "UPDATE users " +
                                           "SET passwd=@passwd,first_name=@first_name,last_name=@last_name," +
                                           "email=@email,address=@address,telephone=@telephone " +
                                           "WHERE username='" + Login.uname + "'";


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
                    Login log = new Login();
                    this.Hide();
                    log.ShowDialog();
                    this.Close();
                }

            }
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            //this.aCTIVITY_USERTableAdapter.Insert(Login.uname, DateTime.Today,"ERASE",Global.getIP());
            int check = 0;
            int check0 = 0;
            try
            {

                //opening the new connection
                conn.Open();

                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = conn;

                //checking if username existed at first
                command2.CommandText = "SELECT username FROM users WHERE username='" + usernameTextBox.Text + "'";

                OleDbDataReader reader1 = command2.ExecuteReader();

                if (reader1.Read())
                {

                    check0 = 1;
                }

                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;

                //Deleting the user from the Database (if they exist)
                command.CommandText = "DELETE FROM users WHERE username='" + usernameTextBox.Text + "'";


                command.ExecuteNonQuery();//executing the query

                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = conn;

                //checking if username exists after the DELETE query
                command1.CommandText = "SELECT username FROM users WHERE username='" + usernameTextBox.Text + "'";

                OleDbDataReader reader = command1.ExecuteReader();

                if (!reader.Read())
                {
                    check = 1;
                }


            }
            catch (Exception ex)
            {
                //message displayed in case there is an error detected
                MessageBox.Show("error");

            }
            finally
            {
                //closing up 
                conn.Close();
                if (check == 1 && check0 == 1)
                {
                    MessageBox.Show("Your account has been successfully erased");
                    Login.uname = null;
                }
                else if (check == 1 && check0 == 0)
                {
                    MessageBox.Show("Unknown username");
                }

            }
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = conn;

                //submitting the query for the user authentication later
                command1.CommandText = "SELECT passwd, first_name, last_name, address, email, telephone FROM users WHERE username='"
                                      + Login.uname + "'";
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
                usernameTextBox.Text = Login.uname;
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
                conn.Close();
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            //updating constantly the username textbox 
            //in order to prevent it from being editted
            usernameTextBox.Text = Login.uname;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void insertAddBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
            //this.aCTIVITY_USERTableAdapter.Insert(Login.uname, DateTime.Today, "INSERT_ADD", Global.getIP());
        }
    }
}
