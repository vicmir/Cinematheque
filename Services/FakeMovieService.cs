using System.Collections.Generic;
using HelloWebApi.Interfaces.Services;
using HelloWebApi.Models;

namespace HelloWebApi.Services
{
    public class FakeMovieService : IMovieService
    {
        public Movie AddMovie(Movie movie)
        {
            throw new System.NotImplementedException();
        }

        public Movie GetMovieById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Movie> GetMovies(out int totalCount)
        {
            totalCount = 1;

            return new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Name = "Fake Movie №1",
                    Year = "1999",
                    Country = "USA",
                    Director = "James Chameleon"
                }
            };
        }
    }
}
