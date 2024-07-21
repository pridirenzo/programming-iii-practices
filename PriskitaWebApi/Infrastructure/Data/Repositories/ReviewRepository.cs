using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class ReviewRepository : IReviewRepository
    {

        // inyeccion de dependencia
        private readonly ApplicationContext _context;
        
        public ReviewRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }
        public Review? GetById(int id)
        {
            return _context.Reviews.FirstOrDefault(x => x.Id == id);
        }

        public List<Review> GetAll()
        {
            return _context.Reviews.ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(int id)
        {
            _context.Update(id);
            _context.SaveChanges();
        }

        public Review Add(Review review)
        {
            _context.Add(review);
            _context.SaveChanges();
            return review;
        }

    }
}
