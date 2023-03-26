using System.Globalization;
using System.Text;
using Escola.Controllers;
using Escola.Models;
using Escola.Dtos;

//[M1S08] Exercicio 5- Criar classe AlunoRepository, contendo uma lista estática
namespace Escola.Repositories;

public class AlunosRepository
{
    private static List<AlunoModel> lista = new List<AlunoModel>(){
        new AlunoModel { Id = 1, Nome = "João Souza"},
        new AlunoModel { Id = 2, Nome = "Maria da Silva"},
        new AlunoModel { Id = 3, Nome = "José Lima"}
    };

//[M1S08] Exercicio 6- Criar metodo para listar alunos
    public List<AlunoModel> ListarAlunos(string filtroNome)
    {

        if (string.IsNullOrEmpty(filtroNome))
            return lista;
        else
            return lista.Where(z => z.Nome.ToLower().RemoverAcentos().Contains(filtroNome.ToLower().RemoverAcentos()))
            .OrderBy(x => x.Id)
            .ToList();
    }

    public AlunoModel? ObterAlunos(int id)
    {
        return lista.FirstOrDefault(x => x.Id == id);
    }

    public AlunoModel AtualizarAlunos(int id, AlunoDto dto)
    {

        var Alunos = ObterAlunos(id);
        lista.Remove(Alunos);

        Alunos.Id = dto.Id;
        Alunos.Nome = dto.Nome;
        Alunos.DataDeAlteracao = DateTime.Now;

        lista.Add(Alunos);

        return Alunos;
    }

    public AlunoModel CriarAluno(AlunoDto dto)
    {

        var Alunos = new AlunoModel();
        Alunos.Id = GerarId();
        Alunos.Nome = dto.Nome;

        lista.Add(Alunos);

        return Alunos;
    }

    public void ExcluirAluno(int id)
    {
        var Alunos = lista.FirstOrDefault(a => a.Id == id);

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