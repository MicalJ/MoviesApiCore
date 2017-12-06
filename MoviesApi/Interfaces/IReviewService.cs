using MoviesApi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Interfaces
{
    public interface IReviewService
    {
        List<Review> GetAll();

        void AddReview(Review review);

        void UpdateReview(Review review);

        void RemoveReview(int id);
    }
}
