using System;
using System.Collections.Generic;
using System.Text;

namespace Paradigmas
{
    internal class Aluno : IPessoa
    {
        public string Nome {  get; set; }
        public int Idade { get; set; }


        public Aluno(string Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
        }
        public void preencher()
        {
            Console.WriteLine($"Teste");
        }
    }
}
