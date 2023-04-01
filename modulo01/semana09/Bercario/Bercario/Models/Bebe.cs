namespace Bercario.Models
{
    public class Bebe
    {
        public int Id { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public decimal Peso_Nascimento { get; set; }
        public int Altura { get; set; }
        public int MaeId { get; set; }
        public int PartoId { get; set; }

        //propriedade de navegação
        public virtual Parto Parto { get; set; }
        public virtual Mae Mae { get; set; }
    }
}
