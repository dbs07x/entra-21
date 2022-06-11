using Entra21.ExerciciosListaObjetos.Exercicio01;

Console.WriteLine(@"1 - Exercício 01
");

Console.WriteLine("Escolha um item no menu: ");
var menu = Convert.ToInt32(Console.ReadLine());

if (menu == 1)
{
    Console.Clear();
    TrianguloControlador controlador = new TrianguloControlador();
    controlador.GerenciarMenu();
}