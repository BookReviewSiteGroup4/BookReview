using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReview.Models
{
    public class DbCon : DbContext
    {
        public DbCon(DbContextOptions<DbCon> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 1,
                FullName = "Paul Tannenberg",
                Birtdate = new DateTime(1970-01-01),
                DeathDate = new DateTime(1970 - 01 - 02),
            });
        }




        public DbSet<Author> Author {get;set;}
        public DbSet<Book> Book { get; set; }
        public DbSet<Review> Review { get; set; }
    }


}
