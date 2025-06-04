using Microsoft.EntityFrameworkCore;
using RegistroCanciones_Backend.Entities;

namespace RegistroCanciones_Backend.Data
{
    public class RegistroCancionesContext : DbContext
    {
        public RegistroCancionesContext (DbContextOptions<RegistroCancionesContext> options)
            : base(options)
        {
        }

        public DbSet<Genero> Generos { get; set; }
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Cancion> Canciones { get; set; }
    }
}
