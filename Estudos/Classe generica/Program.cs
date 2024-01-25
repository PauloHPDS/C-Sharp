// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
using Exemplo_Explorando.models;



/// Classe generica
///


MeuArray<int> arrayInteiro= new MeuArray<int>();

arrayInteiro.AdicionarElementoArray(30);

System.Console.WriteLine(arrayInteiro[0]);

MeuArray<string> arrayString= new MeuArray<string>();

arrayString.AdicionarElementoArray("teste");

System.Console.WriteLine(arrayString[0]);

