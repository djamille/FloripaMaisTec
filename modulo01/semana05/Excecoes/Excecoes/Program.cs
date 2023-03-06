using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Digite dois números decimais:");             //Imprime na tela a orientação para o usuário

            Console.WriteLine("Digite o primeiro número decimal:");             //Imprime na tela a solcitação ao usuário
            decimal numero1 = decimal.Parse(Console.ReadLine());             //Entrada de dados fornecida pelo usuário
            Console.WriteLine("Digite segundo número decimal:");             //Imprime na tela a solcitação ao usuário
            decimal numero2 = decimal.Parse(Console.ReadLine());             //Entrada de dados fornecida pelo usuário

            decimal resultado = numero1 / numero2;              //variavel resultdo recebe o total da divisão realizada com os valores fornecidos pelo usuario

            Console.WriteLine(resultado);               //Imprime na tela o resultado.
        }
        catch (DivideByZeroException ex)            //tratando erro
        {
            Console.WriteLine("Erro específico identificado: {0}. \n\nNão é possível dividir por zero!", ex);  //Imprime na tela a mensagem e o tipo de erro.
        }
        catch (FormatException ex)            //tratando erro
        {
            Console.WriteLine("Erro específico identificado: {0}. \n\nLetras não podem ser informadas. Digite apenas números!", ex);  //Imprime na tela a mensagem e o tipo de erro.
        }
        catch (Exception ex) //Tratando erro
        {
            Console.WriteLine("Ocorreu um erro. Identificdo como: {0}.",ex);  //Imprime na tela a mensagem e o tipo de erro.
        }
        finally //Finalizando
        {
            decimal numero1 = 0;            //atribuido valor as variaveis,, conforme solicitado no exercicio
            decimal numero2 = 0;
            Console.WriteLine("\n\nZerando os valores solicitados ao usuário. \nPrimeiro número:{0}\nSegundo número: {1}\nFinalizando.\n\n", numero1,numero2);          //Imprime na tela a finalização
        }
    }

}