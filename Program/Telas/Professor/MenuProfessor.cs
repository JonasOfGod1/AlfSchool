using System;
using System.Windows.Forms;

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
            new Login().ShowDialog();
            this.Hide();
        }

        private void btnCadastrarNota_Click(object sender, EventArgs e)
        {
            new CadastrarNotas().ShowDialog();
            this.Hide();
        }

        private void btnVisualizarTurma_Click(object sender, EventArgs e)
        {
            new VisualizarTurma().ShowDialog();
            this.Hide();
        }
    }
}
