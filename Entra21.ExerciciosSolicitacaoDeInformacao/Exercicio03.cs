using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio03
    {
        public void Executar()
        {
            // Solicite a altura e peso e apresente o IMC desta pessoa. Fórmula IMC: peso / altura²

            Console.WriteLine("Informe seu Peso (kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe sua Altura(m): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.Clear();
            Console.WriteLine("Seu IMC é de: " + imc);
        }
    }
}
