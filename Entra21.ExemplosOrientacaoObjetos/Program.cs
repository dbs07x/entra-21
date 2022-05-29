using Entra21.ExemplosOrientacaoObjetos.Calculadoras;
using Entra21.ExemplosOrientacaoObjetos.Carros;
using Entra21.ExemplosOrientacaoObjetos.Contas;
using Entra21.ExemplosOrientacaoObjetos.Pessoas;

Console.WriteLine(@"1 - Calculadora
2 - Carros
3 - Contas
4 - Pessoas
");

Console.WriteLine("Escolha um item no menu: ");
var menu = Convert.ToInt32(Console.ReadLine());

if (menu == 1)
{
    ExemploCalculadora exemploCalculadora = new ExemploCalculadora();
    exemploCalculadora.Executar();
}
if(menu == 2)
{
    ExemploCarro exemploCarro = new ExemploCarro();
    exemploCarro.Executar();
}
if (menu == 3)
{
    ExemploConta exemploConta = new ExemploConta();
    exemploConta.Executar();
}
if (menu == 4)
{
    ExemploPessoa exemploPessoa = new ExemploPessoa();
    exemploPessoa.Executar();
}