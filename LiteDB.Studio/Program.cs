using LiteDB.Studio.Forms;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace LiteDB.Studio
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>        
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartUpForm(args));
        }
        public static string AppVersion { get { return string.Format("v.{0}", Assembly.GetExecutingAssembly().GetName().Version.ToString()); } }
        public static void HandleError(Exception ex) => MessageBox.Show(ex.Message, "An Error Occurred");
    }
}
