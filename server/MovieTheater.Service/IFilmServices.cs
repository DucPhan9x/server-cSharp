using System.Collections.Generic;
using MovieTheater.Core.Models;

namespace MovieTheater.Service
{
    public interface IFilmServices
    {
        public List<Film> GetFilms();
        public Film GetFilm(int filmId);
        public Film AddFilm(Film film);
        public Film EditFilm(int filmId, Film film);
        public void DeleteFilm(int filmId);
    }
}