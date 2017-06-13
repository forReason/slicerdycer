using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slicerdycer
{
    // A delegate type for hooking up change notifications.
    public delegate void ChangedEventHandler(object sender, EventArgs e);

    public partial class Botting_Window : Form
    {
        public Botting_Window()
        {
            InitializeComponent();
            Updatevisual();
            groupBox1.Text = GlobalVar.user[0];
            groupBox2.Text = GlobalVar.user[1];
            groupBox3.Text = GlobalVar.user[2];
            groupBox4.Text = GlobalVar.user[3];
            groupBox5.Text = GlobalVar.user[4];
            groupBox6.Text = GlobalVar.user[5];
        }

        private void Updatevisual()
        {
            balance1.Text = GlobalVar.balance[0].ToString();
            betting1.Text = GlobalVar.betting[0].ToString();
            groupBox1.Text = GlobalVar.user[0];

            balance2.Text = GlobalVar.balance[1].ToString();
            betting2.Text = GlobalVar.betting[1].ToString();
            groupBox2.Text = GlobalVar.user[1];

            balance3.Text = GlobalVar.balance[2].ToString();
            betting3.Text = GlobalVar.betting[2].ToString();
            groupBox3.Text = GlobalVar.user[2];

            balance4.Text = GlobalVar.balance[3].ToString();
            betting4.Text = GlobalVar.betting[3].ToString();
            groupBox4.Text = GlobalVar.user[3];

            balance5.Text = GlobalVar.balance[4].ToString();
            betting5.Text = GlobalVar.betting[4].ToString();
            groupBox5.Text = GlobalVar.user[4];

            balance6.Text = GlobalVar.balance[5].ToString();
            betting6.Text = GlobalVar.betting[5].ToString();
            groupBox6.Text = GlobalVar.user[5];

        }
        private void Pausestart_Click(object sender, EventArgs e)
        {
            if (GlobalVar.pause == true)
            {
                GlobalVar.pause = false;
                pausestart.Text = "pause";
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                GlobalVar.pause = true;
                pausestart.Text = "start";
            }
        }

        private delegate void InvokeDelegate();
        private void BackgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            while (GlobalVar.pause == false)
            {   
                for (int i = 0; i<6; i++)
                {
                    if (GlobalVar.api[i] != "api_key")
                    {
                        //if balence = 0 -> update balance
                        if (GlobalVar.balance[i] == 0)
                        {
                            string[] Settings = Regex.Replace(Networkhandler.Get("users/1", i), "\"", string.Empty).Split(',');
                            GlobalVar.balance[i] = (int)float.Parse(SettingsHandler.GetSettingFromAray("balance:", Settings));
                        }
                        if (GlobalVar.balance[i] > 0)
                        {
                            Program.ProgramLogic(i);
                            //Updatevisual();
                            this.BeginInvoke(new InvokeDelegate(Updatevisual));
                            Thread.Sleep(1000);
                        }
                    }
                }
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void Accountbutton_Click(object sender, EventArgs e)
        {
            loginwindow login = new loginwindow();
            login.ShowDialog();
            //Application.Run(new loginwindow());
        }
    }
}
