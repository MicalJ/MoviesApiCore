using MoviesDb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Interfaces
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetAll();

        Movie GetById(int id);

        void AddMovie(Movie movie);

        void UpdateMovie(Movie movie);

        void Remove(int id);
    }
}
