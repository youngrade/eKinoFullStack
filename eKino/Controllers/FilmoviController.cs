﻿using eKino.Data;
using eKino.Models;
using Microsoft.AspNetCore.Mvc;
using Podaci.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Controllers
{
    public class FilmoviController : Controller
    {
        private ApplicationDbContext _db;
        public FilmoviController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Prikaz(int ID)
        {
            if (ID == 0)
            {
                List<FilmoviDodajVM> filmovi = _db.Film
                    .Select(f => new FilmoviDodajVM()
                    {
                        FilmID=f.ID,
                        FilmIme=f.Naziv,
                        SlikaURL=f.SlikaUrl,
                        Godina=f.Godina.ToString(),
                        Reditelj=f.Reditelj,
                        Glumci=f.Glumci,
                        Zanr= f.Zanr,
                        Trajanje=f.TrajanjeMinute.ToString(),
                        TrailerURL=f.TrailerUrl,
                        Info=f.Info
                    })
                    .OrderBy(f=>f.Godina)
                    .ThenBy(f=>f.FilmIme)
                    .ToList();
               
                FilmoviPrikazVM model = new FilmoviPrikazVM()
                {
                    Filmovi = filmovi
                };
                
                return View(model);
            }

            else
            {
                List<FilmoviDodajVM> filmovi = _db.Film
                    .Where(f => f.ID == ID)
                    .Select(f => new FilmoviDodajVM()
                    {
                        FilmID = ID,
                        FilmIme = f.Naziv,
                        SlikaURL = f.SlikaUrl,
                        Godina = f.Godina.ToString(),
                        Reditelj = f.Reditelj,
                        Glumci = f.Glumci,
                        Trajanje = f.TrajanjeMinute.ToString(),
                        TrailerURL=f.TrailerUrl,
                        Info = f.Info
                    })
                    .ToList();

                FilmoviPrikazVM model = new FilmoviPrikazVM()
                {
                    Filmovi = filmovi
                };

                return PartialView(model);
            }

        }
        public IActionResult Dodaj(int ID)
        {
            FilmoviDodajVM model = ID == 0 ? new FilmoviDodajVM() :
                _db.Film
                .Select(f => new FilmoviDodajVM()
                { 
                    FilmIme=f.Naziv,
                    Godina=f.Godina.ToString(),
                    Zanr=f.Zanr,
                    Reditelj=f.Reditelj,
                    Glumci=f.Glumci,
                    Trajanje=f.TrajanjeMinute.ToString(),
                    SlikaURL=f.SlikaUrl,
                    TrailerURL=f.TrailerUrl,
                    Info=f.Info
                })
                .Single();

            return View(model);
        }
        public IActionResult Snimi(FilmoviDodajVM model)
        {
            Film film=model.FilmID==0? new Film():
                _db.Film.Find(model.FilmID);

            film.Naziv = model.FilmIme;
            film.Godina = int.Parse(model.Godina);
            film.Reditelj = model.Reditelj;
            film.Glumci = model.Glumci;
            film.Zanr = model.Zanr;
            film.TrajanjeMinute = int.Parse(model.Trajanje);
            film.SlikaUrl = model.SlikaURL;
            film.TrailerUrl = model.TrailerURL;
            film.Info = model.Info;

            if(model.FilmID==0)
            {
                _db.Film.Add(film);
            }

            _db.SaveChanges();
            return Redirect("/Admin/Index");
        }
    }
}