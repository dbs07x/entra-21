﻿using Entra21.BancoDados01.Ado.Net.Views.Personagens;
using Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens;

namespace Entra21.BancoDados01.Ado.Net.Views
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void buttonEditoras_Click(object sender, EventArgs e)
        {

        }

        private void buttonPersonagens_Click(object sender, EventArgs e)
        {
            var personagemForm = new PersonagemListagemForm();
            personagemForm.ShowDialog();
        }

        private void buttonTipoPersonagens_Click(object sender, EventArgs e)
        {
            var tipoPersonagem = new TipoPersonagemListagemForm();
            tipoPersonagem.ShowDialog();
        }
    }
}
