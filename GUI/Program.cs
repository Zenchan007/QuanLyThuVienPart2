using DevExpress.XtraEditors;
using GUI.Form_BaoCao;
using GUI.Form_DocGia;
using GUI.Form_NhanVien;
using GUI.Form_NhaPhanPhoi;
using GUI.Form_PhieuMuon;
using GUI.Form_Sach;
using GUI.Form_TacGia;
using GUI.Form_TheLoai;
using GUI.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
