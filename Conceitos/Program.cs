using Conceitos.Models;

Pessoa pessoa1 = new Pessoa(nome: "Enzo", "Costa"); // Usando um construtor
Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Emmilly";
pessoa2.Sobrenome = "Costa";

Curso curso = new Curso();
curso.Nome = "English";
curso.Alunos = new List<Pessoa>();

curso.AdcionarAluno(pessoa1);
curso.AdcionarAluno(pessoa2);
curso.MostrarAlunos();
