// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
using Exemplo_Explorando.models;
using Newtonsoft.Json;


///// Tipos anomimos em coleção


string conteudoArquivo = File.ReadAllText("arquivos/vendas.json");

List<Venda> listaVenda=JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

var listaAnonimo = listaVenda.Select(x=>new{x.Produto,x.Preco});

foreach (Venda venda in listaVenda)
{
    System.Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}.");
}
