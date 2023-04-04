namespace PizzariaM1S09.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string NomeStatus { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
