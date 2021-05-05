using System.Collections.Generic;
using System.Linq;
using MovieTheater.Core;
using MovieTheater.Core.Models;

namespace MovieTheater.Service
{
    public class FilmServices : IFilmServices
    {
        private readonly DataContext _context;
        public FilmServices(DataContext context)
        {
            _context = context;
        }
        public Film AddFilm(Film film)
        {
            _context.Films.Add(film);
            _context.SaveChanges();
            return film;
        }

        public void DeleteFilm(int filmId)
        {
            var film = _context.Films.FirstOrDefault(x => x.Id == filmId);
            if (film == null)
            {
                return;
            }
            _context.Films.Remove(film);
            _context.SaveChanges();
        }

        public Film EditFilm(int FilmId, Film film)
        {
            var filmEdit = _context.Films.FirstOrDefault(x => x.Id == film.Id);
            if (film == null)
            {
                return null;
            }
            filmEdit.RoomId = filmEdit.RoomId;
            filmEdit.Name = filmEdit.Name;
            filmEdit.Description = filmEdit.Description;
            filmEdit.Price = filmEdit.Price;
            _context.SaveChanges();
            return filmEdit;
        }

        public Film GetFilm(int filmId)
        {
            var film = _context.Films.FirstOrDefault(x => x.Id == filmId);
            if (film == null)
            {
                return null;
            }
            return film;
        }

        public List<Film> GetFilms()
        {
            return _context.Films.ToList();
        }
    }
}