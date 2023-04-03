using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PIZZARIA09.Models.Configurations;

namespace PIZZARIA09.Models
{
    public class Pizzaria09Context : DbContext
    {
        public DbSet<Borda> Bordas { get; set; }
        public DbSet<Massa> Massas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Sabores> Sabores { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<PizzaSabor> Pizzas_Sabores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MILLE\\SQLEXPRESS;Database=PIZZARIA09;User ID=sa;Password=220202;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BordaConfiguration());
            modelBuilder.ApplyConfiguration(new MassaConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new PizzaConfiguration());
            modelBuilder.ApplyConfiguration(new PizzaSaborConfiguration());
            modelBuilder.ApplyConfiguration(new SaboresConfiguration());
            modelBuilder.ApplyConfiguration(new StatusConfiguration());
        }

    }
}
