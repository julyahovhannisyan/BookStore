using BookStore.Database.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Database.Connection
{
    public class BookStoreContext : DbContext
    {
        public DbSet<BookEntity> Books { get; set; }
        public DbSet<AuthorEntity> Authors { get; set; }
        public DbSet<CoverTypeEntity> CoverTypes { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<GenreEntity> Genres { get; set; }
        public DbSet<GlobalLanguageEntity> GlobalLanguages { get; set; }

        string connectionString = "server=localhost; port=3306; database=BookStoreDB; user=root; password=123123; Persist Security Info=False; Connect Timeout=300";

        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {
            options = new DbContextOptions<BookStoreContext>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
