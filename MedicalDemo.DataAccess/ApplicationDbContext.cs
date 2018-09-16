using JetBrains.Annotations;
using MedicalDemo.Entities.DataBase;
using Microsoft.EntityFrameworkCore;

namespace MedicalDemo.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public ApplicationDbContext()
        {
                       
        }

        public DbSet<Alergia> Alergias { get; set; }
        public DbSet<ExpedienteMedico> ExpedientesMedicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Alergia>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nombre).IsRequired();
                entity.Property(e => e.FechaDeAlta).IsRequired();
            });
                                    
            modelBuilder.Entity<ExpedienteMedico>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.NumeroExpediente).IsRequired();
                entity.Property(e => e.FechaUltimaConsulta).IsRequired();
                entity.HasMany(e => e.Alergias);
            });
        }



    }
}
