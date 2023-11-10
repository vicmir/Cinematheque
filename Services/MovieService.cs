using System.Collections.Generic;
using HelloWebApi.Interfaces.Repositories;
using HelloWebApi.Interfaces.Services;
using HelloWebApi.Models;

namespace HelloWebApi.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Movie GetMovieById(int id)
        {
            return _movieRepository.GetMovieById(id);
        }

        public List<Movie> GetMovies(out int totalCount)
        {
            totalCount = _movieRepository.GetMoviesTotalCount();

            return _movieRepository.GetMovies();
        }

        public Movie AddMovie(Movie movie)
        {
            return _movieRepository.AddMovie(movie);
        }
    }
}
