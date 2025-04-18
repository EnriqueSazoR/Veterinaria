using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Veterinaria.Modelos;

namespace Veterinaria.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Colocar acá todos los modelos creados.
        public DbSet<Cita> Cita { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Mascota> Mascota { get; set; }
        public DbSet<Sucursal> Sucursal { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de la relación Usuario -> Cita
            modelBuilder.Entity<Cita>()
                .HasOne(c => c.usuario)
                .WithMany(u => u.Citas)
                .HasForeignKey(c => c.IdUsuario)
                .OnDelete(DeleteBehavior.Restrict); // Evita cascada

            // Configuración de la relación Mascota -> Cita
            modelBuilder.Entity<Cita>()
                .HasOne(c => c.mascota)
                .WithMany(m => m.Citas)
                .HasForeignKey(c => c.IdMascota)
                .OnDelete(DeleteBehavior.Restrict); // Evita cascada

            // Configuración de la relación Sucursal -> Cita
            modelBuilder.Entity<Cita>()
                .HasOne(c => c.sucursal)
                .WithMany(s => s.Citas)
                .HasForeignKey(c => c.IdSucursal)
                .OnDelete(DeleteBehavior.Restrict); // Evita cascada

            // Configuración de la relación Usuario -> Mascota
            modelBuilder.Entity<Mascota>()
                .HasOne(m => m.usuario)
                .WithMany(u => u.Mascotas)
                .HasForeignKey(m => m.IdUsuario)
                .OnDelete(DeleteBehavior.Restrict); // Evita cascada
        }


    }
}
