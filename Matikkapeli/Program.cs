using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matikkapeli
{
    static class Program
    {
        //public static string databaseFile = @"C:\Users\skype\source\repos\Matikkapeli\Matikkapeli\Database1.mdf";
        public static string databaseFile = @"C:\GitHub\Matikkapeli\Matikkapeli\Database1.mdf";
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + databaseFile + ";Integrated Security=True";

        public static MainMenu menu;
        public static LogIn login;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            menu = new MainMenu();
            login = new LogIn();

            Application.Run(login);
        }

        public static void OpenMain(string username)
        {
            menu.SetUsername(username);
            menu.Show();
        }

        public static void LogOut()
        {
            menu.Hide();
            login.Show();
        }
    }
}
