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
    public partial class Form2 : Form
    {
        public string UserName { get; set; }
        
        public Form2()
        {
            InitializeComponent();
           
            this.label1.Text = Form1.dokimi.ToString();
            if(Form1.dokimi==0) 
            {
                dataGridView1.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.dataSet2.product);
            // TODO: This line of code loads data into the 'dataSet11.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.dataSet11.product);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
