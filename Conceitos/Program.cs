using Conceitos.Models;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.InteropServices;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

Pessoa pessoa1 = new Pessoa(nome: "Enzo", "Costa"); // Usando um construtor
Pessoa pessoa3 = new Pessoa(nome: "José", sobrenome: "Martins");
Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Emmilly";
pessoa2.Sobrenome = "Costa";

Curso curso = new Curso();
curso.Nome = "English";
curso.Alunos = new List<Pessoa>();
curso.Mensalidade = 359.90M;
curso.AdcionarAluno(pessoa1);
curso.AdcionarAluno(pessoa2);
curso.AdcionarAluno(pessoa3);

// Usando ToString para porcentagem
double satisfacao = .9375;
Console.WriteLine($"A satisfação é de {satisfacao.ToString("P2")}");
// Usando ToString para personalizar
int cpe = 78088125;
Console.WriteLine($"CPE da empresa: {cpe.ToString("#####-###")}");

Console.WriteLine("===================================");
curso.ReceitaMensalDoCurso();
Console.WriteLine("===================================");
curso.MostrarAlunos();
Console.WriteLine("===================================");

// Agora irei tentar ler um arquivo

LerArquivoExecao arquivo = new LerArquivoExecao();
arquivo.tentarLerArquivo(caminho: "/Estudos/Arquivos/texto.txt", erro: true);
Console.WriteLine("===================================");

// Usando fila (FIFO)
Queue<Pessoa> fila = new Queue<Pessoa>();

fila.Enqueue(pessoa3);
fila.Enqueue(pessoa2);

Console.WriteLine("Percorrendo uma fila:");
foreach (Pessoa pessoa in fila)
{
    Console.WriteLine(pessoa.Nome);
}
Console.WriteLine("===================================");
fila.Dequeue();
fila.Enqueue(pessoa1);
Console.WriteLine("Tirei uma pessoa da fila");
foreach (Pessoa pessoa in fila)
{
    Console.WriteLine(pessoa.Nome);
}

Console.WriteLine("===================================");
// Usando pilha (LIFO)

Stack<int> pilha = new Stack<int>();

pilha.Push(10);
pilha.Push(11);
pilha.Push(12);
pilha.Push(13);
foreach (int item in pilha)
{
    Console.WriteLine($"Item: {item}");
}

Console.WriteLine("===================================");

Console.WriteLine($"Tirei o item ({pilha.Pop()}) da Pilha ");
pilha.Push(14);
foreach (int item in pilha)
{
    Console.WriteLine($"Item: {item}");
}

// Trabalhando com dicionarios
Console.WriteLine("===================================");
Dictionary<Pessoa, decimal> notaAluno = new Dictionary<Pessoa, decimal>();
Pessoa pessoa4 = new Pessoa(nome: "Rose", sobrenome: "Ruy");

notaAluno.Add(pessoa1, 10.00M);
notaAluno.Add(pessoa2, 7.75M);
notaAluno.Add(pessoa3, 8.50M);

// (KeyValuePair<Pessoa, decimal> aluno in notaAluno) - existe essa opção também
foreach (var aluno in notaAluno)
{
    Console.WriteLine($"Aluno(a): {aluno.Key.Nome}\nNota: {aluno.Value}");
}
// Tentando adcionar uma key igual.
try
{
    notaAluno.Add(pessoa3, 8.00M);
}
catch
{   
    Console.WriteLine("===================================");
    Console.WriteLine("Não é possivel adcionar uma Key igual");
}
// Removendo um item
notaAluno.Remove(pessoa3);
notaAluno.Add(pessoa4, 9.00M);
notaAluno[pessoa1] = 9.50M;
Console.WriteLine("===================================");
foreach (var aluno in notaAluno)
{
    Console.WriteLine($"Aluno(a): {aluno.Key.Nome}\nNota: {aluno.Value}");
}
// Usando o ContainsKey para verificar se a chave existe no dicionario
Console.WriteLine("===================================");
if (notaAluno.ContainsKey(pessoa2))
{
    Console.WriteLine($"Aluno(a) {pessoa2.NomeCompleto} foi sorteada");
}

// Trabalhando com tuplas

// Esse método tem como nomar os itens da tupla * Ganhador
(int ID, string Nome, string Sobrenome, decimal) tupla = (1, "Felippo", "Lopes", 1.77M);
// Acho que esse método seja muito ruim
// ValueTuple<int, string, string, decimal> novaTupla1 = (1, "Rose", "Ruy", 1.62M);
// Acho esse o metodo mais fácil de criar tupla, pena que não tem como nomear
// var novaTupla2 = Tuple.Create(1, "José", "Martins", 1.72M);

Console.WriteLine("===================================");

Console.WriteLine($"ID: {tupla.ID}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sorenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Item4}");

Console.WriteLine("===================================");
// Criando variaveis com retorno de tupla
var (sucesso, linhas, _) = arquivo.LerArquivo(caminho: "/Estudos/Arquivos/texto.txt");
// Uma das infrmações foi descartada
if (sucesso)
{
    // Console.WriteLine($"Quantidade de linhas: {linhasTotais}");
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
Console.WriteLine("===================================");

// Usando o desconstrutor para criar variaveis
(string nome, string sobrenome) = pessoa4;

Console.WriteLine("Usando o deconstrutor: ");
Console.WriteLine($"Nome: {nome}\nSobrenome: {sobrenome}");

Console.WriteLine("===================================");
// criando um método de sorteio
Random random = new();
int numeroSorteado = random.Next(minValue: 1, maxValue: 100);

// Usando if ternário
string imparPar = numeroSorteado % 2 == 0 ? "par" : "ímpar";
Console.WriteLine($"O numero sorteado ({numeroSorteado}) é {imparPar}");
