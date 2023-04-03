namespace Maternidade.Models
{
    public class Mae
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public DateTime Data_Nascimento { get; set; }

        //propriedade de navegação
        public virtual ICollection<Bebe> Bebes { get; set; }

    }
}
