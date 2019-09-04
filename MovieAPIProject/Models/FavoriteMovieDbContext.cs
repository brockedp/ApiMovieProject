using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace MovieAPIProject.Models
{
    public partial class FavoriteMovieDbContext : DbContext
    {
        private readonly IConfiguration Configuration;

        public FavoriteMovieDbContext()
        {
        }

        public FavoriteMovieDbContext(DbContextOptions<FavoriteMovieDbContext> options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
        }

        public virtual DbSet<FavoriteMovie> FavoriteMovie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<FavoriteMovie>(entity =>
            {
                entity.HasKey(e => e.MovieId)
                    .HasName("PK__Favorite__4BD2941AAEAC45C7");

                entity.Property(e => e.Actors).HasMaxLength(200);

                entity.Property(e => e.Director).HasMaxLength(200);

                entity.Property(e => e.Genre).HasMaxLength(200);

                entity.Property(e => e.Plot).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(200);
            });
        }
    }
}
