using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    // interfaces d repositorio quedan a criterio del programador: o en domain o en application
    // metodos q actuaran sobre los datos.
    public interface IVideogameRepository
    {
        public Videogame Add(Videogame videogame);
        public void Update(int id);
        public void Delete(int id);
        public List<Videogame> GetAll();
        public Videogame? GetById(int id);
        public void SaveChanges(); // metodo d EF. para guardar cambios

    }
}
