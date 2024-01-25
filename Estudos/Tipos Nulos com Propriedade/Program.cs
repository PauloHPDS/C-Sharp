using System.Diagnostics.Contracts;
using models;

// Tipos Nulos em propriedades



string conteudoArquivo = File.ReadAllText("arquivos/vendasTipoNulo.json");

List<VendaTipoNulo> listaVenda=JsonConvert.DeserializeObject<List<VendaTipoNulo>>(conteudoArquivo);

foreach (VendaTipoNulo venda in listaVenda)
{
    System.Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco},"+
     $"Data da venda: {venda.DataVenda} Desconto: {(venda.Desconto.HasValue?$"Desconto de: " +
     $"{venda.Desconto}":"Não tem desconto")}");
}


