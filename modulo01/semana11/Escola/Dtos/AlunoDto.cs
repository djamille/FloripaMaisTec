using Escola.Enums;

namespace LabSchool.Dtos
{
    public class AlunoDto
    {
        public class AlunoCreateDto
        {
            public string Nome { get; set; }
            public string Telefone { get; set; }
            public DateTime DataNascimento { get; set; }
            public string CPF { get; set; }
            public ESituacaoMatricula Situacaoa { get; set; }
            public float Nota { get; set; }

        }
        /*
        public class DiretorDto
        {
            public string Cpf { get; set; }

        }

        public class FilmeCriacaoSaidaDto
        {

            public int Cod { get; set; }
            public string Nome { get; set; }
            public string Telefone { get; set; }
            public DateTime DataNascimento { get; set; }
            public string CPF { get; set; }
            public ESituacaoMatricula SituacaoMatricula { get; set; }
            public float Nota { get; set; }
            public int QtdAtendimento { get; set; }

        }

        public class FilmeAlteracaoDto
        {

            public string Titulo { get; set; }
            public string Genero { get; set; }

            public string ObterFrase()
            {

                return $"Filme {Titulo} de {Genero}";
            }
        */

    }
}
