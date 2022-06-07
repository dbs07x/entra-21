using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.EexerciciosLista
{
    internal class Exercicio03
    {
        public void Executar()
        {
            /*3. Criar uma classe que irá as notas:
            a. Solicitar a nota 1
            b. Solicitar a nota 2
            c. Solicitar a nota 3
            d. Listar notas
            e. Apresentar média das notas
            f. Apresentar status da média*/

            List<double> notas = new List<double>();

            //a.Solicitar a nota 1
            Console.Write("a. Nota 1: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));

            //b.Solicitar a nota 2
            Console.Write("b. Nota 2: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));

            //c.Solicitar a nota 3
            Console.Write("c. Nota 3: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();

            //d.Listar notas
            Console.WriteLine("d. Notas armazenados em suas respectivas posições:" +
            "\n[0]: " + notas[0] +
            "\n[1]: " + notas[1] +
            "\n[2]: " + notas[2]);
            Console.WriteLine();

            //e.Apresentar média das notas
            var media = (notas[0] + notas[1] + notas[2]) / 3;
            Console.WriteLine("e. Média: " + media);

            //f.Apresentar status da média
            if (media >= 7)
            {
                Console.WriteLine("f. Aprovado");
            }
            else if (media > 5 )
            {
                Console.WriteLine("f. Em Exame");
            }
            else
            {
                Console.WriteLine("f. Reprovado");
            }
        }
    }
}
