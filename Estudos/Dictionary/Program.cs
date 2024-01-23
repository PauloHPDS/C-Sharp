// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;


/////Dictionary

Dictionary<string, string> estados= new Dictionary<string,string>();
estados.Add("CE","Ceará");
estados.Add("SP","São Paulo");
estados.Add("MG","Minas Gerais");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
estados.Remove("MG");
estados["SP"]="São Paulo - Cidade";
Console.WriteLine("-------------");
foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
Console.WriteLine("-------------");
string chave="CE";
Console.WriteLine();
if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}else{
    Console.WriteLine($"Valor não existente: {chave}");
}
