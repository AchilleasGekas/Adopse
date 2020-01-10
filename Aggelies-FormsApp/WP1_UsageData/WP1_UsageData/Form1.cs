using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP1_UsageData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Query1' table. You can move, or remove it, as needed.
            this.query1TableAdapter.Fill(this.database1DataSet1.Query1);
            // TODO: This line of code loads data into the 'database1DataSet.SEARCHED_DATA' table. You can move, or remove it, as needed.
            this.sEARCHED_DATATableAdapter.Fill(this.database1DataSet.SEARCHED_DATA) ;
           
         
}

        private void fillBySearchnCountToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sEARCHED_DATATableAdapter.FillBySearchnCount(this.database1DataSet.SEARCHED_DATA);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBySearchnCountToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.sEARCHED_DATATableAdapter.FillBySearchnCount(this.database1DataSet.SEARCHED_DATA);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillBySearchnCountToolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.sEARCHED_DATATableAdapter.FillBySearchnCount(this.database1DataSet.SEARCHED_DATA);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable DT = this.database1DataSet.Query1;

            DataView dv1 = new DataView(DT);
            DataView dv2 = new DataView(DT);
            dv1.RowFilter = "reason=='Sold'";
            dv2.RowFilter = "reason=='Other'";
            
        }
    }
}
