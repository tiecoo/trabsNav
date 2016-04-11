namespace Sellers2.View
{
    partial class Update
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.TextBox();
            this.cpf2 = new System.Windows.Forms.Label();
            this.nick = new System.Windows.Forms.TextBox();
            this.lblnick = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 243);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(161, 20);
            this.txtID.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Id";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(12, 129);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(161, 20);
            this.tel.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tel";
            // 
            // cel
            // 
            this.cel.Location = new System.Drawing.Point(219, 129);
            this.cel.Name = "cel";
            this.cel.Size = new System.Drawing.Size(161, 20);
            this.cel.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cel";
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(12, 83);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(368, 20);
            this.cpf.TabIndex = 18;
            // 
            // cpf2
            // 
            this.cpf2.AutoSize = true;
            this.cpf2.Location = new System.Drawing.Point(9, 67);
            this.cpf2.Name = "cpf2";
            this.cpf2.Size = new System.Drawing.Size(27, 13);
            this.cpf2.TabIndex = 17;
            this.cpf2.Text = "CPF";
            // 
            // nick
            // 
            this.nick.Location = new System.Drawing.Point(219, 26);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(161, 20);
            this.nick.TabIndex = 16;
            // 
            // lblnick
            // 
            this.lblnick.AutoSize = true;
            this.lblnick.Location = new System.Drawing.Point(216, 10);
            this.lblnick.Name = "lblnick";
            this.lblnick.Size = new System.Drawing.Size(29, 13);
            this.lblnick.TabIndex = 15;
            this.lblnick.Text = "Nick";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(12, 26);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(161, 20);
            this.nome.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Deletar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 326);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.cpf2);
            this.Controls.Add(this.nick);
            this.Controls.Add(this.lblnick);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label1);
            this.Name = "Update";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cpf;
        private System.Windows.Forms.Label cpf2;
        private System.Windows.Forms.TextBox nick;
        private System.Windows.Forms.Label lblnick;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}