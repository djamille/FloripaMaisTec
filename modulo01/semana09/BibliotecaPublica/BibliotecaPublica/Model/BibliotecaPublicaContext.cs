using System.Diagnostics.Metrics;
using System;
using System.Runtime.InteropServices;
using BibliotecaPublica.Model;
using BibliotecaPublica.Model.Configurations;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using BibliotecaPublica.Model.Configurations;
using System.Collections.Generic;


namespace BibliotecaPublica.Model
{
    public class BibliotecaPublicaContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<LivroAutor> LivrosAutores { get; set; }
        public DbSet<Livro> Livros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
        optionsBuilder.UseSqlServer("Data Source=MILLE\\SQLEXPRESS;User ID=sa;Password=220202;Database=BibliotecaPublica;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AutorConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new LivroConfiguration());
            modelBuilder.ApplyConfiguration(new LivroAutorConfiguration());
        }

    }
}
