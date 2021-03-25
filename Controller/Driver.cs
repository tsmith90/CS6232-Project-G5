using System;
using System.Windows.Forms;

namespace ClinicSupport
{
    /// <summary>
    /// Driver class for the ClinicSupport application
    /// </summary>
    static class Driver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
