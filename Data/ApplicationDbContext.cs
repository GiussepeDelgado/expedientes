using Microsoft.EntityFrameworkCore;
using GestionExpedientesAPI.Models;

namespace GestionExpedientesAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // DbSet que representa la tabla 'expediente' en la base de datos
        public DbSet<Expediente> Expedientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Opcionalmente, puedes agregar configuraciones específicas aquí si las necesitas
        }
    }
}
