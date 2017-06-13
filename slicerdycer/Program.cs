using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public static double safety = 2048;
        public static bool useexploits = false;
        public static bool enabletipping = true;
        public static string tippingaccount = "forReason";
        public static double percenttotip = 1;
        public static bool enablewithdraw = false;
        public static string withdrawaddress = "123456789";
        public static int withdrawtreshold = 40000000;
        public static int withdrawpercent = 1;
        public static bool enabledonating = true;
        public static int donatepercent = 1;
        public static bool increasebetsecond = false;
        public static bool usesafetyvalue = true;
        public static bool disablesafetyfirstaccount = true;
        public static int minimumbet = 1;
        public static int tippingtreshold = 10000;
        public static bool privateFaucet = true;
        public static bool firstAccountFaucet = false;
        public static int maxtip = 10000;
        public static int mintip = 1000;
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
            GlobalVar.minimumbet = (int)decimal.Parse(SettingsHandler.GetSettingValue("minimumbet"));
            GlobalVar.tippingtreshold = (int)decimal.Parse(SettingsHandler.GetSettingValue("tippingtreshold"));
            GlobalVar.privateFaucet = bool.Parse(SettingsHandler.GetSettingValue("privateFaucet"));
            GlobalVar.firstAccountFaucet = bool.Parse(SettingsHandler.GetSettingValue("useFirstAccountAsFaucet"));
        }

        public static void ProgramLogic(int user)
        {
            //eglible tipping user
            int eglibleUser = 10;

            //check if last transaction was positive or negative and set balance
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

            //tipping logic
            if (GlobalVar.balance[user] > GlobalVar.tippingtreshold )
            {
                //calculate tip amount
                int tipamount = (int)(GlobalVar.balance[user] * (GlobalVar.percenttotip / 100.00));
                if (tipamount > GlobalVar.maxtip)
                {
                    tipamount = GlobalVar.maxtip;
                }
                //if private faucet is enabled and tipamount is not below tippingminimum of 1000 satoshi and self is eglible for private faucet
                if (GlobalVar.privateFaucet == true && tipamount >= GlobalVar.mintip && (GlobalVar.firstAccountFaucet == true || user != 1))
                {
                    //check if a user is eglibe for faucet
                    for (int i = 0; i < 6; i++)
                    {
                        if (GlobalVar.api[i] != "api_key" && GlobalVar.balance[i] < GlobalVar.safety)
                        {
                            eglibleUser = i;
                            i = 10;
                        }
                    }
                }
                //if privatefaucet is enabled and an eglible account is found and self is eglible (checked before)
                if (eglibleUser != 10)
                {
                    Networkhandler.TipAnUser(tipamount, user, GlobalVar.user[eglibleUser]);
                }
                //if tipping user not self place a tip on tipping user
                else if (GlobalVar.tippingaccount != GlobalVar.user[user] && tipamount >= GlobalVar.mintip)
                {
                    Networkhandler.TipAnUser(tipamount, user, GlobalVar.tippingaccount);
                }

            }

            //make a bet
            //(0.04*x^0.5)+1 <- calculation of bet
            //if positive transaction 
            if (GlobalVar.positivetransaction[user] == true)
            {
                //When balence/safety(2048) smaller than 1 satoshi, then Bet an satoshi 
                if ((GlobalVar.balance[user] / GlobalVar.safety) < GlobalVar.minimumbet && GlobalVar.usesafetyvalue == true || GlobalVar.disablesafetyfirstaccount == true && user == 0)
                {
                    if (GlobalVar.balance[user] > GlobalVar.minimumbet)
                    {
                        GlobalVar.betting[user] = GlobalVar.minimumbet;
                    }
                    else
                    {
                        GlobalVar.betting[user] = 1;
                    }
                    Networkhandler.Bet(GlobalVar.betting[user], user);
                    GlobalVar.firstnegative[user] = true;
                }
                //otherwhise keep distance so that at least 12 times in a row can be a loss (happens 1 out of 4k rolls stochastically)
                else
                {
                    Networkhandler.Bet((int)(0.06 * Math.Pow(GlobalVar.balance[user], 0.5)+1), user);
                    GlobalVar.betting[user] = (int)(0.06 * Math.Pow(GlobalVar.balance[user], 0.5) + 1);
                    GlobalVar.firstnegative[user] = true;
                }
                //if last bid was the first negative, dont rise to het the possible failovers higher
            }
            else if (GlobalVar.firstnegative[user] == true && GlobalVar.increasebetsecond == true)
            {
                Networkhandler.Bet(GlobalVar.betting[user], user);
                GlobalVar.firstnegative[user] = false;
            }
            else
            {//if more than half of the deposits were eaten, only Bet 1 for safety sake (only if safety treshold of 2048 is met)
                if ((GlobalVar.betting[user] * 2 > GlobalVar.balance[user] / 2) && GlobalVar.usesafetyvalue == true && GlobalVar.balance[user] > GlobalVar.safety)
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
