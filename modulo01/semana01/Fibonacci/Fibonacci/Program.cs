int n1 = 0, n2 = 1, n3 = 0;

Console.Write("Digite qual será a quantidade de números calculados pela sequência de Fibonacci. \n\n");           //Solicitando ao usuário quantidade de numeros que deve ter a sequencia.
int fib = int.Parse(Console.ReadLine());            //Entrada de dados, pelo usuario.

int[] fibonacci = new int[fib];            //Criando o vetor com o tipo inteiro.

Console.WriteLine("Sequência de Fibonacci com " + fib + " números: ");
for (int i = 0; i < fib; i++)         //Enquanto a variavel 'i' for menor que a variavel 'fib', as informações digitadas pelo usuario serao gravadas de caixa em caixa no vetor.
{
    n3 = n1 + n2;         //Somatória 
    Console.Write(n3 + " ");          //Saida dados, imprime na tela o resultado
    n1 = n2;            //n1 passa a ter o valor de n2
    n2 = n3;            //n2 vai receber o valor de n3
}