using eTickets.Data.Interfaces;
using eTickets.Data.ViewModels;
using eTickets.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class MoviesController : Controller
    {
        private readonly IMoviesService moviesService;

        public MoviesController(IMoviesService moviesService)
        {
            this.moviesService = moviesService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data = await moviesService.GetAllAsync(n => n.Cinema);

            return View(data);
        }

        //GET: Movies/Create
        public async Task<IActionResult> Create()
        {
            var movieDropdownsData = await moviesService.GetNewMovieDropdownsValues();

            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "id", "FullName");

            return View();
        }

        //GET: Movies/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await moviesService.GetMovieByIdAsync(id);
            return View(movieDetail);
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewMovieVM movie)
        {
            if (!ModelState.IsValid)
            {
                var movieDropdownsData = await moviesService.GetNewMovieDropdownsValues();

                ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "id", "Name");
                ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "id", "FullName");
                ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "id", "FullName");

                return View(movie);
            }

            await moviesService.AddNewMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }

        //GET: Movies/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var movieDetails = await moviesService.GetMovieByIdAsync(id);
            if (movieDetails == null) return View("NotFound");

            var response = new NewMovieVM()
            {
                id = movieDetails.id,
                Name = movieDetails.Name,
                Description = movieDetails.Description,
                Price = movieDetails.Price,
                StartDate = movieDetails.StartDate,
                EndDate = movieDetails.EndDate,
                ImageURL = movieDetails.ImageURL,
                MovieCategory = movieDetails.MovieCategory,
                CinemaId = movieDetails.CinemaId,
                ProducerId = movieDetails.ProducerId,
                ActorIds = movieDetails.Actors_Movies.Select(n => n.ActorId).ToList(),
            };

            var movieDropdownsData = await moviesService.GetNewMovieDropdownsValues();
            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "id", "FullName");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewMovieVM movie)
        {
            if (id != movie.id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var movieDropdownsData = await moviesService.GetNewMovieDropdownsValues();

                ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "id", "Name");
                ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "id", "FullName");
                ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "id", "FullName");

                return View(movie);
            }

            await moviesService.UpdateMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Filter(string searchString)
        {
            var allMovies = await moviesService.GetAllAsync(n => n.Cinema);

            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = allMovies.Where(n => n.Name.Contains(searchString) || n.Description.Contains(searchString)).ToList();
                return View("Index", filteredResult);
            }

            return View("Index", allMovies);
        }
    }
}
