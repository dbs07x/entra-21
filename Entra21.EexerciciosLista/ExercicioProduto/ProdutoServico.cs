﻿namespace Entra21.ExerciciosLista
{
    internal class ProdutoServico
    {
        // encapsulamento + tipoRetorno + NomeMetodo(parametros) -> assinatura
        // o que fica entre as {} é o corpo do método
        private List<Produto> produtos = new List<Produto>();
        // Armazenar o código do próximo produto
        private int codigoAtual = 1;

        public void Adicionar(string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            // Instanciar um objeto da classe Produto
            Produto produto = new Produto();

            // Atribuir valor para as propriedades com os dados passados como parametro
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            // Atribuir o código novo para o objeto do produto
            produto.Codigo = codigoAtual;

            // Adicionar 1 no código atual para quando criar novo produto o produto conter outro código
            codigoAtual = codigoAtual + 1;

            // Adicionar o produto instanciado na lista de produtos
            produtos.Add(produto);
        }
        public bool Editar(
        int codigoParaAlterar,
        string nome,
        double precoUnitario,
        ProdutoLocalizacao localizacao,
        int quantidade)
        {
            // Obter o produto desejado da lista de produto
            Produto produtoParaAlterar = ObterPorCodigo(codigoParaAlterar);

            // Verificar se não foi possível encontrar o produto
            if (produtoParaAlterar == null)
            {
                // Retorno falso pq não existe produto com o código dos parâmetros
                return false;
            }

            // Atualiza as propriedades (campos) do produto desejado
            produtoParaAlterar.Nome = nome;
            produtoParaAlterar.Localizacao = localizacao;
            produtoParaAlterar.PrecoUnitario = precoUnitario;
            produtoParaAlterar.Quantidade = quantidade;

            //Retorna verdadeiro pq foi possível alterar o produto
            return true;

        }
        public bool Apagar(int codigo)
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                // Resgatando de uma lista de tipos primitivos
                // int numero  = numeros[i]

                // Resgatando de uma lista de objetos
                Produto produto = produtos[i];
                if (produto.Codigo == codigo)
                {
                    // Posso remover com o indice do objeto desejado
                    // produtos.RemoveAt(i);

                    // Posso remover com o objeto desejado
                    produtos.Remove(produto);
                    // Retorna verdadeiro pq o produto com o código desejado foi removido da lista
                    return true;
                }
            }
            // Retorna falso pq não foi encontrado produto com o código desejado, ou seja, nenhum elemento foi removido da lista
            return false;
        }
        public List<Produto> ObterTodos()
        {
            return produtos;
        }

        public Produto ObterPorCodigo(int codigo)
        {
            // Percorrer todos os elementos para encontrar o produto
            // Filtrando por código
            for (int i = 0; i < produtos.Count; i++)
            {
                // Obter o produto da lista de produtos em determinado indice
                var produtoAtual = produtos[i];

                // Verifica se o produto atual da lista percorrida é o desejado
                if (produtoAtual.Codigo == codigo)
                {
                    // Retorno o produto encontrado
                    return produtoAtual;
                }
            }

            // Retorna null, caso não encontre um produto com o código passado como parâmetro
            return null;
        }
    }
}
