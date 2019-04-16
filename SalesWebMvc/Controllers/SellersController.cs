using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellersService _selersService;

        public SellersController(SellersService selersService)
        {
            _selersService = selersService;
        }

        public IActionResult Index()
        {
            var list = _selersService.FindAll();

            return View(list);
        }
    }
}