using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosOrientacaoObjetos.Pessoas
{
    public class Pessoa
    {
        public string Nome;
        public double Altura;
        public double Peso;

        public double CalcularImc()
        {
            var imc = Peso / (Altura * Altura);
            Console.WriteLine("IMC: " + imc);

            return imc;
        }

        public void ApresentarImc()
        {
            var imcAuxiliar = CalcularImc();

            if (imcAuxiliar < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imcAuxiliar < 25)
            {
                Console.WriteLine("Normal");
            }
            else
            {
                Console.WriteLine("Obesidade");
            }
        }
    }
}
