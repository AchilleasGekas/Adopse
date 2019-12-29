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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        Register r = new Register();

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void passwdTxtBox_Click(object sender, EventArgs e)
        {
            passwdTxtBox.Clear();
            passwdTxtBox.PasswordChar = '*';
            panel2.BackColor = Color.FromArgb(90, 82, 255);
            passwdTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel1.BackColor = Color.White;
            usernameTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            
        }

        private void usernameTxtBox_Click(object sender, EventArgs e)
        {
            usernameTxtBox.Clear();
            panel1.BackColor = Color.FromArgb(90, 82, 255);
            usernameTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel2.BackColor = Color.White;
            passwdTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            r.Left += 10;
            if (r.Left>=830)
            {
                timer1.Stop();
                this.TopMost = false;
                r.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            r.Left -= 10;
            if (r.Left >= 525)
            {
                
                timer2.Stop();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            r.Show();
        }
    }
}
