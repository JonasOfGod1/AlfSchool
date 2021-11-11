using Program.Models.Professor;
using Program.Services;
using Program.Telas.Administrador;
using System;
using System.Windows.Forms;

namespace Program.Telas
{
    public partial class CadastrarProfessor : Form
    {
        public CadastrarProfessor()
        {
            InitializeComponent();
        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            var professorService = new ProfessorService();

            var professorRequest = new ProfessorRequestModel()
            {
                Nome = txtNomeProfessor.Text,
                Materia = cbbMateriaProfessor.Text,
                Cpf = txtCpfProfessor.Text,
                Senha = txtSenhaProfessor.Text,
                Sala = cbbSalaProfessor.Text,
                Tipo = "Professor"
            };

            professorService.Create(professorRequest);

            txtNomeProfessor.Text = "";
            txtCpfProfessor.Text = "";
            txtSenhaProfessor.Text = "";
            cbbMateriaProfessor.Text = "";
            cbbSalaProfessor.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var menuAdministrador = new MenuAdministrador();
            menuAdministrador.ShowDialog();
        }
    }
}
