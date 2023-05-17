using System;
using System.IO;

namespace AndroidSideloader
{
    internal class Logger
    {
        public string logfile = Properties.Settings.Default.CurrentLogPath;
        public static bool Log(string text, string logLevel = "NOTICE", bool ret = true)
        {
            if (text.Length <= 5)
                return ret;

            string time = DateTime.UtcNow.ToString("hh:mmtt(UTC): ");
            string newline = text.Length > 40 && text.Contains("\n") ? "\n\n" : "\n";
            string logEntry = time + "[" + logLevel.ToUpper() + "] " + text + newline;

            try
            {
                File.AppendAllText(Properties.Settings.Default.CurrentLogPath, logEntry);
            }
            catch
            {
                // Handle the exception if necessary
            }

            return ret;
        }
    }
}
