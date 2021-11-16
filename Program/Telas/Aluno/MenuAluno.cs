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
            this.Hide();
            new Login().ShowDialog();
        }

        private void btnVisualizarNotas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VisualizarNotas().ShowDialog();
        }

        private void btnVisualizarTurma_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VisualizarTurma().ShowDialog();
        }
    }
}
