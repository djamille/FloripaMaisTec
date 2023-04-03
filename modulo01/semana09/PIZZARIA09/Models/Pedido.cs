using System.IO;

namespace PIZZARIA09.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public int PizzaId { get; set; }

        //propriedade de navegação
        public virtual Pizza Pizza { get; set; }
        public virtual Status Status { get; set; }
    }
}
