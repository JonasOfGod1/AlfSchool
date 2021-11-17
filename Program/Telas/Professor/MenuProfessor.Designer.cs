namespace Program.Telas.Professor
{
    partial class MenuProfessor
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCadastrarNota = new System.Windows.Forms.Button();
            this.btnVisualizarTurma = new System.Windows.Forms.Button();
            this.btnCadastrarFalta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Professor";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Plum;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Bauhaus 93", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLogout.Location = new System.Drawing.Point(61, 345);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(201, 66);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCadastrarNota
            // 
            this.btnCadastrarNota.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCadastrarNota.FlatAppearance.BorderSize = 0;
            this.btnCadastrarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarNota.Font = new System.Drawing.Font("Bauhaus 93", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarNota.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCadastrarNota.Location = new System.Drawing.Point(61, 129);
            this.btnCadastrarNota.Name = "btnCadastrarNota";
            this.btnCadastrarNota.Size = new System.Drawing.Size(201, 66);
            this.btnCadastrarNota.TabIndex = 2;
            this.btnCadastrarNota.Text = "Cadastrar Nota";
            this.btnCadastrarNota.UseVisualStyleBackColor = false;
            this.btnCadastrarNota.Click += new System.EventHandler(this.btnCadastrarNota_Click);
            // 
            // btnVisualizarTurma
            // 
            this.btnVisualizarTurma.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnVisualizarTurma.FlatAppearance.BorderSize = 0;
            this.btnVisualizarTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarTurma.Font = new System.Drawing.Font("Bauhaus 93", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizarTurma.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnVisualizarTurma.Location = new System.Drawing.Point(61, 273);
            this.btnVisualizarTurma.Name = "btnVisualizarTurma";
            this.btnVisualizarTurma.Size = new System.Drawing.Size(201, 66);
            this.btnVisualizarTurma.TabIndex = 3;
            this.btnVisualizarTurma.Text = "Visualizar Turma";
            this.btnVisualizarTurma.UseVisualStyleBackColor = false;
            this.btnVisualizarTurma.Click += new System.EventHandler(this.btnVisualizarTurma_Click);
            // 
            // btnCadastrarFalta
            // 
            this.btnCadastrarFalta.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCadastrarFalta.FlatAppearance.BorderSize = 0;
            this.btnCadastrarFalta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFalta.Font = new System.Drawing.Font("Bauhaus 93", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarFalta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCadastrarFalta.Location = new System.Drawing.Point(61, 201);
            this.btnCadastrarFalta.Name = "btnCadastrarFalta";
            this.btnCadastrarFalta.Size = new System.Drawing.Size(201, 66);
            this.btnCadastrarFalta.TabIndex = 4;
            this.btnCadastrarFalta.Text = "Cadastrar Falta";
            this.btnCadastrarFalta.UseVisualStyleBackColor = false;
            this.btnCadastrarFalta.Click += new System.EventHandler(this.btnCadastrarFalta_Click);
            // 
            // MenuProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(318, 432);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnVisualizarTurma);
            this.Controls.Add(this.btnCadastrarFalta);
            this.Controls.Add(this.btnCadastrarNota);
            this.Controls.Add(this.label1);
            this.Name = "MenuProfessor";
            this.Text = "Menu Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCadastrarNota;
        private System.Windows.Forms.Button btnVisualizarTurma;
        private System.Windows.Forms.Button btnCadastrarFalta;
    }
}