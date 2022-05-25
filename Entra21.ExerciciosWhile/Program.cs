﻿using Entra21.ExerciciosWhile;

Console.WriteLine(@"1 - Exercício 01
2 - Exercício 02
3 - Exercício 03
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
if (menu == 3)
{
    Exercicio03 exercicio03 = new Exercicio03();
    exercicio03.Executar();
}