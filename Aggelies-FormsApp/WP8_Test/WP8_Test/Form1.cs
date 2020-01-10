using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP8_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DonationForm donation = new DonationForm();
            // Show the Donation form
            donation.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.ADS' table. You can move, or remove it, as needed.
            this.aDSTableAdapter.Fill(this.database1DataSet.ADS);
            // TODO: This line of code loads data into the 'database1DataSet.FAVORITES' table. You can move, or remove it, as needed.
            this.fAVORITESTableAdapter.Fill(this.database1DataSet.FAVORITES);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex ==6)
            {
                var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                label1.Text = id.ToString();

                int User_id = 3;

                this.fAVORITESTableAdapter.InsertQuery(9, 9);

            }
     /*       if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
               e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
        //        label1.Text = "";
            }

    */

        }
    }
}
