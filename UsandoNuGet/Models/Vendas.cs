using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UsandoNuGet.Models
{
    // Usando um construtor primário
    public class Vendas(int id, string produto, decimal preco, DateTime dataDaVenda)
    {
        public int Id { get; set; } = id;
        // Fazendo a conversão do nome tando para receber quanto para enviar
        [JsonProperty("Nome_Produto")] // Meta dado
        public string Produto { get; set; } = produto;
        public decimal Preco { get; set; } = preco;
        public DateTime DataDaVenda { get; set; } = dataDaVenda;

    }
}