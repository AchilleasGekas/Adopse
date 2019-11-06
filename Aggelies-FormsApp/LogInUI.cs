using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace Aggelies_FormsApp
{
    
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection();
 
        
        public Form1()
        {
            InitializeComponent();
            //initialization must be done here
            // Do not modify String
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                   @"Data source= C:\Users\zero\source\repos\" +
                   @"Aggelies-FormsApp\databases\users.mdb";
        }

        private void pword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;

                command.CommandText = "SELECT * FROM users WHERE username='"
                                      + uname.Text + "' and password='" + pword.Text + "'";

                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {

                    count = 1;
                }

                if (count == 1)
                {
                    label3.Text = "Authentication Complete.";
                }
                else if (count == 0)
                {
                    label3.Text = "Authentication Failed.";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source");
            }
            finally
            {
                conn.Close();
            }

        }

        private void regButton_Click(object sender, EventArgs e)
        {
            
            Register reg = new Register();
            this.Hide();
            reg.ShowDialog();
            this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void aLogInButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;

                command.CommandText = "SELECT * FROM admins WHERE username='"
                                      + uname.Text + "' and password='" + pword.Text + "'";

                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {

                    count = 1;
                }

                if (count == 1)
                {
                    label3.Text = "Authentication Complete.";
                }
                else if (count == 0)
                {
                    label3.Text = "Authentication Failed.";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
