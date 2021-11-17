using System;
using System.Windows.Forms;

namespace Program.Telas.Professor
{
    public partial class CadastrarFaltas : Form
    {
        public CadastrarFaltas()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuProfessor().Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var faltas = Convert.ToInt32(txtFaltas.Text);

                if (cbbAluno.Text != "" && (faltas > 0 && faltas < 6))
                {
                    cbbAluno.Text = "";
                    txtFaltas.Clear();

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
    }
}
