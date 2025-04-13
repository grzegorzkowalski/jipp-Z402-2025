using FilmDB2.Data;
using FilmDB2.Models;
using FilmDB2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FilmDB2.Controllers
{
    public class FilmController : Controller
    {
        private FilmManager _manager;

        public FilmController(FilmManager manager) 
        { 
            _manager = manager;
        }
        public IActionResult Index()
        {
            var films = _manager.GetFilms();
            return View(films);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(FilmModel film)
        {
            _manager.AddFilm(film);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var film = _manager.GetFilm(id);
            return View(film);
        }

        [HttpPost]
        public IActionResult Remove(int id)
        {
            try
            {
                _manager.RemoveFilm(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return RedirectToAction("Delete" , id);
            }       
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var film = _manager.GetFilm(id);
            return View(film);
        }

        [HttpPost]
        public IActionResult Edit(FilmModel filmModel)
        {
            try
            {
                _manager.UpdateFilm(filmModel);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(filmModel);
            }
        }
    }
}
