namespace slicerdycer
{
    partial class Botting_Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pausestart = new System.Windows.Forms.Button();
            this.balancelabel = new System.Windows.Forms.Label();
            this.balance1 = new System.Windows.Forms.Label();
            this.bet = new System.Windows.Forms.Label();
            this.betting1 = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.betting4 = new System.Windows.Forms.Label();
            this.balance4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.betting2 = new System.Windows.Forms.Label();
            this.balance2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.betting5 = new System.Windows.Forms.Label();
            this.balance5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.betting3 = new System.Windows.Forms.Label();
            this.balance3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.betting6 = new System.Windows.Forms.Label();
            this.balance6 = new System.Windows.Forms.Label();
            this.accountbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pausestart
            // 
            this.pausestart.Location = new System.Drawing.Point(12, 118);
            this.pausestart.Name = "pausestart";
            this.pausestart.Size = new System.Drawing.Size(702, 57);
            this.pausestart.TabIndex = 0;
            this.pausestart.Text = "Start";
            this.pausestart.UseVisualStyleBackColor = true;
            this.pausestart.Click += new System.EventHandler(this.Pausestart_Click);
            // 
            // balancelabel
            // 
            this.balancelabel.AutoSize = true;
            this.balancelabel.Location = new System.Drawing.Point(6, 16);
            this.balancelabel.Name = "balancelabel";
            this.balancelabel.Size = new System.Drawing.Size(46, 13);
            this.balancelabel.TabIndex = 1;
            this.balancelabel.Text = "Balance";
            // 
            // balance1
            // 
            this.balance1.AutoSize = true;
            this.balance1.Location = new System.Drawing.Point(70, 16);
            this.balance1.Name = "balance1";
            this.balance1.Size = new System.Drawing.Size(13, 13);
            this.balance1.TabIndex = 2;
            this.balance1.Text = "0";
            // 
            // Bet
            // 
            this.bet.AutoSize = true;
            this.bet.Location = new System.Drawing.Point(6, 29);
            this.bet.Name = "Bet";
            this.bet.Size = new System.Drawing.Size(58, 13);
            this.bet.TabIndex = 3;
            this.bet.Text = "current Bet";
            // 
            // betting1
            // 
            this.betting1.AutoSize = true;
            this.betting1.Location = new System.Drawing.Point(70, 31);
            this.betting1.Name = "betting1";
            this.betting1.Size = new System.Drawing.Size(13, 13);
            this.betting1.TabIndex = 4;
            this.betting1.Text = "0";
            this.betting1.Click += new System.EventHandler(this.Betting_Click);
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(639, 12);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(75, 23);
            this.Settings.TabIndex = 5;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.balancelabel);
            this.groupBox1.Controls.Add(this.bet);
            this.groupBox1.Controls.Add(this.betting1);
            this.groupBox1.Controls.Add(this.balance1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 47);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account 1";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.betting4);
            this.groupBox4.Controls.Add(this.balance4);
            this.groupBox4.Location = new System.Drawing.Point(12, 65);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 47);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Account 4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "current Bet";
            // 
            // betting4
            // 
            this.betting4.AutoSize = true;
            this.betting4.Location = new System.Drawing.Point(70, 31);
            this.betting4.Name = "betting4";
            this.betting4.Size = new System.Drawing.Size(13, 13);
            this.betting4.TabIndex = 4;
            this.betting4.Text = "0";
            // 
            // balance4
            // 
            this.balance4.AutoSize = true;
            this.balance4.Location = new System.Drawing.Point(70, 16);
            this.balance4.Name = "balance4";
            this.balance4.Size = new System.Drawing.Size(13, 13);
            this.balance4.TabIndex = 2;
            this.balance4.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.betting2);
            this.groupBox2.Controls.Add(this.balance2);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 47);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account 2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Balance";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "current Bet";
            // 
            // betting2
            // 
            this.betting2.AutoSize = true;
            this.betting2.Location = new System.Drawing.Point(70, 31);
            this.betting2.Name = "betting2";
            this.betting2.Size = new System.Drawing.Size(13, 13);
            this.betting2.TabIndex = 4;
            this.betting2.Text = "0";
            // 
            // balance2
            // 
            this.balance2.AutoSize = true;
            this.balance2.Location = new System.Drawing.Point(70, 16);
            this.balance2.Name = "balance2";
            this.balance2.Size = new System.Drawing.Size(13, 13);
            this.balance2.TabIndex = 2;
            this.balance2.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.betting5);
            this.groupBox5.Controls.Add(this.balance5);
            this.groupBox5.Location = new System.Drawing.Point(218, 65);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 47);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Account 5";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Balance";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "current Bet";
            // 
            // betting5
            // 
            this.betting5.AutoSize = true;
            this.betting5.Location = new System.Drawing.Point(70, 31);
            this.betting5.Name = "betting5";
            this.betting5.Size = new System.Drawing.Size(13, 13);
            this.betting5.TabIndex = 4;
            this.betting5.Text = "0";
            // 
            // balance5
            // 
            this.balance5.AutoSize = true;
            this.balance5.Location = new System.Drawing.Point(70, 16);
            this.balance5.Name = "balance5";
            this.balance5.Size = new System.Drawing.Size(13, 13);
            this.balance5.TabIndex = 2;
            this.balance5.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.betting3);
            this.groupBox3.Controls.Add(this.balance3);
            this.groupBox3.Location = new System.Drawing.Point(424, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 47);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account 3";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 16);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(46, 13);
            this.label29.TabIndex = 1;
            this.label29.Text = "Balance";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 29);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(58, 13);
            this.label30.TabIndex = 3;
            this.label30.Text = "current Bet";
            // 
            // betting3
            // 
            this.betting3.AutoSize = true;
            this.betting3.Location = new System.Drawing.Point(70, 31);
            this.betting3.Name = "betting3";
            this.betting3.Size = new System.Drawing.Size(13, 13);
            this.betting3.TabIndex = 4;
            this.betting3.Text = "0";
            // 
            // balance3
            // 
            this.balance3.AutoSize = true;
            this.balance3.Location = new System.Drawing.Point(70, 16);
            this.balance3.Name = "balance3";
            this.balance3.Size = new System.Drawing.Size(13, 13);
            this.balance3.TabIndex = 2;
            this.balance3.Text = "0";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.label34);
            this.groupBox6.Controls.Add(this.betting6);
            this.groupBox6.Controls.Add(this.balance6);
            this.groupBox6.Location = new System.Drawing.Point(424, 65);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 47);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Account 6";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 16);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(46, 13);
            this.label33.TabIndex = 1;
            this.label33.Text = "Balance";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 29);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(58, 13);
            this.label34.TabIndex = 3;
            this.label34.Text = "current Bet";
            // 
            // betting6
            // 
            this.betting6.AutoSize = true;
            this.betting6.Location = new System.Drawing.Point(70, 31);
            this.betting6.Name = "betting6";
            this.betting6.Size = new System.Drawing.Size(13, 13);
            this.betting6.TabIndex = 4;
            this.betting6.Text = "0";
            // 
            // balance6
            // 
            this.balance6.AutoSize = true;
            this.balance6.Location = new System.Drawing.Point(70, 16);
            this.balance6.Name = "balance6";
            this.balance6.Size = new System.Drawing.Size(13, 13);
            this.balance6.TabIndex = 2;
            this.balance6.Text = "0";
            // 
            // accountbutton
            // 
            this.accountbutton.Location = new System.Drawing.Point(639, 43);
            this.accountbutton.Name = "accountbutton";
            this.accountbutton.Size = new System.Drawing.Size(75, 23);
            this.accountbutton.TabIndex = 9;
            this.accountbutton.Text = "accounts";
            this.accountbutton.UseVisualStyleBackColor = true;
            this.accountbutton.Click += new System.EventHandler(this.Accountbutton_Click);
            // 
            // Botting_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 183);
            this.Controls.Add(this.accountbutton);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.pausestart);
            this.Name = "Botting_Window";
            this.Text = "Botting_Window";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pausestart;
        private System.Windows.Forms.Label balancelabel;
        private System.Windows.Forms.Label balance1;
        private System.Windows.Forms.Label bet;
        private System.Windows.Forms.Label betting1;
        private System.Windows.Forms.Button Settings;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label betting4;
        private System.Windows.Forms.Label balance4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label betting2;
        private System.Windows.Forms.Label balance2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label betting5;
        private System.Windows.Forms.Label balance5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label betting3;
        private System.Windows.Forms.Label balance3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label betting6;
        private System.Windows.Forms.Label balance6;
        private System.Windows.Forms.Button accountbutton;
    }
}