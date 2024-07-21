using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class VideogameRepository : IVideogameRepository
    {

        // inyeccion de dependencia ( contexto)
        private readonly ApplicationContext _context;

        public VideogameRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Videogame? GetById(int id)
        {
            return _context.Videogames.FirstOrDefault(x => x.Id == id);
        }
        public Videogame Add(Videogame videogame)
        {
            _context.Add(videogame);
            _context.SaveChanges();
            return videogame;
        }

        public void Delete(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }

        public void Update(int id)
        {
            _context.Update(id);
            _context.SaveChanges();
        }

        public List<Videogame> GetAll()
        {
            return _context.Videogames.ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }


    }
}
