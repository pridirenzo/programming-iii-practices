using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IVideogameService
    {

        public Videogame GetById(int id);
        public List<Videogame> GetAll();
        public Videogame Add(Videogame videogame);
        public void Update(int id);
        public void Delete(int id);
    }
}
