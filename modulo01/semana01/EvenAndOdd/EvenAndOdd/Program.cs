using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;

namespace FloripaMaisTec
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<int> even = new List<int>();               //Criado Lista even
            List<int> odd = new List<int>();               //Criado Lista odd



            for (int i = 0; i < 10; i++)             
            {
                Console.WriteLine("Enter an integer: ");               //Solicita a entrada de DEZ números inteiros     
                int number = int.Parse(Console.ReadLine());               //Entrada de dados fornecida pelo usuário
                if (number % 2 ==0)               //Se o número fornecido for divisível por dois e o resto da divisão for zero é um número par
                {
                    even.Add(number);               //Então será adicionado a lista de números pares
                }
                else               //Senão...
                {
                    odd.Add(number);               //Será adicionado na lista de números ímpares
                }
                
            }

            Console.WriteLine("\n\nEven numbers");               //Saída de dados

            even.Sort();               //Ordenação crescente

            foreach (int i in even)               //Percorre todos os elementos da lista 
            {
                Console.WriteLine(i);               //Imprime na tela elemento por elemento
            }
                                    
            int resultEven = even.Sum();               //Soma 
            Console.WriteLine("The list of odd numbers has {0} numbers and the sum of them is equal to {1}", even.Count, resultEven);           //Imprime na tela o número de elementos presente na lista e a soma dos mesmos

            Console.WriteLine("\n\n---------------------------------");
            Console.WriteLine("\n\nOdd numbers");

            odd.Sort();               //Ordenação crescente

            foreach (int i in odd)               //Percorre todos os elementos da lista
            {
                Console.WriteLine(i);               //Imprime na tela elemento por elemento
            }
            
            int resultOdd = odd.Sum();               //Soma 
            Console.WriteLine("The list of odd numbers has {0} numbers and the sum of them is equal to {1}", odd.Count, resultOdd);           //Imprime na tela o número de elementos presente na lista e a soma dos mesmos
        }
            
    }
}
