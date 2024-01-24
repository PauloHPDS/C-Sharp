// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
using Exemplo_Explorando.models;


//Try e Catch

try{
string[] linhas = File.ReadAllLines("arquivos/arquivoLeitura.txt");
foreach (string linha in linhas){
    Console.WriteLine(linha);
}
}catch(FileNotFoundException ex){
    Console.WriteLine("Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. "+ex.Message);
}catch(DirectoryNotFoundException ex){
    Console.WriteLine("Ocorreu um erro na leitura do arquivo. Caminho não encontrado. " +ex.Message);
}catch(Exception ex){
    Console.WriteLine("Ocorreu uma exceção generica. "+ex.Message);
}finally{
    Console.WriteLine("Chegou até aqui!");
}

