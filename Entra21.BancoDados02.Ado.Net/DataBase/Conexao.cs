using System.Data.SqlClient;

namespace Entra21.BancoDados02.Ado.Net.DataBase
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {
            SqlConnection conexao = new SqlConnection();

            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Douglas\Documents\Teste.mdf;Integrated Security=True;Connect Timeout=30";

            conexao.ConnectionString = connectionString;

            conexao.Open();

            return conexao;
        }
    }
}
