// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
using Exemplo_Explorando.models;


// Metodos e Propriedades

Pessoa p1 = new Pessoa(nome:"Paulo",sobrenome:"Henrique");
Pessoa p2 = new Pessoa(nome:"Hosana",sobrenome:"Morais");

Curso cursoDeIngles=new Curso();
cursoDeIngles.Nome="Ingles";
cursoDeIngles.Alunos=new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
