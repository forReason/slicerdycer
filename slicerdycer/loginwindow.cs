using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace slicerdycer
{
    public partial class loginwindow : Form
    {
        public loginwindow()
        {
            //set loginwindow
            InitializeComponent();
            //get username etc (if safed)
            username1.Text = SettingsHandler.GetSettingValue("username1");
            apikey1.Text = SettingsHandler.GetSettingValue("apikey1");

            username2.Text = SettingsHandler.GetSettingValue("username2");
            apikey2.Text = SettingsHandler.GetSettingValue("apikey2");

            username3.Text = SettingsHandler.GetSettingValue("username3");
            apikey3.Text = SettingsHandler.GetSettingValue("apikey3");

            username4.Text = SettingsHandler.GetSettingValue("username4");
            apikey4.Text = SettingsHandler.GetSettingValue("apikey4");

            username5.Text = SettingsHandler.GetSettingValue("username5");
            apikey5.Text = SettingsHandler.GetSettingValue("apikey5");

            username6.Text = SettingsHandler.GetSettingValue("username6");
            apikey6.Text = SettingsHandler.GetSettingValue("apikey6");

            if (SettingsHandler.GetSettingValue("rememberme")=="true"){
                rememberbox.Checked = true;
            }
            if (this.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }
        private void login_Load(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            //write values to settings based on "remember me checkbox"
            if (rememberbox.Checked==true)
            {
                SettingsHandler.SetSetting("username1", username1.Text);
                SettingsHandler.SetSetting("apikey1", apikey1.Text);

                SettingsHandler.SetSetting("username2", username2.Text);
                SettingsHandler.SetSetting("apikey2", apikey2.Text);

                SettingsHandler.SetSetting("username3", username3.Text);
                SettingsHandler.SetSetting("apikey3", apikey3.Text);

                SettingsHandler.SetSetting("username4", username4.Text);
                SettingsHandler.SetSetting("apikey4", apikey4.Text);

                SettingsHandler.SetSetting("username5", username5.Text);
                SettingsHandler.SetSetting("apikey5", apikey5.Text);

                SettingsHandler.SetSetting("username6", username6.Text);
                SettingsHandler.SetSetting("apikey6", apikey6.Text);

                SettingsHandler.SetSetting("rememberme", "true");
            } else {
                for (int i = 1; i < 13; i++)
                {
                    SettingsHandler.SetSetting("username"+i, "username");
                    SettingsHandler.SetSetting("apikey"+i, "api_key");
                }
                SettingsHandler.SetSetting("rememberme", "false");
            }
            //set global variables username and api key from userinput
            GlobalVar.api[0] = apikey1.Text;
            GlobalVar.user[0] = username1.Text;

            GlobalVar.api[1] = apikey2.Text;
            GlobalVar.user[1] = username2.Text;

            GlobalVar.api[2] = apikey3.Text;
            GlobalVar.user[2] = username3.Text;

            GlobalVar.api[3] = apikey4.Text;
            GlobalVar.user[3] = username4.Text;

            GlobalVar.api[4] = apikey5.Text;
            GlobalVar.user[4] = username5.Text;

            GlobalVar.api[5] = apikey6.Text;
            GlobalVar.user[5] = username6.Text;

            //do the "login" and push initial values into global variables
            for(int i = 0; i<6; i++)
            {
                if (GlobalVar.api[i] != "api_key")
                {
                    string[] Settings = Regex.Replace(Networkhandler.get("users/1", i), "\"", string.Empty).Split(',');
                    GlobalVar.balance[i] = (int)float.Parse(SettingsHandler.GetSettingFromAray("balance:", Settings));
                    //Debug.WriteLine(GlobalVar.balance[i]);
                }
            }

            //Debug.WriteLine(GlobalVar.balance);
            //start main botting window
            this.Close();
        }
    }
}
