using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Oledb;

public class DBConnection
{
	public DBConnection()
	{
       OleDbConnection conn = new OleDbConnection();
        // Do not modify String
        conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data source= C:\Users\zero\source\repos\" +
            @"Aggelies-FormsApp\databases\users.mdb";
        try
        {
            conn.Open();
            string sql = "SELECT username FROM users WHERE id=1";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader reader = command.ExecuteReader();
            string output;
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
