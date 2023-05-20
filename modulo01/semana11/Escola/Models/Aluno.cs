using Escola.Enums;

namespace Escola.Models
{
    public class Aluno : Pessoa
    {
        public int Cod { get; set; }
        public ESituacaoMatricula Situacao { get; set; }
        public float Nota { get; set; }
        public int QtdAtendimento { get; set; }


        public virtual ICollection<Atendimento> Atendimentos { get; set; }
    }
}
