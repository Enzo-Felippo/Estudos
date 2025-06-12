using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conceitos.Models
{
    public class Pessoa
    {
        public Pessoa() // Construtor vazio
        {
            
        }
        public Pessoa(string nome, string sobrenome) // Construtor
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // Usando deconstrutor 
        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome.ToUpper();
        }
        
        private string _nome;
        private int _idade;
        public string Nome
        {
            get => _nome.ToUpper(); // Body Expressions
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // Propriedades somente leitura (get)

        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0 || value > 120)
                {
                    // Fiz uma exeção acontecer
                    throw new ArgumentException("A idade não pode ser menor que zero ou maior que 120");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade {Idade}");
        }
        
    }
}