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
    public partial class test_data : Form
    {
        public test_data()
        {
            InitializeComponent();
        }

        private void test_data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.ADS' table. You can move, or remove it, as needed.
            this.aDSTableAdapter.Fill(this.database1DataSet.ADS);

        }
    }
}
