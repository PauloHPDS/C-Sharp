// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;


////// Queue/Fila -FIFO- First In First Out//////

Queue<int> fila = new Queue<int>();

fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

    Console.WriteLine($"Removendo elemento: {fila.Dequeue()}");
    fila.Enqueue(5);

foreach (int item in fila)
{
    Console.WriteLine(item);
}
