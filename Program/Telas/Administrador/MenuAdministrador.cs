using System;
using System.Windows.Forms;

namespace Program.Telas.Administrador
{
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void btnCadastrarAdministrador_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var cadastrarAdministrador = new Form1();
            cadastrarAdministrador.ShowDialog();
        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var cadastrarProfessor = new CadastrarProfessor();
            cadastrarProfessor.ShowDialog();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var cadastrarAluno = new CadastrarAluno();
            cadastrarAluno.ShowDialog();
        }
    }
}
