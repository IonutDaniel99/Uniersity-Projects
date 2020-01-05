using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSGBD
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
            Application.Run(new MainForm());
        }
    }

    class Global
    {
        public static string strConectare = @"Data source=DESKTOP-B63QKOS\BAZADEDATESGBD; Initial Catalog=SGBD2k20; Integrated Security=SSPI";
        public static SqlConnection con;
        public static DataSet dataset;
        public static SqlDataAdapter sda;

    }
}
