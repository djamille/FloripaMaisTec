using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        FileInfo arquivo = null;            //Criação de variável - classe utilizada para criacao de arquivos fisicos na maquina
        try
        {
            Console.Write("Digite o nome do arquivo para criá-lo: ");           //Imprime na tela a mensagem
            string nomeArquivo = Console.ReadLine();            //Lendo a entrada de dados fornecida pelo usuário
            
            arquivo = new FileInfo(nomeArquivo);            //Instanciando
            
            using (StreamWriter gravadorTexto = File.AppendText(nomeArquivo))       //Fazendo um chamado para gravar um texto dentro da variavel arquivo
            { 
                gravadorTexto.WriteLine("Texto de dentro do arquivo.");         //Texto que sera escrito no arquivo que o usuario criou
            }
        }
        catch (System.ArgumentException ex)             //Exceção epecifica para determinado erro
         {
             Console.WriteLine("Ocorreu o erro: {0}.\n\nDigite um nome para o arquivo",ex.Message);         //Imprime o erro que ocorreu
         }
        catch (Exception ex)            //Exceção genérica
         {
             Console.WriteLine("Ocorreu o erro: {0}",ex.Message);          //Imprime o erro que ocorreu
        }
         finally            //finalizando
         { 
              Console.WriteLine("Encerrando programa... \n"); arquivo = null;           //Encerrando o programa atribuindo valor nulo a variavel arquivo
         }
        
    }
}


/*
 * Arquivo de texto criado esta localizado em ExcecoesEx2M1S05 -> bin -> Debug -> net6.0 -> teste.txt
 * 
 * Ao não digitar um nome para o arquivo, quando solicitado, o erro abaixo aparece.
 * Erro : Ocorreu o erro: The path is empty. (Parameter 'path'), tratado no catch (System.ArgumentException ex)
 * 
 */