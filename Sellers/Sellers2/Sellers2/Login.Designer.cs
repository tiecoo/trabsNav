namespace Sellers2.View
{
    partial class Login
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
            this.nick = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.Nickname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nick
            // 
            this.nick.Location = new System.Drawing.Point(21, 48);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(109, 20);
            this.nick.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(21, 92);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(109, 20);
            this.password.TabIndex = 1;
            // 
            // Nickname
            // 
            this.Nickname.AutoSize = true;
            this.Nickname.Location = new System.Drawing.Point(18, 32);
            this.Nickname.Name = "Nickname";
            this.Nickname.Size = new System.Drawing.Size(55, 13);
            this.Nickname.TabIndex = 2;
            this.Nickname.Text = "Nickname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Senha";
            // 
            // logon
            // 
            this.logon.Location = new System.Drawing.Point(21, 152);
            this.logon.Name = "logon";
            this.logon.Size = new System.Drawing.Size(87, 25);
            this.logon.TabIndex = 4;
            this.logon.Text = "Acessar";
            this.logon.UseVisualStyleBackColor = true;
            this.logon.Click += new System.EventHandler(this.logon_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.logon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nickname);
            this.Controls.Add(this.password);
            this.Controls.Add(this.nick);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nick;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label Nickname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logon;
    }
}