using System;
using System.Collections.Generic;

namespace ParadigmasProcedural
{
    internal struct Aluno
    {
        public string Nome;
        public int Idade;
        public double Media;
        public string Situacao;
    }

    internal struct Professor
    {
        public string Nome;
        public int Idade;
        public string Materia;
    }

    internal class Program
    {
        static List<Aluno> listaAlunos = new List<Aluno>();
        static List<Professor> listaProfessores = new List<Professor>();
        private static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 5)
            {
                Console.WriteLine("\n=== SISTEMA ESCOLAR===");
                Console.WriteLine("1 - Cadastrar Aluno");
                Console.WriteLine("2 - Cadastrar Professor");
                Console.WriteLine("3 - Buscar Aluno por Nome");
                Console.WriteLine("4 - Exibir Relatório da Turma");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1) CadastrarAluno();
                else if (opcao == 2) CadastrarProfessor();
                else if (opcao == 3) BuscarAluno();
                else if (opcao == 4) ExibirTurma();
            }
        }

        static void CadastrarAluno()
        {
            Console.WriteLine("\n---CADASTRO DE ALUNO---");

            Aluno novoAluno = new Aluno();

            Console.Write("Qual o nome do aluno? ");
            novoAluno.Nome = Console.ReadLine();

            Console.Write("Qual a idade? ");
            novoAluno.Idade = int.Parse(Console.ReadLine());

            Console.Write("Qual a nota 1? ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Qual a nota 2? ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("Qual a nota 3? ");
            double n3 = double.Parse(Console.ReadLine());

            novoAluno.Media = (n1 + n2 + n3) / 3;
            novoAluno.Situacao = novoAluno.Media >= 7 ? "Aprovado." : (novoAluno.Media >= 5 ? "Recuperação." : "Reprovado.");

            listaAlunos.Add(novoAluno);
            Console.WriteLine($"Aluno {novoAluno.Nome} adicionado!");
        }

        static void CadastrarProfessor()
        {
            Console.WriteLine("\n---CADASTRO DE PROFESSOR---");
            Professor novoProf = new Professor();

            Console.Write("Qual o nome do professor? ");
            novoProf.Nome = Console.ReadLine();

            Console.Write("Qual a idade? ");
            novoProf.Idade = int.Parse(Console.ReadLine());

            Console.Write("Qual a matéria? ");
            novoProf.Materia = Console.ReadLine();

            listaProfessores.Add(novoProf);
            Console.WriteLine($"Professor {novoProf.Nome} adicionado!");
        }

        static void BuscarAluno()
        {
            Console.Write("\nDigite o nome do aluno que deseja buscar: ");
            string nomeBuscado = Console.ReadLine();
            bool encontrou = false;

            foreach (var aluno in listaAlunos)
            {
                if (aluno.Nome.Equals(nomeBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\n[Aluno Encontrado]");
                    Console.WriteLine($"Nome: {aluno.Nome} || Idade: {aluno.Idade}");
                    Console.WriteLine($"Média: {aluno.Media:F1} ({aluno.Situacao})");
                    encontrou = true;
                    break;
                }
            }
            if (!encontrou) Console.WriteLine($"O aluno '{nomeBuscado}' não foi encontrado.");
        }

        static void ExibirTurma()
        {
            Console.WriteLine("\n=============================");
            Console.WriteLine("      RELATÓRIO DA TURMA     ");
            Console.WriteLine("=============================");

            Console.WriteLine("\n--- Professores ---");
            if (listaProfessores.Count == 0) Console.WriteLine("Nenhum professor cadastrado.");
            foreach (var prof in listaProfessores)
            {
                Console.WriteLine($"|| Nome: {prof.Nome} ({prof.Idade}), Matéria: {prof.Materia}.");
            }

            Console.WriteLine("\n--- Alunos ---");
            if (listaAlunos.Count == 0) Console.WriteLine("Nenhum aluno cadastrado.");
            foreach (var aluno in listaAlunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome} || Idade: {aluno.Idade} | Média: {aluno.Media:F1} ({aluno.Situacao})");
            }
            Console.WriteLine("=============================");
        }
    }
}