using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandyReview.Data;
using CandyReview.Models;

namespace CandyReview.Repositories
{
    public class ProductRepository : IRepository<ProductModel>
    {
        private CandyContext db;
        public ProductRepository(CandyContext db)
        {
            this.db = db;
        }


        public IEnumerable<ProductModel> GetAll()
        {
            return db.Products;
        }
        public ProductModel GetById(int id)
        {
            return db.Products.Single(p => p.Id == id);
        }
    }
}
