using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IReviewService
    {
        public Review GetById(int id);
        public void Delete(int id);
        public List<Review> GetAll();
        public void Update(int id);
        public Review Add(Review review);

    }
}
