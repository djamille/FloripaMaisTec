
using TDD_semana05;


Calculadora.Adicao(5, 5);
Calculadora.Adicao(0.5, 0.5);
Calculadora.Adicao(5.6f, 5.6f);
Calculadora.Adicao(4.7M, 4.7M);
Calculadora.Adicao(30001L, 30009L);

Console.WriteLine("--------------------------------------");

Calculadora.Subtracao(15, 5);
Calculadora.Subtracao(0.9, 0.2);
Calculadora.Subtracao(15.55F, 7.05F);
Calculadora.Subtracao(11.599M, 5.590M);
Calculadora.Subtracao(56789L, 54321L);

Console.WriteLine("--------------------------------------");

Calculadora.Multiplicacao(5, 5);
Calculadora.Multiplicacao(4.5, 4.5);
Calculadora.Multiplicacao(0.9F, 0.5F);
Calculadora.Multiplicacao(5.608M, 10.5M);
Calculadora.Multiplicacao(9999999L, 9563L);

Console.WriteLine("--------------------------------------");

Calculadora.Divisao(515, 5);
Calculadora.Divisao(50, 5);
Calculadora.Divisao(3.003F, 3F);
Calculadora.Divisao(5628.908M, 2.2M);
Calculadora.Divisao(8461328479413266L, 8L);

Console.WriteLine("--------------------------------------");

ValidadorDeNumeros.DivisivelPor(15, 3);
ValidadorDeNumeros.DivisivelPor(10, 3);
ValidadorDeNumeros.ENumeroPrimo(5);
ValidadorDeNumeros.ENumeroPrimo(10);
ValidadorDeNumeros.ParOuImpar(7);
ValidadorDeNumeros.ParOuImpar(20);