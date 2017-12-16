using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Acceuil
{
    static class Program
    {
        public static SqlConnection Connection = new SqlConnection(@"Data Source=acer\sqlexpress;Initial Catalog=ARCHIVE_MJ;Integrated Security=True");
        public static SqlCommand CMD = new SqlCommand();
        public static DataSet DataSET = new DataSet();
        public static SqlDataReader DataReader;
        public static DataTable Table = new DataTable();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
