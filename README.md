# Cadastro de alunos: Procedural vs. Orientado a Objetos

Este repositório contém a **Atividade Prática de Aprendizagem I** da disciplina de Paradigmas de Linguagens de Programação. 

O objetivo do projeto é demonstrar, na prática, como um mesmo problema do cotidiano (o gerenciamento de uma turma, alunos e professores) pode ser resolvido utilizando duas visões arquiteturais completamente diferentes em C#.

O projeto foi dividido em duas soluções independentes dentro da mesma pasta:

* **`ParadigmasProcedural` (A Versão Imperativa):** Onde os dados e os comportamentos são separados. Utiliza `structs` para armazenar as informações e funções estáticas centralizadas no `Program.cs` para processar a lógica, simular o cadastro, cálculo de médias e exibição.
* **`Paradigmas_versao_2` (A Versão Orientada a Objetos):** Onde os dados ganham vida. Utiliza os conceitos de **Classes**, **Encapsulamento** e **Interfaces**. Aqui, a responsabilidade é dividida: Aluno, Professor, Turma.

##  Como testar

1. Clone este repositório.
2. Abra a Solução (`.sln`) no Visual Studio.
3. No Gerenciador de Soluções, clique com o botão direito no projeto que deseja testar (`ParadigmasProcedural` ou `Paradigmas_versao_2`).
4. Selecione **"Definir como Projeto de Inicialização"**.
5. Rode o programa e interaja com o menu no terminal!
