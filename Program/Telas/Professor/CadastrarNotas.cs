using Program.Models.Nota;
using Program.Services;
using System;
using System.Windows.Forms;

namespace Program.Telas.Professor
{
    public partial class CadastrarNotas : Form
    {
        public CadastrarNotas()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var notaService = new NotaService();

            try
            {
                var requestModel = new NotaRequestModel()
                {
                    Valor = Convert.ToDouble(txtNota.Text)
                };

                if (cbbAluno.Text != "")
                {
                    notaService.Create(requestModel);

                    cbbAluno.Text = "";
                    txtNota.Text = "";

                    lblErrorOrSucess.Text = "Nota Cadastrada com sucesso.";
                }
                else
                {
                    lblErrorOrSucess.Text = "Alguma informação está incorreta!";
                }
            }
            catch (Exception)
            {
                lblErrorOrSucess.Text = "Alguma informação está incorreta!";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new MenuProfessor().ShowDialog();
            this.Hide();
        }
    }
}
