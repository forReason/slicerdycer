namespace slicerdycer
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
            this.tiptoaccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.percenttotip = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.generalbox = new System.Windows.Forms.GroupBox();
            this.withdrawbox = new System.Windows.Forms.GroupBox();
            this.enablewithdrawcheckbox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.withdrawbtcadress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.withdrawtreshold = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.withdrawpercent = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enabledonating = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.donatepercent = new System.Windows.Forms.NumericUpDown();
            this.autoupdate = new System.Windows.Forms.CheckBox();
            this.useexploits = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.difficultynumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safetynumeric)).BeginInit();
            this.multibotting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percenttotip)).BeginInit();
            this.generalbox.SuspendLayout();
            this.withdrawbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawtreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawpercent)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donatepercent)).BeginInit();
            this.SuspendLayout();
            // 
            // discardbutton
            // 
            this.discardbutton.Location = new System.Drawing.Point(7, 436);
            this.discardbutton.Name = "discardbutton";
            this.discardbutton.Size = new System.Drawing.Size(75, 23);
            this.discardbutton.TabIndex = 0;
            this.discardbutton.Text = "discard";
            this.discardbutton.UseVisualStyleBackColor = true;
            this.discardbutton.Click += new System.EventHandler(this.discardbutton_Click);
            // 
            // safebutton
            // 
            this.safebutton.Location = new System.Drawing.Point(197, 436);
            this.safebutton.Name = "safebutton";
            this.safebutton.Size = new System.Drawing.Size(75, 23);
            this.safebutton.TabIndex = 1;
            this.safebutton.Text = "Safe";
            this.safebutton.UseVisualStyleBackColor = true;
            this.safebutton.Click += new System.EventHandler(this.safebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "difficulty %";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "safety value";
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
            this.enabletipping.Location = new System.Drawing.Point(162, 21);
            this.enabletipping.Name = "enabletipping";
            this.enabletipping.Size = new System.Drawing.Size(92, 17);
            this.enabletipping.TabIndex = 6;
            this.enabletipping.Text = "enable tipping";
            this.enabletipping.UseVisualStyleBackColor = true;
            this.enabletipping.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // multibotting
            // 
            this.multibotting.Controls.Add(this.label4);
            this.multibotting.Controls.Add(this.percenttotip);
            this.multibotting.Controls.Add(this.label3);
            this.multibotting.Controls.Add(this.tiptoaccount);
            this.multibotting.Controls.Add(this.enabletipping);
            this.multibotting.Location = new System.Drawing.Point(12, 154);
            this.multibotting.Name = "multibotting";
            this.multibotting.Size = new System.Drawing.Size(260, 100);
            this.multibotting.TabIndex = 7;
            this.multibotting.TabStop = false;
            this.multibotting.Text = "Multibotting";
            // 
            // tiptoaccount
            // 
            this.tiptoaccount.Location = new System.Drawing.Point(6, 40);
            this.tiptoaccount.Name = "tiptoaccount";
            this.tiptoaccount.Size = new System.Drawing.Size(248, 20);
            this.tiptoaccount.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "account to tip to";
            // 
            // percenttotip
            // 
            this.percenttotip.Location = new System.Drawing.Point(203, 66);
            this.percenttotip.Name = "percenttotip";
            this.percenttotip.Size = new System.Drawing.Size(51, 20);
            this.percenttotip.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "percent to tip";
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
            // enablewithdrawcheckbox
            // 
            this.enablewithdrawcheckbox.AutoSize = true;
            this.enablewithdrawcheckbox.Location = new System.Drawing.Point(135, 20);
            this.enablewithdrawcheckbox.Name = "enablewithdrawcheckbox";
            this.enablewithdrawcheckbox.Size = new System.Drawing.Size(103, 17);
            this.enablewithdrawcheckbox.TabIndex = 0;
            this.enablewithdrawcheckbox.Text = "enable withdraw";
            this.enablewithdrawcheckbox.UseVisualStyleBackColor = true;
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
            // withdrawbtcadress
            // 
            this.withdrawbtcadress.Location = new System.Drawing.Point(6, 37);
            this.withdrawbtcadress.Name = "withdrawbtcadress";
            this.withdrawbtcadress.Size = new System.Drawing.Size(248, 20);
            this.withdrawbtcadress.TabIndex = 2;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "percent to withdraw";
            // 
            // withdrawpercent
            // 
            this.withdrawpercent.Location = new System.Drawing.Point(203, 91);
            this.withdrawpercent.Name = "withdrawpercent";
            this.withdrawpercent.Size = new System.Drawing.Size(47, 20);
            this.withdrawpercent.TabIndex = 6;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "% to donate";
            // 
            // donatepercent
            // 
            this.donatepercent.Location = new System.Drawing.Point(197, 18);
            this.donatepercent.Name = "donatepercent";
            this.donatepercent.Size = new System.Drawing.Size(47, 20);
            this.donatepercent.TabIndex = 2;
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
            // useexploits
            // 
            this.useexploits.AutoSize = true;
            this.useexploits.Location = new System.Drawing.Point(6, 90);
            this.useexploits.Name = "useexploits";
            this.useexploits.Size = new System.Drawing.Size(205, 17);
            this.useexploits.TabIndex = 7;
            this.useexploits.Text = "user exploits if available (dangerzone!)";
            this.useexploits.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 471);
            this.Controls.Add(this.withdrawbox);
            this.Controls.Add(this.generalbox);
            this.Controls.Add(this.multibotting);
            this.Controls.Add(this.safebutton);
            this.Controls.Add(this.discardbutton);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.difficultynumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safetynumeric)).EndInit();
            this.multibotting.ResumeLayout(false);
            this.multibotting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percenttotip)).EndInit();
            this.generalbox.ResumeLayout(false);
            this.generalbox.PerformLayout();
            this.withdrawbox.ResumeLayout(false);
            this.withdrawbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawtreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawpercent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donatepercent)).EndInit();
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
    }
}