using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;
using WebApplication5.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGoodRepository _goodRepository;

        public HomeController(IGoodRepository goodRepository)
        {
            _goodRepository = goodRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                GoodsOfTheWeek = _goodRepository.GoodsOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
