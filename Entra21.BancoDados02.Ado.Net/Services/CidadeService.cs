using Entra21.BancoDados02.Ado.Net.DataBase;
using Entra21.BancoDados02.Ado.Net.Models;
using System.Data;

namespace Entra21.BancoDados02.Ado.Net.Services
{
    internal class CidadeService : ICidadeService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM cidades WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Cidade cidade)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"INSERT INTO cidades (id_unidade_federativa, nome, quantidade_habitantes, data_hora_fundacao, pib) 
VALUES (@ID_UNIDADE_FEDERATIVA, @NOME, @QUANTIDADE_HABITANTES, @DATA_HORA_FUNDACAO, @PIB);";

            comando.Parameters.AddWithValue("@ID_UNIDADE_FEDERATIVA", cidade.UnidadeFederativa.Id);
            comando.Parameters.AddWithValue("@NOME", cidade.Nome);
            comando.Parameters.AddWithValue("@QUANTIDADE_HABITANTES", cidade.QuantidadeHabitantes);
            comando.Parameters.AddWithValue("@DATA_HORA_FUNDACAO", cidade.DataHoraFundacao);
            comando.Parameters.AddWithValue("@PIB", cidade.Pib);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(Cidade cidade)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"UPDATE cidades SET id_unidade_federativa = @ID_UNIDADE_FEDERATIVA, nome = @NOME, 
quantidade_habitantes = @QUANTIDADE_HABITANTES, data_hora_fundacao = @DATA_HORA_FUNDACAO, pib = @PIB WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", cidade.Id);
            comando.Parameters.AddWithValue("@ID_UNIDADE_FEDERATIVA", cidade.UnidadeFederativa.Id);
            comando.Parameters.AddWithValue("@NOME", cidade.Nome);
            comando.Parameters.AddWithValue("@QUANTIDADE_HABITANTES", cidade.QuantidadeHabitantes);
            comando.Parameters.AddWithValue("@DATA_HORA_FUNDACAO", cidade.DataHoraFundacao);
            comando.Parameters.AddWithValue("@PIB", cidade.Pib);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Cidade ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, id_unidade_federativa, nome, quantidade_habitantes, data_hora_fundacao, pib FROM cidades WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());
            if (dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];
            var cidade = new Cidade();
            cidade.Id = Convert.ToInt32(registro["id"]);

            cidade.UnidadeFederativa = new UnidadeFederativa();
            cidade.UnidadeFederativa.Id = Convert.ToInt32(registro["id_unidade_federativa"]);

            cidade.Nome = registro["nome"].ToString();

            conexao.Close();

            return cidade;
        }

        public List<Cidade> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"..."; // <<<
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var cidades = new List<Cidade>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var cidade = new Cidade();
                cidade.Id = Convert.ToInt32(registro["id"]);
                cidade.Nome = registro["nome"].ToString();

                cidades.Add(cidade);
            }
            return cidades;
        }
    }
}
