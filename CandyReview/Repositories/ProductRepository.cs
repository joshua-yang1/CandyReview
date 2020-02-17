using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandyReview.Models;

namespace CandyReview.Repositories
{
    public class ProductRepository : IRepository<ProductModel>
    {
        public Dictionary<int, ProductModel> productDictionary;
        public ProductRepository()
        {
            productDictionary = new Dictionary<int, ProductModel>()
            {
                { 1, new ProductModel(1, "jawbreakers", "hard candy", "meh") },
                { 2, new ProductModel(2, "KitKats", "chocolate", "gimme a break") },
                { 3, new ProductModel(3, "reese's egg", "chocolate", "does not have an EGG to stand on") }
            };
        }
        public IEnumerable<ProductModel> GetAll()
        {
            return productDictionary.Values;
        }
        //public ProductModel GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
