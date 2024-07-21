using Application.Interfaces;
using Domain.Entities;
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


        [HttpGet("[Action]/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_videogameService.GetById(id));
        }

        [HttpPost("[Action]")]
        public IActionResult Create(Videogame videogame)
        {
            try
            {
                return Ok(_videogameService.Add(videogame));
            }
            catch (Exception ex)
            { 
                return StatusCode(500, "Error al crear el videojuego: " + ex.Message);
            }
        }



    }
}
