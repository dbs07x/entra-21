using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio06
    {
        public void Executar()
        {
            /*Solicite o nome, valor e a quantidade de produtos, enquanto o nome for diferente de sair,
            ao final deve-se aplicar ao valor total da compra um desconto de 5%*/

            string nomeProduto = "";
            double total = 0;

            while (nomeProduto != "sair")
            {
                Console.WriteLine("Nome do produto: ");
                nomeProduto = Console.ReadLine().ToLower().Trim();

                if (nomeProduto != "sair")
                {
                    Console.WriteLine("Valor do produto: ");
                    double valorProduto = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Quantidade do produto: ");
                    int quantidadeProduto = Convert.ToInt32(Console.ReadLine());

                    total = total + (valorProduto * quantidadeProduto);
                }
            }
            Console.Clear();
            double totalComDesconto = total * 0.95;
            Console.WriteLine("O valor total da compra com 5% de desconto é de: R$" + totalComDesconto);
        }
    }
}
