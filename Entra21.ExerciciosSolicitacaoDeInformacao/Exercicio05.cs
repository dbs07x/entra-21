using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio05
    {
        public void Executar()
        {
            //Solicite um número para o usuário e apresente ao final seu antecessor e o sucessor

            Console.WriteLine("Informe um número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("O número antecessor do número informado é: " + (numero - 1));
            Console.WriteLine("O número sucessor do número informado é: " + (numero + 1));
        }
    }
}
