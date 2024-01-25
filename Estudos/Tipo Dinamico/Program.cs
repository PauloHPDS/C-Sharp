// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;


///Tipo dinamico
///

dynamic variavelDinamica = 4;

Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, valor: {variavelDinamica}");

variavelDinamica = "Texto";

Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, valor: {variavelDinamica}");

variavelDinamica = true;

Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, valor: {variavelDinamica}");


