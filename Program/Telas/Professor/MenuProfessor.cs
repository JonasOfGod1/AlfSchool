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
            this.Visible = false;
            var login = new Login();
            login.ShowDialog();
        }

        private void btnCadastrarNota_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var cadastrarNotas = new CadastrarNotas();
            cadastrarNotas.ShowDialog();
        }

        private void btnVisualizarTurma_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var visualizarTurma = new VisualizarTurma();
            visualizarTurma.ShowDialog();
        }
    }
}
