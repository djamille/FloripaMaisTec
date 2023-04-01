using System.Diagnostics.Metrics;
using System;
using System.Runtime.InteropServices;
using M1S09.Models;
using M1S09.Models.Configuracoes;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using M1S09.Models.Configuracoes;

namespace M1S09;

public class LojaContext : DbContext
{
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Compra> Compras { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Promocao> Promocoes { get; set; }
    public DbSet<ProdutoPromocao> ProdutosPromocoes { get; set; }

    //public LojaContexto(DbContextOptions<LojaContexto> options) : base(options)
    //{

    //}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=MILLE\\SQLEXPRESS;User ID=sa;Password=220202;Database=Lojinha;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    if (!optionsBuilder.IsConfigured)
    //         optionsBuilder.UseSqlServer(""Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False")
    // }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CompraConfiguration());
        modelBuilder.ApplyConfiguration(new ClienteConfiguration());
        modelBuilder.ApplyConfiguration(new ProdutoPromocaoConfiguration());
    }
}























// Nos projetos no estilo SDK como este, vários atributos de assembly que sempre eram
// definidos nesse arquivo agora são adicionados automaticamente durante o build e
// populados com os valores definidos nas propriedades do projeto. Para obter detalhes
// de quais atributos são incluídos e como personalizar esse processo, confira: https://aka.ms/assembly-info-properties


// A definição de ComVisible como false torna os tipos neste assembly invisíveis para
// os componentes do COM. Se for necessário acessar um tipo do COM neste assembly,
// defina o atributo ComVisible como true nesse tipo.

//--[assembly: ComVisible(false)]

// O GUID a seguir será destinado à ID de typelib se este projeto for exposto ao COM.

//--[assembly: Guid("0584cd7f-42d7-4d85-aeb6-afb116c65ce8")]