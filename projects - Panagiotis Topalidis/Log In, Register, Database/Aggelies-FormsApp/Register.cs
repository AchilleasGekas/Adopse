using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Aggelies_FormsApp
{
    public partial class Register : Form
    {
        //establishing a new connection
        OleDbConnection conn = new OleDbConnection();

        public Register()
        {
            InitializeComponent();
            //initialization must be done here
            //Do not modify String
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                   @"Data source= C:\Users\zero\source\repos\" +
                   @"Aggelies-FormsApp\databases\users.mdb";
        }

        private void retButton_Click(object sender, EventArgs e)
        {
            //closing up the Registration Form and initiating the LogInUI Form
            Form1 log = new Form1();
            this.Hide();
            log.ShowDialog();
            this.Close();
        }


        private void confButton_Click(object sender, EventArgs e)
        {
            try
            {
                //opening the new connection
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;

                //inserting in database any information submitted by the user
                command.CommandText = "insert into users " +
                                           "(username,pass,name,sname,email) " +
                                           "values (@username,@pass,@name," +
                                           "@sname,@email)";

                command.Parameters.AddWithValue("@username", usernameTextBox.Text);
                command.Parameters.AddWithValue("@pass", passwordTextBox.Text);
                command.Parameters.AddWithValue("@name", firstNameTextBox.Text);
                command.Parameters.AddWithValue("@sname", lastNameTextBox.Text);
                command.Parameters.AddWithValue("@email", emailTextBox.Text);

                command.ExecuteNonQuery();//executing the query 

                
            }
            catch (Exception ex)
            {
                //message displayed in case there is an error detected
                MessageBox.Show("Failed to connect to data source");
            }
            finally
            {
                //closing up and initiating the LogInUI Form
                conn.Close();
                Form1 log = new Form1();
                this.Hide();
                log.ShowDialog();
                this.Close();

            }


        }

    }
}
