﻿using FilmDB2.Data;
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
            return View();
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
    }
}
