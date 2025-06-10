using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conceitos.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdcionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeDeAlunos()
        {
            return Alunos.Count;
        }
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }
        public void MostrarAlunos()
        {
            Console.WriteLine($"Alunos do curso: {Nome}");
            foreach (Pessoa Aluno in Alunos)
            {
                Console.WriteLine(Aluno.NomeCompleto);
            }
        }
        
    }
}