using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Usage_Data : Form
    {
        public Usage_Data()
        {
            InitializeComponent();
        }

        private void Usage_Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseLocal.ACTIVITY_USER' table. You can move, or remove it, as needed.
            this.aCTIVITY_USERTableAdapter.Fill(this.databaseLocal.ACTIVITY_USER);
            // TODO: This line of code loads data into the 'databaseLocal.Query1' table. You can move, or remove it, as needed.
            this.query1TableAdapter.Fill(this.databaseLocal.Query1);

        }

        private void load_GraphBtn_Click(object sender, EventArgs e)
        {
            search_dataChart.Series.Add("Searched/Times");
            search_dataChart.Series["Searched/Times"].XValueMember = "SEARCHED_TEXT";
            search_dataChart.Series["Searched/Times"].YValueMembers = "TIMES";

            search_dataChart.DataSource = query1TableAdapter.GetData();
            search_dataChart.DataBind();
            search_dataChart.Visible = true;
        }

        private void load_GraphsBtn_Click(object sender, EventArgs e)
        {
            String valueCB = choose_graph.Text;
            if (valueCB.Equals("NumberofActions"))
            {

                //activity_Graphs2.Visible = false;

                actionsChart.Series.Add("NumberofActions");
                actionsChart.Series["NumberofActions"].XValueMember = "USERNAME";
                actionsChart.Series["NumberofActions"].YValueMembers = "NumberofActions";

                actionsChart.DataSource = aCTIVITY_USERTableAdapter.GetDataByNumberofActions();
                actionsChart.DataBind();


            }
            else if (valueCB.Equals("DonationPressed"))
            {

                // activity_Graphs.Visible = false;

                
                donateChart.Series.Add("DonationPressed");
                donateChart.Series["DonationPressed"].XValueMember = "USERNAME";
                donateChart.Series["DonationPressed"].YValueMembers = "Counter";

                donateChart.DataSource = aCTIVITY_USERTableAdapter.GetDataByDonationPressed();
                donateChart.DataBind();

            }
        }
    }
}
