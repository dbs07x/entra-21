using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.EexerciciosLista
{
    internal class Exercicio01
    {
        public void Executar()
        {
            /*1. Criar uma classe que irá armazenar os melhores filmes de todos os tempos.
            a. Adicionar o filme "Dragon Ball Evollution";
            b. Adicionar o filme "Titanic";
            c. Adicionar o filme "Lanterna verde";
            d. Listar os filmes armazenados na lista;
            e. Adicionar o filme "";
            f. Alterar o filme "Dragon Ball Evollution" para "Dragon Ball Super: Broly”;
            g. Remover filme "Lanterna verde";
            h. Verificar se a lista contém o filme "Lanterna verde" apresentando para o
            usuário se está ou não cadastrado;
            i. Adicionar o filme "Quarteto fantástico";
            j. Listar os filmes armazenados na lista;
            k. Alterar o filme "Titanic" para “Titanic 2”;
            l. Listar os filmes armazenados na lista;
            m. Verificar se filme "A Lagoa Azul” existe na lista, informando para o usuário*/

            List<string> filmes = new List<string>();

            //a. Adicionar o filme "Dragon Ball Evollution";
            filmes.Add("Dragon Ball Evollution");

            //b. Adicionar o filme "Titanic";
            filmes.Add("Titanic");

            //c. Adicionar o filme "Lanterna verde";
            filmes.Add("Lanterna Verde");

            //d. Listar os filmes armazenados na lista;
            Console.WriteLine("d. Filmes armazenados em suas respectivas posições:" +
            "\n[0]: " + filmes[0] +
            "\n[1]: " + filmes[1] +
            "\n[2]: " + filmes[2]);
            Console.WriteLine();

            //e. Adicionar o filme "";
            filmes.Add("");

            //f. Alterar o filme "Dragon Ball Evollution" para "Dragon Ball Super: Broly”;
            var indiceDragonBallEvollution = filmes.IndexOf("Dragon Ball Evollution");
            filmes[indiceDragonBallEvollution] = "Dragon Ball Super: Broly";

            //g. Remover filme "Lanterna verde";
            var indiceLanternaVerde = filmes.IndexOf("Lanterna Verde");
            filmes.RemoveAt(indiceLanternaVerde);

            //h. Verificar se a lista contém o filme "Lanterna verde" apresentando para o usuário se está ou não cadastrado;
            var contemLanternaVerde = filmes.Contains("Lanterna Verde");
            if (contemLanternaVerde == true)
            {
                Console.WriteLine("h. O filme está cadastrado");
            }
            else
            {
                Console.WriteLine("h. O filme não está cadastrado");
            }
            Console.WriteLine();

            //i. Adicionar o filme "Quarteto fantástico";
            filmes.Add("Quarteto Fantástico");

            //j. Listar os filmes armazenados na lista;
            Console.WriteLine("j. Filmes armazenados em suas respectivas posições:" +
            "\n[0]: " + filmes[0] +
            "\n[1]: " + filmes[1] +
            "\n[2]: " + filmes[2] +
            "\n[3]: " + filmes[3]);
            Console.WriteLine();

            //k. Alterar o filme "Titanic" para “Titanic 2”;
            var indiceTitantic = filmes.IndexOf("Titanic");
            filmes[indiceTitantic] = "Titanic 2";

            //l. Listar os filmes armazenados na lista;
            Console.WriteLine("l. Filmes armazenados em suas respectivas posições:" +
            "\n[0]: " + filmes[0] +
            "\n[1]: " + filmes[1] +
            "\n[2]: " + filmes[2] +
            "\n[3]: " + filmes[3]);
            Console.WriteLine();

            //m. Verificar se filme "A Lagoa Azul” existe na lista, informando para o usuário
            var contemLagoaAzul = filmes.Contains("A Lagoa Azul");
            if (contemLagoaAzul == true)
            {
                Console.WriteLine("m. O filme está cadastrado");
            }
            else
            {
                Console.WriteLine("m. O filme não está cadastrado");
            }
        }
    }
}
