using System;
using System.Windows.Forms;

namespace Program.Telas.Professor
{
    public partial class VisualizarTurma : Form
    {
        public VisualizarTurma()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var menuProfessor = new MenuProfessor();
            menuProfessor.ShowDialog();
        }
    }
}
