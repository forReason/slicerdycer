using System;
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
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void discardbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void safebutton_Click(object sender, EventArgs e)
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
            this.Close();
        }
    }
}
