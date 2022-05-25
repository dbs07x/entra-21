using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio01
    {
        public void Executar()
        {
            //Solicite o preço e nome da peça de 13 peças

            int indice = 0;
            string nome = "";
            double preco = 0;

            while (indice < 13)
            {
                Console.WriteLine("Nome da peça: ");
                nome = Console.ReadLine().Trim();

                Console.WriteLine("Preço da peça: ");
                preco = Convert.ToDouble(Console.ReadLine());

                indice = indice + 1;
            }
        }
    }
}
