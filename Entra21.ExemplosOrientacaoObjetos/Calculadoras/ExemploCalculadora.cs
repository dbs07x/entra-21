using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosOrientacaoObjetos.Calculadoras
{
    public class ExemploCalculadora
    {
        public void Executar()
        {
            Calculadora hp = new Calculadora();
            Console.Write("Digite o número 1:");
            hp.Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o número 2:");
            hp.Numero2 = Convert.ToInt32(Console.ReadLine());

            hp.Somar();
            hp.Subtrair();

            Calculadora epson = new Calculadora();
            Console.Write("Digite o número 1:");
            epson.Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o número 2:");
            epson.Numero2 = Convert.ToInt32(Console.ReadLine());

            epson.Somar();
            epson.Subtrair();
        }
    }
}
