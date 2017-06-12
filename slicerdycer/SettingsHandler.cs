using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace slicerdycer
{
    public class SettingsHandler
    {
        public static string GetSettingFromAray(String setting, string[] array)
        {
            //find "setting" with value
            string temp = Array.Find(array, s => s.Contains(setting));

            // if a setting was found, Get the value
            if (temp != null)
            {
                return (temp.Substring(setting.Length));
            }
            else
            {
            }

            //return temp (may be null if setting was not found)
            return (temp);

        }
        public static string GetSettingValue(String setting, String path = GlobalVar.configPath)
        {
            //read in current settings
            string[] settings = FileHandler.ReadFile(path);

            //find "setting" with value
            string temp = Array.Find(settings, s => s.Contains(setting));

            // if a setting was found, Get the value
            if (temp != null)
            {
                return (temp.Substring(setting.Length+1));
            }
            else
            {
            }

            //return temp (may be null if setting was not found)
            return (temp);
        }

        public static int GetSettingIndex(String setting, String path = GlobalVar.configPath)
        {
            //read in current settings
            string[] settings = FileHandler.ReadFile(path);

            //Get index of setting
            int index = Array.FindIndex(settings, s => s.Contains(setting));

            return (index);
        }
        
        public static void SetSetting(String setting, String value, string path = GlobalVar.configPath)
        {
            //read in current settings
            string[] settings = FileHandler.ReadFile(path);

            //Get index of setting
            int index = Array.FindIndex(settings, s => s.Contains(setting));
            
            //replace setting in current settings
            settings[index] = setting+" "+value;

            FileHandler.WriteFile(settings, path);
        }
        public static void CheckSettings()
        {
            string[] config = null;
            //bool settingsUpdated = false;
            List<string> newConfig;
            //set standardsettings here
            string[] standardSettings =
            {
                "# general settings",
                "autoupdate true",
                "rememberme true",
                "difficulty 50",
                "safetylevel 2048",
                "useexploits false",
                "# Multibotting",
                "enabletipping true",
                "accounttotipto forreason",
                "percenttotip 1",
                "#withdraw settings",
                "enablewithdraw false",
                "withdrawadress 1234567890",
                "withdrawtreshold 40000000",
                "withdrawpercent 1",
                "enabledonating true",
                "donatepercent 1",
                "# tactical settings",
                "increasebetsecond false",
                "usesafetyvalue true",
                "disablesafetyfirstaccount true",
                "# Users",
                "username1 username",
                "apikey1 api_key",
                "username2 username",
                "apikey2 api_key",
                "username3 username",
                "apikey3 api_key",
                "username4 username",
                "apikey4 api_key",
                "username5 username",
                "apikey5 api_key",
                "username6 username",
                "apikey6 api_key",
            };
            //used to determine later if updates to config were made -> exit
            Boolean exit = false;

            //creates config file if it doesnt exit
            if (!File.Exists(GlobalVar.configPath))
            {
                var myFile = File.Create(GlobalVar.configPath);
                myFile.Close();
                exit = true;
                
            }
            try
            {
                //read in config file
                config = File.ReadAllLines(GlobalVar.configPath);
            }
            catch (Exception)
            {

                throw;
            }
            //create a newconfig list (list can add new items more simple)
            newConfig = config.ToList();
            //if a setting is not existing/new, set standard Value
            foreach (string i in standardSettings)
            {
                string[] settingToGet = i.Split(' ');
                Boolean settingExists = Array.Find(config, s => s.Contains(settingToGet[0])) != null;
                if (settingExists == false)
                {
                    newConfig.Add(i);
                    exit = true;
                    //settingsUpdated = true;
                }
            }
            //make newconfig to currentconfig
            config = newConfig.ToArray();
            //write currentconfig
            File.WriteAllLines(GlobalVar.configPath, config);

            if (exit == true)
            {
                //ErrorEventHandler.ErrorMessage("Press a key to exit and open the folder", "GPX");
            }
        }
        
    }
}
