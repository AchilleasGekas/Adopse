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
    public partial class Add_description_v : Form
    {
        public Add_description_v()
        {
            InitializeComponent();
        }

        private void Add_description_v_Load(object sender, EventArgs e)
        {
            populateItems_add_descr();
            populateItems_left_filters();

        }
        private void flowLayoutPanel1_add_descr_Paint(object sender, PaintEventArgs e)
        {

        }

        private void populateItems_add_descr()
        {
            description_of_add[] listItems = new description_of_add[20];

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new description_of_add();
                listItems[i].Title = "Πολυτελής καλόγερος από μασίφ ξύλο και μπρούντζο";
                listItems[i].Message = "Κλασσικός καλόγερος σε πολύ καλή κατάσταση, με κορμό ύψους 177cm με πομπέ και σκαλιστές δακτυλιοειδείς διακοσμήσεις που καταλήγει σε τριγωνική βάση οβάλ πλευρών 44cm, 4 σκαλιστούς μεταλλικούς χρυσαφί γάντζους σε σχήμα S με 8 άγκιστρα και 4 μπρονζέ πόμολα για ομπρέλες, για έναν ξεχωριστό χώρο υποδοχής.";

                // if (flowLayoutPanel1.Controls.Count > 0)
                // {
                //    flowLayoutPanel1.Controls.Clear();
                //}
                //else
                flowLayoutPanel1_add_descr.Controls.Add(listItems[i]);

            }

        }
        private void populateItems_left_filters()
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
                flowLayoutPanel2_add_descr.Controls.Add(listItems[i]);


            }
            }

        private void flowLayoutPanel2_add_descr_Paint(object sender, PaintEventArgs e)
        {

        }

        private void description_of_add1_Load(object sender, EventArgs e)
        {

        }
    }
    }
