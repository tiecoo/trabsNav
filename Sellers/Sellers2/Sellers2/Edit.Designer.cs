namespace Sellers2
{
    partial class Edit
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nick = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.TextBox();
            this.cpf2 = new System.Windows.Forms.Label();
            this.cel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(48, 37);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(161, 20);
            this.nome.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(255, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 4;
            // 
            // nick
            // 
            this.nick.AutoSize = true;
            this.nick.Location = new System.Drawing.Point(252, 21);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(29, 13);
            this.nick.TabIndex = 3;
            this.nick.Text = "Nick";
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(48, 94);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(368, 20);
            this.cpf.TabIndex = 6;
            // 
            // cpf2
            // 
            this.cpf2.AutoSize = true;
            this.cpf2.Location = new System.Drawing.Point(45, 78);
            this.cpf2.Name = "cpf2";
            this.cpf2.Size = new System.Drawing.Size(27, 13);
            this.cpf2.TabIndex = 5;
            this.cpf2.Text = "CPF";
            // 
            // cel
            // 
            this.cel.Location = new System.Drawing.Point(255, 140);
            this.cel.Name = "cel";
            this.cel.Size = new System.Drawing.Size(161, 20);
            this.cel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cel";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(48, 140);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(161, 20);
            this.tel.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tel";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(48, 254);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(161, 20);
            this.id.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Id";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 306);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.cpf2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.nick);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Edit";
            this.Text = "Acessar Cadastro Vendedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label nick;
        private System.Windows.Forms.TextBox cpf;
        private System.Windows.Forms.Label cpf2;
        private System.Windows.Forms.TextBox cel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label2;

    }
}

