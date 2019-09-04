using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using MovieAPIProject.Models;
using NLog.Internal;

namespace MovieAPIProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly FavoriteMovieDbContext _context;
        private readonly IConfiguration _configuration;

        public HomeController(FavoriteMovieDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FavoriteMovieList()
        {
            List<FavoriteMovie> movieList = _context.FavoriteMovie.ToList();

            
            return View(movieList);
        }


        public IActionResult AddFavoriteMovies(Movie favoriteMovie) // change to movie
        {
            FavoriteMovie addedMovie = new FavoriteMovie();
            addedMovie.Title = favoriteMovie.Title;
            addedMovie.Year = int.Parse(favoriteMovie.Year);
            addedMovie.Genre = favoriteMovie.Genre;
            addedMovie.Director = favoriteMovie.Director;
            addedMovie.Actors = favoriteMovie.Actors;
            addedMovie.Plot = favoriteMovie.Plot;
            //string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            _context.FavoriteMovie.Add(addedMovie);
            _context.SaveChanges();
            
            return RedirectToAction("FavoriteMovieList");
        }

        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Search(string userInput)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://www.omdbapi.com");
            var apiKey = _configuration.GetSection("AppConfiguration")["APIKeyValue"];
            var response = await client.GetAsync($"?t={userInput}&apikey={apiKey}");
            var result = await response.Content.ReadAsAsync<Movie>();
            

            return View("List", result);
        }
        public IActionResult DeleteMovie(int Id)
        {

            FavoriteMovie found = _context.FavoriteMovie.Find(Id);
            if (ModelState.IsValid)
            {
                _context.FavoriteMovie.Remove(found);
                _context.SaveChanges();
            }
            return RedirectToAction("FavoriteMovieList");
        }
    }
}




