using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArch.Mvc.Controllers
{
    public class OffersController : Controller
    {
        private IOffersService _offersService;

        public OffersController(IOffersService offersService)
        {
            _offersService = offersService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            OffersViewModel model = _offersService.GetOffers();
            ViewData["OfferTitle"] = "Offers";
            return View(model);
        }

        // GET: /<controller>/
        public IActionResult Offers()
        {
            OffersViewModel model = _offersService.GetOffers();
            ViewData["OfferTitle"] = "Offers";
            return View(model);
        }
    }
}
