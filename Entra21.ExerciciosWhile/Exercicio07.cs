using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio07
    {
        public void Executar()
        {
            /*Solicite o nome, valor, quantidade enquanto a quantidade de produtos for menor que 5
            Ao final deve-se aplicar um desconto de R$ 150,00*/

            int quantidadeProdutos = 0;
            double total = 0;

            while (quantidadeProdutos < 5)
            {
                Console.WriteLine("Nome do produto: ");
                string nomeProduto = Console.ReadLine().Trim();

                Console.WriteLine("Valor: ");
                double valor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Quantidade: ");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                total = total + (valor * quantidade);
                quantidadeProdutos = quantidadeProdutos + 1;
            }

            Console.Clear();
            double totalComDesconto = total - 150;
            Console.WriteLine("Valor total com desconto de R$150,00: R$" + totalComDesconto);
        }
    }
}
