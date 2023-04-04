using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PizzariaScaffold.Models;

public partial class PizzariaScaffoldContext : DbContext
{
    public PizzariaScaffoldContext()
    {
    }

    public PizzariaScaffoldContext(DbContextOptions<PizzariaScaffoldContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Borda> Bordas { get; set; }

    public virtual DbSet<Massa> Massas { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Pizza> Pizzas { get; set; }

    public virtual DbSet<PizzaSabore> PizzaSabores { get; set; }

    public virtual DbSet<Sabore> Sabores { get; set; }

    public virtual DbSet<StatusPizza> StatusPizzas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=MILLE\\SQLEXPRESS;Database=Pizzaria;User ID=sa;Password=220202;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Borda>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bordas__3214EC07AA084E04");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOME");
        });

        modelBuilder.Entity<Massa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Massas__3214EC07DA4D124A");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOME");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pedido__3214EC075571F628");

            entity.ToTable("Pedido");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdPizza)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Id_Pizza");
            entity.Property(e => e.IdStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Id_Status");
        });

        modelBuilder.Entity<Pizza>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pizza__3214EC072A263AE5");

            entity.ToTable("Pizza");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdBordas)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Id_Bordas");
            entity.Property(e => e.IdMassa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Id_Massa");
        });

        modelBuilder.Entity<PizzaSabore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pizza_Sa__3214EC07B0C18025");

            entity.ToTable("Pizza_Sabores");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdPizza)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Id_Pizza");
            entity.Property(e => e.IdSabores)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Id_Sabores");
        });

        modelBuilder.Entity<Sabore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sabores__3214EC07B2809D21");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOME");
        });

        modelBuilder.Entity<StatusPizza>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Status_P__3214EC07613212AC");

            entity.ToTable("Status_Pizza");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
