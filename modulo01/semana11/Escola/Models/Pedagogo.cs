namespace Escola.Models
{
    public class Pedagogo : Pessoa
    {
        public int Cod { get; set; }
        public int QtdAtendimento { get; set; }


        public virtual ICollection<Atendimento> Atendimentos { get; set; }
    }
}
