using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio02
    {
        public void Executar()
        {
            //Crie um vetor para guardar 10 nomes e apresente os dez nomes

            var nomes = new string[10];
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nome: ");
                nomes[i] = Console.ReadLine().Trim();
            }

            Console.Clear();
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
