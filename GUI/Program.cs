using GUI.Form_DocGia;
using GUI.Form_NhaPhanPhoi;
using GUI.Form_PhieuMuon;
using GUI.Form_TacGia;
using GUI.Form_TheLoai;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CRUD_PhieuMuon());
        }
    }
}
