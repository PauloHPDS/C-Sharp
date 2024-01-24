// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
using Exemplo_Explorando.models;



///Desconstrutor
///

    Pessoa p1 = new Pessoa("Paulo","Henrique");
    (string nome,string sobrenome)= p1;
    Console.WriteLine($"{nome} {sobrenome}");
