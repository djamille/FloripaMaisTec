using System.IO;

namespace PizzariaM1S09.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        public int MassaId { get; set; }

        public int BordaId { get; set; }

        public virtual Massa Massa { get; set; }
        public virtual Borda Borda { get; set; }

        public virtual ICollection<PizzaSabor> PizzasSabores { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
