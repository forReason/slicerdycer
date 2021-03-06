﻿namespace slicerdycer
{
    partial class Settings
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
            this.discardbutton = new System.Windows.Forms.Button();
            this.safebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.difficultynumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.safetynumeric = new System.Windows.Forms.NumericUpDown();
            this.enabletipping = new System.Windows.Forms.CheckBox();
            this.multibotting = new System.Windows.Forms.GroupBox();
            this.tippingtreshold = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.percenttotip = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tiptoaccount = new System.Windows.Forms.TextBox();
            this.generalbox = new System.Windows.Forms.GroupBox();
            this.useexploits = new System.Windows.Forms.CheckBox();
            this.autoupdate = new System.Windows.Forms.CheckBox();
            this.withdrawbox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.donatepercent = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.enabledonating = new System.Windows.Forms.CheckBox();
            this.withdrawpercent = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.withdrawtreshold = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.withdrawbtcadress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.enablewithdrawcheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dontfaucetfirstaccountcheckbox = new System.Windows.Forms.CheckBox();
            this.useprivatefaucetcheckbox = new System.Windows.Forms.CheckBox();
            this.minimumbetnumeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.disablesafetyfirst = new System.Windows.Forms.CheckBox();
            this.usesafetyvalue = new System.Windows.Forms.CheckBox();
            this.increasebetsecond = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.faucettresholdnumeric = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.faucetamountnumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.difficultynumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safetynumeric)).BeginInit();
            this.multibotting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tippingtreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percenttotip)).BeginInit();
            this.generalbox.SuspendLayout();
            this.withdrawbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donatepercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawpercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawtreshold)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimumbetnumeric)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faucettresholdnumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faucetamountnumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // discardbutton
            // 
            this.discardbutton.Location = new System.Drawing.Point(644, 436);
            this.discardbutton.Name = "discardbutton";
            this.discardbutton.Size = new System.Drawing.Size(75, 23);
            this.discardbutton.TabIndex = 0;
            this.discardbutton.Text = "discard";
            this.discardbutton.UseVisualStyleBackColor = true;
            this.discardbutton.Click += new System.EventHandler(this.DiscardButton_Click);
            // 
            // safebutton
            // 
            this.safebutton.Location = new System.Drawing.Point(725, 436);
            this.safebutton.Name = "safebutton";
            this.safebutton.Size = new System.Drawing.Size(75, 23);
            this.safebutton.TabIndex = 1;
            this.safebutton.Text = "Safe";
            this.safebutton.UseVisualStyleBackColor = true;
            this.safebutton.Click += new System.EventHandler(this.SafeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "difficulty %";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // difficultynumeric
            // 
            this.difficultynumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.difficultynumeric.Location = new System.Drawing.Point(162, 19);
            this.difficultynumeric.Name = "difficultynumeric";
            this.difficultynumeric.Size = new System.Drawing.Size(88, 20);
            this.difficultynumeric.TabIndex = 3;
            this.difficultynumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "calc bet by factor x of balance";
            // 
            // safetynumeric
            // 
            this.safetynumeric.Location = new System.Drawing.Point(162, 45);
            this.safetynumeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.safetynumeric.Name = "safetynumeric";
            this.safetynumeric.Size = new System.Drawing.Size(89, 20);
            this.safetynumeric.TabIndex = 5;
            this.safetynumeric.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // enabletipping
            // 
            this.enabletipping.AutoSize = true;
            this.enabletipping.Location = new System.Drawing.Point(9, 19);
            this.enabletipping.Name = "enabletipping";
            this.enabletipping.Size = new System.Drawing.Size(92, 17);
            this.enabletipping.TabIndex = 6;
            this.enabletipping.Text = "enable tipping";
            this.enabletipping.UseVisualStyleBackColor = true;
            this.enabletipping.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // multibotting
            // 
            this.multibotting.Controls.Add(this.groupBox4);
            this.multibotting.Controls.Add(this.groupBox3);
            this.multibotting.Location = new System.Drawing.Point(6, 260);
            this.multibotting.Name = "multibotting";
            this.multibotting.Size = new System.Drawing.Size(512, 151);
            this.multibotting.TabIndex = 7;
            this.multibotting.TabStop = false;
            this.multibotting.Text = "Multibotting";
            // 
            // tippingtreshold
            // 
            this.tippingtreshold.Location = new System.Drawing.Point(118, 94);
            this.tippingtreshold.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.tippingtreshold.Name = "tippingtreshold";
            this.tippingtreshold.Size = new System.Drawing.Size(120, 20);
            this.tippingtreshold.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "treshold";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "percent to tip";
            // 
            // percenttotip
            // 
            this.percenttotip.Location = new System.Drawing.Point(187, 68);
            this.percenttotip.Name = "percenttotip";
            this.percenttotip.Size = new System.Drawing.Size(51, 20);
            this.percenttotip.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "user to tip to";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tiptoaccount
            // 
            this.tiptoaccount.Location = new System.Drawing.Point(83, 42);
            this.tiptoaccount.Name = "tiptoaccount";
            this.tiptoaccount.Size = new System.Drawing.Size(155, 20);
            this.tiptoaccount.TabIndex = 7;
            this.tiptoaccount.TextChanged += new System.EventHandler(this.tiptoaccount_TextChanged);
            // 
            // generalbox
            // 
            this.generalbox.Controls.Add(this.useexploits);
            this.generalbox.Controls.Add(this.autoupdate);
            this.generalbox.Controls.Add(this.label1);
            this.generalbox.Controls.Add(this.difficultynumeric);
            this.generalbox.Controls.Add(this.label2);
            this.generalbox.Controls.Add(this.safetynumeric);
            this.generalbox.Location = new System.Drawing.Point(12, 12);
            this.generalbox.Name = "generalbox";
            this.generalbox.Size = new System.Drawing.Size(257, 136);
            this.generalbox.TabIndex = 8;
            this.generalbox.TabStop = false;
            this.generalbox.Text = "General";
            // 
            // useexploits
            // 
            this.useexploits.AutoSize = true;
            this.useexploits.Location = new System.Drawing.Point(6, 90);
            this.useexploits.Name = "useexploits";
            this.useexploits.Size = new System.Drawing.Size(202, 17);
            this.useexploits.TabIndex = 7;
            this.useexploits.Text = "use exploits if available (dangerzone!)";
            this.useexploits.UseVisualStyleBackColor = true;
            // 
            // autoupdate
            // 
            this.autoupdate.AutoSize = true;
            this.autoupdate.Location = new System.Drawing.Point(6, 113);
            this.autoupdate.Name = "autoupdate";
            this.autoupdate.Size = new System.Drawing.Size(80, 17);
            this.autoupdate.TabIndex = 6;
            this.autoupdate.Text = "autoupdate";
            this.autoupdate.UseVisualStyleBackColor = true;
            // 
            // withdrawbox
            // 
            this.withdrawbox.Controls.Add(this.groupBox1);
            this.withdrawbox.Controls.Add(this.withdrawpercent);
            this.withdrawbox.Controls.Add(this.label7);
            this.withdrawbox.Controls.Add(this.withdrawtreshold);
            this.withdrawbox.Controls.Add(this.label6);
            this.withdrawbox.Controls.Add(this.withdrawbtcadress);
            this.withdrawbox.Controls.Add(this.label5);
            this.withdrawbox.Controls.Add(this.enablewithdrawcheckbox);
            this.withdrawbox.Location = new System.Drawing.Point(12, 260);
            this.withdrawbox.Name = "withdrawbox";
            this.withdrawbox.Size = new System.Drawing.Size(260, 170);
            this.withdrawbox.TabIndex = 9;
            this.withdrawbox.TabStop = false;
            this.withdrawbox.Text = "Withdraw";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.donatepercent);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.enabledonating);
            this.groupBox1.Location = new System.Drawing.Point(6, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 42);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Donating";
            // 
            // donatepercent
            // 
            this.donatepercent.Location = new System.Drawing.Point(197, 18);
            this.donatepercent.Name = "donatepercent";
            this.donatepercent.Size = new System.Drawing.Size(47, 20);
            this.donatepercent.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "% to donate";
            // 
            // enabledonating
            // 
            this.enabledonating.AutoSize = true;
            this.enabledonating.Location = new System.Drawing.Point(6, 20);
            this.enabledonating.Name = "enabledonating";
            this.enabledonating.Size = new System.Drawing.Size(102, 17);
            this.enabledonating.TabIndex = 0;
            this.enabledonating.Text = "enable donating";
            this.enabledonating.UseVisualStyleBackColor = true;
            // 
            // withdrawpercent
            // 
            this.withdrawpercent.Location = new System.Drawing.Point(203, 91);
            this.withdrawpercent.Name = "withdrawpercent";
            this.withdrawpercent.Size = new System.Drawing.Size(47, 20);
            this.withdrawpercent.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "percent to withdraw";
            // 
            // withdrawtreshold
            // 
            this.withdrawtreshold.Location = new System.Drawing.Point(130, 64);
            this.withdrawtreshold.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.withdrawtreshold.Name = "withdrawtreshold";
            this.withdrawtreshold.Size = new System.Drawing.Size(120, 20);
            this.withdrawtreshold.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "treshold";
            // 
            // withdrawbtcadress
            // 
            this.withdrawbtcadress.Location = new System.Drawing.Point(6, 37);
            this.withdrawbtcadress.Name = "withdrawbtcadress";
            this.withdrawbtcadress.Size = new System.Drawing.Size(248, 20);
            this.withdrawbtcadress.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "withdraw adress";
            // 
            // enablewithdrawcheckbox
            // 
            this.enablewithdrawcheckbox.AutoSize = true;
            this.enablewithdrawcheckbox.Location = new System.Drawing.Point(147, 18);
            this.enablewithdrawcheckbox.Name = "enablewithdrawcheckbox";
            this.enablewithdrawcheckbox.Size = new System.Drawing.Size(103, 17);
            this.enablewithdrawcheckbox.TabIndex = 0;
            this.enablewithdrawcheckbox.Text = "enable withdraw";
            this.enablewithdrawcheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.minimumbetnumeric);
            this.groupBox2.Controls.Add(this.multibotting);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.disablesafetyfirst);
            this.groupBox2.Controls.Add(this.usesafetyvalue);
            this.groupBox2.Controls.Add(this.increasebetsecond);
            this.groupBox2.Location = new System.Drawing.Point(276, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 417);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tactical decisions";
            // 
            // dontfaucetfirstaccountcheckbox
            // 
            this.dontfaucetfirstaccountcheckbox.AutoSize = true;
            this.dontfaucetfirstaccountcheckbox.Location = new System.Drawing.Point(133, 19);
            this.dontfaucetfirstaccountcheckbox.Name = "dontfaucetfirstaccountcheckbox";
            this.dontfaucetfirstaccountcheckbox.Size = new System.Drawing.Size(111, 17);
            this.dontfaucetfirstaccountcheckbox.TabIndex = 6;
            this.dontfaucetfirstaccountcheckbox.Text = "allow first account";
            this.dontfaucetfirstaccountcheckbox.UseVisualStyleBackColor = true;
            // 
            // useprivatefaucetcheckbox
            // 
            this.useprivatefaucetcheckbox.AutoSize = true;
            this.useprivatefaucetcheckbox.Location = new System.Drawing.Point(6, 19);
            this.useprivatefaucetcheckbox.Name = "useprivatefaucetcheckbox";
            this.useprivatefaucetcheckbox.Size = new System.Drawing.Size(111, 17);
            this.useprivatefaucetcheckbox.TabIndex = 5;
            this.useprivatefaucetcheckbox.Text = "use private faucet";
            this.useprivatefaucetcheckbox.UseVisualStyleBackColor = true;
            // 
            // minimumbetnumeric
            // 
            this.minimumbetnumeric.Location = new System.Drawing.Point(81, 86);
            this.minimumbetnumeric.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.minimumbetnumeric.Name = "minimumbetnumeric";
            this.minimumbetnumeric.Size = new System.Drawing.Size(120, 20);
            this.minimumbetnumeric.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Minimum Bet";
            // 
            // disablesafetyfirst
            // 
            this.disablesafetyfirst.AutoSize = true;
            this.disablesafetyfirst.Location = new System.Drawing.Point(6, 64);
            this.disablesafetyfirst.Name = "disablesafetyfirst";
            this.disablesafetyfirst.Size = new System.Drawing.Size(195, 17);
            this.disablesafetyfirst.TabIndex = 2;
            this.disablesafetyfirst.Text = "disable safety value for first account";
            this.disablesafetyfirst.UseVisualStyleBackColor = true;
            // 
            // usesafetyvalue
            // 
            this.usesafetyvalue.AutoSize = true;
            this.usesafetyvalue.Location = new System.Drawing.Point(6, 41);
            this.usesafetyvalue.Name = "usesafetyvalue";
            this.usesafetyvalue.Size = new System.Drawing.Size(103, 17);
            this.usesafetyvalue.TabIndex = 1;
            this.usesafetyvalue.Text = "use safety value";
            this.usesafetyvalue.UseVisualStyleBackColor = true;
            // 
            // increasebetsecond
            // 
            this.increasebetsecond.AutoSize = true;
            this.increasebetsecond.Location = new System.Drawing.Point(6, 21);
            this.increasebetsecond.Name = "increasebetsecond";
            this.increasebetsecond.Size = new System.Drawing.Size(191, 17);
            this.increasebetsecond.TabIndex = 0;
            this.increasebetsecond.Text = "Increase Bet after second loss only";
            this.increasebetsecond.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.faucetamountnumeric);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.faucettresholdnumeric);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dontfaucetfirstaccountcheckbox);
            this.groupBox3.Controls.Add(this.useprivatefaucetcheckbox);
            this.groupBox3.Location = new System.Drawing.Point(256, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 127);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Private Faucet";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.enabletipping);
            this.groupBox4.Controls.Add(this.tippingtreshold);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.tiptoaccount);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.percenttotip);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 127);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipping";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "treshold";
            // 
            // faucettresholdnumeric
            // 
            this.faucettresholdnumeric.Location = new System.Drawing.Point(124, 43);
            this.faucettresholdnumeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.faucettresholdnumeric.Name = "faucettresholdnumeric";
            this.faucettresholdnumeric.Size = new System.Drawing.Size(120, 20);
            this.faucettresholdnumeric.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "faucet amount";
            // 
            // faucetamountnumeric
            // 
            this.faucetamountnumeric.Location = new System.Drawing.Point(124, 69);
            this.faucetamountnumeric.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.faucetamountnumeric.Name = "faucetamountnumeric";
            this.faucetamountnumeric.Size = new System.Drawing.Size(120, 20);
            this.faucetamountnumeric.TabIndex = 13;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 471);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.withdrawbox);
            this.Controls.Add(this.generalbox);
            this.Controls.Add(this.safebutton);
            this.Controls.Add(this.discardbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.difficultynumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safetynumeric)).EndInit();
            this.multibotting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tippingtreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percenttotip)).EndInit();
            this.generalbox.ResumeLayout(false);
            this.generalbox.PerformLayout();
            this.withdrawbox.ResumeLayout(false);
            this.withdrawbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donatepercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawpercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawtreshold)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimumbetnumeric)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faucettresholdnumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faucetamountnumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button discardbutton;
        private System.Windows.Forms.Button safebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown difficultynumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown safetynumeric;
        private System.Windows.Forms.CheckBox enabletipping;
        private System.Windows.Forms.GroupBox multibotting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown percenttotip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tiptoaccount;
        private System.Windows.Forms.GroupBox generalbox;
        private System.Windows.Forms.CheckBox useexploits;
        private System.Windows.Forms.CheckBox autoupdate;
        private System.Windows.Forms.GroupBox withdrawbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown donatepercent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox enabledonating;
        private System.Windows.Forms.NumericUpDown withdrawpercent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown withdrawtreshold;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox withdrawbtcadress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox enablewithdrawcheckbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox usesafetyvalue;
        private System.Windows.Forms.CheckBox increasebetsecond;
        private System.Windows.Forms.CheckBox disablesafetyfirst;
        private System.Windows.Forms.NumericUpDown minimumbetnumeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown tippingtreshold;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox dontfaucetfirstaccountcheckbox;
        private System.Windows.Forms.CheckBox useprivatefaucetcheckbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown faucetamountnumeric;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown faucettresholdnumeric;
        private System.Windows.Forms.Label label11;
    }
}