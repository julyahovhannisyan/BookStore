using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1
{
    public class BookStoreContext1 : DbContext
    {
        public DbSet<Book> Books { get; set; }
        //public DbSet<Author> Authors { get; set; }
        //public DbSet<CoverType> CoverTypes { get; set; }
        //public DbSet<Genre> Genres { get; set; }
        //public DbSet<GlobalLanguage> GlobalLanguages { get; set; }

        //string connectionString = "server=localhost; port=3306; database=BookStoreDB; user=root; password=123123";

        public BookStoreContext1(DbContextOptions<BookStoreContext1> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Book");

            //modelBuilder.Entity<Book>().Property(u => u.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            //modelBuilder.Entity<Book>().Property(u => u.Title).HasColumnType("nvarchar(50)").IsRequired();
            //modelBuilder.Entity<Book>().Property(u => u.OriginalTitle).HasColumnType("nvarchar(50)").IsRequired();

            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        //}
    }
}

