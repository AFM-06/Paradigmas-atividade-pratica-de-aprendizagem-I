using System;
using Paradigmas;

internal class Program
{
    private static void Main(string[] args)
    {
        Aluno a1 = new Aluno("José", 15, 7.0);
        a1.exibir();

        Console.ReadLine();
    }
}