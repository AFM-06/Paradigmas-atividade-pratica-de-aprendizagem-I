using System;
using System.Collections.Generic;
using System.Text;

namespace Paradigmas
{
    internal class Turma
    {
        public string NomeTurma { get; set; }
        public Professor Professor { get; set; }

        public Turma(string nomeTurma)
        {
            this.NomeTurma = nomeTurma;
        }
        public Turma () { }
        public List<Aluno> Alunos = new List<Aluno>();
        public List<Professor> Professores = new List<Professor>();

        public void adicionarProfessor(Professor professor)
        {
            Console.WriteLine($"Professor: {professor.Nome} adicionado.");
            Professores.Add(professor);
        }

        public void removerProfessor(Professor professor)
        {
            Console.WriteLine($"Professor: {professor.Nome} removido.");
            Professores.Remove(professor);
        }

        public void adicionarAluno(Aluno aluno)
        {
            Console.WriteLine($"Aluno: {aluno.Nome} adicionado.");
            Alunos.Add(aluno);
        }
        public void removerAluno(Aluno aluno)
        {
            Console.WriteLine($"Aluno: {aluno.Nome} removido.");
            Alunos.Remove(aluno);
        }
        public void exibir()
        {
            foreach(var professor in Professores)
            {
                professor.exibir();
            }
            Console.WriteLine("");
            foreach(var aluno in Alunos)
            {
                aluno.exibir();
            }
            Console.WriteLine("");
        }
    }
}
