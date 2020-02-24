using CandyReview.Data;
using CandyReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyReview.Repositories
{
    public class ReviewRepository : IRepository<ReviewModel>
    {
        private CandyContext db;
        public ReviewRepository(CandyContext db)
        {
            this.db = db;
        }

        public void Create(ReviewModel review)
        {
            db.Reviews.Add(review);
            db.SaveChanges();
        }

        public IEnumerable<ReviewModel> GetAll()
        {
            return db.Reviews;
        }
        public ReviewModel GetById(int id)
        {
            return db.Reviews.Single(p => p.Id == id);
        }
    }
}
