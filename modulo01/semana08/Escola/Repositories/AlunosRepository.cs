using System.Globalization;
using System.Text;
using Escola.Controllers;
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

//[M1S08] Exercicio 6- Criar metodo para listar alunos
    public List<AlunoModels> ListarAlunos(string filtroNome)
    {

        if (string.IsNullOrEmpty(filtroNome))
            return lista;
        else
            return lista.Where(z => z.Nome.ToLower().RemoverAcentos().Contains(filtroNome.ToLower().RemoverAcentos()))
            .OrderBy(x => x.Id)
            .ToList();
    }

    public Alunos? ObterAlunos(int id)
    {
        return lista.FirstOrDefault(x => x.Id == id);
    }

    public Alunos AtualizarAlunos(int id, AlunosDto dto)
    {

        var Alunos = ObterAlunos(id);
        lista.Remove(alunos);

        Alunos.CargaHoraria = dto.CargaHoraria;
        Alunos.Nome = dto.Nome;
        Alunos.DataDaAlteracao = DateTime.Now;

        lista.Add(alunos);

        return alunos;
    }

    public Alunos CriarDisciplina(AlunosDto dto)
    {

        var Alunos = new Alunos();
        Alunos.Id = GerarId();
        Alunos.Nome = dto.Nome;

        lista.Add(Alunos);

        return Alunos;
    }

    public void ExcluirDisciplina(int id)
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