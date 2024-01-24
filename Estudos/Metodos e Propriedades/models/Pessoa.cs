using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Exemplo_Explorando.models
{
    public class Pessoa{

        
        public Pessoa(){
        }
        public Pessoa(string nome,string sobrenome){
            Nome=nome;
            SobreNome=sobrenome;
        }      
        public void Deconstruct(out string nome, out string sobrenome){
            nome=Nome;
            sobrenome=SobreNome;
        }  
        private string _nome;
        private int _idade;

         // Propriedades
        public string Nome{ 
            get=> _nome.ToUpper();            

            set{
                if (value==""){
                    throw new ArgumentException("O nome não pode ser vazio!");
                }
                _nome=value;
            }

        }
        public string SobreNome { get; set; }
        public string NomeCompleto => $"{Nome} {SobreNome}".ToUpper();
       
        public int Idade { 
            get=>_idade;
            set{
                if (value<0){
                    throw new ArgumentException("Idade não pode ser menor que 0!");
                }
                _idade=value;
            }
        }
        
        public void Apresentar(){
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}