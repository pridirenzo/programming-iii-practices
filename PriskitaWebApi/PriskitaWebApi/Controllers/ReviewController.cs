using Application.Interfaces;
using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PriskitaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {

        // inyeccion d servicio
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }


        [HttpGet("[Action]")]
        public IActionResult Get(int id)
        {
            return Ok(_reviewService.GetById(id));
        }

        [HttpGet("[Action]")]
        public IActionResult GetAll()
        {
            return Ok(_reviewService.GetAll());
        }


        [HttpDelete("[Action]/{id}")]
        public IActionResult Delete(int id)
        {
            _reviewService.Delete(id);
            return NoContent();
        }

        [HttpPut("[Action]")]
        public IActionResult Update(int id)
        {
            _reviewService.Update(id);
            return NoContent();
        }

        [HttpPost("[Action]")]
        public IActionResult Add(Review review)
        {
            var createdReview = _reviewService.Add(review); // devuelvo 201 creado con exito

            return CreatedAtAction(nameof(Get), new { Id = createdReview.Id }, createdReview);

        }




    }
}
