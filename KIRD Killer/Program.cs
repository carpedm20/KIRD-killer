using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KIRD_Killer
{
    static class Program
    {
        public static string cookie="";
        public static bool success = false;
        public static bool seeAd = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            if (success == true)
            {
                System.Diagnostics.Process.Start("http://www.kird.re.kr/front/portal/main/Main.jsp");

                if (seeAd == true)
                {
                    Application.Run(new BrowserForm("http://carpedm20.net76.net/robot.html"));
                }
            }
        }
    }
}
