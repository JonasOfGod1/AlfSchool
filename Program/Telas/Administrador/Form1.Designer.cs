namespace Program
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrarAdministrador = new System.Windows.Forms.Button();
            this.txtCpfAdministrador = new System.Windows.Forms.TextBox();
            this.txtNomeAdministrador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenhaAdministrador = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblErrorOrSucess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Administrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF";
            // 
            // btnCadastrarAdministrador
            // 
            this.btnCadastrarAdministrador.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCadastrarAdministrador.FlatAppearance.BorderSize = 0;
            this.btnCadastrarAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAdministrador.Font = new System.Drawing.Font("Bauhaus 93", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarAdministrador.Location = new System.Drawing.Point(175, 343);
            this.btnCadastrarAdministrador.Name = "btnCadastrarAdministrador";
            this.btnCadastrarAdministrador.Size = new System.Drawing.Size(116, 59);
            this.btnCadastrarAdministrador.TabIndex = 4;
            this.btnCadastrarAdministrador.Text = "Cadastrar";
            this.btnCadastrarAdministrador.UseVisualStyleBackColor = false;
            this.btnCadastrarAdministrador.Click += new System.EventHandler(this.btnCadastrarAdministrador_Click);
            // 
            // txtCpfAdministrador
            // 
            this.txtCpfAdministrador.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCpfAdministrador.Location = new System.Drawing.Point(54, 203);
            this.txtCpfAdministrador.Name = "txtCpfAdministrador";
            this.txtCpfAdministrador.Size = new System.Drawing.Size(237, 23);
            this.txtCpfAdministrador.TabIndex = 7;
            // 
            // txtNomeAdministrador
            // 
            this.txtNomeAdministrador.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNomeAdministrador.Location = new System.Drawing.Point(54, 138);
            this.txtNomeAdministrador.Name = "txtNomeAdministrador";
            this.txtNomeAdministrador.Size = new System.Drawing.Size(237, 23);
            this.txtNomeAdministrador.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Senha";
            // 
            // txtSenhaAdministrador
            // 
            this.txtSenhaAdministrador.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSenhaAdministrador.Location = new System.Drawing.Point(54, 263);
            this.txtSenhaAdministrador.Name = "txtSenhaAdministrador";
            this.txtSenhaAdministrador.Size = new System.Drawing.Size(237, 23);
            this.txtSenhaAdministrador.TabIndex = 7;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Plum;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Bauhaus 93", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Location = new System.Drawing.Point(54, 343);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(116, 59);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblErrorOrSucess
            // 
            this.lblErrorOrSucess.AutoSize = true;
            this.lblErrorOrSucess.Location = new System.Drawing.Point(81, 302);
            this.lblErrorOrSucess.Name = "lblErrorOrSucess";
            this.lblErrorOrSucess.Size = new System.Drawing.Size(0, 15);
            this.lblErrorOrSucess.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(339, 460);
            this.Controls.Add(this.txtCpfAdministrador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeAdministrador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSenhaAdministrador);
            this.Controls.Add(this.lblErrorOrSucess);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrarAdministrador);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastrar Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrarAdministrador;
        private System.Windows.Forms.TextBox txtCpfAdministrador;
        private System.Windows.Forms.TextBox txtNomeAdministrador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenhaAdministrador;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblErrorOrSucess;
    }
}

