using System;
using System.Windows.Forms;

namespace DB_GUI
{
    static class Program
    {
        public static Login loginForm;
        public static Registration registrationForm;
        public static services_page serviceFrom;
        public static Transfer_funds transferForm;
        public static settings settingForm;
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginForm = new Login();
            Application.Run(loginForm);
        }
    }
}