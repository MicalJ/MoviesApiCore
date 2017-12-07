using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviesApi.Interfaces;
using MoviesApi.Models;

namespace MoviesApi.Controllers
{
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
            var movies = AutoMapper.Mapper.Map<MovieResponse>(_movieService.GetAll());

            return View(movies);
        }
    }
}