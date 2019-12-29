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
    public partial class Welcome_Page : Form
    {
        public Welcome_Page()
        {
            InitializeComponent();
            textBox1.AutoSize = false;
        }

        int movX;
        int movY;
        int mov;

        private void Bottom_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Welcome_Page_Load(object sender, EventArgs e)
        {

        }

        private void Search_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void Maximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
        {
                this.WindowState = FormWindowState.Maximized;
            }
        else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov==1)
            {
                this.SetDesktopLocation(MousePosition.X-movX,MousePosition.Y-movY);
                this.Opacity = .75;

            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
            this.Opacity = 1;
        }


        //go to main page
        //Τεχνολογια main page
        private void pcBtn_Click(object sender, EventArgs e)
        {
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void telephoneBtn_Click(object sender, EventArgs e)
        {
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void sound_devicesBtn_Click(object sender, EventArgs e)
        {
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void televisionBtn_Click(object sender, EventArgs e)
        {
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void photoBtn_Click(object sender, EventArgs e)
        {
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void house_devices_Click(object sender, EventArgs e)
        {
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        //Οχήματα main page
        private void autoBtn_Click(object sender, EventArgs e)
        {
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void motoBtn_Click(object sender, EventArgs e)
        {
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void boatBtn_Click(object sender, EventArgs e)
        {
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void more_vehicles_Click(object sender, EventArgs e)
        {
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void accesoriesBtn_Click(object sender, EventArgs e)
        {
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }
        private void prof_vehiclesBtn_Click(object sender, EventArgs e)
        {
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        //Σπίτι main page
        private void apartmentsBtn_Click(object sender, EventArgs e)
        {
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void vilesBtn_Click(object sender, EventArgs e)
        {
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void prof_housesBtn_Click(object sender, EventArgs e)
        {
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void landBtn_Click(object sender, EventArgs e)
        {
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void summer_housesBtn_Click(object sender, EventArgs e)
        {
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void parkingBtn_Click(object sender, EventArgs e)
        {
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void Log_in_label_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            
            l.ShowDialog();
        }
    }
}
