using LiteDB.Studio.Forms;
using System;
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
        public static void HandleError(Exception ex) => MessageBox.Show(ex.Message, "An Error Occurred");
    }
}
