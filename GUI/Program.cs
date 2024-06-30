using DevExpress.XtraEditors;
using GUI.Login;
using System;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WindowsFormsSettings.LoadApplicationSettings();
            WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Tahoma", 8);

            WindowsFormsSettings.SetDPIAware();
            WindowsFormsSettings.SetPerMonitorDpiAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_form());
        }
    }
}
