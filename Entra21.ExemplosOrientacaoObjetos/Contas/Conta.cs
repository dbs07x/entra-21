using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosOrientacaoObjetos.Contas
{
    public class Conta
    {

        public double Saldo;
        public string Extrato;
        public string NumeroConta;
        public string Nome;

        public void Sacar()
        {
            Console.Write("Digite o valor para saque:");
            var valorSaque = Convert.ToDouble(Console.ReadLine());

            if (valorSaque > Saldo)
            {
                Console.WriteLine($"Valor saque é maior que saldo");
            }
            else
            {
                Saldo = Saldo - valorSaque;

                Extrato = Extrato + $"\n{DateTime.Now.ToString()} Saque de {valorSaque} novo Saldo: {Saldo}";
            }

            ApresentarExtrato();
        }

        public void Depositar()
        {
            Console.Write("Digite o valor para depósito: ");
            var valorDeposito = Convert.ToDouble(Console.ReadLine());
            if (valorDeposito <= 0)
            {
                Console.WriteLine("Valor não pode ser negativo ou zero");
            }
            else
            {
                Saldo = Saldo + valorDeposito;

                Extrato = Extrato + $"\n{DateTime.Now.ToString()} Depósito de {valorDeposito} novo Saldo: {Saldo}";
                ApresentarExtrato();
            }
        }

        public void ApresentarExtrato()
        {
            Console.WriteLine(Extrato);
            Console.WriteLine("Saldo: " + Saldo.ToString("F"));
        }
    }
}
