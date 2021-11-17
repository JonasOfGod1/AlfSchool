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
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(25, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Administrador";
            // 
            // btnCadastrarAdministrador
            // 
            this.btnCadastrarAdministrador.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCadastrarAdministrador.FlatAppearance.BorderSize = 0;
            this.btnCadastrarAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAdministrador.Font = new System.Drawing.Font("Bauhaus 93", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarAdministrador.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCadastrarAdministrador.Location = new System.Drawing.Point(60, 121);
            this.btnCadastrarAdministrador.Name = "btnCadastrarAdministrador";
            this.btnCadastrarAdministrador.Size = new System.Drawing.Size(193, 69);
            this.btnCadastrarAdministrador.TabIndex = 1;
            this.btnCadastrarAdministrador.Text = "Cadastrar Administrador";
            this.btnCadastrarAdministrador.UseVisualStyleBackColor = false;
            this.btnCadastrarAdministrador.Click += new System.EventHandler(this.btnCadastrarAdministrador_Click);
            // 
            // btnCadastrarProfessor
            // 
            this.btnCadastrarProfessor.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCadastrarProfessor.FlatAppearance.BorderSize = 0;
            this.btnCadastrarProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProfessor.Font = new System.Drawing.Font("Bauhaus 93", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarProfessor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCadastrarProfessor.Location = new System.Drawing.Point(60, 210);
            this.btnCadastrarProfessor.Name = "btnCadastrarProfessor";
            this.btnCadastrarProfessor.Size = new System.Drawing.Size(193, 69);
            this.btnCadastrarProfessor.TabIndex = 1;
            this.btnCadastrarProfessor.Text = "Cadastrar Professor";
            this.btnCadastrarProfessor.UseVisualStyleBackColor = false;
            this.btnCadastrarProfessor.Click += new System.EventHandler(this.btnCadastrarProfessor_Click);
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCadastrarAluno.FlatAppearance.BorderSize = 0;
            this.btnCadastrarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAluno.Font = new System.Drawing.Font("Bauhaus 93", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarAluno.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCadastrarAluno.Location = new System.Drawing.Point(60, 302);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(193, 69);
            this.btnCadastrarAluno.TabIndex = 1;
            this.btnCadastrarAluno.Text = "Cadastrar Aluno";
            this.btnCadastrarAluno.UseVisualStyleBackColor = false;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Plum;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Bauhaus 93", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLogout.Location = new System.Drawing.Point(60, 391);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(193, 69);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(330, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCadastrarProfessor);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Controls.Add(this.btnCadastrarAdministrador);
            this.Name = "MenuAdministrador";
            this.Text = "Menu Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarAdministrador;
        private System.Windows.Forms.Button btnCadastrarProfessor;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Button btnLogout;
    }
}