using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class VideogameService : IVideogameService
    {

        // inyeccion de dependencia (inyecto repositorio a servicio)
        private readonly IVideogameRepository _videogameRepository;

        public VideogameService(IVideogameRepository videogameRepository)
        {
            _videogameRepository = videogameRepository;
        }
        // ------------------------------------------------------------
        public Videogame GetById(int id)
        {
           return _videogameRepository.GetById(id);        
        }

        public void Delete(int id)
        {
            _videogameRepository.Delete(id);   // logica repository
        }

        public Videogame Add(Videogame videogame)
        {
            return _videogameRepository.Add(videogame); // logica repo
        }

        public List<Videogame> GetAll()
        {
            return _videogameRepository.GetAll();// logica repo
        }

        public void Update(int id)
        {
            _videogameRepository.Update(id); // logica repo
        }
 
    }
}
