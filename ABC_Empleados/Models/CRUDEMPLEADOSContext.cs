using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ABC_Empleados.Models
{
    public partial class CRUDEMPLEADOSContext : DbContext
    {
        public CRUDEMPLEADOSContext()
        {
        }

        public CRUDEMPLEADOSContext(DbContextOptions<CRUDEMPLEADOSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Estatus> Estatuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-671DNAK\\SQLEXPRESS; database=CRUDEMPLEADOS; integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Apellido_Materno");

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Apellido_Paterno");

                entity.Property(e => e.EstatusId).HasColumnName("Estatus_Id");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Nacimiento");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.EstatusId)
                    .HasConstraintName("FK__Empleados__Estat__3D5E1FD2");
            });

            modelBuilder.Entity<Estatus>(entity =>
            {
                entity.ToTable("Estatus");

                entity.Property(e => e.EstatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("Estatus_Id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
