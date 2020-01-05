using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieMediiSiInstrumenteDeProgramare
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
            Application.Run(new Form1());
        }

        public class Global
        {
            public static string strConectare = @"Data source=DESKTOP-B63QKOS\BAZADEDATESGBD; Initial Catalog=AppAvioane; Integrated Security=SSPI";
            public static SqlConnection con;
            public static DataSet dataset;
            public static SqlDataAdapter sda;
        }
    }
}
