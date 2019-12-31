using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WP9_SearchBar_EK
{
    public static class Global
    {
        public static string getIP()
        {
            string externalip = new WebClient().DownloadString("http://icanhazip.com");
            return externalip;
        }
    }
}
