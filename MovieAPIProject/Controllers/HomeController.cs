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
        public HttpClient GetHttpClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://www.omdbapi.com");
            var apiKey = _configuration.GetSection("AppConfiguration")["APIKeyValue"];
            client.DefaultRequestHeaders.Add("??????", apiKey);
            return client;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SavedMovies()
        {

            List<FavoriteMovie> movieList = _context.FavoriteMovie.ToList();

            //List<Movie> favoriteMovies = new List<Movie>();
            //AspNetUsers thisUser = _context.AspNetUsers.Where(u => u.UserName == User.Identity.Name).First();

            //foreach (var item in movieList)
            //{
            //    if (id == item.)
            //    {
            //        favoriteMovies.Add(item);
            //    }
            //}
            // return View(favoriteMovies);
            return View(movieList);
        }

        public IActionResult AddFavoriteMovies()
        {
            return View();
        }

        public IActionResult AddFavoriteMovies(FavoriteMovie favoriteMovie)
        {
            string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            favoriteMovie.Title = id;
            if (ModelState.IsValid)
            {
                _context.FavoriteMovie.Add(favoriteMovie);
                _context.SaveChanges();
            }
            return RedirectToAction("AddFavoriteMovies");
        }

        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Search(string userInput)
        {
            //bool more = true;
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://www.omdbapi.com");
            //var movieList = new List<Movie>();
            var apiKey = _configuration.GetSection("AppConfiguration")["APIKeyValue"];
            var response = await client.GetAsync($"?t={userInput}&apikey={apiKey}");
            var result = await response.Content.ReadAsAsync<Movie>();
            //while (more)
            //{
            //    var result = await response.Content.ReadAsAsync<Movie>();
            //    movieList.Add(result);
            //    if (result != null)
            //    {
            //        more = true;
            //    }
            //}

            return View("List", result);
        }
    }
}



