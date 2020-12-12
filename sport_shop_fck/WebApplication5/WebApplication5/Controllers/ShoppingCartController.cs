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
    public class ShoppingCartController : Controller
    {
        private readonly IGoodRepository _goodRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IGoodRepository goodRepository, ShoppingCart shoppingCart)
        {
            _goodRepository = goodRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int goodId)
        {
            var selectedGood = _goodRepository.AllGoods.FirstOrDefault(p => p.GoodId == goodId);

            if (selectedGood != null)
            {
                _shoppingCart.AddToCart(selectedGood, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int goodId)
        {
            var selectedGood = _goodRepository.AllGoods.FirstOrDefault(p => p.GoodId == goodId);

            if (selectedGood != null)
            {
                _shoppingCart.RemoveFromCart(selectedGood);
            }
            return RedirectToAction("Index");
        }
    }
}
