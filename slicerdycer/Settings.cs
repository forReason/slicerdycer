﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slicerdycer
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            difficultynumeric.Value = decimal.Parse(SettingsHandler.GetSettingValue("difficulty"));
            safetynumeric.Value = decimal.Parse(SettingsHandler.GetSettingValue("safetylevel"));
            useexploits.Checked = bool.Parse(SettingsHandler.GetSettingValue("useexploits"));
            autoupdate.Checked = bool.Parse(SettingsHandler.GetSettingValue("autoupdate"));
            enabletipping.Checked = bool.Parse(SettingsHandler.GetSettingValue("enabletipping"));
            tiptoaccount.Text = SettingsHandler.GetSettingValue("accounttotipto");
            percenttotip.Value = decimal.Parse(SettingsHandler.GetSettingValue("percenttotip"));
            enablewithdrawcheckbox.Checked = bool.Parse(SettingsHandler.GetSettingValue("enablewithdraw"));
            withdrawbtcadress.Text = SettingsHandler.GetSettingValue("withdrawadress");
            withdrawtreshold.Value = decimal.Parse(SettingsHandler.GetSettingValue("withdrawtreshold"));
            withdrawpercent.Value = decimal.Parse(SettingsHandler.GetSettingValue("withdrawpercent"));
            enabledonating.Checked = bool.Parse(SettingsHandler.GetSettingValue("enabledonating"));
            donatepercent.Value = decimal.Parse(SettingsHandler.GetSettingValue("donatepercent"));
            increasebetsecond.Checked = bool.Parse(SettingsHandler.GetSettingValue("increasebetsecond"));
            usesafetyvalue.Checked = bool.Parse(SettingsHandler.GetSettingValue("usesafetyvalue"));
            disablesafetyfirst.Checked = bool.Parse(SettingsHandler.GetSettingValue("disablesafetyfirstaccount"));
            minimumbetnumeric.Value = decimal.Parse(SettingsHandler.GetSettingValue("minimumbet"));
            tippingtreshold.Value = decimal.Parse(SettingsHandler.GetSettingValue("tippingtreshold"));
            useprivatefaucetcheckbox.Checked = bool.Parse(SettingsHandler.GetSettingValue("privateFaucet"));
            dontfaucetfirstaccountcheckbox.Checked = bool.Parse(SettingsHandler.GetSettingValue("useFirstAccountAsFaucet"));
            faucettresholdnumeric.Value = decimal.Parse(SettingsHandler.GetSettingValue("faucetTreshold"));
            faucetamountnumeric.Value = decimal.Parse(SettingsHandler.GetSettingValue("faucetAmount"));
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DiscardButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SafeButton_Click(object sender, EventArgs e)
        {
            SettingsHandler.SetSetting("difficulty", difficultynumeric.Value.ToString());
            SettingsHandler.SetSetting("safetylevel", safetynumeric.Value.ToString());
            SettingsHandler.SetSetting("useexploits", useexploits.Checked.ToString());
            SettingsHandler.SetSetting("autoupdate", autoupdate.Checked.ToString());
            SettingsHandler.SetSetting("enabletipping", enabletipping.Checked.ToString());
            SettingsHandler.SetSetting("accounttotipto", tiptoaccount.Text);
            SettingsHandler.SetSetting("percenttotip", percenttotip.Value.ToString());
            SettingsHandler.SetSetting("enablewithdraw", enablewithdrawcheckbox.Checked.ToString());
            SettingsHandler.SetSetting("withdrawadress", withdrawbtcadress.Text);
            SettingsHandler.SetSetting("withdrawtreshold", withdrawtreshold.Value.ToString());
            SettingsHandler.SetSetting("withdrawpercent", withdrawpercent.Value.ToString());
            SettingsHandler.SetSetting("enabledonating", enabledonating.Checked.ToString());
            SettingsHandler.SetSetting("donatepercent", donatepercent.Value.ToString());
            SettingsHandler.SetSetting("increasebetsecond", increasebetsecond.Checked.ToString());
            SettingsHandler.SetSetting("usesafetyvalue", usesafetyvalue.Checked.ToString());
            SettingsHandler.SetSetting("disablesafetyfirstaccount", disablesafetyfirst.Checked.ToString());
            SettingsHandler.SetSetting("minimumbet", minimumbetnumeric.Value.ToString());
            SettingsHandler.SetSetting("tippingtreshold", tippingtreshold.Value.ToString());
            SettingsHandler.SetSetting("useFirstAccountAsFaucet", dontfaucetfirstaccountcheckbox.Checked.ToString());
            SettingsHandler.SetSetting("privateFaucet", useprivatefaucetcheckbox.Checked.ToString());
            SettingsHandler.SetSetting("faucetTreshold", faucettresholdnumeric.Value.ToString());
            SettingsHandler.SetSetting("faucetAmount", faucetamountnumeric.Value.ToString());
            Program.Updatesettings();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tiptoaccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
