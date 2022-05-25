using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio05
    {
        public void Executar()
        {
            /*Faça um programa que solicite a quantidade de carros que o usuário deseja
            cadastrar, após isto solicite para o usuário o modelo, valor e ano do carro até que
            atinja a quantidade de carros para cadastro
            Apresente ao final:
            - Média do ano dos carros
            - Média do valor dos carros
            - Quantidade de carros que começam com a letra G
            - Quantidade de carros que começam com a letra A*/

            int carrosCadastrados = 0;
            int totalAnoCarros = 0;
            double totalValorCarros = 0;
            int carrosLetraG = 0;
            int carrosLetraA = 0;

            Console.WriteLine("Quantidade de carros que será cadastrada: ");
            int quantidadeCarros = Convert.ToInt32(Console.ReadLine());

            while (carrosCadastrados < quantidadeCarros)
            {
                Console.WriteLine("Informe o modelo do carro: ");
                string modeloCarro = Console.ReadLine().ToLower().Trim();

                if (modeloCarro.StartsWith("g"))
                {
                    carrosLetraG = carrosLetraG + 1;
                }

                if (modeloCarro.StartsWith("a"))
                {
                    carrosLetraA = carrosLetraA + 1;
                }

                Console.WriteLine("Informe o valor do carro: ");
                double valorCarro = Convert.ToDouble(Console.ReadLine());
                totalValorCarros = totalValorCarros + valorCarro;

                Console.WriteLine("Informe o ano do carro: ");
                int anoCarro = Convert.ToInt32(Console.ReadLine());
                totalAnoCarros = totalAnoCarros + anoCarro;

                carrosCadastrados = carrosCadastrados + 1;
            }

            Console.Clear();
            Console.WriteLine("Média do ano dos carros: " + totalAnoCarros / quantidadeCarros);
            Console.WriteLine("Média do valor dos carros: " + totalValorCarros / quantidadeCarros);
            Console.WriteLine("Quantidade de carros que começam com a letra G: " + carrosLetraG);
            Console.WriteLine("Quantidade de carros que começam com a letra A: " + carrosLetraA);
        }
    }
}
