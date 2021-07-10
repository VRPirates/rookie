using System;
using System.IO;

namespace AndroidSideloader
{
    class Logger
    {
        public static string logfile = "debuglog.txt";

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
