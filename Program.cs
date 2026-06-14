using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildShell
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        /// 

        public static string shellversion = "3.0";
        public static int shellbuild = 14;
        public static string progress = "Release";
        [STAThread]        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Looper());
        }
    }
}
