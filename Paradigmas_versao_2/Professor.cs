using System;
using System.Collections.Generic;
using System.Text;

namespace Paradigmas
{
    internal class Professor : IPessoa
    {
        public string Nome {  get; set; }
        public int Idade { get; set; }
        public string Materia { get; set; }
        
        public Professor(string Nome, int Idade, string Materia)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Materia = Materia;

        }
        public Professor() { }

        public void preencher()
        {
            Console.WriteLine("Qual o nome do professor?");
            Nome = Console.ReadLine();
            Console.WriteLine("Qual a idade?");
            Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a matéria que ele leciona?");
            Materia = Console.ReadLine();
        }
        public void exibir()
        {
            Console.Write($"|| Nome: {Nome}({Idade}),{Materia}.");
        }
    }
}
