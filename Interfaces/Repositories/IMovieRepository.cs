using System.Collections.Generic;
using HelloWebApi.Models;

namespace HelloWebApi.Interfaces.Repositories
{
    public interface IMovieRepository
    {
        List<Movie> GetMovies();

        int GetMoviesTotalCount();

        Movie GetMovieById(int id);

        Movie AddMovie(Movie movie);
    }
}
