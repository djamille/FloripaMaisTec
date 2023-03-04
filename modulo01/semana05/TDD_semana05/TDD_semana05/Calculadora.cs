using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TDD_semana05
{
    public static class Calculadora
    {
        //EXERCICIO 04 [M1S05] Criação de Classe estatica com os metodos Soma, Subtracao, Multiplicacao e Divisao
        //EXERCICIO 05 [M1S05] Criação de sobrecarga para os metodos da classe, com tipos int, double, decimal e long
        //Operaçoes com tipo INT
        public static int Adicao(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine("Adição com números do tipo INT: {0} + {1} = {2}", a, b, resultado);
            return a + b;
        }

        public static int Subtracao(int a, int b)
        {
            int resultado = a - b;
            Console.WriteLine("Subtração com números do tipo INT: {0} - {1} = {2}", a, b, resultado);
            return a - b;
        }

        public static int Multiplicacao(int a, int b)
        {
            int resultado = a * b;
            Console.WriteLine("Multiplicação com números do tipo INT: {0} * {1} = {2}", a, b, resultado);
            return a * b;
        }

        public static int Divisao(int a, int b)
        {
            int resultado = a / b;
            Console.WriteLine("Divisão com números do tipo INT: {0} / {1} = {2}", a, b, resultado);
            return a / b;
        }


        //Operaçoes com tipo DOUBLE
        public static double Adicao(double a, double b)
        {
            double resultado = a + b;
            Console.WriteLine("Adição com números do tipo DOUBLE: {0} + {1} = {2}", a, b, resultado);
            return a + b;
        }

        public static double Subtracao(double a, double b)
        {
            double resultado = a - b;
            Console.WriteLine("Subtração com números do tipo DOUBLE: {0} - {1} = {2}", a, b, resultado);
            return a - b;
        }

        public static double Multiplicacao(double a, double b)
        {
            double resultado = a * b;
            Console.WriteLine("Multiplicação com números do tipo DOUBLE: {0} * {1} = {2}", a, b, resultado);
            return a * b;
        }

        public static double Divisao(double a, double b)
        {
            double resultado = a / b;
            Console.WriteLine("Divisão com números do tipo DOUBLE: {0} / {1} = {2}", a, b, resultado);
            return a / b;
        }


        //Operaçoes com tipo FLOAT
        public static float Adicao(float a, float b)
        {
            float resultado = a + b;
            Console.WriteLine("Adição com números do tipo FLOAT: {0} + {1} = {2}", a, b, resultado);
            return a + b;
        }

        public static float Subtracao(float a, float b)
        {
            float resultado = a - b;
            Console.WriteLine("Subtração com números do tipo FLOAT: {0} - {1} = {2}", a, b, resultado);
            return a - b;
        }

        public static float Multiplicacao(float a, float b)
        {
            float resultado = a * b;
            Console.WriteLine("Multiplicação com números do tipo FLOAT: {0} * {1} = {2}", a, b, resultado);
            return a * b;
        }

        public static float Divisao(float a, float b)
        {
            float resultado = a / b;
            Console.WriteLine("Divisão com números do tipo FLOAT: {0} / {1} = {2}", a, b, resultado);
            return a / b;
        }


        //Operaçoes com tipo DECIMAL
        public static decimal Adicao(decimal a, decimal b)
        {
            decimal resultado = a + b;
            Console.WriteLine("Adição com números do tipo DECIMAL: {0} + {1} = {2}", a, b, resultado);
            return a + b;
        }

        public static decimal Subtracao(decimal a, decimal b)
        {
            decimal resultado = a - b;
            Console.WriteLine("Subtração com números do tipo DECIMAL: {0} - {1} = {2}", a, b, resultado);
            return a - b;
        }

        public static decimal Multiplicacao(decimal a, decimal b)
        {
            decimal resultado = a * b;
            Console.WriteLine("Multiplicação com números do tipo DECIMAL: {0} * {1} = {2}", a, b, resultado);
            return a * b;
        }

        public static decimal Divisao(decimal a, decimal b)
        {
            decimal resultado = a / b;
            Console.WriteLine("Divisão com números do tipo DECIMAL: {0} / {1} = {2}", a, b, resultado);
            return a / b;
        }


        //Operaçoes com tipo LONG
        public static long Adicao(long a, long b)
        {
            long resultado = a + b;
            Console.WriteLine("Adição com números do tipo LONG: {0} + {1} = {2}", a, b, resultado);
            return a + b;
        }

        public static long Subtracao(long a, long b)
        {
            long resultado = a - b;
            Console.WriteLine("Subtração com números do tipo LONG: {0} - {1} = {2}", a, b, resultado);
            return a - b;
        }

        public static long Multiplicacao(long a, long b)
        {
            long resultado = a * b;
            Console.WriteLine("Multiplicação com números do tipo LONG: {0} * {1} = {2}", a, b, resultado);
            return a * b;
        }

        public static long Divisao(long a, long b)
        {
            long resultado = a / b;
            Console.WriteLine("Divisão com números do tipo LONG: {0} / {1} = {2}", a, b, resultado);
            return a / b;
        }

        
    }
}
