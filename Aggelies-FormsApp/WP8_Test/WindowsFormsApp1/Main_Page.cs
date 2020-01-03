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
    public partial class Main_Page : Form
    {

        

        
        
        public Main_Page()
        {
            InitializeComponent();
        }



        int movX;
        int movY;
        int mov;
        private void Main_Page_Load(object sender, EventArgs e)
        {
            if (Program.change_lang == false)
            {
                home_button_main.Text = "     Home";
                back_button_main.Text = "     Back";
                usern_main_label.Text = "User";
                Log_in_label_main.Text = "Log in / Register";
            }
            else
            {
                home_button_main.Text = "     Αρχική";
                back_button_main.Text = "     Πίσω";
                usern_main_label.Text = "Χρήστης";
                Log_in_label_main.Text = "Σύνδεση / Εγγραφή";
            }
            populateItems();
            populateItems2();
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void populateItems()
        {
            Ad_ListItem[] listItems = new Ad_ListItem[20];

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new Ad_ListItem();
                listItems[i].Title = "mple";
                listItems[i].Message = "7.30";

               // if (flowLayoutPanel1.Controls.Count > 0)
               // {
                //    flowLayoutPanel1.Controls.Clear();
                //}
                //else
                    flowLayoutPanel1.Controls.Add(listItems[i]);
                
            }

        }

        private void populateItems2()
        {
            Filters_left[] listItems = new Filters_left[20];

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new Filters_left();
                listItems[i].Title = "mple";

                // if (flowLayoutPanel1.Controls.Count > 0)
                // {
                //    flowLayoutPanel1.Controls.Clear();
                //}
                //else
                flowLayoutPanel2.Controls.Add(listItems[i]);


            }

        }

        
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
                this.Opacity = .75;

            }
        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
            this.Opacity = 1;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_button_Click(object sender, EventArgs e)
        {
            
            panel_home.Height = home_button_main.Height;
            panel_home.Top = home_button_main.Top;
            Welcome_Page wp1 = new Welcome_Page();
            this.Hide();
            wp1.ShowDialog();
            this.Close();
            //Ad_ListItem.BringToFront();

        }

        private void back_button_Click(object sender, EventArgs e)
        {

            panel_back.Height = back_button_main.Height;
            panel_back.Top = back_button_main.Top;
            Welcome_Page wp = new Welcome_Page();
            this.Hide();
            wp.ShowDialog();
            this.Close();

        }

        private void Log_in_label_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            
            l.ShowDialog();
        }
        
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Program.change_lang = true;
                home_button_main.Text = "     Αρχική";
                back_button_main.Text = "     Πίσω";
                usern_main_label.Text = "Χρήστης";
                Log_in_label_main.Text = "Σύνδεση / Εγγραφή";
                

            }
            else
            {
                Program.change_lang = false;
                home_button_main.Text = "     Home";
                back_button_main.Text = "     Back";
                usern_main_label.Text = "User";
                Log_in_label_main.Text = "Log in / Register";
            }
        }

        private void Customer_Support_Click(object sender, EventArgs e)
        {
           Customer_Support cus = new Customer_Support();
           cus.ShowDialog();

            //Kanei to idio pragma apla kleinei to proigoumeno parathiro

           // Customer_Support cus = new Customer_Support();
           // this.Hide();
           // cus.ShowDialog();
           // this.Close();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            Report rep = new Report();
            rep.ShowDialog();

            //Kanei to idio pragma apla kleinei to proigoumeno parathiro

            // Report rep = new Report();
            // this.Hide();
            // rep.ShowDialog();
            // this.Close();
        }

        private void Prosfores_Click(object sender, EventArgs e)
        {

        }
    }
}
    

