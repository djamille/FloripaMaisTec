using System;
using System.Collections.Generic;

namespace PizzariaM1S09.Models
{
    public class Borda
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Pizza> Pizzas { get; set; }
    }
}
