using System;
using MediaAlunos;

namespace FloripaMaisTec { 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a quantidade de alunos?");          //Solicita a quantidade de alunos, atraves dela vamos ter o tamanho do array.
            int n = int.Parse(Console.ReadLine());              //Entrada de dados pelo usuário, o qual da o valor a variavel 'n'.

            AverageStudents[] averages = new AverageStudents[n];            //Cria o array, com o tamanho definida pelo usuario na variavel 'n'.

            for (int i = 0; i < n; i++)             //A variavel 'i' recebe valor zero, enquanto 'i' for menor que 'n' a estruura de repetição vai repetir a açao. A cada repetição 'i' soma +1  (i++).

            {
                Console.WriteLine("Name:  ");           //Saída de dados, na qual solicita ao usuário o nome.
                string names = Console.ReadLine();          //Entrada de dados, names recebe os dados     
                Console.WriteLine("Notes:  ");           //Saída de dados, solicitando notas
                double notes = double.Parse(Console.ReadLine());            //Entrada de dados, notes recebe os dados
                averages[i] = new AverageStudents { Name = names, Note = notes };           //Todas as entradas, names foram armazenados em Name e notes foram armazenados em Note

            }

            foreach (AverageStudents average in averages)           //comando executavel para todos os elementos do array
            {
                Console.Write(average.Name + ": ");         //Saída de dados (Name) + espaço

                if (average.Note >= 6)          //Se a condição for maior ou igual a 6 o aluno esta aprovado
                {
                    Console.WriteLine("Aprovado!");     //Saida de dados, aprovado
                }
                else                    //Se o elemento não se enquandrar na condição acima, entao o aluno esta reprovado.
                {
                    Console.WriteLine("Reprovado!");             //Saida de dados, reprovado
                }
            }
        }   
    }
}