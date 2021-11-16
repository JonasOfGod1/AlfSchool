using System;
using System.Windows.Forms;

namespace Program.Telas.Aluno
{
    public partial class VisualizarNotas : Form
    {
        public VisualizarNotas()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuAluno().ShowDialog();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cbbMateria.Text == "Matemática")
            {
                lblNota1.Visible = true;
                txtNota1.Visible = true;
                txtNota1.Text = "7,5";

                lblNota2.Visible = true;
                txtNota2.Visible = true;
                txtNota2.Text = "8";

                lblNota3.Visible = true;
                txtNota3.Visible = true;
                txtNota3.Text = "5";

                lblNota4.Visible = true;
                txtNota4.Visible = true;
                txtNota4.Text = "6,5";
            }
            else if (cbbMateria.Text == "Português")
            {
                lblNota1.Visible = true;
                txtNota1.Visible = true;
                txtNota1.Text = "9";

                lblNota2.Visible = true;
                txtNota2.Visible = true;
                txtNota2.Text = "7";

                lblNota3.Visible = false;
                txtNota3.Visible = false;
                txtNota3.Visible = false;

                lblNota4.Visible = false;
                txtNota4.Visible = false;
                txtNota4.Visible = false;
            }
            else if (cbbMateria.Text == "História")
            {
                lblNota1.Visible = true;
                txtNota1.Visible = true;
                txtNota1.Text = "10";

                lblNota2.Visible = true;
                txtNota2.Visible = true;
                txtNota2.Text = "8";

                lblNota3.Visible = true;
                txtNota3.Visible = true;
                txtNota3.Text = "9,5";

                lblNota4.Visible = false;
                txtNota4.Visible = false;
                txtNota4.Visible = false;
            }
            else if (cbbMateria.Text == "Geografia")
            {
                lblNota1.Visible = true;
                txtNota1.Visible = true;
                txtNota1.Text = "4";

                lblNota2.Visible = true;
                txtNota2.Visible = true;
                txtNota2.Text = "7";

                lblNota3.Visible = true;
                txtNota3.Visible = true;
                txtNota3.Text = "6";

                lblNota4.Visible = false;
                txtNota4.Visible = false;
                txtNota4.Visible = false;
            }
            else if (cbbMateria.Text == "Biologia")
            {
                lblNota1.Visible = true;
                txtNota1.Visible = true;
                txtNota1.Text = "10";

                lblNota2.Visible = true;
                txtNota2.Visible = true;
                txtNota2.Text = "7,5";

                lblNota3.Visible = false;
                txtNota3.Visible = false;
                txtNota3.Visible = false;

                lblNota4.Visible = false;
                txtNota4.Visible = false;
                txtNota4.Visible = false;
            }
            else if (cbbMateria.Text == "Física")
            {
                lblNota1.Visible = true;
                txtNota1.Visible = true;
                txtNota1.Text = "4,5";

                lblNota2.Visible = true;
                txtNota2.Visible = true;
                txtNota2.Text = "8";

                lblNota3.Visible = true;
                txtNota3.Visible = true;
                txtNota3.Text = "5,5";

                lblNota4.Visible = false;
                txtNota4.Visible = false;
                txtNota4.Visible = false;
            }
            else if (cbbMateria.Text == "Química")
            {
                lblNota1.Visible = true;
                txtNota1.Visible = true;
                txtNota1.Text = "6,5";

                lblNota2.Visible = true;
                txtNota2.Visible = true;
                txtNota2.Text = "7";

                lblNota3.Visible = true;
                txtNota3.Visible = true;
                txtNota3.Text = "3,5";

                lblNota4.Visible = true;
                txtNota4.Visible = true;
                txtNota4.Text = "8";
            }
            else if (cbbMateria.Text == "Educação Física")
            {
                lblNota1.Visible = true;
                txtNota1.Visible = true;
                txtNota1.Text = "10";

                lblNota2.Visible = true;
                txtNota2.Visible = true;
                txtNota2.Text = "9";

                lblNota3.Visible = true;
                txtNota3.Visible = true;
                txtNota3.Text = "9,5";

                lblNota4.Visible = false;
                txtNota4.Visible = false;
                txtNota4.Visible = false;
            }
            else if (cbbMateria.Text == "Inglês")
            {
                lblNota1.Visible = true;
                txtNota1.Visible = true;
                txtNota1.Text = "4";

                lblNota2.Visible = true;
                txtNota2.Visible = true;
                txtNota2.Text = "9";

                lblNota3.Visible = false;
                txtNota3.Visible = false;
                txtNota3.Visible = false;

                lblNota4.Visible = false;
                txtNota4.Visible = false;
                txtNota4.Visible = false;
            }
            else if (cbbMateria.Text == "Artes")
            {
                lblNota1.Visible = true;
                txtNota1.Visible = true;
                txtNota1.Text = "9";

                lblNota2.Visible = true;
                txtNota2.Visible = true;
                txtNota2.Text = "5";

                lblNota3.Visible = true;
                txtNota3.Visible = true;
                txtNota3.Text = "7,5";

                lblNota4.Visible = false;
                txtNota4.Visible = false;
                txtNota4.Visible = false;
            }
            else
            {
                lblNota1.Visible = false;
                lblNota2.Visible = false;
                lblNota3.Visible = false;
                lblNota4.Visible = false;
                txtNota1.Visible = false;
                txtNota2.Visible = false;
                txtNota3.Visible = false;
                txtNota4.Visible = false;
            }
        }
    }
}
