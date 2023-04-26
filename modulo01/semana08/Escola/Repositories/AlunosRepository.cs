using System.Globalization;
using System.Text;
using Escola.Dtos;
using Escola.Models;

namespace Escola.Repositories;

//[M1S08] Exercicio 5- Criar uma classe, contendo uma lista estática
public class AlunosRepository
{
    private static List<AlunoModel> lista = new List<AlunoModel>(){         //Lista estática criada com novas inclusões de AlunoModel
        new AlunoModel { Id = 1, Nome = "Joao", DataNascimento = new DateTime(1984, 12, 13), DataInclusao = DateTime.Now, DataAlteracao = DateTime.Now },
        new AlunoModel { Id = 2, Nome = "Maria Joao", DataNascimento = new DateTime(1998, 01, 01), DataInclusao = DateTime.Now, DataAlteracao = DateTime.Now },
        new AlunoModel { Id = 3, Nome = "Jose", DataNascimento = new DateTime(2001, 10, 01), DataInclusao = DateTime.Now, DataAlteracao = DateTime.Now },
        new AlunoModel { Id = 4, Nome = "Maria Clara", DataNascimento = new DateTime(1999, 11, 20), DataInclusao = DateTime.Now, DataAlteracao = DateTime.Now },
        new AlunoModel { Id = 5, Nome = "Pedro", DataNascimento = new DateTime(1990, 03, 01), DataInclusao = DateTime.Now, DataAlteracao = DateTime.Now },
        new AlunoModel { Id = 6, Nome = "Cleber", DataNascimento = new DateTime(2009, 08, 13), DataInclusao = DateTime.Now, DataAlteracao = DateTime.Now },
        new AlunoModel { Id = 7, Nome = "Jaime", DataNascimento = new DateTime(1990, 01, 31), DataInclusao = DateTime.Now, DataAlteracao = DateTime.Now },
        new AlunoModel { Id = 8, Nome = "Carlota Maria", DataNascimento = new DateTime(1980, 07, 21), DataInclusao = DateTime.Now, DataAlteracao = DateTime.Now },
        new AlunoModel { Id = 9, Nome = "Veronica", DataNascimento = new DateTime(2011, 09, 15), DataInclusao = DateTime.Now, DataAlteracao = DateTime.Now },
        new AlunoModel { Id = 10, Nome = "Renan", DataNascimento = new DateTime(2015, 01, 01), DataInclusao = DateTime.Now, DataAlteracao = DateTime.Now },
    };


    //[M1S08] Exercicio 6- Criar método para listar alunos
    public List<AlunoModel> ListarAlunos(string filtroNome)
    {
        if (string.IsNullOrEmpty(filtroNome))                       //Se for null ou vazia, retorna LISTA COMPLETA
        {
            return lista;
        }
        else
        {
            return lista.Where(z => z.Nome.ToLower().Contains(filtroNome.ToLower()))                      //Se for informado algum valor, retorna od dados referentes ao valor informado
            .OrderBy(x => x.Id)                         //Ordena por Id
            .ToList();
        }
    }
    //[M1S08] Exercício 9- Criar método para obter aluno por Id
    public AlunoModel? ObterAlunos(int id)                          //'?' opcional
    {
        return lista.FirstOrDefault(x => x.Id == id);                       //Pesquisa se tem algum objeto com o Id informado, se tiver retorna o mesmo
    }


    public AlunoModel AtualizarAlunos(int id, AlunoDto dto)
    {

        var Alunos = ObterAlunos(id);                       //Chamando o método ObterAlunos pelo Id
        lista.Remove(Alunos);                        //Remover da lista o aluno                          

        Alunos.Id = dto.Id;                       //Atualizando os valores dos atributos de Aluno
        Alunos.Nome = dto.Nome;
        Alunos.DataAlteracao = DateTime.Now;

        lista.Add(Alunos);                          //Chama o método de add alunos

        return Alunos;                          //Retorna Alunos
    }


    //[M1S08] Exercício 10- Criar método para criar aluno 
    public AlunoModel CriarAluno(AlunoDto dto)
    {

        var Alunos = new AlunoModel();
        Alunos.Id = GerarId();
        Alunos.Nome = dto.Nome;

        lista.Add(Alunos);

        return Alunos;
    }


    //[M1S08] Exercício 1- Criar método para excluir aluno 
    public void ExcluirAluno(int id)
    {
        var Alunos = lista.FirstOrDefault(a => a.Id == id);                       //Pesquisa se tem algum objeto com o Id informado, se tiver retorna o mesmo. Senao retorna null

        if (Alunos != null)
            lista.Remove(Alunos);
    }

    private int GerarId()
    {
        return lista.Last().Id + 1;
    }
}


