using System.Globalization;
using System.Text;
using Escola.Controllers;
using Escola.Models;
using Escola.Dtos;

namespace Escola.Repositories;

//[M1S08] Exercicio 5- Criar uma classe, contendo uma lista estática
public class AlunosRepository
{
    private static List<AlunoModel> lista = new List<AlunoModel>(){         //Lista estática criada com novas inclusões de AlunoModel
        new AlunoModel { Id = 1, Nome = "João Souza"},
        new AlunoModel { Id = 2, Nome = "Maria da Silva"},
        new AlunoModel { Id = 3, Nome = "José Lima"}
    };


    //[M1S08] Exercicio 6- Criar método para listar alunos
    public List<AlunoModel> ListarAlunos(string filtroNome)
    {
        if (string.IsNullOrEmpty(filtroNome))                       //Se for null ou vazia, retorna LISTA COMPLETA
            return lista;
        else
            return lista.Where(z => z.Nome.ToLower().RemoverAcentos().Contains(filtroNome.ToLower().RemoverAcentos())) //Se for informado algum valor, retorna od dados referentes ao valor informado
            .OrderBy(x => x.Id)                         //Ordena por Id
            .ToList();
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
        Alunos.DataDeAlteracao = DateTime.Now;

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

public static class StringExtension
{
    public static string RemoverAcentos(this string text)
    {
        StringBuilder sbReturn = new StringBuilder();
        var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
        foreach (char letter in arrayText)
        {
            if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                sbReturn.Append(letter);
        }
        return sbReturn.ToString();
    }
}