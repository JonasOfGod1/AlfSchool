using Program.Models.Administrador;
using Program.Services;
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

            admService.Create(admRequest);

            txtNomeAdministrador.Text = "";
            txtCpfAdministrador.Text = "";
            txtSenhaAdministrador.Text = "";
        }
    }
}
