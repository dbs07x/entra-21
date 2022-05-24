using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio07
    {
        public void Executar()
        {
            //Solicite a altura de 4 animais, apresente ao final a altura do animal com a menor altura

            var alturas = new double[4];
            for (int i = 0; i < alturas.Length; i++)
            {
                Console.WriteLine("Altura do animal " + (i+1) + " em metros: ");
                alturas[i] = Convert.ToDouble(Console.ReadLine());
            }

            var menorAltura = double.MaxValue;
            for (int i = 0; i < alturas.Length; i++)
            {
                if (alturas[i] < menorAltura)
                {
                    menorAltura = alturas[i];
                }
            }

            Console.Clear();
            Console.WriteLine("O animal com menor altura tem " + menorAltura + " metros");
        }
    }
}
