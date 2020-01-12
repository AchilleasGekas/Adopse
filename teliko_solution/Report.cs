using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp1
{
    public partial class Report : Form
    {
        int movX;
        int movY;
        int mov;
        public Report()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
            this.Opacity = 1;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
                this.Opacity = .75;

            }
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {

                if (txtAddsName.Text.Length == 0 || txtAddsCat.Text.Length == 0)
                {
                    MessageBox.Show("Καποιο από τα πεδία όνομα αγγελίας ή κατηγορία αγγελίας είναι κενά");
                }
                else
                {

                    string email = "elbasidis98@gmail.com";
                    string Pass = "BLACKmamba98";
                    string Sub = "Report";
                    string Bod = txtBody.Text;
                    string sender_Email = txtEmail.Text;
                    string AdName = txtAddsName.Text;
                    string AdCat = txtAddsCat.Text;

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    mail.From = new MailAddress(email);
                    mail.To.Add("elbasidis98@gmail.com");
                    mail.Subject = Sub;
                    mail.Body = "Reported from: " + sender_Email + "\nAd Name: " + AdName + "\nAd Category :" + AdCat + "\n\n\n" + Bod;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(email, Pass);
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);

                    MessageBox.Show("Your Mail is sended");

                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
