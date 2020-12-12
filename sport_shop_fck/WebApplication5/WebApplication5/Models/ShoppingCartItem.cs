using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Good Good { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
