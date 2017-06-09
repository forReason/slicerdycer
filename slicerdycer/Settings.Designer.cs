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
            ((System.ComponentModel.ISupportInitialize)(this.difficultynumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safetynumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // discardbutton
            // 
            this.discardbutton.Location = new System.Drawing.Point(12, 382);
            this.discardbutton.Name = "discardbutton";
            this.discardbutton.Size = new System.Drawing.Size(75, 23);
            this.discardbutton.TabIndex = 0;
            this.discardbutton.Text = "discard";
            this.discardbutton.UseVisualStyleBackColor = true;
            // 
            // safebutton
            // 
            this.safebutton.Location = new System.Drawing.Point(197, 382);
            this.safebutton.Name = "safebutton";
            this.safebutton.Size = new System.Drawing.Size(75, 23);
            this.safebutton.TabIndex = 1;
            this.safebutton.Text = "Safe";
            this.safebutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "difficulty %";
            // 
            // difficultynumeric
            // 
            this.difficultynumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.difficultynumeric.Location = new System.Drawing.Point(105, 12);
            this.difficultynumeric.Name = "difficultynumeric";
            this.difficultynumeric.Size = new System.Drawing.Size(167, 20);
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
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "safety value";
            // 
            // safetynumeric
            // 
            this.safetynumeric.Location = new System.Drawing.Point(105, 46);
            this.safetynumeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.safetynumeric.Name = "safetynumeric";
            this.safetynumeric.Size = new System.Drawing.Size(167, 20);
            this.safetynumeric.TabIndex = 5;
            this.safetynumeric.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 417);
            this.Controls.Add(this.safetynumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.difficultynumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.safebutton);
            this.Controls.Add(this.discardbutton);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.difficultynumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safetynumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button discardbutton;
        private System.Windows.Forms.Button safebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown difficultynumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown safetynumeric;
    }
}