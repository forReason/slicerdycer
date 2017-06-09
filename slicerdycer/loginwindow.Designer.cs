namespace slicerdycer
{
    partial class loginwindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.TextBox();
            this.apikey = new System.Windows.Forms.TextBox();
            this.rememberbox = new System.Windows.Forms.CheckBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(13, 13);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 0;
            this.username.Text = "username";
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // apikey
            // 
            this.apikey.Location = new System.Drawing.Point(13, 40);
            this.apikey.Name = "apikey";
            this.apikey.Size = new System.Drawing.Size(259, 20);
            this.apikey.TabIndex = 1;
            this.apikey.Text = "api key";
            // 
            // rememberbox
            // 
            this.rememberbox.AutoSize = true;
            this.rememberbox.Location = new System.Drawing.Point(13, 67);
            this.rememberbox.Name = "rememberbox";
            this.rememberbox.Size = new System.Drawing.Size(89, 17);
            this.rememberbox.TabIndex = 2;
            this.rememberbox.Text = "remember me";
            this.rememberbox.UseVisualStyleBackColor = true;
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(197, 67);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 23);
            this.loginbutton.TabIndex = 3;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // loginwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 99);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.rememberbox);
            this.Controls.Add(this.apikey);
            this.Controls.Add(this.username);
            this.Name = "loginwindow";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox apikey;
        private System.Windows.Forms.CheckBox rememberbox;
        private System.Windows.Forms.Button loginbutton;
    }
}

