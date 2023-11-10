using System.Collections.Generic;
using HelloWebApi.Models;

namespace HelloWebApi.Interfaces.Services
{
    public interface IMovieService
    {
        Movie GetMovieById(int id);

        List<Movie> GetMovies(out int totalCount);
        
        Movie AddMovie(Movie movie);
    }
}
