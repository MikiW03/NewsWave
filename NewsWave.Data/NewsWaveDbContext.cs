using Microsoft.EntityFrameworkCore;
using NewsWave.Data.Entities;

namespace NewsWave.Data
{
    public class NewsWaveDbContext : DbContext
    {
        private readonly string connectionString;

        public NewsWaveDbContext(string connectionString)
        {
            ArgumentNullException.ThrowIfNull(connectionString);
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Value should not be empty.", nameof(connectionString));

            this.connectionString = connectionString;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Bookmark> Bookmarks { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Preference> Preferences { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UserRole> UsersRoles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<NewsAuthor> NewsAuthors { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.connectionString);
        }
    }
}
