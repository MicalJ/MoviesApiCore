using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviesApi.Interfaces;
using MoviesApi.Models;
using MoviesDb.DAL;

namespace MoviesApi.Controllers
{
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var movies = AutoMapper.Mapper.Map<IEnumerable<MovieResponse>>(_movieService.GetAll());

            return View(movies);
        }

        [HttpGet("{movieId}")]
        public IActionResult GetById(int movieId)
        {
            var movie = AutoMapper.Mapper.Map<MovieResponse>(_movieService.GetById(movieId));

            return View(movie);
        }

        [HttpPost]
        public IActionResult Post([FromBody]MovieRequest movie)
        {
             _movieService.AddMovie(AutoMapper.Mapper.Map<Movie>(movie));

            return RedirectToAction("Get");
        }

        [HttpPut("{movieId}")]
        public IActionResult Put(int movieId ,[FromBody]MovieRequest movieRequest)
        {
            var movie = AutoMapper.Mapper.Map<Movie>(movieRequest);
            movie.Id = movieId;
            _movieService.UpdateMovie(movie);

            return RedirectToAction("Get");
        }

        [HttpDelete("{movieId}")]
        public IActionResult Delete(int movieId)
        {
            _movieService.Remove(movieId);

            return RedirectToAction("Get");
        }
    }
}