using Microsoft.EntityFrameworkCore;

namespace L01P02_2020ZR601_2021RR604.Models
{
    public class blogContext : DbContext
    {
        public blogContext(DbContextOptions options) : base(options) 
        { 

        }
        public DbSet<usuarios> usuarios { get; set; }
        public DbSet<publicaciones> publicaciones { get; set; }
        public DbSet<calificaciones> calificaciones { get; set; }
        public DbSet<comentarios> comentarios { get; set; }

    }
}
