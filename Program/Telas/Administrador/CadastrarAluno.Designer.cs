namespace Program.Telas
{
    partial class CadastrarAluno
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
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtCpfAluno = new System.Windows.Forms.TextBox();
            this.txtSenhaAluno = new System.Windows.Forms.TextBox();
            this.cbbSalaAluno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblErroOrSucess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCadastrarAluno.FlatAppearance.BorderSize = 0;
            this.btnCadastrarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAluno.Font = new System.Drawing.Font("Bauhaus 93", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarAluno.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCadastrarAluno.Location = new System.Drawing.Point(170, 371);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(112, 61);
            this.btnCadastrarAluno.TabIndex = 0;
            this.btnCadastrarAluno.Text = "Cadastrar";
            this.btnCadastrarAluno.UseVisualStyleBackColor = false;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastrar Aluno";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNomeAluno.Location = new System.Drawing.Point(44, 127);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(238, 23);
            this.txtNomeAluno.TabIndex = 2;
            // 
            // txtCpfAluno
            // 
            this.txtCpfAluno.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCpfAluno.Location = new System.Drawing.Point(44, 184);
            this.txtCpfAluno.Name = "txtCpfAluno";
            this.txtCpfAluno.Size = new System.Drawing.Size(238, 23);
            this.txtCpfAluno.TabIndex = 2;
            // 
            // txtSenhaAluno
            // 
            this.txtSenhaAluno.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSenhaAluno.Location = new System.Drawing.Point(44, 241);
            this.txtSenhaAluno.Name = "txtSenhaAluno";
            this.txtSenhaAluno.Size = new System.Drawing.Size(238, 23);
            this.txtSenhaAluno.TabIndex = 2;
            // 
            // cbbSalaAluno
            // 
            this.cbbSalaAluno.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbbSalaAluno.FormattingEnabled = true;
            this.cbbSalaAluno.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "201",
            "202",
            "203",
            "204",
            "301",
            "302",
            "303",
            "304"});
            this.cbbSalaAluno.Location = new System.Drawing.Point(44, 299);
            this.cbbSalaAluno.Name = "cbbSalaAluno";
            this.cbbSalaAluno.Size = new System.Drawing.Size(238, 23);
            this.cbbSalaAluno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sala";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Plum;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Bauhaus 93", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnVoltar.Location = new System.Drawing.Point(44, 371);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(112, 61);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblErroOrSucess
            // 
            this.lblErroOrSucess.AutoSize = true;
            this.lblErroOrSucess.ForeColor = System.Drawing.Color.Black;
            this.lblErroOrSucess.Location = new System.Drawing.Point(80, 334);
            this.lblErroOrSucess.Name = "lblErroOrSucess";
            this.lblErroOrSucess.Size = new System.Drawing.Size(0, 15);
            this.lblErroOrSucess.TabIndex = 6;
            // 
            // CadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(331, 487);
            this.Controls.Add(this.lblErroOrSucess);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCpfAluno);
            this.Controls.Add(this.txtSenhaAluno);
            this.Controls.Add(this.cbbSalaAluno);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.btnVoltar);
            this.Name = "CadastrarAluno";
            this.Text = "Cadastrar Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.TextBox txtCpfAluno;
        private System.Windows.Forms.TextBox txtSenhaAluno;
        private System.Windows.Forms.ComboBox cbbSalaAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblErroOrSucess;
    }
}