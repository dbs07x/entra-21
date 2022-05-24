using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio02
    {
        public void Executar()
        {
            //Solicite o nome e sobrenome e apresente o nome completo

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Nome completo: " + nome + " " + sobrenome);
        }
    }
}
