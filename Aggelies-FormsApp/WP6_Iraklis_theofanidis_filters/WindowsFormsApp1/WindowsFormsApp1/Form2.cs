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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
