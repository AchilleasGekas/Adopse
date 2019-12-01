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
                   @"LogInRegister\databases\users.mdb";
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
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
                                      + usernameTextBox.Text + "' and pass='" + passTextBox.Text + "'";

                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = 1;
                    attr = reader.GetString(0); //retrieving the attribute of the user/admin

                }

                //currently visualizing the authentication
                //temporarily until the next page is made
                if (count == 1)
                {
                    if (attr == "admin") {
                        testLabel.Text = "Admin Authentication Complete.";
                    }
                    else
                    {
                        testLabel.Text = "User Authentication Complete.";
                    }
                    

                }
                else if (count == 0)
                {
                    testLabel.Text = "Authentication Failed.";
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

        private void regButton_Click(object sender, EventArgs e)
        {
            //initiating the Register Form
            Form2 reg = new Form2();
            this.Hide();
            reg.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string simpleValue;
            conn.Open();
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = conn;

            //submitting the query for the user authentication later
            command1.CommandText = "SELECT attr FROM users WHERE username='"
                                  + usernameTextBox.Text + "'";
            OleDbDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                simpleValue = reader.GetString(0);
                testLabel.Text = simpleValue;

            }
            
            
        }
    }
}
