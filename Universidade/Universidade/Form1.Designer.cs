namespace Universidade
{
    partial class Main
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
            this.dataGridDep = new System.Windows.Forms.DataGridView();
            this.listarBtn = new System.Windows.Forms.Button();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridProf = new System.Windows.Forms.DataGridView();
            this.lblDepCount = new System.Windows.Forms.Label();
            this.lblProfCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProf)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDep
            // 
            this.dataGridDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDep.Location = new System.Drawing.Point(41, 79);
            this.dataGridDep.Name = "dataGridDep";
            this.dataGridDep.Size = new System.Drawing.Size(295, 251);
            this.dataGridDep.TabIndex = 0;
            // 
            // listarBtn
            // 
            this.listarBtn.Location = new System.Drawing.Point(147, 37);
            this.listarBtn.Name = "listarBtn";
            this.listarBtn.Size = new System.Drawing.Size(75, 23);
            this.listarBtn.TabIndex = 1;
            this.listarBtn.Text = "Listar";
            this.listarBtn.UseVisualStyleBackColor = true;
            this.listarBtn.Click += new System.EventHandler(this.listarBtn_Click);
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(41, 40);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(100, 20);
            this.txtProfessor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listar departamento por professor";
            // 
            // dataGridProf
            // 
            this.dataGridProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProf.Location = new System.Drawing.Point(371, 79);
            this.dataGridProf.Name = "dataGridProf";
            this.dataGridProf.Size = new System.Drawing.Size(275, 251);
            this.dataGridProf.TabIndex = 5;
            // 
            // lblDepCount
            // 
            this.lblDepCount.AutoSize = true;
            this.lblDepCount.Location = new System.Drawing.Point(213, 333);
            this.lblDepCount.Name = "lblDepCount";
            this.lblDepCount.Size = new System.Drawing.Size(123, 13);
            this.lblDepCount.TabIndex = 6;
            this.lblDepCount.Text = "0 registro(s) encontrados";
            // 
            // lblProfCount
            // 
            this.lblProfCount.AutoSize = true;
            this.lblProfCount.Location = new System.Drawing.Point(523, 333);
            this.lblProfCount.Name = "lblProfCount";
            this.lblProfCount.Size = new System.Drawing.Size(123, 13);
            this.lblProfCount.TabIndex = 7;
            this.lblProfCount.Text = "0 registro(s) encontrados";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 371);
            this.Controls.Add(this.lblProfCount);
            this.Controls.Add(this.lblDepCount);
            this.Controls.Add(this.dataGridProf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProfessor);
            this.Controls.Add(this.listarBtn);
            this.Controls.Add(this.dataGridDep);
            this.Name = "Main";
            this.Text = "Universidade";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDep;
        private System.Windows.Forms.Button listarBtn;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridProf;
        private System.Windows.Forms.Label lblDepCount;
        private System.Windows.Forms.Label lblProfCount;
    }
}

