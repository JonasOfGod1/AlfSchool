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
            this.Hide();
            new Form1().Show();
        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CadastrarProfessor().Show();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CadastrarAluno().Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
