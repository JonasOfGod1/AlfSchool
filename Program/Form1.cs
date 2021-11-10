using Program.Models.Administrador;
using Program.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum TipoUsuario {Aluno, Professor, Administrador};

        private void btnCadastrarAdministrador_Click(object sender, EventArgs e)
        {
            var usuarioService = new UsuarioService();
            var tipo = new TipoUsuario();

            if (cbbTipoUsuario.Text == "Aluno")
            {
                tipo = TipoUsuario.Aluno;
            }
            else if (cbbTipoUsuario.Text == "Professor")
            {
                tipo = TipoUsuario.Professor;
            }
            else if (cbbTipoUsuario.Text == "Administrador")
            {
                tipo = TipoUsuario.Administrador;
            }

            var admRequest = new UsuarioRequestModel()
            {
                Nome = txtNomeUsuario.Text,
                Cpf = txtCpfUsuario.Text,
                Senha = txtSenhaUsuario.Text,
                Tipo = tipo.ToString()
            };

            usuarioService.Create(admRequest);
        }
    }
}
