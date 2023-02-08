// Importação de bibliotecas

// Nome de Classes

//Declaração de método

//Declaração de variáveis
int opcao, numero1 = 0, numero2 = 0;
float resultado = 0;

//Entradas
Console.Write("Escolha uma operação: \n\n" +
    "1 - soma\n2 - subtração\n3 - multiplicação\n4 - divisão\n" +
    "5 - sair\n\nDigite a opção escolhida: ");
opcao = int.Parse(Console.ReadLine());

//Processamento
switch(opcao)
{
    //Bloco de instruções da estrutura condicional
    case 1:
        Console.WriteLine("Operação somar.");
        Console.Write("Digite o numero 1.");
        numero1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o numero 2.");
        numero2 = int.Parse(Console.ReadLine());
        resultado = numero1 + numero2;
        break;
    case 2:
        Console.WriteLine("Operação subtrair.");
        Console.Write("Digite o numero 1.");
        numero1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o numero 2.");
        numero2 = int.Parse(Console.ReadLine());
        resultado = numero1 - numero2;
        break;
    case 3:
        Console.WriteLine("Operação multiplicar.");
        Console.Write("Digite o numero 1.");
        numero1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o numero 2.");
        numero2 = int.Parse(Console.ReadLine());
        resultado = numero1 * numero2;
        break;
    case 4:
        Console.WriteLine("Operação dividir.");
        Console.Write("Digite o numero 1.");
        numero1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o numero 2.");
        numero2 = int.Parse(Console.ReadLine());
        resultado = numero1 / numero2;
        break;
    case 5:
        Console.WriteLine("Sair");
        break;
    case >=6:
        break;
}
if (opcao <= 5) {
    Console.WriteLine("Resultado:" + resultado);
}
else
{
    Console.WriteLine("A opção escolhida está incorreta!");
}

//Saídas