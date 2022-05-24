using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio08
    {
        public void Executar()
        {
			/* Desenvolver um algoritmo que solicite quatro notas e apresente a média ao final.
            Exemplo:
            Nota 01: 9,75
            Nota 02: 10,00
            Nota 03: 4,42
            Nota 04: 5,00
            Média: 7,2925
            */

			Console.WriteLine("Informe a nota 1: ");
			double nota1 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Informe a nota 2: ");
			double nota2 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Informe a nota 3: ");
			double nota3 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Informe a nota 4: ");
			double nota4 = Convert.ToDouble(Console.ReadLine());

			Console.Clear();
			Console.WriteLine("Nota 1 : " + nota1);
			Console.WriteLine("Nota 2 : " + nota2);
			Console.WriteLine("Nota 3 : " + nota3);
			Console.WriteLine("Nota 4 : " + nota4);

			double media = (nota1 + nota2 + nota3 + nota4) / 4;
			Console.WriteLine("Média: " + media);
		}
    }
}
