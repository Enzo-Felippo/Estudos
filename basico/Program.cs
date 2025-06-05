// See https://aka.ms/new-console-template for more information
using Pessoas.Models;
using Calculador.Common.Models;

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

Console.WriteLine("=======================================");
int[] arrayInteiros = new int[3];
arrayInteiros[0] = 1;
arrayInteiros[1] = 2;
arrayInteiros[2] = 3;
// arrayInteiros[3] = 4; Isso dá erro
Console.WriteLine("Array com for:");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Possição N°{contador} - {arrayInteiros[contador]}");
}
Console.WriteLine("=======================================");
Console.WriteLine("Array com foreach");
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Valor: {valor}");
}
Console.WriteLine("=======================================");
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
arrayInteiros[3] = 4;
arrayInteiros[4] = 5;
arrayInteiros[5] = 6;
Console.WriteLine("Dobrando a capacidade o Array");
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Valor: {valor}");
}
Console.WriteLine("=======================================");
List<string> listaString = new List<string>();
listaString.Add("MT");
listaString.Add("RO");
listaString.Add("SP");
listaString.Add("MS");
Console.WriteLine("Lista com for:");
for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Possição N°{contador} - {listaString[contador]}");
}
Console.WriteLine("=======================================");
Console.WriteLine("Usando listas com foreach:");
int contadorForeach = 0;
listaString.Remove("MS");
foreach (string valor in listaString)
{
    Console.WriteLine($"Possição N°{contadorForeach} - {valor}");
    contadorForeach++;
}
