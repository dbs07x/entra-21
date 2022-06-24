﻿using Newtonsoft.Json;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class EnderecosForm : Form
    {
        private EnderecoServico enderecoServico;
        private PacienteServico pacienteServico;

        // Construtor: construir o objeto que está sendo instanciado com as devidas
        // informações ou rotinas
        public EnderecosForm()
        {
            InitializeComponent();

            enderecoServico = new EnderecoServico();

            // Instanciado o objeto de PacienteServico o permitirá listar os
            // pacientes no ComboBox e decorrente disso será possível o usuário selecionar o mesmo
            pacienteServico = new PacienteServico();

            // Deve apresentar os dados quando a tela for carregada
            PreencherDataGridViewComEnderecos();

            // Irá preencher o ComboBox (campo de seleção) com os pacientes
            PreencherComboBoxComOsNomesDosPacientes();
        }

        private void PreencherComboBoxComOsNomesDosPacientes()
        {
            // Obter lista dos pacientes que foram cadastrados, ou seja, armazenados no JSON
            var pacientes = pacienteServico.ObterTodos();

            // Percorrer todos os pacientes adicionando no ComboBox
            for (int i = 0; i < pacientes.Count; i++)
            {
                var paciente = pacientes[i];
                comboBoxPaciente.Items.Add(paciente.Nome);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            maskedTextBoxCep.Text = "";
            textBoxEnderecoCompleto.Text = "";
            comboBoxPaciente.SelectedIndex = -1;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter os dados preenchidos pelo usuário armazenado em variáveis
            var cep = maskedTextBoxCep.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;
            var nomePaciente = Convert.ToString(comboBoxPaciente.SelectedItem);

            // Construir o objeto de endereço com as variáveis
            var endereco = new Endereco();
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Paciente = pacienteServico.ObterPorNomePaciente(nomePaciente);

            // Salvar este endereço na lista de endereços e no arquivo JSON
            enderecoServico.Adicionar(endereco);

            // Apresentar o registro novo no DataGridView
            PreencherDataGridViewComEnderecos();
        }

        private void PreencherDataGridViewComEnderecos()
        {
            // Obter todos os endereços da lista de endereços
            var enderecos = enderecoServico.ObterTodos();

            // Remover todas as linhas do dataGridView
            dataGridView1.Rows.Clear();

            // Remover a seleção do dataGridView
            dataGridView1.ClearSelection();

            // Percorrer cada um dos endereços adicionando uma nova linha na tabela
            for(var i = 0; i < enderecos.Count; i++)
            {
                // Obter endereço percorrido
                var endereco = enderecos[i];

                dataGridView1.Rows.Add(new object[]
                {
                    endereco.Codigo,
                    endereco.EnderecoCompleto,
                    endereco.Cep,
                    endereco.Paciente.Nome
                });
            }
        }

        public void ObterDadosCep()
        {
            var cep = maskedTextBoxCep.Text.Replace("-", "");

            // HttpClient permite fazer requisição para obter ou enviar dados para outros sistemas
            var httpClient = new HttpClient();

            // Executando a requisição para o site ViaCep para obter os dados do endereço do cep
            var resultado = httpClient.GetAsync(
                $"http://viacep.com.br/ws/{cep}/json/").Result;

            // Verificar se a requisição deu certo
            if (resultado.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // Obter a resposta da requisição
                var resposta = resultado.Content.ReadAsStringAsync().Result;

                var dadosEndereco = JsonConvert.DeserializeObject<EnderecoDadosRequisicao>(resposta);

                textBoxEnderecoCompleto.Text =
                    $"{dadosEndereco.Uf} - {dadosEndereco.Localidade} - {dadosEndereco.Bairro} - {dadosEndereco.Logradouro}";
            }
        }
    }
}
