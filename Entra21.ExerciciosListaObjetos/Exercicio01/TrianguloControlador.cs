namespace Entra21.ExerciciosListaObjetos.Exercicio01
{
    internal class TrianguloControlador
    {
        private TrianguloServico trianguloServico = new TrianguloServico();
        public void GerenciarMenu()
        {
            int opcaoMenu = 0;
            while (opcaoMenu != 6)
            {
                Console.Clear();
                opcaoMenu = ApresentarMenu();

                if (opcaoMenu == 1)
                {
                    Adicionar();
                }
                else if (opcaoMenu == 2)
                {
                    //Editar();
                }
                else if (opcaoMenu == 3)
                {
                    //Apagar();
                }
                else if (opcaoMenu == 4)
                {
                    //ListarProdutoPorCodigo
                }
                else if (opcaoMenu == 5)
                {
                    ListarTodosProdutos();
                }
                Console.Write("\n\nPressione uma tecla para continuar...");
                Console.ReadKey();
            }
        }
        private int ApresentarMenu()
        {
            Console.WriteLine(@"Menu:
1 - Adicionar
2 - Editar
3 - Apagar
4 - Listar Produto por Código
5 - Listar Todos Produtos
6 - Sair");
            int opcaoMenu = SolicitarOpcaoMenu();
            return opcaoMenu;
        }
        private int SolicitarOpcaoMenu()
        {
            int opcaoMenu = 0;
            while (opcaoMenu < 1 || opcaoMenu > 6)
            {
                try
                {
                    Console.Write("Digite a opção desejada: ");
                    opcaoMenu = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite um menu válido");
                }
            }
            return opcaoMenu;
        }
        private void Adicionar()
        {
            Console.WriteLine("Dimensão Lado 1: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dimensão Lado 2: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dimensão Lado 3: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            trianguloServico.Adicionar(lado1, lado2, lado3);
        }

        private void ListarTodosProdutos()
        {
            var triangulos = trianguloServico.ListarTodos();

            if (triangulos.Count() == 0)
            {
                Console.WriteLine("Nenhum triângulo cadastrado: ");
                return;
            }

            for (var i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                Console.WriteLine("" +
                    "\nLado 1: " + trianguloAtual.Lado1 +
                    "\nLado 2: " + trianguloAtual.Lado2 +
                    "\nLado 3: " + trianguloAtual.Lado3 + "\n");
            }
        }
    }
}