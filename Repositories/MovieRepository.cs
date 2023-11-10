using System.Collections.Generic;
using System.Linq;
using HelloWebApi.Database;
using HelloWebApi.Interfaces.Repositories;
using HelloWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWebApi.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DbSet<Movie> _dbSet;
        private readonly ApplicationDbContext _dbContext;

        public MovieRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Movies;
        }

        public Movie AddMovie(Movie movie)
        {
            _dbSet.Add(movie);
            _dbContext.SaveChanges();

            return movie;
        }

        public Movie GetMovieById(int id)
        {
            return _dbSet.SingleOrDefault(movie => movie.Id == id);
            /*
             * SELECT * FROM [Movies]
             * WHERE [Id] = @id;
             */
        }

        public List<Movie> GetMovies()
        {
            return _dbSet.ToList();
            /*
            * SELECT * FROM [Movies];
            */
        }

        public int GetMoviesTotalCount()
        {
            return _dbSet.Count();
            /*
            * SELECT COUNT(1) FROM [Movies];
            */
        }
    }
}
