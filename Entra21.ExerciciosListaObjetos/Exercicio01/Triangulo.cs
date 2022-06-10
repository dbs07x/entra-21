using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosLista
{
    internal class Triangulo
    {
        public int Codigo;
        public int Lado1;
        public int Lado2;
        public int Lado3;

        public bool ValidarTriangulo()
        {
            //se a soma das medidas de dois deles é sempre maior que a medida do terceiro, então, eles podem formar um triângulo
            return true;
        }
    }
}
