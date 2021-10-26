using eTickets.Data;
using eTickets.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService cinemasService;

        public CinemasController(ICinemasService cinemasService)
        {
            this.cinemasService = cinemasService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await cinemasService.GetAllAsync();

            return View(data);
        }
    }
}
