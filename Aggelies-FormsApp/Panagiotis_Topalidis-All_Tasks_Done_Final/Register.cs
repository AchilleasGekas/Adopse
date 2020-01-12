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
                   @"Data source=C:\teliko_solution\Database1.mdb;";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Register_Load(object sender, EventArgs e)
        {
            if (Program.change_lang==false)
            {
                usernameTxtBox_reg.Text = "Username";
                passwdTxtBox_reg.Text = "Password";
                addressTxtBox_reg.Text = "Address";
                emailTxtBox_reg.Text = "E-mail";
                phone_numberTxtBox_reg.Text = "Phone Number" ;
                registerBtn_reg.Text = "Register";
                fnameTxtBox_reg.Text = "First name";
                lnameTxtBox_reg.Text = "Last name";
            }
            else
            {
                usernameTxtBox_reg.Text = "Όνομα χρήστη";
                passwdTxtBox_reg.Text = "Κωδικός";
                addressTxtBox_reg.Text = "Διεύθυνση";
                emailTxtBox_reg.Text = "E-mail";
                phone_numberTxtBox_reg.Text = "Αριθμός τηλεφώνου";
                registerBtn_reg.Text = "Εγγραφή";
                fnameTxtBox_reg.Text = "Όνομα";
                lnameTxtBox_reg.Text = "Επώνυμο";
            }
        }


        private void usernameTxtBox_Click(object sender, EventArgs e)
        {
            usernameTxtBox_reg.Clear();
            panel1.BackColor = Color.FromArgb(90, 82, 255);
            usernameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel2.BackColor = Color.White;
            passwdTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel3.BackColor = Color.White;
            emailTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel4.BackColor = Color.White;
            phone_numberTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel5.BackColor = Color.White;
            addressTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);
           
            panel6.BackColor = Color.White;
            fnameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);
            
            panel7.BackColor = Color.White;
            lnameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);
        }

        private void passwdTxtBox_Click(object sender, EventArgs e)
        {
            passwdTxtBox_reg.Clear();
            passwdTxtBox_reg.PasswordChar = '*';
            panel2.BackColor = Color.FromArgb(90, 82, 255);
            passwdTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel1.BackColor = Color.White;
            usernameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel3.BackColor = Color.White;
            emailTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel4.BackColor = Color.White;
            phone_numberTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel5.BackColor = Color.White;
            addressTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel6.BackColor = Color.White;
            fnameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel7.BackColor = Color.White;
            lnameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);
        }
        private void emailTxtBox_Click(object sender, EventArgs e)
        {
            emailTxtBox_reg.Clear();
            panel3.BackColor = Color.FromArgb(90, 82, 255);
            emailTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel1.BackColor = Color.White;
            usernameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel2.BackColor = Color.White;
            passwdTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel4.BackColor = Color.White;
            phone_numberTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel5.BackColor = Color.White;
            addressTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel6.BackColor = Color.White;
            fnameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel7.BackColor = Color.White;
            lnameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void phone_numberTxtBox_Click(object sender, EventArgs e)
        {
            phone_numberTxtBox_reg.Clear();
            panel4.BackColor = Color.FromArgb(90, 82, 255);
            emailTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel1.BackColor = Color.White;
            usernameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel2.BackColor = Color.White;
            passwdTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel3.BackColor = Color.White;
            phone_numberTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel5.BackColor = Color.White;
            addressTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel6.BackColor = Color.White;
            fnameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel7.BackColor = Color.White;
            lnameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);
        }

        private void addressTxtBox_Click(object sender, EventArgs e)
        {
            addressTxtBox_reg.Clear();
            panel5.BackColor = Color.FromArgb(90, 82, 255);
            emailTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel1.BackColor = Color.White;
            usernameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel2.BackColor = Color.White;
            passwdTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel4.BackColor = Color.White;
            phone_numberTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel3.BackColor = Color.White;
            addressTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel6.BackColor = Color.White;
            fnameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel7.BackColor = Color.White;
            lnameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);
        }

        private void fnameTxtBox_reg_Click(object sender, EventArgs e)
        {
            fnameTxtBox_reg.Clear();
            panel6.BackColor = Color.FromArgb(90, 82, 255);
            emailTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel1.BackColor = Color.White;
            usernameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel2.BackColor = Color.White;
            passwdTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel4.BackColor = Color.White;
            phone_numberTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel3.BackColor = Color.White;
            addressTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel5.BackColor = Color.White;
            addressTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel7.BackColor = Color.White;
            lnameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);
        }

        private void lnameTextBox_reg_Click(object sender, EventArgs e)
        {
            lnameTxtBox_reg.Clear();
            panel7.BackColor = Color.FromArgb(90, 82, 255);
            emailTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel1.BackColor = Color.White;
            usernameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel2.BackColor = Color.White;
            passwdTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel4.BackColor = Color.White;
            phone_numberTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel3.BackColor = Color.White;
            addressTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel6.BackColor = Color.White;
            fnameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel5.BackColor = Color.White;
            addressTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);
        }

        private void registerBtn_reg_Click(object sender, EventArgs e)
        {
            int isNull = 0;//used to check if reader is null
            int follow = 0;//used to check if the registration will close or not
            //total report, in case data inputed are not as expected
            String report = "REGISTRATION IS NOT COMPLETE\n\n";
            try
            {
                //opening the new connection
                conn.Open();

                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = conn;


                command2.CommandText = "SELECT username FROM users where username='" + usernameTxtBox_reg.Text + "'";

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

                //!URGENT! requires first and last name 
                command.CommandText = "insert into users " +
                                           "(user_id,username,passwd,first_name,last_name," +
                                           "email,address,attr,telephone) " +
                                           "values (@user_id,@username,@passwd,@first_name,@last_name," +
                                           "@email,@address,@attr,@telephone)";

                //checking data before passing them to the database using Regular Expressions
                command.Parameters.AddWithValue("@user_id", nextID + 1);

                if (isNull == 0 && Regex.IsMatch(usernameTxtBox_reg.Text, @"^[a-zA-Z0-9]+$") && usernameTxtBox_reg.Text.Length < 12)
                {

                    command.Parameters.AddWithValue("@username", usernameTxtBox_reg.Text);

                }
                else
                {
                    report = report + "- Username already exist or is longer than 12 characters or has special characters\n";
                }



                if (Regex.IsMatch(passwdTxtBox_reg.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$") && passwdTxtBox_reg.Text.Length < 16)
                {
                    command.Parameters.AddWithValue("@passwd", passwdTxtBox_reg.Text);
                }
                else
                {
                    report = report + "- Password must be between 8-15 characters and numbers including at east one lowercase, uppercase letter and a number\n";

                }

                if (Regex.IsMatch(fnameTxtBox_reg.Text, @"^[a-zA-Z]+$") && fnameTxtBox_reg.Text.Length < 15)
                {
                    command.Parameters.AddWithValue("@first_name", fnameTxtBox_reg.Text);
                }
                else
                {
                    report = report + "- First name must include only characters and less than 15\n";

                }

                if (Regex.IsMatch(lnameTxtBox_reg.Text, @"^[a-zA-Z]+$") && lnameTxtBox_reg.Text.Length < 15)
                {
                    command.Parameters.AddWithValue("@last_name", lnameTxtBox_reg.Text);
                }
                else
                {
                    report = report + "- First name must include only characters and less than 15\n";

                }

                
                if (Regex.IsMatch(emailTxtBox_reg.Text, @"\A(?:[a-z0-9]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z](?:[a-z]*[a-z])?)\Z"))
                {
                    command.Parameters.AddWithValue("@email", emailTxtBox_reg.Text);
                }
                else
                {
                    report = report + "- Invalid email\n";

                }

                if (Regex.IsMatch(addressTxtBox_reg.Text, @"^[a-zA-Z0-9\s]+$") && addressTxtBox_reg.Text.Length < 15)
                {
                    command.Parameters.AddWithValue("@address", addressTxtBox_reg.Text);
                }
                else
                {
                    report = report + "- Address must include only characters and numbers\n";

                }

                command.Parameters.AddWithValue("@attr", "User");

                if (Regex.IsMatch(phone_numberTxtBox_reg.Text, @"^[0-9]+$") && phone_numberTxtBox_reg.Text.Length == 10)
                {
                    command.Parameters.AddWithValue("@telephone", phone_numberTxtBox_reg.Text);
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

                    this.Hide();

                    this.Close();
                }
            }
        }
    }
}
