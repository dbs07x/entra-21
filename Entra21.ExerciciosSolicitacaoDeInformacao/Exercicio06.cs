using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio06
    {
        public void Executar()
        {
            /*
            Calcule a quantidade de litros de água ingeridos em determinado período e o valor
            pago. Para tal deve-se solicitar ao usuário a média da quantidade de litros ingeridos
            por dia, a quantidade de anos e o valor pago pela água
            Exemplo:
            Quantidade de litros: 3
            Quantidade de anos consumidos: 17
            Valor por Litro: R$ 9.75
            Quantidade de Litros consumidos: 18.615 L
            Valor Total Pago: R$ 181.496, 25
            */

            Console.WriteLine("Informe a quantidade de água ingerida por dia em litros: ");
            double agua = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe em quantos anos foi realizado esse consumo de água: ");
            double anos = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor pago pelo litro da água em R$: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            double quantidadeAgua = (agua * 365) * anos;
            Console.WriteLine("A quantidade de água consumida no período de " + anos + " " + "ano(s) foi de: " + quantidadeAgua + " litros");

            double valorPago = quantidadeAgua * preco;
            Console.WriteLine("O valor total pago por " + quantidadeAgua + " litros de água durante " + anos + " ano(s) foi de: R$" + valorPago);
        }
    }
}
