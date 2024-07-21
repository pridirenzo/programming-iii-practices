using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IReviewRepository
    {
        public void Delete(int id);
        public Review? GetById(int id);
        public void SaveChanges();
        public void Update(int id);
        public Review Add(Review review);
        public List<Review> GetAll();

    }
}
