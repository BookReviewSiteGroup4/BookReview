using BookReview.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReview.Data
{
    public class DbCon : IdentityDbContext
    {
        public DbCon(DbContextOptions<DbCon> options) : base(options)
        {

        }

        public DbCon()
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasIndex(x => x.ISBN).IsUnique();

            //modelBuilder.Entity<Book>().HasMany(c => c.Reviews).WithOne(e => e.book);

            //modelBuilder.Entity<Author>().ToTable("Author");
            //modelBuilder.Entity<Book>().ToTable("Book");
            //modelBuilder.Entity<Review>().ToTable("Review");
        }

       

        public DbSet<Author> Author {get;set;}
        public DbSet<Book> Book { get; set; }
        public DbSet<Review> Review { get; set; }
    }


}
