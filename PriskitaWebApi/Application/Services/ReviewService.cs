using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public Review GetById(int id)
        {
            return _reviewRepository.GetById(id);
        }
        public List<Review> GetAll()
        {
            return _reviewRepository.GetAll();
        }

        public void Delete(int id)
        {
            _reviewRepository.Delete(id);
        }
        public void Update(int id)
        {
            _reviewRepository.Update(id);
        }

        public Review Add(Review review)
        {
            return _reviewRepository.Add(review);
        }
    }
}
