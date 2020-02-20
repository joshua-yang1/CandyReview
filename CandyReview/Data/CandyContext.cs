using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CandyReview.Models;

namespace CandyReview.Data
{
    public class CandyContext : DbContext
    {
        public DbSet<ReviewModel> Reviews { get; set; }
        public DbSet<ProductModel> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=CandyReview;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().HasData(
                new ProductModel()
                {
                    Id = 1,
                    Name = "Swedish Fish",
                    Category = "Chewy"
                },

                new ProductModel()
                {
                    Id = 2,
                    Name = "Starburst",
                    Category = "Chewy"
                },

                new ProductModel()
                {
                    Id = 3,
                    Name = "Heath Bar",
                    Category = "Chocolate"
                });

            ModelBuilder.Entity<ReviewModel>().HasData(

                new ReviewModel()
                {
                    Id = 1,
                    Content = "Review",
                    Reviewer = "Corleeone",
                    Rating = 3,
                    Date = "july 32nd, 2020",
                    ProductId = 1
                },

                  new ReviewModel()
                  {
                    Id = 2,
                    Content = "Review",
                    Reviewer = "Jake",
                    Rating = 2,
                    Date = "January 1st, 1893",
                    ProductId = 1
                  },

                  new ReviewModel()
                  {
                    Id = 3,
                    Content = "Review",
                    Reviewer = "Jackie Fredrickson",
                    Rating = 1,
                    Date = "THE END TIMES",
                    ProductId = 2
                  },

                  new ReviewModel()
                  {
                    Id = 4,
                    Content = "Review",
                    Reviewer = "Becky with the good hair",
                    Rating = 47,
                    Date = "33 BC",
                    ProductId = 2
                  },

                  new ReviewModel()
                  {
                    Id = 5,
                    Content = "Review",
                    Reviewer = "Johnny Pearseed",
                    Rating = 0,
                    Date = "Day 1",
                    ProductId = 3
                  },

                  new ReviewModel()
                  {
                    Id = 6,
                    Content = "Review",
                    Reviewer = "Harriet Tubman",
                    Rating = 5,
                    Date = "Decemberuary 4th, 3112",
                    ProductId = 3
                  }) ;

            base.OnModelCreating(modelBuilder);


        }
    }
}
