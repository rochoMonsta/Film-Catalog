using FilmCatalog.Models;
using Microsoft.EntityFrameworkCore;
namespace FilmCatalog.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserFilms> UserFilms { get; set; }
        public DbSet<Friends> Friends { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserFilms>()
                .HasKey(t => new { t.UserId, t.FilmId });

            modelBuilder.Entity<UserFilms>()
                .HasOne(sc => sc.Film)
                .WithMany(s => s.UserFilms)
                .HasForeignKey(sc => sc.FilmId);

            modelBuilder.Entity<UserFilms>()
                .HasOne(sc => sc.User)
                .WithMany(c => c.UserFilms)
                .HasForeignKey(sc => sc.UserId);

            //modelBuilder.Entity<Friends>()
            //    .HasKey(sc => new { sc.FirstUser, sc.SecondUser, sc.FriendsRelationshipStatus });

            //modelBuilder.Entity<Friends>()
            //    .HasOne(sc => sc.FirstUser)
            //    .WithMany(c => c.UserFriends)
            //    .HasForeignKey(sc => sc.FirstUserId);

            //modelBuilder.Entity<Friends>()
            //    .HasOne(sc => sc.SecondUser)
            //    .WithMany(c => c.UserFriends)
            //    .HasForeignKey(sc => sc.SecondUserId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FilmsDB;Trusted_Connection=True;");
        }
    }
}
