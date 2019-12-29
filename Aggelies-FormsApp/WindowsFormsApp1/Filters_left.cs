using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Filters_left : UserControl
    {
        public Filters_left()
        {
            InitializeComponent();
        }
        private string _title;


        #region Properties

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitlef.Text = value; }
        }

       

        

        

        #endregion
        private void Ad_ListItem_Load(object sender, EventArgs e)
        {

        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitlef_Click(object sender, EventArgs e)
        {

        }
    }
}
