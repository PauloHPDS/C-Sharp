using System.Diagnostics.Contracts;

// Tipos Nulos

bool? desejaReceberEmail = null;

if (desejaReceberEmail.HasValue&&desejaReceberEmail.Value){
//ou
// if (desejaReceberEmail!=null&&desejaReceberEmail.Value){
    Console.WriteLine("O usuário optou por receber e-mail.");

}else{
    Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail.");

}