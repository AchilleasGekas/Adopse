using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP8_Test
{
    public partial class DonationForm : Form
    {
        public DonationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "";

            string business = "";  // your paypal email
            string description =descriptionTB.Text;            
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

        private void DonationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
