namespace Program.Telas.Administrador
{
    partial class MenuAdministrador
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
            this.btnCadastrarAdministrador = new System.Windows.Forms.Button();
            this.btnCadastrarProfessor = new System.Windows.Forms.Button();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(143, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // btnCadastrarAdministrador
            // 
            this.btnCadastrarAdministrador.Location = new System.Drawing.Point(93, 145);
            this.btnCadastrarAdministrador.Name = "btnCadastrarAdministrador";
            this.btnCadastrarAdministrador.Size = new System.Drawing.Size(193, 69);
            this.btnCadastrarAdministrador.TabIndex = 1;
            this.btnCadastrarAdministrador.Text = "Cadastrar Administrador";
            this.btnCadastrarAdministrador.UseVisualStyleBackColor = true;
            this.btnCadastrarAdministrador.Click += new System.EventHandler(this.btnCadastrarAdministrador_Click);
            // 
            // btnCadastrarProfessor
            // 
            this.btnCadastrarProfessor.Location = new System.Drawing.Point(93, 234);
            this.btnCadastrarProfessor.Name = "btnCadastrarProfessor";
            this.btnCadastrarProfessor.Size = new System.Drawing.Size(193, 69);
            this.btnCadastrarProfessor.TabIndex = 1;
            this.btnCadastrarProfessor.Text = "Cadastrar Professor";
            this.btnCadastrarProfessor.UseVisualStyleBackColor = true;
            this.btnCadastrarProfessor.Click += new System.EventHandler(this.btnCadastrarProfessor_Click);
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Location = new System.Drawing.Point(93, 326);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(193, 69);
            this.btnCadastrarAluno.TabIndex = 1;
            this.btnCadastrarAluno.Text = "Cadastrar Aluno";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 444);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Controls.Add(this.btnCadastrarProfessor);
            this.Controls.Add(this.btnCadastrarAdministrador);
            this.Controls.Add(this.label1);
            this.Name = "MenuAdministrador";
            this.Text = "MenuAdministrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarAdministrador;
        private System.Windows.Forms.Button btnCadastrarProfessor;
        private System.Windows.Forms.Button btnCadastrarAluno;
    }
}