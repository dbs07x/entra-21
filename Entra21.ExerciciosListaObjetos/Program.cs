using Entra21.ExerciciosListaObjetos.Exercicio01;
using Entra21.ExerciciosListaObjetos.Exercicio02;

Console.WriteLine(@"1 - Exercício 01
2 - Exercício 02
");

Console.WriteLine("Escolha um item no menu: ");
var menu = Convert.ToInt32(Console.ReadLine());

if (menu == 1)
{
    Console.Clear();
    TrianguloControlador controlador = new TrianguloControlador();
    controlador.GerenciarMenu();
}
else if (menu == 2)
{
    Console.Clear();
    AlunoControlador controlador = new AlunoControlador();
    controlador.GerenciarMenu();
}