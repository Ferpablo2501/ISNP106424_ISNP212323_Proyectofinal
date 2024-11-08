using Microsoft.EntityFrameworkCore;
using ISNP106424_ISNP212323_Proyectofinal.Models;
namespace ISNP106424_ISNP212323_Proyectofinal.Models {
    public class MyDbContext : DbContext {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet <Peliculas> Peliculas { get; set; }
        public DbSet <Alquiler> Alquiler { get; set; }
        public DbSet <Clientes> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Peliculas>().HasKey(peliculas => peliculas.IdPeliculas);
            modelBuilder.Entity<Alquiler>().HasKey(alquiler => alquiler.IdAlquiler);    
            modelBuilder.Entity<Clientes>().HasKey(Clientes => Clientes.IdCliente);

        }
    }
}
