using Program.Models.Aluno;
using Program.Services;
using System;
using System.Windows.Forms;

namespace Program.Telas
{
    public partial class CadastrarAluno : Form
    {
        public CadastrarAluno()
        {
            InitializeComponent();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            var alunoService = new AlunoService();

            var alunoRequest = new AlunoRequestModel()
            {
                Nome = txtNomeAluno.Text,
                Cpf = txtCpfAluno.Text,
                Senha = txtSenhaAluno.Text,
                Sala = cbbSalaAluno.Text,
                Tipo = "Aluno"
            };

            alunoService.Create(alunoRequest);

            txtNomeAluno.Text = "";
            txtCpfAluno.Text = "";
            txtSenhaAluno.Text = "";
            cbbSalaAluno.Text = "";
        }
    }
}
