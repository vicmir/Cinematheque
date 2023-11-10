using System.Collections.Generic;
using System.Linq;
using HelloWebApi.Interfaces.Repositories;
using HelloWebApi.Models;

namespace HelloWebApi.Repositories
{
    public class FakeMovieRepository : IMovieRepository
    {
        private readonly List<Movie> _movies = new List<Movie>
        {
            new Movie
            {
                Id = 1,
                Name = "Fake Movie №1",
                Year = "1999",
                Country = "USA",
                Director = "James Chameleon"
            },
            new Movie
            {
                Id = 2,
                Name = "Fake Movie №2",
                Year = "2002",
                Country = "Germany",
                Director = "Christopher Noone"
            },
            new Movie
            {
                Id = 3,
                Name = "Fake Movie №3",
                Year = "2012",
                Country = "Ukraine",
                Director = "Steven Spleeberg"
            },
            new Movie
            {
                Id = 4,
                Name = "Fake Movie №4",
                Year = "2020",
                Country = "France",
                Director = "Quentin al Pachino"
            }
        };

        public Movie AddMovie(Movie movie)
        {
            movie.Id = _movies.Count + 1;

            _movies.Add(movie);

            return movie;
        }

        public Movie GetMovieById(int id)
        {
            return _movies.SingleOrDefault(movie => movie.Id == id);
        }

        public List<Movie> GetMovies()
        {
            return _movies;
        }

        public int GetMoviesTotalCount()
        {
            return _movies.Count;
        }
    }
}
