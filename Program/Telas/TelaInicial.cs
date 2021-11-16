using System;
using System.Windows.Forms;

namespace Program.Telas
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
