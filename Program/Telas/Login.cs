using Program.Services;
using Program.Telas.Administrador;
using Program.Telas.Aluno;
using Program.Telas.Professor;
using System;
using System.Windows.Forms;

namespace Program.Telas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            var admService = new AdministradorService();
            var professorService = new ProfessorService();
            var alunoService = new AlunoService();

            var administrador = admService.Autenticar(txtCpf.Text, txtSenha.Text);
            var professor = professorService.Autenticar(txtCpf.Text, txtSenha.Text);
            var aluno = alunoService.Autenticar(txtCpf.Text, txtSenha.Text);

            if (administrador != null)
            {
                new MenuAdministrador().Show();
                this.Hide();
            }
            else if (professor != null)
            {
                new MenuProfessor().ShowDialog();
                this.Hide();
            }
            else if (aluno != null)
            {
                new MenuAluno().ShowDialog();
                this.Hide();
            }
            else
            {
                lblErro.Text = "CPF ou Senha inválido(s)";
                txtCpf.Text = "";
                txtSenha.Text = "";
            }
        }
    }
}
