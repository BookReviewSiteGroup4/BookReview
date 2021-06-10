﻿using BookReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReview.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DbCon context)
        {
            context.Database.EnsureCreated();

            if (context.Book.Any())
            {
                return;   // DB has been seeded
            }
            else
            {

            }

            if (context.Author.Any())
            {
                return;   // DB has been seeded
            }
            else
            {
                var authors = new Author[]
                {   
                new Author{FullName ="Paul Tannenberg", Birtdate = new DateTime(1968,08,02), DeathDate = null}
                };

                foreach (Author a in authors)
                {
                    context.Author.Add(a);
                }

                context.SaveChanges();
            }

            
        }
    }
}
