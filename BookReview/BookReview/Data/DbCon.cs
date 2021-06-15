using BookReview.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReview.Data
{
    public class DbCon : DbContext
    {
        public DbCon(DbContextOptions<DbCon> options) : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasIndex(x => x.ISBN).IsUnique();

            modelBuilder.Entity<Book>().HasMany(c => c.Reviews).WithOne(e => e.book);

            modelBuilder.Entity<Author>().ToTable("Author");
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Review>().ToTable("Review");
        }

       

        public DbSet<Author> Author {get;set;}
        public DbSet<Book> Book { get; set; }
        public DbSet<Review> Review { get; set; }
    }


}
