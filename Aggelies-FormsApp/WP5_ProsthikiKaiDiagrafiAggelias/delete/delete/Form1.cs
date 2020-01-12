using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.ADS' table. You can move, or remove it, as needed.
            this.aDSTableAdapter1.Fill(this.database1DataSet1.ADS);
            // TODO: This line of code loads data into the 'database1DataSet.ADS' table. You can move, or remove it, as needed.
            this.aDSTableAdapter.Fill(this.database1DataSet.ADS);

            emfanisiDatagridView2();


        }

        private void emfanisiDatagridView2()
        {
            DataTable dtEmployees = new DataTable();
            string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|Database1.mdb";
            using (OleDbConnection con = new OleDbConnection(connString))
            {
                con.Open();
                string query = "SELECT AD_ID,AD_TITLE,PRICE,DESCRIPTION,STATUS FROM ADS " +
                    " WHERE USER_ID = @USER_ID ";
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@USER_ID", 3);


                    OleDbDataReader reader = cmd.ExecuteReader();

                    dtEmployees.Load(reader);
                }
                con.Close();

            }
            dataGridView2.DataSource = dtEmployees;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
             var senderGrid = (DataGridView)sender;

             if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                 e.RowIndex >= 0 && e.ColumnIndex == 5)
             {
                 var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value); ;
                 label1.Text = id.ToString();

                 string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|Database1.mdb";

          //       aDSTableAdapter.DeleteQuery(Convert.ToString(id));
                 using (OleDbConnection con = new OleDbConnection(connString))
                 {
                     con.Open();

                     string query = "DELETE FROM ADS WHERE AD_ID='" + id + "'";
                     using (OleDbCommand cmd = new OleDbCommand(query, con))
                     {
                         //     cmd.Parameters.AddWithValue("@ID", a);

                         //       OleDbDataReader reader = cmd.ExecuteReader();
                         //    cmd.CommandText = query;
                         int i = cmd.ExecuteNonQuery();
                         if (i >= 1)
                         {
                             MessageBox.Show("Deleted student");
                         }
                         else
                         {
                             MessageBox.Show("Nop");
                         }

                     }

                     con.Close();
                 }



             }
             

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value); ;
                label1.Text = id.ToString();

                string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|Database1.mdb";

                //       aDSTableAdapter.DeleteQuery(Convert.ToString(id));
                using (OleDbConnection con = new OleDbConnection(connString))
                {
                    con.Open();

                    string query = "DELETE FROM ADS WHERE AD_ID='" + id + "'";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        //     cmd.Parameters.AddWithValue("@ID", a);

                        //       OleDbDataReader reader = cmd.ExecuteReader();
                        //    cmd.CommandText = query;
                        int i = cmd.ExecuteNonQuery();
                        if (i >= 1)
                        {
                            MessageBox.Show("Deleted student");
                        }
                        else
                        {
                            MessageBox.Show("Nop");
                        }

                    }

                    con.Close();
                

            }



        }
        }
        
    
    }
}

