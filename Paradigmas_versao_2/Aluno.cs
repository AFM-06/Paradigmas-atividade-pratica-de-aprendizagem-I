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
        public string Situacao { get; set; }


        public Aluno(string Nome, int Idade, double Media, string Situacao)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Media = Media;
            this.Situacao = Situacao;

        }
        public Aluno() { }
        public void preencher()
        {
            Console.WriteLine("Qual o nome do aluno?");
            Nome = Console.ReadLine();
            Console.WriteLine("Qual a idade?");
            Idade = int.Parse(Console.ReadLine());

        }
        public void média()
        {
            double n1, n2, n3;
            Console.WriteLine("Qual a nota 1?");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a nota 2?");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a nota 3?");
            n3 = double.Parse(Console.ReadLine());

            this.Media = (n1 + n2 + n3) / 3;
            if (this.Media >= 7)
            {
                this.Situacao = "Aprovado.";
            } else if (this.Media<7 && this.Media >= 5)
            {
                this.Situacao = "Recuperação.";
            }else
            {
                this.Situacao = "Reprovado.";
            }
        }

        public void exibir()
        {
            Console.WriteLine($"Nome: {Nome} || Idade: {Idade}\nMédia: {Media} ({Situacao}).");
        }
    }
}
