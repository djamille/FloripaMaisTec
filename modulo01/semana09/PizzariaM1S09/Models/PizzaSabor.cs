namespace PizzariaM1S09.Models
{
    public class PizzaSabor
    {
        public int Id { get; set; }
        public int PizzaId { get; set; }
        public int SaborId { get; set; }

        //propriedade de navegação
        public virtual Pizza Pizza { get; set; }
        public virtual Sabor Sabor { get; set; }

    }
}
