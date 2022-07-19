using System.Data.SqlClient;

namespace Entra21.BancoDados02.Ado.Net.DataBase
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {
            SqlConnection conexao = new SqlConnection();

            var connectionString = @"...";

            conexao.ConnectionString = connectionString;

            conexao.Open();

            return conexao;
        }
    }
}
