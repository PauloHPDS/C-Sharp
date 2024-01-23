// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;

//// IF Ternario

int n = 20;
bool ePar=false;

//if ternario
ePar= n % 2 == 0;
System.Console.WriteLine($"{n} é "+(ePar ? "par":"impar"));

//if normal

if (n%2==0){
    System.Console.WriteLine($"{n} é par");
}else{
    System.Console.WriteLine($"{n} é impar");
}

