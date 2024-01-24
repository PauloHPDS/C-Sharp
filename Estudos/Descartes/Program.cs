// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
using Exemplo_Explorando.models;


/// Descartes
/// "_" utilizado para fazer o descarte de uma informação da tupla

LeituraArquivo arquivo=new LeituraArquivo();

var (sucesso,linhasArquivo, _)=arquivo.LerArquivo("arquivos/arquivoLeitura.txt");

if (sucesso)
{
    //Console.WriteLine("Quantidade de linhas no arquivo: "+ quantidadeLinhas);
    foreach (string linha in linhasArquivo){
        Console.WriteLine(linha);
    }
}else{
        System.Console.WriteLine("Não foi possivel ler o aquivo!");
}
