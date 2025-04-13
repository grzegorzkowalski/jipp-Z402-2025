using FilmDB2.Data;
using FilmDB2.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmDB2.Repositories
{
    public class FilmManager
    {
        private FilmContext _context;
        public FilmManager(FilmContext context)
        {
            _context = context;
        }

        public FilmManager AddFilm(FilmModel filmModel)
        {
            _context.FilmModels.Add(filmModel);
            _context.SaveChanges();
            return this;
        }

        public FilmManager RemoveFilm(int id)
        {
            _context.FilmModels.Remove(GetFilm(id));
            _context.SaveChanges();
            return this;
        }

        public FilmManager UpdateFilm(FilmModel filmModel)
        {
            _context.FilmModels.Update(filmModel);
            _context.SaveChanges();
            return this;
        }

        public FilmManager ChangeTitle(int id, string newTitle)
        {
            return this;
        }

        public FilmModel GetFilm(int id)
        {
            var film = _context.FilmModels.SingleOrDefault(x => x.ID == id);
            return film;
        }

        public List<FilmModel> GetFilms()
        {
            var films = _context.FilmModels.ToList();
            return films;
        }
    }
}
