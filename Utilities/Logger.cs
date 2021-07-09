using System;
using System.IO;

namespace AndroidSideloader
{
    class Logger
    {
        public static string logfile = "debuglog.txt";

        public static bool Log(string text, bool ret = true)
        {
            if (text.Length > 0)
            {
                string time = DateTime.UtcNow.ToString("hh:mmtt(UTC): ");
                string newline = "\n";
                if (text.Length > 40 && text.Contains("\n"))
                    newline += "\n\n";
                text = time += text;
                try { File.AppendAllText(logfile, text + newline); } catch { }
                return ret;
            }
            else
                return ret;
            
        }
    }
}
