namespace Program.Telas.Aluno
{
    partial class VisualizarNotas
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
            this.cbbMateria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visualizar Notas";
            // 
            // cbbMateria
            // 
            this.cbbMateria.FormattingEnabled = true;
            this.cbbMateria.Items.AddRange(new object[] {
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
            this.cbbMateria.Location = new System.Drawing.Point(53, 130);
            this.cbbMateria.Name = "cbbMateria";
            this.cbbMateria.Size = new System.Drawing.Size(207, 23);
            this.cbbMateria.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Materia";
            // 
            // txtNota1
            // 
            this.txtNota1.Enabled = false;
            this.txtNota1.Location = new System.Drawing.Point(53, 188);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(207, 23);
            this.txtNota1.TabIndex = 3;
            this.txtNota1.Visible = false;
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(53, 170);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(42, 15);
            this.lblNota1.TabIndex = 4;
            this.lblNota1.Text = "Nota 1";
            this.lblNota1.Visible = false;
            // 
            // txtNota2
            // 
            this.txtNota2.Enabled = false;
            this.txtNota2.Location = new System.Drawing.Point(53, 236);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(207, 23);
            this.txtNota2.TabIndex = 3;
            this.txtNota2.Visible = false;
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(53, 218);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(42, 15);
            this.lblNota2.TabIndex = 4;
            this.lblNota2.Text = "Nota 2";
            this.lblNota2.Visible = false;
            // 
            // txtNota3
            // 
            this.txtNota3.Enabled = false;
            this.txtNota3.Location = new System.Drawing.Point(53, 283);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(207, 23);
            this.txtNota3.TabIndex = 3;
            this.txtNota3.Visible = false;
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(53, 265);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(42, 15);
            this.lblNota3.TabIndex = 4;
            this.lblNota3.Text = "Nota 3";
            this.lblNota3.Visible = false;
            // 
            // txtNota4
            // 
            this.txtNota4.Enabled = false;
            this.txtNota4.Location = new System.Drawing.Point(53, 330);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(207, 23);
            this.txtNota4.TabIndex = 3;
            this.txtNota4.Visible = false;
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Location = new System.Drawing.Point(53, 312);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(42, 15);
            this.lblNota4.TabIndex = 4;
            this.lblNota4.Text = "Nota 4";
            this.lblNota4.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(30, 386);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(122, 52);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(158, 386);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(122, 52);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // VisualizarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.lblNota4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbMateria);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnFiltrar);
            this.Name = "VisualizarNotas";
            this.Text = "VisualizarNotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnFiltrar;
    }
}