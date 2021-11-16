using System;
using System.Windows.Forms;

namespace Program.Telas.Aluno
{
    public partial class VisualizarTurma : Form
    {
        public VisualizarTurma()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new MenuAluno().ShowDialog();
            this.Hide();
        }
    }
}
