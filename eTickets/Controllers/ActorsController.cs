using eTickets.Data.Interfaces;
using eTickets.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    [Authorize]
    public class ActorsController : Controller
    {
        private readonly IActorsService actorsService;

        public ActorsController(IActorsService actorsService)
        {
            this.actorsService = actorsService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data = await actorsService.GetAllAsync();

            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")]Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }

            await actorsService.AddAsync(actor);

            return RedirectToAction(nameof(Index));
        }

        //  Actors/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            Actor actor = await actorsService.GetByIdAsync(id);

            if (actor is null) return View("NotFound");

            return View(actor);
        }

        public async Task<IActionResult> Edit(int id)
        {
            Actor actor = await actorsService.GetByIdAsync(id);

            if (actor is null) return View("NotFound");

            return View(actor);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("id,ProfilePictureURL,FullName,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            await actorsService.UpdateAsync(id, actor);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Actor actor = await actorsService.GetByIdAsync(id);

            if (actor is null) return View("NotFound");

            return View(actor);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Actor actor = await actorsService.GetByIdAsync(id);

            if (actor is null) return View("NotFound");

            await actorsService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
