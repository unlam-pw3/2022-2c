using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EnciclopediaDarwin.Data.Entidades
{
    public partial class _20222CEnciclopediaDarwinContext : DbContext
    {
        public _20222CEnciclopediaDarwinContext()
        {
        }

        public _20222CEnciclopediaDarwinContext(DbContextOptions<_20222CEnciclopediaDarwinContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Especie> Especies { get; set; } = null!;
        public virtual DbSet<TipoEspecie> TipoEspecies { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=2022-2C-Enciclopedia-Darwin;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Especie>(entity =>
            {
                entity.HasKey(e => e.IdEspecie);

                entity.ToTable("Especie");

                entity.Property(e => e.Nombre).HasMaxLength(200);

                entity.Property(e => e.PesoPromedioKg).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdTipoEspecieNavigation)
                    .WithMany(p => p.Especies)
                    .HasForeignKey(d => d.IdTipoEspecie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Especie_TipoEspecie");
            });

            modelBuilder.Entity<TipoEspecie>(entity =>
            {
                entity.HasKey(e => e.IdTipoEspecie);

                entity.ToTable("TipoEspecie");

                entity.Property(e => e.IdTipoEspecie).ValueGeneratedNever();

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
