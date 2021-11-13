using Program.Models.Administrador;
using Program.Services;
using Program.Telas.Administrador;
using System;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrarAdministrador_Click(object sender, EventArgs e)
        {
            var admService = new AdministradorService();

            var admRequest = new AdministradorRequestModel()
            {
                Nome = txtNomeAdministrador.Text,
                Cpf = txtCpfAdministrador.Text,
                Senha = txtSenhaAdministrador.Text,
                Tipo = "Administrador"
            };

            try
            {
                admService.Create(admRequest);

                txtNomeAdministrador.Text = "";
                txtCpfAdministrador.Text = "";
                txtSenhaAdministrador.Text = "";

                lblErrorOrSucess.Text = "Administrador cadastrado com sucesso.";
            }
            catch (Exception)
            {
                lblErrorOrSucess.Text = "Alguma informação está incorreta!";
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
