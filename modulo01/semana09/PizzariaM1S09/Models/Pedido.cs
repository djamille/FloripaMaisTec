namespace PizzariaM1S09.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        public int PizzaId { get; set; }

        public int StatusId { get; set; }

        public virtual Pizza Pizza { get; set; }
        public virtual Status Status { get; set; }
    }
}
