using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;
using ScreenSound.Shared.Modelos.Modelos;


namespace ScreenSound.Banco
{
    public class ScreenSoundContext : DbContext
    {

        public DbSet<Artista> Artistas { get; set; }

        public DbSet<Musica> Musicas { get; set; }

        public DbSet<Genero> Generos { get; set; }



        private string connectionString = "Server=tcp:screensoundserver-web.database.windows.net,1433;Initial Catalog=screensoundserver;Persist Security Info=False;User ID=nicolas;Password=Onishi08!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public ScreenSoundContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                return;
            }
            optionsBuilder
                .UseSqlServer(connectionString)
                .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Musica>()
                .HasMany(c => c.Generos)
                .WithMany(c => c.Musicas);
        }



    }
}
