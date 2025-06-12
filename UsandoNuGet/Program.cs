// Aqui tem uns conceitos mais avançados
using UsandoNuGet.Models;
// Usando da biblioteca NuGet
using Newtonsoft.Json;

DateTime dataAtual = DateTime.Now;
List<Vendas> vendas = []; // versão simplificada
// Vendas venda1 = new Vendas(1, "Bolsa", 249.99M);

vendas.Add(new(1, "Bolsa", 249.99M, dataAtual));
vendas.Add(new(2, "Blussa", 89.99M, dataAtual));

// Formatting.Indented significa mostrar com quebrar de linha
// Recomendo não usar o Formatting.Indented para que o arquivo seja mais leve
string serializado = JsonConvert.SerializeObject(vendas, Formatting.Indented);
Console.WriteLine(serializado);

File.WriteAllText("/Estudos/Arquivos/Vendas.json", serializado);

// Caminho inverso ========
string conteudoArquivo = File.ReadAllText("/Estudos/Arquivos/Vendas.json");

// Usando o DeserializeObject para concerter de Json para C# 

// Os objetos da classe devem representar os equivalentes em JSON
// Se um {objeto} JSON é venda a {propriedade} deve ser venda e os {tipos} devem ser equivalents
List<Vendas> vendasLidas = JsonConvert.DeserializeObject<List<Vendas>>(conteudoArquivo);

foreach (Vendas venda in vendasLidas)
{
    Console.WriteLine("=======================================");
    Console.WriteLine($"Id: {venda.Id}");
    Console.WriteLine($"Produto: {venda.Produto}");
    Console.WriteLine($"Preco: {venda.Preco}");
    Console.WriteLine($"Data: {venda.DataDaVenda}");
}
