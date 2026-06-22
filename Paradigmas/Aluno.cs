using System;
using System.Collections.Generic;
using System.Text;

namespace Paradigmas
{
    internal class Aluno : IPessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; } = 0;
        public double Media { get; set; } = -1;


        public Aluno(string Nome, int Idade, double Media)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Media = Media;

        }
        public void preencher()
        {
            Console.WriteLine("Qual o nome do aluno?");
            Nome = Console.ReadLine();
            Console.WriteLine("Qual a idade?");
            Idade = int.Parse(Console.ReadLine());

        }
        public void média()
        {
            int n1, n2, n3;
            Console.WriteLine("Qual a nota 1?");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a nota 2?");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a nota 3?");
            n3 = int.Parse(Console.ReadLine());

            this.Media = (n1 + n2 + n3) / 3;
        }

        public void exibir()
        {
            Console.WriteLine($"Nome: {Nome} || Idade: {Idade}\nMédia: {Media}.");
        }
    }
}
