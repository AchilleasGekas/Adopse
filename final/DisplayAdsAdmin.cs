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
    
    public partial class DisplayAdsAdmin : Form
    {
        OleDbConnection conn = new OleDbConnection();
        int movX;
        int movY;
        int mov;
        public DisplayAdsAdmin()
        {
            InitializeComponent();

            //initialization must be done here
            //Do not modify the String
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                   @"Data source= C:\Users\Akuma\source\repos\" +
                   @"LogInRegister\databases\Database1.mdb";
        }


        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void displayButton_Click(object sender, EventArgs e)
        {
            int isNull = 0;
            try
            {
                conn.Open();
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = conn;

                command1.CommandText = "SELECT * FROM ads WHERE AD_ID='" + textboxAdId.Text + "'";

                OleDbDataReader reader1 = command1.ExecuteReader();

                if (!reader1.Read())//checking if ad exists
                {
                    isNull = 1;
                }

                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                //double phase;//phase where id is double //were used only for testing
                //Double.TryParse(textboxAdId.Text, out phase); //parsing String to double

                //searching for the ad
                command.CommandText = "SELECT * FROM ads WHERE AD_ID='" + textboxAdId.Text + "'";

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    ad_id_label.Text = reader.GetString(0);
                    ad_title_label.Text = reader.GetString(1);
                    category_id_label.Text = reader.GetDouble(2).ToString();
                    insert_date_label.Text = Convert.ToDateTime(reader["INSERT_DATE"]).ToString("dd/MM/yyyy");
                    finish_date_label.Text = Convert.ToDateTime(reader["FINISH_DATE"]).ToString("dd/MM/yyyy");
                    modify_date_label.Text = Convert.ToDateTime(reader["MODIFY_DATE"]).ToString("dd/MM/yyyy");
                    user_id_label.Text = reader.GetDouble(6).ToString();
                    price_label.Text = reader.GetDouble(7).ToString();
                    description_label.Text = reader.GetString(8);
                    status_label.Text = reader.GetString(9);
                    area_ID_label.Text = reader.GetDouble(10).ToString();
                    discount_price_label.Text = reader.GetDouble(11).ToString();

                }

                if (isNull == 1)//checking if ad exists
                {
                    MessageBox.Show("This ad doesn't exist");
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            int follow = 0;//used to check if the form will close or not
            //total report, in case data inputed are not as expected
            String report = "UPDATE COULD NOT BE DONE\n\n";
            try
            {
                //opening the new connection
                conn.Open();
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = conn;

                //searching for the ad
                command1.CommandText = "SELECT ad_title,category_id,price,description,status,discount_price FROM ads " +
                                      "WHERE ad_id='" + textboxAdId.Text + "'";

                OleDbDataReader reader = command1.ExecuteReader();

                while (reader.Read())//avoiding data loss 
                {
                    if (string.IsNullOrEmpty(textboxAdTitle.Text))
                    {
                        textboxAdTitle.Text = reader.GetString(0);
                    }
                    if (string.IsNullOrEmpty(textboxCategory.Text))
                    {
                        textboxCategory.Text = reader.GetDouble(1).ToString();
                    }
                    if (string.IsNullOrEmpty(textboxPrice.Text))
                    {
                        textboxPrice.Text = reader.GetDouble(2).ToString();
                    }
                    if (string.IsNullOrEmpty(textboxDescription.Text))
                    {
                        textboxDescription.Text = reader.GetString(3);
                    }
                    if (string.IsNullOrEmpty(textboxStatus.Text))
                    {
                        textboxStatus.Text = reader.GetString(4);
                    }
                    if (string.IsNullOrEmpty(textboxDiscount.Text))
                    {
                        textboxDiscount.Text = reader.GetDouble(5).ToString();
                    }


                }


                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;

                //inserting in database any information submitted by the admin
                command.CommandText = "UPDATE ads " +
                                           "SET ad_title=@ad_title,category_id=@category_id,price=@price," +
                                           "description=@description,status=@status,discount_price=@discount_price " +
                                           "WHERE ad_id='" + textboxAdId.Text + "'";

                //checking any data headed to the database
                if (Regex.IsMatch(textboxAdTitle.Text, @"^[a-zA-Z0-9\s]+$") && textboxAdTitle.Text.Length < 30)
                {
                    command.Parameters.AddWithValue("@ad_title", textboxAdTitle.Text);
                }
                else
                {
                    report = report + "- Ad title must inculde in total less than 30 characters and digits\n";

                }

                if (Regex.IsMatch(textboxCategory.Text, @"^[0-9]+$") && textboxCategory.Text.Length < 10)
                {
                    command.Parameters.AddWithValue("@category_id", textboxCategory.Text);
                }
                else
                {
                    report = report + "- Category id must be set using digits\n";

                }

                if (Regex.IsMatch(textboxPrice.Text, @"^[0-9]+$") && textboxPrice.Text.Length < 15)
                {
                    command.Parameters.AddWithValue("@price", textboxPrice.Text);
                }
                else
                {
                    report = report + "- Price must be set using digits\n";

                }

                if (Regex.IsMatch(textboxDescription.Text, @"^(?=.*[0-9 ])(?=.*[a-zA-Z ])([a-zA-Z0-9 ]+)$") && textboxDescription.Text.Length < 100)
                {
                    command.Parameters.AddWithValue("@description", textboxDescription.Text);
                }
                else
                {
                    report = report + "- Description must be set using characters and digits\n";

                }

                if (Regex.IsMatch(textboxStatus.Text, @"^[a-zA-Z]+$") && textboxStatus.Text.Length < 30)
                {
                    command.Parameters.AddWithValue("@status", textboxStatus.Text);
                }
                else
                {
                    report = report + "- Status must be set as pending or sold\n";

                }

                if (Regex.IsMatch(textboxDiscount.Text, @"^[0-9]+$") && textboxDiscount.Text.Length < 30)
                {
                    command.Parameters.AddWithValue("@discount_price", textboxDiscount.Text);
                }
                else
                {
                    report = report + "- Discount price must be set using digits\n";

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
                if (follow == 0)
                {
                    MessageBox.Show("The ad's data has been successfully updated ");
                }
            }
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            int isNull = 0;
            int isNull0 = 0;
            try
            {
                //opening the new connection
                conn.Open();

                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = conn;

                command1.CommandText = "SELECT * FROM ads WHERE AD_ID='" + textboxAdId.Text + "'";

                OleDbDataReader reader1 = command1.ExecuteReader();

                if (reader1.Read())//checking if ad exists before the delete query
                {
                    isNull = 1;
                }

                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;

                //deleting from database the ad with the id retrived from the textbox
                command.CommandText = "DELETE FROM ads WHERE ad_id='" + textboxAdId.Text + "'";


                command.ExecuteNonQuery();//executing the query

                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = conn;

                command2.CommandText = "SELECT * FROM ads WHERE AD_ID='" + textboxAdId.Text + "'";

                OleDbDataReader reader2 = command2.ExecuteReader();

                if (!reader2.Read())//checking if ad exists after the delete query
                {
                    isNull0 = 1;
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
                if (isNull == 1 && isNull0 == 1)//erases ad
                {
                    MessageBox.Show("The ad has been erased");
                }
                else if (isNull == 0 && isNull0 == 1)//in case ad never existed
                {
                    MessageBox.Show("Unknown ad");
                }
            }
        }
    }
}
