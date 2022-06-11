namespace Entra21.ExerciciosListaObjetos.Exercicio01
{
    internal class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();

        private int codigoAtual = 1;

        public bool Adicionar(int lado1, int lado2, int lado3)
        {
            // Instanciar um objeto da classe Triangulo
            Triangulo triangulo = new Triangulo();

            // Atribuir valor para as propriedades com os dados passados como parametro
            triangulo.Lado1 = lado1;
            triangulo.Lado2 = lado2;
            triangulo.Lado3 = lado3;

            // Verificar se o triângulo que está sendo adicionado é válido
            if (triangulo.ValidarTriangulo() == true)
            {
                triangulo.Codigo = codigoAtual;

                codigoAtual = codigoAtual + 1;

                triangulos.Add(triangulo);
            }
            return true;
        }

        //public bool Editar()
        //public bool Apagar()
        public List<Triangulo> ListarTodos()
        {
            return triangulos;
        }

        public Triangulo ObterPorCodigo(int codigo)
        {
            return null;
        }
    }
}
