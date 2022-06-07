using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.EexerciciosLista
{
    internal class Exercicio02
    {
        public void Executar()
        {
            /*2. Criar uma classe que irá armazenar os conteúdos passados até o momento:
            a. Adicionar o conteúdo "Como fazer um bolo"
            b. Listar conteúdos
            c. Alterar conteúdo "Como fazer um bolo" para "Algoritmos onde vivem? Do que se alimentam”
            d. Adicionar o conteúdo "variáveis"
            e. Adicionar o conteúdo "Mais para frente"
            f. Alterar o conteúdo “Mais para frente" por "If com E"
            g. Adicionar o conteúdo "If com OU”;
            h. Adicionar o conteúdo "While";
            i. Adicionar o conteúdo "For"
            j. Listar conteúdos
            k. Adicionar o conteúdo "Vetor"
            l. Adicionar o conteúdo "Vetor”
            m. Apagar os conteúdos "Vetor"
            n. Adicionar o conteúdo "Vetor"
            o. Alterar o conteúdo"Vetor" para "Vetor com For um amor na minha vida”
            p. Listar conteúdos
            q. Adicionar o conteúdo "Classe propriedades e métodos"
            r. Listar conteúdos*/

            List<string> conteudos = new List<string>();

            //a.Adicionar o conteúdo "Como fazer um bolo"
            conteudos.Add("Como fazer um bolo");

            //b. Listar conteúdos
            Console.WriteLine("b. Conteúdos armazenados em suas respectivas posições:" +
            "\n[0]: " + conteudos[0]);
            Console.WriteLine();

            //c. Alterar conteúdo "Como fazer um bolo" para "Algoritmos onde vivem? Do que se alimentam”
            var indiceComoFazerUmBolo = conteudos.IndexOf("Como fazer um bolo");
            conteudos[indiceComoFazerUmBolo] = "Algoritmos onde vivem? Do que se alimentam";

            //d.Adicionar o conteúdo "variáveis"
            conteudos.Add("Variáveis");

            //e. Adicionar o conteúdo "Mais para frente"
            conteudos.Add("Mais para frente");

            //f. Alterar o conteúdo “Mais para frente" por "If com E"
            var indiceMaisParaFrente = conteudos.IndexOf("Mais para frente");
            conteudos[indiceMaisParaFrente] = "If com E";

            //g.Adicionar o conteúdo "If com OU”;
            conteudos.Add("If com OU");

            //h.Adicionar o conteúdo "While";
            conteudos.Add("While");

            //i.Adicionar o conteúdo "For"
            conteudos.Add("For");

            //j.Listar conteúdos
            Console.WriteLine("j. Conteúdos armazenados em suas respectivas posições:" +
            "\n[0]: " + conteudos[0] +
            "\n[1]: " + conteudos[1] +
            "\n[2]: " + conteudos[2] +
            "\n[3]: " + conteudos[3] +
            "\n[4]: " + conteudos[4] +
            "\n[5]: " + conteudos[5]);
            Console.WriteLine();

            //k.Adicionar o conteúdo "Vetor"
            conteudos.Add("Vetor");

            //l.Adicionar o conteúdo "Vetor"
            conteudos.Add("Vetor");

            //m.Apagar os conteúdos "Vetor"
            conteudos.Remove("Vetor");
            conteudos.Remove("Vetor");

            //n.Adicionar o conteúdo "Vetor"
            conteudos.Add("Vetor");

            //o. Alterar o conteúdo"Vetor" para "Vetor com For um amor na minha vida”
            var indiceVetor = conteudos.IndexOf("Vetor");
            conteudos[indiceVetor] = "Vetor com For um amor na minha vida";

            //p.Listar conteúdos
            Console.WriteLine("p. Conteúdos armazenados em suas respectivas posições:" +
            "\n[0]: " + conteudos[0] +
            "\n[1]: " + conteudos[1] +
            "\n[2]: " + conteudos[2] +
            "\n[3]: " + conteudos[3] +
            "\n[4]: " + conteudos[4] +
            "\n[5]: " + conteudos[5] +
            "\n[6]: " + conteudos[6]);
            Console.WriteLine();

            //q.Adicionar o conteúdo "Classe propriedades e métodos"
            conteudos.Add("Classe propriedades e métodos");

            //r. Listar conteúdos
            Console.WriteLine("r. Conteúdos armazenados em suas respectivas posições:" +
            "\n[0]: " + conteudos[0] +
            "\n[1]: " + conteudos[1] +
            "\n[2]: " + conteudos[2] +
            "\n[3]: " + conteudos[3] +
            "\n[4]: " + conteudos[4] +
            "\n[5]: " + conteudos[5] +
            "\n[6]: " + conteudos[6] +
            "\n[7]: " + conteudos[7]);
            Console.WriteLine();
        }
    }
}
