using Entra21.EexerciciosLista;
using Entra21.ExerciciosLista;

Console.WriteLine(@"1 - Exercício 01
2 - Exercício 02
3 - Exercício 03
");

Console.WriteLine("Escolha um item no menu: ");
var menu = Convert.ToInt32(Console.ReadLine());

if (menu == 1)
{
    Console.Clear();
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
if (menu == 2)
{
    Console.Clear();
    Exercicio02 exercicio02 = new Exercicio02();
    exercicio02.Executar();
}
if (menu == 3)
{
    Console.Clear();
    Exercicio03 exercicio03 = new Exercicio03();
    exercicio03.Executar();
}
if (menu == 4)
{
    Console.Clear();
    ProdutoControlador controlador = new ProdutoControlador();
    controlador.GerenciarMenu();
}