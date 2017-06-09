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
            balance.Text = GlobalVar.balance.ToString();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void updatevisual()
        {
            balance.Text = GlobalVar.balance.ToString();
            betting.Text = GlobalVar.betting.ToString();
            richTextBox1.Text = Networkhandler.getbets();


        }
        private void pausestart_Click(object sender, EventArgs e)
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private delegate void InvokeDelegate();
        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            while (GlobalVar.pause == false)
            {
                //check if last transaction was positive or negative
                string[] Settings = Regex.Replace(Networkhandler.get("users/1"), "\"", string.Empty).Split(',');
                int tempbalance = (int)float.Parse(SettingsHandler.GetSettingFromAray("balance:", Settings));
                if (tempbalance < GlobalVar.balance)
                {
                    GlobalVar.positivetransaction = false;
                }
                else
                {
                    GlobalVar.positivetransaction = true;
                }
                //set new balance
                GlobalVar.balance = tempbalance;
                Thread.Sleep(1000);
                //if positive transaction 
                if (GlobalVar.positivetransaction == true)
                {
                    //When balence/safety(2048) smaller than 1 satoshi, then bet an satoshi 
                    if (GlobalVar.balance / GlobalVar.safety < 1)
                    {
                        Networkhandler.bet(1);
                        GlobalVar.betting = 1;
                        GlobalVar.firstnegative = true;
                    }
                    //otherwhise keep distance so that at least 12 times in a row can be a loss (happens 1 out of 4k rolls stochastically)
                    else
                    {
                        Networkhandler.bet(GlobalVar.balance / GlobalVar.safety);
                        GlobalVar.betting = GlobalVar.balance / GlobalVar.safety;
                        GlobalVar.firstnegative = true;
                    }
                    //if last bid was the first negative, dont rise to het the possible failovers higher
                }
                else if (GlobalVar.firstnegative == true)
                {
                    Networkhandler.bet(GlobalVar.betting);
                    GlobalVar.firstnegative = false;
                }
                else
                {//if more than hgalf of the deposits were eaten, only bate 1 for safety sake (only if safety treshold of 2048 is met)
                    if ((GlobalVar.betting * 2 > GlobalVar.balance / 2) && GlobalVar.balance > GlobalVar.safety)
                    {
                        Networkhandler.bet(1);
                        GlobalVar.firstnegative = false;
                        //double the bid
                    }
                    else
                    {
                        Networkhandler.bet(GlobalVar.betting * 2);
                        GlobalVar.firstnegative = false;
                    }
                }

                Thread.Sleep(1000);
                //updatevisual();
                this.BeginInvoke(new InvokeDelegate(updatevisual));
            }
        }
    }
}
