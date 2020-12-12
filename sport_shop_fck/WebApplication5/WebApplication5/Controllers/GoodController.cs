using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;
using WebApplication5.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication5.Controllers
{
    public class GoodController : Controller
    {
        private readonly IGoodRepository _goodRepository;
        private readonly ICategoryRepository _categoryRepository;

        public GoodController(IGoodRepository goodRepository, ICategoryRepository categoryRepository)
        {
            _goodRepository = goodRepository;
            _categoryRepository = categoryRepository;
        }
        public ViewResult List(string category)
        {
            IEnumerable<Good> goods;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                goods = _goodRepository.AllGoods.OrderBy(p => p.GoodId);
                currentCategory = "All goods";
            }
            else
            {
                goods = _goodRepository.AllGoods.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.GoodId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new GoodsListViewModel
            {
                Goods = goods,
                CurrentCategory = currentCategory
            });
        }


        public IActionResult Details(int id)
        {
            var good = _goodRepository.GetGoodById(id);
            if (good == null)
                return NotFound();

            return View(good);
        }
    }
}
