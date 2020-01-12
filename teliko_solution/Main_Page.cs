using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Main_Page : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public Main_Page()
        {
            InitializeComponent();
            //initialization must be done here
            //Do not modify the String
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                   @"Data source=C:\teliko_solution\Database1.mdb;";
            filtra();
            EmfanisiArxikwnAggeliwn();
        }

        private void filtra()
        {
            onomaKatigorias.Text = Welcome_Page.onomaKatigorias;
            //   pROPERTIESTableAdapter.GetRamKinitou();

            if (Welcome_Page.voithitikosArithmos < 7)
            {
                filtraTexnologias();
            }
            else if (Welcome_Page.voithitikosArithmos < 13)
            {
                filtraOximatwn();
            }
            else
            {
                filtraSpitiwn();
            }

        }
        public static int arithmosfiltrwn;
        private void filtraTexnologias()
        {
            switch (Welcome_Page.voithitikosArithmos)
            {
                case 1:
                    filtro1.Text = "Marka: ";
                    comboBox2.DataSource = pROPERTIES1TableAdapter.GetMarkaPC();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    filtro2.Text = "Screen: ";
                    comboBox3.DataSource = pROPERTIES1TableAdapter.GetScreenPC();
                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    filtro3.Text = "CPU: ";
                    comboBox4.DataSource = pROPERTIES1TableAdapter.GetCpuPC();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";

                    break;

                case 2:
                    filtro1.Text = "Marka: ";
                    comboBox2.DataSource = pROPERTIESTableAdapter.GetMarkaTilefonou();
                    comboBox2.DisplayMember = "Subtitle";
                    comboBox2.ValueMember = "Subtitle";

                    filtro2.Text = "Ram: ";
                    comboBox3.DataSource = pROPERTIESTableAdapter.GetRamTilefonou();
                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    filtro3.Text = "BATTERY: ";
                    comboBox4.DataSource = pROPERTIESTableAdapter.GetBatteryTilefonou();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";
                    break;

                case 3:
                    filtro1.Text = "Type: ";
                    comboBox2.DataSource = pROPERTIES2TableAdapter.GetTypeYxiou();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    filtro2.Text = "Watt: ";
                    comboBox3.DataSource = pROPERTIES2TableAdapter.GetWattYxiou();
                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    filtro3.Text = "Inputs: ";
                    comboBox4.DataSource = pROPERTIES2TableAdapter.GetInputsYxiou();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";
                    break;

                case 4:
                    filtro1.Text = "Marka: ";
                    comboBox2.DataSource = pROPERTIES3TableAdapter.GetMarkaTileorasis();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    filtro2.Text = "Inches: ";
                    comboBox3.DataSource = pROPERTIES3TableAdapter.GetInchesTileorasis();
                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    filtro3.Text = "Resolution: ";
                    comboBox4.DataSource = pROPERTIES3TableAdapter.GetResolutionTileorasis();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";
                    break;
                case 5:
                    filtro1.Text = "Type: ";
                    comboBox2.DataSource = pROPERTIES4TableAdapter.GetTypeFotografikis();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    filtro2.Text = "Sensor: ";
                    comboBox3.DataSource = pROPERTIES4TableAdapter.GetSensorFotografikis();
                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    filtro3.Text = "Features: ";
                    comboBox4.DataSource = pROPERTIES4TableAdapter.GetFeaturesFotografikis();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";
                    break;

                case 6:
                    filtro1.Text = "Type: ";
                    comboBox2.DataSource = pROPERTIES5TableAdapter.GetTypeOikiakisSiskeuis();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    filtro2.Hide();
                    filtro3.Hide();
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
                    filtro1.Text = "Type: ";
                    comboBox2.DataSource = pROPERTIES6TableAdapter.GetTypeAutokinitou();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    filtro2.Text = "Marka: ";
                    comboBox3.DataSource = pROPERTIES6TableAdapter.GetMarkaAutokinitou();
                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    filtro3.Text = "Kuvika: ";
                    comboBox4.DataSource = pROPERTIES6TableAdapter.GetKibikaAutokinitou();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";
                    break;

                case 8:
                    filtro1.Text = "Marka: ";
                    comboBox2.DataSource = pROPERTIES7TableAdapter.GetMarkaMixanis();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    filtro2.Text = "Kuvika: ";
                    comboBox3.DataSource = pROPERTIES7TableAdapter.GetKibikaMixanis();
                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    filtro3.Text = "Xronologia: ";
                    comboBox4.DataSource = pROPERTIES7TableAdapter.GetXronologiaMixanis();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";
                    break;

                case 9:
                    filtro1.Text = "Type: ";
                    comboBox2.DataSource = pROPERTIES8TableAdapter.GetTypeEpaggelmatikou();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    filtro2.Hide();
                    filtro3.Hide();
                    comboBox3.Hide();
                    comboBox4.Hide();
                    break;

                case 10:
                    filtro1.Text = "Mhkos: ";
                    comboBox2.DataSource = pROPERTIES9TableAdapter.GetMhkosSkafous();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    filtro2.Text = "Xronologia: ";
                    comboBox3.DataSource = pROPERTIES9TableAdapter.GetXronologiaSkafous();
                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    filtro3.Text = "Zhmia: ";
                    comboBox4.DataSource = pROPERTIES9TableAdapter.GetZhmiaSkafous();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";
                    break;

                case 11:
                    filtro1.Text = "Type: ";
                    comboBox2.DataSource = pROPERTIES10TableAdapter.GetTypeAllwnOximatwn();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    filtro2.Hide();
                    filtro3.Hide();
                    comboBox3.Hide();
                    comboBox4.Hide();
                    break;

                case 12:
                    filtro1.Text = "Type: ";
                    comboBox2.DataSource = pROPERTIES11TableAdapter.GetTypeAntallaktikwn();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    filtro2.Hide();
                    filtro3.Hide();
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
                    filtro1.Text = "TM: ";
                    comboBox2.DataSource = pROPERTIES12TableAdapter.GetTMDiamerismatos();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    filtro2.Text = "Xrhsh: ";
                    comboBox3.DataSource = pROPERTIES12TableAdapter.GetXrhshDiamerismatos();
                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    filtro3.Text = "Extra: ";
                    comboBox4.DataSource = pROPERTIES12TableAdapter.GetExtraDiamerismatos();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";
                    break;

                case 14:
                    filtro1.Text = "TM: ";
                    comboBox2.DataSource = pROPERTIES13TableAdapter.GetTMMonokatikoias();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    filtro2.Text = "Xrhsh: ";
                    comboBox3.DataSource = pROPERTIES13TableAdapter.GetXrhshMonokatoikias();
                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    filtro3.Text = "Extra: ";
                    comboBox4.DataSource = pROPERTIES13TableAdapter.GetExtraMonoikatikias();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";
                    break;

                case 15:
                    filtro1.Text = "TM: ";
                    comboBox2.DataSource = pROPERTIES14TableAdapter.GetTMEpaggelmatikwnXwrwn();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    filtro2.Text = "Xrhsh: ";
                    comboBox3.DataSource = pROPERTIES14TableAdapter.GetXrhshEpaggelmatikwnXwrwn();
                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    filtro3.Text = "Extra: ";
                    comboBox4.DataSource = pROPERTIES14TableAdapter.GetExtraEpaggelmatikwnXwrwn();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";
                    break;

                case 16:
                    filtro1.Text = "TM: ";
                    comboBox2.DataSource = pROPERTIES15TableAdapter.GetTMOikopedwn();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    filtro2.Text = "Xrhsh: ";
                    comboBox3.DataSource = pROPERTIES15TableAdapter.GetXrhshOikopedwn();
                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    filtro3.Hide();
                    comboBox4.Hide();
                    break;
                case 17:
                    filtro1.Text = "TM: ";
                    comboBox2.DataSource = pROPERTIES16TableAdapter.GetTMEksoxikwn();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    filtro2.Text = "Xrhsh: ";
                    comboBox3.DataSource = pROPERTIES16TableAdapter.GetXrhshEksoxikwn();
                    comboBox3.DisplayMember = "SUBTITLE";
                    comboBox3.ValueMember = "SUBTITLE";

                    filtro3.Text = "Extra: ";
                    comboBox4.DataSource = pROPERTIES16TableAdapter.GetExtraEksoxikwn();
                    comboBox4.DisplayMember = "SUBTITLE";
                    comboBox4.ValueMember = "SUBTITLE";
                    break;

                case 18:
                    filtro1.Text = "Type: ";
                    comboBox2.DataSource = pROPERTIES17TableAdapter.GetTypeParking();
                    comboBox2.DisplayMember = "SUBTITLE";
                    comboBox2.ValueMember = "SUBTITLE";

                    filtro2.Hide();
                    filtro3.Hide();
                    comboBox3.Hide();
                    comboBox4.Hide();
                    break;
            }
        }

        private void EmfanisiArxikwnAggeliwn()
        {
            int category_id;
            if (Welcome_Page.voithitikosArithmos.Equals(20))
            {
                Console.WriteLine("EIMAIIIIIIIIIIIIIIIIIIIIIIII MESAAAAAAAAAAAAA");
                filtro1.Visible = false;
            }
            else
            {
                if (Welcome_Page.voithitikosArithmos == 1)
                {
                    category_id = Welcome_Page.voithitikosArithmos + 4;
                }
                else if (Welcome_Page.voithitikosArithmos == 2)
                {
                    category_id = Welcome_Page.voithitikosArithmos + 2;
                }
                else
                {
                    category_id = Welcome_Page.voithitikosArithmos + 3;
                }
                DataTable dtEmployees = new DataTable();
                string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|Database1.mdb";
                using (OleDbConnection con = new OleDbConnection(connString))
                {
                    con.Open();
                    string query = "SELECT AD_TITLE,INSERT_DATE,FINISH_DATE,MODIFY_DATE,PRICE,DESCRIPTION,STATUS FROM ADS " +
                        " WHERE CATEGORY_ID = @CATEGORY_ID ";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CATEGORY_ID", category_id);
                        OleDbDataReader reader = cmd.ExecuteReader();
                        dtEmployees.Load(reader);
                    }
                    con.Close();
                }
                dataGridView1.DataSource = dtEmployees;
            }
        }

        private void epilogiFiltrwn_Click(object sender, EventArgs e)
        {
            arithmosFiltrwn();
            //this.aCTIVITY_USERTableAdapter.Insert(Login.uname, DateTime.Today, "FILTER", Global.getIP());
        }

        public static string Dok, Dok2, Dok3;
        private void arithmosFiltrwn()
        {
            if (comboBox2.Visible == true && comboBox3.Visible == true && comboBox4.Visible == true)
            {
                arithmosfiltrwn = 3;

                DataRow selectedDataRow = ((DataRowView)comboBox2.SelectedItem).Row;
                Dok = selectedDataRow["PROPERTIES_ID"].ToString();

                DataRow selectedDataRow2 = ((DataRowView)comboBox3.SelectedItem).Row;
                Dok2 = selectedDataRow2["PROPERTIES_ID"].ToString();

                DataRow selectedDataRow3 = ((DataRowView)comboBox4.SelectedItem).Row;
                Dok3 = selectedDataRow3["PROPERTIES_ID"].ToString();

                dataGridView1.DataSource = GetAggeliesList();
            }
            else if (comboBox2.Visible == true && comboBox3.Visible == true && comboBox4.Visible == false)
            {
                arithmosfiltrwn = 2;
                DataRow selectedDataRow = ((DataRowView)comboBox2.SelectedItem).Row;
                Dok = selectedDataRow["PROPERTIES_ID"].ToString();

                DataRow selectedDataRow2 = ((DataRowView)comboBox3.SelectedItem).Row;
                Dok2 = selectedDataRow2["PROPERTIES_ID"].ToString();

                Dok3 = "";
            }
            else
            {
                DataRow selectedDataRow = ((DataRowView)comboBox2.SelectedItem).Row;
                Dok = selectedDataRow["PROPERTIES_ID"].ToString();
                arithmosfiltrwn = 1;

                Dok2 = "";
                Dok3 = "";
            }
        }

        private DataTable GetAggeliesList()
        {
            DataTable dtEmployees = new DataTable();
            string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|Database1.mdb";
            using (OleDbConnection con = new OleDbConnection(connString))
            {
                con.Open();
                string query = "SELECT AD_TITLE,INSERT_DATE,FINISH_DATE,MODIFY_DATE,PRICE,DESCRIPTION,STATUS FROM ADS INNER JOIN PROPERTIES_VALUE ON ADS.AD_ID = PROPERTIES_VALUE.AD_ID" +
                    " WHERE PROPERTIES1 = @PROPERTIES1 AND PROPERTIES2 = @PROPERTIES2 AND PROPERTIES3 = @PROPERTIES3 ";
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PROPERTIES1", Dok);
                    cmd.Parameters.AddWithValue("@PROPERTIES2", Dok2);
                    cmd.Parameters.AddWithValue("@PROPERTIES3", Dok3);

                    OleDbDataReader reader = cmd.ExecuteReader();
                    dtEmployees.Load(reader);
                }
                con.Close();
            }
            return dtEmployees;
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

        private void home_button_Click(object sender, EventArgs e)
        {
           // this.aCTIVITY_USERTableAdapter.Insert(Login.uname, DateTime.Today, "HOMEPAGE", Global.getIP());
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
            //this.aCTIVITY_USERTableAdapter.Insert(Login.uname, DateTime.Today, "BACK_BUTTON", Global.getIP());
            panel_back.Height = back_button_main.Height;
            panel_back.Top = back_button_main.Top;
            Welcome_Page wp = new Welcome_Page();
            this.Hide();
            wp.ShowDialog();
            this.Close();
        }



        private void reportBtn_Click(object sender, EventArgs e)
        {
            Report rs = new Report();
            rs.ShowDialog();
            //this.aCTIVITY_USERTableAdapter.Insert(Login.uname, DateTime.Today,"REPORT",Global.getIP());
        }

        private void Customer_supportBtn_Click(object sender, EventArgs e)
        {
            Customer_Support cs = new Customer_Support();
            cs.ShowDialog();
            //this.aCTIVITY_USERTableAdapter.Insert(Login.uname, DateTime.Today, "SUPPORT", Global.getIP());
        }

        private void donationBtn_Click(object sender, EventArgs e)
        {
            DonationForm dn = new DonationForm();
            dn.ShowDialog();
            //this.aCTIVITY_USERTableAdapter.Insert(Login.uname, DateTime.Today, "DONATION", Global.getIP());
        }

        private void prosforesBtn_Click(object sender, EventArgs e)
        {
            Prosfores ps = new Prosfores();
            ps.ShowDialog();
            //this.aCTIVITY_USERTableAdapter.Insert(Login.uname, DateTime.Today, "SALES", Global.getIP());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String attr = "";
            //opening the new connection
            conn.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = conn;

            //submitting the query for the user authentication later
            command.CommandText = "SELECT attr FROM users " +
                                  "WHERE username='" + Login.uname + "'";


            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())//avoiding data loss 
            {
                attr = reader.GetString(0);
            }

            if (attr == "User")
            {
                UserPanel uPanel = new UserPanel();
                uPanel.ShowDialog();
            }
            else if (attr == "Admin")
            {
                AdminPanel aPanel = new AdminPanel();
                aPanel.ShowDialog();
            }
            conn.Close();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Welcome_Page wp = new Welcome_Page();
            MessageBox.Show("you have been logged out");
            Login.uname = null;
            this.Hide();
            wp.ShowDialog();
            //this.aCTIVITY_USERTableAdapter.Insert(Login.uname, DateTime.Today, "LOGGED_OUT", Global.getIP());
            this.Close();
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {
            if (string.IsNullOrEmpty(Login.uname))
            {
                logOutButton.Visible = false;
            }
            if (!string.IsNullOrEmpty(Login.uname))
            {
                Log_in_label_main.Visible = false;
            }
        }

        private void Log_in_label_Click(object sender, EventArgs e)
        {
            Login l = new Login();

            l.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel_user_Paint(object sender, PaintEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Trace.Listeners.Add(new TextWriterTraceListener("AdholicsErrors.log"));
            Trace.AutoFlush = true;
            Trace.Indent();
            Trace.TraceInformation("Information");
            Trace.TraceError("Error");
            Trace.TraceWarning("Warning");
            Trace.Unindent();
        }
    }
}


