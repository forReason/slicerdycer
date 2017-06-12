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
            updatevisual();
            groupBox1.Text = GlobalVar.user[0];
            groupBox2.Text = GlobalVar.user[1];
            groupBox3.Text = GlobalVar.user[2];
            groupBox4.Text = GlobalVar.user[3];
            groupBox5.Text = GlobalVar.user[4];
            groupBox6.Text = GlobalVar.user[5];
        }

        private void updatevisual()
        {
            balance1.Text = GlobalVar.balance[0].ToString();
            betting1.Text = GlobalVar.betting[0].ToString();

            balance2.Text = GlobalVar.balance[1].ToString();
            betting2.Text = GlobalVar.betting[1].ToString();

            balance3.Text = GlobalVar.balance[2].ToString();
            betting3.Text = GlobalVar.betting[2].ToString();

            balance4.Text = GlobalVar.balance[3].ToString();
            betting4.Text = GlobalVar.betting[3].ToString();

            balance5.Text = GlobalVar.balance[4].ToString();
            betting5.Text = GlobalVar.betting[4].ToString();

            balance6.Text = GlobalVar.balance[5].ToString();
            betting6.Text = GlobalVar.betting[5].ToString();

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
                for (int i = 0; i<6; i++)
                {
                    if (GlobalVar.api[i] != "api_key")
                    {
                        Program.ProgramLogic(i);
                        //updatevisual();
                        this.BeginInvoke(new InvokeDelegate(updatevisual));
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Application.Run(new Settings());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void betting_Click(object sender, EventArgs e)
        {

        }

        private void accountbutton_Click(object sender, EventArgs e)
        {
            //Application.Run(new loginwindow());
        }
    }
}
