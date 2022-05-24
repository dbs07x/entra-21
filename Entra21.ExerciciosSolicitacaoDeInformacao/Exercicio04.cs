using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio04
    {
        public void Executar()
        {
            /* Solicitar dois números inteiros e apresentar:
            a. A soma dos valores
            b. A subtração dos valores
            c. A multiplicação dos valores
            d. A divisão dos valores
            */

            Console.WriteLine("Informe um número inteiro: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe outro número inteiro: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A soma dos valores é: " + (numero1 + numero2));
            Console.WriteLine("A subtração dos valores é: " + (numero1 - numero2));
            Console.WriteLine("A multiplicação dos valores é: " + (numero1 * numero2));
            Console.WriteLine("A divisão dos valores é: " + (numero1 / numero2));
        }
    }
}
