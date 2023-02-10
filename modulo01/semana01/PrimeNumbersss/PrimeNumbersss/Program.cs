using System;
using System.Runtime.CompilerServices;

namespace NumberPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];            //Criando um vetor com dez posições
            int counter;

            for (int i = 0; i < 10; i++)             //A variavel 'i' recebe valor zero, enquanto 'i' for menor que DEZ a estruura de repetição vai repetir a açao. A cada repetição 'i' soma +1  (i++) e armazena a entrada de dados numa posição do array.
            {
                Console.WriteLine("Enter an integer: ");            //Solicita ao usuário que digite um numero inteiro
                numbers[i] = int.Parse(Console.ReadLine());             //Entrada de dados no vetor
            }

            for (int i = 0; i < numbers.Length; i++)            //A estrutura de repetição vai passar de posição em posição do vetor realizando a condição abaixo
            {
                counter = 0;            //Variavel recebe valor 0, com ela sera feita a contagem de números divisores de NUMBERS com resto zero
                
                for (int y = 1; y <= numbers[i]; y++)
                {
                    if (numbers[i] % y == 0)                    //Se o resto da divisao for 0 vai somar 1 ao COUNTER q iniciou com valor 0
                    {
                        counter++;
                    }
                }
                
                if (counter == 2)           //Se o contador for igual a 2 o número é primo e imprime a mensagem abaixo. O número é primo 
                {
                    Console.WriteLine("{0} is a prime number and is in position {1}.", numbers[i], i);          //Saída de dados
                }
                
            }

        }

    }

}