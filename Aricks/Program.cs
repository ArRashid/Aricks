using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Aricks
{   //this call is made for some ccostume tool 
    public class ar
    {
        public static string constr = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
        // This methot Fot Using Connection from any ware in aplication 
        public static System.Data.OleDb.OleDbConnection gcon = new System.Data.OleDb.OleDbConnection(ar.constr);

    }
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
}
