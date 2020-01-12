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
    public partial class DonationForm : Form
    {
        int movX;
        int movY;
        int mov;
        public DonationForm()
        {
            InitializeComponent();
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

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DonationForm_Load(object sender, EventArgs e)
        {

        }

        private void donationBtn_Click(object sender, EventArgs e)
        {
            string url = "";

            string business = "";  // your paypal email
            string description = descriptionTB.Text;
            string country = "GR";                  // AU, US, etc.
            string currency = currencyCB.Text;                 // EUR,AUD, USD, etc.

            url += "https://www.paypal.com/cgi-bin/webscr" +
                "?cmd=" + "_donations" +
                "&business=" + business +
                "&lc=" + country +
                "&item_name=" + description +
                "&currency_code=" + currency +
                "&bn=" + "PP%2dDonationsBF";

            System.Diagnostics.Process.Start(url);
            this.Close();
        }
    }
}
