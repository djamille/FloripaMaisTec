using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PIZZARIA09.Models;

public partial class Pizzaria09Context : DbContext
{
    public Pizzaria09Context()
    {
    }

    public Pizzaria09Context(DbContextOptions<Pizzaria09Context> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=MILLE\\SQLEXPRESS;Database=PIZZARIA09;User ID=sa;Password=220202;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
