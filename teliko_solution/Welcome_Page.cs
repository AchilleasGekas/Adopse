using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using Lucene.Net.Store;

namespace WindowsFormsApp1
{
    public partial class Welcome_Page : Form
    {
        
        public Welcome_Page()
        {
            
            InitializeComponent();
            searchboxTxtBox.AutoSize = false;

        }
        
        int movX;
        int movY;
        int mov;

      
        private void Welcome_Page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseLocal1.ACTIVITY_USER' table. You can move, or remove it, as needed.
            this.aCTIVITY_USERTableAdapter.Fill(this.databaseLocal1.ACTIVITY_USER);
            // TODO: This line of code loads data into the 'databaseLocal1.SEARCHED_DATA' table. You can move, or remove it, as needed.
            this.sEARCHED_DATATableAdapter.Fill(this.databaseLocal1.SEARCHED_DATA);
            // TODO: This line of code loads data into the 'databaseLocal1.ADS' table. You can move, or remove it, as needed.
            this.aDSTableAdapter.Fill(this.databaseLocal1.ADS);
            // TODO: This line of code loads data into the 'database1DataSet.AD_CATEGORY2' table. You can move, or remove it, as needed.
            this.aD_CATEGORY2TableAdapter.Fill(this.database1DataSet.AD_CATEGORY2);
            // TODO: This line of code loads data into the 'database1DataSet.AD_CATEGORY1' table. You can move, or remove it, as needed.
            this.aD_CATEGORY1TableAdapter.Fill(this.database1DataSet.AD_CATEGORY1);
            // TODO: This line of code loads data into the 'database1DataSet.AD_CATEGORY' table. You can move, or remove it, as needed.
            this.aD_CATEGORYTableAdapter.Fill(this.database1DataSet.AD_CATEGORY);
            ProsthikiTimwnStaButtons();
            /*
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
              */
        }
        private void ProsthikiTimwnStaButtons()
        {
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            

            for (int i = 0; i < 18; i++)
            {
                switch (i)
                {
                    case 0:
                        telephoneBtn.Text = this.dataGridView1.Rows[0].Cells[0].Value.ToString();
                        break;
                    case 1:
                        pcBtn.Text = this.dataGridView1.Rows[1].Cells[0].Value.ToString();
                        break;
                    case 2:
                        sound_devicesBtn.Text = this.dataGridView1.Rows[2].Cells[0].Value.ToString();
                        break;
                    case 3:
                        televisionBtn.Text = this.dataGridView1.Rows[3].Cells[0].Value.ToString();
                        break;
                    case 4:
                        photoBtn.Text = this.dataGridView1.Rows[4].Cells[0].Value.ToString();
                        break;
                    case 5:
                        house_devices.Text = this.dataGridView1.Rows[5].Cells[0].Value.ToString();
                        break;
                    case 6:
                        autoBtn.Text = this.dataGridView2.Rows[0].Cells[0].Value.ToString();
                        break;

                    case 7:
                        motoBtn.Text = this.dataGridView2.Rows[1].Cells[0].Value.ToString();
                        break;

                    case 8:
                        prof_vehiclesBtn.Text = this.dataGridView2.Rows[2].Cells[0].Value.ToString();
                        break;

                    case 9:
                        boatBtn.Text = this.dataGridView2.Rows[3].Cells[0].Value.ToString();
                        break;

                    case 10:
                        more_vehicles.Text = this.dataGridView2.Rows[4].Cells[0].Value.ToString();

                        break;

                    case 11:
                        accesoriesBtn.Text = this.dataGridView2.Rows[5].Cells[0].Value.ToString();
                        break;
                    case 12:
                        apartmentsBtn.Text= this.dataGridView3.Rows[0].Cells[0].Value.ToString();
                        break;
                    case 13:
                        vilesBtn.Text= this.dataGridView3.Rows[1].Cells[0].Value.ToString();
                        break;
                    case 14:
                        prof_housesBtn.Text= this.dataGridView3.Rows[2].Cells[0].Value.ToString();
                        break;
                    case 15:
                        landBtn.Text= this.dataGridView3.Rows[3].Cells[0].Value.ToString();
                        break;
                    case 16:
                        summer_housesBtn.Text= this.dataGridView3.Rows[4].Cells[0].Value.ToString();
                        break;
                    case 17:
                        parkingBtn.Text= this.dataGridView3.Rows[5].Cells[0].Value.ToString();
                        break;
                    default:

                        break;
                }
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

        public static string onomaKatigorias;
        public static int voithitikosArithmos;
        //go to main page
        //Τεχνολογια main page
        private void pcBtn_Click(object sender, EventArgs e)
        {
            onomaKatigorias = "Επιλέξτε τι είδους υπολογιστή θέλετε";
            voithitikosArithmos = 1;
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();

            this.Close();
        }

        private void telephoneBtn_Click(object sender, EventArgs e)
        {
            onomaKatigorias = "Επιλέξτε τι είδους κινητό θέλετε";
            voithitikosArithmos = 2;
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void sound_devicesBtn_Click(object sender, EventArgs e)
        {
            onomaKatigorias = "Επιλέξτε τι είδους ηχείο θέλετε";
            voithitikosArithmos = 3;
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void televisionBtn_Click(object sender, EventArgs e)
        {
            onomaKatigorias = "Επιλέξτε τι είδους τηλεόραση θέλετε";
            voithitikosArithmos = 4;
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void photoBtn_Click(object sender, EventArgs e)
        {
            onomaKatigorias = "Επιλέξτε τι είδους φωτογραφική θέλετε";
            voithitikosArithmos = 5;
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void house_devices_Click(object sender, EventArgs e)
        {
            onomaKatigorias = "Επιλέξτε τι είδους οικιακή συσκευή θέλετε";
            voithitikosArithmos = 6;
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        //Οχήματα main page
        private void autoBtn_Click(object sender, EventArgs e)
        {
            onomaKatigorias = "Επιλέξτε τι είδους αυτοκίνητο θέλετε";
            voithitikosArithmos = 7;
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void motoBtn_Click(object sender, EventArgs e)
        {
            onomaKatigorias = "Επιλέξτε τι είδους μηχανή θέλετε";
            voithitikosArithmos = 8;
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void boatBtn_Click(object sender, EventArgs e)
        {
            onomaKatigorias = "Επιλέξτε τι είδους σκάφος θέλετε";
            voithitikosArithmos = 10;
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void more_vehicles_Click(object sender, EventArgs e)
        {
            onomaKatigorias = "Επιλέξτε τι είδους όχημα θέλετε";
            voithitikosArithmos = 11;
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void accesoriesBtn_Click(object sender, EventArgs e)
        {
            onomaKatigorias = "Επιλέξτε τι είδους ανταλλακτικά θέλετε";
            voithitikosArithmos = 12;
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }
        private void prof_vehiclesBtn_Click(object sender, EventArgs e)
        {
            onomaKatigorias = "Επιλέξτε τι επαγγελματικό όχημα θέλετε";
            voithitikosArithmos = 9;
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        //spiti main_page
        private void apartmentsBtn_Click(object sender, EventArgs e)
        {
            onomaKatigorias = "Επιλέξτε τι είδους διαμέρισμα θέλετε";
            voithitikosArithmos = 13;
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void vilesBtn_Click(object sender, EventArgs e)
        {
            onomaKatigorias = "Επιλέξτε τι είδους βίλα θέλετε";
            voithitikosArithmos = 14;
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void prof_housesBtn_Click(object sender, EventArgs e)
        {
            onomaKatigorias = "Επιλέξτε τι επαγγελματικό χώρο θέλετε";
            voithitikosArithmos = 15;
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void landBtn_Click(object sender, EventArgs e)
        {
            onomaKatigorias = "Επιλέξτε τι είδους οικόπεδο θέλετε";
            voithitikosArithmos = 16;
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void summer_housesBtn_Click(object sender, EventArgs e)
        {
            onomaKatigorias = "Επιλέξτε τι είδους εξωχικό θέλετε";
            voithitikosArithmos = 17;
            Main_Page mp = new Main_Page();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void parkingBtn_Click(object sender, EventArgs e)
        {
            onomaKatigorias = "Επιλέξτε τι είδους χώρο πάρκινγκ θέλετε";
            voithitikosArithmos = 18;
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
            /*
           if (comboBox1.SelectedIndex == 0)
            {

                Program.change_lang = true;
                /*
                    
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
                */
            }

        private void Search_button_Click(object sender, EventArgs e)
        {
            Main_Page mp = new Main_Page();
            var query = searchboxTxtBox.Text.Trim();
            var results = search(query);
            mp.dataGridView1.DataSource = results;
  
            this.aCTIVITY_USERTableAdapter.Insert(Login.uname, DateTime.Today,"SEARCHED",Global.getIP());
            this.sEARCHED_DATATableAdapter.Insert(Login.uname, searchboxTxtBox.Text, DateTime.Today);
            voithitikosArithmos = 20;
            mp.filtro1.Visible = false;
            mp.filtro2.Visible = false;
            mp.filtro3.Visible = false;
            mp.epilogiFiltrwn.Visible = false;
            mp.comboBox2.Visible = false;
            mp.comboBox3.Visible = false;
            mp.comboBox4.Visible = false;
            mp.onomaKatigorias.Visible = false;
            this.Hide();
            mp.ShowDialog();
            this.Close();
            
        }


        Directory createIndex(DataTable table)
        {
            var directory = new RAMDirectory();
            using (Analyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30))
            using (var writer = new IndexWriter(directory, analyzer, new IndexWriter.MaxFieldLength(1000)))
            {
                foreach (DataRow row in table.Rows)
                {
                    var document = new Document();
                    document.Add(new Field("AD_TITLE", row["AD_TITLE"].ToString(), Field.Store.YES, Field.Index.ANALYZED));
                    document.Add(new Field("DESCRIPTION", row["DESCRIPTION"].ToString(), Field.Store.YES, Field.Index.ANALYZED));
                    document.Add(new Field("PRICE", row["PRICE"].ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));
                    document.Add(new Field("AD_ID", row["AD_ID"].ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));
                    document.Add(new Field("INSERT_DATE", row["INSERT_DATE"].ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));


                    document.Add(new Field("FullText", string.Format("{0} {1}", row["AD_TITLE"], row["DESCRIPTION"]), Field.Store.YES, Field.Index.ANALYZED));

                    writer.AddDocument(document);
                }
                writer.Optimize();
                writer.Flush(true, true, true);
            }
            return directory;
        }

        DataTable search(string textSearch)
        {
            var table = this.databaseLocal1.ADS.Clone();

            var Index = createIndex(this.databaseLocal1.ADS);

            using (var reader = IndexReader.Open(Index, true))
            using (var searcher = new IndexSearcher(reader))
            {
                using (Analyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30))
                {
                    var queryParser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, "FullText", analyzer);
                    queryParser.AllowLeadingWildcard = true;

                    var query = queryParser.Parse("*" + searchboxTxtBox.Text + "*");

                    var collector = TopScoreDocCollector.Create(1000, true);

                    searcher.Search(query, collector);

                    var matches = collector.TopDocs().ScoreDocs;

                    foreach (var item in matches)
                    {
                        var id = item.Doc;
                        var doc = searcher.Doc(id);

                        var row = table.NewRow();
                        row["AD_ID"] = doc.GetField("AD_ID").StringValue;
                        row["AD_TITLE"] = doc.GetField("AD_TITLE").StringValue;
                        row["DESCRIPTION"] = doc.GetField("DESCRIPTION").StringValue;
                        row["PRICE"] = doc.GetField("PRICE").StringValue;
                        row["INSERT_DATE"] = doc.GetField("INSERT_DATE").StringValue;
                        table.Rows.Add(row);
                    }
                }
            }
            return table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usage_Data data = new Usage_Data();
            data.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Usage_Data data = new Usage_Data();
            data.ShowDialog();
        }
    }

      
    }

