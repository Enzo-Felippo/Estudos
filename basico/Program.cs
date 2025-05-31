// See https://aka.ms/new-console-template for more information
using Pessoas.models;

Pessoa Enzo = new()
{
    Nome = "Enzo",
    Idade = 19
};

Enzo.Apresentar();

// Datas
DateTime agora = DateTime.Now;
Console.WriteLine($"Agora é {agora.ToString("dd/MM/yyyy HH:mm")}");

// Conversão
int inteiro = Convert.ToInt32(null); // Convert consegue tratar valores nulos
Console.WriteLine($"{inteiro}");
inteiro = int.Parse("12"); // Não consegue tratar valores nulos
Console.WriteLine($"{inteiro}"); 