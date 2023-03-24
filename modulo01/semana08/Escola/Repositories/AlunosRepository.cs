using Escola.Models;

//[M1S08] Exercicio 5- Criar classe AlunoRepository, contenco uma lista estática
namespace Escola.Repositories;

public class AlunosRepository
{
    private static List<AlunoModels> lista = new List<AlunoModels>(){
        new AlunoModels { Id = 1, Nome = "João Souza"},
        new AlunoModels { Id = 2, Nome = "Maria da Silva"},
        new AlunoModels { Id = 3, Nome = "José Lima"}
    };
}