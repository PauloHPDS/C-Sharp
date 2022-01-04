using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace GestordeClientesCMD
{
    internal class Program {
        [System.Serializable]
        struct Cliente{
            public string nome;
            public string email;
            public string cpf;
        }
        static List<Cliente> clientes = new List<Cliente>();
        enum Menu{ Listagem=1, Adicionar=2, Remover=3,Sair=4 }
        
        static void Main(string[] args){
            Carregar();
            bool EscolheuSair = false;
            while (!EscolheuSair) { 
                Console.WriteLine("Sistema de Clientes - Bem Vindo!");
                Console.WriteLine("1-Listagem\n2-Adicionar\n3-Remover\n4-Sair");
                Console.WriteLine("");
                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                switch (opcao) {
                    case Menu.Adicionar:
                        Adicionar();
                    break;
                    case Menu.Remover:
                        Remover();
                    break;
                    case Menu.Listagem:
                        Listagem();
                    break;
                    case Menu.Sair:
                        EscolheuSair=true;
                    break;
                }
                Console.Clear();
            }

        }
        static void Adicionar() { 
            Cliente cliente = new Cliente();
            Console.WriteLine("Cadastro de Cliente: ");
            Console.WriteLine("Nome do Cliente: ");
            cliente.nome = Console.ReadLine();
            Console.WriteLine("Email do Cliente: ");
            cliente.email= Console.ReadLine();
            Console.WriteLine("Cpf do Cliente: ");
            cliente.cpf = Console.ReadLine();

            clientes.Add(cliente);
            Salvar();
            Console.WriteLine("Cadastro concluido, aperte Enter para sair.");
            Console.ReadLine();
            
        }
        static void Listagem() {
            if (clientes.Count > 0){
                Console.WriteLine("Lista de Clientes: ");
                int i = 0;
                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine($"ID: {i}");
                    Console.WriteLine($"Nome: {cliente.nome}");
                    Console.WriteLine($"E-mail: {cliente.email}");
                    Console.WriteLine($"CPF: {cliente.cpf}");
                    Console.WriteLine("=================================");
                    i++;
                }
                Console.WriteLine("Aperte Enter para sair.");
                Console.ReadLine();
            }
            else { 
                Console.WriteLine("Nenhum cliente cadastrado.");
                Console.WriteLine("Aperte Enter para sair.");
                Console.ReadLine();
            }
            

        }
        static void Salvar() {
            FileStream stream = new FileStream("clients.dat",FileMode.OpenOrCreate);
            BinaryFormatter enconder = new BinaryFormatter();
            enconder.Serialize(stream,clientes);
            stream.Close();
        }
        static void Carregar() {
            FileStream stream = new FileStream("clients.dat", FileMode.OpenOrCreate);
            try {
                BinaryFormatter enconder = new BinaryFormatter();
                clientes = (List<Cliente>)enconder.Deserialize(stream);
                if (clientes==null) { clientes = new List<Cliente>(); }
                
            } catch (Exception e) { 
                clientes = new List<Cliente>();
            }
            stream.Close();
        }
        static void Remover() {
            Listagem();
            Console.WriteLine("Digite o ID do cliente que voce quer remover: ");
            int id = int.Parse(Console.ReadLine());
            if (id>=0&&id<clientes.Count) { 
                clientes.RemoveAt(id);
                Salvar();
            } else {
                Console.WriteLine("ID digitado é invalido.");
                Console.ReadLine();
            }
        }
    }
}
