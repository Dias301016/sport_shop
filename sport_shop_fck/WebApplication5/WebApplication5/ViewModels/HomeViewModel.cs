using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Good> GoodsOfTheWeek { get; set; }
    }
}
