using Entra21.BancoDados02.Ado.Net.Views.Cidades;
using Entra21.BancoDados02.Ado.Net.Views.UnidadesFederativas;

namespace Entra21.BancoDados02.Ado.Net.Views
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void buttonUf_Click(object sender, EventArgs e)
        {
            var ufForm = new UnidadeFederativaListagemForm();
            ufForm.ShowDialog();
        }

        private void buttonCidade_Click(object sender, EventArgs e)
        {
            var cidadeForm = new CidadeListagemForm();
            cidadeForm.ShowDialog();
        }
    }
}
