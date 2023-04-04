using System;
using System.Collections.Generic;

namespace PizzariaScaffold.Models;

public partial class Pedido
{
    public int Id { get; set; }

    public string? IdPizza { get; set; }

    public string? IdStatus { get; set; }
}
