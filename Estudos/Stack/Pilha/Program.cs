// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;

//// Stack/Pilha - LIFO - Last In First Out

Stack<int> pilha = new Stack<int>();

pilha.Push(1);
pilha.Push(2);
pilha.Push(3);
pilha.Push(4);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

    Console.WriteLine($"Removendo elemento: {pilha.Pop()}");
    pilha.Push(5);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}
