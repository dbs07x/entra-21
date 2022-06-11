namespace Entra21.ExerciciosListaObjetos.Exercicio01
{
    public class Triangulo
    {
        public int Codigo;
        public int Lado1;
        public int Lado2;
        public int Lado3;

        public bool ValidarTriangulo()
        {
            //Só irá existir um triângulo se: a soma das medidas de dois lados é sempre maior que a medida do terceiro
            if ((Lado1 + Lado2 < Lado3) || (Lado2 + Lado3 < Lado1) || (Lado3 + Lado1 < Lado2))
            {
                return false;
            }
            return true;
        }
    }
}
