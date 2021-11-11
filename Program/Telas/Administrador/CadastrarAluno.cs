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
            

                mDataSet = new DataSet();


            //define string de conexao e cria a conexao

            mConn = new MySqlConnection(" Persist Security Info=False;server=localhost;database=Cadastro;uid=root;server = localhost; database = Cadastro; uid = root; pwd = xxxx");


      try
            {

                //abre a conexao

                mConn.Open();

            }

            catch (System.Exception e)

            {

                MessageBox.Show(e.Message.ToString());

            }



            //verificva se a conexão esta aberta

            if (mConn.State == ConnectionState.Open)

            {

                //cria um adapter usando a instrução SQL para acessar a tabela Clientes

                mAdapter = new MySqlDataAdapter("SELECT * FROM Clientes", mConn);

                //preenche o dataset via adapter

                mAdapter.Fill(mDataSet, "Clientes");

                //atribui a resultado a propriedade DataSource do DataGrid


            }

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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var menuAdministrador = new MenuAdministrador();
            menuAdministrador.ShowDialog();
        }
    }
}
