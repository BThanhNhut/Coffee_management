using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        
        static void Main()
        {
            ///
            ///
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }
            DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            defaultLookAndFeel.LookAndFeel.SkinName = "Caramel";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_DangNhap());
        }
    }
}
