using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aggelies_FormsApp
{
    public partial class Form1 : Form
    {
        string u = "one";
        string p = "1234";
        public Form1()
        {
            InitializeComponent();
        }

        private void pword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //only for test purposes, no database connected yet
            TextBox un = uname;
            string text = un.Text;

            TextBox pass = pword;
            string text1 = pass.Text;
            
            if((text==u) && (text1 == p)) {
                label3.Text = "Authentication confirmed!";
            }
           
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            
            Register reg = new Register();
            this.Hide();
            reg.ShowDialog();
            this.Close();

        }
    }
}
