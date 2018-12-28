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
        public static Withdraw withdrawForm;
        public static Deposit depositForm;
        public static OpenNewSubAccount openNewAccountForm;
        public static IssueCard IssueCardForm;
        public static ViewTransaction viewTransactions;
        public static CityAvg cityAvg;
        public static IssuersByCity issuersByCity;
        public static int RoleID = 0;

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