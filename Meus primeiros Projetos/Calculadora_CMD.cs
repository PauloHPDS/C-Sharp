using System;

public class HelloWorld{
    enum Menu { Soma=1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair}
    public static void Main(string[] args){
        //Calculadora
        bool escolheuSair=false;
        while(!escolheuSair){
            Console.WriteLine ("Seja Bem Vindo a Calculadora. Selecione uma opcao.");
        Console.WriteLine("1-Soma\n2-Subtracao\n3-Divisao\n4-Multiplicacao\n5-Potencia\n6-Raiz\n7-Sair");
        Menu opcao=(Menu)int.Parse(Console.ReadLine());
        Console.WriteLine(opcao);
        switch(opcao){
            case Menu.Soma:
                Soma();
            break;
            case Menu.Subtracao:
                Subtracao();
            break;
            case Menu.Multiplicacao:
                Mult();
            break;
            case Menu.Divisao:
                Divisao();
            break;
            case Menu.Potencia:
                Potencia();
            break;
            case Menu.Raiz:
                Raiz();
            break;
            case Menu.Sair:
                escolheuSair=true;
            break;
        }
        Console.Clear();
        }
        
        
    }
    static void Soma(){
        Console.WriteLine("Soma de dois numeros.");
        Console.WriteLine("Digite o primeriro numero: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero");
        int n2 = int.Parse(Console.ReadLine());
        int res=n1+n2;
        Console.WriteLine($"O resultado da Soma e: {res}");
        Console.WriteLine("Pressione Enter para sair.");
        Console.ReadLine();
    }
    static void Subtracao(){
        Console.WriteLine("Subtracao de dois numeros.");
        Console.WriteLine("Digite o primeriro numero: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero");
        int n2 = int.Parse(Console.ReadLine());
        int res=n1-n2;
        Console.WriteLine($"O resultado da Subtracao e: {res}");
        Console.WriteLine("Pressione Enter para sair.");
        Console.ReadLine();
    }
    static void Mult(){
        Console.WriteLine("Multiplicacao de dois numeros.");
        Console.WriteLine("Digite o primeriro numero: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero");
        int n2 = int.Parse(Console.ReadLine());
        int res=n1*n2;
        Console.WriteLine($"O resultado da Multiplicacao e: {res}");
        Console.WriteLine("Pressione Enter para sair.");
        Console.ReadLine();
    }
    static void Divisao(){
        Console.WriteLine("Divisao de dois numeros.");
        Console.WriteLine("Digite o primeriro numero: ");
        float n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero");
        float n2 = float.Parse(Console.ReadLine());
        float res=n1/n2;
        Console.WriteLine($"O resultado da Divisao e: {res}");
        Console.WriteLine("Pressione Enter para sair.");
        Console.ReadLine();
    }
    static void Potencia(){
        Console.WriteLine("Potencia de um numero.");
        Console.WriteLine("Digite o numero base");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o expoente");
        int n2 = int.Parse(Console.ReadLine());
        int res=(int)Math.Pow(n1,n2);
        Console.WriteLine($"O resultado da Potencia e: {res}");
        Console.WriteLine("Pressione Enter para sair.");
        Console.ReadLine();
    }
    static void Raiz(){
        Console.WriteLine("Raiz de um numero.");
        Console.WriteLine("Digite o numero: ");
        float n1 = float.Parse(Console.ReadLine());
        double res =  Math.Sqrt(n1);
         Console.WriteLine($"O resultado da Raiz e: {res}");
        Console.WriteLine("Pressione Enter para sair.");
        Console.ReadLine();
    }
}