namespace PizzariaM1S09.Models
{
    public class Sabor
    {
        public int Id { get; set; }
        public string NomeSabor { get; set; }

        public virtual ICollection<PizzaSabor> PizzasSabores { get; set; }
    }
}
