﻿using System;
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
    public partial class DisplayUsersAdmin : Form
    {
        OleDbConnection conn = new OleDbConnection();
        int yAxis = 90; //positioning on y Axis
        int xAxis = 0; //positioning on x Axis, although not being used currently
        double id; //used to retrived the id
        int res; //used for id type cast
        String usern;//variables for the data retrived from the textboxes
        String passwd;
        String fname;
        String lname;
        String address;
        String email;
        String attr;
        String phone;
        int movX;
        int movY;
        int mov;
        public DisplayUsersAdmin()
        {
            InitializeComponent();

            //initialization must be done here
            //Do not modify the String
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                   @"Data source= C:\Users\Akuma\source\repos\" +
                   @"LogInRegister\databases\Database1.mdb";
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            int isNull = 0; //used for the pop up message 
            int follow = 0; //used to check if the update will be done or not
            //total report, in case data inputed are not as expected
            String report = "REGISTRATION IS NOT COMPLETE\n\n";
            try
            {
                //opening the new connection
                conn.Open();
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = conn;

                //submitting the query for the user authentication later
                command1.CommandText = "SELECT * FROM users " +
                                      "WHERE username='" + textboxUNAME.Text + "'";

                OleDbDataReader reader = command1.ExecuteReader();

                while (reader.Read())//avoiding data loss 
                {
                    if (string.IsNullOrEmpty(textboxFNAME.Text))
                    {
                        textboxFNAME.Text = reader.GetString(1);
                    }
                    if (string.IsNullOrEmpty(textboxLNAME.Text))
                    {
                        textboxLNAME.Text = reader.GetString(2);
                    }
                    if (string.IsNullOrEmpty(textboxPASS.Text))
                    {
                        textboxPASS.Text = reader.GetString(4);
                    }
                    if (string.IsNullOrEmpty(textboxEMAIL.Text))
                    {
                        textboxEMAIL.Text = reader.GetString(5);
                    }
                    if (string.IsNullOrEmpty(textboxADD.Text))
                    {
                        textboxADD.Text = reader.GetString(6);
                    }
                    if (string.IsNullOrEmpty(textboxATTR.Text))
                    {
                        textboxATTR.Text = reader.GetString(7);
                    }
                    if (string.IsNullOrEmpty(textboxPHONE.Text))
                    {
                        textboxPHONE.Text = reader.GetString(8);
                    }

                }

                conn.Close();

                //opening the new connection
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;

                //int idINT = 0;
                //Int32.TryParse(textboxID.Text, out idINT); //do not touch, only for testing
                //textboxLNAME.Text = null;

                //inserting in database any information submitted by the user
                command.CommandText = "UPDATE users " +
                                           "SET passwd=@passwd,first_name =@first_name,last_name=@last_name," +
                                           "email=@email,address=@address,attr=@attr,telephone=@telephone " +
                                           "WHERE username='" + textboxUNAME.Text + "'";

                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = conn;

                command2.CommandText = "SELECT username FROM users WHERE username='" + textboxUNAME.Text + "'";

                OleDbDataReader reader1 = command2.ExecuteReader();

                if (reader1.Read())//if reader reads data, username already exists
                {
                    isNull = 1;

                }

                //Regular Expression tests below
                if (Regex.IsMatch(textboxPASS.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$") && textboxPASS.Text.Length < 16)
                {
                    command.Parameters.AddWithValue("@passwd", textboxPASS.Text);
                }
                else
                {
                    report = report + "- Password must be between 8-15 characters and numbers including at east one lowercase, uppercase letter and a number\n";

                }

                if (Regex.IsMatch(textboxFNAME.Text, @"^[a-zA-Z]+$") && textboxFNAME.Text.Length < 15)
                {
                    command.Parameters.AddWithValue("@first_name", textboxFNAME.Text);
                }
                else
                {
                    report = report + "- First name must include only characters and less than 15\n";

                }

                if (Regex.IsMatch(textboxLNAME.Text, @"^[a-zA-Z]+$") && textboxLNAME.Text.Length < 15)
                {
                    command.Parameters.AddWithValue("@last_name", textboxLNAME.Text);
                }
                else
                {
                    report = report + "- First name must include only characters and less than 15\n";

                }

                if (Regex.IsMatch(textboxEMAIL.Text, @"\A(?:[a-z0-9]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z](?:[a-z]*[a-z])?)\Z"))
                {
                    command.Parameters.AddWithValue("@email", textboxEMAIL.Text);
                }
                else
                {
                    report = report + "- Invalid email\n";

                }

                if (Regex.IsMatch(textboxADD.Text, @"^[a-zA-Z0-9\s]+$") && textboxADD.Text.Length < 15)
                {
                    command.Parameters.AddWithValue("@address", textboxADD.Text);
                }
                else
                {
                    report = report + "- Address must include only characters and numbers\n";

                }

                if (textboxATTR.Text == "User" || textboxATTR.Text == "Admin")
                {
                    command.Parameters.AddWithValue("@attr", textboxATTR.Text);
                }
                else
                {
                    report = report + "- Attribute can be changed to either User or Admin\n";
                }

                if (Regex.IsMatch(textboxPHONE.Text, @"^[0-9]+$") && textboxPHONE.Text.Length == 10)
                {
                    command.Parameters.AddWithValue("@telephone", textboxPHONE.Text);
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
                if (isNull == 0)
                {
                    MessageBox.Show("Username doesn't exist");
                    follow = 1;
                }
                else
                {
                    MessageBox.Show(report);
                    follow = 1;
                }
            }
            finally
            {
                //closing up 
                conn.Close();
                if (follow == 0)
                {
                    MessageBox.Show("The user's data has been successfully updated");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //opening the new connection
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;

                //submitting the query for the user authentication later
                command.CommandText = "SELECT * FROM users WHERE username='" + textboxUNAME.Text + "'";

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //displaying every info retrieved from the database in labels
                    yAxis = yAxis + 40;
                    xAxis = 20;

                    res = Convert.ToInt32(reader.GetDouble(0));
                    idLabel.Text = res.ToString();


                    fname = reader.GetString(1);
                    fnameLabel.Text = fname;


                    lname = reader.GetString(2);
                    lnameLabel.Text = lname;


                    usern = reader.GetString(3);
                    usernameLabel.Text = usern;


                    passwd = reader.GetString(4);
                    passwordLabel.Text = passwd;


                    email = reader.GetString(5);
                    emailLabel.Text = email;


                    address = reader.GetString(6);
                    addressLabel.Text = address;


                    attr = reader.GetString(7);
                    attributeLabel.Text = attr;


                    phone = reader.GetString(8);
                    phoneLabel.Text = phone;



                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error detected");

            }
            finally
            {
                //closing up 
                conn.Close();
            }
        
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int check = 0;
            int check0 = 0;
            try
            {

                //opening the new connection
                conn.Open();

                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = conn;

                //checking if username existed at first
                command2.CommandText = "SELECT username FROM users WHERE username='" + textboxUNAME.Text + "'";

                OleDbDataReader reader1 = command2.ExecuteReader();

                if (reader1.Read())
                {

                    check0 = 1;
                }

                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;

                //Deleting the user from the Database (if they exist)
                command.CommandText = "DELETE FROM users WHERE username='" + textboxUNAME.Text + "'";


                command.ExecuteNonQuery();//executing the query

                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = conn;

                //checking if username exists after the DELETE query
                command1.CommandText = "SELECT username FROM users WHERE username='" + textboxUNAME.Text + "'";

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
                    MessageBox.Show("The user's data has been successfully ereased");
                }
                else if (check == 1 && check0 == 0)
                {
                    MessageBox.Show("Unknown username");
                }

            }
        }
    }
}
