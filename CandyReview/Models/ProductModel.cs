using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyReview.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Review { get; set; }

        public ProductModel()
        {

        }

        public ProductModel(int id, string name, string category, string review)
        {
            Id = id;
            Name = name;
            Category = category;
            Review = review;
        }
    }


}
