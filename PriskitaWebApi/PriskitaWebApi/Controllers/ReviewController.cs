using Application.Interfaces;
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
        public IActionResult GetById(int id)
        {
            return Ok(_reviewService.GetById(id));
        }

        [HttpGet("[Action]")]
        public IActionResult GetAll()
        {
            return Ok(_reviewService.GetAll());
        }


        [HttpDelete("[Action]")]
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
            return Ok(_reviewService.Add(review));
        }




    }
}
