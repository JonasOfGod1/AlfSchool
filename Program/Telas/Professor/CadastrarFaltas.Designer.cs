
namespace Program.Telas.Professor
{
    partial class CadastrarFaltas
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbAluno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFaltas = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblErrorOrSucess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Faltas";
            // 
            // cbbAluno
            // 
            this.cbbAluno.FormattingEnabled = true;
            this.cbbAluno.Items.AddRange(new object[] {
            "Alan da Silva",
            "Amanda rosa",
            "Eduarda de Souza",
            "Leonardo Andrade",
            "Jéssica Castro",
            "Henrique Nunes",
            "Pablo Vargas",
            "Lucas da Silva",
            "Maria Pereira",
            "Gustavo de Souza",
            "Alice Barbosa",
            "João Rodrigues",
            "Geovana da Cruz",
            "Julia Vargas",
            "Letícia Rodrigues"});
            this.cbbAluno.Location = new System.Drawing.Point(43, 149);
            this.cbbAluno.Name = "cbbAluno";
            this.cbbAluno.Size = new System.Drawing.Size(240, 23);
            this.cbbAluno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aluno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantidade Faltas";
            // 
            // txtFaltas
            // 
            this.txtFaltas.Location = new System.Drawing.Point(43, 232);
            this.txtFaltas.Name = "txtFaltas";
            this.txtFaltas.Size = new System.Drawing.Size(240, 23);
            this.txtFaltas.TabIndex = 4;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(43, 310);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(116, 51);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(167, 310);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(116, 51);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblErrorOrSucess
            // 
            this.lblErrorOrSucess.AutoSize = true;
            this.lblErrorOrSucess.Location = new System.Drawing.Point(44, 268);
            this.lblErrorOrSucess.Name = "lblErrorOrSucess";
            this.lblErrorOrSucess.Size = new System.Drawing.Size(0, 15);
            this.lblErrorOrSucess.TabIndex = 7;
            // 
            // CadastrarFaltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 387);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblErrorOrSucess);
            this.Controls.Add(this.txtFaltas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbAluno);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarFaltas";
            this.Text = "Cadastrar Faltas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFaltas;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblErrorOrSucess;
    }
}