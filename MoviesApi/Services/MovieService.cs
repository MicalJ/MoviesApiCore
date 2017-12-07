using MoviesApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesDb.DAL;

namespace MoviesApi.Services
{
    public class MovieService : IMovieService
    {
        public IEnumerable<Movie> GetAll()
        {
             using(MoviesApiDbContext db = new MoviesApiDbContext())
            {
                return db.Movies.ToArray();
            } 
        }

        public Movie GetById(int id)
        {
            using(MoviesApiDbContext db = new MoviesApiDbContext())
            {
                return db.Movies.Where(m => m.Id == id).SingleOrDefault();
            }
        }

        public void AddMovie(Movie movie)
        {
            using (MoviesApiDbContext db = new MoviesApiDbContext())
            {
                db.Movies.Add(movie);
                db.SaveChanges();
            }
        }

        public void UpdateMovie(Movie movie)
        {
            using (MoviesApiDbContext db = new MoviesApiDbContext())
            {
                db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Remove(int id)
        {
            using (MoviesApiDbContext db = new MoviesApiDbContext())
            {
                var movieId = db.Movies.Find(id);
                db.Movies.Remove(movieId);
                db.SaveChanges();
            }
        }
    }
}
