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
    public partial class description_of_add : UserControl
    {
        public description_of_add()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void description_of_add_Load(object sender, PaintEventArgs e)
        {

        }

        private string _title;


        #region Properties

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }

        private string _message;

        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; lblDescr.Text = value; }
        }

        private Image _icon;
        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }

        #endregion


    }
}
