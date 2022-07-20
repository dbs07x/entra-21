﻿using System.Data.SqlClient;

namespace Entra21.BancoDados01.Ado.Net.DataBase
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {
            // Instanciando um objeto da classe SqlConnection, que permitirá fazer selects, inserts, updates, deletes, etc...
            SqlConnection conexao = new SqlConnection();

            // string que contém o caminho para o banco de dados, o que permitirá conectar ao banco de dados
            var connectionString = @"";

            // Definir o caminho da conexão para o SqlConnection
            conexao.ConnectionString = connectionString;

            // Abrir a conexão com o banco de dados
            conexao.Open();

            return conexao;
        }
    }
}
