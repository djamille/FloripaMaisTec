int n = 15;         //Já estava definido pelo exercício  tamanho do vetor, neste caso, 15.

Console.Write("Escreva o nome de quinze frutas. \n\n");           //Solicitando ao usuário que escreva as frutas.

string[] fruits = new string[n];            //Criando o vetor com o tipo string.

for (int i = 0; i < n; i++)         //Enquanto a variavel 'i' for menor que a variavel 'n', as informações digitadas pelo usuario serao gravadas de caixa em caixa no vetor.
{
    fruits[i] = Console.ReadLine();             //Entrada de dados, até preencher o tamanho do vetor.
}
;

Array.Sort(fruits);             //Colocando em ordem alfabetica
Console.Write("\nFrutas em ordem alfabética\n\n");          //Espaço entre informações digitadas pelo usuário e as mesmas em ordem alfabética.
foreach (string i in fruits) Console.WriteLine(i);          // Saida de dados em ordem alfabética.
