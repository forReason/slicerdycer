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
            this.balance = new System.Windows.Forms.Label();
            this.bet = new System.Windows.Forms.Label();
            this.betting = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // pausestart
            // 
            this.pausestart.Location = new System.Drawing.Point(12, 247);
            this.pausestart.Name = "pausestart";
            this.pausestart.Size = new System.Drawing.Size(673, 57);
            this.pausestart.TabIndex = 0;
            this.pausestart.Text = "Start";
            this.pausestart.UseVisualStyleBackColor = true;
            this.pausestart.Click += new System.EventHandler(this.pausestart_Click);
            // 
            // balancelabel
            // 
            this.balancelabel.AutoSize = true;
            this.balancelabel.Location = new System.Drawing.Point(12, 9);
            this.balancelabel.Name = "balancelabel";
            this.balancelabel.Size = new System.Drawing.Size(46, 13);
            this.balancelabel.TabIndex = 1;
            this.balancelabel.Text = "Balance";
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(12, 26);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(13, 13);
            this.balance.TabIndex = 2;
            this.balance.Text = "0";
            // 
            // bet
            // 
            this.bet.AutoSize = true;
            this.bet.Location = new System.Drawing.Point(9, 57);
            this.bet.Name = "bet";
            this.bet.Size = new System.Drawing.Size(58, 13);
            this.bet.TabIndex = 3;
            this.bet.Text = "current bet";
            // 
            // betting
            // 
            this.betting.AutoSize = true;
            this.betting.Location = new System.Drawing.Point(12, 70);
            this.betting.Name = "betting";
            this.betting.Size = new System.Drawing.Size(13, 13);
            this.betting.TabIndex = 4;
            this.betting.Text = "0";
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(610, 9);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(75, 23);
            this.Settings.TabIndex = 5;
            this.Settings.Text = "button1";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(201, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(403, 235);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            // 
            // Botting_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 316);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.betting);
            this.Controls.Add(this.bet);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.balancelabel);
            this.Controls.Add(this.pausestart);
            this.Name = "Botting_Window";
            this.Text = "Botting_Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pausestart;
        private System.Windows.Forms.Label balancelabel;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label bet;
        private System.Windows.Forms.Label betting;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}