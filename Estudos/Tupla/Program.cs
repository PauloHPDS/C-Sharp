// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;

//   Tupla

// Tipo de Criação 1 (Recomendada)
(int Id, string Nome, string Sobrenome,decimal Altura) tupla = (01,"Paulo","Henrique", 1.80M);

Console.WriteLine($"Id: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");
//  Tipo de Criação 2
Console.WriteLine("-------------");
ValueTuple<int, string, string,decimal> tupla2 =(02,"Hosana","Morais", 1.50M);

Console.WriteLine($"Id: {tupla2.Item1}");
Console.WriteLine($"Nome: {tupla2.Item2}");
Console.WriteLine($"Sobrenome: {tupla2.Item3}");
Console.WriteLine($"Altura: {tupla2.Item4}");
// Tipo de Criação 3
Console.WriteLine("-------------");
var tupla3=Tuple.Create(03,"Francisca","Pereira", 1.70M);
Console.WriteLine($"Id: {tupla3.Item1}");
Console.WriteLine($"Nome: {tupla3.Item2}");
Console.WriteLine($"Sobrenome: {tupla3.Item3}");
Console.WriteLine($"Altura: {tupla3.Item4}");


