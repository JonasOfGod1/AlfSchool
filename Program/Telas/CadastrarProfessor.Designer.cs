namespace Program.Telas
{
    partial class CadastrarProfessor
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
            this.btnCadastrarProfessor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeProfessor = new System.Windows.Forms.TextBox();
            this.txtSenhaProfessor = new System.Windows.Forms.TextBox();
            this.cbbSalaProfessor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCpfProfessor = new System.Windows.Forms.TextBox();
            this.cbbMateriaProfessor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrarProfessor
            // 
            this.btnCadastrarProfessor.Location = new System.Drawing.Point(102, 375);
            this.btnCadastrarProfessor.Name = "btnCadastrarProfessor";
            this.btnCadastrarProfessor.Size = new System.Drawing.Size(170, 62);
            this.btnCadastrarProfessor.TabIndex = 0;
            this.btnCadastrarProfessor.Text = "Cadastrar";
            this.btnCadastrarProfessor.UseVisualStyleBackColor = true;
            this.btnCadastrarProfessor.Click += new System.EventHandler(this.btnCadastrarProfessor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastrar Professor";
            // 
            // txtNomeProfessor
            // 
            this.txtNomeProfessor.Location = new System.Drawing.Point(62, 125);
            this.txtNomeProfessor.Name = "txtNomeProfessor";
            this.txtNomeProfessor.Size = new System.Drawing.Size(246, 23);
            this.txtNomeProfessor.TabIndex = 2;
            // 
            // txtSenhaProfessor
            // 
            this.txtSenhaProfessor.Location = new System.Drawing.Point(62, 276);
            this.txtSenhaProfessor.Name = "txtSenhaProfessor";
            this.txtSenhaProfessor.Size = new System.Drawing.Size(246, 23);
            this.txtSenhaProfessor.TabIndex = 2;
            // 
            // cbbSalaProfessor
            // 
            this.cbbSalaProfessor.FormattingEnabled = true;
            this.cbbSalaProfessor.Items.AddRange(new object[] {
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
            this.cbbSalaProfessor.Location = new System.Drawing.Point(62, 329);
            this.cbbSalaProfessor.Name = "cbbSalaProfessor";
            this.cbbSalaProfessor.Size = new System.Drawing.Size(246, 23);
            this.cbbSalaProfessor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sala";
            // 
            // txtCpfProfessor
            // 
            this.txtCpfProfessor.Location = new System.Drawing.Point(62, 222);
            this.txtCpfProfessor.Name = "txtCpfProfessor";
            this.txtCpfProfessor.Size = new System.Drawing.Size(246, 23);
            this.txtCpfProfessor.TabIndex = 2;
            // 
            // cbbMateriaProfessor
            // 
            this.cbbMateriaProfessor.FormattingEnabled = true;
            this.cbbMateriaProfessor.Items.AddRange(new object[] {
            "Matemática",
            "Português",
            "História",
            "Geografia",
            "Biologia",
            "Física",
            "Química",
            "Educação Física",
            "Inglês",
            "Artes"});
            this.cbbMateriaProfessor.Location = new System.Drawing.Point(62, 173);
            this.cbbMateriaProfessor.Name = "cbbMateriaProfessor";
            this.cbbMateriaProfessor.Size = new System.Drawing.Size(246, 23);
            this.cbbMateriaProfessor.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Matéria";
            // 
            // CadastrarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 473);
            this.Controls.Add(this.btnCadastrarProfessor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaProfessor);
            this.Controls.Add(this.cbbSalaProfessor);
            this.Controls.Add(this.cbbMateriaProfessor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCpfProfessor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeProfessor);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarProfessor";
            this.Text = "Cadastrar Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarProfessor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeProfessor;
        private System.Windows.Forms.TextBox txtSenhaProfessor;
        private System.Windows.Forms.ComboBox cbbSalaProfessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCpfProfessor;
        private System.Windows.Forms.ComboBox cbbMateriaProfessor;
        private System.Windows.Forms.Label label6;
    }
}