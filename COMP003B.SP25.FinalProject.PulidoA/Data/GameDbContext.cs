using COMP003B.SP25.FinalProject.PulidoA.Models;
using Microsoft.EntityFrameworkCore;
namespace COMP003B.SP25.FinalProject.PulidoA.Data
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options) : base(options) { }

        public DbSet<Game> Games { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Platform> Platforms { get; set; }

    }
}
