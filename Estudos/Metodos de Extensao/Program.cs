// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
using Exemplo_Explorando.models;



////Métodos de Extensão
///

int n = 20;
bool ePar=false;

//if ternario
ePar=  n.EPar();
System.Console.WriteLine($"{n} é "+(ePar ? "par":"impar"));
