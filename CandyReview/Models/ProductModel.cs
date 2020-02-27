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

        public string Image { get; set; }
        public virtual ICollection<ReviewModel> Reviews { get; set; }

        public ProductModel()
        {

        }

        public ProductModel(int id, string name, string category, string image)
        {
            Id = id;
            Name = name;
            Category = category;
            Image = image;
        }
    }


}
