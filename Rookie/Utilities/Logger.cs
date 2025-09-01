using AndroidSideloader.Utilities;
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
        private static readonly SettingsManager settings = SettingsManager.Instance;
        private static readonly object lockObject = new object();
        private static string logFilePath = settings.CurrentLogPath;

        public static void Initialize()
        {
            try
            {
                // Set default log path if not already set
                if (string.IsNullOrEmpty(logFilePath))
                {
                    logFilePath = Path.Combine(Environment.CurrentDirectory, "debuglog.txt");
                }

                // Create directory if it doesn't exist
                string logDirectory = Path.GetDirectoryName(logFilePath);
                if (!string.IsNullOrEmpty(logDirectory) && !Directory.Exists(logDirectory))
                {
                    Directory.CreateDirectory(logDirectory);
                }

                // Create log file if it doesn't exist
                if (!File.Exists(logFilePath))
                {
                    using (FileStream fs = File.Create(logFilePath))
                    {
                        // Create empty file
                    }
                }

                // Update settings with log path
                settings.CurrentLogPath = logFilePath;
                settings.Save();

                // Initial log entry
                Log($"Logger initialized at: {DateTime.Now:hh:mmtt(UTC)}", LogLevel.INFO);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error initializing logger: {ex.Message}");
            }
        }

        public static bool Log(string text, LogLevel logLevel = LogLevel.INFO, bool ret = true)
        {
            if (string.IsNullOrWhiteSpace(text) || text.Length <= 5)
                return ret;

            // Initialize logger if not already initialized
            if (string.IsNullOrEmpty(logFilePath))
            {
                Initialize();
            }

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
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to log: {ex.Message}");
            }

            return ret;
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
