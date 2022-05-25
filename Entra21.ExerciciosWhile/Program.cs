using Entra21.ExerciciosWhile;

Console.WriteLine(@"1 - Exercício 01
");

Console.WriteLine("Escolha um item no menu: ");
var menu = Convert.ToInt32(Console.ReadLine());

if (menu == 1)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}