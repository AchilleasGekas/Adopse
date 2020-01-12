using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            // TODO: This line of code loads data into the 'database1DataSet.ACTIVITY_USER' table. You can move, or remove it, as needed.
            this.aCTIVITY_USERTableAdapter.Fill(this.database1DataSet.ACTIVITY_USER);
            // TODO: This line of code loads data into the 'database1DataSet1.Query1' table. You can move, or remove it, as needed.
            this.query1TableAdapter.Fill(this.database1DataSet1.Query1);
            // TODO: This line of code loads data into the 'database1DataSet.SEARCHED_DATA' table. You can move, or remove it, as needed.
            this.sEARCHED_DATATableAdapter.Fill(this.database1DataSet.SEARCHED_DATA);

           
        } 

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       


        private void button1_Click(object sender, EventArgs e)
            
        {
            chart1.Series.Add("Searched/Times");
            chart1.Series["Searched/Times"].XValueMember = "SEARCHED_TEXT";
            chart1.Series["Searched/Times"].YValueMembers = "TIMES";

            chart1.DataSource = query1TableAdapter.GetData();
            chart1.DataBind();
            chart1.Visible = true;
            
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void load_GraphsBtn_Click(object sender, EventArgs e)
        {
            String valueCB = choose_graph.Text;
            if (valueCB.Equals("NumberofActions"))
            {


                //activity_Graphs2.Visible = false;
                Console.WriteLine ( "1");
                activity_Graphs.Series.Add("NumberofActions");
                activity_Graphs.Series["NumberofActions"].XValueMember = "USERNAME";
                activity_Graphs.Series["NumberofActions"].YValueMembers = "NumberofActions";

                activity_Graphs.DataSource = aCTIVITY_USERTableAdapter.GetDataByNumberofActions();
                activity_Graphs.DataBind();
                

            }
            else if(valueCB.Equals("DonationPressed"))
            {

               // activity_Graphs.Visible = false;
                
                activity_Graphs2.Series.Dispose();
                activity_Graphs2.Series.Add("DonationPressed");
                activity_Graphs2.Series["DonationPressed"].XValueMember = "USERNAME";
                activity_Graphs2.Series["DonationPressed"].YValueMembers = "Counter";

                activity_Graphs2.DataSource = aCTIVITY_USERTableAdapter.GetDataByDonationPressed();
                activity_Graphs2.DataBind();
            
            }
        }

        private void choose_graph_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
