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
    public class ProducersController : Controller
    {
        private readonly IProducersService producersService;

        public ProducersController(IProducersService producersService)
        {
            this.producersService = producersService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await producersService.GetAllAsync();

            return View(data);
        }
    }
}
