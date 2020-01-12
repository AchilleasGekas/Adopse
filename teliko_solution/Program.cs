using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {

        public static bool change_lang = true;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome_Page());
			
			Trace.Listeners.Add(new TextWriterTraceListener("AdholicsErrors.log"));
            Trace.AutoFlush = true;
            Trace.Unindent();
            Trace.WriteLine("Adholics Closed!!");
            Trace.Unindent();
        }
    }
}
