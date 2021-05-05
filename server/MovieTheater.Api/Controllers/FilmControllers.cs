using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MovieTheater.Core.Models;
using MovieTheater.Service;

namespace MovieTheater.Api.Controllers
{
    [Route("api/[controller]")]
    public class FilmController : ControllerBase
    {
        private readonly IFilmServices _filmServies;
        public FilmController(IFilmServices filmServices)
        {
            _filmServies = filmServices;
        }
        [HttpGet]
        public List<Film> Get()
        {
            return _filmServies.GetFilms();
        }
        [HttpGet("{filmID}")]
        public Film Get(int filmID)
        {
            return _filmServies.GetFilm(filmID);
        }
        [HttpPut("{filmID}")]
        public Film Put(int filmID, Film film)
        {
            return _filmServies.EditFilm(filmID, film);
        }
        [HttpPost]
        public Film Post(Film film)
        {
            return _filmServies.AddFilm(film);
        }
        [HttpDelete("{filmID}")]
        public void Delete(int filmID)
        {
            _filmServies.DeleteFilm(filmID);
        }
    }
}