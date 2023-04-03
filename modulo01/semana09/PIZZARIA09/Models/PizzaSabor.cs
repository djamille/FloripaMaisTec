namespace PIZZARIA09.Models
{
    public class PizzaSabor
    {
        public int Id { get; set; }
        public int PizzaId { get; set; }
        public int SaboresId { get; set; }

        //propriedade de navegação
        public virtual Pizza Pizzas { get; set; }
        public virtual Sabores Sabores { get; set; }
    }
}
