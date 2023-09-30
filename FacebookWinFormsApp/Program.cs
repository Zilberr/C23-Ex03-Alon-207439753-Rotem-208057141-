using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); 
            FormLogin loginForm = new FormLogin();
            loginForm.ShowDialog();
        }
    }
}
