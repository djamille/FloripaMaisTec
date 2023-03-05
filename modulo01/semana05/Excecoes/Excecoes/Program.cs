using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Digite dois números decimais:");

            Console.WriteLine("Digite o primeiro número decimal:");
            decimal numero1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite segundo número decimal:");
            decimal numero2 = decimal.Parse(Console.ReadLine());

            decimal resultado = numero1 / numero2;

            Console.WriteLine(resultado);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Erro específico identificado: {0}. \n\nNão é possível dividir por zero!", ex);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Erro específico identificado: {0}. \n\nLetras não podem ser informadas. Digite apenas números!", ex);
        }
        catch (Exception ex) //Tratando erro
        {
            Console.WriteLine("Ocorreu um erro. Identificdo como: {0}.",ex);  //Imprime na tela a mensage e o tipo de erro.
        }
        finally //Finalizando
        {
            decimal numero1 = 0;
            decimal numero2 = 0;
            Console.WriteLine("\n\nZerando os valores solicitados ao usuário. \nPrimeiro número:{0}\nSegundo número: {1}\nFinalizando.\n\n", numero1,numero2);
        }
    }

}