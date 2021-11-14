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
            this.Visible = false;
            var login = new Login();
            login.ShowDialog();
        }

        private void btnVisualizarNotas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var visualizarNotas = new VisualizarNotas();
            visualizarNotas.ShowDialog();
        }
    }
}
