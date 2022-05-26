using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio08
    {
        public void Executar()
        {
            //Solicite um número e apresentar a tabuada do mesmo até 1000

            Console.WriteLine("Informe um número: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            int indice = 0;

            Console.Clear();
            while (indice < 1000)
            {
                indice = indice + 1;
                double resultado = numero * indice;
                Console.WriteLine(numero + " x " + indice + " = " + resultado);
            }
        }
    }
}
