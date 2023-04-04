using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PizzariaM1S09.Models.Configurations;
using PizzariaM1S09.Models;
using System.IO;

namespace PizzariaM1S09.Models
{
    public class PizzariaM1S09Context : DbContext
    {
        public DbSet<Borda> Bordas { get; set; }
        public DbSet<Massa> Massas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<PizzaSabor> PizzasSabores { get; set; }
        public DbSet<Sabor> Sabores { get; set; }
        public DbSet<Status> Status { get; set; }


        /* public BercarioContexto(DbContextOptions<BercarioContexto> options) : base(options)
          {

          }
          */


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MILLE\\SQLEXPRESS;Database=PizzariaM1S09;User ID=sa;Password=220202;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BordaConfiguration());
            modelBuilder.ApplyConfiguration(new MassaConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new PizzaConfiguration());
            modelBuilder.ApplyConfiguration(new PizzaSaborConfiguration());
            modelBuilder.ApplyConfiguration(new SaborConfiguration());
            modelBuilder.ApplyConfiguration(new StatusConfiguration());
        }
    }
}
