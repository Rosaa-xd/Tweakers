using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tweakers.Model
{
    public class ProductReview : Review
    {
        public int Score { get; set; }
        public string Explanation { get; set; }
        public List<Asset> Assets;

        public ProductReview(int id, User user, Product product, DateTime date, int score, string explanation)
            :base (id, user, product, date)
        {
            Score = score;
            Explanation = explanation;
        }

        public ProductReview(User user, Product product, DateTime date, int score, string explanation)
            : base(user, product, date)
        {
            Score = score;
            Explanation = explanation;
        }

        public ProductReview(User user, Product product, DateTime date, int score, string explanation,
            List<Asset> assets)
            :base (user, product, date)
        {
            Score = score;
            Explanation = explanation;
            Assets = assets;
        }
    }
}