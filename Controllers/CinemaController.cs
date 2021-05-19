using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;
namespace MvcMovie.Controllers
{
    public class CinemaController : Controller
    {
        private readonly MvcMovieContext _context;
        public CinemaController(MvcMovieContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> InforCGV(){
        IQueryable<Movie> movies = from m in _context.Movie
             join n in _context.Cinema on m.Id equals n.MId
             where n.CName == "CGV"
             select m; 
            var movieCinema = new Cinema
            {
                Movies = new List<Movie> (await movies.ToListAsync())
            };
            return View(movieCinema);
        }
        public async Task<IActionResult> InforLotte(){
        IQueryable<Movie> movies = from m in _context.Movie
             join n in _context.Cinema on m.Id equals n.MId
             where n.CName == "Lotte"
             select m; 
            var movieCinema = new Cinema
            {
                Movies = new List<Movie> (await movies.ToListAsync())
            };
            return View(movieCinema);
        }
        public async Task<IActionResult> InforBHD(){
        IQueryable<Movie> movies = from m in _context.Movie
             join n in _context.Cinema on m.Id equals n.MId
             where n.CName == "BHD"
             select m; 
            var movieCinema = new Cinema
            {
                Movies = new List<Movie> (await movies.ToListAsync())
            };
            return View(movieCinema);
        }
    }
}