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
            username.Text = SettingsHandler.GetSettingValue("username");
            apikey.Text = SettingsHandler.GetSettingValue("apikey");
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
                SettingsHandler.SetSetting("username", username.Text);
                SettingsHandler.SetSetting("apikey", apikey.Text);
                SettingsHandler.SetSetting("rememberme", "true");
            } else {
                SettingsHandler.SetSetting("username", "username");
                SettingsHandler.SetSetting("apikey", "api_key");
                SettingsHandler.SetSetting("rememberme", "false");
            }
            //set global variables username and api key from userinput
            GlobalVar.api = apikey.Text;
            GlobalVar.user = username.Text;
            //do the "login" and push initial values into global variables
            string[] Settings = Regex.Replace(Networkhandler.get("users/1"), "\"", string.Empty).Split(',');
            GlobalVar.balance = (int) float.Parse(SettingsHandler.GetSettingFromAray("balance:", Settings));
            //Debug.WriteLine(GlobalVar.balance);
            //start main botting window
            this.Close();
        }
    }
}
