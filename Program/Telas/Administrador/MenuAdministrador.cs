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
            new Form1().Show();
            this.Hide();
        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            new CadastrarProfessor().Show();
            this.Hide();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            new CadastrarAluno().Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
