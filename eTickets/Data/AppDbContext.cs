using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorMovieMap>().HasKey(am => new
            {
                am.ActorID,
                am.MovieID
            });

            modelBuilder.Entity<ActorMovieMap>().HasOne(m => m.Movie).WithMany(am => am.ActorMovieMaps).HasForeignKey(m => m.MovieID);
            modelBuilder.Entity<ActorMovieMap>().HasOne(m => m.Actor).WithMany(am => am.ActorMovieMaps).HasForeignKey(m => m.ActorID);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ActorMovieMap> ActorMovieMaps { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
