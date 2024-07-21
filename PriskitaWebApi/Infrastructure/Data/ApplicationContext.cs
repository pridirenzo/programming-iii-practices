using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ApplicationContext : DbContext
    {

        // mapeo de entidades a tablas
        public DbSet<Videogame> Videogames { get; set; }
        public DbSet<Review> Reviews { get; set; }

        // constructor para configurar el contexto
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }


        // METODO model creating- definir relaciones entre entidades 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Videogame>()
                .HasMany(v => v.Reviews) // un videojuego contiene muchas reviews
                .WithOne() // cada review pertenece a un solo videojuego
                .OnDelete(DeleteBehavior.Cascade); // asegura q si se elimina la entidad, se eliminan las relacionadas

            modelBuilder.Entity<Review>()
                .HasOne(r => r.videogame) // entidad review tiene propiedad tipo Videogame
                .WithMany(v => v.Reviews) // cada videojuego perteneces a muchas reviews
                .HasForeignKey(r => r.VideogameId) // clave foranea en entidad Review, q referencia al id del videogame
                .OnDelete(DeleteBehavior.Cascade);


            base.OnModelCreating(modelBuilder);
        }
    }
}
