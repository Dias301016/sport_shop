using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.ViewModels
{
    public class GoodsListViewModel
    {
        public IEnumerable<Good> Goods { get; set; }

        public string CurrentCategory { get; set; }
    }
}
