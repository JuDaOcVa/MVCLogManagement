using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Prj_JDOV_LogMngmtSerilogMoviesWebApp.Models;

public partial class BdJdovLaboratorio4Context : DbContext
{
    public BdJdovLaboratorio4Context()
    {
    }

    public BdJdovLaboratorio4Context(DbContextOptions<BdJdovLaboratorio4Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BD_JDOV_Laboratorio4;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>(entity =>
        {
            entity.Property(e => e.MovDateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Mov_DateCreated");
            entity.Property(e => e.MovDirector)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Mov_Director");
            entity.Property(e => e.MovName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Mov_Name");
            entity.Property(e => e.MovType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Mov_Type");
            entity.Property(e => e.MovWorldWideGross)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Mov_WorldWideGross");
            entity.Property(e => e.MovYear).HasColumnName("Mov_Year");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
