using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyReview.Models
{
    public class ReviewModel
    {
            public int Id { get; set; }
            public string Content { get; set; }
            public string Reviewer { get; set; }
            public int Rating { get; set; }
            public string Date { get; set; }

        public ReviewModel()
        {

        }

        public ReviewModel(int id, string content, string reviewer, int rating, string date)
        {
            Id = id;
            Content = content;
            Reviewer = reviewer;
            Rating = rating;
            Date = date;
        }
    }
}
