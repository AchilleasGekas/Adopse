using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP7_ErrorHandling
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Trace.Listeners.Add(new TextWriterTraceListener("AdholicsErrors.log"));
            Trace.AutoFlush = true;
            Trace.Unindent();
            Trace.WriteLine("Adholics Closed!!");
            Trace.Unindent();
           
           
        }
    }
}
