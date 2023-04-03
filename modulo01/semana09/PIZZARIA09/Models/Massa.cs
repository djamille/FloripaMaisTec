namespace PIZZARIA09.Models
{
    public class Massa
    {
        public int Id { get; set; }
        public string NomeMassa { get; set; }

        public virtual ICollection<Pizza> Pizzas { get; set; }
    }
}
