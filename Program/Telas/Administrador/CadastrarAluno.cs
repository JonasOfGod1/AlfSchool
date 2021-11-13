using MySqlConnector;
using Program.Models.Aluno;
using Program.Services;
using Program.Telas.Administrador;
using System;
using System.Data;
using System.Windows.Forms;

namespace Program.Telas
{
    public partial class CadastrarAluno : Form
    {

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

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

            try
            {
                alunoService.Create(alunoRequest);

                txtNomeAluno.Text = "";
                txtCpfAluno.Text = "";
                txtSenhaAluno.Text = "";
                cbbSalaAluno.Text = "";

                lblErroOrSucess.Text = "Aluno Cadastrado com sucesso.";
            }
            catch (Exception)
            {
                lblErroOrSucess.Text = "Alguma informação está incorreta!";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var menuAdministrador = new MenuAdministrador();
            menuAdministrador.ShowDialog();
        }
    }
}
