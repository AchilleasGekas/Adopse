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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Register_Load(object sender, EventArgs e)
        {

        }


        private void usernameTxtBox_Click(object sender, EventArgs e)
        {
            usernameTxtBox.Clear();
            panel1.BackColor = Color.FromArgb(90, 82, 255);
            usernameTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel2.BackColor = Color.White;
            passwdTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel3.BackColor = Color.White;
            emailTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel4.BackColor = Color.White;
            phone_numberTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel5.BackColor = Color.White;
            addressTxtBox.ForeColor = Color.FromArgb(90, 82, 255);
        }

        private void passwdTxtBox_Click(object sender, EventArgs e)
        {
            passwdTxtBox.Clear();
            passwdTxtBox.PasswordChar = '*';
            panel2.BackColor = Color.FromArgb(90, 82, 255);
            passwdTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel1.BackColor = Color.White;
            usernameTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel3.BackColor = Color.White;
            emailTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel4.BackColor = Color.White;
            phone_numberTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel5.BackColor = Color.White;
            addressTxtBox.ForeColor = Color.FromArgb(90, 82, 255);
        }
        private void emailTxtBox_Click(object sender, EventArgs e)
        {
            emailTxtBox.Clear();
            panel3.BackColor = Color.FromArgb(90, 82, 255);
            emailTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel1.BackColor = Color.White;
            usernameTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel2.BackColor = Color.White;
            passwdTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel4.BackColor = Color.White;
            phone_numberTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel5.BackColor = Color.White;
            addressTxtBox.ForeColor = Color.FromArgb(90, 82, 255);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void phone_numberTxtBox_Click(object sender, EventArgs e)
        {
            phone_numberTxtBox.Clear();
            panel4.BackColor = Color.FromArgb(90, 82, 255);
            emailTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel1.BackColor = Color.White;
            usernameTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel2.BackColor = Color.White;
            passwdTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel3.BackColor = Color.White;
            phone_numberTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel5.BackColor = Color.White;
            addressTxtBox.ForeColor = Color.FromArgb(90, 82, 255);
        }

        private void addressTxtBox_Click(object sender, EventArgs e)
        {
            addressTxtBox.Clear();
            panel5.BackColor = Color.FromArgb(90, 82, 255);
            emailTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel1.BackColor = Color.White;
            usernameTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel2.BackColor = Color.White;
            passwdTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel4.BackColor = Color.White;
            phone_numberTxtBox.ForeColor = Color.FromArgb(90, 82, 255);

            panel3.BackColor = Color.White;
            addressTxtBox.ForeColor = Color.FromArgb(90, 82, 255);
        }

        
    }
}
