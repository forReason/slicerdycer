using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slicerdycer
{
    public class GlobalVar
    {
        public const string configPath = "Config.cfg";
        public const string botConfigPath = "config/config.json";

        public static string[] htmlreturn = { null, null, null, null, null, null};
        public static string[] api = { null, null, null, null, null, null };
        public static string[] user = { "Account 1", "Account 2", "Account 3", "Account 4", "Account 5", "Account 6" };
        
        public static int[] balance = { 0, 0, 0, 0, 0, 0 };
        public static int[] betting = { 0, 0, 0, 0, 0, 0 };
        
        public static bool pause = true;
        public static bool[] firstnegative = { true, true, true, true, true, true };
        public static bool[] positivetransaction = { true, true, true, true, true, true };

        //settings 
        public static bool autoupdate = true;
        public static int difficulty = 50;
        public static int safety = 2048;
        public static bool useexploits = false;
        public static bool enabletipping = true;
        public static string tippingaccount = "forReason";
        public static int percenttotip = 1;
        public static bool enablewithdraw = false;
        public static string withdrawaddress = "123456789";
        public static int withdrawtreshold = 40000000;
        public static int withdrawpercent = 1;
        public static bool enabledonating = true;
        public static int donatepercent = 1;
        public static bool increasebetsecond = false;
        public static bool usesafetyvalue = true;
        public static bool disablesafetyfirstaccount = true;
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
            Updatesettings();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginwindow());
            Application.Run(new Botting_Window());
        }
        public static void Updatesettings()
        {
            GlobalVar.difficulty = (int)decimal.Parse(SettingsHandler.GetSettingValue("difficulty"));
            GlobalVar.safety = (int)decimal.Parse(SettingsHandler.GetSettingValue("safetylevel"));
            GlobalVar.useexploits = bool.Parse(SettingsHandler.GetSettingValue("useexploits"));
            GlobalVar.autoupdate = bool.Parse(SettingsHandler.GetSettingValue("autoupdate"));
            GlobalVar.enabletipping = bool.Parse(SettingsHandler.GetSettingValue("enabletipping"));
            GlobalVar.tippingaccount = SettingsHandler.GetSettingValue("accounttotipto");
            GlobalVar.percenttotip = (int)decimal.Parse(SettingsHandler.GetSettingValue("percenttotip"));
            GlobalVar.enablewithdraw = bool.Parse(SettingsHandler.GetSettingValue("enablewithdraw"));
            GlobalVar.withdrawaddress = SettingsHandler.GetSettingValue("withdrawadress");
            GlobalVar.withdrawtreshold = (int)decimal.Parse(SettingsHandler.GetSettingValue("withdrawtreshold"));
            GlobalVar.withdrawpercent = (int)decimal.Parse(SettingsHandler.GetSettingValue("withdrawpercent"));
            GlobalVar.enabledonating = bool.Parse(SettingsHandler.GetSettingValue("enabledonating"));
            GlobalVar.donatepercent = (int)decimal.Parse(SettingsHandler.GetSettingValue("donatepercent"));
            GlobalVar.increasebetsecond = bool.Parse(SettingsHandler.GetSettingValue("increasebetsecond"));
            GlobalVar.usesafetyvalue = bool.Parse(SettingsHandler.GetSettingValue("usesafetyvalue"));
            GlobalVar.disablesafetyfirstaccount = bool.Parse(SettingsHandler.GetSettingValue("disablesafetyfirstaccount"));
        }

        public static void ProgramLogic(int user)
        {
            //check if last transaction was positive or negative
            string[] Settings = Regex.Replace(Networkhandler.Get("users/1", user), "\"", string.Empty).Split(',');
            int tempbalance = (int)float.Parse(SettingsHandler.GetSettingFromAray("balance:", Settings));
            if (tempbalance < GlobalVar.balance[user])
            {
                GlobalVar.positivetransaction[user] = false;
            }
            else
            {
                GlobalVar.positivetransaction[user] = true;
            }
            //set new balance
            GlobalVar.balance[user] = tempbalance;
            //if positive transaction 
            if (GlobalVar.positivetransaction[user] == true)
            {
                //When balence/safety(2048) smaller than 1 satoshi, then Bet an satoshi 
                if ((GlobalVar.balance[user] / GlobalVar.safety) < 1 || GlobalVar.disablesafetyfirstaccount == true && user == 0)
                {
                    Networkhandler.Bet(1, user);
                    GlobalVar.betting[user] = 1;
                    GlobalVar.firstnegative[user] = true;
                }
                //otherwhise keep distance so that at least 12 times in a row can be a loss (happens 1 out of 4k rolls stochastically)
                else
                {
                    Networkhandler.Bet(GlobalVar.balance[user] / GlobalVar.safety, user);
                    GlobalVar.betting[user] = GlobalVar.balance[user] / GlobalVar.safety;
                    GlobalVar.firstnegative[user] = true;
                }
                //if last bid was the first negative, dont rise to het the possible failovers higher
            }
            else if (GlobalVar.firstnegative[user] == true && GlobalVar.increasebetsecond == true)
            {
                Networkhandler.Bet(GlobalVar.betting[user], user);
                GlobalVar.betting[user] = GlobalVar.betting[user];
                GlobalVar.firstnegative[user] = false;
            }
            else
            {//if more than half of the deposits were eaten, only Bet 1 for safety sake (only if safety treshold of 2048 is met)
                if ((GlobalVar.betting[user] * 2 > GlobalVar.balance[user] / 2) && GlobalVar.balance[user] > GlobalVar.safety)
                {
                    Networkhandler.Bet(1, user);
                    GlobalVar.betting[user] = 1;
                    GlobalVar.firstnegative[user] = false;
                    //double the bid
                }
                else
                {
                    Networkhandler.Bet(GlobalVar.betting[user] * 2, user);
                    GlobalVar.betting[user] = GlobalVar.betting[user] * 2;
                    GlobalVar.firstnegative[user] = false;
                }
            }
        }
    } 
}
