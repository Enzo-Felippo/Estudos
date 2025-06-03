// See https://aka.ms/new-console-template for more information
using Pessoas.Models;
using Calculador.Models;

Pessoa Enzo = new()
{
    Nome = "Enzo",
    Idade = 19
};

Enzo.Apresentar();

// Datas
DateTime agora = DateTime.Now;
Console.WriteLine($"Agora é {agora.ToString("dd/MM/yyyy HH:mm")}");

Console.WriteLine("=======================================");
// Conversão
int inteiro = Convert.ToInt32(null); // Convert consegue tratar valores nulos
Console.WriteLine($"{inteiro}");
inteiro = int.Parse("12"); // Não consegue tratar valores nulos
Console.WriteLine($"{inteiro}");


Calculadora operador = new();

Console.WriteLine("=======================================");
operador.Somar(2, 3);
operador.Subtrair(9, 5);
operador.Multiplicar(3, 4);
operador.Dividir(6, 2);
operador.potencia(3, 4);
Console.WriteLine("=======================================");
operador.Tangente(30);
operador.Coseno(30);
operador.Seno(30);
operador.RaizQuadrada(64);

Console.WriteLine("=======================================");
for (int contator = 1; contator <= 10; contator++)
{
    operador.Multiplicar(11, contator);
}
Console.WriteLine("=======================================");
while (true)
{
    Console.WriteLine("Tentei, mas não consegui! Sem loop por hoje");
    break;
}
Console.WriteLine("=======================================");
int parar = 0;
do
{
    Console.Write("Digite o numero 0 para parar o loop: ");
    parar = Convert.ToInt32(Console.ReadLine());
} while (parar != 0);