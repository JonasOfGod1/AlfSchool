using System;
using System.Windows.Forms;

namespace Program.Telas.Aluno
{
    public partial class VisualizarFaltas : Form
    {
        public VisualizarFaltas()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuAluno().Show();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cbbMateria.Text == "Matemática")
            {
                txtFaltas.Text = "5";
            }
            else if (cbbMateria.Text == "Português")
            {
                txtFaltas.Text = "4";
            }
            else if (cbbMateria.Text == "História")
            {
                txtFaltas.Text = "1";
            }
            else if (cbbMateria.Text == "Geografia")
            {
                txtFaltas.Text = "0";
            }
            else if (cbbMateria.Text == "Biologia")
            {
                txtFaltas.Text = "3";
            }
            else if (cbbMateria.Text == "Física")
            {
                txtFaltas.Text = "2";
            }
            else if (cbbMateria.Text == "Química")
            {
                txtFaltas.Text = "4";
            }
            else if (cbbMateria.Text == "Educação Física")
            {
                txtFaltas.Text = "1";
            }
            else if (cbbMateria.Text == "Inglês")
            {
                txtFaltas.Text = "2";
            }
            else if (cbbMateria.Text == "Artes")
            {
                txtFaltas.Text = "1";
            }
        }
    }
}
