using eTickets.Data;
using eTickets.Data.Interfaces;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService actorsService;

        public ActorsController(IActorsService actorsService)
        {
            this.actorsService = actorsService;
        }

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
        public async Task<IActionResult> Details(int id)
        {
            Actor actor = await actorsService.GetByIdAsync(id);

            if (actor is null) return View("Empty");

            return View(actor);
        }
    }
}
