using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio09
    {
        public void Executar()
        {
            //Solicite um número e faça o fatorial deste número, utilizando while

            Console.WriteLine("Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int indice = numero;
            int numeroSolicitado = numero;

            while (indice > 1)
            {
                indice = indice - 1;
                numero = numero * indice;
            }

            Console.Clear();
            Console.WriteLine("Fatorial de " + numeroSolicitado + ":" + numero);
        }
    }
}
