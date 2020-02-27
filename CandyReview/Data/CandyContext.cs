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
                    Name = "Peeps",
                    Category = "Marshmallow",
                    Image = "peeps.jpg"
                },

                new ProductModel()
                {
                    Id = 2,
                    Name = "Sour Patch Kids",
                    Category = "Sour",
                    Image = "sourpatchkids.jpg"
                },

                new ProductModel()
                {
                    Id = 3,
                    Name = "Hershey's Kisses",
                    Category = "Chocolate",
                    Image = "hersheykisses.jpg"
                });

            modelBuilder.Entity<ReviewModel>().HasData(

                new ReviewModel()
                {
                    Id = 1,
                    Content = "Why wouldn't you just eat a marshmallow..? Peeps make for a very fun s'more though.",
                    Reviewer = "Josh",
                    Rating = 5,
                    Date = "2/26/20",
                    ProductId = 1
                },

                  new ReviewModel()
                  {
                    Id = 2,
                    Content = "God awful. Please do not spend money on these.",
                    Reviewer = "Rhianna",
                    Rating = 1,
                    Date = "2/26/20",
                    ProductId = 1
                  },

                  new ReviewModel()
                  {
                    Id = 3,
                    Content = "They are the perfect combination of chewy and sour",
                    Reviewer = "Tatyana",
                    Rating = 4,
                    Date = "2/26/20",
                    ProductId = 2
                  },

                  new ReviewModel()
                  {
                    Id = 4,
                    Content = "First, they're sour. Then, they're sweet.",
                    Reviewer = "Rob",
                    Rating = 5,
                    Date = "2/26/20",
                    ProductId = 2
                  },

                  new ReviewModel()
                  {
                    Id = 5,
                    Content = "I mean, it's chocolate. You can't really go wrong here.",
                    Reviewer = "Josh",
                    Rating = 4,
                    Date = "2/26/20",
                    ProductId = 3
                  },

                  new ReviewModel()
                  {
                    Id = 6,
                    Content = "I find myself accidentally eating the entire bag. Chocolate is always A+",
                    Reviewer = "Rhianna",
                    Rating = 5,
                    Date = "2/26/20",
                    ProductId = 3
                  }) ;

            base.OnModelCreating(modelBuilder);


        }
    }
}
