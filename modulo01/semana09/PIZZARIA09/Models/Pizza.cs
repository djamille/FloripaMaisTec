namespace PIZZARIA09.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public int MassaId { get; set; }
        public int BordaId { get; set; }

        //propriedade de navegação
        public virtual Pizza Pizzas { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual ICollection<PizzaSabor> Pizza_Sabores { get; set; }

    }
}
