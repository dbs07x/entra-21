using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio12
    {
        public void Executar()
        {
            //Solicite o ano de nascimento do usuário e apresente ao final a idade do mesmo

            Console.WriteLine("Informe o ano de seu nascimento: ");
            int anoNascimento = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Sua idade é: " + (DateTime.Now.Year - anoNascimento) + " anos");
        }
    }
}
