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
            filtra();
        }

        private void filtra()

        {
            onomaKatigorias.Text = Welcome_Page.onomaKatigorias;
            //   pROPERTIESTableAdapter.GetRamKinitou();

            if(Welcome_Page.voithitikosArithmos<7)
            {
                filtraTexnologias();
            }
            else if(Welcome_Page.voithitikosArithmos<13)
            {
                filtraOximatwn();
            }
            else
            {
                filtraSpitiwn();
            }
                       

        }
        
        private void filtraTexnologias()
        {
          switch(Welcome_Page.voithitikosArithmos)
          {
                case 1:
                    comboBox2.DataSource = pROPERTIES1TableAdapter.GetMarkaPC();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    comboBox3.DataSource = pROPERTIES1TableAdapter.GetScreenPC();
                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    comboBox4.DataSource = pROPERTIES1TableAdapter.GetCpuPC();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";
                    break;
               
                case 2:   
                    comboBox2.DataSource = pROPERTIESTableAdapter.GetMarkaTilefonou();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    comboBox3.DataSource = pROPERTIESTableAdapter.GetRamTilefonou();
   
                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    comboBox4.DataSource = pROPERTIESTableAdapter.GetBatteryTilefonou();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";
                break;

                case 3:
                    comboBox2.DataSource = pROPERTIES2TableAdapter.GetTypeYxiou();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    comboBox3.DataSource = pROPERTIES2TableAdapter.GetWattYxiou();

                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    comboBox4.DataSource = pROPERTIES2TableAdapter.GetInputsYxiou();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";
               break;

                case 4:
                    comboBox2.DataSource = pROPERTIES3TableAdapter.GetMarkaTileorasis();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    comboBox3.DataSource = pROPERTIES3TableAdapter.GetInchesTileorasis();

                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    comboBox4.DataSource = pROPERTIES3TableAdapter.GetResolutionTileorasis();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";
                    break;
                case 5:
                    comboBox2.DataSource = pROPERTIES4TableAdapter.GetTypeFotografikis();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    comboBox3.DataSource = pROPERTIES4TableAdapter.GetSensorFotografikis();

                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    comboBox4.DataSource = pROPERTIES4TableAdapter.GetFeaturesFotografikis();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";
                    break;

                case 6:
                    comboBox2.DataSource = pROPERTIES5TableAdapter.GetTypeOikiakisSiskeuis();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    comboBox3.Hide();
                    comboBox4.Hide();
                    break;
            }
            

        }

        private void filtraOximatwn()
        {
            switch (Welcome_Page.voithitikosArithmos)
            {
                case 7:
                    comboBox2.DataSource = pROPERTIES6TableAdapter.GetTypeAutokinitou();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    comboBox3.DataSource = pROPERTIES6TableAdapter.GetMarkaAutokinitou();
                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    comboBox4.DataSource = pROPERTIES6TableAdapter.GetKibikaAutokinitou();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";
                    break;

                case 8:
                    comboBox2.DataSource = pROPERTIES7TableAdapter.GetMarkaMixanis();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    comboBox3.DataSource = pROPERTIES7TableAdapter.GetKibikaMixanis();

                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    comboBox4.DataSource = pROPERTIES7TableAdapter.GetXronologiaMixanis();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";
                    break;

                case 9:
                    comboBox2.DataSource = pROPERTIES8TableAdapter.GetTypeEpaggelmatikou();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    comboBox3.Hide();
                    comboBox4.Hide();


                    break;

                case 10:
                    comboBox2.DataSource = pROPERTIES9TableAdapter.GetMhkosSkafous();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    comboBox3.DataSource = pROPERTIES9TableAdapter.GetXronologiaSkafous();

                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    comboBox4.DataSource = pROPERTIES9TableAdapter.GetZhmiaSkafous();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";
                    break;
                case 11:
                    comboBox2.DataSource = pROPERTIES10TableAdapter.GetTypeAllwnOximatwn();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    comboBox3.Hide();
                    comboBox4.Hide();

                    
                    break;

                case 12:
                    comboBox2.DataSource = pROPERTIES11TableAdapter.GetTypeAntallaktikwn();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    comboBox4.Hide();
                    comboBox3.Hide();
                    break;
            }


        }

        private void filtraSpitiwn()
        {
            switch (Welcome_Page.voithitikosArithmos)
            {
                case 13:
                    comboBox2.DataSource = pROPERTIES12TableAdapter.GetXrhshDiamerismatos();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    comboBox3.DataSource = pROPERTIES12TableAdapter.GetExtraDiamerismatos();
                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    comboBox4.Hide();

                    break;

                case 14:
                    comboBox2.DataSource = pROPERTIES13TableAdapter.GetTMMonokatikoias();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    comboBox3.DataSource = pROPERTIES13TableAdapter.GetXrhshMonokatoikias();

                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    comboBox4.DataSource = pROPERTIES13TableAdapter.GetExtraMonoikatikias();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";
                    break;

                case 15:
                    comboBox2.DataSource = pROPERTIES14TableAdapter.GetTMEpaggelmatikwnXwrwn();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    comboBox3.DataSource = pROPERTIES14TableAdapter.GetXrhshEpaggelmatikwnXwrwn();

                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    comboBox4.DataSource = pROPERTIES14TableAdapter.GetExtraEpaggelmatikwnXwrwn();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";

                    break;

                case 16:
                    comboBox2.DataSource = pROPERTIES15TableAdapter.GetTMOikopedwn();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    comboBox3.DataSource = pROPERTIES15TableAdapter.GetXrhshOikopedwn();

                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    comboBox4.Hide();

                    break;
                case 17:
                    comboBox2.DataSource = pROPERTIES16TableAdapter.GetTMEksoxikwn();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    comboBox3.DataSource = pROPERTIES16TableAdapter.GetXrhshEksoxikwn();

                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    comboBox4.DataSource = pROPERTIES16TableAdapter.GetExtraEksoxikwn();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";


                    break;

                case 18:
                    comboBox2.DataSource = pROPERTIES17TableAdapter.GetTypeParking();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    comboBox3.Hide();
                    comboBox4.Hide();
                    break;
            }


        }
        int movX;
        int movY;
        int mov;
        private void Main_Page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet14.PROPERTIES17' table. You can move, or remove it, as needed.
            this.pROPERTIES17TableAdapter.Fill(this.dataSet14.PROPERTIES17);
            // TODO: This line of code loads data into the 'dataSet1.PROPERTIES16' table. You can move, or remove it, as needed.
            this.pROPERTIES16TableAdapter.Fill(this.dataSet1.PROPERTIES16);
            // TODO: This line of code loads data into the 'dataSet1.PROPERTIES15' table. You can move, or remove it, as needed.
            this.pROPERTIES15TableAdapter.Fill(this.dataSet1.PROPERTIES15);
            // TODO: This line of code loads data into the 'dataSet13.PROPERTIES14' table. You can move, or remove it, as needed.
            this.pROPERTIES14TableAdapter.Fill(this.dataSet13.PROPERTIES14);
            // TODO: This line of code loads data into the 'dataSet1.PROPERTIES13' table. You can move, or remove it, as needed.
            this.pROPERTIES13TableAdapter.Fill(this.dataSet1.PROPERTIES13);
            // TODO: This line of code loads data into the 'dataSet1.PROPERTIES12' table. You can move, or remove it, as needed.
            this.pROPERTIES12TableAdapter.Fill(this.dataSet1.PROPERTIES12);
            // TODO: This line of code loads data into the 'dataSet12.PROPERTIES11' table. You can move, or remove it, as needed.
            this.pROPERTIES11TableAdapter.Fill(this.dataSet12.PROPERTIES11);
            // TODO: This line of code loads data into the 'dataSet1.PROPERTIES10' table. You can move, or remove it, as needed.
            this.pROPERTIES10TableAdapter.Fill(this.dataSet1.PROPERTIES10);
            // TODO: This line of code loads data into the 'dataSet1.PROPERTIES9' table. You can move, or remove it, as needed.
            this.pROPERTIES9TableAdapter.Fill(this.dataSet1.PROPERTIES9);
            // TODO: This line of code loads data into the 'dataSet1.PROPERTIES8' table. You can move, or remove it, as needed.
            this.pROPERTIES8TableAdapter.Fill(this.dataSet1.PROPERTIES8);
            // TODO: This line of code loads data into the 'dataSet1.PROPERTIES7' table. You can move, or remove it, as needed.
            this.pROPERTIES7TableAdapter.Fill(this.dataSet1.PROPERTIES7);
            // TODO: This line of code loads data into the 'dataSet1.PROPERTIES6' table. You can move, or remove it, as needed.
            this.pROPERTIES6TableAdapter.Fill(this.dataSet1.PROPERTIES6);
            // TODO: This line of code loads data into the 'dataSet1.PROPERTIES5' table. You can move, or remove it, as needed.
            this.pROPERTIES5TableAdapter.Fill(this.dataSet1.PROPERTIES5);
            // TODO: This line of code loads data into the 'dataSet1.PROPERTIES4' table. You can move, or remove it, as needed.
            this.pROPERTIES4TableAdapter.Fill(this.dataSet1.PROPERTIES4);
            // TODO: This line of code loads data into the 'dataSet1.PROPERTIES3' table. You can move, or remove it, as needed.
            this.pROPERTIES3TableAdapter.Fill(this.dataSet1.PROPERTIES3);
            // TODO: This line of code loads data into the 'dataSet11.PROPERTIES2' table. You can move, or remove it, as needed.
            this.pROPERTIES2TableAdapter.Fill(this.dataSet11.PROPERTIES2);
            // TODO: This line of code loads data into the 'dataSet1.PROPERTIES1' table. You can move, or remove it, as needed.
            this.pROPERTIES1TableAdapter.Fill(this.dataSet1.PROPERTIES1);
            // TODO: This line of code loads data into the 'dataSet1.PROPERTIES' table. You can move, or remove it, as needed.
            this.pROPERTIESTableAdapter.Fill(this.dataSet1.PROPERTIES);
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

       

        
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
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
    }
}
    

