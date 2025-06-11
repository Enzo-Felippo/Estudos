using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Conceitos.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public decimal Mensalidade { get; set; }
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
            for (int ordem = 0; ordem < Alunos.Count; ordem++)
            {
                Console.WriteLine($"{ordem + 1}º - {Alunos[ordem].NomeCompleto}");
            }
        }
        
        public void ReceitaMensalDoCurso()
        {
            decimal receita = Mensalidade * Alunos.Count;
            Console.WriteLine($"Valor da mensalidada: {Mensalidade:C}");
            Console.WriteLine($"Quantidade de alunos: {Alunos.Count}");
            Console.WriteLine($"Receita mensal: {receita.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");
        }
        
    }
}