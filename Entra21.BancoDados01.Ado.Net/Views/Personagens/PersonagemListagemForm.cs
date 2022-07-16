using Entra21.BancoDados01.Ado.Net.Models;
using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.Personagens
{
    public partial class PersonagemListagemForm : Form
    {
        public PersonagemListagemForm()
        {
            InitializeComponent();

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if(comboBoxEditora.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma editora");
                return;
            }

            if(comboBoxTipoPersonagem.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um tipo de personagem");
                return;
            }

            var nome = textBoxNome.Text.Trim();
            var tipoPersonagem = comboBoxTipoPersonagem.SelectedItem as
                TipoPersonagem;
            var editora = comboBoxEditora.SelectedItem as Editora;

            var personagem = new Personagem();
            personagem.Nome = nome;
            personagem.TipoPersonagem = tipoPersonagem;
            personagem.Editora = editora;

            // Persistir o que o usuário escolheu na tabela de personagens
            var personagemService = new PersonagemService();
            personagemService.Cadastrar(personagem);

            MessageBox.Show("Personagem cadastrado com sucesso");
            Close();
        }
    }
}
