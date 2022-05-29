using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosOrientacaoObjetos.Calculadoras
{
    public class Calculadora
    {
        // Propriedades
        public int Numero1;
        public int Numero2;

        // tipoEncapsulamento + tipoRetorno + NomeMetodo(parametros)
        public void Somar()
        {
            var soma = Numero1 + Numero2;
            Console.WriteLine($"Soma: {soma}");
        }
        public void Subtrair()
        {
            var subtracao = Numero1 - Numero2;
            Console.WriteLine($"Subtração: {subtracao}");
        }
    }
}