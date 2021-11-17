using System;
using System.Windows.Forms;
using Program.Entities;

namespace Program.Telas.Professor
{
    public partial class MenuProfessor : Form
    {
        public MenuProfessor()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
        }

        private void btnCadastrarNota_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CadastrarNotas().ShowDialog();
        }

        private void btnVisualizarTurma_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VisualizarTurma().ShowDialog();
        }

        private void btnCadastrarFalta_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CadastrarFaltas().Show();
        }
    }
}
