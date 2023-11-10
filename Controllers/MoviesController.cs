using HelloWebApi.ClientModels.Movies;
using HelloWebApi.Exceptions;
using HelloWebApi.Interfaces.Services;
using HelloWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var movies = _movieService.GetMovies(out var totalCount);

            var responseModel = new ResponseModel<Movie>
            {
                Data = movies,
                TotalCount = totalCount
            };

            return Ok(responseModel);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var movie = _movieService.GetMovieById(id);

            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }

        [HttpPost]
        public IActionResult Add([FromBody] MovieRequestModel requestModel)
        {
            var movie = new Movie
            {
                Id = requestModel.Id,
                Name = requestModel.Name,
                Year = requestModel.Year,
                Country = requestModel.Country,
                Director = requestModel.Director
            };

            try
            {
                var storedMovie = _movieService.AddMovie(movie);

                return Ok(storedMovie);
            }
            catch (BadOperationException exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, [FromBody] MovieRequestModel requestModel)
        {
            // Implementation
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            // Implementation
            return Ok();
        }
    }
}