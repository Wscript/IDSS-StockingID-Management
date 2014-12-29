using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDSS_StockingID_Management
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main ()
        {
            Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault (false);
            formLogin formLogin = new formLogin ();
            formLogin.ShowDialog ();
            if (formLogin.DialogResult == DialogResult.OK)
            {
                Application.Run (new formStockingIDManagement());
            }
        }
    }

    public class Global
    {
        public static string stringUserName;
    }
}
