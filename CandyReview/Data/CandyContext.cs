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

            base.OnModelCreating(modelBuilder);

        }
    }
}
