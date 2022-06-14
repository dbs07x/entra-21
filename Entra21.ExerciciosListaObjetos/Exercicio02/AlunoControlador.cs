namespace Entra21.ExerciciosListaObjetos.Exercicio02
{
    internal class AlunoControlador
    {
        private AlunoServico alunoServico = new AlunoServico();
        public void GerenciarMenu()
        {
            int opcaoMenu = 0;
            while (opcaoMenu != 6)
            {
                Console.Clear();
                opcaoMenu = ApresentarMenu();

                if (opcaoMenu == 1)
                {
                    CadastrarAluno();
                }
                else if (opcaoMenu == 2)
                {
                    ListarNomes();
                }
                else if (opcaoMenu == 3)
                {
                }
                else if (opcaoMenu == 4)
                {
                }
                else if (opcaoMenu == 5)
                {
                }
                Console.Write("\n\nPressione uma tecla para continuar...");
                Console.ReadKey();
            }
        }
        private int ApresentarMenu()
        {
            Console.WriteLine(@"Menu:
1 - Cadastrar Aluno
2 - Obter Nomes
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

        private void CadastrarAluno()
        {
            Console.Write("Nome: ");
            var nome = Console.ReadLine();
            Console.Write("Idade: ");
            var idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Materia Favorita: ");
            var materiaFavorita = Console.ReadLine();
            Console.Write("Nota 1: ");
            var nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota 2: ");
            var nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota 3: ");
            var nota3 = Convert.ToDouble(Console.ReadLine());
            alunoServico.AdicionarAluno(nome, idade, materiaFavorita, nota1, nota2, nota3);
        }

        private void ListarNomes()
        {
            var alunos = alunoServico.ObterTudo();

            if (alunos.Count() == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado");
                return;
            }

            for (var i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                Console.WriteLine("" +
                    "\nCódigo: " + alunoAtual.CodigoMatricula +
                    "\nNome: " + alunoAtual.Nome + "\n");
            }
        }
    }
}
