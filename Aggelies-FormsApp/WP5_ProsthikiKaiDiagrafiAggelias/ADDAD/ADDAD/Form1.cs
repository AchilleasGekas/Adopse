using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADDAD
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Form1_Load();
		}

		private void Form1_Load()
		{
			comboBox1.Items.Add("ΤΕΧΝΟΛΟΓΙΑ");
			comboBox1.Items.Add("ΟΧΗΜΑΤΑ");
			comboBox1.Items.Add("ΣΠΙΤΙΑ");
		}


		private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex == 0)
			{
				comboBox2.Items.Clear();
				comboBox3.Items.Clear();
				comboBox4.Items.Clear();
				comboBox5.Items.Clear();
				label5.Text = "";
				label6.Text = "";
				label7.Text = "";
				comboBox2.Items.Add("ΤΗΛΕΦΩΝΙΑ");
				comboBox2.Items.Add("PC_ΛΑΠΤΟΠ");
				comboBox2.Items.Add("ΣΥΣΚΕΥΕΣ_ΗΧΟΥ");
				comboBox2.Items.Add("ΤΗΛΕΟΡΑΣΕΙΣ");
				comboBox2.Items.Add("ΦΩΤΟΓΡΑΦΙΑ");
				comboBox2.Items.Add("ΟΙΚΙΑΚΕΣ ΣΥΣΚΕΥΕΣ");
			}
			else if (comboBox1.SelectedIndex == 1)
			{
				comboBox2.Items.Clear();
				comboBox3.Items.Clear();
				comboBox4.Items.Clear();
				comboBox5.Items.Clear();
				label5.Text = "";
				label6.Text = "";
				label7.Text = "";
				comboBox2.Items.Add("ΑΥΤΟΚΙΝΗΤΑ");
				comboBox2.Items.Add("ΜΗΧΑΝΕΣ");
				comboBox2.Items.Add("ΕΠΑΓΓΕΛΜΑΤΙΚΑ");
				comboBox2.Items.Add("ΣΚΑΦΟΙ");
				comboBox2.Items.Add("ΑΛΛΑ ΟΧΗΜΑΤΑ");
				comboBox2.Items.Add("ΑΝΤΑΛΛΑΚΤΙΚΑ");
			}
			else if (comboBox1.SelectedIndex == 2)
			{
				comboBox2.Items.Clear();
				comboBox3.Items.Clear();
				comboBox4.Items.Clear();
				comboBox5.Items.Clear();
				label5.Text = "";
				label6.Text = "";
				label7.Text = "";
				comboBox2.Items.Add("ΔΙΑΜΕΡΙΣΜΑΤΑ");
				comboBox2.Items.Add("ΜΟΝΟΚΑΤΟΙΚΙΕΣ");
				comboBox2.Items.Add("ΕΠΑΓΓΕΛΜΑΤΙΚΟΙ ΧΩΡΟΙ");
				comboBox2.Items.Add("ΟΙΚΟΠΕΔΑ");
				comboBox2.Items.Add("ΕΞΩΧΙΚΑ");
				comboBox2.Items.Add("ΧΩΡΟΙ ΠΑΡΚΙΝΓΚ");
			}
		}

		private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex == 0)
			{
				if (comboBox2.SelectedIndex == 0)
				{
					label5.Text = "ΜΑΡΚΑ";
					comboBox3.Items.Clear();
					comboBox3.Items.Add("XIAOMI");
					comboBox3.Items.Add("SAMSUNG");
					comboBox3.Items.Add("APPLE");
					comboBox3.Items.Add("HUAWEI");
					comboBox3.Items.Add("NOKIA");
					comboBox3.Items.Add("ONEPLUS");
					label6.Text = "RAM";
					comboBox4.Items.Clear();
					comboBox4.Items.Add("2GB");
					comboBox4.Items.Add("4GB");
					comboBox4.Items.Add("6GB");
					comboBox4.Items.Add("8GB");
					comboBox4.Items.Add("12GB");
					label7.Text = "ΜΠΑΤΑΡΙΑ";
					comboBox5.Items.Clear();
					comboBox5.Items.Add("2000MAH");
					comboBox5.Items.Add("3000MAH");
					comboBox5.Items.Add("4000MAH");
					comboBox5.Items.Add("5000MAH");
				}
				else if (comboBox2.SelectedIndex == 1)
				{
					label5.Text = "ΜΑΡΚΑ";
					comboBox3.Items.Clear();
					comboBox3.Items.Add("DELL");
					comboBox3.Items.Add("LENOVO");
					comboBox3.Items.Add("HP");
					comboBox3.Items.Add("ASUS");
					comboBox3.Items.Add("APPLE");
					comboBox3.Items.Add("MSI");
					label6.Text = "SCREEN";
					comboBox4.Items.Clear();
					comboBox4.Items.Add("11,6");
					comboBox4.Items.Add("12,5");
					comboBox4.Items.Add("13,3");
					comboBox4.Items.Add("14");
					comboBox4.Items.Add("15,6");
					comboBox4.Items.Add("17");
					label7.Text = "CPU";
					comboBox5.Items.Clear();
					comboBox5.Items.Add("INTEL CORE I9");
					comboBox5.Items.Add("INTEL CORE I7");
					comboBox5.Items.Add("INTEL CORE I5");
					comboBox5.Items.Add("INTEL CORE I3");
					comboBox5.Items.Add("AMD  RYZEN");
				}
				else if (comboBox2.SelectedIndex == 2)
				{
					label5.Text = "ΤΥΠΟΣ";
					comboBox3.Items.Clear();
					comboBox3.Items.Add("ΑΚΟΥΣΤΙΚΑ");
					comboBox3.Items.Add("ΚΑΡΤΑ ΗΧΟΥ");
					comboBox3.Items.Add("ΜΙΚΤΗΣ");
					comboBox3.Items.Add("ΗΧΕΙΑ");
					label6.Text = "WATT";
					comboBox4.Items.Clear();
					comboBox4.Items.Add("20");
					comboBox4.Items.Add("40");
					comboBox4.Items.Add("80");
					comboBox4.Items.Add("100");
					comboBox4.Items.Add("200");
					label7.Text = "ΕΙΣΟΔΟΙ";
					comboBox5.Items.Clear();
					comboBox5.Items.Add("2");
					comboBox5.Items.Add("4");
					comboBox5.Items.Add("8");
				}
				if (comboBox2.SelectedIndex == 3)
				{
					label5.Text = "ΜΑΡΚΑ";
					comboBox3.Items.Clear();
					comboBox3.Items.Add("SAMSUNG");
					comboBox3.Items.Add("LG");
					comboBox3.Items.Add("SONY");
					comboBox3.Items.Add("PHILLIPS");
					comboBox3.Items.Add("DELL");
					label6.Text = "ΙΝΤΣΕΣ";
					comboBox4.Items.Clear();
					comboBox4.Items.Add("27");
					comboBox4.Items.Add("32");
					comboBox4.Items.Add("40");
					comboBox4.Items.Add("43");
					comboBox4.Items.Add("48");
					comboBox4.Items.Add("50");
					comboBox4.Items.Add("55");
					comboBox4.Items.Add("65");
					comboBox4.Items.Add("70");
					label7.Text = "ΑΝΑΛΥΣΗ";
					comboBox5.Items.Clear();
					comboBox5.Items.Add("FHD");
					comboBox5.Items.Add("4K UHD");
					comboBox5.Items.Add("8K UHD");
				}
				else if (comboBox2.SelectedIndex == 4)
				{
					label5.Text = "ΤΥΠΟΣ";
					comboBox3.Items.Clear();
					comboBox3.Items.Add("MIRRORLESS");
					comboBox3.Items.Add("DSLR");
					comboBox3.Items.Add("COMPACT");
					comboBox3.Items.Add("VIDEOCAMERA");
					label6.Text = "ΑΙΣΘΗΤΗΡΑΣ";
					comboBox4.Items.Clear();
					comboBox4.Items.Add("FULLFRAME");
					comboBox4.Items.Add("APS-C");
					comboBox4.Items.Add("MICRO 4/3");
					comboBox4.Items.Add("MEDIUM FORMAT");
					label7.Text = "ΕΞΤΡΑ";
					comboBox5.Items.Clear();
					comboBox5.Items.Add("BLUETTOTH");
					comboBox5.Items.Add("WIFI");
				}
				else if (comboBox2.SelectedIndex == 5)
				{
					label5.Text = "ΤΥΠΟΣ";
					comboBox3.Items.Clear();
					comboBox3.Items.Add("ΘΕΡΜΑΝΣΗ");
					comboBox3.Items.Add("ΜΙΚΡΕΣ ΣΥΣΚΕΥΕΣ");
					comboBox3.Items.Add("ΜΕΓΑΛΕΣ ΣΥΣΚΕΥΕΣ");
					comboBox3.Items.Add("ΑΞΕΣΟΥΑΡ");
					comboBox3.Items.Add("ΚΛΙΜΑΤΙΣΜΟΣ");
					label6.Text = "";
					comboBox4.Items.Clear();
					label7.Text = "";
					comboBox5.Items.Clear();
				}
			}
			else if (comboBox1.SelectedIndex == 1)
			{
				if (comboBox2.SelectedIndex == 0)
				{
					label5.Text = "ΤΥΠΟΣ";
					comboBox3.Items.Clear();
					comboBox3.Items.Add("ΚΟΥΠΕ");
					comboBox3.Items.Add("ΑΓΡΟΤΙΚΟ");
					comboBox3.Items.Add("ΚΟΜΠΑΚΤ");
					comboBox3.Items.Add("ΑΓΩΝΙΣΤΙΚΟ");
					label6.Text = "ΜΑΡΚΑ";
					comboBox4.Items.Clear();
					comboBox4.Items.Add("AUDI");
					comboBox4.Items.Add("CITROEN");
					comboBox4.Items.Add("BMW");
					comboBox4.Items.Add("FIAT");
					comboBox4.Items.Add("FORD");
					comboBox4.Items.Add("HUYNDAI");
					comboBox4.Items.Add("MERCEDES");
					comboBox4.Items.Add("NISSAN");
					comboBox4.Items.Add("OPEL");
					comboBox4.Items.Add("PEUGEOT");
					comboBox4.Items.Add("RENAULT");
					comboBox4.Items.Add("SMART");
					comboBox4.Items.Add("SUZUKI");
					comboBox4.Items.Add("TOYOTA");
					comboBox4.Items.Add("VW");
					comboBox4.Items.Add("ΑΛΛΟ");
					label7.Text = "ΚΥΒΙΚΑ";
					comboBox5.Items.Clear();
					comboBox5.Items.Add("800");
					comboBox5.Items.Add("900");
					comboBox5.Items.Add("1000");
					comboBox5.Items.Add("1100");
					comboBox5.Items.Add("1200");
					comboBox5.Items.Add("1300");
					comboBox5.Items.Add("1400");
					comboBox5.Items.Add("1500");
					comboBox5.Items.Add("1600");
					comboBox5.Items.Add("1700");
					comboBox5.Items.Add("1800");
					comboBox5.Items.Add("1900");
					comboBox5.Items.Add("2000");
					comboBox5.Items.Add("2250");
					comboBox5.Items.Add("2500");
					comboBox5.Items.Add("2750");
					comboBox5.Items.Add("3000");
				}
				else if (comboBox2.SelectedIndex == 1)
				{
					label5.Text = "ΜΑΡΚΑ";
					comboBox3.Items.Clear();
					comboBox3.Items.Add("BMW");
					comboBox3.Items.Add("DAYTONA");
					comboBox3.Items.Add("DUCATI");
					comboBox3.Items.Add("GILERA");
					comboBox3.Items.Add("HONDA");
					comboBox3.Items.Add("KTM");
					comboBox3.Items.Add("KAWASAKI");
					comboBox3.Items.Add("PIAGGIO");
					comboBox3.Items.Add("SUZUKI");
					comboBox3.Items.Add("SYM");
					comboBox3.Items.Add("YAMAHA");
					label6.Text = "ΚΥΒΙΚΑ";
					comboBox4.Items.Clear();
					comboBox4.Items.Add("50");
					comboBox4.Items.Add("75");
					comboBox4.Items.Add("100");
					comboBox4.Items.Add("125");
					comboBox4.Items.Add("150");
					comboBox4.Items.Add("200");
					comboBox4.Items.Add("250");
					comboBox4.Items.Add("300");
					comboBox4.Items.Add("400");
					comboBox4.Items.Add("500");
					comboBox4.Items.Add("600");
					comboBox4.Items.Add("700");
					comboBox4.Items.Add("1000");
					comboBox4.Items.Add("ΑΛΛΟ");
					label7.Text = "ΧΡΟΝΟΛΟΓΙΑ";
					comboBox5.Items.Clear();
					comboBox5.Items.Add("2010");
					comboBox5.Items.Add("2011");
					comboBox5.Items.Add("2012");
					comboBox5.Items.Add("2013");
					comboBox5.Items.Add("2014");
					comboBox5.Items.Add("2015");
					comboBox5.Items.Add("2016");
					comboBox5.Items.Add("2017");
					comboBox5.Items.Add("2018");
					comboBox5.Items.Add("2019");
					comboBox5.Items.Add("2020");
					comboBox5.Items.Add("ΑΛΛΟ");
				}
				else if (comboBox2.SelectedIndex == 2)
				{
					label5.Text = "ΤΥΠΟΣ";
					comboBox3.Items.Clear();
					comboBox3.Items.Add("ΦΟΡΤΗΓΟ");
					comboBox3.Items.Add("ΛΕΟΦΩΡΕΙΟ");
					comboBox3.Items.Add("ΜΗΧΑΝΗΜΑΤΑ");
					comboBox3.Items.Add("ΝΤΑΛΙΚΑ");
					comboBox3.Items.Add("ΤΡΑΚΤΕΡ");
					comboBox3.Items.Add("ΚΛΑΡΚ");
					comboBox3.Items.Add("ΤΑΞΙ");
					label6.Text = "";
					comboBox4.Items.Clear();
					label7.Text = "";
					comboBox5.Items.Clear();
				}
				if (comboBox2.SelectedIndex == 3)
				{
					label5.Text = "ΜΗΚΟΣ";
					comboBox3.Items.Clear();
					comboBox3.Items.Add("2");
					comboBox3.Items.Add("4");
					comboBox3.Items.Add("6");
					comboBox3.Items.Add("8");
					comboBox3.Items.Add("10");
					comboBox3.Items.Add("12");
					label6.Text = "ΧΡΟΝΟ";
					comboBox4.Items.Clear();
					comboBox4.Items.Add("2010");
					comboBox4.Items.Add("2011");
					comboBox4.Items.Add("2012");
					comboBox4.Items.Add("2013");
					comboBox4.Items.Add("2014");
					comboBox4.Items.Add("2015");
					comboBox4.Items.Add("2016");
					comboBox4.Items.Add("2017");
					comboBox4.Items.Add("2018");
					comboBox4.Items.Add("2019");
					comboBox4.Items.Add("2020");
					label7.Text = "ΖΗΜΙΑ";
					comboBox5.Items.Clear();
					comboBox5.Items.Add("ΝΑΙ");
					comboBox5.Items.Add("ΟΧΙ");
				}
				else if (comboBox2.SelectedIndex == 4)
				{
					label5.Text = "ΤΥΠΟΣ";
					comboBox3.Items.Clear();
					comboBox3.Items.Add("ΠΟΔΗΛΑΤΟ");
					comboBox3.Items.Add("ΜΟΝΤΕΛΙΣΜΟΣ");
					label6.Text = "";
					comboBox4.Items.Clear();
					label7.Text = "";
					comboBox5.Items.Clear();
				}
				else if (comboBox2.SelectedIndex == 5)
				{
					label5.Text = "ΤΥΠΟΣ";
					comboBox3.Items.Clear();
					comboBox3.Items.Add("ΑΝΤΑΛΛΑΚΤΙΚΑ");
					label6.Text = "";
					comboBox4.Items.Clear();
					label7.Text = "";
					comboBox5.Items.Clear();
				}
			}
			else if (comboBox1.SelectedIndex == 2)
			{
				if (comboBox2.SelectedIndex == 0)
				{
					label5.Text = "ΤΕΤΡΑΓΩΝΙΚΑ ΜΕΤΡΑ";
					comboBox3.Items.Clear();
					comboBox3.Items.Add("50");
					comboBox3.Items.Add("100");
					comboBox3.Items.Add("200");
					comboBox3.Items.Add("ΑΛΛΟ");
					label6.Text = "ΧΡΗΣΗ";
					comboBox4.Items.Clear();
					comboBox4.Items.Add("ΠΩΛΗΣΗ");
					comboBox4.Items.Add("ΕΝΟΙΚΙΑΣΗ");
					label7.Text = "ΕΞΤΡΑ";
					comboBox5.Items.Clear();
					comboBox5.Items.Add("ΕΠΙΠΛΟΜΕΝΟ");
					comboBox5.Items.Add("ΑΝΑΚΑΙΝΙΣΜΕΝΟ");
					comboBox5.Items.Add("ΦΟΙΤΙΤΙΚΟ");
				}
				else if (comboBox2.SelectedIndex == 1)
				{
					label5.Text = "ΤΕΤΡΑΓΩΝΙΚΑ ΜΕΤΡΑ";
					comboBox3.Items.Clear();
					comboBox3.Items.Add("50");
					comboBox3.Items.Add("100");
					comboBox3.Items.Add("200");
					comboBox3.Items.Add("ΑΛΛΟ");
					label6.Text = "ΧΡΗΣΗ";
					comboBox4.Items.Clear();
					comboBox4.Items.Add("ΠΩΛΗΣΗ");
					comboBox4.Items.Add("ΕΝΟΙΚΙΑΣΗ");
					label7.Text = "ΕΞΤΡΑ";
					comboBox5.Items.Clear();
					comboBox5.Items.Add("ΕΠΙΠΛΟΜΕΝΟ");
					comboBox5.Items.Add("ΑΝΑΚΑΙΝΙΣΜΕΝΟ");
					comboBox5.Items.Add("ΦΟΙΤΙΤΙΚΟ");
				}
				else if (comboBox2.SelectedIndex == 2)
				{
					label5.Text = "ΤΕΤΡΑΓΩΝΙΚΑ ΜΕΤΡΑ";
					comboBox3.Items.Clear();
					comboBox3.Items.Add("50");
					comboBox3.Items.Add("100");
					comboBox3.Items.Add("200");
					comboBox3.Items.Add("ΑΛΛΟ");
					label6.Text = "ΧΡΗΣΗ";
					comboBox4.Items.Clear();
					comboBox4.Items.Add("ΠΩΛΗΣΗ");
					comboBox4.Items.Add("ΕΝΟΙΚΙΑΣΗ");
					label7.Text = "ΕΞΤΡΑ";
					comboBox5.Items.Clear();
					comboBox5.Items.Add("ΕΠΙΠΛΟΜΕΝΟ");
					comboBox5.Items.Add("ΑΝΑΚΑΙΝΙΣΜΕΝΟ");
					comboBox5.Items.Add("ΦΟΙΤΙΤΙΚΟ");
				}
				else if (comboBox2.SelectedIndex == 3)
				{
					label5.Text = "ΤΕΤΡΑΓΩΝΙΚΑ ΜΕΤΡΑ";
					comboBox3.Items.Clear();
					comboBox3.Items.Add("50");
					comboBox3.Items.Add("100");
					comboBox3.Items.Add("200");
					comboBox3.Items.Add("ΑΛΛΟ");
					label6.Text = "ΧΡΗΣΗ";
					comboBox4.Items.Clear();
					comboBox4.Items.Add("ΠΩΛΗΣΗ");
					comboBox4.Items.Add("ΕΝΟΙΚΙΑΣΗ");
					label7.Text = "ΕΞΤΡΑ";
					comboBox5.Items.Clear();
					comboBox5.Items.Add("ΕΞΤΡΑ");
				}
				else if (comboBox2.SelectedIndex == 4)
				{
					label5.Text = "ΤΕΤΡΑΓΩΝΙΚΑ ΜΕΤΡΑ";
					comboBox3.Items.Clear();
					comboBox3.Items.Add("50");
					comboBox3.Items.Add("100");
					comboBox3.Items.Add("200");
					comboBox3.Items.Add("ΑΛΛΟ");
					label6.Text = "ΧΡΗΣΗ";
					comboBox4.Items.Clear();
					comboBox4.Items.Add("ΠΩΛΗΣΗ");
					comboBox4.Items.Add("ΕΝΟΙΚΙΑΣΗ");
					label7.Text = "ΕΞΤΡΑ";
					comboBox5.Items.Clear();
					comboBox5.Items.Add("ΕΠΙΠΛΟΜΕΝΟ");
					comboBox5.Items.Add("ΑΝΑΚΑΙΝΙΣΜΕΝΟ");
				}
				else if (comboBox2.SelectedIndex == 5)
				{
					label5.Text = "ΤΥΠΟΣ";
					comboBox3.Items.Clear();
					comboBox3.Items.Add("ΧΩΡΟΣ ΠΑΡΚΙΝΓΚ");
					label6.Text = "";
					comboBox4.Items.Clear();
					label7.Text = "";
					comboBox5.Items.Clear();
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|Database1.mdb";
			int COUNT;
			using (OleDbConnection con = new OleDbConnection(connString))
			{
				DateTime today = DateTime.Today;
				con.Open();
				if (textBox1.TextLength == 0 || textBox2.TextLength == 0 || numericUpDown1.Value == 0 )
				{
					MessageBox.Show("Συμπλήρωσε τα απαραίτητα πεδία");
				}
				else
				{

					string query2 = "SELECT COUNT(*) FROM ADS";
					using (OleDbCommand CMD2 = new OleDbCommand(query2, con))
					{
						COUNT = (int)CMD2.ExecuteScalar();
					}


					int nexthop = COUNT + 2;


					int category = 0;

			
					string str = comboBox2.Text;
					switch (str)
					{
						case "ΤΗΛΕΦΩΝΙΑ":
							category = 4;
							break;
						case "PC_ΛΑΠΤΟΠ":
							category = 5;
							break;
						case "ΣΥΣΚΕΥΕΣ_ΗΧΟΥ":
							category = 6;
							break;
						case "ΤΗΛΕΟΡΑΣΕΙΣ":
							category = 7;
							break;
						case "ΦΩΤΟΓΡΑΦΙΑ":
							category = 8;
							break;
						case "ΟΙΚΙΑΚΕΣ ΣΥΣΚΕΥΕΣ":
							category = 9;
							break;
						case "ΑΥΤΟΚΙΝΗΤΑ":
							category = 10;
							break;
						case "ΜΗΧΑΝΕΣ":
							category = 11;
							break;
						case "ΕΠΑΓΓΕΛΜΑΤΙΚΑ":
							category = 12;
							break;
						case "ΣΚΑΦΟΙ":
							category = 13;
							break;
						case "ΑΛΛΑ ΟΧΗΜΑΤΑ":
							category = 14;
							break;
						case "ΑΝΤΑΛΛΑΚΤΙΚΑ":
							category = 15;
							break;
						case "ΔΙΑΜΕΡΙΣΜΑΤΑ":
							category = 16;
							break;
						case "ΜΟΝΟΚΑΤΟΙΚΙΕΣ":
							category = 17;
							break;
						case "ΕΠΑΓΓΕΛΜΑΤΙΚΟΙ ΧΩΡΟΙ":
							category = 18;
							break;
						case "ΟΙΚΟΠΕΔΑ":
							category = 19;
							break;
						case "ΕΞΩΧΙΚΑ":
							category = 20;
							break;
						case "ΧΩΡΟΙ ΠΑΡΚΙΝΓΚ":
							category = 21;
							break;
						default:
							MessageBox.Show("Συμπλήρωσε Υποκατηγορία");
							return ;
					}



					int prop1=0;
					int prop2=0;
					int prop3=0;

					string str1 = comboBox3.Text;

					switch (str1)
					{
						case "XIAOMI":
							prop1 = 1;
							break;
						case "SAMSUNG":
							if (category == 4)
								prop1 = 2;
							else if (category == 7)
								prop1 = 46;
							break;
						case "APPLE":
							if (category == 4)
								prop1 = 3;
							else if (category == 5)
								prop1 = 21;
							break;
						case "HUAWEI":
							prop1 = 4;
							break;
						case "NOKIA":
							prop1 = 5;
							break;
						case "ONEPLUS":
							prop1 = 6;
							break;
						case "DELL":
							if (category == 5)
								prop1 = 17;
							else if (category == 7)
								prop1 = 50;
							break;
						case "LENOVO":
							prop1 = 18;
							break;
						case "HP":
							prop1 = 19;
							break;
						case "ASUS":
							prop1 = 20;
							break;
						case "MSI":
							prop1 = 22;
							break;
						case "ΑΚΟΥΣΤΙΚΑ":
							prop1 = 34;
							break;
						case "ΚΑΡΤΑ ΗΧΟΥ":
							prop1 = 35;
							break;
						case "ΜΙΚΤΗΣ":
							prop1 = 36;
							break;
						case "ΗΧΕΙΑ":
							prop1 = 37;
							break;
						case "LG":
							prop1 = 47;
							break;
						case "SONY":
							prop1 = 48;
							break;
						case "PHILLIPS":
							prop1 = 49;
							break;
						case "MIRRORLESS":
							prop1 = 63;
							break;
						case "DSLR":
							prop1 = 64;
							break;
						case "COMPACT":
							prop1 = 65;
							break;
						case "VIDEOCAMERA":
							prop1 = 66;
							break;
						case "ΘΕΡΜΑΝΣΗ":
							prop1 = 73;
							break;
						case "ΜΙΚΡΕΣ ΣΥΣΚΕΥΕΣ":
							prop1 = 74;
							break;
						case "ΜΕΓΑΛΕΣ ΣΥΣΚΕΥΕΣ":
							prop1 = 75;
							break;
						case "ΑΞΕΣΟΥΑΡ":
							prop1 = 76;
							break;
						case "ΚΛΙΜΑΤΙΣΜΟΣ":
							prop1 = 77;
							break;
						case "ΚΟΥΠΕ":
							prop1 = 78;
							break;
						case "ΑΓΡΟΤΙΚΟ":
							prop1 = 79;
							break;
						case "ΚΟΜΠΑΚΤ":
							prop1 = 80;
							break;
						case "ΑΓΩΝΙΣΤΙΚΟ":
							prop1 = 81;
							break;
						case "BMW":
							prop1 = 115;
							break;
						case "DAYTONA":
							prop1 = 116;
							break;
						case "DUCATI":
							prop1 = 117;
							break;
						case "GILERA":
							prop1 = 118;
							break;
						case "HONDA":
							prop1 = 119;
							break;
						case "KTM":
							prop1 = 120;
							break;
						case "KAWASAKI":
							prop1 = 121;
							break;
						case "PIAGGIO":
							prop1 = 122;
							break;
						case "SUZUKI":
							prop1 = 123;
							break;
						case "SYM":
							prop1 = 124;
							break;
						case "YAMAHA":
							prop1 = 125;
							break;
						case "ΦΟΡΤΗΓΟ":
							prop1 = 152;
							break;
						case "ΛΕΟΦΩΡΕΙΟ":
							prop1 = 153;
							break;
						case "ΜΗΧΑΝΗΜΑΤΑ":
							prop1 = 154;
							break;
						case "ΝΤΑΛΙΚΑ":
							prop1 = 155;
							break;
						case "ΤΡΑΚΤΕΡ":
							prop1 = 156;
							break;
						case "ΚΛΑΡΚ":
							prop1 = 157;
							break;
						case "ΤΑΞΙ":
							prop1 = 158;
							break;
						case "2":
							prop1 = 159;
							break;
						case "4":
							prop1 = 160;
							break;
						case "6":
							prop1 = 161;
							break;
						case "8":
							prop1 = 162;
							break;
						case "10":
							prop1 = 163;
							break;
						case "12":
							prop1 = 164;
							break;
						case "ΠΟΔΗΛΑΤΟ":
							prop1 = 178;
							break;
						case "ΜΟΝΤΕΛΙΣΜΟΣ":
							prop1 = 179;
							break;
						case "ΑΝΤΑΛΛΑΚΤΙΚΑ":
							prop1 = 180;
							break;
						case "50":
							if (category == 16)
								prop1 = 181;
							else if (category == 17)
								prop1 = 190;
							else if (category == 18)
								prop1 = 199;
							else if (category == 19)
								prop1 = 208;
							else if (category == 20)
								prop1 = 215;
							break;
						case "100":
							if (category == 16)
								prop1 = 182;
							else if (category == 17)
								prop1 = 191;
							else if (category == 18)
								prop1 = 200;
							else if (category == 19)
								prop1 = 209;
							else if (category == 20)
								prop1 = 216;
							break;
						case "200":
							if (category == 16)
								prop1 = 183;
							else if (category == 17)
								prop1 = 192;
							else if (category == 18)
								prop1 = 201;
							else if (category == 19)
								prop1 = 210;
							else if (category == 20)
								prop1 = 217;
							break;
						case "ΑΛΛΟ":
							if (category == 16)
								prop1 = 184;
							else if (category == 17)
								prop1 = 193;
							else if (category == 18)
								prop1 = 202;
							else if (category == 19)
								prop1 = 211;
							else if (category == 20)
								prop1 = 218;
							break;
						case "ΤΥΠΟΣ":
							prop1 = 223;
							break;
						default:
							MessageBox.Show("Συμπλήρωσε " + label5.Text );
							return;
					}


					string str2 = comboBox4.Text;

					switch (str2)
					{
						case "2GB":
							prop2 = 7;
							break;
						case "3GB":
							prop2 = 8;
							break;
						case "4GB":
							prop2 = 9;
							break;
						case "6GB":
							prop2 = 10;
							break;
						case "8GB":
							prop2 = 11;
							break;
						case "12GB":
							prop2 = 12;
							break;
						case "11,6":
							prop2 = 23;
							break;
						case "12,5":
							prop2 = 24;
							break;
						case "13,3":
							prop2 = 25;
							break;
						case "14":
							prop2 = 26;
							break;
						case "15,6":
							prop2 = 27;
							break;
						case "17":
							prop2 = 28;
							break;
						case "20":
							prop2 = 38;
							break;
						case "40":
							if (category == 6)
								prop2 = 39;
							else if (category == 7)
								prop2 = 53;
							break;
						case "80":
							prop2 = 40;
							break;
						case "100":
							if (category == 6)
								prop2 = 41;
							else if (category == 11)
								prop2 = 128;
							break;
						case "200":
							if (category == 6)
								prop2 = 42;
							else if (category == 11)
								prop2 = 131;
							break;
						case "27":
							prop2 = 51;
							break;
						case "32":
							prop2 = 52;
							break;
						case "43":
							prop2 = 54;
							break;
						case "48":
							prop2 = 55;
							break;
						case "50":
							if (category == 7)
								prop2 = 56;
							else if (category == 11)
								prop2 = 126;
							break;
						case "55":
							prop2 = 57;
							break;
						case "65":
							prop2 = 58;
							break;
						case "70":
							prop2 = 59;
							break;
						case "FULLFRAME":
							prop2 = 67;
							break;
						case "APS-C":
							prop2 = 68;
							break;
						case "MICRO 4/3":
							prop2 = 69;
							break;
						case "MEDIUM FORMAT":
							prop2 = 70;
							break;
						case "AUDI":
							prop2 = 82;
							break;
						case "CITROEN":
							prop2 = 83;
							break;
						case "BMW":
							prop2 = 84;
							break;
						case "FIAT":
							prop2 = 85;
							break;
						case "FORD":
							prop2 = 86;
							break;
						case "HUYNDAI":
							prop2 = 87;
							break;
						case "MERCEDES":
							prop2 = 88;
							break;
						case "NISSAN":
							prop2 = 89;
							break;
						case "OPEL":
							prop2 = 90;
							break;
						case "PEUGEOT":
							prop2 = 91;
							break;
						case "RENAULT":
							prop2 = 92;
							break;
						case "SMART":
							prop2 = 93;
							break;
						case "SUZUKI":
							prop2 = 94;
							break;
						case "TOYOTA":
							prop2 = 95;
							break;
						case "VW":
							prop2 = 96;
							break;
						case "ΑΛΛΟ":
							if (category == 10)
								prop2 = 97;
							else if (category == 11)
								prop2 = 139;
							break;
						case "75":
							prop2 = 127;
							break;
						case "125":
							prop2 = 129;
							break;
						case "150":
							prop2 = 130;
							break;
						case "250":
							prop2 = 132;
							break;
						case "300":
							prop2 = 133;
							break;
						case "400":
							prop2 = 134;
							break;
						case "500":
							prop2 = 135;
							break;
						case "600":
							prop2 = 136;
							break;
						case "700":
							prop2 = 137;
							break;
						case "1000":
							prop2 = 138;
							break;
						case "2010":
							prop2 = 165;
							break;
						case "2011":
							prop2 = 166;
							break;
						case "2012":
							prop2 = 167;
							break;
						case "2013":
							prop2 = 168;
							break;
						case "2014":
							prop2 = 169;
							break;
						case "2015":
							prop2 = 170;
							break;
						case "2016":
							prop2 = 171;
							break;
						case "2017":
							prop2 = 172;
							break;
						case "2018":
							prop2 = 173;
							break;
						case "2019":
							prop2 = 174;
							break;
						case "2020":
							prop2 = 175;
							break;
						case "ΠΩΛΗΣΗ":
							if (category == 16)
								prop2 = 185;
							else if (category == 17)
								prop2 = 194;
							else if (category == 18)
								prop2 = 203;
							else if (category == 19)
								prop2 = 212;
							else if (category == 20)
								prop2 = 219;
							break;
						case "ΕΝΟΙΚΙΑΣΗ":
							if (category == 16)
								prop2 = 186;
							else if (category == 17)
								prop2 = 195;
							else if (category == 18)
								prop2 = 204;
							else if (category == 19)
								prop2 = 213;
							else if (category == 20)
								prop2 = 220;
							break;
						default:
							if (category == 9 || category == 12 || category == 14 || category == 15 || category == 23)
							{
								break;
							}
							else
							{
								MessageBox.Show("Συμπλήρωσε " + label6.Text);
								return;
							}
					}


					string str3 = comboBox5.Text;

					switch (str3)
					{
						case "2000MAH":
							prop3 = 13;
							break;
						case "3000MAH":
							prop3 = 14;
							break;
						case "4000MAH":
							prop3 = 15;
							break;
						case "5000MAH":
							prop3 = 16;
							break;
						case "INTEL CORE I9":
							prop3 = 29;
							break;
						case "INTEL CORE I7":
							prop3 = 30;
							break;
						case "INTEL CORE I5":
							prop3 = 31;
							break;
						case "INTEL CORE I3":
							prop3 = 32;
							break;
						case "AMD  RYZEN":
							prop3 = 33;
							break;
						case "2":
							prop3 = 43;
							break;
						case "4":
							prop3 = 44;
							break;
						case "8":
							prop3 = 45;
							break;
						case "FHD":
							prop3 = 60;
							break;
						case "4K UHD":
							prop3 = 61;
							break;
						case "8K UHD":
							prop3 = 62;
							break;
						case "BLUETTOTH":
							prop3 = 71;
							break;
						case "WIFI":
							prop3 = 72;
							break;
						case "800":
							prop3 = 98;
							break;
						case "900":
							prop3 = 99;
							break;
						case "1000":
							prop3 = 100;
							break;
						case "1100":
							prop3 = 101;
							break;
						case "1200":
							prop3 = 102;
							break;
						case "1300":
							prop3 = 103;
							break;
						case "1400":
							prop3 = 104;
							break;
						case "1500":
							prop3 = 105;
							break;
						case "1600":
							prop3 = 106;
							break;
						case "1700":
							prop3 = 107;
							break;
						case "1800":
							prop3 = 108;
							break;
						case "1900":
							prop3 = 109;
							break;
						case "2000":
							prop3 = 110;
							break;
						case "2250":
							prop3 = 111;
							break;
						case "2500":
							prop3 = 112;
							break;
						case "2750":
							prop3 = 113;
							break;
						case "3000":
							prop3 = 114;
							break;
						case "2010":
							prop3 = 140;
							break;
						case "2011":
							prop3 = 141;
							break;
						case "2012":
							prop3 = 142;
							break;
						case "2013":
							prop3 = 143;
							break;
						case "2014":
							prop3 = 144;
							break;
						case "2015":
							prop3 = 145;
							break;
						case "2016":
							prop3 = 146;
							break;
						case "2017":
							prop3 = 147;
							break;
						case "2018":
							prop3 = 148;
							break;
						case "2019":
							prop3 = 149;
							break;
						case "2020":
							prop3 = 150;
							break;
						case "ΝΑΙ":
							prop3 = 176;
							break;
						case "ΟΧΙ":
							prop3 = 177;
							break;
						case "ΕΠΙΠΛΟΜΕΝΟ":
							if (category == 16)
								prop3 = 187;
							else if (category == 17)
								prop3 = 196;
							else if (category == 18)
								prop3 = 205;
							else if (category == 20)
								prop3 = 221;
							break;
						case "ΑΝΑΚΑΙΝΙΣΜΕΝΟ":
							if (category == 16)
								prop3 = 188;
							else if (category == 17)
								prop3 = 197;
							else if (category == 18)
								prop3 = 206;
							else if (category == 20)
								prop3 = 222;
							break;
						case "ΦΟΙΤΙΤΙΚΟ":
							if (category == 16)
								prop3 = 189;
							else if (category == 17)
								prop3 = 198;
							else if (category == 18)
								prop3 = 207;
							break;
						case "ΕΞΤΡΑ":
							prop3 = 214;
							break;
						default:
							if (category == 9 || category == 12 || category == 14 || category == 15 || category == 23)
							{
								break;
							}
							else
							{
								MessageBox.Show("Συμπλήρωσε " + label7.Text);
								return;
							}

					}

				Random rnd = new Random();
				int randomnum = rnd.Next(1, 54);
				string PEND = "PENDING";

				string query = "INSERT INTO ADS( AD_ID , AD_TITLE, DESCRIPTION, INSERT_DATE, PRICE, CATEGORY_ID, AREA_ID, STATUS)" + " VALUES('" + nexthop + "' , '" + textBox1.Text + "', '" + textBox2.Text + "', '" + today.ToString() + "', '" + numericUpDown1.Value + "', '" + category + "', '" + randomnum + "', '" + PEND + "'); ";
				using (OleDbCommand cmd = new OleDbCommand(query, con))
				{
					int i = cmd.ExecuteNonQuery();
				}
				
				string query1 = "INSERT INTO PROPERTIES_VALUE(AD_ID, PROPERTIES1 , PROPERTIES2 , PROPERTIES3)" + " VALUES('" + nexthop + "', '" + prop1 + "', '" + prop2 + "','" + prop3 + "');";
				using (OleDbCommand cmd1 = new OleDbCommand(query1, con))
				{
					int J = cmd1.ExecuteNonQuery();
					if (J >= 1 )
					{
						MessageBox.Show("Προσθέθηκε επιτυχώς");
					}
					
				}

				con.Close();
				}
			}
		}
	}
}