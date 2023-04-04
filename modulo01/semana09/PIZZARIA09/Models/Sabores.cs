namespace PIZZARIA09.Models
{
    public class Sabores
    {
        public int Id { get; set; }
        public string Sabor { get; set; }

        public virtual ICollection<PizzaSabor> PizzasSabores{ get; set; }
    }
}
