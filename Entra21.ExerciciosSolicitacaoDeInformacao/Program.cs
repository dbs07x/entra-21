﻿using Entra21.ExerciciosSolicitacaoDeInformacao;

Console.WriteLine(@"1 - Exercício 01
2 - Exercício 02
");

Console.WriteLine("Escolha um item no menu: ");
var menu = Convert.ToInt32(Console.ReadLine());

if (menu == 1)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
if (menu == 2)
{
    Exercicio02 exercicio02 = new Exercicio02();
    exercicio02.Executar();
}