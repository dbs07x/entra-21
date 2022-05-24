using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio09
    {
        public void Executar()
        {
            /*
            Solicitar nome do carro, valor do carro, valor de cada parcela e a quantidade de meses em que o carro foi financiado, ao final deve ser apresentado:
            a. Nome do carro
            b. Valor do carro
            c. Valor de cada parcela
            d. Quantidade de parcelas
            e. Valor total do financiamento
            f. Diferença entre o valor total do financiamento e valor do carro
            */

            Console.WriteLine("Informe o nome do carro: ");
            string nomeCarro = Console.ReadLine();

            Console.WriteLine("Informe o valor do carro: ");
            double valorCarro = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor de cada parcela: ");
            double valorParcela = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de parcelas: ");
            double quantidadeParcelas = Convert.ToDouble(Console.ReadLine());

            double valorTotalFinanciamento = valorParcela * quantidadeParcelas;

            Console.Clear();
            Console.WriteLine("Nome do carro: " + nomeCarro);
            Console.WriteLine("Valor do carro: R$" + valorCarro);
            Console.WriteLine("Valor de cada parcela: R$" + valorParcela);
            Console.WriteLine("Quantidade de parcelas: " + quantidadeParcelas);
            Console.WriteLine("Valor total do financimento: R$" + valorTotalFinanciamento);
            Console.WriteLine("A diferença entre o valor total do financiamento e o valor do carro é de: R$" + (valorTotalFinanciamento - valorCarro));
        }
    }
}
