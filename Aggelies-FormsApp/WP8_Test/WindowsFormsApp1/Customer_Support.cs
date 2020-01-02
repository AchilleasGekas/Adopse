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
        public Customer_Support()
        {
            InitializeComponent();
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
                    string Pass = "";
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

                    if(attachmentFilename.Length != 0)
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

                    this.Close();
               // }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Customer_Support_Load(object sender, EventArgs e)
        {

        }
    }
}
