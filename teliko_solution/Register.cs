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
            if (Program.change_lang==false)
            {
                usernameTxtBox_reg.Text = "Username";
                passwdTxtBox_reg.Text = "Password";
                addressTxtBox_reg.Text = "Address";
                emailTxtBox_reg.Text = "E-mail";
                phone_numberTxtBox_reg.Text = "Phone Number" ;
                registerBtn_reg.Text = "Register";
            }
            else
            {
                usernameTxtBox_reg.Text = "Όνομα χρήστη";
                passwdTxtBox_reg.Text = "Κωδικός";
                addressTxtBox_reg.Text = "Διεύθυνση";
                emailTxtBox_reg.Text = "E-mail";
                phone_numberTxtBox_reg.Text = "Αριθμός τηλεφώνου";
                registerBtn_reg.Text = "Εγγραφή";
            }
        }


        private void usernameTxtBox_Click(object sender, EventArgs e)
        {
            usernameTxtBox_reg.Clear();
            panel1.BackColor = Color.FromArgb(90, 82, 255);
            usernameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel2.BackColor = Color.White;
            passwdTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel3.BackColor = Color.White;
            emailTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel4.BackColor = Color.White;
            phone_numberTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel5.BackColor = Color.White;
            addressTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);
        }

        private void passwdTxtBox_Click(object sender, EventArgs e)
        {
            passwdTxtBox_reg.Clear();
            passwdTxtBox_reg.PasswordChar = '*';
            panel2.BackColor = Color.FromArgb(90, 82, 255);
            passwdTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel1.BackColor = Color.White;
            usernameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel3.BackColor = Color.White;
            emailTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel4.BackColor = Color.White;
            phone_numberTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel5.BackColor = Color.White;
            addressTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);
        }
        private void emailTxtBox_Click(object sender, EventArgs e)
        {
            emailTxtBox_reg.Clear();
            panel3.BackColor = Color.FromArgb(90, 82, 255);
            emailTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel1.BackColor = Color.White;
            usernameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel2.BackColor = Color.White;
            passwdTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel4.BackColor = Color.White;
            phone_numberTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel5.BackColor = Color.White;
            addressTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void phone_numberTxtBox_Click(object sender, EventArgs e)
        {
            phone_numberTxtBox_reg.Clear();
            panel4.BackColor = Color.FromArgb(90, 82, 255);
            emailTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel1.BackColor = Color.White;
            usernameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel2.BackColor = Color.White;
            passwdTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel3.BackColor = Color.White;
            phone_numberTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel5.BackColor = Color.White;
            addressTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);
        }

        private void addressTxtBox_Click(object sender, EventArgs e)
        {
            addressTxtBox_reg.Clear();
            panel5.BackColor = Color.FromArgb(90, 82, 255);
            emailTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel1.BackColor = Color.White;
            usernameTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel2.BackColor = Color.White;
            passwdTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel4.BackColor = Color.White;
            phone_numberTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);

            panel3.BackColor = Color.White;
            addressTxtBox_reg.ForeColor = Color.FromArgb(90, 82, 255);
        }

        private void usernameTxtBox_reg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
