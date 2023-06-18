using System;
using System.IO;
using System.Text;

namespace AndroidSideloader
{
    public enum LogLevel
    {
        DEBUG,
        INFO,
        WARNING,
        ERROR,
        TRACE,
        FATAL
    }

    public static class Logger
    {
        private static readonly object lockObject = new object();
        private static string logFilePath = Properties.Settings.Default.CurrentLogPath;
        private static bool enableContextualLogging = true;

        public static bool Log(string text, LogLevel logLevel = LogLevel.INFO, bool ret = true)
        {
            if (string.IsNullOrWhiteSpace(text) || text.Length <= 5)
                return ret;

            string time = DateTime.UtcNow.ToString("hh:mm:ss.fff tt (UTC): ");
            string newline = text.Length > 40 && text.Contains("\n") ? "\n\n" : "\n";
            string logEntry = time + "[" + logLevel.ToString().ToUpper() + "] [" + GetCallerInfo() + "] " + text + newline;

            try
            {
                lock (lockObject)
                {
                    File.AppendAllText(logFilePath, logEntry);
                }
            }
            catch
            {
                // Handle the exception if necessary
            }

            return ret;
        }

        public static void SetLogFilePath(string path)
        {
            logFilePath = path;
        }

        public static void EnableContextualLogging(bool enable)
        {
            enableContextualLogging = enable;
        }

        private static string GetCallerInfo()
        {
            System.Diagnostics.StackTrace stackTrace = new System.Diagnostics.StackTrace(true);
            if (stackTrace.FrameCount >= 3)
            {
                var frame = stackTrace.GetFrame(2);
                var method = frame.GetMethod();
                string className = method.DeclaringType?.Name;
                string methodName = method.Name;
                string callerInfo = $"{className}.{methodName}";
                return callerInfo;
            }

            return string.Empty;
        }
    }
}
