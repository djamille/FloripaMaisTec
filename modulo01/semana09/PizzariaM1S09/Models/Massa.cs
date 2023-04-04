namespace PizzariaM1S09.Models
{
    public class Massa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Pizza> Pizzas { get; set; }
    }
}
