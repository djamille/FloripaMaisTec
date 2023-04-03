namespace PIZZARIA09.Models
{
    public class Borda
    {
        public int Id { get; set; }
        public string NomeBorda { get; set; }

        public virtual ICollection<Pizza> Pizzas { get; set; }
    }
}
