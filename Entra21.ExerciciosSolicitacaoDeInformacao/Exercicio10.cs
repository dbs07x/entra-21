using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosSolicitacaoDeInformacao
{
    internal class Exercicio10
    {
        public void Executar()
        {
            /*
            Desenvolver um algoritmo que solicite a conta de luz, conta de água , valor da NET,
            valor da Vivo, valor da Oi, valor do IPTU, valor do IPVA, valor do seguro do carro,
            valor do seguro do jet ski, valor do seguro do avião, valor do seguro do iate.
            Após solicitar as informações deve-se apresentar as seguintes informações:
            - Valor das contas de telefone
            - Valor dos impostos
            - Valor dos seguros
            - Valor do restante das contas
            - Valor total de todas as contas
            */

            Console.WriteLine("Informe o valor da conta de luz: R$");
            double contaLuz = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor da conta de água: R$");
            double contaAgua = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor da conta da NET: R$");
            double contaNet = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor da conta da Vivo: R$");
            double contaVivo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor da conta da Oi: R$");
            double contaOi = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor do IPTU: R$");
            double iptu = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor do IPVA: R$");
            double ipva = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor do seguro do carro: R$");
            double seguroCarro = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor do seguro do jet ski : R$");
            double seguroJetSki = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor do seguro do aviâo: R$");
            double seguroAviao = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor do seguro do iate: R$");
            double seguroIate = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            double valorContasTelefone = contaNet + contaVivo + contaOi;
            double valorImpostos = iptu + ipva;
            double valorSeguros = seguroCarro + seguroJetSki + seguroAviao + seguroIate;
            double restanteContas = contaLuz + contaAgua;
            double todasContas = valorContasTelefone + valorImpostos + valorSeguros + restanteContas;
            Console.WriteLine("Valor das contas de telefone: " + valorContasTelefone);
            Console.WriteLine("Valor dos impostos: " + valorImpostos);
            Console.WriteLine("Valor dos seguros: " + valorSeguros);
            Console.WriteLine("Valor do restante das contas: " + restanteContas);
            Console.WriteLine("Valor total de todas as contas: " + todasContas);
        }
    }
}
