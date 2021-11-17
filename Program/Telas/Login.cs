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
                this.Hide();
                new MenuAdministrador().Show();
                
            }
            else if (professor != null)
            {
                this.Hide();
                new MenuProfessor().ShowDialog();
                new MenuProfessor()
            }
            else if (aluno != null)
            {
                this.Hide();
                new MenuAluno().ShowDialog();
            }
            else
            {
                lblErro.Text = "CPF ou Senha inválido(s)";
                txtCpf.Text = "";
                txtSenha.Text = "";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
