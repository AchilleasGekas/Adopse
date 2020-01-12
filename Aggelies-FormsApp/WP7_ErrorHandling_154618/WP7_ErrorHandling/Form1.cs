using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP7_ErrorHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
