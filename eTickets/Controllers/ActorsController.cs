using eTickets.Data;
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
        private readonly AppDbContext context;

        public ActorsController(AppDbContext dbContext)
        {
            context = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var data = await context.Actors.ToListAsync();

            return View(data);
        }
    }
}
