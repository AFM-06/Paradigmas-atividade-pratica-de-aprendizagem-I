using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Paradigmas
{
    internal class Turma
    {
        //Atributos
        public string NomeTurma { get; set; }
        public Professor Professor { get; set; }
        //Construtores
        public Turma(string nomeTurma)
        {
            this.NomeTurma = nomeTurma;
        }
        public Turma () { }
        //Lista de alunos e professores da turma.
        public List<Aluno> Alunos = new List<Aluno>();
        public List<Professor> Professores = new List<Professor>();
        //Metodos de professor em turma.
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
        public void buscarProfessorPorNome(string nomeBuscado)
        {
            bool encontrou = false;

            foreach (var professor in Professores)
            {
                if (professor.Nome.Equals(nomeBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Professor encontrado:");
                    professor.exibir();
                    encontrou = true;
                    break;
                }
            }
            if (!encontrou)
            {
                Console.WriteLine($"O professor '{nomeBuscado}' não leciona nesta turma.");
            }
        }
        //Metodos de aluno em turma.
        public void buscarAlunoPorNome(string nomeBuscado)
        {
            bool encontrou = false;

            foreach (var aluno in Alunos)
            {
                if (aluno.Nome.Equals(nomeBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Aluno encontrado:");
                    aluno.exibir();
                    encontrou = true;
                    break;
                }
            }
            if (!encontrou)
            {
                Console.WriteLine($"O aluno '{nomeBuscado}' não estuda nesta turma.");
            }
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
        //Metodo de exibir a turma
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
