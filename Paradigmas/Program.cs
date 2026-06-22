using System;
using Paradigmas;

internal class Program
{
    private static void Main(string[] args)
    {
        Aluno a1 = new Aluno("José", 16, 7.0,"Aprovado.");
        Aluno a2 = new Aluno("Matheus", 15, 8.0, "Aprovado.");
        Aluno a3 = new Aluno("Maria", 14, 9.0, "Aprovado.");
        Aluno a4 = new Aluno("Angel", 15, 7.5, "Aprovado.");
        Professor prof1 = new Professor("Vinicius",45,"Ciências");
        Professor prof2 = new Professor("Bruno",29,"Matemática");
        Turma primeiro_medio = new Turma();
        primeiro_medio.adicionarAluno(a1);
        primeiro_medio.adicionarAluno(a2);
        primeiro_medio.adicionarAluno(a3);
        primeiro_medio.adicionarAluno(a4);
        primeiro_medio.adicionarProfessor(prof1);
        primeiro_medio.adicionarProfessor(prof2);
        primeiro_medio.exibir();

    }
}