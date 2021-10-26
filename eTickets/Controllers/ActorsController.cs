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
            var data = await actorsService.GetAll();

            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("ProfilePictureURL,FullName,Bio")]Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }

            actorsService.Add(actor);

            return RedirectToAction(nameof(Index));
        }
    }
}
