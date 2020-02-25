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

        public void Create(ProductModel obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductModel obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> GetAll()
        {
            return db.Products;
        }
        public ProductModel GetById(int id)
        {
            return db.Products.Single(p => p.Id == id);
        }

        public void Update(ProductModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
