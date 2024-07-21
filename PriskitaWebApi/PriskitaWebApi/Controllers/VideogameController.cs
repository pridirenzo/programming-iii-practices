using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PriskitaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideogameController : ControllerBase
    {

        // inyeccion d dependencia
        private readonly IVideogameService _videogameService;

        public VideogameController(IVideogameService videogameService)
        {
            _videogameService = videogameService;
        }

        [HttpGet("[Action]")]
        public IActionResult GetAll()
        {
            return Ok(_videogameService.GetAll());

        }

        [HttpGet("[Action]/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_videogameService.GetById(id));
        }

        [HttpPost("[Action]")]
        public IActionResult Create(Videogame videogame)
        {
           
           var createdVideogame = _videogameService.Add(videogame); // devuelvo 201 creado con exito

           return CreatedAtAction(nameof(Get), new { Id = createdVideogame.Id }, createdVideogame);
            
        }

        [HttpDelete("[Action]/{id}")]
        public IActionResult Delete(int id)
        {
            _videogameService.Delete(id);
            return NoContent();
        }

        [HttpPut("[Action]")]
        public IActionResult Update(int id)
        {
            _videogameService.Update(id);
            return NoContent(); 
        }

    }
}
