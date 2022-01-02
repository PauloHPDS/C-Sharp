using System;

public class HelloWorld{
    
    static void Maior_numero(int n1,int n2,int n3){
        if(n1==n2&&n2==n3){
            Console.WriteLine("Os 3 numeros sao iguais");
        }else if(n1>n2&&n1>n3){
            Console.WriteLine("n1 e maior");
        }else if(n2>n3&&n2>n3){
            Console.WriteLine("n2 e maior");
        }else{
            Console.WriteLine("n3 e maior");
        }
    }
    static void Menor_numero(int n1,int n2,int n3){
        if(n1==n2&&n2==n3){

        }else if(n1<n2&&n1<n3){
            Console.WriteLine("n1 e menor");
        }else if(n2<n3&&n2<n3){
            Console.WriteLine("n2 e menor");
        }else{
            Console.WriteLine("n3 e menor");
        }
    }
    
    public static void Main(string[] args){
        //Recebe 3 numeros, diz qual o maior e o menor ou se não iguais
        int n1, n2, n3;
        Console.WriteLine("Digite 3 Numeros: ");
        Console.WriteLine("Digite o Primeiro Numero: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o Segundo Numero: ");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o Terceiro Numero: ");
        n3 = int.Parse(Console.ReadLine());
        
        Maior_numero(n1,n2,n3);
        Menor_numero(n1,n2,n3);
        
    }
}