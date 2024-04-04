using System;
using System.IO;
using System.Security.Permissions;
using System.Windows.Forms;

namespace AndroidSideloader
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]
        private static void Main()
        {

            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(CrashHandler);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (AndroidSideloader.Properties.Settings.Default.UpdateSettings)
            {
                AndroidSideloader.Properties.Settings.Default.Upgrade();
                AndroidSideloader.Properties.Settings.Default.UpdateSettings = false;
                AndroidSideloader.Properties.Settings.Default.Save();
            }
            form = new MainForm();
            Application.Run(form);
            //form.Show();
        }
        public static MainForm form;

        private static void CrashHandler(object sender, UnhandledExceptionEventArgs args)
        {
            // Capture unhandled exceptions and write to file.
            Exception e = (Exception)args.ExceptionObject;
            string innerExceptionMessage = (e.InnerException != null)
                ? e.InnerException.Message
                : "None";
            string date_time = DateTime.Now.ToString("dddd, MMMM dd @ hh:mmtt (UTC)");
            File.WriteAllText(Sideloader.CrashLogPath, $"Date/Time of crash: {date_time}\nMessage: {e.Message}\nInner Message: {innerExceptionMessage}\nData: {e.Data}\nSource: {e.Source}\nTargetSite: {e.TargetSite}\nStack Trace: \n{e.StackTrace}\n\n\nDebuglog: \n\n\n");
            // If a debuglog exists we append it to the crashlog.
            if (File.Exists(Properties.Settings.Default.CurrentLogPath))
            {
                File.AppendAllText(Sideloader.CrashLogPath, File.ReadAllText($"{Properties.Settings.Default.CurrentLogPath}"));
            }
        }
    }
}
