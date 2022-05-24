using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio11
    {
        public void Executar()
        {
            /*
            Solicite dois números e inverta os valores destas variáveis
            Exemplo:
            número 1: 29
            número 2: 32
            Após a inversão a variável número 1 terá o valor 32 e a variável número 2 terá o valor 29
            */

            Console.WriteLine("Informe o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double x = numero1;
            numero1 = numero2;

            Console.WriteLine("O primeiro número é: " + numero1);
            Console.WriteLine("O segundo número é: " + x);
        }
    }
}
