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
    public partial class Form2 : Form
    {
        //establishing a new connection
        OleDbConnection conn = new OleDbConnection();

        public Form2()
        {
            InitializeComponent();
            //initialization must be done here
            //Do not modify String
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                   @"Data source= C:\Users\zero\source\repos\" +
                   @"LogInRegister\databases\users.mdb";
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

        private void retButton_Click(object sender, EventArgs e)
        {
            //closing up the Registration Form and initiating the LogInUI Form
            Form1 log = new Form1();
            this.Hide();
            log.ShowDialog();
            this.Close();
        }
    }
}
