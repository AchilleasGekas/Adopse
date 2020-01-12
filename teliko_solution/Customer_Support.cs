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
    public partial class Customer_Support : Form
    {
        int movX;
        int movY;
        int mov;
        public Customer_Support()
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //if(txtEmail.Text.Length == 0 || txtPassword.Text.Length == 0)
                //{
                //    MessageBox.Show("Καποιο από τα πεδία είναι κενά");
                // }
                // else
                // {
                string email = "elbasidis98@gmail.com";
                string Pass = "BLACKmamba98";
                string Sub = txtSubject.Text;
                string Bod = txtBody.Text;
                string attachmentFilename = txtAttachment.Text;
                string sender_Email = txtEmail.Text;

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(email);
                mail.To.Add("elbasidis98@gmail.com");
                mail.Subject = Sub;
                mail.Body = sender_Email + " " + Bod;

                if (attachmentFilename.Length != 0)
                {
                    System.Net.Mail.Attachment attachment;
                    attachment = new System.Net.Mail.Attachment(attachmentFilename);
                    mail.Attachments.Add(attachment);
                }

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(email, Pass);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

                MessageBox.Show("Your Mail is sended");
                //            this.aCTIVITY_USERTableAdapter.Insert(Login.uname, DateTime.Today,"CUSTOMER_SUPPORT",Global.getIP());
                this.Close();
                // }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
