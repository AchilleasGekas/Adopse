﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Welcome_Page : Form
    {
        
        public Welcome_Page()
        {
            
            InitializeComponent();
            searchboxTxtBox.AutoSize = false;

        }
        /*public Welcome_Page(Main_Page mple)
        {
            InitializeComponent();
            textBox1.AutoSize = false;
            change_language_label.Click += new EventHandler(change_language_label_Click);
            mple = mp;
        }
        */
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
            if (Program.change_lang == false)
            {
                //Welcome page


                pcBtn.Text = "Pc and Laptop";
                telephoneBtn.Text = "Telephone";
                sound_devicesBtn.Text = "Sound Devices";
                televisionBtn.Text = "TV";
                photoBtn.Text = "Photography";
                house_devices.Text = "Home Appliances";
                tech_label.Text = "Technology";

                autoBtn.Text = "Automobile";
                motoBtn.Text = "Motorcycles";
                prof_vehiclesBtn.Text = "Commercial Vehicles";
                boatBtn.Text = "Yachts and Boats";
                more_vehicles.Text = "Other Vehicles";
                accesoriesBtn.Text = "Spare parts";
                auto_label.Text = "Vehicles";

                apartmentsBtn.Text = "Apartments";
                vilesBtn.Text = "Detached and Luxury houses";
                prof_housesBtn.Text = "Professional Spaces";
                landBtn.Text = "Land";
                summer_housesBtn.Text = "Vacation houses";
                parkingBtn.Text = "Parking";
                home_label.Text = "Houses";

                Search_button.Text = "Search";
                Log_in_label.Text = "Log in / Resister";
            }
            }

        private void Search_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                tech_panel.Size = new Size(531,480);
                auto_panel.Size = new Size(531, 480);
                auto_panel.Location = new Point(664, 57);
                house_panel.Size = new Size(531, 480);
                house_panel.Location = new Point(1291, 57);
                panel6.Size = new Size(1100, 38);
                searchboxTxtBox.Size = new Size(916, 38);
                Search_button.Location = new Point(917, 0);
                //tech panel
                pcBtn.Size = new Size(278,77);
                telephoneBtn.Size = new Size(278, 77);
                telephoneBtn.Location = new Point(258, 81);
                sound_devicesBtn.Size = new Size(278, 77);
                sound_devicesBtn.Location = new Point(258, 162);
                televisionBtn.Size = new Size(278, 77);
                televisionBtn.Location = new Point(258, 243);
                photoBtn.Size = new Size(278, 77);
                photoBtn.Location = new Point(258, 324);
                house_devices.Size = new Size(278, 77);
                house_devices.Location = new Point(258, 405);

                //auto panel
                autoBtn.Size = new Size(278, 77);
                motoBtn.Size = new Size(278, 77);
                motoBtn.Location = new Point(261, 81);
                prof_vehiclesBtn.Size = new Size(278, 77);
                prof_vehiclesBtn.Location = new Point(261, 162);
                boatBtn.Size = new Size(278, 77);
                boatBtn.Location = new Point(261, 243);
                more_vehicles.Size = new Size(278, 77);
                more_vehicles.Location = new Point(261, 324);
                accesoriesBtn.Size = new Size(278, 77);
                accesoriesBtn.Location = new Point(261, 405);
                //house panel
                apartmentsBtn.Size = new Size(278, 77);
                vilesBtn.Size = new Size(278, 77);
                vilesBtn.Location = new Point(261, 81);
                prof_housesBtn.Size = new Size(278, 77);
                prof_housesBtn.Location = new Point(261, 162);
                landBtn.Size = new Size(278, 77);
                landBtn.Location = new Point(261, 243);
                summer_housesBtn.Size = new Size(278, 77);
                summer_housesBtn.Location = new Point(261, 324);
                parkingBtn.Size = new Size(278, 77);
                parkingBtn.Location = new Point(261, 405);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                tech_panel.Size = new Size(331, 280);
                auto_panel.Size = new Size(331, 280);
                auto_panel.Location = new Point(414, 57);
                house_panel.Size = new Size(331, 280);
                house_panel.Location = new Point(791, 57);
                panel6.Size = new Size(638, 38);
                searchboxTxtBox.Size = new Size(470, 38);
                Search_button.Location = new Point(471, 0);
                //tech panel
                pcBtn.Size = new Size(173, 45);
                telephoneBtn.Size = new Size(173, 45);
                telephoneBtn.Location = new Point(158, 47);
                sound_devicesBtn.Size = new Size(173, 45);
                sound_devicesBtn.Location = new Point(158, 94);
                televisionBtn.Size = new Size(173, 45);
                televisionBtn.Location = new Point(158, 141);
                photoBtn.Size = new Size(173, 45);
                photoBtn.Location = new Point(158, 188);
                house_devices.Size = new Size(173, 45);
                house_devices.Location = new Point(158, 235);
                //auto panel
                autoBtn.Size = new Size(173, 45);
                motoBtn.Size = new Size(173, 45);
                motoBtn.Location = new Point(161, 47);
                prof_vehiclesBtn.Size = new Size(173, 45);
                prof_vehiclesBtn.Location = new Point(161, 94);
                boatBtn.Size = new Size(173, 45);
                boatBtn.Location = new Point(161, 141);
                more_vehicles.Size = new Size(173, 45);
                more_vehicles.Location = new Point(161, 188);
                accesoriesBtn.Size = new Size(173, 45);
                accesoriesBtn.Location = new Point(161, 235);
                //house panel
                apartmentsBtn.Size = new Size(173, 45);
                vilesBtn.Size = new Size(173, 45);
                vilesBtn.Location = new Point(161, 47);
                prof_housesBtn.Size = new Size(173, 45);
                prof_housesBtn.Location = new Point(161, 94);
                landBtn.Size = new Size(173, 45);
                landBtn.Location = new Point(161, 141);
                summer_housesBtn.Size = new Size(173, 45);
                summer_housesBtn.Location = new Point(161, 188);
                parkingBtn.Size = new Size(173, 45);
                parkingBtn.Location = new Point(161, 235);
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
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
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


        
       
             

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Program.change_lang = true;
                pcBtn.Text = "Pc και Laptop";
                telephoneBtn.Text = "Τηλεφωνία";
                sound_devicesBtn.Text = "Συσκευές ήχου";
                televisionBtn.Text = "Τηλεοράσεις";
                photoBtn.Text = "Φωτογραφία και Βίντεο";
                house_devices.Text = "Οικιακές Συσκευές";
                tech_label.Text = "Τεχνολογία";

                autoBtn.Text = "Αυτοκίνητα";
                motoBtn.Text = "Μηχανές";
                prof_vehiclesBtn.Text = "Εππαγγελμπατικά Οχήματα";
                boatBtn.Text = "Σκάφη";
                more_vehicles.Text = "Άλλα Οχήματα";
                accesoriesBtn.Text = "Ανταλλακτικά και Αξεσουάρ";
                auto_label.Text = "Οχήματα";

                apartmentsBtn.Text = "Διαμερίσματα";
                vilesBtn.Text = "Μονοκατοικίες και Βίλες";
                prof_housesBtn.Text = "Εππαγγελματικοί χώροι";
                landBtn.Text = "Οικόπεδα και Γή";
                summer_housesBtn.Text = "Εξοχικά";
                parkingBtn.Text = "Parking";
                home_label.Text = "Σπίτι";

                Search_button.Text = "Αναζήτηση";
                Log_in_label.Text = "Σύνδεση / Εγγραφή";

            }
            else 
            {
                Program.change_lang = false;
                pcBtn.Text = "Pc and Laptop";
                telephoneBtn.Text = "Telephone";
                sound_devicesBtn.Text = "Sound Devices";
                televisionBtn.Text = "TV";
                photoBtn.Text = "Photography";
                house_devices.Text = "Home Appliances";
                tech_label.Text = "Technology";

                autoBtn.Text = "Automobile";
                motoBtn.Text = "Motorcycles";
                prof_vehiclesBtn.Text = "Commercial Vehicles";
                boatBtn.Text = "Yachts and Boats";
                more_vehicles.Text = "Other Vehicles";
                accesoriesBtn.Text = "Spare parts";
                auto_label.Text = "Vehicles";

                apartmentsBtn.Text = "Apartments";
                vilesBtn.Text = "Detached and Luxury houses";
                prof_housesBtn.Text = "Professional Spaces";
                landBtn.Text = "Land";
                summer_housesBtn.Text = "Vacation houses";
                parkingBtn.Text = "Parking";
                home_label.Text = "Houses";

                Search_button.Text = "Search";
                Log_in_label.Text = "Log in / Resister";
            }

        }
    }
}
