using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_semana05
{
    public static class ValidadorDeNumeros
    {
        ////EXERCICIO 06 [M1S05] Criação de metodo ENumeroPrimo, ParOuImpar e EDivisivelPor

        public static bool ENumeroPrimo(int number)             //Criação de método ENumeroPrimo
        {
            int contador = 0;            //Variavel contador recebe valor 0, com ela sera feita a contagem de números divisores de NUMBER com resto zero

            for (int y = 1; y <= number; y++)
            {
                if (number % y == 0)                    //Se o resto da divisao for 0 vai somar 1 ao COUNTER q iniciou com valor 0
                {
                    contador++;
                }
            }
            if (contador == 2)           //Se o contador for igual a 2 o número é primo e imprime a mensagem : O número é primo!
            {
                Console.WriteLine("O número {0} é primo!", number);
                return true;
            }
            else
            {
                Console.WriteLine("O número {0} NÂO é primo!", number);                 //Se for FALSE aparece mensagem de que não é primo
                return false;
            }

        }



        public static bool ParOuImpar(int a)
        {
            if (a % 2 == 00)
            {
                Console.WriteLine("O número {0} é par!", a);
                return true;
            }
            else
            {
                Console.WriteLine("O número {0} é impar!", a);
                return false;
            }
        }



        public static bool DivisivelPor(int dividendo, int divisor)
        {
            if (dividendo % divisor == 00)
            {
                Console.WriteLine("O número {0} é divisível por {1}!", dividendo, divisor);
                return true;
                
            }
            else
            {
                Console.WriteLine("O número {0} NÂO é divisível por {1}!", dividendo, divisor);
                return false;
                
            }
        }
    }
}
