﻿using eKino.Data;
using eKino.Helper_Metode;
using eKino.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Podaci.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Controllers
{
    public class PonudaController : Controller
    {
        private readonly UserManager<Korisnik> _userManager;
        private readonly SignInManager<Korisnik> _signInManager;
        private ApplicationDbContext _db;
        public PonudaController(ApplicationDbContext db, UserManager<Korisnik> userManager, SignInManager<Korisnik> signInManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Prikaz(int dan)
        {
            //DateTime d = new DateTime(2021, 1, 1);
            //int o = (int)(d.Date - DateTime.Today).TotalDays;
            List<PonudaPrikazVM.Row> ponuda = _db.Projekcija
                .Where(p=>p.Datum >= DateTime.Now)
                .Select(p => new PonudaPrikazVM.Row()
                {
                    ID = p.ID,
                    Film = p.Film.Naziv,
                    FilmID=p.FilmID,
                    Datum = p.Datum,
                    Godina = p.Film.Godina.ToString(),
                    Zanr = p.Film.Zanr,
                    Glumci = p.Film.Glumci,
                    Reditelj = p.Film.Reditelj,
                    SlikaUrl = p.Film.SlikaUrl,
                    Trajanje=p.Film.TrajanjeMinute.ToString(),
                    Sala=p.Sala.Oznaka,
                    DanUSedmini=HelperMetode.DanUsedmiciBosanski(p.Datum),
                    Cijena=p.Cijena
                })
                .ToList();

            var termini = new List<PonudaPrikazVM.Termin>();
            foreach(var p in ponuda)
            {
                if ((int)(p.Datum - DateTime.Today).TotalDays == dan &&
                    /*p.Datum > DateTime.Now*/ DateTime.Now<p.Datum.AddMinutes(int.Parse(p.Trajanje)))
                {
                var t = new PonudaPrikazVM.Termin();
                t.FilmID = p.FilmID;
                t.Vrijeme = p.Datum;
                termini.Add(t);
                }
            }

            ponuda = ponuda
                .Where(p => (int)(p.Datum.Date - DateTime.Today).TotalDays == dan && //gleda razliku između danas i datuma projekcije
                p.Datum.AddMinutes(int.Parse(p.Trajanje)) > DateTime.Now) //gleda je li prošlo to vrijeme
                .ToList();

            ponuda = ponuda.GroupBy(x=>x.FilmID).Select(x => x.First()).ToList();

            PonudaPrikazVM m = new PonudaPrikazVM()
            {
                Ponuda = ponuda,
                dan = dan,
                Termini=termini.OrderBy(t=>t.Vrijeme).ToList()
            };
            return PartialView(m);
        }
    }
}
