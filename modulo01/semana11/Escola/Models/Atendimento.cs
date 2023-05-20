namespace Escola.Models
{
    public class Atendimento
    {
        public int Cod { get; set; }
        public int AlunoCod { get; set; }
        public int PedagogoCod { get; set; }


        public virtual Aluno Aluno { get; set; }
        public virtual Pedagogo Pedagogo { get; set; }
    }
}
