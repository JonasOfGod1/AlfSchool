using System;
using System.Windows.Forms;

namespace Program.Telas.Aluno
{
    public partial class MenuAluno : Form
    {
        public MenuAluno()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Login().ShowDialog();
            this.Hide();
        }

        private void btnVisualizarNotas_Click(object sender, EventArgs e)
        {
            new VisualizarNotas().ShowDialog();
            this.Hide();
        }

        private void btnVisualizarTurma_Click(object sender, EventArgs e)
        {
            new VisualizarTurma().ShowDialog();
            this.Hide();
        }
    }
}
