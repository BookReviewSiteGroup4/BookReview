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

        public DbSet<Author> Author {get;set;}
        public DbSet<Book> Book { get; set; }
        public DbSet<Review> Review { get; set; }

        
    }
}
