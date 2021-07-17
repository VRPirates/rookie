using System;
using System.IO;
using System.Windows.Forms;

namespace AndroidSideloader
{
    class Logger
    {
       public string logfile = Properties.Settings.Default.CurrentLogTitle;
        public static bool Log(string text, bool ret = true)
        {
   
            string time = DateTime.Now.ToString("hh:mmtt(UTC): ");
            if (text.Length > 5)
            {

                string newline = "\n";
                if (text.Length > 40 && text.Contains("\n"))
                    newline += "\n\n";
                try { File.AppendAllText(logfile, time + text + newline); } catch { }
                return ret;
            }
            return ret;
        }
    }
}
