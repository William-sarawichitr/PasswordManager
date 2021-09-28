using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Password_Manager
{
    static class Program
    {
        public static bool OpenDetailFormOnClose { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            OpenDetailFormOnClose = false;

            Application.Run(new Login());

            if (OpenDetailFormOnClose)
            {
                Application.Run(new PasswordManager());
            }
            
        }

        //Current User
        public static class Globals
        {
            public static string USER = "";
            public static string USERHASH = "";
        }
    }
}
