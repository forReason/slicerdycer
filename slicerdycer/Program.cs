using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slicerdycer
{
    public class GlobalVar
    {
        public const string configPath = "Config.cfg";
        public const string botConfigPath = "config/config.json";

        public static string htmlreturn = null;
        public static string api = null;
        public static string user = null;
        public static int balance = 0;
        public static int betting = 0;
        public static int safety = 2048;
        public static bool pause = true;
        public static bool firstnegative = true;
        public static bool positivetransaction = true;
    };

    static class Program
    {
        
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SettingsHandler.CheckSettings();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginwindow());
            Application.Run(new Botting_Window());
        }
    }
}
