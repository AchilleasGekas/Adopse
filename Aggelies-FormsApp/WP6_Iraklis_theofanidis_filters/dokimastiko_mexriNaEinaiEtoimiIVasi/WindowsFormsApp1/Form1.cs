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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
       //     string conString = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" + Application.StartupPath +"~/ebookstoredb.mdb" ;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ebookstoredbDataSet1.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter1.Fill(this.ebookstoredbDataSet1.category);
            // TODO: This line of code loads data into the 'ebookstoredbDataSet.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.ebookstoredbDataSet.category);

        }

        public static int dokimi ;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                 
                    dokimi = e.RowIndex;
    
            }
            Form2 mp = new Form2();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoryTableAdapter1.FillBy(this.ebookstoredbDataSet1.category);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
